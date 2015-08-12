using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Comment
    {

        private AccesoDatos.Comment objCommentAD;
        private ModeloNegocio.Comment objContentMN;

        public Comment()
        {
            objCommentAD = new AccesoDatos.Comment();
            objContentMN = new ModeloNegocio.Comment();
        }

        public int insertComment(ModeloNegocio.Comment ObjComment)
        {

            return objCommentAD.insertComment(ObjComment);
        }

    }
}
