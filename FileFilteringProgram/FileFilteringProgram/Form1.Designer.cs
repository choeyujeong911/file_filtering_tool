namespace FileFilteringProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbox_up = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.col_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbox_under = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpbox_up.SuspendLayout();
            this.grpbox_under.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_up
            // 
            this.grpbox_up.Controls.Add(this.listView2);
            this.grpbox_up.Controls.Add(this.listView1);
            this.grpbox_up.Controls.Add(this.label4);
            this.grpbox_up.Controls.Add(this.label3);
            this.grpbox_up.Location = new System.Drawing.Point(13, 12);
            this.grpbox_up.Name = "grpbox_up";
            this.grpbox_up.Size = new System.Drawing.Size(663, 540);
            this.grpbox_up.TabIndex = 0;
            this.grpbox_up.TabStop = false;
            this.grpbox_up.Text = "Filter Design";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_key,
            this.col_path,
            this.col_name});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(7, 217);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(650, 317);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // col_key
            // 
            this.col_key.Text = "Shortcut Key";
            this.col_key.Width = 100;
            // 
            // col_path
            // 
            this.col_path.Text = "Path";
            this.col_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_path.Width = 390;
            // 
            // col_name
            // 
            this.col_name.Text = "Filter Name";
            this.col_name.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.path});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 160);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 500;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Save Folders Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Folder Path";
            // 
            // grpbox_under
            // 
            this.grpbox_under.Controls.Add(this.tb_name);
            this.grpbox_under.Controls.Add(this.label5);
            this.grpbox_under.Controls.Add(this.add_btn);
            this.grpbox_under.Controls.Add(this.label2);
            this.grpbox_under.Controls.Add(this.tb_path);
            this.grpbox_under.Controls.Add(this.tb_key);
            this.grpbox_under.Controls.Add(this.label1);
            this.grpbox_under.Controls.Add(this.start_btn);
            this.grpbox_under.Controls.Add(this.select_btn);
            this.grpbox_under.Controls.Add(this.open_btn);
            this.grpbox_under.Location = new System.Drawing.Point(13, 558);
            this.grpbox_under.Name = "grpbox_under";
            this.grpbox_under.Size = new System.Drawing.Size(663, 129);
            this.grpbox_under.TabIndex = 4;
            this.grpbox_under.TabStop = false;
            this.grpbox_under.Text = "Set Filter Options";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(198, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(137, 21);
            this.tb_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Filter Name";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(6, 17);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(110, 48);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add Save Folder";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path of Folder";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(341, 46);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(316, 21);
            this.tb_path.TabIndex = 5;
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(236, 20);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(99, 21);
            this.tb_key.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter Key Shortcut";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.start_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_btn.Location = new System.Drawing.Point(6, 73);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(111, 47);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start to Sort";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(341, 73);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(316, 47);
            this.select_btn.TabIndex = 1;
            this.select_btn.Text = "Select Folder to Save Data";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(123, 73);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(212, 47);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open Data Folder";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 699);
            this.Controls.Add(this.grpbox_under);
            this.Controls.Add(this.grpbox_up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Filter Program for Annotation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbox_up.ResumeLayout(false);
            this.grpbox_up.PerformLayout();
            this.grpbox_under.ResumeLayout(false);
            this.grpbox_under.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbox_up;
        private System.Windows.Forms.GroupBox grpbox_under;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader col_key;
        private System.Windows.Forms.ColumnHeader col_path;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
    }
}

