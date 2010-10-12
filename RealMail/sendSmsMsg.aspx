<%@ Page Language="VB" AutoEventWireup="false" CodeFile="sendSmsMsg.aspx.vb" Inherits="sendSmsMsg" %>

<%@ Register Assembly="GradientPanel" Namespace="BXSW.SLControls" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottommargin="0" leftmargin="0" rightmargin="0" topmargin="0" style="font-size: medium; color: navy; font-family: Arial">
    <form id="form1" runat="server">
    <div>
        <div>
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                <tr>
                    <td height="60" valign="bottom">
                        <cc1:GradientPanel ID="GradientPanel1" runat="server" Direction="Vertical" EndColor="DarkGray"
                            Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="Black" Height="60px"
                            StartColor="LightSteelBlue">
                            <br />
                            &nbsp; &nbsp;&nbsp; ASP.NET 2.0 - Send SMS Message Demonstration<br />
                            &nbsp;
                        </cc1:GradientPanel>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td height="100%" style="font-size: small; font-family: Arial" valign="top">
                        <table style="width: 100%">
                            <tr>
                                <td align="right" style="width: 20%; height: 9px" valign="top">
                                    &nbsp; To (Cell Phone Number):&nbsp;
                                </td>
                                <td style="width: 100%; height: 9px" valign="top">
                                    &nbsp;
                                    <asp:TextBox ID="txtToNumber" runat="server" Width="192px"></asp:TextBox>&nbsp;
                                    <asp:DropDownList ID="cboCarrier" runat="server" Width="232px">
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 20%; height: 20px;" valign="top">
                                    &nbsp; From:&nbsp;
                                </td>
                                <td style="width: 100%; height: 20px;" valign="top">
                                    &nbsp;
                                    <asp:TextBox ID="txtFrom" runat="server" Width="432px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" height="10" style="width: 20%" valign="top">
                                    &nbsp; Subject:&nbsp;
                                </td>
                                <td height="20" style="width: 100%" valign="top">
                                    &nbsp;
                                    <asp:TextBox ID="txtSubject" runat="server" Width="432px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" height="10" style="width: 20%" valign="top">
                                    &nbsp; Message:&nbsp;
                                </td>
                                <td height="20" style="width: 100%" valign="top">
                                    &nbsp;
                                    <asp:TextBox ID="txtMessage" runat="server" Height="96px" TextMode="MultiLine" Width="432px" MaxLength="140"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 20%; height: 20px" valign="top">
                                </td>
                                <td style="width: 100%; height: 20px" valign="top">
                                    &nbsp;
                                    <asp:Button ID="Button1" runat="server" Text="Clear" />
                                    <asp:Button ID="Button2" runat="server" Text="Send" /></td>
                            </tr>
                        </table>
                        <br />
                        &nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">No, I want to send an email message</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
