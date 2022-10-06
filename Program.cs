
void printCat(){
Console.WriteLine(@"|\__/,|    ('\ ");
Console.WriteLine(@"|_ _  | .--.) )");
Console.WriteLine(@"( T   )      /");
Console.WriteLine(@"((^_(((/(((_/");
}
//printCat();

void inputInput(){
    Console.WriteLine("hello, please write something");
    string userIntput = Console.ReadLine();
    Console.WriteLine($"you wrote {userIntput}");
    Console.ReadKey();
}
//inputInput();

int Addition(){
    Console.WriteLine("choose your first number");
    int addNumOne = Int32.Parse(Console.ReadLine());
    Console.WriteLine("what are you adding to that number?");
    int addNumTwo = Int32.Parse(Console.ReadLine());
    int addAnswer = addNumOne + addNumTwo;
    Console.Write($"your answer is : {addAnswer}");
    return addAnswer;
}
//Addition();

int Subtraction(){
    Console.WriteLine("choose your first number");
    int subNumOne = Int32.Parse(Console.ReadLine());
    Console.WriteLine("what are you subtracting from that number?");
    int subNumTwo = Int32.Parse(Console.ReadLine());
    int subAnswer = subNumOne - subNumTwo;
    Console.Write($"your answer is : {subAnswer}");
    return subAnswer;
}

int Multiplcaton(){
    Console.WriteLine("choose your first number");
    int multiNumOne = Int32.Parse(Console.ReadLine());
    Console.WriteLine("what are you multiplying the number by?");
    int multiNumTwo = Int32.Parse(Console.ReadLine());
    int multiAnswer = multiNumOne * multiNumTwo;
    Console.Write($"your answer is : {multiAnswer}");
    return multiAnswer;
}

int Division(){
    Console.WriteLine("choose your first number");
    int NumOne = Int32.Parse(Console.ReadLine());
    Console.WriteLine("what are dividing the number by?");
    int NumTwo = Int32.Parse(Console.ReadLine());
    int Answer = NumOne / NumTwo;
    Console.Write($"your answer is : {Answer}");
    return Answer;
}
    
    

bool calcEnder=true;
    while (calcEnder==true){
    Console.WriteLine("calulator 2!! electric boogaloo");
    Console.WriteLine("CHOOSE MATH TYPE");
    Console.WriteLine(" (1) Add \n (2) Subtract \n (3) Multiply \n (4) Divide\n (5) cat\n (6) Leave");
    int question = Int32.Parse(Console.ReadLine());

    switch (question){
        case 1:
        Addition();
        Console.ReadKey();
        break;
        case 2:
        Subtraction();
        Console.ReadKey();
        break;
        case 3:
        Multiplcaton();
        Console.ReadKey();
        break;
        case 4:
        Division();
        Console.ReadLine();
        break;
        case 5:
        printCat();
        Console.ReadKey();
        break;
        case 6:
        Console.WriteLine("thanks for calulating!");
        calcEnder=false;
        break;
        default:
        Console.WriteLine("invalid input");   
        break;
    }
    }