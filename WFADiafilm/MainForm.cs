using Microsoft.Data.SqlClient;
using WFADiafilm.Properties;
using System.DirectoryServices.ActiveDirectory;
using WFADiafilm.Properties;

namespace WFADiafilm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DGVRFresh();
        }

        void DGVRFresh()
        {
            SqlConnection conn = new(Resources.conString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT film.id, film.cim, film.kiadasiev, film.kocka, film.szinese, kiado.nev " +
                "FROM film INNER JOIN kiado ON film.kiadoid = kiado.id WHERE film.cim LIKE '%"+ TBMain.Text + "%' ORDER BY kiadasiev ASC, cim;", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string szines = "FF";
                        string kiadas = "nincs adat";
                        string kocka = kiadas;
                        if (reader.GetBoolean(4))
                        {
                            szines = "SZ";
                        }

                        if (!String.IsNullOrEmpty(reader[2].ToString()))
                        {
                            kiadas = reader[2].ToString();
                        }

                        if (!String.IsNullOrEmpty(reader[3].ToString()))
                        {
                            kocka = reader[3].ToString();
                        }

                        DGV.Rows.Add(reader[0], reader[1], kiadas, kocka, szines, reader[5]);
                    }
                }
            }
        }

        private void TBMain_TextChanged(object sender, EventArgs e)
        {
            DGVRFresh();
        }
    }
}