<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListBooks.aspx.cs" Inherits="WebApplication4.ListBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
   
<table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" >
       <tr align="center"><td style="color:deeppink;font: 18px arial, verdana;">Books</td></tr>
        <tr align="center" style="background-color:white;color:deeppink;" >
            <!--<th style="font: 14px arial, verdana;"> Select </th> --->
            <th style="font: 14px arial, verdana;" class="auto-style1"> ISBN </th>                        
            <th style="font: 14px arial, verdana;" class="auto-style1"> Title </th>            
            <th style="font: 14px arial, verdana;" class="auto-style1">Price</th>                        
        </tr>
        <%=getBookData()%>

    <tr>

        <td colspan="4" align="center">

            &nbsp;</td>

        <tr>
        <td colspan="2">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>

    </tr>
</table>

   <br />
<table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" >
      <tr align="center" ><td colspan="2" style="color:deeppink;font: 16px arial, verdana;">Subjects</td></tr>
        <tr align="center" style="background-color:white;color:deeppink;font: 14px arial, verdana;" >
            <th> SID</th> 
            <th> Name </th> 
                          
        </tr>
        <%=getSubjectData()%>

    
</table>

    <br />

<table width="60%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="white" style="font: 16px arial, verdana;" >
      <tr align="center"><td colspan="2" style="color:deeppink;">Customers</td></tr>
        <tr align="center" style="background-color:white;color:deeppink;font:14px arial, verdana;" >

            <th> CID</th> 
            <th> Names </th> 
                              
        </tr>
        <%=getCustomerData()%>

    
</table>


     



</asp:Content>
