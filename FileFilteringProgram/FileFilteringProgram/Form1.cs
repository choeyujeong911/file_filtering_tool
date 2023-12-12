using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilteringProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string org_path;
        public Keys[] keys = new Keys[10];
        public string[] paths = new string[10];
        public string[] filters = new string[10];
        int num = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            using (folderBrowserDialog1 = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
                {
                    DisplayOrgFolder(folderBrowserDialog1.SelectedPath);
                }
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddSaveFolder2List(tb_key.Text, tb_path.Text, tb_name.Text);
            Keys shtcut;
            switch(Char.ToUpper(Convert.ToChar(tb_key.Text)))
            {
                case 'A': shtcut = Keys.A; break;
                case 'B': shtcut = Keys.B; break;
                case 'C': shtcut = Keys.C; break;
                case 'D': shtcut = Keys.D; break;
                case 'E': shtcut = Keys.E; break;
                case 'F': shtcut = Keys.F; break;
                case 'G': shtcut = Keys.G; break;
                case 'H': shtcut = Keys.H; break;
                case 'I': shtcut = Keys.I; break;
                case 'J': shtcut = Keys.J; break;
                case 'K': shtcut = Keys.K; break;
                case 'L': shtcut = Keys.L; break;
                case 'M': shtcut = Keys.M; break;
                case 'N': shtcut = Keys.N; break;
                case 'O': shtcut = Keys.O; break;
                case 'P': shtcut = Keys.P; break;
                case 'Q': shtcut = Keys.Q; break;
                case 'R': shtcut = Keys.R; break;
                case 'S': shtcut = Keys.S; break;
                case 'T': shtcut = Keys.T; break;
                case 'U': shtcut = Keys.U; break;
                case 'V': shtcut = Keys.V; break;
                case 'W': shtcut = Keys.W; break;
                case 'X': shtcut = Keys.X; break;
                case 'Y': shtcut = Keys.Y; break;
                case 'Z': shtcut = Keys.Z; break;
                default: shtcut = Keys.None; break;
            }
            this.keys[num] = shtcut;
            this.paths[num] = tb_path.Text;
            this.filters[num] = tb_name.Text;
            
            tb_key.Text = string.Empty;
            tb_path.Text = string.Empty;
            tb_name.Text = string.Empty;
            num++;
        }
        private void DisplayOrgFolder(string folderPath)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            ColumnHeader colHeader = new ColumnHeader();
            colHeader.Text = "Path";
            colHeader.Width = 600;
            listView1.Columns.Add(colHeader);
            ListViewItem item = new ListViewItem();
            item.Text = folderPath;
            this.org_path = folderPath;
            listView1.Items.Add(item);
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            using (folderBrowserDialog1 = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
                {
                    tb_path.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        private void AddSaveFolder2List(string key, string folderPath, string name)
        {
            ListViewItem item = new ListViewItem();
            item.Text = folderPath;
            AddRow(key, folderPath, name);
        }
        private void AddRow(string key, string path, string name)
        {
            // ListViewItem을 생성하고 데이터를 설정합니다.
            ListViewItem item = new ListViewItem(key);
            item.SubItems.Add(path);
            item.SubItems.Add(name);

            // ListView에 행을 추가합니다.
            listView2.Items.Add(item);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.org_path, this.keys, this.paths, this.filters);
            form2.ShowDialog();
            this.Focus();
        }
    }
}
