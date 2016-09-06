<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridViewPager.ascx.cs" Inherits="SIARH.Template.GridViewPager" %>
<div class="DDPager">
    <span class="DDFloatLeft">
        <asp:ImageButton AlternateText="Primera página" ToolTip="Primera página" ID="ImageButtonFirst" runat="server" ImageUrl="~/Content/Imagen/PgFirst.gif" Width="8" Height="9" CommandName="Page" CommandArgument="First" />
        &nbsp;
        <asp:ImageButton AlternateText="Página anterior" ToolTip="Página anterior" ID="ImageButtonPrev" runat="server" ImageUrl="~/Content/Imagen/PgPrev.gif" Width="5" Height="9" CommandName="Page" CommandArgument="Prev" />
        &nbsp;
        <asp:Label ID="LabelPage" runat="server" Text="Página " AssociatedControlID="TextBoxPage" />
        <asp:TextBox ID="TextBoxPage" runat="server" Columns="5" AutoPostBack="true" OnTextChanged="TextBoxPage_TextChanged" Width="20px" CssClass="DDControl" disabled="disabled" />
        de
        <asp:Label ID="LabelNumberOfPages" runat="server" />
        &nbsp;
        <asp:ImageButton AlternateText="Página siguiente" ToolTip="Página siguiente" ID="ImageButtonNext" runat="server" ImageUrl="~/Content/Imagen/PgNext.gif" Width="5" Height="9" CommandName="Page" CommandArgument="Next" />
        &nbsp;
        <asp:ImageButton AlternateText="Última página" ToolTip="Última página" ID="ImageButtonLast" runat="server" ImageUrl="~/Content/Imagen/PgLast.gif" Width="8" Height="9" CommandName="Page" CommandArgument="Last" />
    </span>
    <span class="DDFloatRight">
        <asp:Label ID="LabelRows" runat="server" Text="Resultados por página:" AssociatedControlID="DropDownListPageSize" />
        <asp:DropDownList ID="DropDownListPageSize" runat="server" AutoPostBack="true" CssClass="DDControl" onselectedindexchanged="DropDownListPageSize_SelectedIndexChanged" disabled="disabled">
            <asp:ListItem Value="5" />
            <asp:ListItem Value="10" />
        </asp:DropDownList>
    </span>
</div>