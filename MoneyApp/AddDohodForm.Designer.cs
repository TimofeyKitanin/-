namespace MoneyApp
{
    partial class AddDohodForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumaDohodTb = new System.Windows.Forms.TextBox();
            this.categoriaDohodCB = new System.Windows.Forms.ComboBox();
            this.addDohodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление дохода";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(548, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 25);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Х";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Категория:";
            // 
            // sumaDohodTb
            // 
            this.sumaDohodTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumaDohodTb.Location = new System.Drawing.Point(169, 110);
            this.sumaDohodTb.Multiline = true;
            this.sumaDohodTb.Name = "sumaDohodTb";
            this.sumaDohodTb.Size = new System.Drawing.Size(321, 37);
            this.sumaDohodTb.TabIndex = 4;
            // 
            // categoriaDohodCB
            // 
            this.categoriaDohodCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriaDohodCB.FormattingEnabled = true;
            this.categoriaDohodCB.Items.AddRange(new object[] {
            "Зарплата",
            "Подработка",
            "Подарок",
            "Дивиденды",
            "Рента "});
            this.categoriaDohodCB.Location = new System.Drawing.Point(168, 186);
            this.categoriaDohodCB.Name = "categoriaDohodCB";
            this.categoriaDohodCB.Size = new System.Drawing.Size(338, 33);
            this.categoriaDohodCB.TabIndex = 5;
            // 
            // addDohodBtn
            // 
            this.addDohodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addDohodBtn.FlatAppearance.BorderSize = 3;
            this.addDohodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDohodBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addDohodBtn.Location = new System.Drawing.Point(177, 273);
            this.addDohodBtn.Name = "addDohodBtn";
            this.addDohodBtn.Size = new System.Drawing.Size(207, 61);
            this.addDohodBtn.TabIndex = 18;
            this.addDohodBtn.Text = "Добавить доход";
            this.addDohodBtn.UseVisualStyleBackColor = true;
            this.addDohodBtn.Click += new System.EventHandler(this.addDohodBtn_Click);
            // 
            // AddDohodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 431);
            this.Controls.Add(this.addDohodBtn);
            this.Controls.Add(this.categoriaDohodCB);
            this.Controls.Add(this.sumaDohodTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDohodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDohodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumaDohodTb;
        private System.Windows.Forms.ComboBox categoriaDohodCB;
        private System.Windows.Forms.Button addDohodBtn;
    }
}