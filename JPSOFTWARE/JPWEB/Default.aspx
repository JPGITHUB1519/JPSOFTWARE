<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JPWEB._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script type="text/javascript">
    function mensaje() {
        alert("Registro Ingresado Exitosamente");
    }
</script>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
    <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
        <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    </p>
    <asp:CheckBox ID="chkestatus" runat="server" Text="Estatus" />
    <p>
        <asp:Button ID="btnsalvar" runat="server" onclick="Button1_Click" 
            Text="Aceptar" Width="122px" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Eliminar" Width="118px" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancelar" 
            Width="132px" />
    </p>
    <asp:Label ID="lblinfo" runat="server" Text="Nada"></asp:Label>
    <asp:GridView ID="dgvdata" runat="server" Height="259px" 
        onselectedindexchanged="dgvdata_SelectedIndexChanged" OnRowDeleting="DeleteRow" Width="655px" AutoGenerateEditButton="true" >
    </asp:GridView>
    </form>
</body>
</html>
