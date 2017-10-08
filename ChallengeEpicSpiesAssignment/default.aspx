<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <p>
            Spy Code Name: <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <asp:Calendar ID="Calendar1" runat="server" Caption="End Date of Previous Assignment" CaptionAlign="Left" SelectedDate="10/06/2017 21:22:35">
            <SelectedDayStyle BackColor="#9966FF" />
        </asp:Calendar>
        <br />
        <asp:Calendar ID="Calendar2" runat="server" Caption="Start Date of New Assignment" CaptionAlign="Left" OnSelectionChanged="Calendar2_SelectionChanged">
            <SelectedDayStyle BackColor="#CC33FF" />
        </asp:Calendar>
        <br />
        <asp:Calendar ID="Calendar3" runat="server" Caption="Projected End Date of New Assignment" CaptionAlign="Left">
            <SelectedDayStyle BackColor="#666633" />
        </asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
