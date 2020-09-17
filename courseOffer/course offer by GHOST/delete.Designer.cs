namespace course_offer_by_GHOST
{
    partial class delete
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
            this.logo = new System.Windows.Forms.Panel();
            this.ghost = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dcc = new System.Windows.Forms.TextBox();
            this.dback = new System.Windows.Forms.Button();
            this.logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Navy;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logo.Controls.Add(this.ghost);
            this.logo.Location = new System.Drawing.Point(12, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(106, 76);
            this.logo.TabIndex = 3;
            // 
            // ghost
            // 
            this.ghost.AutoSize = true;
            this.ghost.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghost.ForeColor = System.Drawing.Color.Blue;
            this.ghost.Location = new System.Drawing.Point(12, 19);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(78, 33);
            this.ghost.TabIndex = 0;
            this.ghost.Text = "GHOST";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.heading.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Maroon;
            this.heading.Location = new System.Drawing.Point(216, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(155, 36);
            this.heading.TabIndex = 2;
            this.heading.Text = "Course Offer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(328, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Code: ";
            // 
            // dcc
            // 
            this.dcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcc.Location = new System.Drawing.Point(273, 96);
            this.dcc.Name = "dcc";
            this.dcc.Size = new System.Drawing.Size(130, 22);
            this.dcc.TabIndex = 6;
            // 
            // dback
            // 
            this.dback.BackColor = System.Drawing.Color.Blue;
            this.dback.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dback.Location = new System.Drawing.Point(504, 284);
            this.dback.Name = "dback";
            this.dback.Size = new System.Drawing.Size(88, 49);
            this.dback.TabIndex = 7;
            this.dback.Text = "Back";
            this.dback.UseVisualStyleBackColor = false;
            this.dback.Click += new System.EventHandler(this.dback_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 336);
            this.Controls.Add(this.dback);
            this.Controls.Add(this.dcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.heading);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label ghost;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dcc;
        private System.Windows.Forms.Button dback;
    }
}