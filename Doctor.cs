namespace Lesson6
{
    internal abstract class Doctor
    {
        internal abstract void Treat();
    }

    internal class Surgeon : Doctor
    {
        internal override void Treat()
        {
            Console.WriteLine("Хирург лечит");
        }
    }

    internal class Therapist : Doctor
    {
        internal override void Treat()
        {
            Console.WriteLine("Терапевт лечит.");
        }
    }

    internal class Dentist : Doctor
    {
        internal override void Treat()
        {
            Console.WriteLine("Дантист лечит.");
        }
    }

}
