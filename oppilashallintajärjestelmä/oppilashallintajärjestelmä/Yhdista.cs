﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace oppilashallintajärjestelmä
{
    internal class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;database=hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =;  database = hotelli");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        //funktio yhteyden avaamiseen
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        //funktio yhteyden sulkemiseen
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}