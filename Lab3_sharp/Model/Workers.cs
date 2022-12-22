using System;

namespace Lab3_sharp.Model
{
    public class Workers
    {
        public string Worker_name { get; set; }
        public string Worker_family { get; set; }
        public int Worker_ID { get; set; }
        public double Worker_salary { get; set; }
        public Workers(string name, string surname, int id, double sal)
        {
            Worker_name = name;
            Worker_family = surname;
            Worker_ID = id;
            Worker_salary = sal;
        }
        public Workers SetWorker_name(string name)
        {
            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name must contain at least 1 letter");

            Worker_name = name;
            return this;
        }
        public Workers SetWorker_family (string family)
        {
            if (string.IsNullOrEmpty(family) ||
               string.IsNullOrWhiteSpace(family))
                throw new ArgumentException("Name must contain at least 1 letter");

            Worker_family = family;
            return this;
        }
        public Workers SetWorker_ID(int id)
        {
            Worker_ID = id;
            return this;
        }
        public Workers SetWorker_salary(int salary)
        {
            Worker_salary = salary;
            return this;
        }
        public override string ToString()
        {

            return $"ID : {Worker_ID} Ім'я : {Worker_name} Призвіще : {Worker_family} З/п : {Worker_salary}";

        }
    }
}
