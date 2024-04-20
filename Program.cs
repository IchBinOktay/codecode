//0

//using System.Threading.Channels;

//Console.WriteLine("bir ededi daxil edin");
//int number =  Convert.ToInt32(Console.ReadLine());

//if (number == 0)
//{
//    Console.WriteLine("daxil edilen eded ne musbetdir ne de menfi");
//}
//else if(number>0)
//{
//    Console.WriteLine("daxil edilen eded musbetdir");
//}
//else
//{
//    Console.WriteLine("daxil edilen eded menfidir");
//}

//-----------------------------------------------------------------------
//1

//int sum = 0;
//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//sum += number1;
//Console.WriteLine("2-ci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//sum += number2;
//Console.WriteLine("3-cu ededi daxil et");
//int number3 = Convert.ToInt32(Console.ReadLine());
//sum += number3;
//Console.WriteLine("4-cu ededi daxil et");
//int number4 = Convert.ToInt32(Console.ReadLine());
//sum += number4;
//Console.WriteLine("5-ci ededi daxil et");
//int number5 = Convert.ToInt32(Console.ReadLine());
//sum += number5;
//Console.WriteLine(sum);

//------------------------------------------------------------------------
//2

//Console.WriteLine("ededi daxil et");
//int number  = Convert.ToInt32(Console.ReadLine());
//int power=number*number;
//Console.WriteLine(power);

//------------------------------------------------------------------------
//3

//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3-cu ededi daxil et");
//int number3 = Convert.ToInt32(Console.ReadLine());

//int max = 0;

//if (number1 >= number2 && number1 >= number3)
//{
//    max = number1;
//}
//else if (number2 >= number1 && number2 >= number3)
//{
//    max = number2;
//}
//else
//{
//    max = number3;
//}
//Console.WriteLine("en boyuk eded");
//Console.WriteLine(max);

//-------------------------------------------------------------------------
//4

//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int power=number1 * number1 * number1;
//Console.WriteLine("1-ci ededin kubu: " +  power);
//if (power > number2 )
//{
//    Console.WriteLine("1 ci ededin kubu 2-ciden daha boyukdur");
//}
//else
//{
//    Console.WriteLine("1 ci ededin kubu 2-ciden daha boyuk deyil");
//}

//--------------------------------------------------------------------------
//5

//Console.WriteLine(" ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());

//if (number1 % 3== 0 && number1 % 5==0)
//{
//    Console.WriteLine("eded hem 3-e hem de 5-e bolunur");
//}
//else
//{
//    Console.WriteLine("eded hem 3-e hem de 5-e bolunmur");
//}

//---------------------------------------------------------------------------
//6


//Console.WriteLine("kartin meblegi:");
//int kart = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("alinan mehsulun qiymeti:");
//int mehsul = Convert.ToInt32(Console.ReadLine());
//if (kart >= mehsul)
//{
//    Console.WriteLine("kartdaki mebleg mehsulu almaga yeterlidir");
//}
//else
//{
//    Console.WriteLine("kartdaki mebleg mehsulu almaga yeterli deyil");
//}

//---------------------------------------------------------------------------
//7


//int sum = 0;
//int availablePoint = 0;

//Console.WriteLine("fennin ballari:");

//for (int i = 0; i < 5; i++)
//{
//    int num = int.Parse(Console.ReadLine());


//    switch (num)
//    {
//        case int n when (n >= 1 && n <= 100):
//            availablePoint++;
//            sum += num;
//            break;
//        default:
//            Console.WriteLine($"{num}  (1-100) arasinda daxil edin.");
//            break;
//    }
//}
//double average = (double)sum / availablePoint;
//Console.WriteLine($"telebenin imtahandan aldigi qiymetlerin ortalamasi: {average}");
//if (average >= 65)
//{
//    Console.WriteLine("telebe imtahandan kecdi");
//}
//else
//{
//    Console.WriteLine("telebe imtahandan kesildi");
//}

//-------------------------------------------------------------------------------------------------------
//8

//Console.WriteLine("1-ci ededi daxil edin:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2-ci ededi daxil edin:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2)
//{  Console.WriteLine("1-ci eded daha boyukdur");
//}
//else if (num2 > num1)
//{   Console.WriteLine("2-ci eded daha boyukdur");
//}
//else
//{   Console.WriteLine("her ikisi eyni");
//}

