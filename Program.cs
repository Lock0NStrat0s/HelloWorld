#region PART 1
//level 3
//string name;
//Console.WriteLine("Bread is ready./nWho is the bread for?");
//name = Console.ReadLine();
//Console.WriteLine("Noted: " + name + " got bread.");

//level 6 - C# TYPE SYSTEM
//the variable shop
//byte b = 12;                //byte
//Console.WriteLine(b);
//short
//int
//long
//sbyte
//ushort
//uint
//ulong num = 1_000_000_000_000_000UL;      //ulong
//Console.WriteLine(num);

//level 7 - MATH

//challenge 1: triangle farmer
//int area, baseT, height;
//Console.WriteLine("What is the height: ");
//int.TryParse(Console.ReadLine(), out height);
//Console.WriteLine("What is the base: ");
//int.TryParse(Console.ReadLine(), out baseT);
//area = baseT * height / 2;
//Console.WriteLine($"The area of the triangle is {area} units squared");

//challenge 2: the four sisters and the duckbear
//int total, rem, per;
//Console.WriteLine("How many eggs were collected today: ");
//int.TryParse(Console.ReadLine(), out total);
//rem = total % 4;
//if (rem == 0)
//{
//    per = total / 4;
//}
//else
//{
//    per = (total - rem) / 4;
//}
//Console.WriteLine($"Each sister gets {per} eggs and the duckbear gets {rem} eggs.");

//challenge 3: The Dominion of Kings
//int total, p, d, e;
//Console.Write("# of provinces: ");
//int.TryParse(Console.ReadLine(), out p);
//Console.Write("# of duchies: ");
//int.TryParse(Console.ReadLine(), out d);
//Console.Write("# of estates: ");
//int.TryParse(Console.ReadLine(), out e);
//total = 6 * p + 3 * d + e;
//Console.WriteLine($"Your total points are {total}.");

//level 8 - CONSOLE 2.0
//challenge 1: The Defense of Consolas
//Console.Title = "Defense of Consolas";
//int row, column;
//Console.Write("Target Row: ");
//int.TryParse(Console.ReadLine(), out row);
//Console.Write("Target Column: ");
//int.TryParse(Console.ReadLine(), out column);
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"Deploy to:\n({row},{column - 1})\n({row - 1},{column})\n({row},{column + 1})\n({row + 1},{column})");
//Console.Beep();

//level 9 - DECISION MAKING
//challenge 1: Repairing the Clocktower
//int num;
//Console.Write("Enter a number: ");
//int.TryParse(Console.ReadLine(), out num);
//if (num % 2 == 0)
//{
//    Console.WriteLine("Tick");
//}
//else
//{
//    Console.WriteLine("Tock");
//}

//challenge 2: Watchtower
//int x, y;
//Console.Write("Enter x position: ");
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Enter y position: ");
//int.TryParse(Console.ReadLine(), out y);
//if (x == 0 && y == 0)
//    Console.WriteLine("The enemy is here!");
//else if (x < 0 && y < 0)
//    Console.WriteLine("The enemy is to the SW!");
//else if (x > 0 && y < 0)
//    Console.WriteLine("The enemy is to the SE!");
//else if (x < 0 && y > 0)
//    Console.WriteLine("The enemy is to the NW!");
//else if (x > 0 && y > 0)
//    Console.WriteLine("The enemy is to the NE!");
//else if (x == 0 && y < 0)
//    Console.WriteLine("The enemy is to the S!");
//else if (x == 0 && y > 0)
//    Console.WriteLine("The enemy is to the N!");
//else if (x < 0 && y == 0)
//    Console.WriteLine("The enemy is to the W!");
//else if (x > 0 && y == 0)
//    Console.WriteLine("The enemy is to the E!");

//level 10 - SWITCHES

//challenges 1: Buying Inventory
//int num;
//Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing" +
//    " Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n" +
//    "What number do you want to see the price of? ");
//int.TryParse(Console.ReadLine(), out num);
////string response;
////response = num switch
////{
////    1 => "Rope costs 10 gold",
////    2 => "Torches cost 15 gold",
////    3 => "Climbing Equipment costs 25 gold",
////    4 => "Clean Water costs 1 gold",
////    5 => "Machete costs 20 gold",
////    6 => "Canoe costs 200 gold",
////    7 => "Food Supplies cost 1 gold",
////    _ => ""
////};
////Console.WriteLine(response);

//challenge 2: Discounted Inventory
//int rope = 10; int torches = 15; int ce = 25; int cw = 1; int machete = 20; int canoe = 200; int fs = 1;
//string name, response;
//Console.Write("What is your name? ");
//name = Console.ReadLine();
//float value = 1;
//if (name == "quack") value /= 2;
//switch (num)
//{
//    case 1: value *= rope; response = $"Rope costs {value} gold"; break;
//    case 2: value *= torches; response = $"Torches cost {value} gold"; break;
//    case 3: value *= ce; response = $"Climbing Equipment costs {value} gold"; break;
//    case 4: value *= cw; response = $"Clean Water costs {value} gold"; break;
//    case 5: value *= machete; response = $"Machete costs {value} gold"; break;
//    case 6: value *= canoe; response = $"Canoe costs {value} gold"; break;
//    case 7: value *= fs; response = $"Food Supplies cost {value} gold"; break;
//    default: response = ""; break;
//}
//Console.WriteLine(response);

//level 11 - LOOPING

//challenge 1: The Prototype
//int num1, num2;
//Console.Write("User 1, enter a number between 0 and 100: ");
//int.TryParse(Console.ReadLine(), out num1);
//Console.Clear();
//do
//{
//    Console.Write("User 2, guess the number: ");
//    int.TryParse(Console.ReadLine(), out num2);
//    if (num2 > num1) Console.WriteLine($"{num2} is too high");
//    else if (num2 < num1) Console.WriteLine($"{num2} is too low");
//    else Console.WriteLine("You guessed it!");
//} while (!(num1 == num2));

