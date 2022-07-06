Imports System.Net.Mail
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timerdate.Enabled = True
        Timerdate.Interval = 1
    End Sub



#Region "Gönderme Butonu"
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim uname As String = tbUname.Text.Trim + lbluserend.Text
        Dim pass As String = tbPass.Text.Trim
        Dim receiver As String = tbTo.Text.Trim + cbEnd.Text.Trim
        Dim cc As String = tbCc.Text.Trim + cbEndcc.Text.Trim
        Dim subject As String = tbSubject.Text.Trim
        Dim body As String = tbBody.Text.Trim + ControlChars.NewLine + "<-------Balaban G-Mail kullanılarak gönderildi-------->" + ControlChars.NewLine
        Dim attachlocation As String = lblAttach.Text

        If tbUname.Text = "" Or tbUname.Text.Length < 2 Then
            hidelbl()
            lblerroruser.Show()
            lblerroruser.Text = "Geçersiz kullanıcı adı"
            tbUname.Focus()
            Exit Sub
        ElseIf pass.Length < 6 Then
            hidelbl()
            lblerroruser.Show()
            lblerroruser.Text = "Geçersiz şifre"
            tbPass.Focus()
            Exit Sub
        ElseIf tbTo.Text = "" Or tbTo.Text.Length < 2 Then
            hidelbl()
            lblerrorto.Show()
            lblerrorto.Text = "Geçersiz Alıcı E-postası"
            tbTo.Focus()
            Exit Sub
        ElseIf cbEnd.Text = "" Then
            hidelbl()
            lblerrortoend.Show()
            lblerrortoend.Text = "Etki Alanı Seç"
            cbEnd.Focus()
            Exit Sub
        ElseIf tbSubject.Text = "" Or tbSubject.Text.Length < 2 Then
            hidelbl()
            lblerrorsubject.Show()
            lblerrorsubject.Text = "Geçersiz Konu"
            tbSubject.Focus()
            Exit Sub
        ElseIf tbCc.Text = "" And lblAttach.Text = "attach" Then
            hidelbl()
            Dim mail As New MailMessage()
            Try
                mail.From = New MailAddress(uname)
                mail.To.Add(receiver)
                mail.Subject = subject
                mail.Body = body

                Dim smtpsettings As New SmtpClient("smtp.gmail.com")
                smtpsettings.Port = 587
                smtpsettings.Credentials = New System.Net.NetworkCredential(uname, pass)
                smtpsettings.EnableSsl = True
                Try
                    Me.Enabled = False
                    Me.WindowState = FormWindowState.Normal
                    smtpsettings.Send(mail)
                    TimerProgressbar.Start()
                    lblAttach.Hide()
                    clearinputs()
                Catch ex As Exception
                    MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                    Me.Enabled = True
                End Try
            Catch ex As Exception
                MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                Me.Enabled = True
            End Try

        ElseIf tbCc.Text = "" And lblAttach.Text <> "attach" Then
            hidelbl()
            Dim attach As New Attachment(attachlocation)
            Dim mail As New MailMessage()
            Try
                mail.From = New MailAddress(uname)
                mail.To.Add(receiver)
                mail.Subject = subject
                mail.Body = body
                mail.Attachments.Add(attach)

                Dim smtpsettings As New SmtpClient("smtp.gmail.com")
                smtpsettings.Port = 587
                smtpsettings.Credentials = New System.Net.NetworkCredential(uname, pass)
                smtpsettings.EnableSsl = True
                Try
                    Me.Enabled = False
                    Me.WindowState = FormWindowState.Normal
                    smtpsettings.Send(mail)
                    TimerProgressbar.Start()
                    lblAttach.Hide()
                    clearinputs()
                Catch ex As Exception
                    MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                    Me.Enabled = True
                End Try
            Catch ex As Exception
                MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                Me.Enabled = True
            End Try

        ElseIf tbCc.Text <> "" And lblAttach.Text = "attach" Then
            If tbCc.Text.Length < 2 Then
                hidelbl()
                lblerrorcc.Show()
                lblerrorcc.Text = "Geçersiz Bilgi E-Mail"
                Exit Sub
            ElseIf cbEndcc.Text = "" Then
                hidelbl()
                lblerrorccend.Show()
                lblerrorccend.Text = "Etki Alanı Seç"
                Exit Sub
            Else
                hidelbl()
                Dim mail As New MailMessage()
                Try
                    mail.From = New MailAddress(uname)
                    mail.To.Add(receiver)
                    mail.Subject = subject
                    mail.CC.Add(cc)
                    mail.Body = body

                    Dim smtpsettings As New SmtpClient("smtp.gmail.com")
                    smtpsettings.Port = 587
                    smtpsettings.Credentials = New System.Net.NetworkCredential(uname, pass)
                    smtpsettings.EnableSsl = True
                    Try
                        Me.Enabled = False
                        Me.WindowState = FormWindowState.Normal
                        smtpsettings.Send(mail)
                        TimerProgressbar.Start()
                        lblAttach.Hide()
                        clearinputs()
                    Catch ex As Exception
                        MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                        Me.Enabled = True
                    End Try
                Catch ex As Exception
                    MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                    Me.Enabled = True
                End Try
            End If

        ElseIf tbCc.Text <> "" And lblAttach.Text <> "attach" Then
            hidelbl()
            Dim attach As New Attachment(attachlocation)
            Dim mail As New MailMessage()
            Try
                mail.From = New MailAddress(uname)
                mail.To.Add(receiver)
                mail.Subject = subject
                mail.Body = body
                mail.CC.Add(cc)
                mail.Attachments.Add(attach)

                Dim smtpsettings As New SmtpClient("smtp.gmail.com")
                smtpsettings.Port = 587
                smtpsettings.Credentials = New System.Net.NetworkCredential(uname, pass)
                smtpsettings.EnableSsl = True
                Try
                    Me.Enabled = False
                    Me.WindowState = FormWindowState.Normal
                    smtpsettings.Send(mail)
                    TimerProgressbar.Start()
                    lblAttach.Hide()
                    clearinputs()
                Catch ex As Exception
                    MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                    Me.Enabled = True
                End Try
            Catch ex As Exception
                MsgBox("Lütfen kullanıcı adı ve şifreyi kontrol edin", MessageBoxIcon.Error, "Hata")
                Me.Enabled = True
            End Try
        End If
    End Sub
