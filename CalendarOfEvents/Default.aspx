<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar of Events</title>
    <link href="CalendarStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>My Calendar</h1>
        <asp:Calendar ID="myCalendar" runat="server" OnSelectionChanged="myCalendar_SelectionChanged" CssClass="myCal"></asp:Calendar><br />
        <asp:Label ID="eventLabel" runat="server" Text=" " CssClass="output"></asp:Label>
    </div>
    </form>
</body>
</html>
