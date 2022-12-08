using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static AstronomieForm.GalaxieForm2;

namespace AstronomieForm
{
    public partial class GalaxieForm : Form
    {
        public GalaxieForm()
        {
            InitializeComponent();
        }   

        private void TxbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxbNom.Text.Length > 0)
                {

                    Galaxie NewGalaxie = new Galaxie($"{TxbNom.Text}");

                    MessageBox.Show(Galaxie.lstGalaxie.Count.ToString());
                    return;

                    MessageBox.Show(Galaxie.lstGalaxie.Count.ToString());
                    if (!Galaxie.lstGalaxie.Contains(NewGalaxie))
                    {
                        Galaxie.lstGalaxie.Add(NewGalaxie);
                    }
                    //MessageBox.Show("bravo");
                    else
                    {
                        MessageBox.Show("Galaxie déjà présente");
                    }
                    


                }
                else
                {

                    throw new ExceptionVide("Le nom de la nouvelle galaxie est obligatoire");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public class ExceptionVide : Exception
        {
            public ExceptionVide(string message) : base(message)
            {
                MessageBox.Show(message);
                return;
            }
        }
    }
}
