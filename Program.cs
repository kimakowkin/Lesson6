namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            //phone1.ReceiveCall("Dimash");
            phone1.ReceiveCall("Dimash", "1234567");
            phone1.sendMessage(new string[]{ "1234", "12344", "111"});

            Patient patient = new Patient { Name = "Иван" };
            patient.Plan = new TreatmentPlan { Treatment = "Лечение зубов" };

            Dentist dentist = new Dentist();
            patient.AssignDoctor(dentist);

            Console.WriteLine($"{patient.Name} требуется {patient.Plan.Treatment}. Назначенный врач: {patient.Plan.AssignedDoctor.GetType().Name}");

            patient.Plan = new TreatmentPlan { Treatment = "Лечение зубов", TreatmentCode = 2 };

            patient.AssignDoctor();

            Console.WriteLine($"{patient.Name} требуется {patient.Plan.Treatment}. Назначенный врач: {patient.Plan.AssignedDoctor.GetType().Name}");
        }

    }
}