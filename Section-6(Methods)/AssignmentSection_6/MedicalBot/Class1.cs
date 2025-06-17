using System;

public class MedicalBot
{
    private const string botName = "Bob";

    public static string GetBotName()
    {
        return botName;
    }

    public void PrescribeMedication(Patient patient)
    {
        string dosage = GetDosage(patient.GetSymptomeCode());
        if (patient.GetSymptomeCode().Contains("s1")) // HeadAche
        {
            Console.WriteLine("Medicine: Ibuprofen.");
            Console.WriteLine($"Dosage: {dosage}");
        }
        else if (patient.GetSymptomeCode().Contains("s2")) // Skin Rashes
        {
            Console.WriteLine("Medicine: Diphenhydramine.");
            Console.WriteLine($"Dosage: {dosage}");
        }
        else if (patient.GetSymptomeCode().Contains("s3")) // Dizziness
        {
            if (patient.GetMedicalHistory().Contains("Diabetes"))
            {
                Console.WriteLine("Medicine: Metformin.");
                Console.WriteLine($"Dosage: 500 mg");
            }
            else
            {
                Console.WriteLine("Medicine: Dimenhydrinate.");
                Console.WriteLine($"Dosage: {dosage}");
            }
        }

        string GetDosage(string medicineName)
        {
            switch (patient.GetSymptomeCode())
            {
                case "s1": // ibuprofen
                    if (patient.GetAge() < 18)
                    {
                        return "400 mg";
                    }
                    else
                    {
                        return "800 mg";
                    }
                case "s2": // diphenhydramine
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "300 mg";
                    }
                case "s3": // dimenhydrinate
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "400 mg";
                    }
                default:
                    return "Dosage not available for this medication.";
            }
        }
    }
}

public class Patient
{
    private string name;
    private int age;
    private string gender;
    private string medicalHistory;
    private string symptomeCode;
    private string prescription;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value, out string errorMessage)
    {
        if (value != null && value.Length > 0)
        {
            name = value;
            errorMessage = "";
        }
        else
        {
            errorMessage = "Name cannot be null or empty.";
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int value, out int errorMessage)
    {
        if (value > 0)
        {
            age = value;
            errorMessage = 0; // No Error, Positive Number Entered
        }
        else
        {
            errorMessage = 1; // Negative Number Entered
        }
    }

    public string GetGender()
    {
        return gender;
    }

    public void SetGender(string value, out string errorMessage)
    {
        if (value != null && value.Length > 0)
        {
            gender = value;
            errorMessage = "";
        }
        else
        {
            errorMessage = "Gender field cannot be null or empty.";
        }
    }

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }

    public void SetMedicalHistory(string value, out string errorMessage)
    {
        if (value != null || value.Length > 0)
        {
            medicalHistory = value;
            errorMessage = "";
        }
        else
        {
            errorMessage = "No medical history";
        }
    }

    public string GetSymptomeCode()
    {
        return symptomeCode;
    }

    public void SetSymptomeCode(string value, out string errorMessage)
    {
        if (value != null && value.Length > 0)
        {
            symptomeCode = value;
            errorMessage = "";
        }
        else
        {
            errorMessage = "Symptome code cannot be null or empty.";
        }
    }

    public string GetPrescription()
    {
        return prescription;
    }

    public void SetPrescription(string value, out string errorMessage)
    {
        if (value != null && value.Length > 0)
        {
            prescription = value;
            errorMessage = "";
        }
        else
        {
            errorMessage = "Prescription cannot be null or empty.";
        }
    }

}