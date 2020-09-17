namespace course_offer_by_GHOST
{
    partial class admin
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
            this.name = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.ghost = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Maroon;
            this.name.Location = new System.Drawing.Point(290, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(172, 39);
            this.name.TabIndex = 0;
            this.name.Text = "Course Offer";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Navy;
            this.logo.Controls.Add(this.ghost);
            this.logo.Location = new System.Drawing.Point(12, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(103, 70);
            this.logo.TabIndex = 1;
            // 
            // ghost
            // 
            this.ghost.AutoSize = true;
            this.ghost.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghost.ForeColor = System.Drawing.Color.Blue;
            this.ghost.Location = new System.Drawing.Point(0, 14);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(97, 33);
            this.ghost.TabIndex = 0;
            this.ghost.Text = "GHOST";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Blue;
            this.insert.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insert.Location = new System.Drawing.Point(174, 80);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(95, 47);
            this.insert.TabIndex = 6;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Blue;
            this.delete.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Location = new System.Drawing.Point(262, 80);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Blue;
            this.update.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update.Location = new System.Drawing.Point(352, 80);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 47);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Blue;
            this.display.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.display.Location = new System.Drawing.Point(442, 80);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(93, 48);
            this.display.TabIndex = 6;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 198);
            this.dataGridView1.TabIndex = 7;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Blue;
            this.logout.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.Location = new System.Drawing.Point(466, 345);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(93, 48);
            this.logout.TabIndex = 6;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.display);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "admin";
            this.Text = "admin";
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label ghost;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logout;
    }
}