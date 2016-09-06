using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIARH.DAL;
using SIARH.BLL;
using SIARH.UIL.Models;

namespace SIARH.UIL.Form.frmInstrumentoLegal
{
    public partial class InstrumentoLegalList : System.Web.UI.Page
    {
        #region ATRIBUTOS

        private BLLInstrumentoLegal oBLLInstrumentoLegal = new BLLInstrumentoLegal();
        private bool primerIngeso=true;
        MessageBox.uscMsgBox.enmMessageType Errors = MessageBox.uscMsgBox.enmMessageType.Error;
        MessageBox.uscMsgBox.enmMessageType Correcto = MessageBox.uscMsgBox.enmMessageType.Success;
        MessageBox.uscMsgBox.enmMessageType Info = MessageBox.uscMsgBox.enmMessageType.Info;
        MessageBox.uscMsgBox.enmMessageType Atencion = MessageBox.uscMsgBox.enmMessageType.Attention;
        MessageBox.uscMsgBox.enmMessageType Confirma = MessageBox.uscMsgBox.enmMessageType.Question;

        #endregion

        #region PROPIEDADES

        public string Accion
        {
            get
            {
                if (Session["Accion"] == null)
                    Session["Accion"] = "";

                return (Convert.ToString(Session["Accion"]));
            }
            set
            {
                Session["Accion"] = value;
            }
        }

        public InstrumentoLegal oINSTRUMENTOLEGAL
        {
            get
            {
                if (Session["InstrumentoLegal"] == null)
                    Session["InstrumentoLegal"] = new InstrumentoLegal();

                return (InstrumentoLegal)Session["InstrumentoLegal"];
            }
            set
            {
                Session["InstrumentoLegal"] = value;
            }
        }


        #endregion
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AbstractHelp.CargarGridR(oBLLInstrumentoLegal, gvInstLegal, "", true);
                //gvInstLegal.DataSource = instrumentoLegalBLL.ListInstrumentoLegal();
                //gvInstLegal.DataBind();
                this.primerIngeso = true;                

            }
            msgAccept.MsgBoxAnswered += MessageAnswered;
            msgAcceptCancel.MsgBoxAnswered += MessageAnsweredAC;
        }

        protected void btnNuevo_ServerClick(object sender, EventArgs e)
        {
            this.Accion = "Insert";
            InstrumentoLegal oIns = new InstrumentoLegal();
            oIns.idInstrumentoLegal = 0;
            ///Usando la clase MySession          
            //MySession.Current.oInstrumentoLegal = oIns;
            this.oINSTRUMENTOLEGAL = oIns;
            Response.Redirect("/Form/frmInstrumentoLegal/InstrumentoLegalInsUpd.aspx");  //InstrumentoLegalInsUpd.aspx");
        }

        protected void btnMostrarTodos_ServerClick(object sender, EventArgs e)
        {
            AbstractHelp.CargarGridR(oBLLInstrumentoLegal, gvInstLegal, "", true);
            this.primerIngeso = false;            
        }

        protected void btnHabilitaBusqueda_ServerClick(object sender, EventArgs e)
        {
            //Boton que habilita los parametros de busqueda           
            AbstractHelp.EnabledControls(new object[] { this.DivBusqueda });
            AbstractHelp.DisabledControls(new object[] { this.DivGridView, this.btnNuevo, this.btnMostrarTodos, this.btnHabilitaBusqueda });
            this.primerIngeso = false;
            
        }

        protected void btnBuscar_ServerClick(object sender, EventArgs e)
        {
            bool activo = chkBusqueda.Checked;
            AbstractHelp.CargarGridR(oBLLInstrumentoLegal, gvInstLegal, txtBusquedaNombre.Value, activo);
            AbstractHelp.EnabledControls(new object[] { this.DivGridView, this.btnNuevo, this.btnMostrarTodos, this.btnHabilitaBusqueda });
            AbstractHelp.DisabledControls(new object[] { this.DivBusqueda });
        }
                
        protected void gvInstLegal_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            chkBusqueda.Checked = this.primerIngeso;            
            AbstractHelp.CargarGridR(oBLLInstrumentoLegal, gvInstLegal, txtBusquedaNombre.Value, chkBusqueda.Checked);
            gvInstLegal.SelectedIndex = -1;

            if (e.NewPageIndex >= 0)
            {
                gvInstLegal.PageIndex = e.NewPageIndex;
                Session["PaginaActual"] = gvInstLegal.PageIndex.ToString();
                Session["RegistrosPorPagina"] = gvInstLegal.PageSize.ToString();
                gvInstLegal.DataBind();
            }
        }

        protected void gvInstLegal_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = 0;
            if (Int32.TryParse(e.Keys["idInstrumentoLegal"].ToString(), out Id))
            {
                oINSTRUMENTOLEGAL.idInstrumentoLegal = Id;
                msgAcceptCancel.AddMessage("Eliminar Instrumento Legal", "Instrumento Legal", Confirma, true, true, "EliminarIL");
            }
        }

        public void Remove()
        {
            if (oBLLInstrumentoLegal.IntegrityCheck(oINSTRUMENTOLEGAL))
            {
                if (oBLLInstrumentoLegal.DeletedLogical(this.oINSTRUMENTOLEGAL.idInstrumentoLegal))
                {
                    AbstractHelp.CargarGridR(oBLLInstrumentoLegal, gvInstLegal, "", true);
                    msgAccept.AddMessage("Se ha desactivado el registro.", Correcto);
                }
                else
                    msgAccept.AddMessage("El registro tiene asociado un Registro Activo.", "Instrumento Legal", Errors);
            }
            else
                msgAccept.AddMessage("El Registro Tiene asociado un Registro Activo.", "Instrumento Legal", Errors, false, false, string.Empty);
        }

        protected void gvInstLegal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.Accion = "Edit";
            this.oINSTRUMENTOLEGAL = oBLLInstrumentoLegal.SearchbyIdInstrumentoLegal(Convert.ToInt32(gvInstLegal.DataKeys[e.NewEditIndex].Value.ToString()));
            Response.Redirect("/Form/frmInstrumentoLegal/InstrumentoLegalInsUpd.aspx");
        }

        protected void gvInstLegal_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        #region CONFIGURACION
        public void MessageAnswered(object sender, MessageBox.uscMsgBox.MsgBoxEventArgs e)
        {
            if (e.Answer == MessageBox.uscMsgBox.enmAnswer.OK)
            {
                GoBack();
            }
        }

        public void MessageAnsweredAC(object sender, MessageBox.uscMsgBox.MsgBoxEventArgs e)
        {
            if (e.Answer == MessageBox.uscMsgBox.enmAnswer.OK)
            {
                if (e.Args == "EliminarIL")               
                    Remove();                
            }
            else
                GoBack();
        }

        private void GoBack()
        {
            Response.Redirect("/Form/frmInstrumentoLegal/InstrumentoLegalList.aspx");
        }



        #endregion


    }
}