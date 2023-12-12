namespace FileFilteringProgram
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.viewer = new System.Windows.Forms.PictureBox();
            this.shtcut_list = new System.Windows.Forms.ListView();
            this.col_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_file_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.Location = new System.Drawing.Point(12, 12);
            this.viewer.Name = "viewer";
            this.viewer.Size = new System.Drawing.Size(757, 569);
            this.viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewer.TabIndex = 0;
            this.viewer.TabStop = false;
            // 
            // shtcut_list
            // 
            this.shtcut_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_key,
            this.col_name});
            this.shtcut_list.GridLines = true;
            this.shtcut_list.HideSelection = false;
            this.shtcut_list.Location = new System.Drawing.Point(775, 66);
            this.shtcut_list.Name = "shtcut_list";
            this.shtcut_list.Size = new System.Drawing.Size(159, 493);
            this.shtcut_list.TabIndex = 1;
            this.shtcut_list.TabStop = false;
            this.shtcut_list.UseCompatibleStateImageBehavior = false;
            this.shtcut_list.View = System.Windows.Forms.View.Details;
            // 
            // col_key
            // 
            this.col_key.Text = "Key";
            this.col_key.Width = 40;
            // 
            // col_name
            // 
            this.col_name.Text = "Filter Name";
            this.col_name.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shortcut Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Name";
            // 
            // tb_file_name
            // 
            this.tb_file_name.Location = new System.Drawing.Point(777, 27);
            this.tb_file_name.Name = "tb_file_name";
            this.tb_file_name.ReadOnly = true;
            this.tb_file_name.Size = new System.Drawing.Size(157, 21);
            this.tb_file_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num of Data: ";
            // 
            // data_num
            // 
            this.data_num.Location = new System.Drawing.Point(859, 565);
            this.data_num.Name = "data_num";
            this.data_num.ReadOnly = true;
            this.data_num.Size = new System.Drawing.Size(75, 21);
            this.data_num.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 593);
            this.Controls.Add(this.data_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_file_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shtcut_list);
            this.Controls.Add(this.viewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Start Filtering";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viewer;
        private System.Windows.Forms.ListView shtcut_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader col_key;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_file_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox data_num;
    }
}