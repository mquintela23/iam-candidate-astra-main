<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IAMCandidateTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">

            <br />

            <asp:DropDownList runat="server" ID="ObjectTypeList" CssClass="form-control" DataValueField="Value" DataTextField="Text" OnSelectedIndexChanged="ObjectTypeList_SelectedIndexChanged" AutoPostBack="true" />

            <asp:PlaceHolder runat="server" ID="Level2" Visible="false">

                <hr />

                <asp:DropDownList runat="server" ID="ObjectList" CssClass="form-control" DataValueField="Value" DataTextField="Text" OnSelectedIndexChanged="ObjectList_SelectedIndexChanged" AutoPostBack="true" />

                <asp:PlaceHolder runat="server" ID="Level3" Visible="false">

                    <hr />

                    <asp:PlaceHolder runat="server" ID="DetailContainer" />

                </asp:PlaceHolder>
            </asp:PlaceHolder>
        </div>
    </div>

</asp:Content>
