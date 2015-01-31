using System;

namespace _03Animals
{
    class Program
    {
        static void Main()
        {
            Tomcat george = new Tomcat("Pesho", 14);
            Tomcat tosho = new Tomcat("Tosho", 2);
            Tomcat sasho = new Tomcat("Sasho", 5);
            Kitten elisabeth = new Kitten("Elisabeth", 1);
            Kitten sara = new Kitten("Sarah", 3);
            Kitten ivi = new Kitten("Ivvie", 1);
            Dog sharo = new Dog("Sharovar", 8, Gender.Male);
            Dog svetlin = new Dog("Svetlin", 3, Gender.Male);
            Dog mincho = new Dog("Mincho", 11, Gender.Male);
            Frog frogcho = new Frog("Froggy", 1, Gender.Female);

            Tomcat[] tomcats = { george, tosho, sasho };
            Kitten[] kittens = { elisabeth, sara, ivi };
            Dog[] dogs = { sharo, svetlin, mincho };

            george.ProduceSound();
            elisabeth.ProduceSound();
            sharo.ProduceSound();
            frogcho.ProduceSound();
        }
    }
}
