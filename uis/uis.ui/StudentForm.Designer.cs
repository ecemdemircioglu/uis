﻿namespace uis.ui
{
    partial class StudentForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnStudentPictureUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 12);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyadı";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogStudentPicture";
            // 
            // btnStudentPictureUpload
            // 
            btnStudentPictureUpload.Location = new Point(40, 194);
            btnStudentPictureUpload.Name = "btnStudentPictureUpload";
            btnStudentPictureUpload.Size = new Size(111, 23);
            btnStudentPictureUpload.TabIndex = 5;
            btnStudentPictureUpload.Text = "Upload Picture";
            btnStudentPictureUpload.UseVisualStyleBackColor = true;
            btnStudentPictureUpload.Click += btnStudentPictureUpload_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudentPictureUpload);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button btnStudentPictureUpload;
    }
}