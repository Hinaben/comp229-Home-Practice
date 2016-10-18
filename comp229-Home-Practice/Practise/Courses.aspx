<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="comp229_Home_Practice.Courses" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">

                <h2>Course List</h2>
                <a href="/Practise/CourseDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i>Add Course
                </a>

                <asp:GridView ID="CoursesGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover" DataKeyNames="CourseID"
                    OnRowDeleting="CoursesGridView_RowDeleting">
                    <Columns>
                        
                        <asp:BoundField DataField="Title" HeaderText="Course Title" Visible="true" />
                        <asp:BoundField DataField="Credits" HeaderText="Credits" Visible="true" />
                        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" Visible="true" />

                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
