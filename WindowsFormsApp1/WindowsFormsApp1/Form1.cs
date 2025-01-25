using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int czas =0;
        private int punkty = 0;
        private int odp = -1;
        private int interval = 2000;
        

        private Color[] tablicaKolorow = new Color[8] {
            Color.White,
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Purple,
            Color.Pink,
            Color.Orange
};
        private string[] tablicaTekstow = new string[8]
{
       "biały",
       "czerwony",
       "niebieski",
       "zielony",
       "żółty",
       "fioletowy",
       "różowy",
       "pomarańczowy"
};
        Random rand = new Random();
        private int[] losujNumeryKolorow(int k, int n)
        {
            int[] tab = new int[k];
            bool bad;
            for (int i = 0; i < k; i++)
            {
                do
                {
                    bad = false;
                    tab[i] = rand.Next(n) + 1;
                    for (int j = 0; j < i; j++)
                    {
                        if (tab[i] == tab[j])
                        {
                            bad = true;
                            break;
                        }
                    }
                } while (bad);
            }
            return tab;
        }
        public Form1()
        {
            InitializeComponent();
            label1.Text = "KOLOR :";
            label4.Text = "0";
            label6.Text= czas.ToString();
            
        }

       

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas--;
            label6.Text = czas.ToString();
            if (czas == 0) {
                Ustaw_clickable(false);
                timer1.Stop();
                timer2.Stop();
                
                Form2 reset_window = new Form2($"twoj wynik to : {punkty}");
                reset_window.Show(); }

            }
            private void resetuj_gre() {
            Ustaw_kolor_kafelkow(Color.White);
            label2.Text = "";
            timer2.Interval = interval;
            Reset_timer(timer1);
            Reset_timer(timer2);
            timer1.Enabled = false;
            timer2.Enabled = false;
            czas = 15;
            punkty = 0;
            label4.Text = punkty.ToString();
            label6.Text = czas.ToString();
        }
        private void UstawGre() {
            Ustaw_clickable(true);
            int[] los = losujNumeryKolorow(4, 7);
            odp = rand.Next(4);
            label2.Text = tablicaTekstow[los[odp]];
            label2.BackColor = tablicaKolorow[rand.Next(7)];
            panel1.BackColor = tablicaKolorow[los[0]];
            panel2.BackColor = tablicaKolorow[los[1]];
            panel3.BackColor = tablicaKolorow[los[2]];
            panel4.BackColor = tablicaKolorow[los[3]];
        }
        private void Ustaw_kolor_kafelkow(Color color) {
            panel1.BackColor = color;
            panel2.BackColor = color;
            panel3.BackColor = color;
            panel4.BackColor = color;
        }
       

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (odp == 0) { punkty++; } else { punkty-=2; }
            timer2.Stop();
            timer2.Start();
            label4.Text=punkty.ToString();
            UstawGre();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

            if (odp == 1) { punkty++; } else { punkty-=2; }
            timer2.Stop();
            timer2.Start();
            label4.Text = punkty.ToString();
            UstawGre();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {

            if (odp == 3) { punkty++; } else { punkty-=2; }
            timer2.Stop();
            timer2.Start();
            label4.Text = punkty.ToString();
            UstawGre();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (odp == 2) { punkty++; } else { punkty-=2; }
            timer2.Stop();
            timer2.Start();
            label4.Text = punkty.ToString();
            UstawGre();
        }
        private void Ustaw_clickable(bool x) { 
        panel1.Enabled = x;
        panel2.Enabled = x;
        panel3.Enabled = x;
        panel4.Enabled = x;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            punkty -= 5;
            label4.Text=punkty.ToString();
            UstawGre();
        }

        private void brązToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in x.GetCurrentParent().Items)
            {
                if (item != x)
                {
                    item.Checked = false;
                }
            }
            if (x.Checked) { interval = 2000; }
            else
            {
                interval = 2000;
            }
            
        }

        private void srebroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in x.GetCurrentParent().Items)
            {
                if (item != x)
                {
                    item.Checked = false;
                }
            }
            if (x.Checked) { interval = 1500; }
            else
            {
                interval = 2000;
            }
        }

        private void złotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem x = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in x.GetCurrentParent().Items)
            {
                if (item != x)
                {
                    item.Checked = false;
                }
            }
            if (x.Checked) { interval = 1000; }
            else
            {
                interval = 2000;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czas = 15;
            punkty = 0;
            label4.Text = punkty.ToString();
            label6.Text = czas.ToString();
            timer2.Interval = interval;
            Reset_timer(timer1);
            Reset_timer(timer2);
            timer1.Enabled = true;
            timer2.Enabled = true;
            UstawGre();
        }

        private void resetujAplikacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetuj_gre();

        }
        
        private void Reset_timer(Timer timer) { 
            timer.Stop();
            timer.Start();
        }
        
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tworcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 reset_window = new Form2("tworcy : ja");
            reset_window.Show();
        }
    }
}
