<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowBook.aspx.cs" Inherits="WebApplication3.ShowBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font:bold 16px arial, verdana;">
        <tr align="center" style="background-color:white;color:black;" style="font: 16px arial, verdana;" >
            <th> ISBN </th>
            <th> Title </th>                        
            <th> Price </th>            
            <th> Subject</th>                        
        </tr>
        <%=getBook()%>


</table>

    
    <br/>

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>

</asp:Content>
