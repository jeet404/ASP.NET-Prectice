<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h1>Dashboard</h1>
        <hr />
        <div class="row">
            <div class="card">
                <div class="card-title">Category</div>
                <div class="card-body">
                    <a href="category.aspx" class="card-link">View</a>
                </div>
            </div>
            <div class="card">
                <div class="card-title">Brands</div>
                <div class="card-body">
                    <a href="brands.aspx" class="card-link">View</a>
                </div>
            </div>
            <div class="card">
                <div class="card-title">Products</div>
                <div class="card-body">
                    <a href="products.aspx" class="card-link">View</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>