//-----------------------------------------------------
//9
//Console.WriteLine("Enter the temperature:");
//int tempratur = Convert.ToInt32(Console.ReadLine());
//if (tempratur > 0)
//{
//    Console.WriteLine("derece suyun donma tempraturundan boyukdur");
//}
//else 
//{
//    Console.WriteLine("derece suyun donma tempraturundan kicikdir");
//}


//------------------------------------------------------------------------
//1

//Console.WriteLine("Ededler");
//int n = 50;
//for (int i = 1; i <= n; i++) 
//{
//    Console.WriteLine(i);
//}

//-------------------------------------------------
//2


//Console.WriteLine("Ededler");
//int n = 40;
//int count = 0;
//for (int i = 1; i <= n; i++) 
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine("40-a qeder 3-e bolunen ededlerin sayi:" + count);

//---------------------------------------------------------------------------
//3


//Console.WriteLine("Hem 3 hem de 7 bolunen ededler");
//int n = 100;
//for (int i= 1;i<=n;i++)
//{
//    if (i%3==0 && i%7==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//--------------------------------------------------------------------------------
//4

//int number = 0, count = 0;
//Console.Write("ededi daxil edin :");
//number = Convert.ToInt32(Console.ReadLine());
//while (number > 0)
//{
//    number = number / 10;
//    count++;
//}
//Console.WriteLine("ededin reqemlerinin sayi : " + count);
//Console.ReadLine();

//-----------------------------------------------------------------------------------------
//5

//Console.WriteLine("Bir eded daxil edin:");
//int num = Convert.ToInt32(Console.ReadLine());

//string terseded = "";

//// Ədədin hər bir rəqəmini alaraq, tərsinə yazın
//while (num > 0)
//{
//    int reqem = num % 10;
//    terseded += reqem.ToString();
//    num /= 10;
//}

//Console.WriteLine("edədin tersi: " + terseded);

//------------------------------------------------------------------------------
//6

//int f = 1;
//int number;
//Console.Write("Bir eded daxil edin: ");
//number = int.Parse(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    f *= i;
//}
//Console.Write(number + " ededinin faktorialı: " + f);

//----------------------------------------------------------------------------------------------
//7


//int n = Convert.ToInt32(Console.ReadLine());
//int squareroot = Convert.ToInt32(Math.Sqrt(n));
//bool isprimitive = true;
//for (int i = 2; i <= squareroot; i++)
//{
//    if (n % i == 0)
//    {
//        isprimitive = false;
//        break;
//    }
//}
//if (isprimitive)
//{
//    Console.WriteLine("Sade");
//}
//else
//{
//    Console.WriteLine("Murekkeb");
//}

//----------------------------------------------------------------------------------------------
//8


//int n, sum = 0, m;
//Console.Write("Eded daxil edin: ");
//n = int.Parse(Console.ReadLine());
//while (n > 0)
//{
//    m = n % 10;
//    sum = sum + m;
//    n = n / 10;
//}
//Console.Write("Sum = " + sum);

//----------------------------------------------------------------------------------------------
//9


//Console.WriteLine("ededi daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());

//int max = 0;
//while (num > 0)
//{
//    int reqem = num % 10;
//    if (reqem > max)
//    {
//        max = reqem;
//    }
//    num /= 10;
//}
//Console.WriteLine("ededin en boyuk reqemi: " + max);

//----------------------------------------------------------------------------------------------
//10

//Console.WriteLine("70-den kiçik cüt ededler");
//for (int i = 70; i > 0; i--)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//----------------------------------------------------------------------------------------------
//11

//Console.WriteLine("Ayi daxil edin");
//int ay = Convert.ToInt32(Console.ReadLine());
//switch (ay)
//{
//    case 1:
//        Console.WriteLine("Qis");
//        break;
//    case 2:
//        Console.WriteLine("Yaz");
//        break;
//    case 3:
//        Console.WriteLine("Yay");
//        break;
//    case 4:
//        Console.WriteLine("Payiz");
//        break;
//}

//----------------------------------------------------------------------------------------------
//12
//int setir = 5;
//int sutun = 5;
//for (int i = 1; i <= sutun; i++)
//{
//    for (int n = 1; n <= setir; n++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//------------------------------------------------------------------------------
//13

//int sira = 9;

//for (int i = 0; i <= sira; i++)
//{
//    for (int num = 1; num <= i; num++)
//    {
//        Console.Write("*");
//    }
//        Console.WriteLine();
//}

//---------------------------------------------------------------
//14

//int sira = 9;
//for (int i = sira; i >= 1; i--)
//{
//    for (int num = 1; num <= i; num++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//---------------------------------------------------------------
