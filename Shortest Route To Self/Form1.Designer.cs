namespace Shortest_Route_To_Self
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ansShort = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.txtBox_filePath = new System.Windows.Forms.TextBox();
            this.dataGridViewCsv = new System.Windows.Forms.DataGridView();
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.label_ansLong = new System.Windows.Forms.Label();
            this.label_routeShort = new System.Windows.Forms.Label();
            this.label_routeLong = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ansShort
            // 
            this.label_ansShort.AutoSize = true;
            this.label_ansShort.Location = new System.Drawing.Point(37, 412);
            this.label_ansShort.Name = "label_ansShort";
            this.label_ansShort.Size = new System.Drawing.Size(65, 13);
            this.label_ansShort.TabIndex = 0;
            this.label_ansShort.Text = "Lowest Cost";
            this.label_ansShort.Visible = false;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(294, 383);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Visible = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Location = new System.Drawing.Point(551, 54);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(75, 23);
            this.btn_loadFile.TabIndex = 2;
            this.btn_loadFile.Text = "Choose File";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // txtBox_filePath
            // 
            this.txtBox_filePath.Location = new System.Drawing.Point(15, 56);
            this.txtBox_filePath.Name = "txtBox_filePath";
            this.txtBox_filePath.Size = new System.Drawing.Size(415, 20);
            this.txtBox_filePath.TabIndex = 3;
            // 
            // dataGridViewCsv
            // 
            this.dataGridViewCsv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCsv.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewCsv.Name = "dataGridViewCsv";
            this.dataGridViewCsv.Size = new System.Drawing.Size(626, 254);
            this.dataGridViewCsv.TabIndex = 4;
            // 
            // lbl_filePath
            // 
            this.lbl_filePath.AutoSize = true;
            this.lbl_filePath.Location = new System.Drawing.Point(28, 41);
            this.lbl_filePath.Name = "lbl_filePath";
            this.lbl_filePath.Size = new System.Drawing.Size(181, 13);
            this.lbl_filePath.TabIndex = 6;
            this.lbl_filePath.Text = "CSV File Path (Ex:  c:\\temp\\test.csv)";
            // 
            // label_ansLong
            // 
            this.label_ansLong.AutoSize = true;
            this.label_ansLong.Location = new System.Drawing.Point(395, 412);
            this.label_ansLong.Name = "label_ansLong";
            this.label_ansLong.Size = new System.Drawing.Size(67, 13);
            this.label_ansLong.TabIndex = 7;
            this.label_ansLong.Text = "Highest Cost";
            this.label_ansLong.Visible = false;
            // 
            // label_routeShort
            // 
            this.label_routeShort.AutoSize = true;
            this.label_routeShort.Location = new System.Drawing.Point(37, 383);
            this.label_routeShort.Name = "label_routeShort";
            this.label_routeShort.Size = new System.Drawing.Size(35, 13);
            this.label_routeShort.TabIndex = 8;
            this.label_routeShort.Text = "label1";
            this.label_routeShort.Visible = false;
            // 
            // label_routeLong
            // 
            this.label_routeLong.AutoSize = true;
            this.label_routeLong.Location = new System.Drawing.Point(395, 383);
            this.label_routeLong.Name = "label_routeLong";
            this.label_routeLong.Size = new System.Drawing.Size(35, 13);
            this.label_routeLong.TabIndex = 9;
            this.label_routeLong.Text = "label1";
            this.label_routeLong.Visible = false;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(12, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(627, 13);
            this.label_info.TabIndex = 10;
            this.label_info.Text = "This App determines Lowest and Highest Cost of circuits of node \'A\' in a Weighted" +
    " Complete Graph where the Pure Cost is positive. ";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(15, 344);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(478, 13);
            this.label_note.TabIndex = 11;
            this.label_note.Text = "Note: A Node can only be traversed Once and Two Nodes must be traversed before re" +
    "turning to \'A\'.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 452);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_routeLong);
            this.Controls.Add(this.label_routeShort);
            this.Controls.Add(this.label_ansLong);
            this.Controls.Add(this.lbl_filePath);
            this.Controls.Add(this.dataGridViewCsv);
            this.Controls.Add(this.txtBox_filePath);
            this.Controls.Add(this.btn_loadFile);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label_ansShort);
            this.Name = "Form1";
            this.Text = "Cost of Circuit of A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ansShort;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.TextBox txtBox_filePath;
        private System.Windows.Forms.DataGridView dataGridViewCsv;
        private System.Windows.Forms.Label lbl_filePath;
        private System.Windows.Forms.Label label_ansLong;
        private System.Windows.Forms.Label label_routeShort;
        private System.Windows.Forms.Label label_routeLong;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_note;
    }
}

