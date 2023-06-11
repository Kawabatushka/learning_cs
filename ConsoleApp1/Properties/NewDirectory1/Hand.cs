using System;

namespace Program
{
    public class Hand : ITake
    {
        public string name = "default name";
        public string Name
        {
            set { Name = value; }
        }

        public bool TakeSmth(string message, out bool choice, bool force = false)
        {
            throw new System.NotImplementedException();
        }

        private string[] finger = { "большой", "указательный", "средний", "безымянный", "мезинец" };

        public void NameAllFingers()
        {
            Console.Write($"1-{finger[0]}\n2-{finger[1]}\n3-{finger[2]}\n4-{finger[3]}\n5-{finger[4]}\n");
        }
    }
}