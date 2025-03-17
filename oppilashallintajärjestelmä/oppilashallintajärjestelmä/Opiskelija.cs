using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace oppilashallintajärjestelmä
{
    internal class Opiskelija
    {
        Yhdista yhteys = new Yhdista();


        //lisätään opiskelija
        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO opiskelijat (etunimi, sukunimi, puhelin, email, opiskelijanumero)"
             + "VALUES (@enm, @snm, @puh, @eml, @onro); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@onro", MySqlDbType.UInt32).Value = onro;

            yhteys.avaaYhteys();
             if (komento.ExecuteNonQuery() ==1)
            {
                yhteys.suljeYhteys();
                return true;
            }
             else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        //haetaan kaikki opiskelijatiedot
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("Select id, etunimi, sukunimi, puhelin, email, opiskelijanumero FROM opiskelijat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `opiskelijat` SET `etunimi` = @enm," + "`sukunimi` = @snm, `puhelin` = @puh, `email` = @eml, `opiskelijanumero` = @onro" + "WHERE id = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@onro", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaOpiskelija(string ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM opiskelijat WHERE id = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
