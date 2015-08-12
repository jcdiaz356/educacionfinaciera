using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Comment
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _commentContent;

        public string CommentContent
        {
            get { return _commentContent; }
            set { _commentContent = value; }
        }
        private string _emailAuthor;

        public string EmailAuthor
        {
            get { return _emailAuthor; }
            set { _emailAuthor = value; }
        }
        private int _idCotent;

        public int IdCotent
        {
            get { return _idCotent; }
            set { _idCotent = value; }
        }

        private int _id_content_galeria;


        public int Id_content_galeria
        {
            get { return _id_content_galeria; }
            set { _id_content_galeria = value; }
        }

        private DateTime _created_at;

        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        private DateTime _updated_at;

        public DateTime Updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }

        private string _ipAuthor;

        public string IpAuthor
        {
            get { return _ipAuthor; }
            set { _ipAuthor = value; }
        }


    }
}
