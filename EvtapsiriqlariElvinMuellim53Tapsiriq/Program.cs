using EvtapsiriqlariElvinMuellim53Tapsiriq.ClassMisallari;
using System.Collections;
using System.Collections.Generic;


namespace EvtapsiriqlariElvinMuellim53Tapsiriq
{
    internal class Program
    {
        //Console.InputEncoding = System.Text.Encoding.UTF8;
        // Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Misal 1        
        //static void Main()
        //{
        //    int i = 1;
        //    Console.Write("son addimi daxil edin:");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //basla:
        //    if (i <= n)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //        goto basla;
        //    }
        //}
        #endregion

        #region Misal 2
        //static void Main()
        //{
        //    int i = 0;
        //    int sum = 0;
        //    Console.Write("sonuncu ededi daxil edin:");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //basla:
        //    if (i <= n)
        //    {
        //        sum += i;
        //        i++;
        //        goto basla;
        //    }
        //    Console.WriteLine($"cemi {sum}");
        //}
        #endregion

        #region Misal 3
        //static void Main()
        //{
        //    int sum = 0;
        //    Random rd = new Random();
        //    Console.Write("massivin olcusunu daxil edin:");
        //    int i = 0;
        //    int[] arrInt = new int[Convert.ToInt32(Console.ReadLine())];
        //    while (i < arrInt.Length)
        //    {
        //        arrInt[i] = rd.Next(1, 100);
        //        Console.Write(arrInt[i] + ",");
        //        if (arrInt[i] < 49)
        //        {
        //            sum += arrInt[i];
        //        }
        //        i++;
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("**************************");
        //    Console.WriteLine($"Sum={sum}");
        //}
        #endregion

        #region Misal 4
        //static void Main()
        //{
        //    Console.Write("Arrayin uzunluqunu daxil edin:");
        //    int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
        //    int i = 0;
        //    int sum = 0;
        //    Random rd = new Random();
        //    do
        //    {
        //        arr[i] = rd.Next(1, 20);
        //        sum += arr[i];

        //        Console.Write(arr[i] + ",");
        //        i++;
        //    } while (i < arr.Length);
        //    Console.WriteLine();
        //    Console.WriteLine($"sum={sum}");

        //}
        #endregion

        #region Misal 5
        //static void Main()
        //{
        //    int i = 4; int j = 5;
        //    i++;
        //    ++j;
        //    Console.WriteLine($"i++ {i}");
        //    Console.WriteLine($"++j {j}");
        //    i--;
        //    --j;
        //    Console.WriteLine($"i-- {i}");
        //    Console.WriteLine($"--j {j}");
        //}
        #endregion

        #region Misal 7
        //static void Main()
        //{
        //    int count = "Nizami Gencevinin eserlerinin en mehsuru leyli ve mecnundur?".GetnumberOfLetters('e');
        //    Console.WriteLine($"daxil edilmis sozde secilmis herfin sayi {count}");
        //}
        #endregion

        #region Misal 8
        //static void Main()
        //{
        //    int count = "AzerBaycan ResPuBlIKASi VeTendaSi".GetUpperLettersCount();
        //    Console.WriteLine($"daxil edilmis sozun daxilinde boyuk heriflerin sayi:{count}");
        //}
        #endregion

        #region Misal 9
        //static void Main()
        //{
        //    //int n = Convert.ToInt32(Console.ReadLine());
        //    //int[] arr;
        //    //CreateArray(n, out arr);
        //    //foreach (int i in arr)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //}
        #endregion

        #region Misal 10
        //static void Main()
        //{
        //    //string rs = "Altun".GetReversString();
        ////    //Console.WriteLine(rs);
        //}
        #endregion

        #region Misal 11,12,13
        //static void Main()
        //{
        //    //Misal11 is1= new Misal11();
        //    //is1.Name = "abbas";
        //    //is1.Surname = "hesenov";
        //    //is1.Age = 18;
        //    //Misal11 is2 = new Misal11("etibar", "hesnov", 34);
        //    //Console.WriteLine(is2.ToString());
        //    //Console.WriteLine(is1.ToString());
        //    //Console.WriteLine(is2.MaasHesabati(240));
        //    //Misal12 is3 = new Misal12("Altun", "Seyyafzde", 27, 670);
        //    //Console.WriteLine(is3.MasHesabati(240,5));
        //    //Console.WriteLine(is3.ToString());
        //}        
        #endregion

        #region Misal 14
        // static void Main()
        //{
        //    //// 4x4 arrayin doldurulmasi
        //    //Console.WriteLine("Kvadrat arrayin ölçüsünü daxil edin:");
        //    //int n = Convert.ToInt32(Console.ReadLine());
        //    //Random rd = new Random();
        //    //int[,] arr = new int[n, n];
        //    //int rows = 0;
        //    //int colum = 0;
        //    //int sum = 0;
        //    //while (rows < n)
        //    //{
        //    //    if (colum < n)
        //    //    {
        //    //        arr[rows, colum] = rd.Next(1, 10);
        //    //        if (rows == colum ) 
        //    //        {
        //    //            sum += arr[rows, colum];
        //    //        }
        //    //        else if ((rows + colum) == (arr.GetLength(0) - 1))
        //    //        {
        //    //            sum += arr[rows, colum];
        //    //        }
        //    //        colum++;
        //    //    }
        //    //    else
        //    //    {
        //    //        rows++;
        //    //        colum = 0;
        //    //    }
        //    //}       
        //    //Console.WriteLine("kvadrat arrayin tesviri");
        //    //for (int i = 0; i < n; i++)
        //    //{
        //    //    for (int j = 0; j < n; j++)
        //    //    {
        //    //        Console.Write(arr[i, j] + "\t");
        //    //    }
        //    //    Console.WriteLine();
        //    //}
        //    //Console.WriteLine($"SUM={sum}");
        //  }
        #endregion

