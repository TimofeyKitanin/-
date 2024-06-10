namespace MoneyApp
{
    partial class AddRashodForm
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
            this.addRashodBtn = new System.Windows.Forms.Button();
            this.categoriaRashodCB = new System.Windows.Forms.ComboBox();
            this.sumaRashodTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRashodBtn
            // 
            this.addRashodBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addRashodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRashodBtn.FlatAppearance.BorderSize = 3;
            this.addRashodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRashodBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRashodBtn.Location = new System.Drawing.Point(168, 279);
            this.addRashodBtn.Name = "addRashodBtn";
            this.addRashodBtn.Size = new System.Drawing.Size(207, 61);
            this.addRashodBtn.TabIndex = 25;
            this.addRashodBtn.Text = "Добавить расход";
            this.addRashodBtn.UseVisualStyleBackColor = false;
            this.addRashodBtn.Click += new System.EventHandler(this.addRashodBtn_Click);
            // 
            // categoriaRashodCB
            // 
            this.categoriaRashodCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriaRashodCB.FormattingEnabled = true;
            this.categoriaRashodCB.Items.AddRange(new object[] {
            "Здоровье",
            "Досуг",
            "Дом",
            "Кафе",
            "Образование",
            "Подарки",
            "Продукты"});
            this.categoriaRashodCB.Location = new System.Drawing.Point(159, 192);
            this.categoriaRashodCB.Name = "categoriaRashodCB";
            this.categoriaRashodCB.Size = new System.Drawing.Size(338, 33);
            this.categoriaRashodCB.TabIndex = 24;
            // 
            // sumaRashodTb
            // 
            this.sumaRashodTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumaRashodTb.Location = new System.Drawing.Point(160, 116);
            this.sumaRashodTb.Multiline = true;
            this.sumaRashodTb.Name = "sumaRashodTb";
            this.sumaRashodTb.Size = new System.Drawing.Size(321, 37);
            this.sumaRashodTb.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cумма:";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(539, 15);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 25);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Х";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Добавление расхода";
            // 
            // AddRashodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 431);
            this.Controls.Add(this.addRashodBtn);
            this.Controls.Add(this.categoriaRashodCB);
            this.Controls.Add(this.sumaRashodTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRashodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRashodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRashodBtn;
        private System.Windows.Forms.ComboBox categoriaRashodCB;
        private System.Windows.Forms.TextBox sumaRashodTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Label label1;
    }
}