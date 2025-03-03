namespace Ajastin
{
    public partial class aikaForm : Form
    {
        private int kokonaisaika;
        public aikaForm()
        {
            InitializeComponent();
        }

        private void aikaForm_Load(object sender, EventArgs e)
        {
            stopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                minCB.Items.Add(i.ToString());
                sekCB.Items.Add(i.ToString());
            }
            minCB.SelectedIndex = 0;
            sekCB.SelectedIndex = 10;

        }


        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            int minuutit = int.Parse(minCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0) 
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekuntit = kokonaisaika - (minuutit * 60);
                kelloLB.Text = minuutit + ":" + sekuntit;
            }
            else
            {
                ajastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }

        }
    }
}