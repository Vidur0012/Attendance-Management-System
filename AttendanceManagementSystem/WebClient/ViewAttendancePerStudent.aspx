<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAttendancePerStudent.aspx.cs" Inherits="WebClient.ViewAttendancePerStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Per Student</title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.rtl.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body style="background-color: navajowhite">
    <form id="form1" runat="server">

        <div class="card-header bg-dark text-white">
            <h1>Student Name:&nbsp;&nbsp;<%=student.Name %>
                <div style="float: right">
                    Roll No:&nbsp;&nbsp;<%=student.RollNo %>
                </div>
            </h1>
            <h1>Class:&nbsp;&nbsp;<%=student.Class %>
                <div style="float: right" class="row">
                    Select Subject : &nbsp;
                        <asp:DropDownList class="col mt-2 fs-3 dropdown-toggle" data-toggle="dropdown"
                            ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="40px" Width="200px">
                        </asp:DropDownList>
                </div>
            </h1>
        </div>
        <div class="card mt-5">
            <div class="card-header text-center">
                <h2>View Attendance</h2>
            </div>
            <div class="card-body">
                <table class="table table-hover table-bordered border-secondary text-center">
                    <thead class="table-dark">
                        <tr>
                            <th>No
                            </th>
                            <th>TeacherName
                            </th>
                            <th>Date
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
                                <%i += 1;%>
                                <%=i%>
                            </td>
                            <td>
                                <%:att.TeacherName%>
                            </td>
                            <td>
                                <%:att.Dt.ToString("dddd, MMMM dd yyyy")%>
                            </td>
                            <th>
                                <%if (att.Present)
                                    { %>
                                <span class="btn btn-success rounded-pill " style="cursor: text">Present</span>
                                <%}
                                    else
                                    { %>
                                <span class="btn btn-danger rounded-pill " style="cursor: text">Absent</span>
                                <%} %>
                            </th>
                        </tr>
                        <% }%>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
