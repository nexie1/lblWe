using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrefourEssert
{
    public partial class Form1 : Form
    {
        enum state { vert, rouge };
        state etat = new state();
        static int compteur = 200;
        static int timer = compteur;
       
        Voiture car;
        Pieton pieton;
        public Form1()
        {
            InitializeComponent();
            pieton = new Pieton();
            car = new Voiture(1000,12,"656443553","dany","Sacado",10,10);
        }

        private void bntCreateScene_Click(object sender, EventArgs e)
        {
            //Feu feu = new Feu("rouge","piéton",43,45);

            etat = state.rouge;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            couleurFeu();


            switch (etat)
            {
                case state.vert:
                    car.Avancer(voiture1);
                    pieton.Freiner(pietons);
                    break;

                case state.rouge:
                    if (feuRouge.Bottom >= voiture1.Top && feuRouge.Top <= voiture1.Bottom)
                    {
                        car.Freiner(voiture1);
                    }
                    else
                    {
                        car.Avancer(voiture1);
                    }
                    pieton.Avancer(pietons);
                    break;
            }
        }
        private void couleurFeu()
        {
            if (timer <= 0 && state.vert == etat)
            {
                feuRouge.Visible = true;
                feuVert.Visible = false;
                etat = state.rouge;
                timer = compteur * 2;
            }
            else if (timer <= 0 && state.rouge == etat)
            {
                feuRouge.Visible = false;
                feuVert.Visible = true;
                etat = state.vert;
                timer = compteur;
            } else
            {
                timer -= 1;
            }

        }
      
    }
}
