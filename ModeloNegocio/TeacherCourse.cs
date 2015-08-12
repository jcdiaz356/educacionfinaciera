using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class TeacherCourse
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _userTeacheId;

        public int UserTeacheId
        {
            get { return _userTeacheId; }
            set { _userTeacheId = value; }
        }
        string _course;

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        DateTime _created_at;

        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        DateTime _update_at;

        public DateTime Update_at
        {
            get { return _update_at; }
            set { _update_at = value; }
        }
    }
}
