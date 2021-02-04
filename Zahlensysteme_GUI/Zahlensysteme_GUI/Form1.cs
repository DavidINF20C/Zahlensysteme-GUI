using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlensysteme_GUI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Diese Datenbank ist für die Zahlensysteme die umgerechnet werden.
        /// </summary>
        DataTable UrsprungsZahlenSystem = new DataTable();

        /// <summary>
        /// Diese Datenbank ist für die Ziel berechnung zuständig.
        /// </summary>
        DataTable ZielZahlenSystem = new DataTable();

        /// <summary>
        /// Diese Datenbank ist dafür zuständig, dass die richtigen Daten bereitgestellt werden.
        /// </summary>
        DataTable ZielZahlenSystemAuswahl = new DataTable();

        public static string gewählteAusgangsZahl; //
        public static bool nummernTest; //Boolean benötigt zur verifizierung, dass die Zahl umgerechnet werden kann
        public static int errorHochzähler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxError.Hide();
            FülleUrsprungsZahlenSystem();
            FülleZielZahlenSystem();
            comBoxUrsprung.DataSource = UrsprungsZahlenSystem;
            comBoxUrsprung.DisplayMember = "UZSystemName";
        }

        /// <summary>
        /// Mit dieser Methode wird eine Datenbank erstellt, welche die Daten für das Ursprungs-Zahlensystem bereitstellt.
        /// </summary>
        private void FülleUrsprungsZahlenSystem()
        {
            UrsprungsZahlenSystem.Columns.Add("UZSystemID", typeof(int));
            UrsprungsZahlenSystem.Columns.Add("UZSystemName");
            UrsprungsZahlenSystem.Columns.Add("UZSystemWert", typeof(int));
            UrsprungsZahlenSystem.Columns.Add("UZSystemChar", typeof(char));


            UrsprungsZahlenSystem.Rows.Add(1, "Binär", 2, '1');
            UrsprungsZahlenSystem.Rows.Add(2, "Oktal", 8, '7');
            UrsprungsZahlenSystem.Rows.Add(3, "Dezimal", 10, '9');
            UrsprungsZahlenSystem.Rows.Add(4, "Hexadezimal", 16, 'F');
        }
        /// <summary>
        /// Mit dieser Methode werden die Daten für das Ziel-System bereitgestellt. Dabei können nur kompatible Systeme ausgewählt werden.
        /// </summary>
        private void FülleZielZahlenSystem()
        {
            ZielZahlenSystem.Columns.Add("UZSystemID", typeof(int));
            ZielZahlenSystem.Columns.Add("ZZSystemName");
            ZielZahlenSystem.Columns.Add("ZZSystemWert", typeof(int));

            ZielZahlenSystem.Rows.Add(1, "Oktal", 8);
            ZielZahlenSystem.Rows.Add(1, "Dezimal", 10);
            ZielZahlenSystem.Rows.Add(1, "Hexadezimal", 16);

            ZielZahlenSystem.Rows.Add(2, "Binär", 2);
            ZielZahlenSystem.Rows.Add(2, "Dezimal", 10);
            ZielZahlenSystem.Rows.Add(2, "Hexadezimal", 16);

            ZielZahlenSystem.Rows.Add(3, "Binär", 2);
            ZielZahlenSystem.Rows.Add(3, "Oktal", 8);
            ZielZahlenSystem.Rows.Add(3, "Hexadezimal", 16);

            ZielZahlenSystem.Rows.Add(4, "Binär", 2);
            ZielZahlenSystem.Rows.Add(4, "Oktal", 8);
            ZielZahlenSystem.Rows.Add(4, "Dezimal", 10);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hierbei wird genau die Datenbank-Zeile für das Ziel-System erstellt.
            ZielZahlenSystemAuswahl = ZielZahlenSystem.Select("UZSystemID=" + UrsprungsZahlenSystem.Rows[comBoxUrsprung.SelectedIndex]["UZSystemID"]).CopyToDataTable();

            comBoxZiel.DataSource = ZielZahlenSystemAuswahl;
            comBoxZiel.DisplayMember = "ZZSystemName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long zwischenErgebnis;
            int gewähltesUrsprungsZahlenSystem = Convert.ToInt32(UrsprungsZahlenSystem.Rows[comBoxUrsprung.SelectedIndex]["UZSystemWert"]);
            int gewähltesZielZahlenSystem = Convert.ToInt32(ZielZahlenSystemAuswahl.Rows[comBoxZiel.SelectedIndex]["ZZSystemWert"]);
            string ergebnis;

            try
            {
                gewählteAusgangsZahl = txtAusgangszahl.Text;
                nummernTest = NummernTest(gewählteAusgangsZahl, Convert.ToChar(UrsprungsZahlenSystem.Rows[comBoxUrsprung.SelectedIndex]["UZSystemChar"]));

                if (nummernTest == false)
                {
                    MessageBox.Show("Diese Zahl kann nicht umgerechnet werden!");
                    txtAusgangszahl.Text = "";
                    txtResultat.Text = "";
                }
                else
                {
                    if (gewähltesZielZahlenSystem == 10)//Falls eine Berechnung ins Dezimalsystem durchgeführt wird
                    {
                        zwischenErgebnis = Convert.ToInt64(gewählteAusgangsZahl, gewähltesUrsprungsZahlenSystem);
                        ergebnis = Convert.ToString(zwischenErgebnis);
                    }
                    else if (gewähltesUrsprungsZahlenSystem == 10)//Falls eine Berechnung vom Dezimalsystem durchgeführt wird
                    {
                        zwischenErgebnis = Convert.ToInt64(DivisionsRest(gewählteAusgangsZahl, gewähltesZielZahlenSystem));
                        ergebnis = Convert.ToString(zwischenErgebnis);
                    }
                    else //Für die Berechnung aller anderen Zahlensysteme
                    {
                        zwischenErgebnis = Convert.ToInt64(gewählteAusgangsZahl, gewähltesUrsprungsZahlenSystem);
                        ergebnis = Convert.ToString(zwischenErgebnis);
                        ergebnis = DivisionsRest(ergebnis, gewähltesZielZahlenSystem);
                    }
                    txtResultat.Text = ergebnis;
                }
            }
            catch (ArgumentOutOfRangeException er)
            {
                errorHochzähler++;
                lboxError.Show();
                MessageBox.Show("Gib eine Nummer ein!");
                lboxError.Items.Add($"Error Nummer {errorHochzähler}: { er.Message}");

            }
            catch (Exception ex)
            {
                errorHochzähler++;
                lboxError.Show();
                MessageBox.Show(ex.Message);
                lboxError.Items.Add($"Error Nummer {errorHochzähler}: { ex.Message}");
            }
        }
        public static bool NummernTest(string ausgangsZahl, char ursprungsZSystem)
        {
            char[] ausgangArray;
            bool Nummerntest = true;
            ausgangsZahl = ausgangsZahl.ToUpper();

            ausgangArray = ausgangsZahl.ToCharArray();

            for (int i = 0; i < ausgangsZahl.Length; i++)
            {
                if (ausgangArray[i] > ursprungsZSystem)
                {
                    Nummerntest = false;
                }
            }
            return Nummerntest;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static string DivisionsRest(string ausgangsZahl, int zielZahlensystem)
        {
            long rest;
            long zahlNeu = 0;
            string ergebnis2 = "";
            string restString = "";
            long ausgangsInt;
            ausgangsInt = Convert.ToInt64(ausgangsZahl);

            do
            {
                try
                {
                    rest = ausgangsInt % zielZahlensystem;
                    if (rest > 9)
                    {
                        restString = Convert.ToString(Convert.ToChar(rest + 55));
                        ergebnis2 = Convert.ToString(restString + ergebnis2);
                    }
                    else if (rest <= 9)
                    {
                        ergebnis2 = Convert.ToString(rest + ergebnis2);
                    }
                    zahlNeu = ausgangsInt / zielZahlensystem;
                    ausgangsInt = zahlNeu;
                }
                catch (Exception e)
                {
                    zahlNeu = 0;
                    MessageBox.Show(e.Message);
                }

            } while (zahlNeu != 0);
            return ergebnis2;
        }
    }
}
