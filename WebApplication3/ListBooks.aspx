<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListBooks.aspx.cs" Inherits="WebApplication3.ListBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

<table align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="width: 70%" style="font:bold 14px arial, verdana;">
        <tr align="center" style="background-color:white;color:black;" >
            <th> Select </th> 
            <th> ISBN </th>                        
            <th> Title </th>            
            <th>Price</th>                        
        </tr>
        <%=getBookData()%>

    <tr>

        <td colspan="4" align="center" style="font:14px arial, verdana;">

            <input name="SubmitPrices" type="submit" value="Update Prices" /> 

        </td>

        <tr>
        <td colspan="2" style="font:bold 14px arial, verdana;">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>

    </tr>
</table>

   

     



</asp:Content>
