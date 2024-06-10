namespace MoneyApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.minFormBtn = new System.Windows.Forms.Label();
            this.maxFormBtn = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dohodDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rashodDataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reloadData = new System.Windows.Forms.Button();
            this.rashodLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dohodLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteRashodBtn = new System.Windows.Forms.Button();
            this.deleteDohodBtn = new System.Windows.Forms.Button();
            this.addRashodBtn = new System.Windows.Forms.Button();
            this.addDohodBtn = new System.Windows.Forms.Button();
            this.balanceLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.financePage = new System.Windows.Forms.TabPage();
            this.dataRashodPanel = new System.Windows.Forms.Panel();
            this.dataDohodPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.popularRashod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.popularDohod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.infoPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dohodDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rashodDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.financePage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.minFormBtn);
            this.panel1.Controls.Add(this.maxFormBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 41);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(431, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Мой кошелек - система управления финсами";
            // 
            // minFormBtn
            // 
            this.minFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minFormBtn.AutoSize = true;
            this.minFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minFormBtn.ForeColor = System.Drawing.Color.Blue;
            this.minFormBtn.Location = new System.Drawing.Point(1383, 5);
            this.minFormBtn.Name = "minFormBtn";
            this.minFormBtn.Size = new System.Drawing.Size(27, 29);
            this.minFormBtn.TabIndex = 5;
            this.minFormBtn.Text = "_";
            this.minFormBtn.Click += new System.EventHandler(this.minFormBtn_Click);
            // 
            // maxFormBtn
            // 
            this.maxFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxFormBtn.AutoSize = true;
            this.maxFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxFormBtn.ForeColor = System.Drawing.Color.Blue;
            this.maxFormBtn.Location = new System.Drawing.Point(1420, 9);
            this.maxFormBtn.Name = "maxFormBtn";
            this.maxFormBtn.Size = new System.Drawing.Size(28, 29);
            this.maxFormBtn.TabIndex = 4;
            this.maxFormBtn.Text = "□";
            this.maxFormBtn.Click += new System.EventHandler(this.maxFormBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(1457, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(31, 29);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabcontrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 809);
            this.panel2.TabIndex = 1;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.infoPage);
            this.tabcontrol.Controls.Add(this.financePage);
            this.tabcontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1500, 809);
            this.tabcontrol.TabIndex = 0;
            // 
            // infoPage
            // 
            this.infoPage.AutoScroll = true;
            this.infoPage.BackColor = System.Drawing.Color.White;
            this.infoPage.Controls.Add(this.panel4);
            this.infoPage.Controls.Add(this.panel3);
            this.infoPage.Location = new System.Drawing.Point(4, 31);
            this.infoPage.Name = "infoPage";
            this.infoPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoPage.Size = new System.Drawing.Size(1492, 774);
            this.infoPage.TabIndex = 0;
            this.infoPage.Text = "Основная информация";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1486, 257);
            this.panel4.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1486, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dohodDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1478, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Доходы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dohodDataGrid
            // 
            this.dohodDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dohodDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dohodDataGrid.Location = new System.Drawing.Point(3, 3);
            this.dohodDataGrid.Name = "dohodDataGrid";
            this.dohodDataGrid.RowHeadersWidth = 51;
            this.dohodDataGrid.RowTemplate.Height = 24;
            this.dohodDataGrid.Size = new System.Drawing.Size(1472, 216);
            this.dohodDataGrid.TabIndex = 0;
            this.dohodDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dohodDataGrid_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.rashodDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1478, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расходы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rashodDataGrid
            // 
            this.rashodDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rashodDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rashodDataGrid.Location = new System.Drawing.Point(3, 3);
            this.rashodDataGrid.Name = "rashodDataGrid";
            this.rashodDataGrid.RowHeadersWidth = 51;
            this.rashodDataGrid.RowTemplate.Height = 24;
            this.rashodDataGrid.Size = new System.Drawing.Size(1472, 216);
            this.rashodDataGrid.TabIndex = 0;
            this.rashodDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rashodDataGrid_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reloadData);
            this.panel3.Controls.Add(this.rashodLb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dohodLb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.deleteRashodBtn);
            this.panel3.Controls.Add(this.deleteDohodBtn);
            this.panel3.Controls.Add(this.addRashodBtn);
            this.panel3.Controls.Add(this.addDohodBtn);
            this.panel3.Controls.Add(this.balanceLb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1486, 511);
            this.panel3.TabIndex = 0;
            // 
            // reloadData
            // 
            this.reloadData.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.reloadData.FlatAppearance.BorderSize = 3;
            this.reloadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadData.ForeColor = System.Drawing.Color.Blue;
            this.reloadData.Location = new System.Drawing.Point(762, 411);
            this.reloadData.Name = "reloadData";
            this.reloadData.Size = new System.Drawing.Size(313, 67);
            this.reloadData.TabIndex = 25;
            this.reloadData.Text = "Обновить данные";
            this.reloadData.UseVisualStyleBackColor = true;
            this.reloadData.Click += new System.EventHandler(this.reloadData_Click);
            // 
            // rashodLb
            // 
            this.rashodLb.AutoSize = true;
            this.rashodLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rashodLb.ForeColor = System.Drawing.Color.DarkGray;
            this.rashodLb.Location = new System.Drawing.Point(703, 309);
            this.rashodLb.Name = "rashodLb";
            this.rashodLb.Size = new System.Drawing.Size(170, 29);
            this.rashodLb.TabIndex = 24;
            this.rashodLb.Text = "34.310 рублей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(443, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Расходы за месяц:";
            // 
            // dohodLb
            // 
            this.dohodLb.AutoSize = true;
            this.dohodLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dohodLb.ForeColor = System.Drawing.Color.DarkGray;
            this.dohodLb.Location = new System.Drawing.Point(703, 204);
            this.dohodLb.Name = "dohodLb";
            this.dohodLb.Size = new System.Drawing.Size(170, 29);
            this.dohodLb.TabIndex = 22;
            this.dohodLb.Text = "50.000 рублей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(443, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Доход за месяц:";
            // 
            // deleteRashodBtn
            // 
            this.deleteRashodBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteRashodBtn.FlatAppearance.BorderSize = 3;
            this.deleteRashodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRashodBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteRashodBtn.Location = new System.Drawing.Point(1195, 295);
            this.deleteRashodBtn.Name = "deleteRashodBtn";
            this.deleteRashodBtn.Size = new System.Drawing.Size(207, 61);
            this.deleteRashodBtn.TabIndex = 20;
            this.deleteRashodBtn.Text = "Удалить расходы";
            this.deleteRashodBtn.UseVisualStyleBackColor = true;
            this.deleteRashodBtn.Click += new System.EventHandler(this.deleteRashodBtn_Click);
            // 
            // deleteDohodBtn
            // 
            this.deleteDohodBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteDohodBtn.FlatAppearance.BorderSize = 3;
            this.deleteDohodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDohodBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteDohodBtn.Location = new System.Drawing.Point(1195, 190);
            this.deleteDohodBtn.Name = "deleteDohodBtn";
            this.deleteDohodBtn.Size = new System.Drawing.Size(207, 61);
            this.deleteDohodBtn.TabIndex = 19;
            this.deleteDohodBtn.Text = "Удалить доход";
            this.deleteDohodBtn.UseVisualStyleBackColor = true;
            this.deleteDohodBtn.Click += new System.EventHandler(this.deleteDohodBtn_Click);
            // 
            // addRashodBtn
            // 
            this.addRashodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRashodBtn.FlatAppearance.BorderSize = 3;
            this.addRashodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRashodBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRashodBtn.Location = new System.Drawing.Point(970, 295);
            this.addRashodBtn.Name = "addRashodBtn";
            this.addRashodBtn.Size = new System.Drawing.Size(207, 61);
            this.addRashodBtn.TabIndex = 18;
            this.addRashodBtn.Text = "Добавить расходы";
            this.addRashodBtn.UseVisualStyleBackColor = true;
            this.addRashodBtn.Click += new System.EventHandler(this.addRashodBtn_Click);
            // 
            // addDohodBtn
            // 
            this.addDohodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addDohodBtn.FlatAppearance.BorderSize = 3;
            this.addDohodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDohodBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addDohodBtn.Location = new System.Drawing.Point(971, 190);
            this.addDohodBtn.Name = "addDohodBtn";
            this.addDohodBtn.Size = new System.Drawing.Size(207, 61);
            this.addDohodBtn.TabIndex = 17;
            this.addDohodBtn.Text = "Добавить доход";
            this.addDohodBtn.UseVisualStyleBackColor = true;
            this.addDohodBtn.Click += new System.EventHandler(this.addDohodBtn_Click);
            // 
            // balanceLb
            // 
            this.balanceLb.AutoSize = true;
            this.balanceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceLb.ForeColor = System.Drawing.Color.DarkGray;
            this.balanceLb.Location = new System.Drawing.Point(571, 112);
            this.balanceLb.Name = "balanceLb";
            this.balanceLb.Size = new System.Drawing.Size(170, 29);
            this.balanceLb.TabIndex = 16;
            this.balanceLb.Text = "15.960 рублей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(450, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Баланс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(647, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Управление финансами";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyApp.Properties.Resources._5027885_dollar_finance_money_online_payment_icon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // financePage
            // 
            this.financePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.financePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.financePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.financePage.Controls.Add(this.dataRashodPanel);
            this.financePage.Controls.Add(this.dataDohodPanel);
            this.financePage.Controls.Add(this.panel5);
            this.financePage.ForeColor = System.Drawing.SystemColors.Control;
            this.financePage.Location = new System.Drawing.Point(4, 31);
            this.financePage.Name = "financePage";
            this.financePage.Padding = new System.Windows.Forms.Padding(3);
            this.financePage.Size = new System.Drawing.Size(1492, 774);
            this.financePage.TabIndex = 1;
            this.financePage.Text = "Распределение финансов";
            // 
            // dataRashodPanel
            // 
            this.dataRashodPanel.Location = new System.Drawing.Point(735, 131);
            this.dataRashodPanel.Name = "dataRashodPanel";
            this.dataRashodPanel.Size = new System.Drawing.Size(708, 542);
            this.dataRashodPanel.TabIndex = 2;
            // 
            // dataDohodPanel
            // 
            this.dataDohodPanel.Location = new System.Drawing.Point(24, 131);
            this.dataDohodPanel.Name = "dataDohodPanel";
            this.dataDohodPanel.Size = new System.Drawing.Size(681, 542);
            this.dataDohodPanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.popularRashod);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.popularDohod);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1484, 107);
            this.panel5.TabIndex = 0;
            // 
            // popularRashod
            // 
            this.popularRashod.AutoSize = true;
            this.popularRashod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularRashod.ForeColor = System.Drawing.Color.DarkGray;
            this.popularRashod.Location = new System.Drawing.Point(1202, 38);
            this.popularRashod.Name = "popularRashod";
            this.popularRashod.Size = new System.Drawing.Size(21, 29);
            this.popularRashod.TabIndex = 26;
            this.popularRashod.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(909, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Популярный расход:";
            // 
            // popularDohod
            // 
            this.popularDohod.AutoSize = true;
            this.popularDohod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularDohod.ForeColor = System.Drawing.Color.DarkGray;
            this.popularDohod.Location = new System.Drawing.Point(382, 37);
            this.popularDohod.Name = "popularDohod";
            this.popularDohod.Size = new System.Drawing.Size(22, 29);
            this.popularDohod.TabIndex = 24;
            this.popularDohod.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(65, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Самый частый доход:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.infoPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dohodDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rashodDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.financePage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minFormBtn;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.TabPage financePage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label maxFormBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rashodLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dohodLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteRashodBtn;
        private System.Windows.Forms.Button deleteDohodBtn;
        private System.Windows.Forms.Button addRashodBtn;
        private System.Windows.Forms.Button addDohodBtn;
        private System.Windows.Forms.Label balanceLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dohodDataGrid;
        private System.Windows.Forms.DataGridView rashodDataGrid;
        private System.Windows.Forms.Button reloadData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label popularRashod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label popularDohod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel dataDohodPanel;
        private System.Windows.Forms.Panel dataRashodPanel;
    }
}

