namespace Lesson6
{
    // Создайте класс Phone, который содержит переменные number, model и weight.

    internal class Phone
    {
        string Number { get; set; }
        string Model { get; set; }
        string Weight { get; set; }

        // Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит {name}”.
        //getNumber – возвращает номер телефона.Вызвать эти методы для каждого из объектов.

        internal void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        internal void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"Звонит {name}, номер: {number}");
        }

        string getNumber (string number) 
        {
            return number;
        }

        internal void sendMessage(string[] numbers)
        {
            foreach(string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        internal Phone(string number, string model, string weight) 
        {
            Number = number;
            Model = model;
            Weight = weight;
        }

        internal Phone(string number, string model)
        {
            Number = number;
            Model = model;
        }
        internal Phone() { }
    }
}
