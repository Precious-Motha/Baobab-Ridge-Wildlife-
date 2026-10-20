using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaobabRidge.DataLayer;
using BaobabRidge;
using System.Net.Security;


namespace BaobabRidge
{
    public partial class Form1 : Form
    {
        public DataManager DM = new DataManager(@"animals.txt");
        public DataTable data;
        public int selectedRowIndex = -1;
        public Form1()
        {
            InitializeComponent();
            data = DM.GetDataTable();
            dgvAnimals.DataSource = data;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecies.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!txtAnimal.Text.StartsWith("BRW-"))
            {
                MessageBox.Show("Animal ID must start with 'BRW-'.");
                return;
            }
            if (!int.TryParse(txtAge.Text, out int age) || !int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter valid numbers for Age and Recovery Score.");
                return;
            }
            Animal animal = new Animal(txtAnimal.Text, txtName.Text, txtSpecies.Text, age, score, AnimalClassifier.Classify(score).status, AnimalClassifier.Classify(score).HousingUnit);



            foreach (DataRow row in data.Rows)
            {
                if (row["ID"].ToString() == animal.ID)
                {
                    MessageBox.Show("Animal with this ID already exists!");
                    return;
                }
            }

            data.Rows.Add(animal.ID, animal.Name, animal.Species, animal.Age, animal.RecoveryScore, animal.Status, animal.HousingUnit);
            MessageBox.Show("Animal added successfully!" + animal.Status + " in " + animal.HousingUnit);
            clearInputBoxes();
            DM.SaveToFile(data);

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DM.SaveToFile(data);
        }

        private void clearInputBoxes()
        {
            txtAnimal.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtStatus.Clear();
            txtHousing.Clear();
        }

        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dgvAnimals.Rows[e.RowIndex];
                txtAnimal.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecies.Text = row.Cells["Species"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtScore.Text = row.Cells["RecoveryScore"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
                txtHousing.Text = row.Cells["HousingUnit"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // we need to update data 
            if (selectedRowIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecies.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                if (int.TryParse(txtAge.Text, out int age) && int.TryParse(txtScore.Text, out int score))
                {
                    DataRow row = data.Rows[selectedRowIndex];
                    row["ID"] = txtAnimal.Text;
                    row["Name"] = txtName.Text;
                    row["Species"] = txtSpecies.Text;
                    row["Age"] = age;
                    row["RecoveryScore"] = score;
                    row["RecoveryScore"] = txtScore.Text;
                    row["Status"] = AnimalClassifier.Classify(int.Parse(txtScore.Text)).status;
                    row["HousingUnit"] = AnimalClassifier.Classify(int.Parse(txtScore.Text)).HousingUnit;
                    MessageBox.Show("Animal updated successfully!");
                    clearInputBoxes();
                    DM.SaveToFile(data);
                    selectedRowIndex = -1;
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers for Age and Recovery Score.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                string id = txtAnimal.Text;
                string name = txtName.Text;
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + " (ID: " + id + ")? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    data.Rows.RemoveAt(selectedRowIndex);
                    clearInputBoxes();
                    selectedRowIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["ID"].ToString() == txtSearch.Text)
                {
                    MessageBox.Show("Animal found and selected in the list.");
                    dgvAnimals.ClearSelection();
                    dgvAnimals.Rows[i].Selected = true;
                    dgvAnimals.FirstDisplayedScrollingRowIndex = i;
                    selectedRowIndex = i;
                    DataGridViewRow row = dgvAnimals.Rows[i];
                    txtAnimal.Text = row.Cells["ID"].Value.ToString();
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtSpecies.Text = row.Cells["Species"].Value.ToString();
                    txtAge.Text = row.Cells["Age"].Value.ToString();
                    txtScore.Text = row.Cells["RecoveryScore"].Value.ToString();
                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                    txtHousing.Text = row.Cells["HousingUnit"].Value.ToString();
                    return;
                }

            }
            MessageBox.Show("Animal not found."); return;

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            int totalAnimals = data.Rows.Count;
            double averageAge = 0;
            double averageRecoveryScore = 0;
            int criticalCount = 0;
            int seriousCount = 0;
            int stableCount = 0;
            int releaseReadyCount = 0;
            int recoveringCount = 0;

            for (int i = 0; i < totalAnimals; i++)
            {
                object ageObj = data.Rows[i]["Age"];
                if (ageObj != DBNull.Value && ageObj != null)
                {
                    averageAge += Convert.ToDouble(ageObj);
                }

                // Safely check and convert RecoveryScore
                object scoreObj = data.Rows[i]["RecoveryScore"];
                if (scoreObj != DBNull.Value && scoreObj != null)
                {
                    averageRecoveryScore += Convert.ToDouble(scoreObj);
                }
                string status = data.Rows[i]["Status"].ToString();
                if (status == "Critical")
                    criticalCount++;
                else if (status == "Serious")
                    seriousCount++;
                else if (status == "Stable")
                    stableCount++;
                else if (status == "Recovering")
                    recoveringCount++;
                else if (status == "Release-Ready")
                    releaseReadyCount++;
            }


            if (totalAnimals > 0)
            {
                averageAge /= totalAnimals;
                averageRecoveryScore /= totalAnimals;
            }


            string avgAgeStr = totalAnimals > 0 ? averageAge.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) : "N/A";
            string avgScoreStr = totalAnimals > 0 ? averageRecoveryScore.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) : "N/A";


            txtTotal.Text = totalAnimals.ToString();
            txtAvgAge.Text = avgAgeStr;
            txtAvgScore.Text = avgScoreStr;
            txtCritical.Text = criticalCount.ToString();
            txtSerious.Text = seriousCount.ToString();
            txtStable.Text = stableCount.ToString();
            TxtRecover.Text = recoveringCount.ToString();
            txtReady.Text = releaseReadyCount.ToString();


            string reportContent =
                "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE\r\n" +
                "ANIMAL SUMMARY REPORT\r\n" +
                "Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\r\n" +
                "----------------------------------------\r\n" +
                "Total animals:        " + totalAnimals + "\r\n" +
                "Average age (years):  " + avgAgeStr + "\r\n" +
                "Average recovery score: " + avgScoreStr + "\r\n" +
                "----------------------------------------\r\n" +
                "Animals per status:\r\n" +
                "    Critical:         " + criticalCount + "\r\n" +
                "    Serious:          " + seriousCount + "\r\n" +
                "    Stable:           " + stableCount + "\r\n" +
                "    Recovering:       " + recoveringCount + "\r\n" +
                "    Release-Ready:    " + releaseReadyCount;

            System.IO.File.WriteAllText("summary.txt", reportContent);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit? Any unsaved changes will be lost.", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MessageBox.Show("Thank you for using the Baobab Ridge Wildlife Rehabilitation Centre Animal Management System. Goodbye!");
                Application.Exit();
            }
            
        }
    }
}


