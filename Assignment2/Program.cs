using System.Text;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1
            bool isPassed = int.TryParse(Console.ReadLine(), out int result);
            if (isPassed)
            {
                for (int i = 1; i <= result; i++) Console.Write($"{i} ");
            }
            #endregion
            Console.WriteLine();
            #region 2
            bool isPassed1 = int.TryParse(Console.ReadLine(), out int result1);
            if (isPassed)
            {
                for (int i = 1; i <= 12; i++) Console.Write($"{i*result} ");
            }
            #endregion
            Console.WriteLine();
            #region 3
            bool isPassed2 = int.TryParse(Console.ReadLine(), out int result3);
            if (isPassed2)
            {
                for(int i = 2; i < result3; i += 2) Console.Write($"{i} ");
            }
            #endregion
            Console.WriteLine();
            #region 4
            double.TryParse(Console.ReadLine(), out double pow1);
            double.TryParse(Console.ReadLine(), out double pow2);
            Console.WriteLine(Math.Pow(pow1,pow2));
            #endregion
            Console.WriteLine();
            
            #region 5
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int.TryParse(Console.ReadLine(), out int Mark);
                sum += Mark;
            }
            Console.WriteLine($"Total marks is {sum}");
            Console.WriteLine($"Average is {sum/5}");
            Console.WriteLine($"Precentage is {(sum / 5)}");
            #endregion
            Console.WriteLine();
            #region 6
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
            #endregion
            Console.WriteLine();
            #region 7
            int.TryParse(Console.ReadLine(), out int reverse);
            int reversed = 0;
            while (reverse != 0)
            {
                reversed = (reverse % 10)+(reversed*10);
                reverse = (int)(reverse / 10);
            }
            Console.WriteLine(reversed);
            #endregion
            Console.WriteLine();

            #region 8
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            for (int i = number1;i<=number2;i++)
            {
                bool isPrime = true;
                for (int j = 1; j <= (int)Math.Sqrt(i); j++)
                {
                    if (((i%j == 0)&&j!=1)||i == 1)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime) { Console.Write($"{i} "); }
            }
            #endregion
            Console.WriteLine();
            #region 9
            int.TryParse(Console.ReadLine(), out int dec);
            double bin = 0;
            double ctn = 0;
            while (dec != 0)
            {
                if (dec % 2 == 1)
                {
                    bin += (Math.Pow(10,ctn));
                }
                dec /= 2;
                Console.WriteLine(bin);
                Console.WriteLine(dec);
                ctn++;
            }
            Console.WriteLine(bin);
            #endregion
            Console.WriteLine();
            #region 10
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            double.TryParse(Console.ReadLine(), out double x1);
            double.TryParse(Console.ReadLine(), out double y1);
            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            double.TryParse(Console.ReadLine(), out double x2);
            double.TryParse(Console.ReadLine(), out double y2);

            Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            double.TryParse(Console.ReadLine(), out double x3);
            double.TryParse(Console.ReadLine(), out double y3);

            double p1 = (x2 - x1) / (y2 - y1);
            double p2 = (x3 - x1) / (y3 - y1);
            if (p1 == p2) Console.WriteLine("there are in straight line");
            else Console.WriteLine("No");
            #endregion
            Console.WriteLine();
            #region 11
            int.TryParse(Console.ReadLine(), out int n);
            int[,] identityMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) identityMatrix[i, j] = 1;
                    else identityMatrix[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{identityMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region 12
            int[] sum1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(sum1.Sum());
            #endregion
            Console.WriteLine();
            #region 13
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 4, 5, 6 };

            int[] resultt = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultt[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                resultt[array1.Length + i] = array2[i];
            }
            Console.WriteLine("Result Array: [{0}]", string.Join(", ", result));
            #endregion
            Console.WriteLine();
            #region 13
            int[] array12 = { 1, 2, 3, 4, 5 };
            int[] array23 = { 6, 7, 8, 9, 10 };
            int[] array34 = new int[array1.Length+array2.Length];
            for (int i = 0; i < array1.Length; i++) array34[i] = array1[i];
            for (int i = array2.Length; i < array1.Length*2; i++) array34[i] = array2[i-array2.Length];
            for (int i = 0;i < array34.Length; i++) Console.Write(array34[i]+" ");
            #endregion
            Console.WriteLine();
            #region 14
            int[] arr = new int[10];
            arr = [1, 3, 4, 4, 3, 2, 5, 7, 4, 2];
            int[] freq = new int[arr.Max()+1];
            for (int i = 0; i < arr.Length; i++) freq[arr[i]]++;
            for (int i = 0;i < freq.Length; i++) Console.WriteLine($"{i} has \"{freq[i]}\"");
            #endregion
            Console.WriteLine();
            #region 15
            int[] mm = [1, 2, 3, 4, 5, 6, 7, 8];
            Console.WriteLine(mm.Max());
            Console.WriteLine(mm.Min());
            #endregion
            Console.WriteLine();
            #region 16
            int[] secarr = [1, 2, 3, 4, 5, 6, 7];
            int ma = 0 , ma2 = 0 ;
            for (int i = 0; i < secarr.Length; i++)
            {
                if (secarr[i] > ma)
                {
                    ma2 = ma;
                    ma = secarr[i];
                }
            }
            Console.WriteLine(ma2);
            #endregion
            Console.WriteLine();
            #region 17
            int[] lon = [7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3];
            int mx = 0;
            for (int i = 1; i < lon.Length; i++)
            {
                for (int j = i+1;j< lon.Length; j++)
                {
                    if (lon[j] == lon[i] && mx < j - i) mx = j - i;
                }
            }
            Console.WriteLine(mx);
            #endregion
            Console.WriteLine();
            #region 18
            string sen = Console.ReadLine();
            string[] str = sen.Split();
            for (int i = str.Length - 1; i > -1; i--)
            {
                Console.Write($"{str[i]} ");
            }
            #endregion
            Console.WriteLine();
            #region 19
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array11 = new int[rows, cols];
            int[,] array22 = new int[rows, cols];

            Console.WriteLine("Enter the elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter value for element [{i}, {j}]: ");
                    array11[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array22[i, j] = array11[i, j];
                }
            }

            // Print the second array
            Console.WriteLine("The elements of the second array are:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array22[i, j] + "\t");
                }
                Console.WriteLine();

            }
            #endregion
            Console.WriteLine();
            #region 20
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Print the array in reverse order
            Console.WriteLine("Array in reverse order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            #endregion
        }
    }
}

