﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Student
    {
        // Properties
        private string name;
        private int age;
        private string major;

        // Constructor
        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        // Method to introduce the student
        public void Introduce()
        {
            Console.WriteLine($"Hello, I'm {name}. I am {age} years old, and I am majoring in {major}.");
        }
    }

}
