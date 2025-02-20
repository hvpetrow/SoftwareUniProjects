﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get;}
        public int Age { get ;}
        public string Id { get ; set ; }
        public string Birthdate { get ; set; }
    }
}