//challenge 2: The Magic Cannon
//string status = "";
//for (int i = 1; i <= 100; ++i)
//{
//    Console.ForegroundColor = ConsoleColor.White;
//    status = "Normal";
//    if (i % 3 == 0) { status = "Fire"; Console.ForegroundColor = ConsoleColor.Red; }
//    if (i % 5 == 0) { status = "Electric"; Console.ForegroundColor = ConsoleColor.Yellow; }
//    if (i % 15 == 0) { status = "KABOOOOOOOOOOM"; Console.ForegroundColor = ConsoleColor.Blue; }
//    Console.WriteLine($"{i}: " + status);
//}

//level 12 - ARRAYS

//challenge 1: The Replicator of D'To
//int[] num = new int[5];
//Console.Write("Enter 5 numbers separated by a space: ");
//string line = Console.ReadLine();
//string[] data = line.Split(' ');
//for (int i = 0; i < data.Length; i++)
//{
//    num[i] = int.Parse(data[i]);
//}
//int[] num2 = new int[5];
//for (int i = 0; i < num.Length; i++)
//{
//    num2[i] = num[i];
//    Console.WriteLine($"{num[i]} : {num2[i]}");
//}

//challenge 2: The Laws of Freach
//smallest value
//int[] array = new int[] { 4, 81, -7, 13, -99, 15, -8, 45, 90 };
//int currentSmallest = int.MaxValue;
////for (int i = 0; i < array.Length; i++)
////    if (array[i] < currentSmallest) currentSmallest = array[i];
//foreach (int i in array)
//    if (i < currentSmallest) currentSmallest = i;
//Console.WriteLine(currentSmallest);

////average value
//int total = 0;
////for (int i = 0; i < array.Length; i++)
////    total += array[i];
//foreach (int i in array)
//    total += i;
//float average = (float)total / array.Length;
//Console.WriteLine(average);

//level 13 - METHODS

//challenge 1: Taking a Number

//Console.WriteLine(AskForNumber("What is 2 * 3? "));
//int AskForNumber(string text)
//{
//    Console.Write(text);
//    return int.Parse(Console.ReadLine());
//}

//int min = 15;
//int max = 30;
//AskForNumberInRange($"Select a number between {min} and {max}: ", min, max);

//int AskForNumberInRange(string text, int min, int max)
//{
//    int value = 0;
//    do
//    {
//        Console.Write(text);
//        int.TryParse(Console.ReadLine(), out value);
//    } while (value < min || value > max);
//    return value;
//}

//challenge 2: Countdown
//for (int i = 10; i > 0; i--)
//    Console.WriteLine(i);
//Countdown(10);
//int Countdown(int num)
//{
//    Console.WriteLine(num);
//    if (num <= 0) return 0;
//    return Countdown(num - 1);
//}

//level 14 - MEMORY MANAGEMENT

/*  Memory:
    1. You can access anything on the stack at anytime? FALSE
    2. The stack keeps track of local variables? TRUE
    3. The contents of a value type can be placed on the heap? TRUE
    4. The contents of a value type are always placed on the heap? FALSE
    5. The contents of a reference type are always placed on the heap? TRUE
    6. The garbage collector cleans up old, unused space on the heap and stack? FALSE
    7. If a and b are array variables referencing the same object, modifiying a affects b as well? TRUE
    8. If a and b are ints with the same value, changing a will also affect b? FALSE
*/

//challenge 1: Hunting the Manticore

////intitialize variables
//int maxCityH = 15;
//int maxManticoreH = 10;
//int pos;

////read player 1 response and store as position
//pos = CheckValue("Player 1, how far away from the city do you want to station the Manticore (0-100)? ");
//Console.WriteLine("Player 2, it is your turn: ");

////run game until either city health or manticore health hits zero
//DisplayRounds(maxCityH, maxManticoreH, pos);

////method to display rounds
//void DisplayRounds(int maxC, int maxM, int pos)
//{
//    int round = 0;
//    int currCityH = 15;
//    int currMantiH = 10;
//    do
//    {
//        Console.WriteLine("-----------------------------------------------------------------------");
//        Console.WriteLine($"STATUS: Round: {++round} City: {currCityH}/{maxC} Manticore: {currMantiH}/{maxM}");
//        int dmg = Damage(round);
//        Console.WriteLine($"The cannon is expected to deal {dmg} damage this round.");
//        int target = CheckValue("Enter desired cannon range: ");
//        currCityH--;
//        if (TargetAcquisition(pos, target))
//            currMantiH -= dmg;
//    } while (currCityH > 0 && currMantiH > 0);
//}

////method to validate user response
//int CheckValue(string ask)
//{
//    int pos = -1;
//    do
//    {
//        Console.Write(ask);
//        string response = Console.ReadLine();
//        pos = int.Parse(response);
//    } while (pos < 0 || pos > 100);
//    return pos;
//}

////method to calculate target damage
//int Damage(int round)
//{
//    if (round % 15 == 0)
//        return 10;
//    else if (round % 5 == 0)
//        return 5;
//    else if (round % 3 == 0)
//        return 3;
//    return 1;
//}

////method to determine target acquisition
//bool TargetAcquisition(int pos, int target)
//{
//    if (pos != target)
//    {
//        if (target < pos)
//            Console.WriteLine("That round FELL SHORT of the target.");
//        else
//            Console.WriteLine("That round OVERSHOT the target.");
//        return false;
//    }
//    else
//    {
//        Console.WriteLine("That round was a DIRECT HIT!");
//        return true;
//    }
//}
#endregion

#region PART 2 - 1
//Level 15: Object Oriented Concepts

/*Knowledge Check: Objects
    1. What two things does an object bundle together? Data and operations on that data (methods)
    2. C# lets you define new types of objects? True
*/

//Level 16: Enumerations

//Challenge 1: Simula's Test

//State state = State.Locked;
//string response;
//Console.WriteLine("Press E to exit.");
//do
//{
//    Console.Write($"The chest is {state}. What do you want to do? ");
//    response = Console.ReadLine();
//    if (response.ToLower() == "unlock" && state == State.Locked)
//        state = State.Closed;
//    else if (response.ToLower() == "open" && state == State.Closed)
//        state = State.Open;
//    else if (response.ToLower() == "close" && state == State.Open)
//        state = State.Closed;
//    else if (response.ToLower() == "lock" && state == State.Closed)
//        state = State.Locked;
//    else
//        continue;
//} while (response.ToLower() != "e");

