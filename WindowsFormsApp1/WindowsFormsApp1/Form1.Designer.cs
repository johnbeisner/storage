using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(List<UserDetails> outputPayload)
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(126, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(359, 100);
            this.Label1.Text = $"Name: {outputPayload[0].name} Age: {outputPayload[0].age} Phone: {outputPayload[0].number} Bio: {outputPayload[0].bio}";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(126, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(359, 100);
            this.Label2.Text = $"Name: {outputPayload[1].name} Age: {outputPayload[1].age} Phone: {outputPayload[1].number} Bio: {outputPayload[1].bio}";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(126, 231);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(359, 100);
            this.Label3.Text = $"Name: {outputPayload[2].name} Age: {outputPayload[2].age} Phone: {outputPayload[2].number} Bio: {outputPayload[2].bio}";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(126, 336);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(359, 100);
            this.Label4.Text = $"Name: {outputPayload[3].name} Age: {outputPayload[3].age} Phone: {outputPayload[3].number} Bio: {outputPayload[3].bio}";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(126, 441);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(359, 100);
            this.Label5.Text = $"Name: {outputPayload[4].name} Age: {outputPayload[4].age} Phone: {outputPayload[4].number} Bio: {outputPayload[4].bio}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.ImageLocation = outputPayload[0].photo;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(21, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.ImageLocation = outputPayload[1].photo;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(21, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.ImageLocation = outputPayload[2].photo;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(21, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.ImageLocation = outputPayload[3].photo;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(21, 441);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.ImageLocation = outputPayload[4].photo;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 562);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form1";
            this.Text = "The 5 Youngest Users with Valid U.S. Telephone Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
    }
}

