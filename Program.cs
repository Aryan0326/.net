using System;

public class Patient
{
    public string FullName { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public double CalculateBMI()
    {
        double heightInMeters = Height / 100; // Convert height from centimeters to meters
        double bmi = Weight / (Math.Pow(heightInMeters, 2));
        return bmi;
    }

    public string GetBMIStatus()
    {
        double bmi = CalculateBMI();

        if (bmi >= 25.0)
            return "Overweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal (In the healthy range)";
        else
            return "Underweight";
    }

    public void PrintPatientInformation()
    {
        double bmi = CalculateBMI();
        string bmiStatus = GetBMIStatus();

        Console.WriteLine("Patient Information:");
        Console.WriteLine("Full Name: " + FullName);
        Console.WriteLine("Weight: " + Weight + " kg");
        Console.WriteLine("Height: " + Height + " cm");
        Console.WriteLine("Blood Pressure: " + GetBloodPressure());
        Console.WriteLine("BMI: " + bmi);
        Console.WriteLine("BMI Status: " + bmiStatus);
    }

    private string GetBloodPressure()
    {
        // Implement your logic to calculate the blood pressure here
        // This is just a placeholder method
        return "Normal";
    }
}
