using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        public String _name;
        public String _id;
        public String _branch;
        public int _age;
        public int _brith;
        public int _hight;
        public int _grade;

        //constructure 
        public Student(String name, String id, int brith, int age, int hight, int grade, String branch) {
            this._name = name;
            this._brith = brith;
            this._hight = hight;
            this._id = id;
            this._branch = branch;
            this._grade = grade;
            this._age = age;
        }

        public int myAge() {
            int age = 2023 - _brith;
            return age;
        }
    }
}
