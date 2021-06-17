using System;
using System.Collections.Generic;

namespace ConstructionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddRoom("master")
                .AddRoom("guest")
                .AddBalcony();

            var normalHouse= myHouse.Build();

            //kitchen, master room, guest room, balcony
            normalHouse.Describe();

            myHouse.AddKitchen().AddRoom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            luxuryHouse.Describe();

            Console.ReadLine();

        }
    }

    public class Building
    {
        private string House { get; set; } = "";
        public List<string> Parts { get; set; } = new List<string>();


        public Building AddKitchen()
        {
            
            Parts.Add("Kitchen");
            return this;
        }
        public Building AddRoom(string name)
        {
            Parts.Add($"{name} room");
            return this;
        }
        public Building AddBalcony()
        {
            Parts.Add("Balcony");
            return this;
        }

        public Building Build()
        {
            House = string.Join(", ", Parts.ToArray());
            return this;
        }

        public void Describe()
        {
            Console.WriteLine(House);
        }
    }
}