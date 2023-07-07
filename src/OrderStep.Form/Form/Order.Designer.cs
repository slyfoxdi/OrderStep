namespace OrderStep.Api
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLable1 = new System.Windows.Forms.Label();
            this.timerLable1 = new System.Windows.Forms.Label();
            this.linkExitLabel1 = new System.Windows.Forms.LinkLabel();
            this.userFioLable1 = new System.Windows.Forms.Label();
            this.logoLable1 = new System.Windows.Forms.Label();
            this.mainLabel1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.addButton2 = new System.Windows.Forms.Button();
            this.saveButton3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dateLable1);
            this.panel1.Controls.Add(this.timerLable1);
            this.panel1.Controls.Add(this.linkExitLabel1);
            this.panel1.Controls.Add(this.userFioLable1);
            this.panel1.Controls.Add(this.logoLable1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 79);
            this.panel1.TabIndex = 0;
            // 
            // dateLable1
            // 
            this.dateLable1.AutoSize = true;
            this.dateLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLable1.Location = new System.Drawing.Point(755, 35);
            this.dateLable1.Name = "dateLable1";
            this.dateLable1.Size = new System.Drawing.Size(0, 24);
            this.dateLable1.TabIndex = 5;
            // 
            // timerLable1
            // 
            this.timerLable1.AutoSize = true;
            this.timerLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLable1.Location = new System.Drawing.Point(642, 35);
            this.timerLable1.Name = "timerLable1";
            this.timerLable1.Size = new System.Drawing.Size(0, 24);
            this.timerLable1.TabIndex = 4;
            // 
            // linkExitLabel1
            // 
            this.linkExitLabel1.AutoSize = true;
            this.linkExitLabel1.LinkColor = System.Drawing.Color.DarkRed;
            this.linkExitLabel1.Location = new System.Drawing.Point(1522, 37);
            this.linkExitLabel1.Name = "linkExitLabel1";
            this.linkExitLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkExitLabel1.TabIndex = 3;
            this.linkExitLabel1.TabStop = true;
            this.linkExitLabel1.Text = "Выйти";
            // 
            // userFioLable1
            // 
            this.userFioLable1.AutoSize = true;
            this.userFioLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFioLable1.Location = new System.Drawing.Point(1393, 29);
            this.userFioLable1.Name = "userFioLable1";
            this.userFioLable1.Size = new System.Drawing.Size(114, 24);
            this.userFioLable1.TabIndex = 2;
            this.userFioLable1.Text = "Дмитрий П.";
            // 
            // logoLable1
            // 
            this.logoLable1.AutoSize = true;
            this.logoLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLable1.Location = new System.Drawing.Point(45, 17);
            this.logoLable1.Name = "logoLable1";
            this.logoLable1.Size = new System.Drawing.Size(151, 46);
            this.logoLable1.TabIndex = 1;
            this.logoLable1.Text = "Кортис";
            // 
            // mainLabel1
            // 
            this.mainLabel1.AutoSize = true;
            this.mainLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel1.Location = new System.Drawing.Point(349, 126);
            this.mainLabel1.Name = "mainLabel1";
            this.mainLabel1.Size = new System.Drawing.Size(108, 31);
            this.mainLabel1.TabIndex = 0;
            this.mainLabel1.Text = "Заказы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7});
            this.dataGridView1.Location = new System.Drawing.Point(324, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1276, 615);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // Col1
            // 
            this.Col1.HeaderText = "Id";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Артикул";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Наименование";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 300;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "Вес";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "Кол-во";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "Адрес доставки";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            this.Col6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col6.Width = 300;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "Цена";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            this.Col7.Width = 240;
            // 
            // deleteButton1
            // 
            this.deleteButton1.BackColor = System.Drawing.Color.Firebrick;
            this.deleteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton1.Location = new System.Drawing.Point(1073, 126);
            this.deleteButton1.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(172, 36);
            this.deleteButton1.TabIndex = 3;
            this.deleteButton1.Text = "Удалить";
            this.deleteButton1.UseVisualStyleBackColor = false;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // addButton2
            // 
            this.addButton2.BackColor = System.Drawing.Color.OliveDrab;
            this.addButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton2.Location = new System.Drawing.Point(1251, 126);
            this.addButton2.Margin = new System.Windows.Forms.Padding(0);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(172, 36);
            this.addButton2.TabIndex = 4;
            this.addButton2.Text = "Добавить";
            this.addButton2.UseVisualStyleBackColor = false;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // saveButton3
            // 
            this.saveButton3.BackColor = System.Drawing.Color.Khaki;
            this.saveButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton3.Location = new System.Drawing.Point(1429, 126);
            this.saveButton3.Name = "saveButton3";
            this.saveButton3.Size = new System.Drawing.Size(172, 36);
            this.saveButton3.TabIndex = 5;
            this.saveButton3.Text = "Сохранить";
            this.saveButton3.UseVisualStyleBackColor = false;
            this.saveButton3.Click += new System.EventHandler(this.saveButton3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(18, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(18, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Заказы";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(18, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Доставка";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1622, 814);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton3);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "OrderStep.Заказы";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dateLable1;
        private System.Windows.Forms.Label timerLable1;
        private System.Windows.Forms.LinkLabel linkExitLabel1;
        private System.Windows.Forms.Label userFioLable1;
        private System.Windows.Forms.Label logoLable1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Button saveButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
    }
}