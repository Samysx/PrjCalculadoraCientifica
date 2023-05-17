<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculadoraCientifica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link rel="stylesheet" type="text/css" href="CSS/estilos.css" />
 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div style="height: 366px; margin-top: 0px; width: 259px;" >
            <asp:Label ID= "lblDisplay" runat="server" BorderStyle="Solid" Width="170px" Height="35px"> </asp:Label><br />
            <asp:Button class="BtnOp" ID="BtnSin" runat="server" Text="sin" OnClick="BtnSin_Click"  />

            <asp:Button class="BtnOp" ID="BtnCos" runat="server" Text="Cos" OnClick="BtnCos_Click" />
            <asp:Button class="BtnOp" ID="BtnClear" runat="server" Text="C"  OnClick="BtnClear_Click"  />

            <asp:Button class="BtnOp" ID="BtnMult" runat="server" Text="*"  OnClick="BtnMult_Click"  /><br />
            <asp:Button class="btn" ID="Btn7" runat="server" Text="7"  OnClick="Btn7_Click"  />
            <asp:Button class="btn" ID="Btn8" runat="server" Text="8"  OnClick="Btn8_Click"  />

            <asp:Button class="btn" ID="Btn9" runat="server" Text="9"  OnClick="Btn9_Click" />

            <asp:Button class="BtnOp" ID="BtnSub" runat="server" Text="-"  OnClick="BtnSub_Click" style="margin-top: 0px"  /><br />
            <asp:Button class="btn" ID="Btn4" runat="server" Text="4"  OnClick="Btn4_Click" />
            <asp:Button class="btn" ID="Btn5" runat="server" Text="5"  OnClick="Btn5_Click" />

            <asp:Button class="btn" ID="Btn6" runat="server" Text="6"  OnClick="Btn6_Click"  />

            <asp:Button class="BtnOp" ID="BtnSoma" runat="server" Text="+" OnClick="BtnSoma_Click" />
            
            <br />
            <asp:Button class="btn" ID="Btn1" runat="server" Text="1"  OnClick="Btn1_Click" />
            <asp:Button class="btn" ID="Btn2" runat="server" Text="2" OnClick="Btn2_Click" />
            <asp:Button class="btn" ID="Btn3" runat="server" Text="3" OnClick="Btn3_Click" />
            <asp:Button class="BtnOp" ID="BtnIgual" runat="server" Text="="  OnClick="BtnIgual_Click"  /><br />

            <asp:Button class="btn" ID="Btn0" runat="server" Text="0" OnClick="Btn0_Click" />

            <asp:Button class="BtnOp" ID="BtnRaiz" runat="server" Text="Raiz" OnClick="BtnRaiz_Click"  />
            <asp:Button class="BtnOp" ID="BtnPI" runat="server" Text="Pi" OnClick="BtnPI_Click"  />
            <asp:Button class="BtnOp" ID="BtnPow" runat="server" Text="^" OnClick="BtnPow_Click"  />
            <br />


            <asp:Image ID="Image1" runat="server" Height="118px" Width="230px" ImageUrl="~/IMG/heartstopper.jpg" style="margin-left: 75px; margin-right: 0px" />


        </div>
        <div>

        </div>
            </div>
    </form>
</body>
</html>
