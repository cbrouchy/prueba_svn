<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="InstrumentoLegalInsUpd.aspx.cs" Inherits="SIARH.UIL.Form.frmInstrumentoLegal.InstrumentoLegalInsUpd" %>

<%@ MasterType VirtualPath="~/Master/Master.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/Template/uscMsgBox.ascx" TagName="uscMsgBox" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoHeader" runat="server">
    <h1>Instrumento Legal          
                        <small>Administración de Instrumento Legal</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="../Form/Default.aspx"><i class="fa fa-dashboard"></i>Home</a></li>
        <li><a href="#">Configuración</a></li>
        <li><a href="../Form/frmInstrumentoLegalList.aspx">InstrumentoLegal</a></li>
        <li class="active">Administración</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenido" runat="server">
    <%--Campos Ocultos para actualización--%>
    <asp:HiddenField runat="server" ID="Idhdn" />
    <div id="DivAlta" runat="server" style="display: inline;">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">
                            <asp:Label ID="lblTitulo" runat="server"></asp:Label></h3>
                        <span class="label label-primary pull-right"><i class="fa fa-database"></i></span>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <label>Instrumento legal:</label>
                            <asp:TextBox ID="txtInstrumentoLegal" runat="server" CssClass="form-control req" placeholder="Instrumento Legal"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Ingrese el instrumento legal." ControlToValidate="txtInstrumentoLegal" Display="None" ValidationGroup="valGroup" EnableClientScript="false"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>Descripción:</label>
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control req" placeholder="Descripción"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="Ingrese descripción." ControlToValidate="txtDescripcion" Display="None" ValidationGroup="valGroup" EnableClientScript="false"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>Tipo de Instrumento Legal:</label>
                            <asp:DropDownList ID="ddlTipoIntrumentoLegal" runat="server" AppendDataBoundItems="true" Width="100%" CssClass="btn btn-default dropdown-toggle">
                                <asp:ListItem Text="[ Seleccione ]" Value="-1" Selected="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                       <%-- <div class="form-group">
                            <label>Dependencia Inicial:</label>
                            <div class="input-group">
                                <asp:TextBox ID="txtDependenciaInicial" runat="server" CssClass="form-control" placeholder="Seleccione la Dependencia Inicial." Enabled="false"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvProceso" runat="server" ErrorMessage="Debe seleccionar una dependencia inicial." ControlToValidate="txtDependenciaInicial" Display="None" ValidationGroup="valGroup" EnableClientScript="false"></asp:RequiredFieldValidator>
                                <span class="input-group-btn">
                                    <button id="BtnBuscarDependenciaInicial" runat="server" class="btn btn-primary">
                                        <%-- onserverclick="BtnBuscarDependenciaInicial_ServerClick">--%>
                                      <%--  <span class="glyphicon glyphicon-search"></span>
                                    </button>
                                </span>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Genera</label>
                            <div class="radio">
                                <asp:RadioButtonList ID="rbnGenera" runat="server" Style="display: none">
                                    <asp:ListItem Text="Actuacion" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Expediente" Value="2"></asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            <div class="radio">
                                <label>
                                    <input type="radio" name="rbnGenera" id="generaActuacion" value="1" runat="server">Actuacion</label>
                            </div>
                            <div class="radio">
                                <label>
                                    <input type="radio" name="rbnGenera" id="generaExpediente" value="2" runat="server">Expediente</label>
                            </div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe seleccionar si genera Actuación o Expediente." ControlToValidate="rbnGenera" Display="None" ValidationGroup="valGroup" EnableClientScript="false"></asp:RequiredFieldValidator>
                        </div>
                       

                        <div class="form-group">
                            <input type="checkbox" class="icheckbox_minimal-blue" runat="server" id="chkPoseeCircuito" />
                            <label>Posee Circuitos ?</label>
                        </div>--%>

                        <div class="form-group">
                            <label>Esta Activo:</label>
                            <input type="checkbox" class="icheckbox_minimal-blue" runat="server" id="chkActivo" disabled checked />
                        </div>
                    </div>
                    <div class="box-footer">
                        <asp:Button ID="BtnGuardar" class="btn btn-primary" runat="server" Text="Guardar" OnClientClick="return validar();" OnClick="BtnGuardar_Click" />
                        <asp:Button ID="btnCancelar" class="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <uc:uscMsgBox ID="msgAccept" runat="server" />
</asp:Content>

