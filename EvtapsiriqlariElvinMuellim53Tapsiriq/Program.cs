using EvtapsiriqlariElvinMuellim53Tapsiriq.ClassMisallari;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Misal 1
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
            #endregion

            #region Misal 2
            //int i = 0;
            //int sum = 0;
            //Console.Write("sonuncu ededi daxil edin:");
            //int n=Convert.ToInt32(Console.ReadLine());
            //basla:
            //if (i <= n)
            //{
            //    sum += i;
            //    i++;
            //    goto basla;
            //}
            //Console.WriteLine($"cemi {sum}");
            #endregion

            #region Misal 3
            // int sum = 0;
            // Random rd = new Random();
            // Console.Write("massivin olcusunu daxil edin:");
            // int i = 0;
            // int[] arrInt = new int[Convert.ToInt32(Console.ReadLine())];
            //while (i < arrInt.Length) {
            //     arrInt[i] = rd.Next(1, 100);
            //     Console.Write(arrInt[i] + ",");
            //     if (arrInt[i] < 49)
            //     {
            //         sum += arrInt[i];
            //     }
            //     i++;
            // }
            // Console.WriteLine();
            // Console.WriteLine("**************************");
            // Console.WriteLine($"Sum={sum}");
            #endregion

            #region Misal 4

            //Console.Write("Arrayin uzunluqunu daxil edin:");
            //int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            //int i = 0;
            //int sum = 0;
            //Random rd = new Random();
            //do
            //{
            //    arr[i] = rd.Next(1, 20);
            //    sum += arr[i];

            //    Console.Write(arr[i] + ",");
            //    i++;
            //} while (i < arr.Length);
            //Console.WriteLine();
            //Console.WriteLine($"sum={sum}");
            #endregion

            #region Misal 5
            //int i = 4; int j = 5;
            //i++;
            //++j;
            //Console.WriteLine($"i++ {i}");
            //Console.WriteLine($"++j {j}");
            //i--;
            //--j;
            //Console.WriteLine($"i-- {i}");
            //Console.WriteLine($"--j {j}");
            #endregion

            #region Misal 7

            //int count = "Nizami Gencevinin eserlerinin en mehsuru leyli ve mecnundur?".GetnumberOfLetters('e');
            //Console.WriteLine($"daxil edilmis sozde secilmis herfin sayi {count}");
            #endregion

            #region Misal 8
            //int count = "AzerBaycan ResPuBlIKASi VeTendaSi".GetUpperLettersCount();
            //Console.WriteLine($"daxil edilmis sozun daxilinde boyuk heriflerin sayi:{count}");
            #endregion

            #region Misal 9

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr;
            //CreateArray(n, out arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Misal 10

            //string rs = "Altun".GetReversString();
            //Console.WriteLine(rs);
            #endregion

            #region Misal 13
            //Misal11 is1= new Misal11();
            //is1.Name = "abbas";
            //is1.Surname = "hesenov";
            //is1.Age = 18;
            //Misal11 is2 = new Misal11("etibar", "hesnov", 34);
            //Console.WriteLine(is2.ToString());
            //Console.WriteLine(is1.ToString());
            //Console.WriteLine(is2.MaasHesabati(240));
            //Misal12 is3 = new Misal12("Altun", "Seyyafzde", 27, 670);
            //Console.WriteLine(is3.MasHesabati(240,5));
            //Console.WriteLine(is3.ToString());
            #endregion

            #region Misal 14
            //// 4x4 arrayin doldurulmasi
            //Console.WriteLine("Kvadrat arrayin ölçüsünü daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rd = new Random();
            //int[,] arr = new int[n, n];
            //int rows = 0;
            //int colum = 0;
            //int sum = 0;

            //while (rows < n)
            //{
            //    if (colum < n)
            //    {
            //        arr[rows, colum] = rd.Next(1, 10);
            //        if (rows == colum ) 
            //        {
            //            sum += arr[rows, colum];
            //        }
            //        else if ((rows + colum) == (arr.GetLength(0) - 1))
            //        {
            //            sum += arr[rows, colum];
            //        }
            //        colum++;
            //    }
            //    else
            //    {
            //        rows++;
            //        colum = 0;
            //    }

            //}
            //// Arrayi göstər
            //Console.WriteLine("Təsadüfi ədədlərlə doldurulmuş kvadrat array:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"SUM={sum}");



            #endregion

            #region Misal 15
            //Console.Write("birinci ədədi daxil edin:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("ikinci ədədi daxil edin:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bir sinvol daxil edin");
            //char sinvol=Convert.ToChar(Console.ReadLine());
            //switch (sinvol)
            //{
            //    case '+':
            //        Console.WriteLine(a+b);
            //        break;
            //    case '-':
            //        Console.WriteLine(a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a / b);
            //        break;
            //    case '%':
            //        Console.WriteLine(a % b);
            //        break;
            //    default:
            //        Console.WriteLine("düzgün sinvol daxil etməmisiniz");
            //        break;
            //}
            #endregion
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
    }
}
