using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;

namespace BaobabRidge.DataLayer
{
    public class DataManager
    {
        private readonly string filePath;
        private List<string> records;

        public DataManager(string filePath)
        {
            this.filePath = filePath;
            LoadFile();
        }

        public void LoadFile()
        {
            records = new List<string>();
            try
            {

                if (File.Exists(filePath))
                {
                    records = new List<string>(File.ReadAllLines(filePath));
                }
                else{
                    File.Create(filePath);
                    records= new List<string>();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occurred on load file: " + e.ToString());
                MessageBox.Show("An error has occured on loading file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SaveToFile(DataTable dataTable)
        {
            try
            {   
                
                File.WriteAllLines(filePath, DataTableToList(dataTable));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occurred on Save file: " + e.ToString());
                MessageBox.Show("An error has occured on Saving file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public  List<string> DataTableToList(DataTable dataTable)
        {
            List<string> stringList = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                // Extract each value safely, handling potential null/DBNull values
                string id = row["ID"]?.ToString() ?? "";
                string name = row["Name"]?.ToString() ?? "";
                string species = row["Species"]?.ToString() ?? "";
                string age = row["Age"]?.ToString() ?? "";
                string recoveryScore = row["RecoveryScore"]?.ToString() ?? "";
                string status = row["Status"]?.ToString() ?? "";
                string housingUnit = row["HousingUnit"]?.ToString() ?? "";

                // Reconstruct the pipe-separated string
                string line = $"{id} | {name} | {species} | {age} | {recoveryScore} | {status} | {housingUnit}";

                stringList.Add(line);
            }

            return stringList;
        }

        public  DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable("Records");

            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Species", typeof(string));
            dataTable.Columns.Add("Age", typeof(string));           
            dataTable.Columns.Add("RecoveryScore", typeof(string)); 
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("HousingUnit", typeof(string));


            foreach (var line in records)
            {
                string[] values = line.Split('|');
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = values[i].Trim();
                }

                if (values.Length >= 7)
                {
                    DataRow row = dataTable.NewRow();
                    row["ID"] = values[0];
                    row["Name"] = values[1];
                    row["Species"] = values[2];
                    row["Age"] = int.TryParse(values[3], out int age) ? age : (object)DBNull.Value;
                    row["RecoveryScore"] = int.TryParse(values[4], out int score) ? score : (object)DBNull.Value;
                    row["Status"] = values[5];
                    row["HousingUnit"] = values[6];

                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

    }
}