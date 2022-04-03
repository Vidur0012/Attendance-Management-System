<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAttendance.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Per Teacher</title>
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
                        Today's Date : <%=DateTime.Now.ToString("dddd, MMMM dd yyyy")%>
                    </div>
                </h1>
                <h1>Class:&nbsp;&nbsp;<%=teacher.Class%>
                    <div style="float: right">
                        Select date
                        <asp:TextBox OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" CssClass="h3" ID="TextBox1" TextMode="Date" runat="server"></asp:TextBox>
                    </div>
                </h1>
            </div>
            <div class="card-header text-center">
                <h2>View Attendance</h2>
            </div>
            <div class="card-body">
                <table class="table table-hover table-bordered border-secondary text-center">
                    <thead class="table-dark">
                        <tr>
                            <th>No
                            </th>
                            <th>Name
                            </th>
                            <th>Roll No
                            </th>
                            <th>presence
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <% foreach (AttendanceEntry att in AttendanceEntries)
                            {%>
                        <tr>
                            <td>
                                <%:att.Id%>
                            </td>
                            <td>
                                <%:att.Name%>
                            </td>
                            <td>
                                <%:att.RollNo%>
                            </td>
                            <td>
                                <%if (att.Present)
                                    { %>
                                <span class="btn btn-success rounded-pill " style="cursor: text">Present</span>
                                <%}
                                    else
                                    { %>
                                <span class="btn btn-danger rounded-pill " style="cursor: text">Absent</span>
                                <%} %>
                            </td>
                        </tr>
                        <% }%>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
