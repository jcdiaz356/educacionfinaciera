using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Galeria
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private int _type_id;

        public int Type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
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

        public virtual List<GaleriaContenido> GaleriaContenido { get; set; }
    }
}
