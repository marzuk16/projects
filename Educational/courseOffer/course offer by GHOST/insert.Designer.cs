﻿namespace course_offer_by_GHOST
{
    partial class insert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.icc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ict = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ich = new System.Windows.Forms.TextBox();
            this.iinsert = new System.Windows.Forms.Button();
            this.dback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 59);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "GHOST";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DarkRed;
            this.name.Location = new System.Drawing.Point(180, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 36);
            this.name.TabIndex = 2;
            this.name.Text = "Course Offer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Code: ";
            // 
            // icc
            // 
            this.icc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icc.Location = new System.Drawing.Point(239, 114);
            this.icc.Name = "icc";
            this.icc.Size = new System.Drawing.Size(198, 22);
            this.icc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Title: ";
            // 
            // ict
            // 
            this.ict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ict.Location = new System.Drawing.Point(239, 140);
            this.ict.Name = "ict";
            this.ict.Size = new System.Drawing.Size(198, 22);
            this.ict.TabIndex = 5;
            this.ict.TextChanged += new System.EventHandler(this.ict_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Credit Hour: ";
            // 
            // ich
            // 
            this.ich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ich.Location = new System.Drawing.Point(239, 166);
            this.ich.Name = "ich";
            this.ich.Size = new System.Drawing.Size(198, 22);
            this.ich.TabIndex = 5;
            // 
            // iinsert
            // 
            this.iinsert.BackColor = System.Drawing.Color.Blue;
            this.iinsert.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iinsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iinsert.Location = new System.Drawing.Point(362, 194);
            this.iinsert.Name = "iinsert";
            this.iinsert.Size = new System.Drawing.Size(75, 35);
            this.iinsert.TabIndex = 6;
            this.iinsert.Text = "Insert";
            this.iinsert.UseVisualStyleBackColor = false;
            this.iinsert.Click += new System.EventHandler(this.iinsert_Click);
            // 
            // dback
            // 
            this.dback.BackColor = System.Drawing.Color.Blue;
            this.dback.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dback.Location = new System.Drawing.Point(478, 272);
            this.dback.Name = "dback";
            this.dback.Size = new System.Drawing.Size(88, 49);
            this.dback.TabIndex = 8;
            this.dback.Text = "Back";
            this.dback.UseVisualStyleBackColor = false;
            this.dback.Click += new System.EventHandler(this.dback_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 323);
            this.Controls.Add(this.dback);
            this.Controls.Add(this.iinsert);
            this.Controls.Add(this.ich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.icc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Name = "insert";
            this.Text = "insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox icc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ich;
        private System.Windows.Forms.Button iinsert;
        private System.Windows.Forms.Button dback;
    }
}