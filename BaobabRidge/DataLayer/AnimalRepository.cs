using BaobabRidge.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BaobabRidge.BaobabRidge.DataLayer
{
    class AnimalRepository
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

        public List<Animal> LoadAnimals(out int skippedCount)
        {

            skippedCount = 0;
            //var animals = new List<Animal>();
            List<Animal> animals = new List<Animal>();

            if (!File.Exists(filePath))
                return animals;

            //var lines = File.ReadAllLines(filePath);
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                if (parts.Length != 7)
                {
                    skippedCount++;
                    continue;
                }

                //Ensures proper ID formatting 
                string id = parts[0].Trim().ToUpper();
                if (!Regex.IsMatch(id, @"^WR-\d{4}$"))
                {
                    skippedCount++;
                    continue;
                }

                string name = parts[1].Trim();
                string species = parts[2].Trim();
                if (string.IsNullOrEmpty(name) || name.Length > 0 && name.Contains("|") || string.IsNullOrEmpty(species) || species.Length > 0 && species.Contains("|"))
                {
                    skippedCount++;
                    continue;
                }

                //Age
                if (!int.TryParse(parts[3], out int age) || age < 0 || age > 100)
                {
                    skippedCount++;
                    continue;
                }

                //Score
                if (!int.TryParse(parts[4], out int score) || score < 0 || score > 100)
                {
                    skippedCount++;
                    continue;
                }

                //Recalculate status and housing unit to ensure consistency
                var (status, housing) = AnimalClassifier.Classify(score);

                animals.Add(new Animal
                {
                    ID = id,
                    Name = name,
                    Species = species,
                    Age = age,
                    RecoveryScore = score,
                    Status = status,
                    HousingUnit = housing
                });
            }

            return animals;
        }

        public void SaveAnimals(List<Animal> animals)
        {
            var lines = new List<string>();
            foreach (var animal in animals)
            {
                lines.Add(animal.ToString());
            }
            File.WriteAllLines(filePath, lines);
        }
    }

}
    