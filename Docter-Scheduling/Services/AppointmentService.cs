using System;
using System.Collections.Generic;
using System.Linq;

public class AppointmentService
{
    private int appointmentId = 1;

    public List<Doctor> Doctors { get; set; } = new();
    public List<Patient> Patients { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();

    public void AddDoctor(Doctor doc)
    {
        Doctors.Add(doc);
    }

    public void AddPatient(Patient pat)
    {
        Patients.Add(pat);
    }

    public void ViewDoctorsWithSlots()
    {
        foreach (var doc in Doctors)
        {
            Console.WriteLine($"\n[Doctor ID: {doc.ID}] {doc.Name} ({doc.Specialization})");
            foreach (var kv in doc.SlotMap)
            {
                Console.WriteLine($"  [Slot ID: {kv.Key}] {kv.Value}");
            }
        }
    }

    public void BookBySlotId(int doctorId, int patientId, int slotId)
    {
        var doc = Doctors.FirstOrDefault(d => d.ID == doctorId);
        if (doc == null || !doc.SlotMap.ContainsKey(slotId))
        {
            Console.WriteLine("Invalid Doctor ID or Slot ID.");
            return;
        }

        DateTime slotTime = doc.SlotMap[slotId];
        string appointmentCode = $"APT-D{doctorId}P{patientId}-{appointmentId}";

        var newAppointment = new Appointment
        {
            ID = appointmentId++,
            DoctorID = doctorId,
            PatientID = patientId,
            Slot = slotTime,
            AppointmentCode = appointmentCode
        };

        Appointments.Add(newAppointment);
        doc.SlotMap.Remove(slotId); 

        Console.WriteLine($"Appointment booked successfully!");
        Console.WriteLine($"Your Appointment Code: {appointmentCode}");
    }

    public void CancelByCode(string appointmentCode)
    {
        var appt = Appointments.FirstOrDefault(a => a.AppointmentCode == appointmentCode);
        if (appt == null)
        {
            Console.WriteLine("No appointment found with this code.");
            return;
        }

        var doctor = Doctors.FirstOrDefault(d => d.ID == appt.DoctorID);
        if (doctor != null)
        {
            int newSlotId = doctor.SlotMap.Count + 1;
            doctor.SlotMap[newSlotId] = appt.Slot;
        }

        Appointments.Remove(appt);
        Console.WriteLine("Appointment cancelled successfully.");
    }
}
