namespace DeMVC
{
    partial class AutorizationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.checkBoxSe = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.checkBoxSe);
            this.groupBoxAuto.Controls.Add(this.buttonOk);
            this.groupBoxAuto.Controls.Add(this.textBoxPassword);
            this.groupBoxAuto.Controls.Add(this.textBoxLogin);
            this.groupBoxAuto.Controls.Add(this.pictureBox1);
            this.groupBoxAuto.Location = new System.Drawing.Point(18, 18);
            this.groupBoxAuto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBoxAuto.Size = new System.Drawing.Size(540, 365);
            this.groupBoxAuto.TabIndex = 1;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Введите логин и пароль";
            // 
            // checkBoxSe
            // 
            this.checkBoxSe.AutoSize = true;
            this.checkBoxSe.Location = new System.Drawing.Point(407, 220);
            this.checkBoxSe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBoxSe.Name = "checkBoxSe";
            this.checkBoxSe.Size = new System.Drawing.Size(101, 24);
            this.checkBoxSe.TabIndex = 4;
            this.checkBoxSe.Text = "Показать";
            this.checkBoxSe.UseVisualStyleBackColor = true;
            this.checkBoxSe.CheckedChanged += new System.EventHandler(this.checkBoxSe_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(192, 285);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(113, 35);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(96, 215);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(290, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(96, 138);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(290, 26);
            this.textBoxLogin.TabIndex = 1;
            // 
            // AutorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.groupBoxAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AutorizationView";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.CheckBox checkBoxSe;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