//enum State
//{
//    Open,
//    Closed,
//    Locked
//}

//Level 17: Tuples

//Challenge 1: Simula's Soup

//(Type type, MainIngredients mainIngredients, Seasoning seasoning) soup;
//int typeVal;
//do
//{
//    Console.Write("Pick a type of food: Soup - 0, Stew - 1, Gumbo - 2 --> ");
//    int.TryParse(Console.ReadLine(), out typeVal);
//} while (typeVal < 0 || typeVal > 2);
//soup.type = (Type)typeVal;
//int ingredientVal;
//do
//{
//    Console.Write("Pick a main ingredient: Mushrooms - 0, chicken - 1, carrots - 2, potatoes - 3 --> ");
//    int.TryParse(Console.ReadLine(), out ingredientVal);
//} while (ingredientVal < 0 || ingredientVal > 3);
//soup.mainIngredients = (MainIngredients)ingredientVal;
//int seasoningVal;
//do
//{
//    Console.Write("Pick a seasoning: Spicy - 0, Salty - 1, Sweet - 2 --> ");
//    int.TryParse(Console.ReadLine(), out seasoningVal);
//} while (seasoningVal < 0 || seasoningVal > 2);
//soup.seasoning = (Seasoning)seasoningVal;
//Console.WriteLine(soup);
//enum Type { Soup, Stew, Gumbo }
//enum MainIngredients { Mushrooms, Chicken, Carrots, Potatoes }
//enum Seasoning { Spicy, Salty, Sweet }

//Level 18: Classes

/* OBJECT ORIENTED PRINCIPLE #1: ENCAPSULATION
 * Combining data (fields) and the operations on that data (methods)
 * into a well defined unit (like a class) */

//Challenge 1: Vin Fletcher's Arrows (DONE BELOW IN LVL 21)

//Level 19: Information Hiding

/* OBJECT ORIENTED PRINCIPLE #2: INFORMATION HIDING
 * Only the object itself should directly access its data */

/* OBJECT ORIENTED PRINCIPLE #3: ABSTRACTION
 * The outside world does not need to know each object or class's inner workings
 * and can deal with it as an abstract concept. Abstraction allows the inner
 * workings to change without affecting the outside world. */

//Challenge 1: Vin's Trouble (DONE BELOW IN LVL 21)

//LEVEL 20: PROPERTIES

//Challenge 1: The Properties of Arrows (DONE BELOW IN LVL 21)

//LEVEL 21: STATIC

//Challenge 1: Arrow Factories

//init
//string input;

//Console.Write("What arrow do you want?\n1 - Elite Arrow\n2 - Beginner Arrow\n" +
//    "3 - Marksman Arrow\n4 - Custom Arrow -----> ");
//input = Console.ReadLine();

////create arrow with user input
//Arrow newArrow = input switch
//{
//    "1" => Arrow.CreateEliteArrow(),
//    "2" => Arrow.CreateBeginnerArrow(),
//    "3" => Arrow.CreateMarksmanArrow(),
//    _ => CreateCustomArrow()
//};

//Arrow CreateCustomArrow()
//{
//    Console.Write("Arrowhead: s - Steel, w - Wood, o - Obsidian: ");
//    input = Console.ReadLine().ToLower();
//    Arrowhead arrowHead = input switch
//    {
//        "s" => Arrowhead.Steel,
//        "w" => Arrowhead.Wood,
//        "o" => Arrowhead.Obsidian,
//        _ => Arrowhead.Steel
//    };

//    Console.Write("Fletching: p - plastic, t - turkey feather, g - goose feather: ");
//    input = Console.ReadLine().ToLower();
//    Fletching arrowFletching = input switch
//    {
//        "p" => Fletching.Plastic,
//        "t" => Fletching.TurkeyFeather,
//        "g" => Fletching.GooseFeather,
//        _ => Fletching.Plastic
//    };

//    float shaftSize = 0;
//    do
//    {
//        Console.Write("Choose shaft size between 60 and 100cm: ");
//        shaftSize = float.Parse(Console.ReadLine());
//    } while (shaftSize < 60 || shaftSize > 100);

//    return new Arrow(arrowHead, arrowFletching, shaftSize);
//}

//Console.WriteLine($"This arrow has the following properties:\nArrow Head: {newArrow.Head}\n" +
//    $"Fletching: {newArrow.Fletching}\nShaft Size: {newArrow.Shaft}");
//Console.WriteLine($"The cost of this arrow is {newArrow.GetCost:C2}");

////--------------------------------------------------------------------------------

//class Arrow
//{
//    public Arrowhead Head { get; }
//    public Fletching Fletching { get; }
//    public float Shaft { get; }

//    public Arrow(Arrowhead head, Fletching fletching, float shaft)
//    {
//        Head = head;
//        Fletching = fletching;
//        Shaft = shaft;
//    }

//    public float GetCost
//    {
//        get {
//            float arrowheadCost = Head switch
//            {
//                Arrowhead.Steel => 10,
//                Arrowhead.Wood => 3,
//                Arrowhead.Obsidian => 5
//            };

//            float fletchingCost = Fletching switch
//            {
//                Fletching.Plastic => 10,
//                Fletching.TurkeyFeather => 5,
//                Fletching.GooseFeather => 3
//            };

//            return arrowheadCost + fletchingCost + Shaft * 0.05f;
//        }
//    }

//    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
//    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeather, 75);
//    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeather, 65);
//}

//enum Arrowhead { Steel, Wood, Obsidian }
//enum Fletching { Plastic, TurkeyFeather, GooseFeather }

//LEVEL 22: NULL REFERENCES

//LEVEL 23: OBJECT ORIENTED DESIGN

//LEVEL 24: THE CATACOMBS OF THE CLASS
#endregion

#region PART 2 - BOSS BATTLES
/****************************************************************************************/
//Boss Battle 1: The Point

//Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
//      The x and y coordinates are immutable because they cannot be changed after the point is made
//      due to having a private setter. The public getter allows them to be viewed outside the class.

//Point pointUno = new Point(2, 3);
//Point pointDos = new Point(-4, 0);

//Console.WriteLine($"({pointUno.X}, {pointUno.Y})\n\n({pointDos.X}, {pointDos.Y})");

//class Point
//{
//    public int X { get; }
//    public int Y { get; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public Point() : this(0, 0)
//    {
//    }
//}

/****************************************************************************************/
//Boss Battle 2: The Colour

//Colour customColour = new Colour(32, 89, 166);
//Colour preColour = Colour.Purple();

//Console.WriteLine($"Custom: ({customColour.R}, {customColour.G}, {customColour.B})");
//Console.WriteLine($"Pre-defined: ({preColour.R}, {preColour.G}, {preColour.B})");

//class Colour
//{
//    public int R { get; }
//    public int G { get; }
//    public int B { get; }

//    public Colour(int red, int green, int blue)
//    {
//        R = red;
//        G = green;
//        B = blue;
//    }

//    public static Colour White { get; } = new Colour(255, 255, 255);
//    public static Colour Black { get; } = new Colour(0, 0, 0);
//    public static Colour Red { get; } = new Colour(255, 0, 0);
//    public static Colour Orange { get; } = new Colour(255, 165, 0);
//    public static Colour Yellow { get; } = new Colour(255, 255, 0);
//    public static Colour Green { get; } = new Colour(0, 128, 0);
//    public static Colour Blue { get; } = new Colour(0, 0, 255);
//    public static Colour Purple { get; } = new Colour(128, 0, 128);
//}

/****************************************************************************************/
//Boss Battle 3: The Card

//Card card;

//foreach (Rank rank in Enum.GetValues(typeof(Rank)))
//{
//    foreach (Colour colour in Enum.GetValues(typeof(Colour)))
//    {
//        card = new Card(colour, rank);
//        Console.WriteLine($"The {card.Clr} {card.Rnk}. Face Card: {card.IsFace}");
//    }
//}

//class Card
//{
//    public Colour Clr { get; }
//    public Rank Rnk { get; }

//    public Card(Colour clr, Rank rnk)
//    {
//        Clr = clr;
//        Rnk = rnk;
//    }

//    public bool IsFace => Rnk == Rank.Dollar || Rnk == Rank.Percent || Rnk == Rank.Hat || Rnk == Rank.Ampersand;
//    public bool isNum => !IsFace;
//}

//enum Colour { red, green, blue, yellow };
//enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Hat, Ampersand };

/****************************************************************************************/
//Boss Battle 4: The Locked Door

//locked: cannot open or close
//unlocked: can open or close or lock
//open: cannot lock, can close
//closed: can lock or open

////create passcode (4 characters)
//string passcode, result, action, newPasscode;
//do
//{
//    Console.Write("Create door with passcode (4 characters/digits): ");
//    passcode = Console.ReadLine();
//} while (passcode.Length != 4);

////create door
//Door door = new Door(passcode);

////loop program until user enters e
//do
//{
//    Console.WriteLine($"Current State of Door: {door.DoorLock}, {door.DoorOpen}\n");

//    Console.Write("Choose action: l - Lock, u - Unlock, o - Open, c - Close, p - Change Passcode, e - Exit: ");
//    result = Console.ReadLine().ToLower();

//    if (result == "l") door.Lock();
//    else if (result == "u") door.Unlock();
//    else if (result == "o") door.Open();
//    else if (result == "c") door.Close();
//    else if (result == "p") ChangePasscode();

//} while (result != "e");

//void ChangePasscode()
//{
//    Console.Write("Change passcode -> old passcode: ");
//    passcode = Console.ReadLine();
//    do
//    {
//        Console.Write("Enter new passcode: ");
//        newPasscode = Console.ReadLine();
//    } while (newPasscode.Length != 4);

//    door.ChangePasscode(passcode, newPasscode);
//    Console.WriteLine($"Passcode: {door.Passcode}");
//}

//class Door
//{
//    public StateLock DoorLock { get; private set; } = StateLock.Locked;
//    public StateOpen DoorOpen { get; private set; } = StateOpen.Closed;
//    public string Passcode { get; private set; }

//    public Door(string passcode)
//    {
//        Passcode = passcode;
//    }

//    public void Lock()
//    {
//        if (DoorLock == StateLock.Unlocked && DoorOpen == StateOpen.Closed)
//            DoorLock = StateLock.Locked;
//    }
//    public void Unlock()
//    {
//        if (DoorLock == StateLock.Locked && DoorOpen == StateOpen.Closed)
//            DoorLock = StateLock.Unlocked;
//    }
//    public void Open()
//    {
//        if (DoorLock == StateLock.Unlocked && DoorOpen == StateOpen.Closed)
//            DoorOpen = StateOpen.Opened;
//    }
//    public void Close()
//    {
//        if (DoorLock == StateLock.Unlocked && DoorOpen == StateOpen.Opened)
//            DoorOpen = StateOpen.Closed;
//    }

//    public bool ChangePasscode(string oldPasscode, string newPasscode)
//    {
//        if (!(oldPasscode == Passcode)) return false;
//        else Passcode = newPasscode; return true;
//    }
//}

//enum StateLock { Locked, Unlocked }
//enum StateOpen { Opened, Closed }

/****************************************************************************************/
//Boss Battle 5: The Password Validator

//string result;
//PasswordValidator passValidator = new PasswordValidator();
//do
//{
//    Console.Write("Enter password (e to exit): ");
//    result = Console.ReadLine();
//    if (passValidator.IsValid(result)) Console.WriteLine("The password is valid!");
//    else Console.WriteLine("The password is not valid");
//} while (result.ToLower() != "e");

//class PasswordValidator
//{
//    public bool IsValid(string Password)
//    {
//        if (Password.Length < 6 || Password.Length > 13) return false;  //check length
//        if (!HasUpperCase(Password)) return false;
//        if (!HasLowerCase(Password)) return false;
//        if (!HasDgit(Password)) return false;
//        if (Contains(Password, 'T')) return false;
//        if (Contains(Password, '&')) return false;

