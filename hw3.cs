using System;

namespace homework3
{
    class Program
    {
        static int elementnumbercheck(string elementcheck)//H elementlerin önündeki ve arkasındaki sayıların tespiti
        {
            string Hcountpart1partoffront, Hcountpart2partofback;
            int Hindex = 0, Hcountcheck = 0, Hcountcheck1 = 0, Hcountcheck2 = 0;
            Hindex = elementcheck.IndexOf("H");//H index                                               
            Hcountpart1partoffront = elementcheck.Substring(0, Hindex);//önünü hafızaya aldık                
            int[] Hcountpart1partoffronttranslatetoint = new int[Hcountpart1partoffront.Length];//ön kısım için int array açtık
            for (int i = 0; i < Hcountpart1partoffront.Length; i++)//
            {
                for (int k = 0; k < 10; k++)
                {
                    if (Convert.ToInt64(Hcountpart1partoffront[i]) == k + 48)//her charı tek tek sayıya çevirdik
                    {
                        Hcountpart1partoffronttranslatetoint[i] = k;
                        break;
                    }
                }
            }            
            int test = 0;
            for (int i = Hcountpart1partoffront.Length; 0 < i; i--)//ön kısımı sayıya çevirdik
            {
                if (i == Hcountpart1partoffront.Length)
                    Hcountcheck1 = Hcountcheck1 + Hcountpart1partoffronttranslatetoint[i - 1];
                else
                    Hcountcheck1 = Hcountcheck1 + (Hcountpart1partoffronttranslatetoint[i - 1] * Convert.ToInt32(Math.Pow(10, test)));
                test++;
            }           
            Hcountpart2partofback = elementcheck.Substring(Hindex + 1);//arkasını hafızaya aldık                
            int[] Hcountpart2partofbacktranslatetoint = new int[Hcountpart2partofback.Length];//arka kısım için int array açtık
            for (int i = 0; i < Hcountpart2partofback.Length; i++)//
            {
                for (int k = 0; k < 10; k++)
                {
                    if (Convert.ToInt64(Hcountpart2partofback[i]) == k + 48)//her charı tek tek sayıya çevirdik
                    {
                        Hcountpart2partofbacktranslatetoint[i] = k;
                    }
                }
            }
            test = 0;
            for (int i = Hcountpart2partofback.Length; 0 < i; i--)//arka kısımı sayıya çevirdik
            {
                if (i == Hcountpart2partofback.Length)
                    Hcountcheck2 = Hcountcheck2 + Hcountpart2partofbacktranslatetoint[i - 1];

                else
                    Hcountcheck2 = Hcountcheck2 + (Hcountpart2partofbacktranslatetoint[i - 1] * Convert.ToInt32(Math.Pow(10, test)));
                test++;
            }
            if (!(Hcountcheck1 == 0 && Hcountcheck2 == 0))
            {
                if (Hcountcheck1 == 0)
                    Hcountcheck1 = 1;
                if (Hcountcheck2 == 0)
                    Hcountcheck2 = 1;
            }
            Hcountcheck = Hcountcheck1 * Hcountcheck2;
            if (Hcountcheck == 0)
                Hcountcheck = 1;            
            return Hcountcheck;
        }
        static int elementnumbercheck2(string elementcheck)//C elementlerin önündeki ve arkasındaki sayıların tespiti
        {
            string Ccountpart1partoffront, Ccountpart2partofback;
            int Cindex = 0, Ccountcheck = 0, Ccountcheck1 = 0, Ccountcheck2 = 0;
            {
                Cindex = elementcheck.IndexOf("C");//C index                                                  
                Ccountpart1partoffront = elementcheck.Substring(0, Cindex);//önünü hafızaya aldık                
                int[] Ccountpart1partoffronttranslatetoint = new int[Ccountpart1partoffront.Length];//ön kısım için int array açtık
                for (int i = 0; i < Ccountpart1partoffront.Length; i++)//
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (Convert.ToInt64(Ccountpart1partoffront[i]) == k + 48)//her charı tek tek sayıya çevirdik
                        {
                            Ccountpart1partoffronttranslatetoint[i] = k;
                        }
                    }
                }
                int test = 0;
                for (int i = Ccountpart1partoffront.Length; 0 < i; i--)//ön kısımı sayıya çevirdik
                {
                    if (i == Ccountpart1partoffront.Length)
                        Ccountcheck1 = Ccountcheck1 + Ccountpart1partoffronttranslatetoint[i - 1];

                    else
                        Ccountcheck1 = Ccountcheck1 + (Ccountpart1partoffronttranslatetoint[i - 1] * Convert.ToInt32(Math.Pow(10, test)));
                    test++;
                }                
                Ccountpart2partofback = elementcheck.Substring(Cindex + 1);//arkasını hafızaya aldık                
                int[] Ccountpart2partofbacktranslatetoint = new int[Ccountpart2partofback.Length];//arka kısım için int array açtık
                for (int i = 0; i < Ccountpart2partofback.Length; i++)//
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (Convert.ToInt64(Ccountpart2partofback[i]) == k + 48)//her charı tek tek sayıya çevirdik
                        {
                            Ccountpart2partofbacktranslatetoint[i] = k;
                        }
                    }
                }
                test = 0;
                for (int i = Ccountpart2partofback.Length; 0 < i; i--)//arka kısımı sayıya çevirdik
                {
                    if (i == Ccountpart2partofback.Length)
                        Ccountcheck2 = Ccountcheck2 + Ccountpart2partofbacktranslatetoint[i - 1];
                    else
                        Ccountcheck2 = Ccountcheck2 + (Ccountpart2partofbacktranslatetoint[i - 1] * Convert.ToInt32(Math.Pow(10, test)));
                    test++;
                }
                if (!(Ccountcheck1 == 0 && Ccountcheck2 == 0))
                {
                    if (Ccountcheck1 == 0)
                        Ccountcheck1 = 1;
                    if (Ccountcheck2 == 0)
                        Ccountcheck2 = 1;
                }
                Ccountcheck = Ccountcheck1 * Ccountcheck2;
                if (Ccountcheck == 0)
                    Ccountcheck = 1;                
            }
            return Ccountcheck;
        }
        static void Main(string[] args)
        {
            int equal = 0, leftHcountt = 0, leftCcountt = 0, rightHcountt = 0, rightCcountt = 0,equalcount=0;
            Console.WriteLine("PLEASE ENTER THE FORMULE WHICH YOU WANT TO CHECK");
            string formule = Convert.ToString(Console.ReadLine());
            Console.Clear();
            formule = formule.ToUpper();
            bool error1 = false;
            bool processflag = true;
            for (int i = 0; i < formule.Length; i++)
            {
                if(formule[i]=='=')
                { equalcount++; }
                if (formule[i] != '+' && formule[i] != '=' && formule[i] != 'C' && formule[i] != 'H' && !(formule[i] < 58 && formule[i] > 47))//Invalid character check
                {error1 = true;}
            }
            if (error1)//ERROR
            {Console.Write("Invalid character");}
            else if (!error1)//PROCESS
            {
                for (int i = 0; i < formule.Length; i++)// = check
                {
                    equal = formule.IndexOf("=");//equal found                    
                }
                if (equal == -1||equalcount>1)
                { processflag = false; }
                if (processflag)
                {
                    string leftpart = formule.Substring(0, equal);//seperate formule to part1
                    string rightpart = formule.Substring(equal + 1);//seperate formule to part2
                    string[] leftpartelements = leftpart.Split("+");//seperate part1 elements
                    string[] rightpartelements = rightpart.Split("+");//seperate part2 elements
                    string[] leftHcount = new string[2];
                    string[] leftCcount = new string[2];
                    for (int i = 0; i < leftpartelements.Length; i++)
                    {
                        bool flag1 = false;
                        bool flag2 = false;
                        if (leftpartelements[i].Contains("H"))
                        {flag1 = true;}
                        if (flag1)
                        { leftHcountt = leftHcountt + elementnumbercheck(leftpartelements[i]); }
                        if (leftpartelements[i].Contains("C"))
                        { flag2 = true; }
                        if (flag2)
                        { leftCcountt = leftCcountt + elementnumbercheck2(leftpartelements[i]); }
                    }
                    Console.Write("LH :" + leftHcountt);
                    Console.WriteLine(" LC :" + leftCcountt);
                    for (int i = 0; i < rightpartelements.Length; i++)
                    {
                        bool flag1 = false;
                        bool flag2 = false;
                        if (rightpartelements[i].Contains("H"))
                        {flag1 = true;}
                        if (flag1)
                            rightHcountt = rightHcountt + elementnumbercheck(rightpartelements[i]);
                        if (rightpartelements[i].Contains("C"))
                        {
                            flag2 = true;
                        }
                        if (flag2)
                            rightCcountt = rightCcountt + elementnumbercheck2(rightpartelements[i]);
                    }
                    Console.Write("RH :" + rightHcountt);
                    Console.WriteLine(" RC :" + rightCcountt);
                    if (leftHcountt == rightHcountt && leftCcountt == rightCcountt)
                    {
                        Console.WriteLine("Formule : " + formule);
                        Console.Write("Tantamount");
                    }
                    else
                    {
                        Console.WriteLine("Formule : " + formule);
                        Console.Write("Not tantamount");
                    }
                }
                else
                {
                    Console.Write("Wrong Formule");
                }
            }
            Console.ReadLine();
        }
    }
}
