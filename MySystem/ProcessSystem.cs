using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MySystem
{

    public partial class ProcessSystem : Form
    {
        public ProcessSystem()
        {
            InitializeComponent();
        }
        private void refreshTables()
        {
            Queue.final = false;
            Queue.InProgress = false;
            Queue.nowTime = 0;
            avgTimeR_TextBox.Text = "-";
            avgTimeD_TextBox.Text = "-";
            processTab.Columns.Clear();
            progressTab.Columns.Clear();
            progressTab.Columns.Add("Column1", "id");
            processTab.Columns.Add("Column1", "id");
            processTab.Columns.Add("Column2", "cpuBurst");
            processTab.Columns.Add("Column3", "createTime");
            processTab.Columns.Add("Column4", "priority");
            for (int i = 0; i < Queue.elementsCount; i++)
            {
                processTab.Rows.Add(Queue.elements[i].Id.ToString(),
                         Queue.elements[i].CpuBurst.ToString(),
                         Queue.elements[i].CreateTime.ToString(),
                         Queue.elements[i].Priority.ToString());
            }
            for (int i = 0; i < Queue.elementsCount; i++)
            {
                progressTab.Rows.Add(Queue.elements[i].Id.ToString());
            }
        }
        private void add_ButtonClick(object sender, EventArgs e)
        {
            if (!Queue.final)
            {
                if (int.TryParse(priority_TextBox.Text, out _) && int.TryParse(cpuBurst_TextBox.Text, out _))
                {
                    if (!Queue.isFull())
                    {
                        if (Convert.ToInt32(priority_TextBox.Text) <= 36)
                        {
                            Queue.addProcess(Convert.ToInt32(cpuBurst_TextBox.Text), Convert.ToInt32(priority_TextBox.Text), Convert.ToInt32(createTime_TextBox.Text));
                            processTab.Rows.Add(Queue.elements[Queue.elementsCount - 1].Id.ToString(),
                                Queue.elements[Queue.elementsCount - 1].CpuBurst.ToString(),
                                Queue.elements[Queue.elementsCount - 1].CreateTime.ToString(),
                                Queue.elements[Queue.elementsCount - 1].Priority.ToString());
                            progressTab.Rows.Add(Queue.elements[Queue.elementsCount - 1].Id.ToString());
                            refreshTables();
                        }
                        else
                        {
                            MessageBox.Show("Невозможно добавить процесс в очередь (Слишком низкий приоритет, максимально низкий приоритет = 36)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно добавить процесс в очередь (Очередь полна)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно добавить процесс в очередь (Введены некоректные данные", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невозможно добавить процесс в очередь (Очередь закончила своё выполнение). Перед выполнением этого действия очистите очередь.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void del_ButtonClick(object sender, EventArgs e)
        {
            if (!Queue.final)
            {
                if (int.TryParse(index_TextBox.Text, out _))
                {
                    if (!Queue.isEmpty())
                    {
                        bool exist = false;
                        int index = 0;
                        for (int i = 0; i < Queue.elementsCount; i++)
                        {
                            Console.WriteLine(Queue.elementsCount);
                            if (Queue.elements[i].Id == Convert.ToInt32(index_TextBox.Text))
                            {
                                exist = true;
                                index = i;
                            }
                        }
                        if (exist)
                        {
                            Queue.delProcess(Convert.ToInt32(index));
                            processTab.Rows.RemoveAt(index);
                            progressTab.Rows.RemoveAt(index);
                            refreshTables();
                        }
                        else
                        {
                            MessageBox.Show("Записи с таким ID не существует", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить процесс из очереди (Очередь пуста)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно удалить процесс из очереди (Введены некоректные данные)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невозможно удалить процесс из очереди (Очередь закончила своё выполнение)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshTables();
        }
        private void processTab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (processTab.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    index_TextBox.Text = processTab.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Queue.final)
            {
                if (!Queue.isEmpty())
                {
                    Queue.InProgress = true;
                }
                else
                {
                    MessageBox.Show("Невозможно запустить просчёт (Очередь пуста)", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невозможно запустить просчёт (Очередь закончила своё выполнение). Перед выполнением этого действия очистите очередь.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Queue.InProgress)
            {
                float countD = 0;
                float countAll = 0;
                foreach (DataGridViewRow row in progressTab.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == "Г")
                        {
                            countD++;
                        }
                        else if (cell.Value == "И")
                        {
                            countAll++;
                        }
                    }
                }

                avgTimeD_TextBox.Text = Math.Round((countD / Queue.elementsCount), 2).ToString();

                avgTimeR_TextBox.Text = Math.Round(((countAll + countD) / Queue.elementsCount), 2).ToString();

                Queue.nowTime += 1;
                Console.WriteLine($"Такт {Queue.nowTime.ToString()}");
                Queue.getCurProcess();

                if (!Queue.final)
                {
                    progressTab.Columns.Add("column" + Queue.nowTime, Queue.nowTime.ToString());
                    Console.WriteLine((Queue.nowTime - 1).ToString());
                    progressTab.Columns[Queue.nowTime].Width = 35;
                    for (int i = 0; i < Queue.elementsCount; i++)
                    {
                        progressTab.Rows[i].Cells[Queue.nowTime].Value = Queue.elements[i].State;
                    }
                }
                else
                {
                    Queue.InProgress = false;
                }
            }
        }
        private void clear_Button_Click(object sender, EventArgs e)
        {
            Queue.elementsCount = 0;
            processTab.Columns.Clear();
            progressTab.Columns.Clear();
            refreshTables();
        }
        private void stop_Button_Click(object sender, EventArgs e)
        {
            if (!Queue.isEmpty())
            {
                if (!Queue.final)
                {
                    Queue.InProgress = false;
                }
                else
                {
                    MessageBox.Show("Невозможно остановить просчёт (Очередь закончила своё выполнение). Перед выполнением этого действия очистите очередь.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невозможно остановить просчёт (Очередь пуста).", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    static class Queue
    {
        public static bool InProgress = false;
        public static int maxProcess = 25;
        public static int nowTime = 0;
        public static Process[] elements = new Process[maxProcess];
        public static int elementsCount = 0;
        public static bool final = false;
        public static void addProcess(int cpuBurst, int priority, int createTime)
        {
            Process process = new Process(cpuBurst, priority, createTime);
            elements[elementsCount] = process;
            elementsCount++;
        }
        public static void delProcess(int delIndex)
        {
            elements[delIndex] = elements[elementsCount - 1];
            elementsCount--;             
        }
        public static bool isEmpty()
        {
            if(elementsCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isFull()
        {
            if (elementsCount == maxProcess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operate(int indexCur)
        {
            bool exist = false;
            for(int i = 0; i < elementsCount; i++)
            {
                if(elements[i].Work)
                {
                    exist = true;
                    break;
                }
            }    

            if(!exist)
            {
                return true;
            }
            else
            {
                if (elements[indexCur].CpuBurst >= 1)
                {
                    elements[indexCur].CpuBurst--;
                    Console.WriteLine($"Выполняется {elements[indexCur].Id}");
                    if (elements[indexCur].CpuBurst == 0)
                    {
                        elements[indexCur].Work = false;
                        Console.WriteLine($"Выполнился {elements[indexCur].Id}");
                        return false;
                    }
                }          
                return false;
            }
        }
        public static void getCurProcess()
        {
            int indexCur = 0;
            int bestPriority = elements[indexCur].Priority;
            int bestCreateTime = elements[indexCur].CreateTime;
            int bestId = elements[indexCur].Id;

            for (int i = 0; i < elementsCount; i++)
            {
                if (bestPriority > elements[i].Priority && elements[i].Work)
                {
                    bestPriority = elements[i].Priority;
                    indexCur = i;
                }
            }

            for (int i = 0; i < elementsCount; i++)
            {
                if (bestPriority == elements[i].Priority && 
                    bestCreateTime > elements[i].CreateTime && 
                    elements[i].Work)
                {
                    bestCreateTime = elements[i].CreateTime;
                    indexCur = i;
                }
            }

            for (int i = 0; i < elementsCount; i++)
            {
                if (bestPriority == elements[i].Priority &&
                    bestCreateTime == elements[i].CreateTime &&
                    bestId > elements[i].Id && 
                    elements[i].Work)
                {
                    bestId = elements[i].Id;
                    indexCur = i;
                }
            }

            for(int i = 0; i < elementsCount; i++)
            {
                if(nowTime >= elements[i].CreateTime && elements[i].Work)
                {
                    elements[i].State = "Г";
                }
                else
                {
                    elements[i].State = "   ";
                }
            }

            if (nowTime >= elements[indexCur].CreateTime)
            {
                elements[indexCur].State = "И";
                final = operate(indexCur);
            }    
            if (final)
            {
                Console.WriteLine($"Просчёт завершён");
            }


        }        
    }
    class Process
    {
        string state;
        int id;
        int cpuBurst;
        int createTime;
        int priority;
        bool work;

        public bool Work
        {
            get
            {
                return this.work;
            }
            set
            {
                this.work = value;
            }
        }
        public int CpuBurst
        {
            get
            {
                return this.cpuBurst;
            }
            set
            {
                this.cpuBurst = value;
            }
        }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int CreateTime
        {
            get
            {
                return this.createTime;
            }
            set
            {
                this.createTime = value;
            }
        }
        public int Priority
        {
            get
            {
                return this.priority;
            }
            set
            {
                this.priority = value;
            }
        }
        public Process(int cpuBurst, int priority, int createTime)
        {
            Random rand = new Random();
            this.id = rand.Next(99999999);
            this.cpuBurst = cpuBurst;
            this.createTime = createTime;
            this.priority = priority;
            this.work = true;
        }
    }
}
