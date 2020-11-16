<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListSubjects.aspx.cs" Inherits="WebApplication3.ListSubjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 43px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font:bold 14px arial, verdana;">
        <tr align="center" style="background-color: white; color: black;" style="font:bold 14px arial, verdana;">
            <th style="font:16px arial, verdana;">Select </th>
            <th style="font:16px arial, verdana;">Subject </ht>

        </tr>
        <%=getSubjectData()%>


        <tr style="font:bold 14px arial, verdana;">
            <td colspan="2" align="center" style="font:bold 14px arial, verdana;" class="auto-style1">
                <input name="SearchSubjects" type="submit" value="Search Subjects" style="font:14px arial, verdana;" />

            </td>
        </tr>

</table>
        <br />
  

            <%=getSearchedSubjects()%>


    <br/>

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    
</asp:Content>
