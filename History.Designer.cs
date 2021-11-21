﻿namespace Alatoo_Medical_Care
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faculty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAlpha1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAlpha2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAlpha3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAlpha4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelAlpha1.SuspendLayout();
            this.panelAlpha2.SuspendLayout();
            this.panelAlpha3.SuspendLayout();
            this.panelAlpha4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 501);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.faculty,
            this.number,
            this.disease,
            this.time});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(735, 501);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // surname
            // 
            this.surname.Text = "Surname";
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surname.Width = 100;
            // 
            // faculty
            // 
            this.faculty.Text = "Faculty";
            this.faculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.faculty.Width = 100;
            // 
            // number
            // 
            this.number.Text = "Number";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.Width = 100;
            // 
            // disease
            // 
            this.disease.Text = "Disease";
            this.disease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disease.Width = 180;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 150;
            // 
            // panelAlpha1
            // 
            this.panelAlpha1.Controls.Add(this.button1);
            this.panelAlpha1.Location = new System.Drawing.Point(3, 3);
            this.panelAlpha1.Name = "panelAlpha1";
            this.panelAlpha1.Size = new System.Drawing.Size(144, 122);
            this.panelAlpha1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 122);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAlpha2
            // 
            this.panelAlpha2.Controls.Add(this.button2);
            this.panelAlpha2.Location = new System.Drawing.Point(3, 128);
            this.panelAlpha2.Name = "panelAlpha2";
            this.panelAlpha2.Size = new System.Drawing.Size(144, 122);
            this.panelAlpha2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 122);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelAlpha3
            // 
            this.panelAlpha3.Controls.Add(this.button3);
            this.panelAlpha3.Location = new System.Drawing.Point(3, 253);
            this.panelAlpha3.Name = "panelAlpha3";
            this.panelAlpha3.Size = new System.Drawing.Size(144, 122);
            this.panelAlpha3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 122);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelAlpha4
            // 
            this.panelAlpha4.Controls.Add(this.button4);
            this.panelAlpha4.Location = new System.Drawing.Point(3, 378);
            this.panelAlpha4.Name = "panelAlpha4";
            this.panelAlpha4.Size = new System.Drawing.Size(144, 122);
            this.panelAlpha4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 122);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.panelAlpha2);
            this.Controls.Add(this.panelAlpha3);
            this.Controls.Add(this.panelAlpha4);
            this.Controls.Add(this.panelAlpha1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 540);
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panelAlpha1.ResumeLayout(false);
            this.panelAlpha2.ResumeLayout(false);
            this.panelAlpha3.ResumeLayout(false);
            this.panelAlpha4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAlpha1;
        private System.Windows.Forms.Panel panelAlpha2;
        private System.Windows.Forms.Panel panelAlpha3;
        private System.Windows.Forms.Panel panelAlpha4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader faculty;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader disease;
        private System.Windows.Forms.ColumnHeader time;
    }
}