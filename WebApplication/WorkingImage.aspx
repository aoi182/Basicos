<%@ Page Language="C#" AutoEventWireup="true"  %>
<%@ Import Namespace="System.Threading" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>"Working" animated Image Demo</title>
<script language='javascript'> 
function showDiv() 
{
document.getElementById('myHiddenDiv').style.display =""; 
setTimeout('document.images["myAnimatedImage"].src = "work.gif"', 200); 
} 
</script> 

<script language="C#" runat="server"> 
        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000); // this is a surrogate for your long-running method call
            lblMessage.Text = "Done!";
        }
</script>
</head>
<body>
    <form id="form1" runat="server">    
     <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <span id='myHiddenDiv' style='display:none'> 
            <img src='' id='myAnimatedImage' align='absmiddle'> 
          </span> 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
               OnClientClick="showDiv();" Text="Search" />        
        <asp:Label ID="lblMessage" runat="server"></asp:Label> 
    </form>
</body>
</html>
