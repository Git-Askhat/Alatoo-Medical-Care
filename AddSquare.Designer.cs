namespace Alatoo_Medical_Care
{
    partial class AddSquare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSquare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Upcoming = new System.Windows.Forms.Button();
            this.disease = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.studentId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Upcoming);
            this.panel1.Controls.Add(this.disease);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.studentId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 501);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Upcoming
            // 
            this.Upcoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Upcoming.FlatAppearance.BorderSize = 0;
            this.Upcoming.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Upcoming.ForeColor = System.Drawing.Color.White;
            this.Upcoming.Location = new System.Drawing.Point(100, 380);
            this.Upcoming.Name = "Upcoming";
            this.Upcoming.Size = new System.Drawing.Size(300, 40);
            this.Upcoming.TabIndex = 3;
            this.Upcoming.Text = "Upcoming";
            this.Upcoming.UseVisualStyleBackColor = false;
            this.Upcoming.Click += new System.EventHandler(this.Upcoming_Click);
            // 
            // disease
            // 
            this.disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.disease.Location = new System.Drawing.Point(100, 245);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(300, 31);
            this.disease.TabIndex = 2;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.date.Location = new System.Drawing.Point(100, 180);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(300, 31);
            this.date.TabIndex = 1;
            // 
            // studentId
            // 
            this.studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.studentId.Location = new System.Drawing.Point(100, 115);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(300, 31);
            this.studentId.TabIndex = 0;
            // 
            // AddSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(500, 540);
            this.MinimumSize = new System.Drawing.Size(500, 540);
            this.Name = "AddSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSquare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox disease;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.Button Upcoming;
    }
}