//        return true;
//    }

//    private bool HasUpperCase(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsUpper(letter)) return true;

//        return false;
//    }

//    private bool HasLowerCase(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsLower(letter)) return true;

//        return false;
//    }

//    private bool HasDgit(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsDigit(letter)) return true;

//        return false;
//    }

//    private bool Contains(string password, char character)
//    {
//        foreach (char letter in password)
//            if (letter == character) return true;

//        return false;
//    }
//}

//Boss Battle Final: Tic-Tac-Toe

////initialize
//int round = 1;
//Player myTurn = null;
//string result;

////create players
//Player P1 = new Player('X');
//Player P2 = new Player('O');

////create 3x3 board
//Board board = new Board();

////create game state
//GameState gameState = new GameState();

//for (; ; )
//{
//    //draw grid
//    Console.WriteLine($" {board.Grid[0]} | {board.Grid[1]} | {board.Grid[2]} ");
//    Console.WriteLine($"-----------");
//    Console.WriteLine($" {board.Grid[3]} | {board.Grid[4]} | {board.Grid[5]} ");
//    Console.WriteLine($"-----------");
//    Console.WriteLine($" {board.Grid[6]} | {board.Grid[7]} | {board.Grid[8]} ");

//    //check if game is won or grid tiles are finished
//    if (gameState.GameWon(board))
//    {
//        Console.WriteLine($"{myTurn.Symbol} is the Winner!");
//        break;
//    }
//    else if (board.isFull())
//    {
//        Console.WriteLine("DRAW!!!");
//        break;
//    }

//    //whose turn is it
//    if (gameState.WhoseTurn(round)) myTurn = P1;
//    else myTurn = P2;

//    //ask user for square input
//    Console.WriteLine($"\n\nIt is {myTurn.Symbol}'s turn.");
//    Console.Write("What square do you want to play in (1-9): ");
//    result = Console.ReadLine();

//    //insert into grid, if valid
//    if (board.Insert(int.Parse(result), myTurn.Symbol)) round++;
//    else Console.WriteLine("Please try again!");
//}

//class Player
//{
//    public char Symbol { get; }

//    public Player(char symbol)
//    {
//        Symbol = symbol;
//    }
//}

//class Board
//{
//    public char[] Grid { get; } = new char[9];

//    public Board()
//    {
//        for (int i = 0; i < 9; i++)
//            Grid[i] = ' ';
//    }
//    public bool Insert(int i, char c)
//    {
//        if (Grid[i - 1] == ' ')
//        {
//            Grid[i - 1] = c;
//            return true;
//        }
//        else return false;
//    }

//    public bool isFull()
//    {
//        foreach (char c in Grid)
//            if (c == ' ') return false;

//        return true;
//    }
//}

//class GameState
//{
//    public bool WhoseTurn(int round)
//    {
//        return round % 2 == 0;
//    }

//    public bool GameWon(Board grid)
//    {
//        char[] square = grid.Grid;

//        //check rows
//        if (square[0] != ' ' && square[0] == square[1] && square[0] == square[2]) return true;
//        if (square[3] != ' ' && square[3] == square[4] && square[3] == square[5]) return true;
//        if (square[6] != ' ' && square[6] == square[7] && square[6] == square[8]) return true;

//        //check columns
//        if (square[0] != ' ' && square[0] == square[3] && square[0] == square[6]) return true;
//        if (square[1] != ' ' && square[1] == square[4] && square[1] == square[7]) return true;
//        if (square[2] != ' ' && square[2] == square[5] && square[2] == square[8]) return true;

//        //check diagonals
//        if (square[0] != ' ' && square[0] == square[4] && square[0] == square[8]) return true;
//        if (square[2] != ' ' && square[2] == square[4] && square[2] == square[6]) return true;

//        return false;
//    }
//}

/*********************************************************************************************/
#endregion

#region PART 2 - 2
//LEVEL 25: INHERITANCE

/* Object Oriented Principle #4: INHERITANCE
 * Basing one class on another, retaining the original class's functionality 
 * while extending the new class with additional capabilities. */

//Challenge 1: Packing Inventory (DONE BELOW IN LVL 26)

//LEVEL 26: POLYMORPHISM

/* Object-Oriented Principle #5: POLYMORPHISM
 * Derived classes can override methods from the base class.
 * The correct version is determined at runtime, so you will
 * get different behaviour depending on the object's class*/

//Challenge 1: Labeling Inventory

//initialization
//string maxLimit, maxWeight, maxVolume, result;
//int count = 0;

////create Pack
//Console.Write("Welcome to Packing Inventory!\nSelect Max Item Limit: ");
//maxLimit = Console.ReadLine();
//Console.Write("Select Max Item Weight: ");
//maxWeight = Console.ReadLine();
//Console.Write("Select Max Item Volume: ");
//maxVolume = Console.ReadLine();

//Pack pack = new Pack(int.Parse(maxLimit), float.Parse(maxWeight), float.Parse(maxVolume));

//Console.WriteLine($"This Pack has:\n--Max Item Limit: {pack.TotalItems}" +
//    $"\n--Max Weight: {pack.MaxWeight}\n--Max Volume: {pack.MaxVolume}");

////run until user exits
//while (true)
//{
//    //ask user to select from menu
//    Console.Write("\nWhat item do you want to add?\na - Arrow\nb - Bow\nr - Rope\n" +
//        "w - Water\nf - Food\ns - Sword\nSelect: ");
//    result = Console.ReadLine().ToLower();

//    //create inventory item from user input
//    InventoryItem newItem = result switch
//    {
//        "a" => new Arrow(),
//        "b" => new Bow(),
//        "r" => new Rope(),
//        "w" => new Water(),
//        "f" => new Food(),
//        "s" => new Sword(),
//        _ => new Arrow()        //default to arrow if invalid selection
//    };

//    //check if item can be added to pack
//    if (pack.Add(newItem))
//        pack.Items[count++] = newItem;
//    Console.Write("\n");

