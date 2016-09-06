using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace SIARH.UIL.Models
{
    public static class AbstractHelp
    {

        public static void EnabledControls(object[] obj)
        {
            foreach (var item in obj)
            {
                switch (item.GetType().Name)
                {
                    case "HtmlInputText":
                        ((HtmlInputText)item).Disabled = false;
                        break;
                    case "HtmlGenericControl":
                        ((HtmlGenericControl)item).Attributes["Style"] = "display:";
                        break;
                    case "HtmlButton":
                        ((HtmlButton)item).Attributes["Style"] = "display:";
                        break;
                    case "TextBox":
                        ((TextBox)item).Attributes["disabled"] = "";
                        break;
                    case "HtmlInputCheckBox":
                        ((HtmlInputCheckBox)item).Disabled = false;
                        break;                  
                }
            }
        }
        public static void DisabledControls(object[] obj)
        {
            foreach (var item in obj)
            {
                var name = item.GetType().Name;
                switch (item.GetType().Name)
                {
                    case "HtmlInputText":
                        ((HtmlInputText)item).Disabled = true;
                        break;
                    case "HtmlGenericControl":
                        ((HtmlGenericControl)item).Attributes["Style"] = "display:none";
                        break;
                    case "HtmlButton":
                        ((HtmlButton)item).Attributes["Style"] = "display:none";
                        break;
                }
            }
        }

        public static void ClearControls(object[] obj)
        {
            foreach (var item in obj)
            {
                var c = item.GetType().Name;
                switch (item.GetType().Name)
                {
                    case "TextBox":
                        ((TextBox)item).Text = "";
                        break;
                    case "HtmlInputText":
                        ((HtmlInputText)item).Value = "";
                        break;
                    case "HtmlInputCheckBox":
                        ((HtmlInputCheckBox)item).Checked = false;
                        break;
                }
            }
        }

        public static void CargarGridR<T>(T model, GridView grid, string valor, bool? esActivo)
        {
            var clase = typeof(T);

            switch (model.GetType().Name)
            {                
                case "BLLInstrumentoLegal":
                    var Model = new SIARH.BLL.BLLInstrumentoLegal();
                    grid.DataSource = Model.Search(valor, esActivo);
                    break;
                //case "RolModel":
                //    var rModel = new Gdocs.Business.RolModel();
                //    grid.DataSource = rModel.Search(valor, esActivo);
                //    break;
                //case "PermisoModel":
                //    var pModel = new Gdocs.Business.PermisoModel();
                //    grid.DataSource = pModel.Search(valor, esActivo);
                //    break;
                //case "PermisoRolModel":
                //    var prModel = new Gdocs.Business.PermisoRolModel();
                //    grid.DataSource = prModel.GetActive();//prModel.Search(valor, esActivo);
                //    break;
                //case "DependenciaModel":
                //    var dModel = new Gdocs.Business.DependenciaModel();
                //    grid.DataSource = dModel.Search(valor, esActivo);
                //    break;
                //case "HorarioDependenciaModel":
                //    var HdModel = new Gdocs.Business.HorarioDependenciaModel();
                //    grid.DataSource = HdModel.Search(valor, esActivo);
                //    break;
                //case "UsuarioModel":
                //    var uModel = new Gdocs.Business.UsuarioModel();
                //    grid.DataSource = (esActivo) ? uModel.GetActive() : uModel.Search(valor);
                //    break;
                //case "UsuarioDependenciaModel":
                //    var udModel = new Gdocs.Business.UsuarioDependenciaModel();
                //    grid.DataSource = (esActivo) ? udModel.GetActive() : udModel.Search(valor);
                //    break;
                //case "UsuarioDependenciaRolModel":
                //    var urModel = new Gdocs.Business.UsuarioDependenciaRolModel();
                //    grid.DataSource = (esActivo) ? urModel.GetActive() : urModel.Search(valor);
                //    break;
                //case "UsuarioDependenciaPermisoModel":
                //    var udpModel = new Gdocs.Business.UsuarioDependenciaPermisoModel();
                //    grid.DataSource = (esActivo) ? udpModel.GetActive() : udpModel.Search(valor);
                //    break;
                //case "ProcesoModel":
                //    var procesoModel = new Gdocs.Business.ProcesoModel();
                //    grid.DataSource = (esActivo) ? procesoModel.GetActive() : procesoModel.Search(valor, esActivo);
                //    break;
            }

            grid.DataBind();
        }
    }
}