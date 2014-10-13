using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class Class
    {
        private string ID;
        private List<Teacher> teachers = new List<Teacher>();

        public Class(string id)
        {
            this.ID = id;
        }

        public Class(string id, List<Teacher> teachers)
            : this(id)
        {
            this.teachers = teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            return "Class " + this.ID + ":\n" + string.Join("\n", this.teachers.Select(t => t.ToString()).ToArray()) + "\n";
        }
    }
}
