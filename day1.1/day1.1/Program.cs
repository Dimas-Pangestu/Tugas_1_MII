using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;


namespace day1
{

    class Ipk
    {
        private float num1;
        private float num2;
        private float num3;
        private float num4;

        private float avgipk()
        {
            return (num1 + num2 + num3 + num4) / 4;
        }

        public void input()
        {
            Console.Write("IPK Semester 1: ");
            num1 = Single.Parse(Console.ReadLine());

            Console.Write("IPK Semester 2: ");
            num2 = Single.Parse(Console.ReadLine());

            Console.Write("IPK Semester 3: ");
            num3 = Single.Parse(Console.ReadLine());

            Console.Write("IPK Semester 4: ");
            num4 = Single.Parse(Console.ReadLine());
        }
        public void shows()
        {

            Console.WriteLine("IPK Semester avg: {0}", avgipk());
        }
    }

    public class User
    {
        public string Hello;
        public string Name;
        private string Job;
        public string Enter;


        public void GetUserInfo(string job)
        {
            Job = job;
            Console.WriteLine("{0}", Hello);
            Console.WriteLine("{0}", Name);
            Console.WriteLine("Job {0}", Job);

        }
    }
    public class Details : User
    {
        public int Age;

        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
            
        }
    }

    




    public class Program

        {

            public static void RandomWait()
            {
                System.Threading.Thread.Sleep(1000);
            }
            public static void RandomWait2()
            {
                System.Threading.Thread.Sleep(200);
            }
            public static void Main()

            {


            string username, password;


            Console.Clear();
            Console.WriteLine("=====================WELCOME=====================");
            Console.WriteLine(" ");

            Console.Write("Masukan User Name : ");
            username = Console.ReadLine();
            Console.Write("Masukan password: ");
            password = Console.ReadLine();

           
                if (username != "dimas")
                {
                    Console.Clear();
                    Console.WriteLine("Username is Incorrect");
                    Console.WriteLine("Access Denied");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (password != "12345")
                {
                    Console.Clear();
                    Console.WriteLine("Password is Incorrect");
                    Console.WriteLine("Access Denied");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" User Name berhasil ditemukan ! ");


                    Console.Write("Press any key to Continue... ");
                    Console.ReadLine();
                    Console.Clear();
                }
            Console.ReadKey();
            




            Console.Clear();

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
            Console.Clear();
            Loadshow();
            Console.Clear();

            


            Details d = new Details();
            d.Hello = "WELCOME";
            d.Name = "Dimas Pangestu";
            d.Age = 32;
           
            d.GetUserInfo("Application Developper Jr");
            d.GetAge();
         
            d.Enter = "Please Enter to Continue ...";

           
            bool showMenu = true;
                while (showMenu)
                {
                    showMenu = Menuutama();
                }
            }

            
            private static bool Menuutama()
            {
         
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Input Data Mahasiswa");
                Console.WriteLine("2) Hitung Data IPK");
                Console.WriteLine("3) List Harga Buku");
                Console.WriteLine("4) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        
                        Menu1();
                        return true;
                    case "2":
                        Menu2();
                        return true;
                    case "3":
                        Menu3();
                        return true;
                    case "4":
                    Kereta();
                    return false;
                    default:
                        return true;
                }

            }

            public static void Menu1()
            {

                Console.Clear();

                // Display 
                Console.WriteLine("Input Nama\r");
                Console.WriteLine("------------------------\n");

                Console.Write("Nama ");
                string nama = Console.ReadLine();

                Console.Write("Jenis Kelamin ");
                string gender = Console.ReadLine();

                Console.Write("Jurusan ");
                string jurusan = Console.ReadLine();

                Console.Write("Alamat ");
                string alamat = Console.ReadLine();

                
                Console.Clear();
                Console.WriteLine("Nama: {0}.", nama);
                Console.WriteLine("Umur: {0}.", gender);
                Console.WriteLine("Jurusan: {0}.", jurusan);
                Console.WriteLine("Alamat: {0}.", alamat);

                Console.Write("Press any key to close the console app...");
                Console.ReadKey();
            }


            public static void Menu2()
            {
                try
                {
                    Console.Clear();
                    //// Display 
                    Console.WriteLine("Hitung IPK\r");
                    Console.WriteLine("------------------------\n");

                    Ipk ip = new Ipk();

                    ip.input();
                    ip.shows();
                    Console.Write("Press any key to close the  console app...");
                    Console.ReadLine();

                }

                catch (FormatException)
                {
                    Console.WriteLine("Input anda bukan angka.");
                }

                Console.ReadKey();

            }

            public static void Menu3()
            {
            Console.Clear();
                char done = 'n';
            int order = 0;
                Console.WriteLine("Tolong pilih Buku yang anda ingin beli");
                do
                {
                    List<String> LKS = new List<String>();//List
                    LKS.Add("1.Buku Sejarah       30000");
                    LKS.Add("2.Buku Kimia         20000");
                    LKS.Add("3.Buku Biologi       40000");
                    LKS.Add("4.Buku Agama         50000");
                    foreach (String item in LKS)//Looping
                    {
                        Console.WriteLine(item);
                    }
                order = Convert.ToInt32(Console.ReadLine());
                if (order < 1 || order > 4)
                {
                    Console.Clear();
                    Console.WriteLine("!! Peringatan : Nomor yang anda masukan tidak ada dalam list\n");
                    Console.ReadKey();
                }
             
                switch (order)
                    {

                        case 1:

                            Console.Clear();
                            Console.WriteLine("Total Cost: Rp 30.000,00");
                            break;
                        case 2:

                            Console.Clear();
                            Console.WriteLine("Total Cost: Rp 20.000,00");
                            break;
                        case 3:

                            Console.Clear();
                            Console.WriteLine("Total Cost: Rp 40.000,00");
                            break;
                        case 4:

                            Console.Clear();
                            Console.WriteLine("Total Cost: Rp 50.000,00");
                            break;

                        default:
                            Console.WriteLine("Not on the menu!");
                            break;
                    }

                    Console.Write("Order Complete?(y/n)");
                    done = Char.Parse(Console.ReadLine());
                    Console.Clear();

                } while (done == 'n' || done == 'N');
                Console.WriteLine("Please take your bill");


            }

        public static void Loadshow()
        {
            var counter = 0;
            for (int i = 0; i < 50; i++)
            {
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(50);
            }
        }

        public static void Kereta()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o", System.Drawing.Color.LightGray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", System.Drawing.Color.LightGray);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", System.Drawing.Color.LightGray);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);

                    Thread.Sleep(50);
                }
            }
        }

    }

    internal class Hobby : Details
    {
    }
}

    
