<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListSubjects.aspx.cs" Inherits="WebApplication4.ListSubjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font: 16px arial, verdana;">
        <tr align="center" style="background-color: white; color: deeppink;">
            <th>Select </th>
            <th>Subject </th>

        </tr>
        <%=getSubjectData()%>


        <tr>
            <td colspan="2" align="center" >
                <input name="SearchSubjects" type="submit" value="Search Subjects" style="font: 14px arial, verdana;" />

            </td>
        </tr>

</table>
        <br />
  

            <%=getSearchedSubjects()%>


    <br/>

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    
</asp:Content>