//    //display all items in pack
//    for (int i = 0; i < pack.Items.Count(); i++)
//        if (pack.Items[i] != null)
//            Console.WriteLine($"Slot {i}: Item Name: {pack.Items[i].GetType().Name}" +
//                $", Weight: {pack.Items[i].ItemWeight}, Volume: {pack.Items[i].ItemVolume}");

//    //display current weight/volume
//    Console.WriteLine($"\nPack weight: {pack.CurrentWeight}/{pack.MaxWeight}\n" +
//        $"Pack volume: {pack.CurrentVolume}/{pack.MaxVolume}");

//    //display contents
//    Console.WriteLine($"0th item: {pack.Items[0]?.ToString()}");
//    Console.WriteLine($"Pack items: {pack.ToString()}");
//}

//class InventoryItem
//{
//    public float ItemWeight { get; }
//    public float ItemVolume { get; }

//    public InventoryItem(float weight, float volume)
//    {
//        ItemWeight = weight;
//        ItemVolume = volume;
//    }

//    public override string ToString()
//    {
//        return GetType().Name.ToString();
//    }
//}
//class Arrow : InventoryItem { public Arrow() : base(0.1f, 0.05f) { } }
//class Bow : InventoryItem { public Bow() : base(1f, 4f) { } }
//class Rope : InventoryItem { public Rope() : base(1f, 1.5f) { } }
//class Water : InventoryItem { public Water() : base(2f, 3f) { } }
//class Food : InventoryItem { public Food() : base(1f, 0.5f) { } }
//class Sword : InventoryItem { public Sword() : base(5f, 3f) { } }
//class Pack
//{
//    public int TotalItems { get; }
//    public float MaxWeight { get; }
//    public float CurrentWeight { get; private set; } = 0;
//    public float MaxVolume { get; }
//    public float CurrentVolume { get; private set; } = 0;
//    public InventoryItem[] Items;

//    public Pack(int totalItems, float maxWeight, float maxVolume)
//    {
//        TotalItems = totalItems;
//        MaxWeight = maxWeight;
//        MaxVolume = maxVolume;

//        Items = new InventoryItem[totalItems];
//    }

//    public bool Add(InventoryItem item)
//    {
//        foreach (InventoryItem i in Items)
//            if (i == null && (CurrentWeight + item.ItemWeight < MaxWeight)
//                && (CurrentVolume + item.ItemVolume < MaxVolume))
//            {
//                CurrentWeight += item.ItemWeight;
//                CurrentVolume += item.ItemVolume;
//                return true;
//            }
//        return false;
//    }

//    public override string ToString()
//    {
//        string name = "";
//        foreach (InventoryItem i in Items)
//        {
//            name += $"{i} ";
//        }
//        return $"Pack containing {name}";
//    }
//}

//Challenge 2: The Old Robot

////init
//Robot robot = new Robot();

////run program
//while (true)
//{
//    //get user inputs up to limit
//    for (int i = 0; i < robot.Commands.Length; i++)
//    {
//        Console.Write("Command: ");
//        string? input = Console.ReadLine().ToLower();

//        //set robot command
//        RobotCommand RCommand = input switch
//        {
//            "on" => new OnCommand(),
//            "off" => new OffCommand(),
//            "north" => new NorthCommand(),
//            "south" => new SouthCommand(),
//            "west" => new WestCommand(),
//            "east" => new EastCommand(),
//            _ => new OffCommand()
//        };

//        //add command to array
//        robot.Commands[i] = RCommand;
//    }
//    Console.WriteLine();

//    //display results
//    robot.Run();
//}

//abstract class RobotCommand
//{
//    public abstract void Run(Robot robot);
//}

//class OnCommand : RobotCommand
//{
//    public override void Run(Robot robot) => robot.IsPowered = true;
//}
//class OffCommand : RobotCommand
//{
//    public override void Run(Robot robot) => robot.IsPowered = false;
//}
//class NorthCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
//}
//class SouthCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
//}
//class WestCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
//}
//class EastCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
//}


//class Robot
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public bool IsPowered { get; set; }
//    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];

//    public void Run()
//    {
//        foreach (RobotCommand? command in Commands)
//        {
//            command?.Run(this);
//            Console.WriteLine($"[{X} {Y} {IsPowered}]");
//        }
//    }
//}

//Polymorphism Practice:

//Animal and their sounds - program will iterate through 3 animal sounds

//Animal ani = new Animal();

//ani.Sounds[0] = new Dog();
//ani.Sounds[1] = new Cat();
//ani.Sounds[2] = new Rooster();

//ani.Listen();

//class Animal
//{
//    public string Sound { get; set; }
//    public Sound[] Sounds { get; } = new Sound[3];

//    public void Listen()
//    {
//        foreach (Sound s in Sounds)
//        {
//            s.Noise(this);
//            Console.WriteLine(Sound);
//        }
//    }
//}

//abstract class Sound
//{
//    public abstract void Noise(Animal a);
//}
//class Dog : Sound
//{
//    public override void Noise(Animal a)
//    {
//        a.Sound = "Woof!";
//    }
//}
//class Cat : Sound
//{
//    public override void Noise(Animal a)
//    {
//        a.Sound = "Meow!";
//    }
//}
//class Rooster : Sound
//{
//    public override void Noise(Animal a)
//    {
//        a.Sound = "Cluckaroo!";
//    }
//}

//Level 27: INTERFACES

//CHALLENGE 1: ROBOTIC INTERFACE

//Answer this question: Do you feel this is an improvement over using an abstract base class? Why or why not?
//
// In this situation, I think this is better. For starters, there's less code to do the same thing. No need
// to have those abstracts and overrides everywhere. But at a more substantial level, inheritance is a pretty
// strong relationship, and these commands do not really need to have that strong of a relationship to each
// other. The only thing that really binds them together is that they do the same type of thing. So I think
// it is better for that reason.

////init
//Robot robot = new Robot();

////run program
//while (true)
//{
//    //get user inputs up to limit
//    for (int i = 0; i < robot.Commands.Length; i++)
//    {
//        Console.Write("Command: ");
//        string? input = Console.ReadLine().ToLower();

