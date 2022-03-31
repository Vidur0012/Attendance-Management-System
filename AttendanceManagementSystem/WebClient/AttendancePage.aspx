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
                <h1>Attendance Sheet</h1>

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

                <button class="btn btn-primary">Submit</button>
                </center>
            </div>

        </div>





    </form>
</body>
</html>
