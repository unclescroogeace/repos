using Interface_Implementation;
using System.Collections;

namespace CustomListNamespace
{
    public class Basket<T> : ICustomList<T>, IEnumerable<T>
    {
        List<T> list = new List<T>();
        public T this[int index] { get => list[index]; set => list[index] = value; }

        public int Count { get => list.Count; }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            if (list.Remove(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Fruit{
            string Name { get; set; }
            string Color { get; set; }
            int Sweetness { get; set; }

            public Fruit() { }

            public Fruit(string Name, string Color, int Sweetness)
            {
            this.Name = Name;
            this.Color = Color;
            this.Sweetness = Sweetness;
            }

            public void print()
            {
            Console.WriteLine(Name + " " + Color + " " + Sweetness);
            }
        }

    class TestClass
    {
        static void Main(string[] args)
        {
            Basket<Fruit> basket = new Basket<Fruit>();
            Fruit redApple = new Fruit("Apple", "Red", 8);
            Fruit greenApple = new Fruit("Apple", "Green", 3);
            Fruit yellowApple = new Fruit("Apple", "Yellow", 5);
            Fruit orange = new Fruit("Orange", "Orange", 3);
            Fruit melon = new Fruit("Melon", "Yellow", 9);

            basket.Add(redApple);
            basket.Add(greenApple);
            basket.Add(yellowApple);
            basket.Add(orange);

            foreach(Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);

            basket.Remove(yellowApple);

            Console.WriteLine();

            foreach (Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);

            basket.Insert(2, melon);

            Console.WriteLine();

            foreach (Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);

        }
    }


}