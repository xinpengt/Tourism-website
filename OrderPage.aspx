<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Individual_Assignment.OrderPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Page</title>
    <link href="casca.css" rel="stylesheet" />
    
</head>
    
<body >
     
    <form id="form1" runat="server" style="margin:auto;width:600px;background-color:white">
        <div >
            <h1>Hotel Booking Form</h1><hr />
            <h2>Hotel</h2><br />
            <h5>Selected destination:<asp:Label ID="lbdestination" runat="server" /></h5><br />
            <asp:Image ID="Imghotel" runat="server" ImageAlign="Middle" Height="300px" Width="500px" /><br />
            Hotel name: <asp:Label ID="lblhotel" runat="server"/><br />
            <hr />
            <h2>Personal details</h2><br />
            Name: <asp:TextBox ID="tbname" runat="server"/><br />
            
            <%--Gender:<asp:RadioButtonList ID="rdlgender" runat="server" RepeatDirection="Horizontal" style="display:inline" >
                <asp:ListItem Value="Male"></asp:ListItem>
                <asp:ListItem Value="Female"></asp:ListItem>
                   </asp:RadioButtonList> <br />--%>
            
            Email Address:<asp:TextBox ID="tbemail" runat="server" TextMode="Email"/><br />
            
            Phone Number:<asp:TextBox ID="tbphone" runat="server" TextMode="Phone" /><br /><hr />
           
            <h2>Booking details</h2><br />

            Check-in date:<asp:Calendar ID="cldindate" runat="server" SelectionMode="Day"/><br />
           
            Number of days:<asp:DropDownList ID="ddldays" runat="server">
            </asp:DropDownList><br />
            
            Number of person:<asp:DropDownList ID="ddlperson" runat="server">
            </asp:DropDownList>
            <br /><hr />
           
            <h2>Room details</h2><br />
            Room type:<asp:RadioButtonList ID="rdlroom" runat="server" CssClass="item">
                <asp:ListItem Value="Single room (RM85.90 per day)"></asp:ListItem> 
                <asp:ListItem Value="Double room (RM105.90 per day)"></asp:ListItem>
                <asp:ListItem Value="Apartment (RM125.90 per day)"></asp:ListItem>
                      </asp:RadioButtonList><br />
            
            Room requirements:<asp:CheckBoxList ID="cbreq" runat="server" CssClass="item">
                <asp:ListItem Value="Smoking area"></asp:ListItem>
                <asp:ListItem Value="Morning call"> </asp:ListItem>
                <asp:ListItem Value="Daily room service"></asp:ListItem>
               </asp:CheckBoxList><br /><hr />
            <asp:CheckBox ID="cbconfirmation" runat="server" /> I agree to receive notification via SMS.<br />
            <asp:Button ID="btnplaceorder" runat="server" Text="Place order" OnClick="btnplaceorder_Click"/> <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" /><br /><hr />
            <asp:Label ID="lblvalidmessage" runat="server" /><br/> <hr /> 
            <asp:Label ID="lblorder" runat="server"/><br />
        </div>
    </form>
   
</body>
</html>
