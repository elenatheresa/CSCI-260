﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowSubjects.aspx.cs" Inherits="WebApplication4.ShowSubjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font: 14px arial, verdana;" >
        <tr align="center" style="background-color:white;color:deeppink;" >
            <th> ISBN </th>
            <th> Title </th>                        
            <th> Price </th>            
            <th> Subject</th>                        
        </tr>
        <%=getBooks()%>


         <tr>
        <td colspan="4">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>
      </tr>

</table>

    


</asp:Content>
