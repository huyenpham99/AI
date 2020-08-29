using System;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace AI.GTS1
{
    
    public class GTS1
    {
        int n,v;
        int Cost;
        int [] Tour = new int[5]  { 1,  2, 5, 8, 3};
        int[,] mtTP = 
        { 
            {1, 2}, 
            {3, 4}, 
            {5, 6},
            {4,2},
            {1,7}
        };
        int [] flag = new int[5]  { 2,  8, 5, 1, 3};
        
        public void Input()
        {
            Console.OutputEncoding = Encoding.Unicode;

            string filePath = @"file.txt";
            
            string[] lines;
            string str;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Line {0}: {1}",i , lines[i]);
                }
                Console.WriteLine();

                str = System.IO.File.ReadAllText(filePath);
                Console.WriteLine("String: {0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public void Output()
        {
            string fileLPath = @"file1.txt";
            string fileSPath = @"file2.txt";
 
            string[] lines = new string[2];
            lines[0] = "Write data to file using C#.";
            lines[1] = ":)";

            System.IO.File.WriteAllLines(fileLPath, lines);

            string str;
            str = "Write data to file using C#.\r\n:D";
 
            System.IO.File.WriteAllText(fileSPath, str);
        }

        public void GTS1a()
        {
            int dem = 0;
            Tour[0] = v;
            flag[v] = 1;
            int tmp = v;
            while (dem != n - 1)
            {
                int tmpCost = 100;
                int co;
                for (int i = 1; i <= n; i++)
                {
                    if (tmpCost > mtTP[v, i] && flag[i] == 0 && mtTP[v, i] != -1)
                    {
                        tmpCost = mtTP[v, i];
                        co = i;
                    }
                }
                dem++;
                    co =Tour[dem] ;
                    Cost += tmpCost;
                    flag[v] = 1;
                    v = co;

                }
            Cost += mtTP[v, tmp];

            }

            public static void Main(string[] args)
        {
            Console.WriteLine("======= TRI TUE NHAN TAO ======\n");
            Console.WriteLine("                               \n");
            GTS1 gts1 = new GTS1();
            gts1.Input();
            gts1.GTS1a();
            gts1.Output();
            return;
        }
    }
}