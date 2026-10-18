using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidge
{
    internal class Animal
    {
        public string ID { get; set; } //String because of prefixes in front
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

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
            return $"{ID} | {Name} | {Species} | {Age} | {RecoveryScore} | {Status} | {HousingUnit}";
        }
    }
}