#End Region

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

#Region "Saat"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timerdate.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dd MMMM  yyyy - dddd")
    End Sub
#End Region


#Region "Temizle Butonu"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblStatus.Hide()
        tbUname.Clear()
        tbPass.Clear()
        tbTo.Clear()
        tbCc.Clear()
        tbSubject.Clear()
        lblAttach.Hide()
        lblAttach.Text = "attach"
        tbBody.Clear()
        hidelbl()
    End Sub

#End Region



#Region "İlerleme Çubuğu"
    Private Sub TimerProgressbar_Tick(sender As Object, e As EventArgs) Handles TimerProgressbar.Tick
        ProgressBar1.Show()
        ProgressBar1.Increment(1)
        lblStatus.Visible = True

        If ProgressBar1.Value = 10 Then
            lblStatus.Text = "Lütfen bekleyiniz..."
        ElseIf ProgressBar1.Value = 30 Then
            lblStatus.Text = "Sunucuya bağlanıyor..."
        ElseIf ProgressBar1.Value = 40 Then
            lblStatus.Text = "Lütfen bekleyiniz..."
        ElseIf ProgressBar1.Value = 50 Then
            lblStatus.Text = "Bağlantı kontrol ediliyor..."
        ElseIf ProgressBar1.Value = 60 Then
            lblStatus.Text = "Bağlantı Tamam..."
        ElseIf ProgressBar1.Value = 80 Then
            lblStatus.Text = "Lütfen bekleyiniz..."
        ElseIf ProgressBar1.Value = 90 Then
            lblStatus.Text = "Bitti..."
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Hide()
            lblStatus.Text = "Mail gönderildi!"
            TimerProgressbar.Stop()
            Me.Enabled = True
        End If
    End Sub
#End Region

#Region "Tıkladğında"
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niEGS.MouseDoubleClick
        If (Me.WindowState = FormWindowState.Minimized) Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region

#Region "Küçültüldüğünde"
    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        If (Me.WindowState = FormWindowState.Minimized) Then
            Me.Hide()
            niEGS.ShowBalloonTip(3000, "Balaban G-Mail gönderici", "Balaban G-Mail arka planda çalışıyor. Büyütmek için bu simgeye çift tıklayın", ToolTipIcon.Info)
        Else
            Me.Show()
        End If
    End Sub
#End Region

