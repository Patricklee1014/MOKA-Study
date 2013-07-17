<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWorld.WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<h1>Hello World! from H1</h1>
		<h2><asp:Literal runat="server" ID="helloWorld" /></h2>
		
		<asp:TextBox runat="server" ID="Username" />
		<asp:TextBox runat="server" ID="Password" TextMode="Password" />
		<asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click" />
	</div>
		
		<div>
			<asp:Literal runat="server" ID="Result" />
		</div>
	</form>
</body>
</html>
