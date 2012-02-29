using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Een windows application om inheritance te testen.
    /// Als voorbeeld nemen we de classes Hond en Kat, die erven van de class Huisdier.
    /// </summary>
    public partial class FormDierenasiel : Form
    {
        const int CHIPNR_LENGTE = 5;
        private Dierenasiel asiel;
        //private Huisdier h;

        /// <summary>
        /// Deze constructor creeert een applicatie. 
        /// <p>De variabele h (van het type Huisdier) is gelijk aan null.</p>
        /// </summary>
        public FormDierenasiel()
        {
            InitializeComponent();
            //h = null;
            asiel = new Dierenasiel("Peter's dierenasiel", 25);            
        }

        ///// <summary>
        ///// Afhankelijk van of de radiobutton "hond" of "kat" is aangevinkt,
        ///// wordt "h = new Hond(...);" of  "h = new Kat(...);" uitgevoerd. 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnMaakDier_Click(object sender, EventArgs e)
        //{
        //    //moet je nog maken
        //    if (rdBtnHond.Checked)
        //        h = new Hond("12345", 2012, "Snoopy", false);
        //    else
        //        h = new Kat("67890", 2012, "Garfield", false, "Kleur: oranje; Geslacht: man;");
        //}

        ///// <summary>
        ///// Informatie over huisdier h verschijnt op het scherm.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnGeefInfo_Click(object sender, EventArgs e)
        //{
        //    //moet je nog maken
        //    tbInfo.Text = (h == null ? "Geen informatie beschikbaar." : h.GetInfo());
        //}


        private void VulHetAsielMetEnkeleDieren()
        {
            Huisdier[] huisdieren = 
            {
                new Hond("12345", 2000, "Snoopy", false, null),
                new Kat("00002", 2001, "Garfield", true, "Is erg grapppig", null),
                new Kat("00033", 2002, "Kitten", false, "Is nog niks over bekend", null),
                new Hond("00444", 2003, "Doggy", true, null)
            };

            foreach (Huisdier h in huisdieren)
            {
                if (!asiel.VoegHuisdierToe(h))
                {
                    if (asiel.IsVol)
                    {
                        MessageBox.Show("Het dierenasiel zit helemaal vol en kan momenteel geen huisdieren meer aannemen.", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    MessageBox.Show(string.Format("Het huisdier met chipnummer \"{0}\" staat al in het systeem.", h.Chipnummer), "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                       
                }
            }            
        }

        private void btAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSelecteerFoto_Click(object sender, EventArgs e)
        {
            string[] geldigeExtensies =
            {
                ".bmp", ".jpg", ".jpeg", ".gif", ".png"
            };

            OpenFileDialog of = new OpenFileDialog();

            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string bestand = of.FileName;
                string bestandsextensie = (new System.IO.FileInfo(bestand)).Extension.ToLower();

                foreach (string ext in geldigeExtensies)
                {
                    if (ext == bestandsextensie)
                    {
                        tbFoto.Text = bestand;
                        return;
                    }
                }

                MessageBox.Show("Het geselecteerde bestandsformaat wordt niet ondersteund!", "Fout:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void rdBtnKat_CheckedChanged(object sender, EventArgs e)
        {
            tbExtraInformatie.Enabled = rdBtnKat.Checked; // volstaat in het geval van enkel het toevoeven van een kat OF een hond
        }

        private void FormDierenasiel_Load(object sender, EventArgs e)
        {
            tbNaam.Text = asiel.Naam;
            tbCapaciteit.Text = asiel.Capaciteit.ToString();

            cbStatusReserveer.Items.Add("Niet gereserveerd");
            cbStatusReserveer.Items.Add("Gereserveerd");

            cbStatusVoegToe.Items.Add("Niet gereserveerd");
            cbStatusVoegToe.Items.Add("Gereserveerd");

            tbExtraInformatie.Enabled = rdBtnKat.Checked;

            VulHetAsielMetEnkeleDieren();
            UpdateOverzicht();
        }

        private bool IsGeldigNummer(string nr, int lengte)
        {
            for (int index = 0; index < nr.Length; index++)
                if (!char.IsDigit(nr[index]))
                    return false;

            return nr.Length == lengte;
        }

        private void btVoegToe_Click(object sender, EventArgs e)
        {
            string chipnr = tbChipnrVoegToe.Text;
            if (!IsGeldigNummer(chipnr, CHIPNR_LENGTE))
            {
                MessageBox.Show("Er is geen geldig chipnummer opgegeven!", "Fout:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string roepnaam = tbRoepnaam.Text;
            int geboortejaar = (IsGeldigNummer(tbGeboortejaar.Text, 4) ? Convert.ToInt32(tbGeboortejaar.Text) : 0);
            Image afbeelding = (System.IO.File.Exists(tbFoto.Text) ? Image.FromFile(tbFoto.Text) : null);            
            bool isGereserveerd = cbStatusVoegToe.SelectedIndex == 1; // index 1 = gereserveerd

            Huisdier h;

            if (rdBtnHond.Checked)
                h = new Hond(chipnr, geboortejaar, roepnaam, isGereserveerd, afbeelding);
            else
                h = new Kat(chipnr, geboortejaar, roepnaam, isGereserveerd, tbExtraInformatie.Text, afbeelding);

            if (asiel.VoegHuisdierToe(h))
            {
                MessageBox.Show("Huisdier is succesvol toegevoegd!", "Informatie:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOverzicht();

                tbChipnrVoegToe.Text = string.Empty;
                tbRoepnaam.Text = string.Empty;
                tbGeboortejaar.Text = string.Empty;
                tbFoto.Text = string.Empty;
                cbStatusVoegToe.SelectedIndex = -1;
            }
            else
            {
                if (asiel.IsVol)
                    MessageBox.Show("Het dierenasiel zit helemaal vol en kan momenteel geen huisdieren meer aannemen.", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(string.Format("Het huisdier met chipnummer \"{0}\" staat al in het systeem.", h.Chipnummer), "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btVerwijder_Click(object sender, EventArgs e)
        {
            string chipnr = tbChipnrVerwijder.Text;
            if (!IsGeldigNummer(chipnr, CHIPNR_LENGTE))
            {
                MessageBox.Show("Er is geen geldig chipnummer opgegeven!", "Fout:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (asiel.VerwijderHuisdier(chipnr))
            {
                MessageBox.Show("Het opgegeven huisdier is succesvol verwijderd!", "Informatie:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOverzicht();

                tbChipnrVerwijder.Text = string.Empty;
            }
            else
                MessageBox.Show("Het opgegeven huisdier bestaat niet en kan dus ook niet verwijderd worden!", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
        }

        private void btWijzig_Click(object sender, EventArgs e)
        {
            string chipnr = tbChipnrReserveer.Text;
            if (!IsGeldigNummer(chipnr, CHIPNR_LENGTE))
            {
                MessageBox.Show("Er is geen geldig chipnummer opgegeven!", "Fout:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Huisdier h = asiel.GetHuisdierMetChipnummer(chipnr);
            if (h == null)
                MessageBox.Show("Het opgegeven huisdier bestaat niet en diens status kan daardoor ook niet gewijzigd worden!", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool status = cbStatusReserveer.SelectedIndex == 1; // index 1 = gereserveerd
                if (h.Gereserveerd == status) return; // status is hetzelfde en hoeft dus niet gewijzigd te worden
                
                asiel.VerwijderHuisdier(h.Chipnummer);

                h.Gereserveerd = status; 
                asiel.VoegHuisdierToe(h);

                UpdateOverzicht();

                tbChipnrReserveer.Text = string.Empty;
                cbStatusReserveer.SelectedIndex = -1;
            }            
        }

        private void UpdateOverzicht()
        {
            lvGereserveerd.Items.Clear();
            lvNietGereserveerd.Items.Clear();

            for (int index = 0; index < asiel.AantalHuisdieren; index++)
            {
                Huisdier h = asiel.GetHuisdierMetIndex(index);

                ListViewItem item = new ListViewItem(h.Chipnummer);
                item.SubItems.Add(h.Roepnaam);
                item.SubItems.Add(h.Geboortejaar.ToString());

                if (h.Gereserveerd)
                    lvGereserveerd.Items.Add(item);
                else
                    lvNietGereserveerd.Items.Add(item);                
            }
        }

        private Huisdier HaalGeselecteerdHuisdierOp(ListView.ListViewItemCollection collection)
        {            
            foreach (ListViewItem item in collection)
            {
                if (item.Selected)
                {
                    return asiel.GetHuisdierMetChipnummer(item.Text);                    
                }
            }

            return null;
        }

        private void lvGereserveerd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Huisdier h = HaalGeselecteerdHuisdierOp(lvGereserveerd.Items);

            if (h != null)
                pbFoto.Image = h.Foto;            
        }

        private void lvNietGereserveerd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Huisdier h = HaalGeselecteerdHuisdierOp(lvNietGereserveerd.Items);

            if (h != null)
                pbFoto.Image = h.Foto;                           
        }

        private void btToonGroteFoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nog niet geimplementeerd!");
        }

        private void btKloonHuisdier_Click(object sender, EventArgs e)
        {
            if (asiel.IsVol)
            {
                MessageBox.Show("Het dierenasiel zit helemaal vol en kan momenteel geen huisdieren meer aannemen.", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Huisdier h = HaalGeselecteerdHuisdierOp(lvGereserveerd.Items);
            if (h == null)
            {
                h = HaalGeselecteerdHuisdierOp(lvNietGereserveerd.Items);
                if (h == null) return;
            }

            Huisdier kloon = (Huisdier)h.Clone();
            MessageBox.Show(kloon.GetInfo(), "Informatie kloon:", MessageBoxButtons.OK, MessageBoxIcon.Information);                                        
        }
    }
}