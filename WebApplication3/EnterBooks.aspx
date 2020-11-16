<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EnterBooks.aspx.cs" Inherits="WebApplication3.EnterBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table align="center" style="width: 679px">

        <tr>
            <th style="font:bold 14px arial, verdana;">ISBN:</th>
            <td>
                <asp:TextBox ID="TextBoxISBN" runat="server" size="10"></asp:TextBox>
            </td>
            <td style="font: bold 14px arial, verdana;">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidatorISBN" runat="server" ErrorMessage="ISBN Number Required" ControlToValidate="TextBoxISBN" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <th class="auto-style1" style="font:bold 14px arial, verdana;" >Title: </th>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxTitle" runat="server" size="30"></asp:TextBox>
            </td>
               <td class="auto-style1" style="font:bold 14px arial, verdana;">
  <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" ErrorMessage="Tiltle Required" ControlToValidate="TextBoxTitle" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <th style="font:bold 14px arial, verdana;" >Price</th>

            <td style="font:bold 14px arial, verdana;">
                <asp:TextBox ID="TextBoxPrice" runat="server" size="5"></asp:TextBox>
            </td>
               <td style="font:bold 14px arial, verdana;">
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrice" runat="server" ErrorMessage="Price Required" ControlToValidate="TextBoxPrice" ForeColor="deeppink"></asp:RequiredFieldValidator>
            </td>

        </tr>

        <tr>
            <th style="font:bold 14px arial, verdana;">Choose Subject: </th>

            <td>
                <asp:DropDownList ID="DropDownListSubjects" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListSubjects_SelectedIndexChanged"></asp:DropDownList>
            </td>
            
        </tr>
        <tr>
            <th style="font:bold 14px arial, verdana;">Or Enter Subject: </th>
            <td>
                <asp:TextBox ID="TextBoxSubject" runat="server"></asp:TextBox>
            </td>
               <td style="font:bold 14px arial, verdana;">
       <asp:RequiredFieldValidator ID="RequiredFieldValidatorSubject" runat="server" ErrorMessage="Subject Required" ControlToValidate="TextBoxSubject" ForeColor="deeppink"></asp:RequiredFieldValidator>

            </td>

        </tr>

        <tr>
            <td>
         
            </td>


            <td style="font:bold 14px arial, verdana;">
                <asp:Button ID="ButtonAdd" runat="server" Text="Add Book" OnClick="ButtonAdd_Click" style="font:14px arial, verdana;" />
                <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" CausesValidation="False" style="font:14px arial, verdana;"/>
           
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