//        //set robot command
//        IRobotCommand RCommand = input switch
//        {
//            "on" => new OnCommand(),
//            "off" => new OffCommand(),
//            "north" => new NorthCommand(),
//            "south" => new SouthCommand(),
//            "west" => new WestCommand(),
//            "east" => new EastCommand(),
//            _ => new OffCommand()
//        };

//        //add command to array
//        robot.Commands[i] = RCommand;
//    }
//    Console.WriteLine();

//    //display results
//    robot.Run();
//}

//interface IRobotCommand
//{
//    void Run(Robot robot);
//}
//class OnCommand : IRobotCommand
//{
//    public void Run(Robot robot) => robot.IsPowered = true;
//}
//class OffCommand : IRobotCommand
//{
//    public void Run(Robot robot) => robot.IsPowered = false;
//}
//class NorthCommand : IRobotCommand
//{
//    public void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
//}
//class SouthCommand : IRobotCommand
//{
//    public void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
//}
//class WestCommand : IRobotCommand
//{
//    public void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
//}
//class EastCommand : IRobotCommand
//{
//    public void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
//}

//class Robot
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public bool IsPowered { get; set; }
//    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

//    public void Run()
//    {
//        foreach (IRobotCommand? command in Commands)
//        {
//            command?.Run(this);
//            Console.WriteLine($"[{X} {Y} {IsPowered}]");
//        }
//    }
//}

//LEVEL 28: STRUCTS

//Difference between structs and classes:
//Structs are value types and classes are reference types.

//CHALLENGE 1: ROOM COORDINATES

////init
//Coordinate[] Coords = new Coordinate[4];
//Coords[0] = new Coordinate(10, 10);
//Coords[1] = new Coordinate(9, 9);
//Coords[2] = new Coordinate(8, 8);
//Coords[3] = new Coordinate(6, 5);

//Coordinate arbCoord = new Coordinate(7, 7);

//foreach(Coordinate coord in Coords)
//{
//    Console.WriteLine(Coordinate.Adjacent(coord, arbCoord));
//}

//struct Coordinate
//{
//    public int Row { get; }
//    public int Col { get; }
//    public Coordinate(int row, int col)
//    {
//        Row = row;
//        Col = col;
//    }
//    public static bool Adjacent(Coordinate coord1, Coordinate coord2)
//    {
//        if (Math.Abs(coord1.Row - coord2.Row) == 1 || Math.Abs(coord1.Col - coord2.Col) == 1) return true; 

//        return false;
//    }
//}

//LEVEL 29: RECORDS

//When to use records:
//Records give you a concise way to make a type with several properties and a constructor to initialize them.
//They also give you a nice string representation, value semantics, deconstruction,
//and the ability to use "with" statements. They are also considered alternatives to tuples.

//CHALLENGE 1: WAR PREPARATIONS

//Sword first = new Sword(Materials.Iron, GemStones.None, 10, 2);
//Sword second = first with { gem = GemStones.Emerald, length = 20, xGuardWidth = 5 };
//Sword third = first with { mat = Materials.Binarium, gem = GemStones.Sapphire};
//Console.WriteLine($"{first}\n{second}\n{third}");
//record Sword(Materials mat, GemStones gem, int length, int xGuardWidth);
//enum Materials { Wood, Bronze, Iron, Steel, Binarium }
//enum GemStones { Emerald, Amber, Sapphire, Diamond, Bitstone, None }

//LEVEL 30: GENERICS

//CHALLENGE 1: COLOURED ITEMS

////create generic coloureditem
//ColouredItem<Sword> sword = new ColouredItem<Sword>(new Sword(), ConsoleColor.Blue);
//ColouredItem<Bow> bow = new ColouredItem<Bow>(new Bow(), ConsoleColor.Red);
//ColouredItem<Axe> axe = new ColouredItem<Axe>(new Axe(), ConsoleColor.Green);
//sword.Display();
//bow.Display();
//axe.Display();

//class ColouredItem<T>
//{
//    public T Item { get; }
//    public ConsoleColor Colour { get; }
//    public ColouredItem(T item, ConsoleColor colour)
//    {
//        Item = item;
//        Colour = colour;
//    }

//    public void Display()
//    {
//        Console.ForegroundColor = Colour;
//        Console.WriteLine(Item);
//        Console.ForegroundColor = ConsoleColor.Black;
//    }
//}

//class Sword { }
//class Bow { }
//class Axe { }

#endregion

#region PART 2 - BOSS BATTLE: THE FOUNTAIN OF OBJECTS

//LEVEL 31: THE FOUNTAIN OF OBJECTS

//BOSS BATTLE:

//ask user for grid size
Console.Write("1 - Small\n2 - Medium\n3 - Large\nSelect map size: ");
string input = Console.ReadLine();

int gridSize = input switch
{
    "1" => 4,
    "2" => 6,
    "3" => 8,
    _ => 4
};

//create grid
Coordinates coords = new Coordinates(gridSize);

//create player
Player player = new Player();

//run until win/loss condition
while (true)
{
    Console.Clear();
    ConsoleHelper.Display("-----------------------------------------", ConsoleColor.Cyan, 0);
    for (int i = 0; i < coords.Grid.GetLength(0); i++)
    {
        for (int j = 0; j < coords.Grid.GetLength(1); j++)
        {
            if (player.X == j && player.Y == i)
                ConsoleHelper.Display(coords.Grid[player.Y, player.X].GetType().Name, ConsoleColor.White, 1);
            else
                coords.Grid[i, j].Show();
        }
        Console.WriteLine();
    }
    ConsoleHelper.Display("-----------------------------------------", ConsoleColor.Cyan, 0);

    //set location of player to grid room
    player.WhichRoom = coords.Grid[player.Y, player.X];

    //check if player is in a trap room
    if (player.WhichRoom.GetType().Name == "Pit")
        player.isAlive = false;

    //check adjacent tiles for any traps
    AdjacentCheck(player, coords, new Pit());
    AdjacentCheck(player, coords, new Maelstrom());
    AdjacentCheck(player, coords, new Amarok());

    //game won or loss
    if (player.isAlive && player.X == 0 && player.Y == 0 && Fountain.ActiveFountain)
    {
        ConsoleHelper.Display("YOU WIN!", ConsoleColor.DarkBlue, 0);
        break;
    }
    else if (!player.isAlive && player.WhichRoom.GetType().Name == "Pit")
    {
        ConsoleHelper.Display("YOU DIE FROM FALLING INTO A PIT!", ConsoleColor.DarkRed, 0);
        break;
    }

    //run player move
    player.Run();                                           
}

