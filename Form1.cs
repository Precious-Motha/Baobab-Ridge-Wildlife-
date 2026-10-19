using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BaobabRidge.DataLayer;

namespace BaobabRidge
{
    public partial class Form1 : Form
    {
        private AnimalRepository animalRepository = new AnimalRepository();
        public Form1()
        {
            InitializeComponent();
            LoadAnimalsIntoGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate Animal ID
            string id = txtAnimalID.Text.Trim().ToUpper();
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^WR-\d{4}$"))
            {
                MessageBox.Show("Animal ID must follow the format WR-0001");
                return;
            }

            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();

            //Text field validation
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species))
            {
                MessageBox.Show("Please enter the animal's name and species. ");
                return;
            }

            //Age Validation
            if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Please enter a valid age between 0 and 100.");
                return;
            }

            //Recovery score Validation
            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score >100)
            {
                MessageBox.Show("Please enter a recovery score between 0 and 100. ");
                return;
            }

            //Loads existing animals
            var animals = animalRepository.LoadAnimals(out int skippedCount);

            //Ensures no duplicates
            if(animals.Exists(a => a.ID == id))
            {
                MessageBox.Show("An animal with this ID already exists.");
                return;
            }

            //Status and housing calculator
            var (status, housing) = AnimalClassifier.Classify(score);

            //Creates the new animal list
            var animal = new Animal
            {
                ID = id,
                Name = name,
                Species = species,
                Age = age,
                RecoveryScore = score,
                Status = status,
                HousingUnit = housing
            };

            //add animal to list
            animals.Add(animal);

            //Saves 
            animalRepository.SaveAnimals(animals);

            MessageBox.Show("Animal added successfully!");
        }

        private void  LoadAnimalsIntoGrid()
        {
            var animals = animalRepository.LoadAnimals(out int skippedCount);

            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
