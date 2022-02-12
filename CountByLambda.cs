using System;
namespace LambdaExpressionDemo
{
    public static class LambdaExpression
    {

        // UC1
        public static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456877", "SAM", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456878", "Elan", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456879", "Smith", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456880", "SAM", "Dayton", "OH"));
            listPersonInCity.Add(new Person("203456881", "Sue", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456882", "Winston", "Newyork", "NY"));
            listPersonInCity.Add(new Person("203456883", "Mac", "Baltimore", "NY"));
            listPersonInCity.Add(new Person("203456884", "SAM", "Baltimore","NY"));
            // Console.WriteLine(listPersonInCity.ToString());
            // listPersonInCity.ForEach(x => Console.WriteLine("{0}\t",x.Name.ToString()));

        }


      

       

     


      
        public static void AllPersonsAverageAge(List<Person> listPersonInCity)
        {
            double count = listPersonInCity.Count(e => e.State == "NY");
            Console.WriteLine("The count of all the person's in NY state is :" + count);
        }

      
       



    }
}

