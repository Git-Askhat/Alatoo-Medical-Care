namespace Alatoo_Medical_Care
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.notificationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.historyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homePagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.history = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.upcoming = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.homePageOpacity = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.history.SuspendLayout();
            this.upcoming.SuspendLayout();
            this.homePageOpacity.SuspendLayout();
            this.add.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.Black;
            this.notificationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationPanel.BackgroundImage")));
            this.notificationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notificationPanel.Location = new System.Drawing.Point(3, 378);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(144, 122);
            this.notificationPanel.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.Black;
            this.addPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPanel.BackgroundImage")));
            this.addPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addPanel.Location = new System.Drawing.Point(3, 253);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(144, 122);
            this.addPanel.TabIndex = 1;
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.Color.Black;
            this.historyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyPanel.BackgroundImage")));
            this.historyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.historyPanel.Location = new System.Drawing.Point(3, 128);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(144, 122);
            this.historyPanel.TabIndex = 1;
            this.historyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.historyPanel_Paint);
            // 
            // homePagePanel
            // 
            this.homePagePanel.BackColor = System.Drawing.Color.Black;
            this.homePagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePagePanel.BackgroundImage")));
            this.homePagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homePagePanel.Location = new System.Drawing.Point(3, 3);
            this.homePagePanel.Name = "homePagePanel";
            this.homePagePanel.Size = new System.Drawing.Size(144, 122);
            this.homePagePanel.TabIndex = 1;
            this.homePagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePagePanel_Paint);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.Black;
            this.history.Controls.Add(this.label1);
            this.history.Controls.Add(this.panel1);
            this.history.Controls.Add(this.button1);
            this.history.Location = new System.Drawing.Point(33, 100);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(200, 300);
            this.history.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(85, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upcoming
            // 
            this.upcoming.BackColor = System.Drawing.Color.Black;
            this.upcoming.Controls.Add(this.label3);
            this.upcoming.Controls.Add(this.label2);
            this.upcoming.Controls.Add(this.panel3);
            this.upcoming.Controls.Add(this.button3);
            this.upcoming.Location = new System.Drawing.Point(499, 100);
            this.upcoming.Name = "upcoming";
            this.upcoming.Size = new System.Drawing.Size(200, 300);
            this.upcoming.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(25, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Upcoming";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // homePageOpacity
            // 
            this.homePageOpacity.BackColor = System.Drawing.Color.Transparent;
            this.homePageOpacity.Controls.Add(this.add);
            this.homePageOpacity.Controls.Add(this.upcoming);
            this.homePageOpacity.Controls.Add(this.history);
            this.homePageOpacity.Location = new System.Drawing.Point(150, 0);
            this.homePageOpacity.Name = "homePageOpacity";
            this.homePageOpacity.Size = new System.Drawing.Size(735, 501);
            this.homePageOpacity.TabIndex = 0;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.Controls.Add(this.panel2);
            this.add.Controls.Add(this.button2);
            this.add.Location = new System.Drawing.Point(266, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 300);
            this.add.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(30, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 140);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(25, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add Patient";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.homePagePanel);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.homePageOpacity);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.history.ResumeLayout(false);
            this.history.PerformLayout();
            this.upcoming.ResumeLayout(false);
            this.upcoming.PerformLayout();
            this.homePageOpacity.ResumeLayout(false);
            this.add.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel notificationPanel;
        private System.Windows.Forms.FlowLayoutPanel addPanel;
        private System.Windows.Forms.FlowLayoutPanel historyPanel;
        private System.Windows.Forms.FlowLayoutPanel homePagePanel;
        private System.Windows.Forms.Panel history;
        private System.Windows.Forms.Panel upcoming;
        private System.Windows.Forms.Panel homePageOpacity;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}