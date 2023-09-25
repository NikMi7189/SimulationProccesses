
namespace MySystem
{
    partial class ProcessSystem
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add_Button = new System.Windows.Forms.Button();
            this.del_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createTime_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.index_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priority_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuBurst_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressTab = new System.Windows.Forms.DataGridView();
            this.processTab = new System.Windows.Forms.DataGridView();
            this.start_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stop_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avgTimeD_TextBox = new System.Windows.Forms.TextBox();
            this.avgTimeR_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTab)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Button.ForeColor = System.Drawing.Color.White;
            this.add_Button.Location = new System.Drawing.Point(3, 136);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(392, 22);
            this.add_Button.TabIndex = 6;
            this.add_Button.Text = "Добавить процесс";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_ButtonClick);
            // 
            // del_Button
            // 
            this.del_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_Button.ForeColor = System.Drawing.Color.White;
            this.del_Button.Location = new System.Drawing.Point(3, 198);
            this.del_Button.Name = "del_Button";
            this.del_Button.Size = new System.Drawing.Size(392, 23);
            this.del_Button.TabIndex = 7;
            this.del_Button.Text = "Удалить процесс";
            this.del_Button.UseVisualStyleBackColor = false;
            this.del_Button.Click += new System.EventHandler(this.del_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.createTime_TextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.index_TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priority_TextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cpuBurst_TextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.add_Button);
            this.panel1.Controls.Add(this.del_Button);
            this.panel1.Location = new System.Drawing.Point(694, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 253);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(167, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "МЕНЮ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "ТАБЛИЦА ПРОЦЕССОВ";
            // 
            // createTime_TextBox
            // 
            this.createTime_TextBox.BackColor = System.Drawing.Color.White;
            this.createTime_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createTime_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createTime_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTime_TextBox.Location = new System.Drawing.Point(3, 78);
            this.createTime_TextBox.Name = "createTime_TextBox";
            this.createTime_TextBox.Size = new System.Drawing.Size(392, 18);
            this.createTime_TextBox.TabIndex = 16;
            this.createTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер удаляемого процесса";
            // 
            // index_TextBox
            // 
            this.index_TextBox.BackColor = System.Drawing.Color.White;
            this.index_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.index_TextBox.Location = new System.Drawing.Point(3, 177);
            this.index_TextBox.Name = "index_TextBox";
            this.index_TextBox.Size = new System.Drawing.Size(392, 18);
            this.index_TextBox.TabIndex = 14;
            this.index_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Время появления";
            // 
            // priority_TextBox
            // 
            this.priority_TextBox.BackColor = System.Drawing.Color.White;
            this.priority_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priority_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priority_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority_TextBox.Location = new System.Drawing.Point(3, 41);
            this.priority_TextBox.Name = "priority_TextBox";
            this.priority_TextBox.Size = new System.Drawing.Size(392, 18);
            this.priority_TextBox.TabIndex = 11;
            this.priority_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Приоритет";
            // 
            // cpuBurst_TextBox
            // 
            this.cpuBurst_TextBox.BackColor = System.Drawing.Color.White;
            this.cpuBurst_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpuBurst_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cpuBurst_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpuBurst_TextBox.Location = new System.Drawing.Point(3, 115);
            this.cpuBurst_TextBox.Name = "cpuBurst_TextBox";
            this.cpuBurst_TextBox.Size = new System.Drawing.Size(392, 18);
            this.cpuBurst_TextBox.TabIndex = 9;
            this.cpuBurst_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Время выполнения";
            // 
            // progressTab
            // 
            this.progressTab.AllowUserToResizeColumns = false;
            this.progressTab.AllowUserToResizeRows = false;
            this.progressTab.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.progressTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressTab.Location = new System.Drawing.Point(12, 12);
            this.progressTab.MultiSelect = false;
            this.progressTab.Name = "progressTab";
            this.progressTab.ReadOnly = true;
            this.progressTab.RowHeadersVisible = false;
            this.progressTab.RowTemplate.Height = 24;
            this.progressTab.RowTemplate.ReadOnly = true;
            this.progressTab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.progressTab.Size = new System.Drawing.Size(569, 426);
            this.progressTab.TabIndex = 9;
            // 
            // processTab
            // 
            this.processTab.AllowUserToResizeColumns = false;
            this.processTab.AllowUserToResizeRows = false;
            this.processTab.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.processTab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.processTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processTab.Location = new System.Drawing.Point(694, 265);
            this.processTab.MultiSelect = false;
            this.processTab.Name = "processTab";
            this.processTab.ReadOnly = true;
            this.processTab.RowHeadersVisible = false;
            this.processTab.RowTemplate.Height = 25;
            this.processTab.RowTemplate.ReadOnly = true;
            this.processTab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.processTab.Size = new System.Drawing.Size(405, 173);
            this.processTab.TabIndex = 10;
            this.processTab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processTab_CellClick);
            // 
            // start_Button
            // 
            this.start_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_Button.ForeColor = System.Drawing.Color.White;
            this.start_Button.Location = new System.Drawing.Point(3, 252);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(93, 81);
            this.start_Button.TabIndex = 19;
            this.start_Button.Text = "Запустить";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stop_Button);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.avgTimeD_TextBox);
            this.panel2.Controls.Add(this.avgTimeR_TextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.start_Button);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(587, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 426);
            this.panel2.TabIndex = 19;
            // 
            // stop_Button
            // 
            this.stop_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_Button.ForeColor = System.Drawing.Color.White;
            this.stop_Button.Location = new System.Drawing.Point(3, 339);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(93, 86);
            this.stop_Button.TabIndex = 23;
            this.stop_Button.Text = "Остановить";
            this.stop_Button.UseVisualStyleBackColor = false;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ожидания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Выполнения";
            // 
            // avgTimeD_TextBox
            // 
            this.avgTimeD_TextBox.BackColor = System.Drawing.Color.White;
            this.avgTimeD_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgTimeD_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.avgTimeD_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgTimeD_TextBox.Location = new System.Drawing.Point(7, 178);
            this.avgTimeD_TextBox.Name = "avgTimeD_TextBox";
            this.avgTimeD_TextBox.ReadOnly = true;
            this.avgTimeD_TextBox.Size = new System.Drawing.Size(85, 45);
            this.avgTimeD_TextBox.TabIndex = 20;
            this.avgTimeD_TextBox.Text = "-";
            this.avgTimeD_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avgTimeR_TextBox
            // 
            this.avgTimeR_TextBox.BackColor = System.Drawing.Color.White;
            this.avgTimeR_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgTimeR_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.avgTimeR_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgTimeR_TextBox.Location = new System.Drawing.Point(7, 66);
            this.avgTimeR_TextBox.Name = "avgTimeR_TextBox";
            this.avgTimeR_TextBox.ReadOnly = true;
            this.avgTimeR_TextBox.Size = new System.Drawing.Size(85, 45);
            this.avgTimeR_TextBox.TabIndex = 19;
            this.avgTimeR_TextBox.Text = "-";
            this.avgTimeR_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "ЗНАЧЕНИЯ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(167, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "МЕНЮ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Среднее время";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Среднее время";
            // 
            // clear_Button
            // 
            this.clear_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_Button.ForeColor = System.Drawing.Color.White;
            this.clear_Button.Location = new System.Drawing.Point(694, 413);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(403, 25);
            this.clear_Button.TabIndex = 23;
            this.clear_Button.Text = "Очистить очередь";
            this.clear_Button.UseVisualStyleBackColor = false;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ProcessSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.processTab);
            this.Controls.Add(this.progressTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessSystem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсистема управления процессами";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTab)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button del_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priority_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpuBurst_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox index_TextBox;
        private System.Windows.Forms.DataGridView progressTab;
        private System.Windows.Forms.DataGridView processTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createTime_TextBox;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox avgTimeD_TextBox;
        private System.Windows.Forms.TextBox avgTimeR_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button stop_Button;
    }
}

