<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
            <nav>
                <ul>
                    <li id="login">
                        <a id="login-trigger" href="#">Entrar<span>▼</span>
                        </a>
                        <div id="login-content">

                            <div id="inputs">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                             </div>
                            <div id="actions">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ingresar" />
                                <asp:CheckBox ID="chkRemember" runat="server" Checked="true"></asp:CheckBox>Rocardar cuenta
                            </div>
                            <a href="#" style="float: right;">Olvidaste tu contraseña?</a>
                        </div>

                    </li>
                    <li id="signup">
                        <a href="#">Sign up</a>
                    </li>
                </ul>
            </nav>
        </div>
    </form>
</body>
</html>
