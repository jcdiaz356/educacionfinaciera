using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class GaleriaContenido
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _galeria_id;

        public int Galeria_id
        {
            get { return _galeria_id; }
            set { _galeria_id = value; }
        }

        private string _name_galeria;

        public string Name_galeria
        {
            get { return _name_galeria; }
            set { _name_galeria = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _source;

        public string Source
        {
            get { return _source; }
            set { _source = value; }
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


       // public virtual List<Comment> Comentario { get; set; }
    }
}
