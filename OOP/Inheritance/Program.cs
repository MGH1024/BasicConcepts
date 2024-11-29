
using Inheritance;

Bird parrot = new Bird { Name = "Parrot", Age = 2 };
parrot.Eat();
parrot.Fly();

Fish goldfish = new Fish { Name = "Goldfish", Age = 1 };
goldfish.Eat();
goldfish.Swim();

Dog bulldog = new Dog { Name = "Bulldog", Age = 3 };
bulldog.Eat();
bulldog.Bark();

Console.ReadKey();