void AdjacentCheck(Player p, Coordinates c, Room r)
{
    int tempX = p.X, tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[++tempY, tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[++tempY, ++tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[tempY, ++tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[--tempY, ++tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[--tempY, tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[--tempY, --tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
         if (c.Grid[tempY, --tempX].GetType().Name == r.ToString()) SenseDisplay(r);
    tempX = p.X; tempY = p.Y;
    if (IsOnBoard(tempY, tempX))
        if (c.Grid[++tempY, --tempX].GetType().Name == r.ToString()) SenseDisplay(r);
}
bool IsOnBoard(int row, int column)
{
    if (row < 0) return false;
    if (row >= gridSize) return false;
    if (column < 0) return false;
    if (column >= gridSize) return false;
    return true;
}
void SenseDisplay(Room r)
{
    ConsoleHelper.Display("SENSE: " + r.Sense().ToString(), ConsoleColor.DarkRed, 0);
}

static class ConsoleHelper
{
    //i is arbitrarily used to determine what is being printed (0 - name of room, 1 - anything else)
    public static void Display(string write, ConsoleColor colour, int i)
    {
        Console.ForegroundColor = colour;
        if (i == 0)
            Console.WriteLine(write);
        else if (i == 1)
            Console.Write($"{write} ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

//Player class
class Player
{
    public int X { get; set; } = 0;         //column
    public int Y { get; set; } = 0;         //row
    public Room? WhichRoom { get; set; }    //which room is the player in?
    public bool isAlive { get; set; } = true;

    public void Run()
    {
        Console.WriteLine($"You are in the room {WhichRoom} at ({X}, {Y})");
        Console.WriteLine($"Is Fountain active? {Fountain.ActiveFountain}");
        Console.WriteLine("Am I Alive? " + isAlive);
        ConsoleHelper.Display(WhichRoom?.Sense().ToString(), ConsoleColor.DarkGreen, 0);
        Console.Write("What do you want to do? ");
        string input = Console.ReadLine().ToLower();

        //set move command
        IActionCommand Command = input switch
        {
            "north" => new MoveNorth(),
            "west" => new MoveWest(),
            "south" => new MoveSouth(),
            "east" => new MoveEast(),
            "enable" => new EnableFountain(),
            _ => new MoveNorth()
        };

        Command.Move(this);
    }
}

//Coordinates class
class Coordinates
{
    public Room[,] Grid { get; }
    public Coordinates(int gridSize)
    {
        //create array of given size
        Grid = new Room[gridSize, gridSize];

        //populate array with coordinates of room
        for (int i = 0; i < Grid.GetLength(0); i++)
            for (int j = 0; j < Grid.GetLength(1); j++)
                Grid[i, j] = new Empty();

        CreateRoom(new Entrance(), 0, 0);
        CreateRoom(new Fountain(), 0, 2);
        CreateRoom(new Pit(), 1, 1);
        CreateRoom(new Maelstrom(), 2, 2);
        CreateRoom(new Amarok(), 1, 2);
    }

    public void CreateRoom(Room r, int row, int column)
    {
        Grid[row, column] = r;
    }
}

//Interface and classes for movement
interface IActionCommand
{
    public void Move(Player player);
}
class MoveNorth : IActionCommand
{
    public void Move(Player player)
    {
        int y = player.Y;
        if (--y >= 0) player.Y--;
    }
}
class MoveWest : IActionCommand
{
    public void Move(Player player)
    {
        int x = player.X;
        if (--x >= 0) player.X--;
    }
}
class MoveSouth : IActionCommand
{
    public void Move(Player player)
    {
        int y = player.Y;
        if (++y < 4) player.Y++;
    }
}
class MoveEast : IActionCommand
{
    public void Move(Player player)
    {
        int x = player.X;
        if (++x < 4) player.X++;
    }
}
class EnableFountain : IActionCommand 
{
    public void Move(Player player)
    {
        if (player.X == 2 && player.Y == 0)
            Fountain.ActiveFountain = true;
    }
}

//Room classes
abstract class Room
{
    public abstract string Sense();
    public abstract void Show();
}
class Entrance : Room
{
    public override string Sense() => Fountain.ActiveFountain ? "The Found of Objects " +
        "has been reactivated, and you have escaped with your life!" : "You see light" +
        " coming from the cavern entrance.";
    public override void Show() => ConsoleHelper.Display("Entrance", ConsoleColor.Green, 1);
}
class Fountain : Room
{
    public static bool ActiveFountain { get; set; } = false;
    public override string Sense() => ActiveFountain ? "You hear the rushing waters" +
        " from the Fountain of Objects. It has been reactivated!" : "You hear water " +
        "dripping in this room. The Fountain of Objects is in this room!";
    public override void Show() => ConsoleHelper.Display("Fountain", ConsoleColor.Magenta, 1);
}
class Empty : Room
{
    public override string Sense() => "See no evil; Speak no evil.";
    public override void Show() => ConsoleHelper.Display("Empty", ConsoleColor.Yellow, 1);
}
class Pit : Room
{
    public override string Sense() => "You feel a draft. There is a pit in a nearby room.";
    public override void Show() => ConsoleHelper.Display("Pit", ConsoleColor.DarkGray, 1);
}
class Maelstrom : Room
{
    public override string Sense() => "You hear the growling and groaning of a maelstorm nearby.";
    public override void Show() => ConsoleHelper.Display("Pit", ConsoleColor.DarkCyan, 1);
}
class Amarok : Room
{
    public override string Sense() => "You smell the rotten stench of an amarok in a nearby room.";
    public override void Show() => ConsoleHelper.Display("Pit", ConsoleColor.DarkMagenta, 1);
}

#endregion