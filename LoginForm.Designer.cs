﻿namespace DPPMAIN
{
    partial class LoginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPatient);
            this.groupBox1.Controls.Add(this.btndoctor);
            this.groupBox1.Controls.Add(this.btnadmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(242, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN AS-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 146);
            this.panel1.TabIndex = 1;
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(51, 50);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(240, 74);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(51, 142);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(240, 74);
            this.btndoctor.TabIndex = 1;
            this.btndoctor.Text = "DOCTOR";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(51, 228);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(240, 74);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO DOCTOR PATIENT PORTAL";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}