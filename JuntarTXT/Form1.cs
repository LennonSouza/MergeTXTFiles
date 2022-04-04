using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JuntarTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            IEnumerable<string> files = Directory.GetFiles(this.txt_path.Text, "*.*", SearchOption.AllDirectories).Where(f => f.EndsWith(".txt"));
            bool flag = files.Count() != 0;
            if (flag)
            {
                FileStream fileStream = File.Open(@"file.txt", FileMode.OpenOrCreate);
                fileStream.Close();
                List<string> list = new List<string>();
                foreach (string path2 in files)
                {
                    list.AddRange(File.ReadAllLines(path2));
                }
                File.WriteAllLines(@"file.txt", list.ToArray());
                MessageBox.Show($"Save file in '{AppDomain.CurrentDomain.BaseDirectory}file.txt'!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
