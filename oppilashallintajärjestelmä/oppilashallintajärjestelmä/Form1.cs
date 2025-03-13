using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppilashallintajärjestelmä
{
    public partial class ohjFORM : Form
    {
        Opiskelija opiskelija = new Opiskelija();
        public ohjFORM()
        {
            InitializeComponent();
        }

        private void ohjFORM_Load(object sender, EventArgs e)
        {
            tietotauluDT.DataSource = opiskelija.haeOpiskelijat();

        }

        private void tyhjennaTB_Click(object sender, EventArgs e)
        {
            IDTB = "";
            etunimiTB = "";
            sukunimiTB = "";
            puhelinTB = "";
            sahkopostiTB = "";
            opiskelijanroTB = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
                    {
                MessageBox.Show("Virhe - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);

            }

        }
    }
}
