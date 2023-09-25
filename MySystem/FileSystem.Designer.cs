
namespace MySystem
{
    partial class FileSystem
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
            this.addFile_Button = new System.Windows.Forms.Button();
            this.memory_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.sizeFile_TextBox = new System.Windows.Forms.TextBox();
            this.addFile_Label = new System.Windows.Forms.Label();
            this.claster_TextBox = new System.Windows.Forms.TextBox();
            this.claster_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.console_TextBox = new System.Windows.Forms.TextBox();
            this.clasters_DataGridView = new System.Windows.Forms.DataGridView();
            this.clasterCount_TextBox = new System.Windows.Forms.TextBox();
            this.clasterCount_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.busyClasters_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.freeClasters_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameFile_TextBox = new System.Windows.Forms.TextBox();
            this.delNameFile_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delFile_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clasters_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addFile_Button
            // 
            this.addFile_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addFile_Button.Enabled = false;
            this.addFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFile_Button.ForeColor = System.Drawing.Color.White;
            this.addFile_Button.Location = new System.Drawing.Point(360, 513);
            this.addFile_Button.Name = "addFile_Button";
            this.addFile_Button.Size = new System.Drawing.Size(354, 22);
            this.addFile_Button.TabIndex = 7;
            this.addFile_Button.Text = "Добавить файл";
            this.addFile_Button.UseVisualStyleBackColor = false;
            this.addFile_Button.Click += new System.EventHandler(this.addFile_Button_Click);
            // 
            // memory_TextBox
            // 
            this.memory_TextBox.BackColor = System.Drawing.Color.White;
            this.memory_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memory_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memory_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memory_TextBox.Location = new System.Drawing.Point(363, 143);
            this.memory_TextBox.Name = "memory_TextBox";
            this.memory_TextBox.Size = new System.Drawing.Size(351, 18);
            this.memory_TextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Размер оперативной памяти (МБайт)";
            // 
            // confirm_Button
            // 
            this.confirm_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_Button.ForeColor = System.Drawing.Color.White;
            this.confirm_Button.Location = new System.Drawing.Point(360, 357);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(354, 22);
            this.confirm_Button.TabIndex = 12;
            this.confirm_Button.Text = "Подтвердить";
            this.confirm_Button.UseVisualStyleBackColor = false;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Button_Click);
            // 
            // sizeFile_TextBox
            // 
            this.sizeFile_TextBox.BackColor = System.Drawing.Color.White;
            this.sizeFile_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeFile_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sizeFile_TextBox.Enabled = false;
            this.sizeFile_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeFile_TextBox.Location = new System.Drawing.Point(360, 450);
            this.sizeFile_TextBox.Name = "sizeFile_TextBox";
            this.sizeFile_TextBox.Size = new System.Drawing.Size(354, 18);
            this.sizeFile_TextBox.TabIndex = 16;
            // 
            // addFile_Label
            // 
            this.addFile_Label.AutoSize = true;
            this.addFile_Label.ForeColor = System.Drawing.Color.White;
            this.addFile_Label.Location = new System.Drawing.Point(357, 434);
            this.addFile_Label.Name = "addFile_Label";
            this.addFile_Label.Size = new System.Drawing.Size(117, 13);
            this.addFile_Label.TabIndex = 15;
            this.addFile_Label.Text = "Размер файла (Байт)";
            // 
            // claster_TextBox
            // 
            this.claster_TextBox.BackColor = System.Drawing.Color.White;
            this.claster_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claster_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.claster_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.claster_TextBox.Location = new System.Drawing.Point(363, 192);
            this.claster_TextBox.Name = "claster_TextBox";
            this.claster_TextBox.ReadOnly = true;
            this.claster_TextBox.Size = new System.Drawing.Size(351, 18);
            this.claster_TextBox.TabIndex = 18;
            // 
            // claster_Label
            // 
            this.claster_Label.AutoSize = true;
            this.claster_Label.ForeColor = System.Drawing.Color.White;
            this.claster_Label.Location = new System.Drawing.Point(360, 176);
            this.claster_Label.Name = "claster_Label";
            this.claster_Label.Size = new System.Drawing.Size(131, 13);
            this.claster_Label.TabIndex = 17;
            this.claster_Label.Text = "Размер кластера (Байт)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Консольный вывод";
            // 
            // console_TextBox
            // 
            this.console_TextBox.BackColor = System.Drawing.Color.Black;
            this.console_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.console_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.console_TextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.console_TextBox.Location = new System.Drawing.Point(12, 127);
            this.console_TextBox.Multiline = true;
            this.console_TextBox.Name = "console_TextBox";
            this.console_TextBox.ReadOnly = true;
            this.console_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_TextBox.Size = new System.Drawing.Size(342, 517);
            this.console_TextBox.TabIndex = 24;
            // 
            // clasters_DataGridView
            // 
            this.clasters_DataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.clasters_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clasters_DataGridView.Location = new System.Drawing.Point(12, 13);
            this.clasters_DataGridView.Name = "clasters_DataGridView";
            this.clasters_DataGridView.ReadOnly = true;
            this.clasters_DataGridView.RowTemplate.Height = 24;
            this.clasters_DataGridView.Size = new System.Drawing.Size(702, 70);
            this.clasters_DataGridView.TabIndex = 25;
            this.clasters_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clasters_DataGridView_CellClick);
            // 
            // clasterCount_TextBox
            // 
            this.clasterCount_TextBox.BackColor = System.Drawing.Color.White;
            this.clasterCount_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clasterCount_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clasterCount_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clasterCount_TextBox.Location = new System.Drawing.Point(363, 239);
            this.clasterCount_TextBox.Name = "clasterCount_TextBox";
            this.clasterCount_TextBox.ReadOnly = true;
            this.clasterCount_TextBox.Size = new System.Drawing.Size(351, 18);
            this.clasterCount_TextBox.TabIndex = 20;
            // 
            // clasterCount_Label
            // 
            this.clasterCount_Label.AutoSize = true;
            this.clasterCount_Label.ForeColor = System.Drawing.Color.White;
            this.clasterCount_Label.Location = new System.Drawing.Point(360, 223);
            this.clasterCount_Label.Name = "clasterCount_Label";
            this.clasterCount_Label.Size = new System.Drawing.Size(164, 13);
            this.clasterCount_Label.TabIndex = 19;
            this.clasterCount_Label.Text = "Общее количество кластеров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество занятых кластеров";
            // 
            // busyClasters_TextBox
            // 
            this.busyClasters_TextBox.BackColor = System.Drawing.Color.White;
            this.busyClasters_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busyClasters_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.busyClasters_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busyClasters_TextBox.Location = new System.Drawing.Point(363, 288);
            this.busyClasters_TextBox.Name = "busyClasters_TextBox";
            this.busyClasters_TextBox.ReadOnly = true;
            this.busyClasters_TextBox.Size = new System.Drawing.Size(351, 18);
            this.busyClasters_TextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Количество свободных кластеров";
            // 
            // freeClasters_TextBox
            // 
            this.freeClasters_TextBox.BackColor = System.Drawing.Color.White;
            this.freeClasters_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.freeClasters_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.freeClasters_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeClasters_TextBox.Location = new System.Drawing.Point(363, 333);
            this.freeClasters_TextBox.Name = "freeClasters_TextBox";
            this.freeClasters_TextBox.ReadOnly = true;
            this.freeClasters_TextBox.Size = new System.Drawing.Size(351, 18);
            this.freeClasters_TextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Номер файла (Имя)";
            // 
            // nameFile_TextBox
            // 
            this.nameFile_TextBox.BackColor = System.Drawing.Color.White;
            this.nameFile_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameFile_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameFile_TextBox.Enabled = false;
            this.nameFile_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFile_TextBox.Location = new System.Drawing.Point(360, 489);
            this.nameFile_TextBox.Name = "nameFile_TextBox";
            this.nameFile_TextBox.Size = new System.Drawing.Size(354, 18);
            this.nameFile_TextBox.TabIndex = 31;
            // 
            // delNameFile_TextBox
            // 
            this.delNameFile_TextBox.BackColor = System.Drawing.Color.White;
            this.delNameFile_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delNameFile_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delNameFile_TextBox.Enabled = false;
            this.delNameFile_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delNameFile_TextBox.Location = new System.Drawing.Point(360, 598);
            this.delNameFile_TextBox.Name = "delNameFile_TextBox";
            this.delNameFile_TextBox.Size = new System.Drawing.Size(354, 18);
            this.delNameFile_TextBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(357, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Номер файла (Имя)";
            // 
            // delFile_Button
            // 
            this.delFile_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.delFile_Button.Enabled = false;
            this.delFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delFile_Button.ForeColor = System.Drawing.Color.White;
            this.delFile_Button.Location = new System.Drawing.Point(360, 622);
            this.delFile_Button.Name = "delFile_Button";
            this.delFile_Button.Size = new System.Drawing.Size(354, 22);
            this.delFile_Button.TabIndex = 34;
            this.delFile_Button.Text = "Удалить файл";
            this.delFile_Button.UseVisualStyleBackColor = false;
            this.delFile_Button.Click += new System.EventHandler(this.delFile_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(472, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Добавление файла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(464, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Найстройки системы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(484, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Удаление файла";
            // 
            // FileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(728, 656);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameFile_TextBox);
            this.Controls.Add(this.addFile_Button);
            this.Controls.Add(this.delFile_Button);
            this.Controls.Add(this.addFile_Label);
            this.Controls.Add(this.delNameFile_TextBox);
            this.Controls.Add(this.sizeFile_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.freeClasters_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busyClasters_TextBox);
            this.Controls.Add(this.clasters_DataGridView);
            this.Controls.Add(this.console_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clasterCount_Label);
            this.Controls.Add(this.clasterCount_TextBox);
            this.Controls.Add(this.confirm_Button);
            this.Controls.Add(this.claster_TextBox);
            this.Controls.Add(this.claster_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memory_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсистема управления файлами";
            this.Load += new System.EventHandler(this.FileSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasters_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFile_Button;
        private System.Windows.Forms.TextBox memory_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_Button;
        private System.Windows.Forms.TextBox sizeFile_TextBox;
        private System.Windows.Forms.Label addFile_Label;
        private System.Windows.Forms.TextBox claster_TextBox;
        private System.Windows.Forms.Label claster_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox console_TextBox;
        private System.Windows.Forms.DataGridView clasters_DataGridView;
        private System.Windows.Forms.TextBox clasterCount_TextBox;
        private System.Windows.Forms.Label clasterCount_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busyClasters_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox freeClasters_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameFile_TextBox;
        private System.Windows.Forms.TextBox delNameFile_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delFile_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}