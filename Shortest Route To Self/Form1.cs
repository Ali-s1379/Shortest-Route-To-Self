using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shortest_Route_To_Self
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly List<string[]> routes = new List<string[]>();
        private static readonly List<string> steps = new List<string>();
        private static readonly List<string[]> csvFile = new List<string[]>();

        private static bool CheckListEqual(string[][] a,string[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i][j] == b[j]) 
                        counter++;
                    if (counter == b.Length)
                        return true;
                    
                }
            }
            return false;
        }

        static void addToList(string[] a, int size)
        {
            for (int i = 0; i < size; i++)
                steps.Add(a[i]);

            string[] t = steps.ToArray();
            string[][] s = routes.ToArray();
            if (!CheckListEqual(s,t))
            {
                routes.Add(steps.ToArray());
            } 
            steps.Clear();
        }

        static void HeapPermutation(string[] a, int n, int size)
        {
            if (n == 1)
                addToList(a, size);

            for (int i = 0; i < n; i++)
            {
                HeapPermutation(a, n - 1, size);
                if (n % 2 == 1)
                {
                    string temp = a[0];
                    a[0] = a[n - 1];
                    a[n - 1] = temp;
                }
                else
                {
                    string temp = a[i];
                    a[i] = a[n - 1];
                    a[n - 1] = temp;
                }
            }
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            btn_calculate.Visible = false;
            string[][] input = csvFile.ToArray();
            int inputRow = input.GetLength(0);
            List<string> nodes = new List<string>();
            for (int i = 0; i < inputRow; i++)
            {
                if (!nodes.Contains(input[i][0]))
                {
                    nodes.Add(input[i][0]);
                }
                if (!nodes.Contains(input[i][1]))
                {
                    nodes.Add((input[i][1]));
                }
            }

            nodes.Remove("A");
            string[] finalNodes = nodes.ToArray();
            List<string[]> allRoutes = new List<string[]>();

            for (int i = 2;i <= finalNodes.Length; i++)
            {
                HeapPermutation(finalNodes, finalNodes.Length, i);
                allRoutes.AddRange(routes);
                routes.Clear();
            }

            string[][] finalRoutes = allRoutes.ToArray();
            float[] cost = new float[finalRoutes.Length];
            float[] pureCost = new float[finalRoutes.Length];           
            string check1 = "A";
            string check2;

            for (int i = 0;i < finalRoutes.Length; i++)
            {
                for (int j = 0;j <= finalRoutes[i].Length; j++)
                {
                    if (j == finalRoutes[i].Length)
                    {
                        check2 = "A";
                    }
                    else check2 = finalRoutes[i][j];

                    for (int t = 0; t < inputRow; t++)
                    {
                        if ((input[t][0] == check1 && input[t][1] == check2) || (input[t][0] == check2 && input[t][1] == check1))
                        {
                            cost[i] += float.Parse(input[t][2], CultureInfo.InvariantCulture);
                            pureCost[i] += float.Parse(input[t][3], CultureInfo.InvariantCulture);
                            check1 = check2;
                        }

                    }
                }
                
            }
            while (true)
            {
                float minCost = cost.AsQueryable().Min();
                int indexMin = Array.IndexOf(cost, minCost);
                if (pureCost[indexMin] < 0)
                {
                    cost = cost.Where((source, index) => index != indexMin).ToArray();
                    pureCost = pureCost.Where((source, index) => index != indexMin).ToArray();
                    finalRoutes = finalRoutes.Where((source, index) => index != indexMin).ToArray();
                }
                else
                {
                    string route = "Route: A => ";
                    foreach (string step in finalRoutes[indexMin])
                    {
                        route = route + step + " => ";
                    }
                    route = route + "A";
                    label_routeShort.Text = route;
                    label_routeShort.Visible = true;
                    label_ansShort.Text = "The Lowest Cost is: " + minCost;
                    label_ansShort.Visible = true;
                    break;
                }
                    
            }
            while (true)
            {
                float maxCost = cost.AsQueryable().Max();
                int indexMax = Array.IndexOf(cost, maxCost);
                if (pureCost[indexMax] < 0)
                {
                    cost = cost.Where((source, index) => index != indexMax).ToArray();
                    pureCost = pureCost.Where((source, index) => index != indexMax).ToArray();
                    finalRoutes = finalRoutes.Where((source, index) => index != indexMax).ToArray();
                }
                else
                {
                    string route = "Route: A => ";
                    foreach (string step in finalRoutes[indexMax])
                    {
                        route = route + step + " => ";
                    }
                    route = route + "A";
                    label_routeLong.Text = route;
                    label_routeLong.Visible = true;
                    label_ansLong.Text = "The Highest Cost is: " + maxCost;
                    label_ansLong.Visible = true;
                    break;
                }
            }
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            csvFile.Clear();
            routes.Clear();
            steps.Clear();
            label_ansLong.Visible=false;
            label_ansShort.Visible=false;
            label_routeLong.Visible=false;
            label_routeShort.Visible=false;
            string filePath = txtBox_filePath.Text;
            using (TextFieldParser parser = new TextFieldParser(@filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("First Node"));
                dt.Columns.Add(new DataColumn("Second Node"));
                dt.Columns.Add(new DataColumn("Cost"));
                dt.Columns.Add(new DataColumn("Pure Cost"));

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    csvFile.Add(fields);
                    dt.Rows.Add();
                    int i = 0;
                    foreach (string cell in fields)
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
                dataGridViewCsv.DataSource = dt;
                btn_calculate.Visible = true;
            }
        }
    }
}

