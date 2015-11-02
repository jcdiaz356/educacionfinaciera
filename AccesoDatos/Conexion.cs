using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Conexion
    {
        // Private servidor, database_access, database_excell, usuario, password As String
        // Private Conn As New OleDbConnection
        //private string connString = "Server=192.185.11.131;Port=3306;Database=otakus_bcp;Uid=otaku_admin;Password=Kqwf33#7";
        //private string connString = "Server=localhost;Port=3306;Database=bcp_db;Uid=root;Password=irmagaguevara";

        private string connString = "Data Source=192.185.6.25;Initial Catalog=otakus_bcp_edu;Persist Security Info=True;User ID=otaku_bcp;Password=aYjp92#9";
       
         //private string connString = "Data Source=PERSONAL-JAIME\\SQLEXPRESS2012;Initial Catalog=otakus_bcp_edu; Integrated Security=False;User ID=sa;Password=irmaguevara;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        
        //private string connString = "Server=ttaudit.com;Port=3306;Database=ttaudit_bd;Uid=ttaudit_admin;Password=franbrsj09";
        private SqlConnection Conn = new SqlConnection();
       

        public Conexion()
        {
            
        }
        public SqlConnection abrirConexion()
        {
            //string ConnString;
            try
            {
                Conn.ConnectionString = connString;
            
                Conn.Open();
                return Conn;
            }
            catch (Exception ex)
            {
                //MsgBox("Erro al obtener datos conexion: \n" & ex.Message)
                //MessageBox.Show("Usuario no exite intentelo nuevamente");
                //
                //return Conn;
                throw new Exception("Error al conetarse con la base de datos.", ex);
            }
        }


        
    }
}
