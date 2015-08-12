using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Content
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private String _contentNote;

        public String ContentNote
        {
            get { return _contentNote; }
            set { _contentNote = value; }
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
        private int _idType;

        public int IdType
        {
            get { return _idType; }
            set { _idType = value; }
        }

        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }


        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }


        public virtual User User
        {
            get;
            set;
        }
        public virtual TypeContent typeContent
        {
            get;
            set;
        }

        public  List<Comment> Comment { get; set; }

        public  List<Comment> Galeria { get; set; }

    }
}
