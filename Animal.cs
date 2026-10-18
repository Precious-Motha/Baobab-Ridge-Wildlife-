using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidge
{
    internal class Animal
    {
        public string ID { get; set; } = string.Empty; //String because of prefixes in front
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; } = string.Empty;
        public string HousingUnit { get; set; } = string.Empty;
        public Animal()
        {
        }

        public Animal(string AnimalId, string Name, string Species, int Age, int RecoveryScore, string status, string HousingUnit)
        {
            this.ID = AnimalId;
            this.Name = Name;
            this.Species = Species;
            this.Age = Age;
            this.RecoveryScore = RecoveryScore;
            this.Status = status;
            this.HousingUnit = HousingUnit;
        }

        public override string ToString()
        {
            return $"{ID.Trim()}|{Name.Trim()}|{Species.Trim()}|{Age}|{RecoveryScore}|{Status.Trim()}|{HousingUnit.Trim()}";
        }
    }
}
