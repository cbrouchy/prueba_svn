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
    public partial class InstrumentoLegalInsUpd : System.Web.UI.Page
    {
        #region ATRIBUTOS

        BLLInstrumentoLegal instrumentoLegalBLL = new BLLInstrumentoLegal();
        BLLRefTipoInstrumetnoLegal refTipoInstrumentoLegalBLL = new BLLRefTipoInstrumetnoLegal();

        MessageBox.uscMsgBox.enmMessageType Errors = MessageBox.uscMsgBox.enmMessageType.Error;
        MessageBox.uscMsgBox.enmMessageType Correcto = MessageBox.uscMsgBox.enmMessageType.Success;
        MessageBox.uscMsgBox.enmMessageType Info = MessageBox.uscMsgBox.enmMessageType.Info;
        MessageBox.uscMsgBox.enmMessageType Atencion = MessageBox.uscMsgBox.enmMessageType.Attention;

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
                    Session["InstrumentoLegal"] = "";

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
                LoadDDLTipoInstrumentoLegal();

                if (this.Accion == "Insert")
                    lblTitulo.Text = "Nuevo Instrumento Legal";

                if (this.Accion == "Edit")
                {
                    lblTitulo.Text = "Actualizar Instrumento Legal";
                    AbstractHelp.EnabledControls(new object[] { DivAlta });
                    LoadData();
                }

            }

            msgAccept.MsgBoxAnswered += MessageAnswered;
        }

        private void LoadData()
        {
            Idhdn.Value = this.oINSTRUMENTOLEGAL.idInstrumentoLegal.ToString();
            this.txtInstrumentoLegal.Text = this.oINSTRUMENTOLEGAL.instrumentoLegal1;
            this.txtDescripcion.Text = this.oINSTRUMENTOLEGAL.descripcion;
            this.chkActivo.Checked = this.oINSTRUMENTOLEGAL.estaActivo;
            ddlTipoIntrumentoLegal.SelectedValue = this.oINSTRUMENTOLEGAL.idTipoInstrumentoLegal.ToString();
        }

        public void LoadDDLTipoInstrumentoLegal()
        {
            ddlTipoIntrumentoLegal.DataSource = refTipoInstrumentoLegalBLL.ListTipoInstrumento();
            ddlTipoIntrumentoLegal.DataValueField = "idTipoInstrumentoLegal";
            ddlTipoIntrumentoLegal.DataTextField = "tipoInstrumentoLegal";
            ddlTipoIntrumentoLegal.DataBind();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CreateObject();
                if (!this.instrumentoLegalBLL.RepeatedObjectCheck(oINSTRUMENTOLEGAL))
                    msgAccept.AddMessage("Existe otro Instrumetno Legal con los mismos datos ingresados!.", "Instrumento Legal", Atencion, true, false, string.Empty);
                else
                    if (instrumentoLegalBLL.InsertOrUpdate(oINSTRUMENTOLEGAL))
                    msgAccept.AddMessage("Registro Guardado Correctamente!.", "Instrumento Legal", Correcto, true, false, string.Empty);
                else
                    msgAccept.AddMessage(instrumentoLegalBLL.error, "Instrumento Legal", Errors);
            }
        }

        public object CreateObject()
        {
            //Usando clase MySession
            //InstrumentoLegal miIns = MySession.Current.oInstrumentoLegal;
            //miIns.instrumentoLegal1 = txtInstrumentoLegal.Text.ToUpper();

            this.oINSTRUMENTOLEGAL.instrumentoLegal1 = txtInstrumentoLegal.Text.ToUpper();
            this.oINSTRUMENTOLEGAL.descripcion = txtDescripcion.Text;
            this.oINSTRUMENTOLEGAL.idTipoInstrumentoLegal = (!ddlTipoIntrumentoLegal.SelectedItem.Value.Equals("[ Seleccione ]")) ? int.Parse(ddlTipoIntrumentoLegal.SelectedItem.Value) : 0;
            this.oINSTRUMENTOLEGAL.estaActivo = chkActivo.Checked;
            return oINSTRUMENTOLEGAL;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        #region CONFIGURACION
        public void MessageAnswered(object sender, MessageBox.uscMsgBox.MsgBoxEventArgs e)
        {
            if (e.Answer == MessageBox.uscMsgBox.enmAnswer.OK)
            {
                GoBack();
            }
        }

        private void GoBack()
        {
            Response.Redirect("/Form/frmInstrumentoLegal/InstrumentoLegalList.aspx");        
        }

        #endregion
    }
}