
namespace baitapquanlysinhvien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewsv = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.cbLophp = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridViewsv);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.cbSort);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.cbLophp);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.btSort);
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btShow);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 414);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lop HP";
            // 
            // dataGridViewsv
            // 
            this.dataGridViewsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsv.Location = new System.Drawing.Point(6, 111);
            this.dataGridViewsv.Name = "dataGridViewsv";
            this.dataGridViewsv.RowHeadersWidth = 62;
            this.dataGridViewsv.RowTemplate.Height = 28;
            this.dataGridViewsv.Size = new System.Drawing.Size(755, 242);
            this.dataGridViewsv.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1210, 43);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 26);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(790, -129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 26);
            this.textBox6.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(504, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "MSSV",
            "Ten SV"});
            this.cbSort.Location = new System.Drawing.Point(510, 359);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 28);
            this.cbSort.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1059, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 36);
            this.button7.TabIndex = 0;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cbLophp
            // 
            this.cbLophp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLophp.FormattingEnabled = true;
            this.cbLophp.Location = new System.Drawing.Point(104, 41);
            this.cbLophp.Name = "cbLophp";
            this.cbLophp.Size = new System.Drawing.Size(121, 28);
            this.cbLophp.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(639, 41);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(83, 36);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(359, 359);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(83, 36);
            this.btSort.TabIndex = 0;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(248, 359);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(83, 36);
            this.btDel.TabIndex = 0;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(142, 359);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(83, 36);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(235, 39);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(83, 36);
            this.btShow.TabIndex = 0;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(28, 359);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 36);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewsv;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cbLophp;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
    }
}

