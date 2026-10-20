using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaobabRidge.DataLayer;

namespace BaobabRidge.DataLayer
{
    class AnimalClassifier
    {
        public static (string status, string HousingUnit) Classify(int score)
        {
            try{
                if (score >= 0 && score <= 19)
                    return ("Critical", "Intensive Care Unit");
                if (score >= 20 && score <= 39)
                    return ("Serious", "High-Dependency Ward");
                if (score >= 40 && score <= 59)
                    return ("Stable", "Recovery Ward");
                if (score >= 60 && score <= 79)
                    return ("Recovering", "Outdoor Enclosure");
                if (score >= 80 && score <= 100)
                    return ("Release-Ready", "Pre-Release Camp");
                    MessageBox.Show("Score is out of range. Please enter a score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ("Invalid", "Invalid");
            }
            catch (Exception e){
                MessageBox.Show("An error occurred during classification: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ("Failed", "Failed");
            }
            

           

        }




    }
}
