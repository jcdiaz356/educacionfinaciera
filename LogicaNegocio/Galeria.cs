using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Galeria
    {

        public List<ModeloNegocio.Galeria> getAllGaleria(int registroAMostrar, int registroAEmpezar, int Type_id)
        {
            AccesoDatos.Galeria galeria = new AccesoDatos.Galeria();

            return galeria.getAllGaleria(registroAMostrar, registroAEmpezar, Type_id);
        }

    }
}
