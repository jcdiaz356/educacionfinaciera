using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Content
    {

        private AccesoDatos.Content objADContent;
        private ModeloNegocio.Content objMNContent;
        public Content()
        {
            objADContent = new AccesoDatos.Content();
            objMNContent = new ModeloNegocio.Content();
        }

        /// <summary>
        /// getContentId Metodo obtiene un Contenido según su ID
        /// </summary>
        /// <param name="id">Id del Contenido </param>
        /// <returns>Retorna un List ModeloNegocio.Content</returns>
        public ModeloNegocio.Content getContentId(int id)
        {
            objMNContent= objADContent.getContentId(id);

            return objMNContent;
        }

        public List<ModeloNegocio.Content> getAllContent(int registroAMostrar, int registroAEmpezar, int idType)
        {

          
            return objADContent.getAllContent( registroAMostrar,  registroAEmpezar,  idType);
        }


        public int countRowsContent(int idType)
        {
            AccesoDatos.Content content = new AccesoDatos.Content();
            return content.countRowsContent(idType);

        }
    }
}
