<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThreeSixNine.WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<h1>3-6-9 Game</h1>
		<label>Enter number</label>
		<asp:TextBox runat="server" ID="InputNumber" />
		<asp:Button runat="server" ID="Submit" Text="Run" OnClick="Submit_Click" />
		
		<asp:Label runat="server" ID="Result" />
	</div>
	</form>
</body>
</html>
