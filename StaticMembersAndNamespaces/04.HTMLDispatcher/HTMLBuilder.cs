using System;

namespace HTMLDispatcher
{
    class HTMLBuilder
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div);
            Console.WriteLine();
            Console.WriteLine(div * 2);
            Console.WriteLine();


            ElementBuilder image = HTMLDispatcher.CreateImage("https://softuni.bg/Content/design/logo.png", "Software University", "Software University");
            ElementBuilder url = HTMLDispatcher.CreateURL("https://softuni.bg", "Software University", "SoftUni");
            ElementBuilder input = HTMLDispatcher.CreateInput("text", "name", "1");

            Console.WriteLine(image);
            Console.WriteLine(url);
            Console.WriteLine(input);
        }
    }
}
