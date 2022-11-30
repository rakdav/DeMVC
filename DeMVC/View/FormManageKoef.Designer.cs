namespace DeMVC.View
{
    partial class FormManageKoef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageKoef));
            this.listBoxWorks = new System.Windows.Forms.ListBox();
            this.textBoxJunior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMiddle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSenior = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxTO = new System.Windows.Forms.TextBox();
            this.textBoxComplex = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxDeployment = new System.Windows.Forms.TextBox();
            this.textBoxAnaliz = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWorks
            // 
            this.listBoxWorks.FormattingEnabled = true;
            this.listBoxWorks.ItemHeight = 20;
            this.listBoxWorks.Location = new System.Drawing.Point(12, 32);
            this.listBoxWorks.Name = "listBoxWorks";
            this.listBoxWorks.Size = new System.Drawing.Size(249, 364);
            this.listBoxWorks.TabIndex = 0;
            this.listBoxWorks.SelectedIndexChanged += new System.EventHandler(this.listBoxWorks_SelectedIndexChanged);
            // 
            // textBoxJunior
            // 
            this.textBoxJunior.Location = new System.Drawing.Point(329, 70);
            this.textBoxJunior.Name = "textBoxJunior";
            this.textBoxJunior.Size = new System.Drawing.Size(153, 26);
            this.textBoxJunior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "junior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "middle";
            // 
            // textBoxMiddle
            // 
            this.textBoxMiddle.Location = new System.Drawing.Point(329, 119);
            this.textBoxMiddle.Name = "textBoxMiddle";
            this.textBoxMiddle.Size = new System.Drawing.Size(153, 26);
            this.textBoxMiddle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "senior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Исполнитель";
            // 
            // textBoxSenior
            // 
            this.textBoxSenior.Location = new System.Drawing.Point(329, 171);
            this.textBoxSenior.Name = "textBoxSenior";
            this.textBoxSenior.Size = new System.Drawing.Size(153, 26);
            this.textBoxSenior.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxTime);
            this.groupBox1.Controls.Add(this.textBoxTO);
            this.groupBox1.Controls.Add(this.textBoxComplex);
            this.groupBox1.Controls.Add(this.textBoxMoney);
            this.groupBox1.Controls.Add(this.textBoxDeployment);
            this.groupBox1.Controls.Add(this.textBoxAnaliz);
            this.groupBox1.Location = new System.Drawing.Point(268, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэффициенты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Денежный эквивалент";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Время исполнения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Сложность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ТО и сопровождение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Установка оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Анализ и проектирование";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(231, 154);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 26);
            this.textBoxTime.TabIndex = 5;
            // 
            // textBoxTO
            // 
            this.textBoxTO.Location = new System.Drawing.Point(231, 90);
            this.textBoxTO.Name = "textBoxTO";
            this.textBoxTO.Size = new System.Drawing.Size(100, 26);
            this.textBoxTO.TabIndex = 4;
            // 
            // textBoxComplex
            // 
            this.textBoxComplex.Location = new System.Drawing.Point(231, 122);
            this.textBoxComplex.Name = "textBoxComplex";
            this.textBoxComplex.Size = new System.Drawing.Size(100, 26);
            this.textBoxComplex.TabIndex = 3;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(231, 186);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 26);
            this.textBoxMoney.TabIndex = 2;
            // 
            // textBoxDeployment
            // 
            this.textBoxDeployment.Location = new System.Drawing.Point(231, 58);
            this.textBoxDeployment.Name = "textBoxDeployment";
            this.textBoxDeployment.Size = new System.Drawing.Size(100, 26);
            this.textBoxDeployment.TabIndex = 1;
            // 
            // textBoxAnaliz
            // 
            this.textBoxAnaliz.Location = new System.Drawing.Point(231, 26);
            this.textBoxAnaliz.Name = "textBoxAnaliz";
            this.textBoxAnaliz.Size = new System.Drawing.Size(100, 26);
            this.textBoxAnaliz.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(16, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(245, 46);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 109);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormManageKoef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSenior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJunior);
            this.Controls.Add(this.listBoxWorks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManageKoef";
            this.Text = "Управление менеджерами ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorks;
        private System.Windows.Forms.TextBox textBoxJunior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMiddle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSenior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxTO;
        private System.Windows.Forms.TextBox textBoxComplex;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxDeployment;
        private System.Windows.Forms.TextBox textBoxAnaliz;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}