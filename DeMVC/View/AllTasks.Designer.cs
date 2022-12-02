namespace DeMVC.View
{
    partial class AllTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTasks));
            this.buttonManageCoef = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tasksButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManageCoef
            // 
            this.buttonManageCoef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonManageCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageCoef.Location = new System.Drawing.Point(34, 110);
            this.buttonManageCoef.Margin = new System.Windows.Forms.Padding(4);
            this.buttonManageCoef.Name = "buttonManageCoef";
            this.buttonManageCoef.Size = new System.Drawing.Size(429, 66);
            this.buttonManageCoef.TabIndex = 0;
            this.buttonManageCoef.Text = "Управление коэффициентами";
            this.buttonManageCoef.UseVisualStyleBackColor = false;
            this.buttonManageCoef.Click += new System.EventHandler(this.buttonManageCoef_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tasksButton
            // 
            this.tasksButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksButton.Location = new System.Drawing.Point(34, 204);
            this.tasksButton.Margin = new System.Windows.Forms.Padding(4);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(429, 59);
            this.tasksButton.TabIndex = 2;
            this.tasksButton.Text = "Задачи";
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Исполнители";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonManageCoef);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllTasks";
            this.Text = "Панель управления";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCoef;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button button1;
    }
}