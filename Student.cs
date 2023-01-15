using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LAB3
{
    internal class Student
    {
        private string name;
        private string _id;
        private int _hight;
        private int _birthYear;
        private double _grade;
        private string _branch;
        private int _age;

        public string Name
        {
            get { return this.Name; }
        }
        public string ID
        {
            get { return this._id; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }
        public int Hight
        {
            get { return this._hight; }
        }
        public double Grade
        {
            get { return this._grade; }
        }
        public string Branch
        {
            get { return this._branch; }
        }

        //constructor
        public Student(string name, string id, int birthYear, int hight, double grade, string branch) 
        {
            this.name = name;
            this._id = ID;
            this._birthYear = birthYear;
            this._hight = Hight;
            this._grade = Grade;
            this._branch = Branch;
        }

        
    }
} 

