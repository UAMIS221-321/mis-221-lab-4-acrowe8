//start main
DisplayMenu();
string userChoice = Console.ReadLine();
RouteEm(userChoice);
Random numRows = new Random();
int numRows = rnd.Next(8,12);
//end main

static void DisplayMenu(){
    System.Console.WriteLine("1. plain\n1 2. cheese pizza\n2 3. pepperoni pizza\n3 4. exit\n4");
}
static void RouteEm(string userChoice){
    switch{
        case "1":
            PlainPizza();
        break;
        case "2":
            CheesePizza();
        break;
        case "3":
            PepperoniPizza();
        break;
        case "4":
            SayBye();
        break;
        default:
            System.Console.WriteLine("Entered invalid menu choice");
        break;
    }
}
static void PlainPizza(int numRows){
    for(int=0;int<5;int++){
        for(int j=numrows;j<0;j--){
            System.Console.Write("*");
        }
        System.Console.WriteLine(" ");
    }
}
static void CheesePizza(){
    for(int=0;int<5;int++){
        for(int j=numrows;j<0;j--){
            if(i == 0){
                System.Console.Write("*");
            }
            else{
                System.Console.Write("#");
            }
        }
        System.Console.WriteLine("*");
    }

}
static void PepperoniPizza(){
    for(int=0;int<5;int++){
        for(int j=numrows;j<0;j--){
            if(i == 0){
                System.Console.Write("*");
            }
            else{
                System.Console.Write("#");
            }
        }
        System.Console.WriteLine("*");
    }
}
static void SayBye(){
    System.Console.WriteLine("Bye!");
}



