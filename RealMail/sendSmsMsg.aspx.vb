Imports System
Imports System.Net
Imports System.Net.Mail


Partial Class sendSmsMsg
    Inherits System.Web.UI.Page


#Region "Declarations"

    ' message elements
    Private mMailServer As String
    Private mTo As String
    Private mFrom As String
    Private mMsg As String
    Private mSubject As String
    Private mPort As Integer

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Load the names of the common carriers 
        cboCarrier.Items.Add("@itelemigcelular.com.br")
        cboCarrier.Items.Add("@message.alltel.com")
        cboCarrier.Items.Add("@message.pioneerenidcellular.com")
        cboCarrier.Items.Add("@messaging.cellone-sf.com")
        cboCarrier.Items.Add("@messaging.centurytel.net")
        cboCarrier.Items.Add("@messaging.sprintpcs.com")
        cboCarrier.Items.Add("@mobile.att.net")
        cboCarrier.Items.Add("@mobile.cell1se.com")
        cboCarrier.Items.Add("@mobile.celloneusa.com")
        cboCarrier.Items.Add("@mobile.dobson.net")
        cboCarrier.Items.Add("@mobile.mycingular.com")
        cboCarrier.Items.Add("@mobile.mycingular.net")
        cboCarrier.Items.Add("@mobile.surewest.com")
        cboCarrier.Items.Add("@msg.acsalaska.com")
        cboCarrier.Items.Add("@msg.clearnet.com")
        cboCarrier.Items.Add("@msg.mactel.com")
        cboCarrier.Items.Add("@msg.myvzw.com")
        cboCarrier.Items.Add("@msg.telus.com")
        cboCarrier.Items.Add("@mycellular.com")
        cboCarrier.Items.Add("@mycingular.com")
        cboCarrier.Items.Add("@mycingular.net")
        cboCarrier.Items.Add("@mycingular.textmsg.com")
        cboCarrier.Items.Add("@o2.net.br")
        cboCarrier.Items.Add("@ondefor.com")
        cboCarrier.Items.Add("@pcs.rogers.com")
        cboCarrier.Items.Add("@personal-net.com.ar")
        cboCarrier.Items.Add("@personal.net.py")
        cboCarrier.Items.Add("@portafree.com")
        cboCarrier.Items.Add("@qwest.com")
        cboCarrier.Items.Add("@qwestmp.com")
        cboCarrier.Items.Add("@sbcemail.com")
        cboCarrier.Items.Add("@sms.bluecell.com")
        cboCarrier.Items.Add("@sms.cwjamaica.com")
        cboCarrier.Items.Add("@sms.edgewireless.com")
        cboCarrier.Items.Add("@sms.hickorytech.com")
        cboCarrier.Items.Add("@sms.net.nz")
        cboCarrier.Items.Add("@sms.pscel.com")
        cboCarrier.Items.Add("@smsc.vzpacifica.net")
        cboCarrier.Items.Add("@speedmemo.com")
        cboCarrier.Items.Add("@suncom1.com")
        cboCarrier.Items.Add("@sungram.com")
        cboCarrier.Items.Add("@telesurf.com.py")
        cboCarrier.Items.Add("@teletexto.rcp.net.pe")
        cboCarrier.Items.Add("@text.houstoncellular.net")
        cboCarrier.Items.Add("@text.telus.com")
        cboCarrier.Items.Add("@timnet.com")
        cboCarrier.Items.Add("@timnet.com.br")
        cboCarrier.Items.Add("@tms.suncom.com")
        cboCarrier.Items.Add("@tmomail.net")
        cboCarrier.Items.Add("@tsttmobile.co.tt")
        cboCarrier.Items.Add("@txt.bellmobility.ca")
        cboCarrier.Items.Add("@typetalk.ruralcellular.com")
        cboCarrier.Items.Add("@unistar.unifon.com.ar")
        cboCarrier.Items.Add("@uscc.textmsg.com")
        cboCarrier.Items.Add("@voicestream.net")
        cboCarrier.Items.Add("@vtext.com")
        cboCarrier.Items.Add("@wireless.bellsouth.com")

    End Sub



    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

        'send message

        Dim strMsg As String
        strMsg = txtMessage.Text

        If strMsg.Length >= 140 Then
            strMsg = strMsg.Substring(1, 140)
        End If

        mTo = Trim(txtToNumber.Text) & Trim(cboCarrier.SelectedItem.ToString())
        mFrom = Trim(txtFrom.Text)
        mSubject = Trim(txtSubject.Text)
        mMsg = Trim(txtMessage.Text)
        mMailServer = ConfigurationManager.AppSettings.Get("MyMailServer")
        mPort = ConfigurationManager.AppSettings.Get("MyMailServerPort")

        Try

            Dim message As New MailMessage(mFrom, mTo, mSubject, mmsg)
            Dim mySmtpClient As New SmtpClient(mMailServer, mPort)
            mySmtpClient.UseDefaultCredentials = True
            mySmtpClient.Send(message)

            MessageBox("The mail message has been sent to " & message.To.ToString())

        Catch ex As FormatException

            MessageBox("Format Exception: " & ex.Message)

        Catch ex As SmtpException

            MessageBox("SMTP Exception:  " & ex.Message)

        Catch ex As Exception

            MessageBox("General Exception:  " & ex.Message)

        End Try


    End Sub



    Private Sub MessageBox(ByVal strMsg As String)

        ' generate a popup message using javascript alert function
        ' dumped into a label with the string argument passed in
        ' to supply the alert box text
        Dim lbl As New Label
        lbl.Text = "<script language='javascript'>" & Environment.NewLine _
        & "window.alert(" & "'" & strMsg & "'" & ")</script>"

        ' add the label to the page to display the alert
        Page.Controls.Add(lbl)

    End Sub


End Class