#Region "Form kapatıldğında"
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim close As String
        close = MessageBox.Show("Kapatmak istediğinizden emin misiniz?", "Balaban G-Mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If close = MsgBoxResult.No Then
            e.Cancel = True
            Me.Refresh()
        Else
            MsgBox("Balaban G-mail'i kullandığınız için teşekkür ederiz", MsgBoxStyle.Information, "Balaban G-Mail")
            Me.Dispose()
        End If
    End Sub
#End Region

#Region "Sola hizalama"
    Private Sub tbrLeft_Click(sender As Object, e As EventArgs) Handles tbrLeft.Click
        tbBody.SelectionAlignment = HorizontalAlignment.Left
        Dim body As String = tbBody.SelectionAlignment
    End Sub
#End Region


#Region "Sola hizalama"
    Private Sub tbrCenter_Click(sender As Object, e As EventArgs) Handles tbrCenter.Click
        tbBody.SelectionAlignment = HorizontalAlignment.Center
        Dim body As String = tbBody.SelectionAlignment
    End Sub
#End Region

#Region "Sağa hizalama"
    Private Sub tbrRight_Click(sender As Object, e As EventArgs) Handles tbrRight.Click
        tbBody.SelectionAlignment = HorizontalAlignment.Right
        Dim body As String = tbBody.SelectionAlignment
    End Sub
#End Region


#Region "Kalın"
    Private Sub tbrBold_Click(sender As Object, e As EventArgs) Handles tbrBold.Click
        If Not tbBody.SelectionFont Is Nothing Then

            Dim currentFont As System.Drawing.Font = tbBody.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If tbBody.SelectionFont.Bold = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Bold
            End If

            tbBody.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)

        End If
    End Sub
#End Region

#Region "İtalik"
    Private Sub tbrItalic_Click(sender As Object, e As EventArgs) Handles tbrItalic.Click
        If Not tbBody.SelectionFont Is Nothing Then

            Dim currentFont As System.Drawing.Font = tbBody.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If tbBody.SelectionFont.Italic = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Italic
            End If

            tbBody.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)

        End If
    End Sub
#End Region

#Region "Altı Çizili"
    Private Sub tbrUnderline_Click(sender As Object, e As EventArgs) Handles tbrUnderline.Click
        If Not tbBody.SelectionFont Is Nothing Then

            Dim currentFont As System.Drawing.Font = tbBody.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If tbBody.SelectionFont.Underline = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Underline
            End If

            tbBody.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)

        End If
    End Sub
#End Region


#Region "Font Stili"
    Private Sub tbrFont_Click(sender As Object, e As EventArgs) Handles tbrFont.Click
        If Not tbBody.SelectionFont Is Nothing Then
            FontDialog1.Font = tbBody.SelectionFont
        Else
            FontDialog1.Font = Nothing
        End If

        FontDialog1.ShowApply = True

        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tbBody.SelectionFont = FontDialog1.Font
        End If
    End Sub
#End Region

#Region "Kaydedilen dosyayı oku"
    Private Sub tbrOpen_Click(sender As Object, e As EventArgs) Handles tbrOpen.Click
        With OpenFileDialog1
            .Filter = "Metin Dosyaları (*.txt)|*.txt"
            .Title = "Dosya Aç"
            .FileName = ""
            .ShowDialog()
        End With
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filename As String = OpenFileDialog1.FileName
        Dim sr As StreamReader
        sr = New StreamReader(filename)
        tbBody.Text = sr.ReadToEnd
        sr.Close()
    End Sub
#End Region

#Region "button dosya aç"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.Enabled = False
        With OpenFileDialog2
            .Title = "Select Attachment"
            .FileName = ""
            .Filter = "All Files(*.*)|*.*"
        End With

        If Me.OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Me.Enabled = True
        End If
    End Sub
#End Region

#Region "Openfiledialog tamam"
    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Me.Enabled = True
        lblAttach.Show()
        lblAttach.Text = Path.GetFullPath(OpenFileDialog2.FileName)
    End Sub
#End Region

#Region "Tüm hataları gizle"
    Private Sub hidelbl()
        lblerroruser.Hide()
        lblerrorto.Hide()
        lblerrortoend.Hide()
        lblerrorcc.Hide()
        lblerrorccend.Hide()
        lblerrorsubject.Hide()
    End Sub
#End Region

#Region "Girişleri temizle"
    Private Sub clearinputs()
        tbTo.Clear()
        tbCc.Clear()
        tbSubject.Clear()
        tbBody.Clear()
        lblAttach.Text = "attach"
    End Sub
#End Region

End Class
