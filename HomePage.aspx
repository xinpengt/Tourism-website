<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Individual_Assignment.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>

    <link href="casca.css" rel="stylesheet" />
   
     
    <style type="text/css">
        .auto-style2 {
            width: 803px;
        }
        
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1">
            <table id="table1" runat="server" align="center">
                
                <tr>
                    <td style="background-image:url(images/v.jpg)" class="auto-style2">
                        <h1>Welcome,enjoy your vacation in Kuala Lumpur!</h1><br />
                        <h3 >Where do you want to go?</h3>
                    </td>

                </tr>
                
                <tr>
                    <td class="auto-style2" style="background-color:white">
                        Kuala Lumpur is a city with a unique character. The architectural styles, food,flavors and people in KL reflect her many different facets and faces.As one of the strongest economies in the South East Asia region,KL is fiercely cosmopolitan. 
                            At the same time,KL integrates old cultures and traditions with the new.Introducing Kuala Lumpur explores the qualities that make KL a fascinating destination.</td>
               </tr>
                
                <tr>
                    <td class="auto-style2" style="background-color:white">
                      <h4>Choose a place:</h4>
                    <asp:DropDownList ID="ddlDestination" runat="server" OnSelectedIndexChanged="ddlDestination_SelectedIndexChanged1" AutoPostBack="True">
                        <asp:ListItem Value="Sultan Adbul Samad Building"></asp:ListItem>
                        <asp:ListItem Value="Petaling Street Market"></asp:ListItem>
                        <asp:ListItem Value="Central Market"></asp:ListItem>
                        <asp:ListItem Value="Batu Caves"></asp:ListItem>
                    </asp:DropDownList></td>
               </tr>
                </table>
                <table id="table2" runat="server" align="center" style="background-color:white">
                <tr>
                   <td colspan="2" ><asp:Image ID="imgDestination1" runat="server" Height="200px" Width="200px" />
                       <asp:Image ID="imgDestination2" runat="server" Height="200px" Width="200px" />
                       <asp:Image ID="imgDestination3" runat="server" Height="200px" Width="200px" />
                       <asp:Image ID="imgDestination4" runat="server" Height="200px" Width="200px" />
                       
                   </td>
               </tr>
                <tr>
                   <td colspan="2" >
                       <asp:Label ID="lbldescription" runat="server" Width="795px"/>
                    </td>
               </tr>
                <tr>
                   <td colspan="2" ><h4>What's around here:</h4></td>
               </tr>
                <tr>
                   <td>
                      <h4>Food:</h4>
                       <asp:BulletedList ID="blFood" runat="server">
                           <asp:ListItem Value="Fried noodles"></asp:ListItem>
                           <asp:ListItem Value="Nasi lemak"></asp:ListItem>
                           <asp:ListItem Value="Kari laksa"></asp:ListItem>
                           <asp:ListItem Value="Nasi kandar"></asp:ListItem>
                           <asp:ListItem Value="Kuih"></asp:ListItem>
                           <asp:ListItem Value="Popia"></asp:ListItem>
                       </asp:BulletedList>
                   </td>
                   <td>
                      <h4>Restaurant:</h4>
                        <asp:BulletedList ID="blRes" runat="server">
                            <asp:ListItem Value="Spring"></asp:ListItem>
                            <asp:ListItem Value="Fuego"></asp:ListItem>
                            <asp:ListItem Value="Marble"></asp:ListItem>
                            <asp:ListItem Value="Thirty8"></asp:ListItem>
                            <asp:ListItem Value="Opium"></asp:ListItem>
                            <asp:ListItem Value="Halab"></asp:ListItem>
                        </asp:BulletedList>

                   </td>
                    
               </tr>
                <tr>
                   <td colspan="2" > <h4>Would you like to travel here?</h4></td>
               </tr>
                <tr>
                   <td >
                   <asp:LinkButton ID="lbtnyes" Text="Yes" runat="server" OnClick="lbtnyes_Click"/>
                       
                   </td>
                    <td>
                        <asp:LinkButton ID="lbtnno" Text="No" runat="server" OnClick="lbtnno_Click"/>
                    </td>
               </tr>
                    </table>
           
        </div>
        
            
        
        </form>
    
</body>
</html>
