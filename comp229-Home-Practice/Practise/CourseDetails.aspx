<%@ Page Title="CourseDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="comp229_Home_Practice.CourseDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">

                <h1>Course Details</h1>
                <h5>All Fields are required</h5>
                <br />

                
                <div class="form-group">
                    <label class="control-label" for="TitleTextBox">Title</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TitleTextBox"
                        placeholder="Title" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="CreditTextBox">Credit</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="CreditTextBox"
                        placeholder="Credit" required="true"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="DepartmentIDTextBox">DepartmentID</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DepartmentIDTextBox"
                        placeholder="DepartmentID" required="true"></asp:TextBox>
                </div>

                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
