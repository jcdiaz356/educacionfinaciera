using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class UserTeacher
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
        int _userAsesorId;

        public int UserAsesorId
        {
            get { return _userAsesorId; }
            set { _userAsesorId = value; }
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
