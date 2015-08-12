using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_OperationsJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Response.ContentType = "application/json;";
            Page.Response.Charset = "utf-8";
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);


            if (Request.Params["tipo"] == "deleteAsesor")
            {
                int iduser = Convert.ToInt32(Request.Params["iduser"]);
                LogicaNegocio.Asesor Asesor = new LogicaNegocio.Asesor();
                LogicaNegocio.UserSchool userSchool = new LogicaNegocio.UserSchool();
                LogicaNegocio.UserTeacher userTeacher = new LogicaNegocio.UserTeacher();
                //Response.Write("{success:1}");
                if (Asesor.deleteAsesor(iduser))
                {
                    ModeloNegocio.Asesor AsesorMN = new ModeloNegocio.Asesor();
                    foreach (ModeloNegocio.School listSchool in AsesorMN.Schools)
                    {
                        userSchool.updateSelectSchoolForIduser(listSchool.id, 0);
                    }
                   // userSchool.updateSelectSchoolForIduser(iduser);
                    userSchool.deleteSchoolsForUserId(iduser);
                    userTeacher.deleteTeachersForUserId(iduser);
                    Response.Write("{success:1}");
                }
            }

            if (Request.Params["tipo"] == "deleteDocente")
            {
                int iduser = Convert.ToInt32(Request.Params["iduser"]);
                LogicaNegocio.Docente Docente = new LogicaNegocio.Docente();
                //Response.Write("{success:1}");
                if (Docente.deleteDocente(iduser))
                {
                    Response.Write("{success:1}");
                    
                }
            }

            if (Request.Params["tipo"] == "deleteSchool")
            {
                int idSchool = Convert.ToInt32(Request.Params["idSchool"]);
                LogicaNegocio.School School = new LogicaNegocio.School();
                //Response.Write("{success:1}");
                if (School.deleteSchool(idSchool))
                {
                    Response.Write("{success:1}");
                }
            }


            if (Request.Params["tipo"] == "deleteMicrored")
            {
                int idMicrored = Convert.ToInt32(Request.Params["idmicrored"]);
                LogicaNegocio.Microred microred = new LogicaNegocio.Microred();
                //Response.Write("{success:1}");
                if (microred.deleteMicrored(idMicrored))
                {
                    Response.Write("{success:1}");
                }
            }


            if (Request.Params["tipo"] == "deleteAconpanaClase")
            {
                int idMicrored = Convert.ToInt32(Request.Params["idAconpanaClase"]);
                LogicaNegocio.AconpanaClase aconpanaClase = new LogicaNegocio.AconpanaClase();
                //Response.Write("{success:1}");
                if (aconpanaClase.deleteMicrored(idMicrored))
                {
                    Response.Write("{success:1}");
                }
            }

            if (Request.Params["tipo"] == "deleteVisitasIE")
            {
                int idVisita = Convert.ToInt32(Request.Params["idVisita"]);
                LogicaNegocio.VisitaIE visita = new LogicaNegocio.VisitaIE();
                //Response.Write("{success:1}");
                if (visita.deleteVisitaIE(idVisita))
                {
                    Response.Write("{success:1}");
                }
            }


            if (Request.Params["tipo"] == "allSchoolAsesor")
            {
                int idMicrored = Convert.ToInt32(Request.Params["idAconpanaClase"]);
                LogicaNegocio.UserSchool shool = new LogicaNegocio.UserSchool();
                //Response.Write("{success:1}");
                int idAsesor = Convert.ToInt32(Request.Params["idAsesor"]);
                


                List<ModeloNegocio.Docente> listUsuario = new List<ModeloNegocio.Docente>();



                //listUsuario = shool.getAllDocenteSchool(idSchool);
                //foreach (ModeloNegocio.Docente Docentes in listUsuario)
                //{
                //    Response.Write("{success:1}");
                //}

                var json = new JavaScriptSerializer().Serialize(shool.getAllSchoolForUser(idAsesor));
                Response.Write(json);
                //if (aconpanaClase.deleteMicrored(idMicrored))
                //{

                //    Response.Write("{success:1}");
                //}
            }

            if (Request.Params["tipo"] == "allDocenteSchool")
            {
                int idMicrored = Convert.ToInt32(Request.Params["idAconpanaClase"]);
                LogicaNegocio.School shool = new LogicaNegocio.School();
                //Response.Write("{success:1}");
                int idSchool = Convert.ToInt32(Request.Params["idSchool"]);



                List<ModeloNegocio.Docente> listUsuario = new List<ModeloNegocio.Docente>();



                //listUsuario = shool.getAllDocenteSchool(idSchool);
                //foreach (ModeloNegocio.Docente Docentes in listUsuario)
                //{
                //    Response.Write("{success:1}");
                //}

                var json = new JavaScriptSerializer().Serialize(shool.getAllDocenteSchool(idSchool));
                Response.Write(json);
                //if (aconpanaClase.deleteMicrored(idMicrored))
                //{

                //    Response.Write("{success:1}");
                //}
            }

            if (Request.Params["tipo"] == "allGradeSectionForTeacher")
            {
                int idDocente = Convert.ToInt32(Request.Params["idDocente"]);
                List<ModeloNegocio.TeacherGrade> lista1 = new List<ModeloNegocio.TeacherGrade>();
                LogicaNegocio.TeacherGrade teacherGrade = new LogicaNegocio.TeacherGrade();
                lista1 = teacherGrade.getAllTeacherGradeForUser(idDocente);
                var json = new JavaScriptSerializer().Serialize(lista1);
                Response.Write(json);
            }

            if (Request.Params["tipo"] == "allDirectorSchool")
            {
                int idMicrored = Convert.ToInt32(Request.Params["idAconpanaClase"]);
                LogicaNegocio.School shool = new LogicaNegocio.School();
                
                int idSchool = Convert.ToInt32(Request.Params["idSchool"]);
 
                var json = new JavaScriptSerializer().Serialize(shool.getDirectorSchool(idSchool));
                Response.Write(json);
                
            }

            //Franco allTemForGrade
            if (Request.Params["tipo"] == "allTemForGrade")
            {
                LogicaNegocio.Tema tema = new LogicaNegocio.Tema();
                //Response.Write("{success:1}");
                string grade = Convert.ToString(Request.Params["grade"]);

                List<ModeloNegocio.Tema> listTemas = new List<ModeloNegocio.Tema>();
                var json = new JavaScriptSerializer().Serialize(tema.getAllTemaForGrade(grade));
                Response.Write(json);
                

            }

            if (Request.Params["tipo"] == "allNumSesionForTem")
            {
                LogicaNegocio.Sesion sesion = new LogicaNegocio.Sesion();
                //Response.Write("{success:1}");
                int tema_id = Convert.ToInt32(Request.Params["tema_id"]);
                var json = new JavaScriptSerializer().Serialize(sesion.getAllSesionsForTem(tema_id));
                Response.Write(json);
                

            }
        }
    }
}