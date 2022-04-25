
namespace BD_KURS_SHMAKOV_846
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.buttonAddOtsr = new System.Windows.Forms.Button();
            this.buttonUpOtsr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddStr = new System.Windows.Forms.Button();
            this.buttonDelOtsr = new System.Windows.Forms.Button();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.buttonCloseConnection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAboutApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.buttonAddOtsr);
            this.groupBoxTable.Controls.Add(this.buttonUpOtsr);
            this.groupBoxTable.Controls.Add(this.comboBox1);
            this.groupBoxTable.Controls.Add(this.buttonAddStr);
            this.groupBoxTable.Controls.Add(this.buttonDelOtsr);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 47);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(330, 279);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Таблицы";
            // 
            // buttonAddOtsr
            // 
            this.buttonAddOtsr.Location = new System.Drawing.Point(6, 230);
            this.buttonAddOtsr.Name = "buttonAddOtsr";
            this.buttonAddOtsr.Size = new System.Drawing.Size(318, 30);
            this.buttonAddOtsr.TabIndex = 14;
            this.buttonAddOtsr.Text = "Добавить отсрочку призывнику";
            this.buttonAddOtsr.UseVisualStyleBackColor = true;
            this.buttonAddOtsr.Click += new System.EventHandler(this.buttonAddOtsr_Click);
            // 
            // buttonUpOtsr
            // 
            this.buttonUpOtsr.Location = new System.Drawing.Point(6, 180);
            this.buttonUpOtsr.Name = "buttonUpOtsr";
            this.buttonUpOtsr.Size = new System.Drawing.Size(318, 30);
            this.buttonUpOtsr.TabIndex = 7;
            this.buttonUpOtsr.Text = "Обновить отсрочку призывнику";
            this.buttonUpOtsr.UseVisualStyleBackColor = true;
            this.buttonUpOtsr.Click += new System.EventHandler(this.ButtonUpStr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAddStr
            // 
            this.buttonAddStr.Location = new System.Drawing.Point(6, 80);
            this.buttonAddStr.Name = "buttonAddStr";
            this.buttonAddStr.Size = new System.Drawing.Size(318, 30);
            this.buttonAddStr.TabIndex = 5;
            this.buttonAddStr.Text = "Добавить призывника";
            this.buttonAddStr.UseVisualStyleBackColor = true;
            this.buttonAddStr.Click += new System.EventHandler(this.ButtonAddStr_Click);
            // 
            // buttonDelOtsr
            // 
            this.buttonDelOtsr.Location = new System.Drawing.Point(6, 130);
            this.buttonDelOtsr.Name = "buttonDelOtsr";
            this.buttonDelOtsr.Size = new System.Drawing.Size(318, 30);
            this.buttonDelOtsr.TabIndex = 8;
            this.buttonDelOtsr.Text = "Удалить отсрочку призывнику";
            this.buttonDelOtsr.UseVisualStyleBackColor = true;
            this.buttonDelOtsr.Click += new System.EventHandler(this.ButtonDelStr_Click);
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(12, 12);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(200, 29);
            this.buttonConnection.TabIndex = 1;
            this.buttonConnection.Text = "Подключиться к БД";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.ButtonConnection_Click);
            // 
            // buttonCloseConnection
            // 
            this.buttonCloseConnection.Location = new System.Drawing.Point(218, 12);
            this.buttonCloseConnection.Name = "buttonCloseConnection";
            this.buttonCloseConnection.Size = new System.Drawing.Size(200, 29);
            this.buttonCloseConnection.TabIndex = 2;
            this.buttonCloseConnection.Text = "Отключиться от БД";
            this.buttonCloseConnection.UseVisualStyleBackColor = true;
            this.buttonCloseConnection.Click += new System.EventHandler(this.ButtonCloseConnection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(348, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 773);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonAboutApp
            // 
            this.buttonAboutApp.Location = new System.Drawing.Point(424, 12);
            this.buttonAboutApp.Name = "buttonAboutApp";
            this.buttonAboutApp.Size = new System.Drawing.Size(200, 29);
            this.buttonAboutApp.TabIndex = 10;
            this.buttonAboutApp.Text = "О программе";
            this.buttonAboutApp.UseVisualStyleBackColor = true;
            this.buttonAboutApp.Click += new System.EventHandler(this.ButtonAboutApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Location = new System.Drawing.Point(630, 12);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(200, 29);
            this.buttonCloseApp.TabIndex = 11;
            this.buttonCloseApp.Text = "Выйти";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1547, 825);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.buttonAboutApp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCloseConnection);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.groupBoxTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета призывников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Button buttonCloseConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAboutApp;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUpOtsr;
        private System.Windows.Forms.Button buttonAddStr;
        private System.Windows.Forms.Button buttonDelOtsr;
        private System.Windows.Forms.Button buttonAddOtsr;
    }
}

