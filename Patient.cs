namespace Lesson6
{
    internal class Patient
    {
        internal string Name { get; set; }
        internal TreatmentPlan Plan { get; set; }

        internal void AssignDoctor(Doctor doctor)
        {
            Plan.AssignedDoctor = doctor;
        }

        internal void AssignDoctor()
        {
            switch (Plan.TreatmentCode)
            {
                case 1:
                    Plan.AssignedDoctor = new Surgeon();
                    break;
                case 2:
                    Plan.AssignedDoctor = new Dentist();
                    break;
                default:
                    Plan.AssignedDoctor = new Therapist();
                    break;
            }

            Plan.AssignedDoctor.Treat();
        }
    }

    internal class TreatmentPlan
    {
        internal string Treatment { get; set; }
        internal Doctor AssignedDoctor{ get; set; }

        internal int TreatmentCode { get; set; }
    }
}
