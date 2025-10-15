using ex_zoologico;

Animal[] animals = new Animal[3];

animals[0] = new Dog("Max", 5);
animals[0] = new Cat("Alex", 5);
animals[0] = new Lion("Unbelivable", 5);

for (int i = 0; i < animals.Length; i++)
{
    Console.WriteLine(animals[i].ToString);
}