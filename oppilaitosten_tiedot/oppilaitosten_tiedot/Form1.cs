using System.Data;
using System.Windows.Forms;

namespace oppilaitosten_tiedot


{
    public partial class avainhloForm : Form
    {
        //luodaan tietotaulut
        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public avainhloForm()
        {
            InitializeComponent();
        }

        private void avainhloForm_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            taytaVastuuhenkilotTaulukko();
            oppilaitosCB.DataSource = oppilaitos;
            oppilaitosCB.DisplayMember = "ONimi";
        }

        private void taytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int)); //itsestään kasvava
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OPostiosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");

        }

        private void taytaVastuuhenkilotTaulukko()
        {
            vastuuHenkilot.Columns.Add("VID", typeof(int)); //itsestään kasvava
            vastuuHenkilot.Columns.Add("VNimi");
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VOsasto");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");

            vastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            vastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            vastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            vastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            vastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            vastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            vastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuHenkilot.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            vastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            vastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            vastuuHenkilot.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            vastuuHenkilot.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            vastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            vastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            vastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            vastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            vastuuHenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            vastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            vastuuHenkilot.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            vastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");

        }

        private void vastuuhloCB_SelectedIndexChanged (object sender, EventArgs e)
        {
            titteliLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VTitteli"].ToString();
            osastoLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VOsasto"].ToString();
            sahkopostiLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VSahkoposti"].ToString();
            puhLB.Text = yhteys.Rows[vastuuhloCB.SelectedIndex]["VPuhelin"].ToString();
        }


        private void oppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxin alle valitut tiedot
            string viite = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OID"].ToString(); //etsitään oppilaitokseen kuuluvia vastuuhenkilöitä 
            osoiteLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OPostiosoite"].ToString();
            postinroLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OPostinumero"].ToString();
            PTpaikkaLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            puhelinLB.Text = oppilaitos.Rows[oppilaitosCB.SelectedIndex]["Opuhelin"].ToString();


            yhteys = vastuuHenkilot.Select("VID =" + viite).CopyToDataTable(); //Select palauttaa valitut rivit Datatableltä
            vastuuhloCB.DataSource = yhteys;
            vastuuhloCB.DisplayMember = "VNimi";
        }
    }
}