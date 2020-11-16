<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowSubjects.aspx.cs" Inherits="WebApplication3.ShowSubjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" >
        <tr align="center" style="background-color:white;color:black;" >
            <th> ISBN </th>
            <th> Title </th>                        
            <th> Price </th>            
            <th> Subject</th>                        
        </tr>
        <%=getBooks()%>


</table>

    
    <br/>

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>

</asp:Content>
