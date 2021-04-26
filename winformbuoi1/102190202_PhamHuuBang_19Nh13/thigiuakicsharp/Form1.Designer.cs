
namespace thigiuakicsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.cbTG = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ten NXB";
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(6, 111);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.RowHeadersWidth = 62;
            this.dataGridViewSach.RowTemplate.Height = 28;
            this.dataGridViewSach.Size = new System.Drawing.Size(755, 242);
            this.dataGridViewSach.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(536, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "id",
            "Ten"});
            this.cbSort.Location = new System.Drawing.Point(639, 364);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 28);
            this.cbSort.TabIndex = 2;
            // 
            // cbNXB
            // 
            this.cbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(106, 46);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(153, 28);
            this.cbNXB.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(678, 43);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(83, 36);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(517, 364);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(83, 36);
            this.btSort.TabIndex = 0;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(397, 364);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(83, 36);
            this.btDel.TabIndex = 0;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(262, 364);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(83, 36);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(6, 364);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(83, 36);
            this.btShow.TabIndex = 0;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(132, 364);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 36);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridViewSach);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.cbSort);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.cbTG);
            this.groupBox2.Controls.Add(this.cbNXB);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.btSort);
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btShow);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 414);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ten TG";
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1059, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 36);
            this.button7.TabIndex = 0;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cbTG
            // 
            this.cbTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTG.FormattingEnabled = true;
            this.cbTG.Location = new System.Drawing.Point(350, 49);
            this.cbTG.Name = "cbTG";
            this.cbTG.Size = new System.Drawing.Size(153, 28);
            this.cbTG.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTG;
    }
}

