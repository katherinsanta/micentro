<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="Presentacion.Sesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 113%;
        }
        .auto-style1 {
            height: 34px;
        }
        .auto-style2 {
            color: #808080;
        }
    .auto-style3 {
        color: #333333;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="contentLogin" style="margin-left:199px; margin-bottom:70px;">
    
    <img src="Resources/images/slider.jpg"  />
    <img src="Resources/images/iphone.png" style="margin-left:50px; margin-top:-320px;" />

    <div id="login" 
        style="margin-top:-300px; height: 265px; margin-left:300px; width: 803px;">
    
        <div style="text-align:center; width: 431px;">
            <a style="color:Black; font-size:19px;">Inicio de Sesión</a>
        </div>       
         
         <div style="height:231px; width:440px; padding:15px;">
            
             <table class="style2">
                 <tr>
                     <td>
                         <asp:Label ID="Label2" runat="server" Text="Usuario: "></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="Txt_Usuario" runat="server" ForeColor="Black" ToolTip="Ingrese hasta 50 caracteres"
                             Width="204px"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="Txt_Contrasena" runat="server" ForeColor="Black" TextMode="Password"
                             ToolTip="Ingrese Numeros o Caracteres" Width="204px"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style1">
                     </td>
                     <td class="auto-style1">
                         <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         </span>
                         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ingresar" CssClass="auto-style3" />
                     </td>
                 </tr>
             </table>

                <p>
                    <span class="auto-style3">Por favor ingrese su usuario y contraseña </span> <a href="RegistroUsuario.aspx">
                        <asp:Label ID="Label4" runat="server" Text="Label" CssClass="auto-style3">Registrese</asp:Label>
                    </a><span class="auto-style3">&nbsp;. Si usted no tiene una cuenta.</span><span class="auto-style2">
                </span>
                </p>
            </div>

            <br />
            <br />
            <br />

            <br />
            <br />
            <br />

    </div>

</div>

<br />
            <br />
            <br />
            <br />
            
            <div>
    
    </div>


</asp:Content>

