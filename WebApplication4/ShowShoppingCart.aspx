<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowShoppingCart.aspx.cs" Inherits="WebApplication4.ShowShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font: 14px arial, verdana;">
        <tr align="center" style="background-color: white; color: deeppink;">
            <th>Title </th>
            <th>Quantity</th>
            <th>Each</th>
            <th>Total</th>

        </tr>
        <%=getCartData()%>

         <tr>
        <td colspan="2">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>
      </tr>

        </table>

      

</asp:Content>
