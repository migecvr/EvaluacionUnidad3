<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidorASP.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">

                    <div class="form-group">
                       <label for="medidorDdl">Medidor (N° Serie): </label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control form-select"></asp:DropDownList>
                    </div>
                    <asp:Label ID="Label1" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                     <div class="form-group">
                       <label for="FechaTxt">Fecha (yyyy-MM-dd): </label>
                        <asp:TextBox ID="FechaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="FechaTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label2" runat="server" Font-Size="Smaller" ForeColor="Red"></asp:Label>

                    <div class="form-group">
                       <label for="HoraTxt">Horas: </label>
                        <asp:TextBox ID="HoraTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="HoraTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Dato No Valido" ControlToValidate="HoraTxt" Type="Integer" MinimumValue="0" MaximumValue="59" Font-Size="Smaller" ForeColor="Red"></asp:RangeValidator>

                     <div class="form-group">
                       <label for="MinutoTxt">Minutos: </label>
                        <asp:TextBox ID="MinutoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="MinutoTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Dato No Valido" ControlToValidate="MinutoTxt" Type="Integer" MinimumValue="0" MaximumValue="59" Font-Size="Smaller" ForeColor="Red"></asp:RangeValidator>


                     <div class="form-group">
                       <label for="ConsumoTxt">Consumo (entre 0 y 600 kw): </label>
                        <asp:TextBox ID="ConsumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Campo requerido" ControlToValidate="ConsumoTxt" ForeColor="red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Dato No Valido" ControlToValidate="ConsumoTxt" Type="Integer" MinimumValue="0" MaximumValue="600" Font-Size="Smaller" ForeColor="Red"></asp:RangeValidator>



                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="btnIngresarLectura" Text="Ingresar" CssClass="btn btn-primary mt-2" OnClick="btnIngresarLectura_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
