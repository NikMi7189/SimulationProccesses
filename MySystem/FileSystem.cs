using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class FileSystem : Form
    {
        public FileSystem()
        {
            InitializeComponent();    
        }
        static class Memory
        {
            public static int fileCount = 0;
            public static SystemFile[] myFiles = new SystemFile[1000];
        }
        class SystemFile
        {
            public static int ClusterSize = 512;
            static int clusterCount;
            public static int ClusterCount
            {
                get { return clusterCount; }
                set { clusterCount = value; }
            }
            public class Fullc
            {
                public bool check = false;
                public int name;
                public Fullc()
                {
                    name = -1;
                }
                public Fullc(int name)
                {
                    check = true;
                    this.name = name;
                }
            }

            public static Fullc[] full;
            public static int Full
            {
                set
                {
                    full = new Fullc[value];
                    for (int i = 0; i < full.Length; i++)
                        full[i] = new Fullc();
                }
            }

            int number;
            public int size;
            public int start, end;
            public int busy, ostatok;
            public SystemFile()
            {
                number = -2;
                size = 0;
            }
            public SystemFile(int number, int size)
            {
                this.number = number;
                this.size = size;
                if (this.size % ClusterSize != 0)
                {
                    busy = 1 + this.size / ClusterSize;
                    ostatok = ClusterSize - this.size % ClusterSize;
                }
                else
                {
                    busy = this.size / ClusterSize;
                    ostatok = 0;
                }
                end = start + busy - 1;
            }
            public static void ShowFree(out int[] masNames)
            {
                int[] masNamesBuf = new int[full.Length];
                for (int i = 0; i < full.Length; i++)
                {
                    if (full[i].check == true)
                    {
                        masNamesBuf[i] = full[i].name;
                    }
                    else
                    {
                        masNamesBuf[i] = -404;
                    }
                }
                masNames = masNamesBuf;
            }
            public void Add()
            {
                int start = 0;
                int fileCount = 0;
                for (int i = 0; i < full.Length; i++)
                {
                    if (full[i].check == false)
                    {
                        start = i;
                        for (int j = i; j < full.Length; j++)
                        {
                            if (full[j].check == false)
                                fileCount++;
                            else
                                break;
                        }
                    }

                    if (fileCount >= busy)
                    {
                        break;
                    }
                    else
                    {
                        fileCount = 0;
                    }
                }
                this.start = start;
                end = start + busy - 1;
                ClusterCount -= busy;
                if (end != this.start)
                {
                    for (int i = start; i < this.start + busy; i++)
                        full[i] = new Fullc(number);
                }
                else
                    full[start] = new Fullc(number);
            }
            public void Delete(int delName)
            {
                SystemFile.ClusterCount += busy;
                for (int i = 0; i < full.Length; i++)
                {
                    if (full[i].name == delName)
                    {
                        full[i] = new Fullc();
                    }                   
                }
            }
        }
        private void ScrollDown()
        {
            console_TextBox.SelectionStart = console_TextBox.Text.Length;
            console_TextBox.ScrollToCaret();
            console_TextBox.Refresh();
        }
        private void printInConsole(string str)
        {
            console_TextBox.Text += $"{str}";
            console_TextBox.Text += Environment.NewLine;
            ScrollDown();
        }
        private void OutputClaster()
        {
            clasters_DataGridView.Columns.Clear();
            int[] masNamesBuf = new int[SystemFile.full.Length];

            for (int i = 0; i < masNamesBuf.Length; i++)
            {
                clasters_DataGridView.Columns.Add("claster" + (i + 1), $"Кластер {i + 1}");
            }

            SystemFile.ShowFree(out masNamesBuf);
            int busyClasters = 0;
            int freeClasters = 0;
            for (int i = 0; i < masNamesBuf.Length; i++)
            {
                if (masNamesBuf[i] != -404)
                {
                    clasters_DataGridView.Rows[0].Cells[i].Value = masNamesBuf[i].ToString();
                    printInConsole($"Кластер ({i + 1}) занят файлом ({masNamesBuf[i]})");           
                }          
                if(clasters_DataGridView.Rows[0].Cells[i].Value == null)
                {
                    freeClasters++;
                    clasters_DataGridView.Rows[0].Cells[i].Style.BackColor = Color.LimeGreen;
                }
                else
                {
                    busyClasters++;
                    clasters_DataGridView.Rows[0].Cells[i].Style.BackColor = Color.Red;
                }
            }
            busyClasters_TextBox.Text = busyClasters.ToString();
            freeClasters_TextBox.Text = freeClasters.ToString();
            printInConsole($"Количество занятых кластеров ({busyClasters})");
            printInConsole($"Количество свободных кластеров ({freeClasters})");
            printInConsole("\n-------------------------------------------------ВЫПОЛНЕНО\n-------------------------------------------------");
        }
        private void confirm_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(memory_TextBox.Text, out _))
            {
                if (Convert.ToInt32(memory_TextBox.Text) * 1024 >= SystemFile.ClusterSize)
                {
                    SystemFile.ClusterCount = (Convert.ToInt32(memory_TextBox.Text) * 1024) / SystemFile.ClusterSize;
                    printInConsole($"Задано количество кластеров ({SystemFile.ClusterCount})");
                    clasterCount_TextBox.Text = SystemFile.ClusterCount.ToString();
                    SystemFile.Full = SystemFile.ClusterCount;
                    memory_TextBox.ReadOnly = true;
                    confirm_Button.Enabled = false;
                    sizeFile_TextBox.Enabled = true;
                    addFile_Button.Enabled = true;
                    nameFile_TextBox.Enabled = true;
                    delNameFile_TextBox.Enabled = true;
                    delFile_Button.Enabled = true;
                    OutputClaster();
                }
                else
                {
                    printInConsole("Код ошибки(3dx043)");
                    MessageBox.Show("Невозможно задать введённый размер ОЗУ (размер ОЗУ должен превышать размер кластера).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                printInConsole("Код ошибки(0002xd321)");
                MessageBox.Show("Невозможно задать введённый размер ОЗУ (Введены некорректные данные).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addFile_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nameFile_TextBox.Text, out _) && int.TryParse(sizeFile_TextBox.Text, out _))
            {
                Memory.myFiles[Memory.fileCount] = new SystemFile(Convert.ToInt32(nameFile_TextBox.Text), Convert.ToInt32(sizeFile_TextBox.Text));
                if (SystemFile.ClusterCount >= Memory.myFiles[Memory.fileCount].busy)
                {
                    Memory.myFiles[Memory.fileCount].Add();
                    Memory.fileCount++;
                    OutputClaster();
                }
                else
                {
                    printInConsole("Код ошибки(06431dl31)");
                    MessageBox.Show("Невозможно добавить файл (Количество занимаемых им кластеров превышает возможное).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                printInConsole("Код ошибки(0002xd321)");
                MessageBox.Show("Невозможно добавить файл (Введены некорректные данные).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            nameFile_TextBox.Text = "";
            sizeFile_TextBox.Text = "";
        }

        private void FileSystem_Load(object sender, EventArgs e)
        {
            claster_TextBox.Text = SystemFile.ClusterSize.ToString();
            printInConsole($"Задан размер кластеров ({SystemFile.ClusterSize})");
        }

        private void delFile_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(delNameFile_TextBox.Text, out _))
            {
                SystemFile delFile = new SystemFile();
                delFile.Delete(Convert.ToInt32(delNameFile_TextBox.Text));
                Memory.fileCount--;
                OutputClaster();
            }
            else
            {
                printInConsole("Код ошибки(0002xd321)");
                MessageBox.Show("Невозможно удалить файл (Введены некорректные данные).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            delNameFile_TextBox.Text = "";
        }

        private void clasters_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (clasters_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    delNameFile_TextBox.Text = clasters_DataGridView.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                }
            }
        }
    }
}
