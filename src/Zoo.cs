﻿namespace ZooSimulator
{
    public class Zoo
    {
        public string Name { get; set; }
        public List<Enclosure> Enclosures {  get; set; }
        public List<Visitor> Visitors {  get; set; }

        public Zoo(string name)
        {
            Name = name;
            Enclosures = new List<Enclosure>();
            Visitors = new List<Visitor>();
        }


        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
            Console.WriteLine($"\n\tEnclosure {enclosure.Name} is added to {Name}\n");
        }

        public int GetAnimalCount()
        {
            int count = 0;
            foreach (var enclosure in Enclosures)
            {
                count += enclosure.Animals.Count;
            }

            return count;
        }

        public int GetVisitorCount()
        {
            return Visitors.Count;
        }
    }
}
