using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Basket
{
    interface ICustomList<T>
    {
        int Count { get; }
        void Add(T item);
        bool Remove(T item);
        void Insert(int index, T item);
        T this[int index] { get; set; }
    }

    class Program
    {
        private class Basket<T> : ICustomList<T>, IEnumerable<T>
        {
            static int itemindex = 0;
            T[] objects = new T[2];

            public T this[int index] { get => objects[index]; set => objects[index] = value; }

            public void Add(T item)
            {
                if(objects.Length <= itemindex + 1)
                {
                    Array.Resize(ref objects, objects.Length * 2);
                }
                objects[itemindex++] = item;
            }

            private int countItems()
            {
                int i = 0;
                while(!EqualityComparer<T>.Default.Equals(objects[i], default(T)))
                {
                    i++;
                }
                return i;
            }

            public int Count { get => countItems(); }

            public bool Remove(T item)
            {
                bool itemRemoved = false;
                T[] newArr = new T[objects.Length];
                int j = 0;

                for (int i = 0; i < objects.Length; i++)
                {
                    if(EqualityComparer<T>.Default.Equals(objects[i], default(T)))
                    {
                        break;
                    }
                    else if (!objects[i].Equals(item))
                    {
                        newArr[j] = objects[i];
                        j++;
                    }
                    else
                    {
                        itemRemoved = true;
                    }
                }
                newArr.CopyTo(objects, 0);

                return itemRemoved;
            }

            public void Insert(int index, T item)
            {
                if (objects.Length < itemindex + 1)
                {
                    Array.Resize(ref objects, objects.Length * 2);
                }

                T[] newArr = new T[objects.Length];

                for (int i = 0; i < objects.Length; i++)
                {
                    if (i < index)
                        newArr[i] = objects[i];
                    else if (i == index)
                        newArr[i] = item;
                    else
                        newArr[i] = objects[i - 1];
                }
                newArr.CopyTo(objects, 0);
            }
            public IEnumerator<T> GetEnumerator()
            {
                for (int i = 0; i < objects.Length + 1; i++)
                {
                    if (!EqualityComparer<T>.Default.Equals(objects[i], default(T)))
                    {
                        yield return objects[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class Fruit
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Sweetness { get; set; }

            public Fruit()
            {
                Name = "";
                Color = "";
                Sweetness = 0;
            }

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

            Console.WriteLine("--- Get by index ---");
            basket[1].print();
            Console.WriteLine("--- Set by index ---");
            basket[1].Sweetness = 7;
            basket[1].print();

            Console.WriteLine();
            Console.WriteLine("--- Print all fruits ---");
            foreach (Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);

            Console.WriteLine();
            Console.WriteLine("--- Remove yellow apple ---");
            basket.Remove(yellowApple);
            foreach (Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);

            Console.WriteLine();
            Console.WriteLine("--- Insert melon at 3 position ---");
            basket.Insert(2, melon);
            foreach (Fruit fruit in basket)
            {
                fruit.print();
            }
            Console.WriteLine("Total fruits in the basket: " + basket.Count);
        }
    }
}
