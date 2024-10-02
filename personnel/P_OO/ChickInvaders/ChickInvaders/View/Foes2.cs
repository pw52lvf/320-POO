﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickInvaders
{
    public partial class Foes2
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int fx;                                 // Position en X depuis la gauche de l'espace aérien
        private int fy;
        private List<Image> images = new List<Image>();
        private Image foeImage2;
        private int speedF2;

        // Constructeur
        public Foes2(int x, int y, string name)
        {
            fx = x;
            fy = y;
            _name = name;
            speedF2 = GlobalHelpers.alea.Next(1, 8);
            _charge = FULLCHARGE;
            //_charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
            foeImage2 = Image.FromFile("foe2.png");
        }
        public int X { get { return fx; } }
        public int Y { get { return fy; } }
        public string Name { get { return _name; } }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void UpdateF2(int interval)
        {
            if (fx > 0)
            {
                fx -= speedF2;
            }
            else
            {
                fx = 1200;
                speedF2 = GlobalHelpers.alea.Next(1, 8);
                fy = GlobalHelpers.alea.Next(1, 150);
            }
        }
    }
}
