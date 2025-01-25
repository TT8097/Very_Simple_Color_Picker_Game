namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujAplikacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziomTrudnościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brązToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srebroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.złotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tworcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(622, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(428, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 100);
            this.panel2.TabIndex = 1;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(218, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 100);
            this.panel3.TabIndex = 2;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(219, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label2.Location = new System.Drawing.Point(420, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 44);
            this.label2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(29, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 100);
            this.panel4.TabIndex = 5;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "wynik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "czas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcjaToolStripMenuItem,
            this.poziomTrudnościToolStripMenuItem,
            this.informatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akcjaToolStripMenuItem
            // 
            this.akcjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resetujAplikacjeToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.akcjaToolStripMenuItem.Name = "akcjaToolStripMenuItem";
            this.akcjaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.akcjaToolStripMenuItem.Text = "akcja";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // resetujAplikacjeToolStripMenuItem
            // 
            this.resetujAplikacjeToolStripMenuItem.Name = "resetujAplikacjeToolStripMenuItem";
            this.resetujAplikacjeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resetujAplikacjeToolStripMenuItem.Text = "Resetuj aplikacje";
            this.resetujAplikacjeToolStripMenuItem.Click += new System.EventHandler(this.resetujAplikacjeToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // poziomTrudnościToolStripMenuItem
            // 
            this.poziomTrudnościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brązToolStripMenuItem,
            this.srebroToolStripMenuItem,
            this.złotoToolStripMenuItem});
            this.poziomTrudnościToolStripMenuItem.Name = "poziomTrudnościToolStripMenuItem";
            this.poziomTrudnościToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.poziomTrudnościToolStripMenuItem.Text = "Poziom trudności";
            // 
            // brązToolStripMenuItem
            // 
            this.brązToolStripMenuItem.CheckOnClick = true;
            this.brązToolStripMenuItem.Name = "brązToolStripMenuItem";
            this.brązToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.brązToolStripMenuItem.Text = "Brąz(2 s)";
            this.brązToolStripMenuItem.Click += new System.EventHandler(this.brązToolStripMenuItem_Click);
            // 
            // srebroToolStripMenuItem
            // 
            this.srebroToolStripMenuItem.CheckOnClick = true;
            this.srebroToolStripMenuItem.Name = "srebroToolStripMenuItem";
            this.srebroToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.srebroToolStripMenuItem.Text = "Srebro(1.5 s)";
            this.srebroToolStripMenuItem.Click += new System.EventHandler(this.srebroToolStripMenuItem_Click);
            // 
            // złotoToolStripMenuItem
            // 
            this.złotoToolStripMenuItem.CheckOnClick = true;
            this.złotoToolStripMenuItem.Name = "złotoToolStripMenuItem";
            this.złotoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.złotoToolStripMenuItem.Text = "Złoto(1s)";
            this.złotoToolStripMenuItem.Click += new System.EventHandler(this.złotoToolStripMenuItem_Click);
            // 
            // informatorToolStripMenuItem
            // 
            this.informatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tworcyToolStripMenuItem});
            this.informatorToolStripMenuItem.Name = "informatorToolStripMenuItem";
            this.informatorToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.informatorToolStripMenuItem.Text = "Informator";
            // 
            // tworcyToolStripMenuItem
            // 
            this.tworcyToolStripMenuItem.Name = "tworcyToolStripMenuItem";
            this.tworcyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.tworcyToolStripMenuItem.Text = "Tworcy";
            this.tworcyToolStripMenuItem.Click += new System.EventHandler(this.tworcyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetujAplikacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziomTrudnościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brązToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem srebroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem złotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tworcyToolStripMenuItem;
    }
}

