using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_03._Stacks_and_Queues
{
    abstract class Animal
    {
        private int order;
        public string name;
        public Animal(string n)
        {
            name = n;
        }
        public void SetOrder (int ord)
        {
            order = ord;
        }

        public int GetOrder()
        {
            return order;
        }

        // compare orders of animals to return the older item
        public bool IsOlderThan(Animal a)
        {
            return this.order < a.GetOrder();
        }
    }

    internal class Dog: Animal
    {
        public Dog(string n): base(n)
        {
            name = "Dog";
        }
    }

    internal class Cat : Animal
    {
        public Cat(string n) : base(n)
        {
            name = "Cat";
        }
    }


    class Q3_06_Animal_Shelter
    {
        LinkedList<Dog> dogs = new LinkedList<Dog>();
        LinkedList<Cat> cats = new LinkedList<Cat>();

        private int order = 0;

        public void enqueue(Animal a)
        {
            a.SetOrder(order);
            order++;

            if (a.name == "Dog")
            {
                dogs.AddLast((Dog)a);
            }
            else if (a.name == "Cat")
            {
                cats.AddLast((Cat)a);
            }
        }

        public Animal dequeueAny()
        {
            // look at the tops of dog and cat queues, and pop the queue with the oldest value
            if (dogs.Count == 0)
            {
                return dequeueCats();
            }
            else if (cats.Count == 0)
            {
                return dequeueDogs();
            }

            Dog dog = dogs.First.Value;
            Cat cat = cats.First.Value;

            if (dog.IsOlderThan(cat))
            {
                return dequeueDogs();
            }
            else
            {
                return dequeueCats();
            }
        }

        public Dog dequeueDogs()
        {
            var first = dogs.First.Value;
            dogs.RemoveFirst();
            return first;
        }

        public Cat dequeueCats()
        {
            var first = cats.First.Value;
            cats.RemoveFirst();
            return first;
        }
    }
}
