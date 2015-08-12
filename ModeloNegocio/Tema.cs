using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Tema
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        string _grade;

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        string _tema;
        public string Name
        {
            get { return _tema; }
            set { _tema = value; }
        }
    }
}
