using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSection_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, I'm {MedicalBot.GetBotName()}. I'm here to help you in your medication.");

            Patient patient = new Patient();

            Console.WriteLine("Enter your (patient) details: ");

            Console.Write("Enter Patient Name: ");
            patient.SetName(Console.ReadLine(), out string nameError);

            Console.Write("\nEnter Patient Age: ");
            patient.SetAge(int.Parse(Console.ReadLine()), out int ageError);

            Console.Write("\nEnter Patient Gender: ");
            patient.SetGender(Console.ReadLine(), out string genderError);

            Console.Write("\nEnter Medical History (Eg: Diabetes). Press Enter for None: ");
            patient.SetMedicalHistory(Console.ReadLine(), out string medicalHistoryError);

            Console.WriteLine();

            Console.WriteLine($"Welcome {patient.GetName()}, {patient.GetAge()} ");
            Console.WriteLine("Which of the following symptom do you have ?");
            Console.WriteLine("S1. Headache\nS2. Skin rashes\nS3. Dizziness");
            Console.WriteLine("Enter the symptom code from above list (S1, S2 or S3): ");
            patient.SetSymptomeCode(Console.ReadLine(), out string symptomeCodeError);

            Console.WriteLine();

            Console.WriteLine("Your prescription based on your age, symptoms and medical history:");

            MedicalBot medicalBot = new MedicalBot();
            medicalBot.PrescribeMedication(patient);

            Console.ReadKey();


        }
    }
}