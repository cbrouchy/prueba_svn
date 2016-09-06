<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="InstrumentoLegalList.aspx.cs" Inherits="SIARH.UIL.Form.frmInstrumentoLegal.InstrumentoLegalList" %>
<%@ MasterType VirtualPath="~/Master/Master.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/Template/uscMsgBox.ascx" TagName="uscMsgBox" TagPrefix="uc" %>
<%@ Register Src="~/Template/GridViewPager.ascx" TagName="GridViewPager" TagPrefix="asp" %>
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
    <asp:UpdatePanel ID="updPanel" runat="server">
        <ContentTemplate>
            <%--Botones Iniciales--%>
            <div runat="server" id="Botones">
                <button id="btnNuevo" class="btn  btn-social btn-foursquare" runat="server" onserverclick="btnNuevo_ServerClick">
                    <i class="fa fa-plus"></i>Nuevo Instrumento Legal</button>                
                <button id="btnMostrarTodos" class="btn btn-social btn-foursquare" runat="server" onserverclick="btnMostrarTodos_ServerClick">
                    <i class="fa fa-newspaper-o"></i>Mostrar Instrumentos 
                </button>
                <button id="btnHabilitaBusqueda" class="btn btn-social btn-foursquare" runat="server" onserverclick="btnHabilitaBusqueda_ServerClick">
                    <i class="fa fa-search"></i>Buscar instrumento
                </button>
            </div>

            <%--Grilla--%>
            <div class="panel panel-primary" id="DivGridView" runat="server" style="display: inherit">
                <div class="panel-heading">
                    Lista de Instrumentos Legales
                </div>
                <asp:GridView ID="gvInstLegal" runat="server" class="table table-bordered table-hover" ItemType="SIARH.DAL.InstrumentoLegal"
                    AutoGenerateColumns="false" DataKeyNames="idInstrumentoLegal" HorizontalAlign="Center"
                    AllowPaging="true" OnRowDeleting="gvInstLegal_RowDeleting" OnPageIndexChanging="gvInstLegal_PageIndexChanging"
                    OnRowEditing="gvInstLegal_RowEditing" OnSelectedIndexChanging="gvInstLegal_SelectedIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="idInstrumentoLegal" HeaderText="Codigo" Visible="false" HeaderStyle-BackColor="#ededed" />
                        <asp:BoundField DataField="instrumentoLegal1" HeaderText="Instrumento" HeaderStyle-BackColor="#ededed" />
                        <asp:BoundField DataField="RefTipoInstrumentoLegal.tipoInstrumentoLegal" HeaderText="Tipo de IL" HeaderStyle-BackColor="#ededed" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" HeaderStyle-BackColor="#ededed" />
                        <asp:BoundField DataField="estaActivo" HeaderText="Activo" HeaderStyle-BackColor="#ededed" />
                        <asp:TemplateField HeaderText="Acciones" HeaderStyle-BackColor="#ededed">
                            <ItemTemplate>
                                <asp:ImageButton ID="imgbtnEdit" runat="server" CommandArgument="ImageButton" CommandName="Edit"
                                    ImageUrl="~/Content/Imagen/edit.png" ToolTip="Editar" AlternateText="Editar" Width="15px" />
                                <asp:ImageButton runat="server" ID="imgbtnDelete" CommandArgument="DeleteButton"
                                    CommandName="Delete" ImageUrl="~/Content/Imagen/Delete.png" ToolTip="Eliminar" AlternateText="eliminar" Width="22px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <asp:GridViewPager ID="GridViewPager1" runat="server" />
                    </PagerTemplate>
                </asp:GridView>
            </div>

             <%--Formulario Busqueda--%>
            <div class="form-horizontal" id="DivBusqueda" runat="server" style="display: none;">
                <div class="col-xs-12 col-sm-8">
                    <div class="box box-primary">
                        <div class="box-header">
                            <h4 class="box-title">Parametros de Busqueda</h4>
                        </div>
                        <!-- /.box-header -->
                        <div class="box-body">
                            <div class="form-group">
                                <label class="col-sm-3 control-label">Nombre del instrumento</label>
                                <div class="col-sm-5">
                                    <input type="text" runat="server" class="form-control" id="txtBusquedaNombre" />
                                </div>

                            </div>
                            <div class="form-group">
                                <label class="col-sm-3 control-label">Solo Activo</label>
                                <div class="col-sm-5">
                                    <label>
                                        <input type="checkbox" class="icheckbox_minimal-blue" runat="server" id="chkBusqueda" />
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <div class="col-sm-9 col-sm-offset-3">
                                <button id="btnBuscar" type="submit" class="btn btn-primary" runat="server" onserverclick="btnBuscar_ServerClick">Buscar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           
            <uc:uscmsgbox id="msgAccept" runat="server" />
            <uc:uscmsgbox id="msgAcceptCancel" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
