using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class User
    {

        public List<ModeloNegocio.Asesor> getAllUsers()
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.User users = new AccesoDatos.User();

            return users.getAllUsers();

        }


        public ModeloNegocio.Asesor loginUsuario(String email, String password)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.User user = new AccesoDatos.User();
            ModeloNegocio.Asesor userLogin = new ModeloNegocio.Asesor();
            userLogin=user.loginUsuario(email, password);

            

            return userLogin;

        }


        ///Temporalmente  encriptaPassword
        //public String Encrypt(string pass)
        //{
        //    AccesoDatos.User user = new AccesoDatos.User();
        //    //string hashed = BCrypt.Net.BCrypt.HashPassword(pass, BCrypt.Net.BCrypt.GenerateSalt());


        //    //return user.Encrypt(pass); 
        //}



    }
}
