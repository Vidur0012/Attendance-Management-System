<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttendancePage.aspx.cs" Inherits="WebClient.AttendancePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance</title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.rtl.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <div class="card-header bg-dark text-white">
                <h1>Teacher Name:&nbsp;&nbsp;<%=teacher.Name%>
                    <div style="float: right">
                        Date : <%=DateTime.Now.ToString("dddd, MMMM dd yyyy")%>
                    </div>
                </h1>
                <h1>Class:&nbsp;&nbsp;<%=teacher.Class%>
                    <div style="float: right">
                        <a href="ViewAttendance.aspx" class="btn btn-info mx-5">View Attendance</a>
                        <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="Logout" OnClick="Button2_Click" />
                    </div>
                </h1>
            </div>
            <div class="card-header text-center">
                <h2>Attendance Sheet</h2>
                <asp:Label ID="Label1" CssClass="form-control alert-success" runat="server" Text="hello"></asp:Label>
            </div>
            <div class="card-body">
                <asp:GridView CssClass="auto-style1" runat="server" BackColor="White" BorderColor="#999999"
                    BorderStyle="Solid" BorderWidth="1px" Style="max-height: fit-content; width: 100%;" CellPadding="3"
                    AutoGenerateColumns="False" ID="gvData">
                    <Columns>
                        <asp:BoundField DataField="NO" HeaderText="No">
                            <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name">
                            <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Rollno" HeaderText="Roll no">
                            <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Present">
                            <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>

                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle HorizontalAlign="Center" BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
            <div class="card-footer">
                <center>
                    <asp:Button ID="Button1" OnClick="Button1_Click" class="btn btn-primary" runat="server" Text="Submit" />
                </center>
            </div>
        </div>
    </form>
</body>
</html>
