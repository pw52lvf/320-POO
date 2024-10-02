﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickInvaders
{
    public partial class Projectile
    {
        private int px;                                 // Position en X depuis la gauche de l'espace aérien
        private int py;
        private Image projImage;
        
        // Constructeur
        public Projectile(int x, int y)
        {
            px = x;
            py = y;
            //_charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
            projImage = Image.FromFile("projectile_foe.png");
        }
        public int X { get { return px; } }
        public int Y { get { return py; } }
        
        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void UpdateP(int interval)
        {
            py = py + 5;
            py++;
        }
    }
}
