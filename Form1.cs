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

            btnSaveChanges.Enabled = false;

            LoadAnimalsIntoGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtSearchID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter an Animal ID.");
                return;
            }

            var animals = animalRepository.LoadAnimals(out int skippedCount);

            Animal? animal = animals.Find(a => a.ID == searchID);

            if (animal == null)
            {
                MessageBox.Show("Animal ID not found.");
                return;
            }

            txtAnimalID.Text = animal.ID;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtScore.Text = animal.RecoveryScore.ToString();

            SetEditMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.CurrentRow == null ||
                dgvAnimals.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an animal from the table.");
                return;
            }

            txtAnimalID.Text =
                dgvAnimals.CurrentRow.Cells["ID"].Value?.ToString();

            txtName.Text =
                dgvAnimals.CurrentRow.Cells["Name"].Value?.ToString();

            txtSpecies.Text =
                dgvAnimals.CurrentRow.Cells["Species"].Value?.ToString();

            txtAge.Text =
                dgvAnimals.CurrentRow.Cells["Age"].Value?.ToString();

            txtScore.Text =
                dgvAnimals.CurrentRow.Cells["RecoveryScore"].Value?.ToString();

            SetEditMode();
        }

        private void SetEditMode()
        {
            txtAnimalID.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSaveChanges.Enabled = true;
        }

        // Switches the form back to Add mode,clears the input fields.
        private void SetAddMode()
        {
            txtAnimalID.ReadOnly = false;
            btnAdd.Enabled = true;
            btnSaveChanges.Enabled = false;

            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtSearchID.Clear();

            dgvAnimals.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAddMode();
        }

        // Saves changes to an existing animal record.
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Make sure an animal is currently being edited.
            string id = txtAnimalID.Text.Trim().ToUpper();

            var animals = animalRepository.LoadAnimals(out int skippedCount);

            Animal? animal = animals.Find(a => a.ID == id);

            if (animal == null)
            {
                MessageBox.Show("Animal not found. Please search for or select an existing animal.");
                return;
            }

            // Get the edited values.
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();

            // Validate the name and species.
            if (string.IsNullOrWhiteSpace(name) || name.Length > 30 ||
                name.Contains("|"))
            {
                MessageBox.Show("Name is required, must be 30 characters or fewer, and cannot contain |.");
                return;
            }

            if (string.IsNullOrWhiteSpace(species) || species.Length > 30 ||
                species.Contains("|"))
            {
                MessageBox.Show("Species is required, must be 30 characters or fewer, and cannot contain |.");
                return;
            }

            // Validate the age.
            if (!int.TryParse(txtAge.Text, out int age) ||
                age < 0 || age > 100)
            {
                MessageBox.Show("Please enter a valid age between 0 and 100.");
                return;
            }
            if (!int.TryParse(txtScore.Text, out int score) ||
                score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a recovery score between 0 and 100.");
                return;
            }

            // Recalculate animal's status and housing unit.
            var (status, housing) = AnimalClassifier.Classify(score);

            // Update the existing record instead of adding a new animal.
            animal.Name = name;
            animal.Species = species;
            animal.Age = age;
            animal.RecoveryScore = score;
            animal.Status = status;
            animal.HousingUnit = housing;

            // Save all records back to the text file.
            animalRepository.SaveAnimals(animals);

            // Refresh the grid and return to Add mode.
            LoadAnimalsIntoGrid();
            SetAddMode();

            MessageBox.Show("Animal record updated successfully!");
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
            dgvAnimals.ReadOnly = true;
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
