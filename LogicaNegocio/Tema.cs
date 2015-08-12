using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class Tema
    {
        DataTable Temas;
        public List<ModeloNegocio.Tema> getAllTemaForGrade(string grade)
        {
            List<ModeloNegocio.Tema> lista = new List<ModeloNegocio.Tema>();
            AccesoDatos.Tema temaAD = new AccesoDatos.Tema();
            Temas = temaAD.getAllTemsForGrade(grade);
            foreach (DataRow fila in Temas.Rows)
            {
                ModeloNegocio.Tema temaMN = new ModeloNegocio.Tema();
                temaMN.Id = int.Parse(fila["id"].ToString());
                temaMN.Name = fila["tema"].ToString();
                lista.Add(temaMN);
            }
            return lista;

        }

        public ModeloNegocio.Tema getTemaId(int tema_id)
        {
            AccesoDatos.Tema tema = new AccesoDatos.Tema();

            return tema.getTemaId(tema_id);
        }
    }
}
