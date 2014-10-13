using System;
using CompanyHierarchy.Person.Emloyee;
using CompanyHierarchy.Person.Emloyee.RegularEmployee;
using CompanyHierarchy.Utilities;

class Program
{
    static void Main()
    {
        var ultraGame = new Product("UltraGame", DateTime.Now, 30);
        var textEditor = new Product("Editor 2014", DateTime.Now, 100);

        var calculator = new Project("Calculator", DateTime.Now);
        var pdfConverter = new Project("PDF converter", DateTime.Now, "Convert text file in PDF");
        pdfConverter.CloseProject();

        var pesho = new SalesEmployee("Pesho", "Peshev", 10001, 1200, Department.Marketing);
        pesho.AddSales(ultraGame);
        pesho.AddSales(textEditor);
        Console.WriteLine(pesho);
        Console.WriteLine();

        var ivan = new SalesEmployee("Ivan", "Ivanov", 10002, 1250, Department.Marketing);
        ivan.AddSales(textEditor);
        ivan.AddSales(textEditor);

        var tsvetan = new Delveloper("Tsvetan", "Tsvetanov", 10003, 1500, Department.Production);
        tsvetan.AddProject(calculator);
        tsvetan.AddProject(pdfConverter);

        var gergana = new Delveloper("Gergana", "Gergina", 10004, 1600, Department.Production);
        gergana.AddProject(calculator);
        gergana.AddProject(pdfConverter);
        Console.WriteLine(gergana);
        Console.WriteLine();

        var managerTodor = new Manager("Todor", "Todorov", 12345, 1800, Department.Marketing);
        managerTodor.AddEploymee(pesho);
        managerTodor.AddEploymee(ivan);
        Console.WriteLine(managerTodor);
        Console.WriteLine();

        var managerIvanNeivanov = new Manager("Ivan", "Neivanov", 12346, 1900, Department.Production);
        managerIvanNeivanov.AddEploymee(gergana);
        managerIvanNeivanov.AddEploymee(tsvetan);
        Console.WriteLine(managerIvanNeivanov);
    }
}
