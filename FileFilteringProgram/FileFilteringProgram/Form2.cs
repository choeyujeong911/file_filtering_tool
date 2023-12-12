using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

/* 비정상적인 종료(cnt 문제인 듯) 수정 필요 */
namespace FileFilteringProgram
{
    public partial class Form2 : Form
    {
        public string path;
        public Keys[] shtcuts = new Keys[10];
        public string[] save_paths = new string[10];
        public string[] names = new string[10];
        public string[] imgFiles;
        private int current = 0;
        public int cnt;
        public int total;

        public Form2(string org_path, Keys[] keys, string[] paths, string[] filters)
        {
            
            this.path = org_path;
            Array.Copy(keys, this.shtcuts, 10);
            Array.Copy(paths, this.save_paths, 10);
            Array.Copy(filters, this.names, 10);
            this.total = GetFileCount(org_path);

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;
            LoadImgFiles();
            ShowCurrentImg();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Text = "Start Filtering " + this.path;
            this.cnt = GetFileCount(this.path);
            data_num.Text = Convert.ToString(cnt);
            for (int i = 0; i < 10; i++)
            {
                string key = GetAlphabetFromKeys(shtcuts[i]);
                ListViewItem item = new ListViewItem(key);
                item.SubItems.Add(names[i]);
                shtcut_list.Items.Add(item);
            }
        }
        private void Form2_Activated(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void LoadImgFiles()
        {
            try
            {
                this.imgFiles = Directory.GetFiles(this.path, "*.jpeg");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No author to open data.");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("No such Folder.");
            }
        }

        private int GetFileCount(string path)
        {
            try
            {
                return Directory.GetFiles(path).Length;
            }
            catch (UnauthorizedAccessException)
            {
                return -1;
            }
            catch (DirectoryNotFoundException)
            {
                return -1;
            }
        }

        private void ShowCurrentImg()
        {
            if (imgFiles != null && imgFiles.Length > 0 && current < imgFiles.Length)
            {
                viewer.ImageLocation = imgFiles[current];
                tb_file_name.Text = imgFiles[current];
            }
        }

        private void ShowNextImg()
        {
            if (current < imgFiles.Length - 1)
            {
                current++;
                ShowCurrentImg();
            }
        }
        private void ShowPreviousImg()
        {
            if (current > 0)
            {
                current--;
                ShowCurrentImg();
            }
        }
        private void DeleteCurrentImg()
        {
            if (imgFiles != null && imgFiles.Length > 0 && current >= 0 && current < imgFiles.Length)
            {
                try
                {
                    File.Delete(imgFiles[current]);
                    LoadImgFiles();
                    current = Math.Max(current - 1, 0);
                    ShowCurrentImg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Image Delete Error: {ex.Message}");
                }
            }
        }
        private void SortImg(int index)
        {
            try
            {
                string currentFileName = Path.GetFileName(imgFiles[current]);
                string destinationFilePath = Path.Combine(save_paths[index], currentFileName);
                File.Move(imgFiles[current], destinationFilePath);
                LoadImgFiles();
                ShowNextImg();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Image Move Error: {ex.Message}");
            }
        }
        private void CloseForm2()
        {
            if(cnt == 0)
            {
                MessageBox.Show("Filtering End ! !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["Form2"].Close();
            }
        }
        private string GetCurrentImageFileName()
        {
            if (imgFiles != null && current >= 0 && current < imgFiles.Length)
            {
                return Path.GetFileName(imgFiles[current]);
            }
            return null;
        }
        public static string GetAlphabetFromKeys(Keys key)
        {
            // Keys 열거형의 값과 알파벳 매핑
            switch (key)
            {
                case Keys.A: return "A";
                case Keys.B: return "B";
                case Keys.C: return "C";
                case Keys.D: return "D";
                case Keys.E: return "E";
                case Keys.F: return "F";
                case Keys.G: return "G";
                case Keys.H: return "H";
                case Keys.I: return "I";
                case Keys.J: return "J";
                case Keys.K: return "K";
                case Keys.L: return "L";
                case Keys.M: return "M";
                case Keys.N: return "N";
                case Keys.O: return "O";
                case Keys.P: return "P";
                case Keys.Q: return "Q";
                case Keys.R: return "R";
                case Keys.S: return "S";
                case Keys.T: return "T";
                case Keys.U: return "U";
                case Keys.V: return "V";
                case Keys.W: return "W";
                case Keys.X: return "X";
                case Keys.Y: return "Y";
                case Keys.Z: return "Z";

                default: return string.Empty; // 알파벳이 아닌 경우 빈 문자열 반환
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Key pressed: {e.KeyCode}");
            bool keyExists = Array.Exists(this.shtcuts, key => key == e.KeyCode);
            if (keyExists)
            {
                int keyIndex = Array.IndexOf(shtcuts, e.KeyCode);
                SortImg(keyIndex);
                CloseForm2();
                this.cnt = GetFileCount(this.path);
                data_num.Text = Convert.ToString(cnt);
                tb_file_name.Text = GetCurrentImageFileName();
            }
            else if (e.KeyCode == Keys.Left)
            {
                ShowPreviousImg();
                this.cnt = GetFileCount(this.path);
                data_num.Text = Convert.ToString(cnt);
                tb_file_name.Text = GetCurrentImageFileName();
            }
            else if (e.KeyCode == Keys.Right)
            {
                ShowNextImg();
                CloseForm2();
                this.cnt = GetFileCount(this.path);
                data_num.Text = Convert.ToString(cnt);
                tb_file_name.Text = GetCurrentImageFileName();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteCurrentImg();
                CloseForm2();
                this.cnt = GetFileCount(this.path);
                data_num.Text = Convert.ToString(cnt);
                tb_file_name.Text = GetCurrentImageFileName();
            }
            else { }
        }
    }
}
