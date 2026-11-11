using System;
using System.Collections.Generic;

namespace Opgave5_1
{
    public class Superhero
    {
        // Attributter / Properties
        public string HeroName { get; set; }
        public string RealIdentity { get; set; }
        public bool HasMask { get; set; }
        public string CostumeDescription { get; set; }
        public List<string> Superpowers { get; set; }
        public string Nemesis { get; set; }
        public string InnerFear { get; set; }
        public int MoralCodeLevel { get; set; } // F.eks. skala 1-10

        // Konstruktør
        public Superhero(string heroName, string realIdentity, bool hasMask, string costumeDescription, string nemesis, string innerFear)
        {
            HeroName = heroName;
            RealIdentity = realIdentity;
            HasMask = hasMask;
            CostumeDescription = costumeDescription;
            Nemesis = nemesis;
            InnerFear = innerFear;
            Superpowers = new List<string>();
            MoralCodeLevel = 10;
        }

        // Metoder, som beskriver superheltens adfærd
        public void UsePower(string powerName)
        {
            // Implementation behøves ikke ifølge opgavebeskrivelsen
        }

        public void FightCrime(string location)
        {
        }

        public void ConfrontFear()
        {
        }

        public void HideIdentity()
        {
        }
    }
}