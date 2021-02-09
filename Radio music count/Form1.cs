using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Radio_music_count
{
    public partial class Form1 : Form
    {
        List<string> listRusMusic = new List<string>();
        List<string> listKazMusic = new List<string>();
        //List<string> listRusReklama = new List<string>();
        //List<string> listKazReklama = new List<string>();
        List<string> listExclude = new List<string>();


        int countRusMusic = 0;
        int countKazMusic = 0;


        string separ1 = @"\Music\каз\";
        //string separ2 = @"\Реклама\";
        string separ3 = @"^\\Music\\(\d+\.\d+\.\d+)\\";
        string separ4 = @"^\d+\s";
        string separ5 = @"\|+.+";
        


        public Form1()
        {
            InitializeComponent();

            string[] paths = { "rus Music.txt", "kaz Music.txt", "no Used.txt" };
            List<List<string>> lists = new List<List<string>>
            {
                listRusMusic,
                listKazMusic,
                listExclude
            };

            for (int i = 0; i<paths.Length; i++)
            {
                GetInfoInFile(paths[i], lists[i]);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] paths = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                Regex regex = new Regex(separ3);
                Regex regex2 = new Regex(separ4);
                Regex regex3 = new Regex(separ5);

                for (int i = 0; i<paths.Length; i++)
                {
                    string path = paths[i];

                    using (StreamReader sr = new StreamReader(path, Encoding.ASCII))
                    {
                        countKazMusic = 0;
                        countRusMusic = 0;

                        string str;
                        while ((str = sr.ReadLine()) != null)
                        {
                            string newStr = "";
                            if (str.StartsWith(separ1))
                            {
                                newStr = str.Replace(separ1, "");
                                if (Regex.IsMatch(newStr, separ5))
                                {
                                    newStr = regex3.Replace(newStr, "");

                                    if (IsFind(listKazMusic, newStr))
                                    {
                                        countKazMusic++;
                                        newStr = "";
                                    }
                                }
                            }
                            else if (Regex.IsMatch(str, separ3))
                            {
                                newStr = regex.Replace(str, "");
                                if (Regex.IsMatch(newStr, separ4))
                                {
                                    newStr = regex2.Replace(newStr, "");
                                    if (Regex.IsMatch(newStr, separ5))
                                    {
                                        newStr = regex3.Replace(newStr, "");

                                        if (IsFind(listExclude, newStr))
                                        {
                                            newStr = "";
                                        }
                                        else if (IsFind(listRusMusic, newStr))
                                        {
                                            countRusMusic++;
                                            newStr = "";
                                        }
                                        else
                                        {
                                            AddInfoInFile("rus Music.txt", newStr);
                                            listRusMusic.Add(newStr);
                                        }
                                    }
                                }
                            }

                            if (newStr != "")
                            {
                                listBox2.Items.Add(newStr);
                            }

                        }
                    }

                    FileInfo file = new FileInfo(path);
                    string nameFile = file.Name;

                    listBox1.Items.Add(nameFile + " : Каз муз - " + countKazMusic + " : Рус муз - " + countRusMusic);
                }

                btnStart.Enabled = true;
            }
        }

        bool IsFind(List<string> list, string strFind)
        {
            for (int i = 0; i<list.Count; i++)
            {
                if (list[i] == strFind)
                {
                    return true;
                }
            }

            return false;
        }

        void AddInfoInFile(string path, string info)
        {
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.WriteLine(info);
            }
        }

        void GetInfoInFile(string path, List<string> list)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    list.Add(str);
                }
            }
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            string info = listBox1.Items[listBox1.SelectedIndex].ToString();
            AddInfoInFile("no Used.txt", info);
        }

        private void btnRusMusic_Click(object sender, EventArgs e)
        {
            string info = listBox1.Items[listBox1.SelectedIndex].ToString();
            AddInfoInFile("rus Music.txt", info);
        }

        private void btnKazMusic_Click(object sender, EventArgs e)
        {
            string info = listBox1.Items[listBox1.SelectedIndex].ToString();
            AddInfoInFile("kaz Music.txt", info);
        }
    }
}
