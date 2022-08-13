<%@ Page Title="" Language="C#" MasterPageFile="~/nav.master" AutoEventWireup="true" CodeFile="projects.aspx.cs" Inherits="projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="innerbody" Runat="Server">
    <style>
        .container{
            display:flex;
            flex-direction:row;
        }
        .box{
            width:120px;
            height:120px;
            background-color:skyblue;
            border:1px solid black;
            border-radius:10px;
            padding:16px;
            margin-left:8px;
        }
    </style>
    <div class="container">
        <div class="box">
            <h3>Hello World</h3>
        </div>
        <div class="box">
            <h3>Hello World</h3>
        </div>
        <div class="box">
            <h3>Hello World</h3>
        </div>
        <div class="box">
            <h3>Hello World</h3>
        </div>
    </div>
</asp:Content>

