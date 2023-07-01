<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidorASP.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-borderer" 
                     OnRowCommand="grillaMedidores_RowCommand" EmptyDataText="No existen Medidores"
                     AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="NumSerie" HeaderText="Numero de Serie"/>
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo"/>

                            
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
