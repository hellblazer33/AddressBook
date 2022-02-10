public static class FileDemo
{

 public static void ReadAllLines()
        {
            String path = @"/Users/pankajkumar/Desktop/Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

  public static void ReadFromStreamReader()
        {
            String path = @"/Users/pankajkumar/Desktop/Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";    //String.Empty
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

 public static void WriteUsingStreamWriter()
        {
            String path = @"/Users/pankajkumar/Desktop/Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome1");
                //sr.Close();
                Console.WriteLine(File.ReadAllText(path));
		Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            sr.WriteLine(People.Add(person));
            }
        }
}