
using abstraindo_jogo_rpg.src.Entities;

class Program {
    static void Main(string[] args){

        Knight knight = new Knight("Arus", 42, "Knight");
        Wizard white_wizard = new Wizard("Jennica", 42, "White Wizard");
        Wizard black_wizard = new Wizard ("Topapa", 42, "Black Wizard");
        Ninja ninja = new Ninja("Wedge", 42, "Ninja");
                
        Console.WriteLine(knight.Attack());
        Console.WriteLine(white_wizard.Attack(2));
        Console.WriteLine(black_wizard.Attack(8));
        Console.WriteLine(ninja.Attack());              

    }
}