using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Delegates;

//declare delegate
public delegate void FirstDelegate(string msg);

public delegate int SecondDelegate(int a, int b);

public delegate T GenericAddDelegate<T>(T param1, T param2); //generic

internal static class Program
{
    private static void Main()
    {
        //delegate section-----------------------------------------------------------------------------
        //1-simple delegate
        void PrintMessage(string message) => Console.WriteLine(message); //inline method
        var firstDelegate = new FirstDelegate(PrintMessage);
        firstDelegate("directly call");
        firstDelegate.Invoke("call by invoke");

        int FirstSum(int a, int b) => a + b; //inline method
        int SecondSum(int a, int b) => (a + b) * 2; //inline method
        var secondDelegate = new SecondDelegate(FirstSum);
        Console.WriteLine(secondDelegate(3, 4));
        secondDelegate += (SecondSum);
        Console.WriteLine(secondDelegate(1, 1)); // return 4 because use latest method which added is SecondSum

        //2-generic delegate
        string Concat(string str1, string str2) => str1 + str2; //inline method
        var genericDelegate1 = new GenericAddDelegate<int>(FirstSum);
        var genericDelegate2 = new GenericAddDelegate<string>(Concat);

        Console.WriteLine(genericDelegate1(1, 2)); //3
        Console.WriteLine(genericDelegate2("te", "st")); //test

        //Func delegate: is generic delegate with one output and max 8 input
        Func<int, int, int> add = FirstSum;
        add += SecondSum;
        Console.WriteLine(add(3, 4)); //14

        Func<string, string, string> concat = Concat;
        Console.WriteLine(concat("a", "vf"));

        //Func with anonymous methods
        Func<int, int, int> anonymousMultiple = delegate (int a, int b) { return a * b; };
        Console.WriteLine(anonymousMultiple(8, 8)); //64

        //Func with lambda
        Func<int, int, int> anonymousMultipleLambda = (a, b) => a * b;
        Console.WriteLine(anonymousMultipleLambda(9, 9));

        //action delegate :is same as Func except tha it does not return anything
        Action<string> actionDelegate = (str) => Console.WriteLine("pre_" + str + "_post");
        actionDelegate("aaa"); //pre_aaa_post


        //predicate delegate :just return bool
        bool IsEvenMethod(int number) => number % 2 == 0; //inline method
        Predicate<int> isEvenPredicateDelegate = IsEvenMethod;
        Console.WriteLine(isEvenPredicateDelegate(17));
        Console.WriteLine(isEvenPredicateDelegate(22));

        //anonymous method section-----------------------------------------------------------------------------
        //anonymous method can be defined by delegates
        var anonymousMethod = delegate (int a, int b) { return a + b; };
        Console.WriteLine(anonymousMethod(1, 3)); //4

        //methods with action and func as parameter
        void MethodWithActionParam(Action action) => action(); //inline method

        int MethodWithFuncParam(Func<int, int, int> func, int a, int b) //inline method
        {
            return func(a, b);
        }

        MethodWithActionParam(delegate { Console.WriteLine("MethodWithActionParam"); });
        Console.WriteLine(MethodWithFuncParam(FirstSum, 1, 2));

        //methods with anonymous as param
        int ThirdAction(SecondDelegate del, int a, int b) //inline methods
        {
            return del(a, b);
        }

        int sum = ThirdAction((num1, num2) => num1 + num2, 10, 2);
        Console.WriteLine(sum);

        int multiple = ThirdAction((num1, num2) => num1 * num2, 10, 2);
        Console.WriteLine(multiple);

        //events in c#
        Console.WriteLine("Events---------------------------------------------------------------");
        var stock = new EventHelper.Stock("THPW");
        stock.Price = 27.10M;
        // Register with the PriceChanged event
        stock.PriceChanged += stock_PriceChanged;
        stock.Price = 32.59M;
        stock.Price = 33.59M;
        stock.Price = 34.59M;
        stock.Price = 35.59M;
        stock.Price = 36.59M;
        stock.Price = 37.59M;
        stock.Price = 38.59M;
        stock.Price = 39.59M;
        stock.Price = 40.59M;


        void stock_PriceChanged(object sender, EventHelper.PriceChangedEventArgs e)
        {
            Console.WriteLine($"last price is :{e.LastPrice} new price is  : {e.NewPrice} ");
        }

        Console.WriteLine("Nullable Value Types--------------------------------\n");
        //Nullable Value Types
        //int i = null;   =>compiler error
        int? i = null;
        Console.WriteLine(i == null);

        //this current twi lines translate to 
        Nullable<int> i2 = new Nullable<int>();
        Console.WriteLine(!i2.HasValue);


        int? x = 5; // implicit
        int y = (int)x; // explicit

        Console.WriteLine("operator lifting--------------------------------\n");
        //operator lifting
        int? a = 5;
        int? b = 10;
        bool c = a < b; // true

        //this current 1 lines translate to :

        bool c1 = (a.HasValue && b.HasValue) ? (a.Value < b.Value) : false;

        Console.WriteLine(c);
        Console.WriteLine(c1);



        Console.WriteLine("tuples---------------------------------------------");
        var bob = ("bob", 23);
        Console.WriteLine(bob.Item1); // Bob
        Console.WriteLine(bob.Item2); // 23


        var joe = bob; // joe is a *copy* of bob
        joe.Item1 = "Joe"; // Change joe’s Item1 from Bob to Joe
        joe.Item2 = 27; // Change joe’s Item2 from 23 to 27
        Console.WriteLine(bob); // (Bob, 23)
        Console.WriteLine(joe); // (Joe, 27)



        (string, int) toni = ("Toni", 29);
        Console.WriteLine(toni); // (toni, 29)


        //we can return tuple vaue rom a method
        (string, int) person = GetPerson(); // Could use 'var' instead if we want
        Console.WriteLine(person.Item1); // ali
        Console.WriteLine(person.Item2); // 83

        

        //you can use meaning full name for tuple items
        var tuple = (name: "Bob", age: 23);
        Console.WriteLine(tuple.name); // Bob
        Console.WriteLine(tuple.age); // 23


        var person2 = GetPerson2();
        Console.WriteLine(person2.name); // Bob
        Console.WriteLine(person2.age); // 23


        (string name, int age, char sex) bob1 = ("Bob", 23, 'M');
        (string age, int sex, char name) bob2 = bob1; // No error!

        Console.WriteLine(bob2.name); // M
        Console.WriteLine(bob2.age); // Bob
        Console.WriteLine(bob2.sex); // 23

        //tuple methods
        (string, int) GetPerson() => ("ali", 83);
        (string name, int age) GetPerson2() => ("Bob", 23);


        //ValueTuple.Create
        ValueTuple<string, int> bob3 = ValueTuple.Create("Bob", 23);
        (string, int) bob4 = ValueTuple.Create("Bob", 23);
        (string name, int age) bob5 = ValueTuple.Create("Bob", 23);

        //Deconstructing Tuples
        var bob6 = ("Bob", 23);
        string name = bob6.Item1;
        int age = bob6.Item2;

        //other way for deconstructing
        (string name6, int age6) = bob6;


        //Equality Comparison
        var t1 = ("one", 1);
        var t2 = ("one", 1);
        Console.WriteLine(t1.Equals(t2)); // True
        Console.WriteLine(t1 == t2);// True (from C# 7.3)

        //records
        Console.WriteLine("Records----------------------------------------\n");
        Console.WriteLine("Caller Attributes------------------------------\n");
        
        Console.WriteLine(Print(1,1));

        var foo = new Foo { CustomerName = "Hasan" };
        foo.CustomerName = "Hasan1";

        Console.WriteLine("\nCallerArgumentExpression");

        Print2(Math.PI * 1024);


        //caller attributes methods
        string Print(int? a,int b,[CallerMemberName] string memberName = null,
                                  [CallerFilePath] string filePath = null,
                                  [CallerLineNumber] int lineNumber = 0)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);


            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);

            return concat(a.ToString(),b.ToString());
        }


        void Print2(double number,
            [CallerArgumentExpression("number")] string expr = null)
            => Console.WriteLine(expr);



    }

    public class Foo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            Console.WriteLine($"{propertyName} changed");
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        }
        string customerName;
        public string CustomerName
        {
            get => customerName;
            set
            {
                if (value == customerName) return;
                customerName = value;
                RaisePropertyChanged();
                // The compiler converts the above line to:
                // RaisePropertyChanged ("CustomerName");
            }
        }
    }
}