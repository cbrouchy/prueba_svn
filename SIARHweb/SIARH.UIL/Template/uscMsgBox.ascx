<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uscMsgBox.ascx.cs" Inherits="SIARH.MessageBox.uscMsgBox" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:UpdatePanel ID="udpMsj" runat="server" UpdateMode="Conditional" RenderMode="Inline">

    <ContentTemplate>
        <asp:Button ID="btnD" runat="server" Text="" Style="display: none" Width="0" Height="0" />
        <asp:Button ID="btnD2" runat="server" Text="" Style="display: none" Width="0" Height="0" />
        <asp:Panel ID="pnlMsg" runat="server" Style="display: none" Width="550px">

            <asp:Panel ID="panelContenedor" runat="server" CssClass="modal-content">
                <div class="modal-header">
                    &nbsp;<asp:Label ID="lblMsgCaption" runat="server" Text="Mensaje"></asp:Label>
                </div>
                <div class="modal-body">
                    <asp:GridView ID="grvMsg" runat="server" ShowHeader="false" Width="98%" AutoGenerateColumns="false"
                        BorderWidth="0">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <table style="width:100%; height:100%" >
                                        <tr>
                                            <td>                                              
                                                <div id="msgAtention" runat="server" class="alert alert-warning alert-dismissable" visible='<%# (((Message)Container.DataItem).MessageType == enmMessageType.Attention) ? true : false %>'>

                                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                                    <h4><i class="icon fa fa-warning"></i>Atencion!</h4>
                                                    <%# Eval("MessageText")%>
                                                   
                                                </div>
                                                <div id="msgAcepted" runat="server" class="alert alert-success alert-dismissable" visible=' <%# (((Message)Container.DataItem).MessageType == enmMessageType.Success) ? true : false %>'>
                                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                                    <h4><i class="icon fa fa-check"></i>Correcto!</h4>
                                                    <%# Eval("MessageText")%>                                                    
                                                </div>
                                                  <div id="msgError" runat="server" class="alert alert-danger alert-dismissable" visible='<%# (((Message)Container.DataItem).MessageType == enmMessageType.Error) ? true : false %>'>

                                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                                    <h4><i class="icon fa fa-ban"></i>Atencion!</h4>
                                                    <%# Eval("MessageText")%>
                                                   
                                                </div>
                                                <div id="Div2" runat="server" class="alert alert-info alert-dismissable" visible=' <%# (((Message)Container.DataItem).MessageType == enmMessageType.Info) ? true : false %>'>
                                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                                    <h4><i class="icon fa fa-check"></i>Atencion!</h4>
                                                    <%# Eval("MessageText")%>                                                    
                                                </div>   
                                                
                                                <div id="msgQuestion" runat="server" class="alert alert-warning alert-dismissable" visible=' <%# (((Message)Container.DataItem).MessageType == enmMessageType.Question) ? true : false %>'>
                                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                                    <h4><i class="icon fa fa-check"></i>Confirma?</h4>
                                                    <%# Eval("MessageText")%>                                                    
                                                </div>                                             
                                            </td>                                         
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
               </div>
                 <div class="modal-footer">
                     <asp:Button ID="btnOK" runat="server" Text="Aceptar" CssClass="btn btn-block btn-default" CausesValidation="false" />
                    <asp:Button ID="btnPostOK" runat="server" Text="Aceptar" CausesValidation="false" OnClick="btnPostOK_Click" CssClass="btn btn-default" Visible="false" Width="80px" />
                    <asp:Button ID="btnPostCancel" runat="server" Text="Cancelar" CausesValidation="false" OnClick="btnPostCancel_Click" CssClass="btn btn-default" Visible="false" Width="80px" />
                </div>
            </asp:Panel>
        </asp:Panel>
        <cc1:ModalPopupExtender ID="mpeMsg" runat="server" TargetControlID="btnD"
            PopupControlID="pnlMsg" PopupDragHandleControlID="pnlMsgHD" BackgroundCssClass="modalBackground"
            DropShadow="false" OkControlID="btnOK">
        </cc1:ModalPopupExtender>
         <cc1:RoundedCornersExtender ID="rce" runat="server" TargetControlID="panelContenedor"
            Radius="10" Corners="All"  >
        </cc1:RoundedCornersExtender>
    </ContentTemplate>

</asp:UpdatePanel>
