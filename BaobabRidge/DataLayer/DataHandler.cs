using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

public class DataManager
{
    private readonly string filePath;
    private List<string> records;

    public DataManager(string filePath)
    {
        this.filePath = filePath;
        LoadFile();
    }

    //Load the file into memory
    public void LoadFile()
    {
        records=new List<string>();//ensure a gracefull fail by leaving a empty list if file load fails and if no file exists
        try
        {

            if (File.Exists(filePath))
            {
                records = new List<string>(File.ReadAllLines(filePath));
            }
        }
        catch(Exception e){
            System.Diagnostics.Debug.WriteLine("An error occurred on load file: "+e.ToString());
            MessageBox.Show("An error has occured on loading file","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }

    //used to push changes from the list back to the text file
    private void SaveToFile()
    {
        try {
            File.WriteAllLines(filePath, records);
        }
        catch (Exception e){
        System.Diagnostics.Debug.WriteLine("An error occurred on Save file: " + e.ToString());
        MessageBox.Show("An error has occured on Saving file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    //adding a new record into the list then updating the text file
    public void AppendRecord(string record)
    {
        records.Add(record);
        SaveToFile();
    }

    //finds a list of record containing a search term
    public List<string> FindRecords(string searchTerm)
    {
        return records.FindAll(r => r.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }

    //updates a record on a specified index
    public bool UpdateRecord(int index, string updatedRecord)
    {
        if (index >= 0 && index < records.Count)
        {
            records[index] = updatedRecord;
            SaveToFile();
            return true;
        }
        return false; //out of bounds
    }

    // deletes a record on a specified index
    public bool DeleteRecord(int index)
    {
        if (index >= 0 && index < records.Count)
        {
            records.RemoveAt(index);
            SaveToFile();
            return true;
        }
        return false; //out of bounds
    }

    // returns all records as a string
    // Evrioment.newline returns the right newline for wherever the programming is running
    public string PrintAllRecords()
    {
        return string.Join(Environment.NewLine, records);
    }

    // Returns the index of the first match, or -1 if nothing is found
    public int FindFirstIndex(string searchTerm)
    {
        return records.FindIndex(r => r.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }

}