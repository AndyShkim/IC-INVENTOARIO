﻿namespace Qr_Code_Generator
{
    partial class GeneratorForm
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
            this.btnQr = new System.Windows.Forms.Button();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgQr = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQr
            // 
            this.btnQr.Font = new System.Drawing.Font("Intel Clear", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQr.Location = new System.Drawing.Point(360, 260);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(104, 38);
            this.btnQr.TabIndex = 1;
            this.btnQr.Text = "Generar";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(93, 261);
            this.txtQr.Multiline = true;
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(252, 37);
            this.txtQr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qr";
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(93, 12);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(252, 218);
            this.imgQr.TabIndex = 4;
            this.imgQr.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgQr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQr);
            this.Controls.Add(this.btnQr);
            this.Name = "GeneratorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgQr;
        private System.Windows.Forms.Button button1;
    }
}
