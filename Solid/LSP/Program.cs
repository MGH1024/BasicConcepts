using LSP.NotFollowingLSP.Is_A;
using static LSP.FollowingLSP.NotImplementedExceptionSolveByLSP;
using static LSP.NotFollowingLSP.NotImplementedException;

Console.WriteLine("without LSP--------------------------------------------");
AccessDataFile accessDataFile = new AdminDataFileUser();
accessDataFile.FilePath = @"c:\temp\a.txt";
accessDataFile.ReadFile();
accessDataFile.WriteFile();

AccessDataFile accessDataFileR = new RegularDataFileUser();
accessDataFileR.FilePath = @"c:\temp\a.txt";
accessDataFileR.ReadFile();
//accessDataFileR.WriteFile();  // Throws exception 
Console.WriteLine("\n");
Console.WriteLine("LSP--------------------------------------------");
IFileReader fileReader = new AdminDataFileUserFixed();
fileReader.ReadFile(@"c:\temp\a.txt");

IFileWriter fileWriter = new AdminDataFileUserFixed();
fileWriter.WriteFile(@"c:\temp\a.txt");

IFileReader fileReaderR = new RegularDataFileUserFixed();
fileReaderR.ReadFile(@"c:\temp\a.txt");



Console.WriteLine("\nIs-A------------------------");
var rectangle = new Rectangle { Height = 4,Width=5};
Console.WriteLine($"area of rectangle is :{rectangle.CalculateArea()}");


var square = new Square { Height = 6 };
Console.WriteLine($"area of square is {square.CalculateArea()}");

 
Console.WriteLine("Problem is here ...");

Rectangle rect = new Square { Height=5,Width=5};
Console.WriteLine($"area of rect is :{rect.CalculateArea()}");