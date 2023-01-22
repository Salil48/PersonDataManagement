using PersonDataManagement;
using System.Collections.Generic;

namespace PraticingLambdaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            List<Person> person = new List<Person>();
            AddRecord(person);
            //RetrievingTopTwoRecord_ForAgeIs_LessthanSixty(person);
            //RetrievingthoRecords_ForAgeIs_LessthanEighteenandgreaterthanThirteen(person);
            //RetrievingAverageAge(person);
            CheckSpecficName(person);

        }
        private static void AddRecord(List<Person> ListPersonInCity)
        {
            ListPersonInCity.Add(new Person("1223225", "John", "12 Main street", 15));
            ListPersonInCity.Add(new Person("4324444", "Sam", "14 Main street", 25));
            ListPersonInCity.Add(new Person("3243434", "Elan", "12 Main street", 35));
            ListPersonInCity.Add(new Person("3423666", "John", "14 Main street", 45));
            ListPersonInCity.Add(new Person("6574754", "Sue", "12 Main street", 55));
            ListPersonInCity.Add(new Person("4688865", "Rita", "12 Main street", 65));
            ListPersonInCity.Add(new Person("3433245", "Mith", "17 Main street", 75));
            ListPersonInCity.Add(new Person("3244233", "Mac", "19 Main street", 85));
            ListPersonInCity.Add(new Person("3264645", "Ramesh", "16 Main street", 95));
            ListPersonInCity.Add(new Person("7869977", "Geetha", "10 Main street", 14));

        }
        private static void RetrievingTopTwoRecord_ForAgeIs_LessthanSixty(List<Person> ListPersonInCity)
        {
            foreach (Person person in ListPersonInCity.FindAll(e => e.Age < 60).Take(2))
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
        }
        private static void RetrievingthoRecords_ForAgeIs_LessthanEighteenandgreaterthanThirteen(List<Person> ListPersonInCity)
        {
            foreach (Person person in ListPersonInCity.FindAll(e => e.Age < 18 && e.Age > 13))
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
        }
        private static void RetrievingAverageAge(List<Person> ListPersonInCity)
        {
            double avgAge = ListPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average age is " + avgAge);
        }
        private static void CheckSpecficName(List<Person> ListPersonInCity)
        {
            bool val = ListPersonInCity.Exists(e => e.Name == "Sam");
            if (val)
            {
                Console.WriteLine("The Name exists");
            }
            else
            {
                Console.WriteLine("The Name does not exists");
            }
        }


    }
}
