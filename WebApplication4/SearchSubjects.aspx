<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchSubjects.aspx.cs" Inherits="WebApplication4.SearchSubjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font: 14px arial, verdana;">
        <tr align="center" style="background-color: white; color: deeppink;">
            <th>Select </th>
            <th>Title </th>
            <th>Matches </th>

        </tr>
        <%=getSearchData()%>

       <tr>
        <td colspan="3">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>
      </tr>

        </table>


</asp:Content>
