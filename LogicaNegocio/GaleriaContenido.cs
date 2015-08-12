using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class GaleriaContenido
    {
        public List<ModeloNegocio.GaleriaContenido> getAllGaleriaContenidoId(int idGaleria)
        {
             AccesoDatos.GaleriaContenido galeriaContenido = new AccesoDatos.GaleriaContenido();
             return galeriaContenido.getAllGaleriaContenidoId(idGaleria);
        }
    }
}
