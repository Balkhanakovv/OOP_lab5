﻿namespace WinForms_Galery
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
            this.galeryCircle1 = new WinForms_Galery.GaleryCircle();
            this.galery1 = new WinForms_Galery.Galery();
            this.SuspendLayout();
            // 
            // galeryCircle1
            // 
            this.galeryCircle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galeryCircle1.ForeColor = System.Drawing.Color.White;
            this.galeryCircle1.Location = new System.Drawing.Point(95, 103);
            this.galeryCircle1.Name = "galeryCircle1";
            this.galeryCircle1.Size = new System.Drawing.Size(200, 200);
            this.galeryCircle1.TabIndex = 2;
            this.galeryCircle1.Text = "galeryCircle1";
            this.galeryCircle1.UseVisualStyleBackColor = true;
            // 
            // galery1
            // 
            this.galery1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galery1.ForeColor = System.Drawing.Color.White;
            this.galery1.Location = new System.Drawing.Point(503, 103);
            this.galery1.Name = "galery1";
            this.galery1.Size = new System.Drawing.Size(200, 200);
            this.galery1.TabIndex = 3;
            this.galery1.Text = "galery1";
            this.galery1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.galery1);
            this.Controls.Add(this.galeryCircle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GaleryCircle galeryCircle1;
        private Galery galery1;
    }
}