        #region Misal 15
        //   static void Main()
        // {
        //    //Console.Write("birinci ədədi daxil edin:");
        //    //int a = Convert.ToInt32(Console.ReadLine());
        //    //Console.WriteLine();
        //    //Console.Write("ikinci ədədi daxil edin:");
        //    //int b = Convert.ToInt32(Console.ReadLine());
        //    //Console.Write("bir sinvol daxil edin");
        //    //char sinvol=Convert.ToChar(Console.ReadLine());
        //    //switch (sinvol)
        //    //{
        //    //    case '+':
        //    //        Console.WriteLine(a+b);
        //    //        break;
        //    //    case '-':
        //    //        Console.WriteLine(a - b);
        //    //        break;
        //    //    case '*':
        //    //        Console.WriteLine(a * b);
        //    //        break;
        //    //    case '/':
        //    //        Console.WriteLine(a / b);
        //    //        break;
        //    //    case '%':
        //    //        Console.WriteLine(a % b);
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("düzgün sinvol daxil etməmisiniz");
        //    //        break;
        //    //}
        //   }
        #endregion

        #region Misal 17
        //static void Main()
        //{
        //    ParamsArray<int>(23, 4435, 6556, 87, 223, 343435, 232, 2323, 22424, 11212);
        //}  
        #endregion

        #region Misal 18
        //static void Main()
        //{
        //    var result = "Altun".GetASCII();
        //    foreach (var item in result) {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #region Misal 21
        //static void Main()
        //{
        //    var result = "Altun".GetControlLatter('z');
        //    Console.WriteLine(result);
        //} 
        #endregion

        #region Misal 22
        //static void Main()
        //{
        //    GetConvertNumberToString(567);
        //} 
        #endregion

        #region Misal 23
        //static void Main()
        //{
        //    var result = "Altun".WordlatterDelete('l');
        //    Console.WriteLine(result);
        //} 
        #endregion

        #region Misal 25
        //static void Main()
        //{

        //    Dictionary<int,int> dcNumber= new Dictionary<int,int>();
        //    Random rd = new Random();
        //    int uzunluq = rd.Next(10, 50);

        //    for (int i = 1; i <= uzunluq; i++)
        //    {
        //        dcNumber.Add(i, rd.Next(1, 999));
        //    }
        //    foreach (var item in dcNumber)
        //    {
        //        Console.WriteLine($"<Key:{item.Key}> <Value:{item.Value}>");
        //    }
        //} 
        #endregion

        #region Misal 26

        //static void Main()
        //{
        //    var result = "Abbas Sehet Dahi Sairiizdir Bizim Ucun EzizdIR".GetBigLatter();
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
        //} 
        #endregion

        #region Misal 28
        //static void Main()
        //{
        //    List<int> numbers = new List<int>();
        //    Random rd = new Random();
        //    for (int i = 0; i < rd.Next(20, 50); i++)
        //    {
        //        numbers.Add(rd.Next(1,999));
        //    }
        //    foreach (var item in numbers)
        //    {
        //        Console.Write(item +",");
        //    }
        //    var result = numbers.Sum() / numbers.Count();
        //    Console.WriteLine();
        //    Console.WriteLine(result);
        //} 
        #endregion

        #region Misal 29
        //static void Main()
        //{
        //    Box a = new Box();
        //    Box b = new Box();
        //    b.a = 12; b.b = 24;
        //    var result = a - b;
        //    Console.WriteLine($"{result.a} {result.b}");
        //    var result1 = a < b;
        //    Console.WriteLine(result1);
        //}
        #endregion

        #region Misal 30
        static void Main()
        {
            List<int> intList = new List<int>();
            Random rd = new Random();
            // listin tesadufu sayda tesadufu  reqemlerle doldurulmasi
            for (int i = 0; i < rd.Next(10, 30); i++)
            {
                intList.Add(rd.Next(1, 999));
            }
            //listin adi qaydada numayisi
            ListShow(intList);
            GetSortList(intList);
            Console.WriteLine();
            ListShow(intList);
            Console.WriteLine();
            GetReversList(intList);
            ListShow(intList);
        }
        #endregion       

        #region Metodlar
        static void GetConvertNumberToString(int _number)
        {
            char[] chars = _number.ToString().ToCharArray();
            Console.WriteLine(chars[0]);
        }
        private static void ListShow(List<int> intList)
        {
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }
        }
        static void GetSortList(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {                   
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        static void GetReversList(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        static void ParamsArray<T>(params T[] _array)
        {
            if (_array == null || _array.Length == 0)
            {
                Console.WriteLine("Bos array");
            }
            else
            {
                Console.WriteLine($"arrayin uzunluqu:{_array.Length}");
                Console.WriteLine($"arrayin Max qiymeti:{_array.Max()}");
                Console.WriteLine($"arrayin Min qiymeti:{_array.Min()}");
                foreach (T item in _array)
                {
                    Console.Write(item + ",");
                }
                Console.WriteLine();
            }
        }



        static void CreateArray(int n, out int[] arr)
        {
            arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(1, 30);
            }

        }
        #endregion
    }
}
