using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Person
    {
        public Person(int id,
                      string name,
                      string surname,
                      string phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
        }
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append(Id.ToString())
        //        .Append(": ")
        //        .Append(Name + " ")
        //        .Append(Surname + " ")
        //        .Append(Phone);
        //    return sb.ToString();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
