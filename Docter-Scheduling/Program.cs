using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AppointmentService service = new AppointmentService();

        // Add dummy data
        service.AddDoctor(new Doctor
        {
            ID = 1,
            Name = "Dr. Smith",
            Specialization = "Cardiology",
            SlotMap = new Dictionary<int, DateTime>
            {
                { 1, DateTime.Today.AddHours(10) },
                { 2, DateTime.Today.AddHours(11) },
                { 3, DateTime.Today.AddHours(12) }
            }
        });

        service.AddPatient(new Patient
        {
            ID = 1,
            Name = "John Doe",
            Age = 30,
            Phone = "1234567890"
        });

        while (true)
        {
            Console.WriteLine("\n===== Clinic Appointment Scheduler =====");
            Console.WriteLine("1. View Doctors & Book Appointment");
            Console.WriteLine("2. Cancel Appointment");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    service.ViewDoctorsWithSlots();
                    Console.Write("Enter Doctor ID: ");
                    int doctorId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Patient ID: ");
                    int patientId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Slot ID to book: ");
                    int slotId = int.Parse(Console.ReadLine());
                    service.BookBySlotId(doctorId, patientId, slotId);
                    break;

                case "2":
                    Console.Write("Enter your Appointment Code: ");
                    string code = Console.ReadLine();
                    service.CancelByCode(code);
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
