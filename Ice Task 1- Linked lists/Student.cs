using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_1__Linked_lists
{
    public class Student
    {
        private string StudentNumber, StudentName, StudentCourse;

        public Student(string studentNumber, string studentName, string studentCourse)
        {
            StudentNumber = studentNumber;
            StudentName = studentName;
            StudentCourse = studentCourse;
        }

        //public object this[int index]
        //{
        //    get 
        //    {
        //        if (index == 0)
        //            return this.StudentNumber;
        //        else if (index == 1)
        //            return this.StudentName;
        //        else if (index == 2)
        //            return this.StudentCourse;
        //        return null;
        //    }
        //    set
        //    {
        //        if (index == 0)
        //            this.StudentNumber = (string)value;
        //        else if (index == 1)
        //            this.StudentName = (string)value;
        //        else if(index == 2)
        //            this.StudentCourse = (string)value;
        //    }
        //}

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("studentnumber"))
                    return this.StudentNumber;
                else if (attrName.ToLower().Equals("studentname"))
                    return this.StudentName;
                else if (attrName.ToLower().Equals("studentcourse"))
                    return this.StudentCourse;

                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("studentnumber"))
                    this.StudentNumber = (string)value;
                else if (attrName.ToLower().Equals("studentname"))
                    this.StudentName = (string)value;
                else if (attrName.ToLower().Equals("studentcourse"))
                    this.StudentCourse = (string)value;
            }
        }
    }
}
