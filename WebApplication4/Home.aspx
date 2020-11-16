<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication4.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 721px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    
    <table align="center" class="auto-style1">

        <tr>
            <th style="font:bold 14px arial, verdana;">UserName: </th>
            <td>
                <asp:TextBox ID="TextBoxUsername" runat="server" size="30" ></asp:TextBox>
            </td>
            <td style="font:bold 14px arial, verdana;">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidatorISBN" runat="server" ErrorMessage="UserName Required" ControlToValidate="TextBoxUsername" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <th style="font:bold 14px arial, verdana;">Password: </th>
            <td>
                <asp:TextBox ID="TextBoxPassword" runat="server" size="30"></asp:TextBox>
            </td>
               <td style="font:bold 14px arial, verdana;">
  <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" ErrorMessage="Password Required" ControlToValidate="TextBoxPassword" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <th>&nbsp;</th>

            <td>
                &nbsp;</td>
               <td>
                     &nbsp;</td>

        </tr>

        <tr>
            <th>&nbsp;</th>

            <td>
                &nbsp;</td>
            
        </tr>
        <tr>
            <th style="font:bold 14px arial, verdana;">CustomerName:&nbsp;&nbsp; </th>
            <td>
                <asp:TextBox ID="TextBoxCustomerName" runat="server" Size="30"></asp:TextBox>
            </td>
               <td style="font:bold 14px arial, verdana;">
       <asp:RequiredFieldValidator ID="RequiredFieldValidatorSubject" runat="server" ErrorMessage="Customer Name Required" ControlToValidate="TextBoxCustomerName" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>

        </tr>

        <tr>
            <td>
         
            </td>


            <td>
                <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" CausesValidation="True" style="font: 14px arial, verdana;color:deeppink; background-color:white;"/>
                <asp:Button ID="registerButton" runat="server" Text="Register for Account" OnClick="registerButton_Click" CausesValidation="True" style="font: 14px arial, verdana;color:deeppink; background-color:white;"/>
           
            </td>

        </tr>
        <tr>
        <td colspan="2">

            <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
       </td>
      </tr>
    </table>
    <br />
   
</asp:Content>
