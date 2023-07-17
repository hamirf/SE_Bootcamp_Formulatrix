using System.Collections;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Animal elephant = new("Elephant", 4);
        Animal chicken = new("Chicken", 2);
        Animal snake = new("Snake", 0);
        // elephant.AnimalInfo();
        // chicken.AnimalInfo();
        // snake.AnimalInfo();
        // System.Console.WriteLine();

        Stopwatch arrayTime = new();
        Stopwatch arrayListTime = new();
        Stopwatch listTime = new();
        Stopwatch linkedListTime = new();
        Stopwatch hashSetTime = new();

        // 1. Array
        arrayTime.Start();
        string[] animalName = { elephant.Name, chicken.Name, snake.Name };
        int[] animalLeg = { elephant.leg, chicken.leg, snake.leg };

        System.Console.WriteLine("======================Array======================");
        for (int i = 0; i <= animalName.Length - 1; i++)
        {
            if (animalLeg[i] >= 2)
            {
                System.Console.WriteLine($"{animalName[i]} has {animalLeg[i]} legs");
            }
            else
            {
                System.Console.WriteLine($"{animalName[i]} has {animalLeg[i]} leg");
            }
        }
        arrayTime.Stop();
        System.Console.WriteLine($"Array time : {arrayTime.Elapsed}");
        System.Console.WriteLine("======================Array======================");
        System.Console.WriteLine();

        // 2. ArrayList
        arrayListTime.Start();
        System.Console.WriteLine("======================ArrayList======================");
        ArrayList myAnimal = new() { elephant, snake.Name, chicken.leg };
        // myAnimal.Add(elephant);
        // myAnimal.Add(snake.Name);
        // myAnimal.Add(chicken.leg);
        foreach (var animal in myAnimal)
        {
            System.Console.WriteLine(animal);
        }
        arrayListTime.Stop();
        System.Console.WriteLine($"Array List Time : {arrayListTime.Elapsed}");
        System.Console.WriteLine("======================ArrayList======================");
        System.Console.WriteLine();

        // 3. List<T>
        listTime.Start();
        System.Console.WriteLine("======================List<T>======================");
        List<Animal> animals = new() { elephant, chicken, snake };
        foreach (Animal animal in animals.OrderBy(animal => animal.Name))
        {
            // if (animal.leg >= 2)
            // {
            //     System.Console.WriteLine($"{animal.Name} has {animal.leg} legs");
            // }
            // else
            // {
            //     System.Console.WriteLine($"{animal.Name} has {animal.leg} leg");
            // }
            string output = (animal.leg >= 2) ? $"{animal.Name} has {animal.leg} legs" : $"{animal.Name} has {animal.leg} leg";
            System.Console.WriteLine(output);
        }
        listTime.Stop();
        System.Console.WriteLine($"List Time : {listTime.Elapsed}");
        System.Console.WriteLine("======================List<T>======================");
        System.Console.WriteLine();

        // 4. LinkedList<T>
        linkedListTime.Start();
        System.Console.WriteLine("======================LinkedList<T>======================");
        LinkedList<Animal> animalList = new();
        LinkedListNode<Animal> gajah = animalList.AddFirst(elephant);
        LinkedListNode<Animal> ayam = animalList.AddAfter(gajah, chicken);
        LinkedListNode<Animal> ular = animalList.AddAfter(ayam, snake);
        // animalList.AddLast(elephant);
        // animalList.AddLast(chicken);
        // animalList.AddLast(snake);

        foreach (var animal in animalList)
        {
            System.Console.WriteLine(animal.Name);
        }
        linkedListTime.Stop();
        System.Console.WriteLine($"Linked List Time : {linkedListTime.Elapsed}");
        System.Console.WriteLine("======================LinkedList<T>======================");
        System.Console.WriteLine();

        // 5. HashSet<T>
        hashSetTime.Start();
        System.Console.WriteLine("======================HashSet<T>======================");
        HashSet<Animal> animalLists = new() { elephant, chicken, snake };

        foreach (var animal in animalLists.OrderBy(animal => animal.leg))
        {
            animal.AnimalInfo();
        }
        hashSetTime.Stop();
        System.Console.WriteLine($"Hash Set Time : {hashSetTime.Elapsed}");
        System.Console.WriteLine("======================HashSet<T>======================");
    }
}