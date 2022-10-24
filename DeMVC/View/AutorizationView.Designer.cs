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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxSe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
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
            this.groupBoxAuto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(360, 237);
            this.groupBoxAuto.TabIndex = 1;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Введите логин и пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(64, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(195, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(64, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(195, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(128, 185);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // checkBoxSe
            // 
            this.checkBoxSe.AutoSize = true;
            this.checkBoxSe.Location = new System.Drawing.Point(271, 143);
            this.checkBoxSe.Name = "checkBoxSe";
            this.checkBoxSe.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSe.TabIndex = 4;
            this.checkBoxSe.Text = "Показать";
            this.checkBoxSe.UseVisualStyleBackColor = true;
            this.checkBoxSe.CheckedChanged += new System.EventHandler(this.checkBoxSe_CheckedChanged);
            
            // 
            // AutorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBoxAuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

