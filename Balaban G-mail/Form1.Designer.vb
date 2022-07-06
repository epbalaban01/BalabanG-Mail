<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbrFont = New System.Windows.Forms.ToolStripButton()
        Me.lblerrorccend = New System.Windows.Forms.Label()
        Me.lblerrortoend = New System.Windows.Forms.Label()
        Me.lblerrorsubject = New System.Windows.Forms.Label()
        Me.lblerrorcc = New System.Windows.Forms.Label()
        Me.lblerrorto = New System.Windows.Forms.Label()
        Me.lblAttach = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbrLeft = New System.Windows.Forms.ToolStripButton()
        Me.tbrCenter = New System.Windows.Forms.ToolStripButton()
        Me.tbrRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrItalic = New System.Windows.Forms.ToolStripButton()
        Me.tbrUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TimerProgressbar = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tbrBold = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.cbEndcc = New System.Windows.Forms.ComboBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Timerdate = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.niEGS = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbUname = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEnd = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbluserend = New System.Windows.Forms.Label()
        Me.lblerroruser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbBody = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbrFont
        '
        Me.tbrFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrFont.Image = CType(resources.GetObject("tbrFont.Image"), System.Drawing.Image)
        Me.tbrFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrFont.Name = "tbrFont"
        Me.tbrFont.Size = New System.Drawing.Size(23, 22)
        Me.tbrFont.Text = "Font Stili"
        '
        'lblerrorccend
        '
        Me.lblerrorccend.AutoSize = True
        Me.lblerrorccend.ForeColor = System.Drawing.Color.Yellow
        Me.lblerrorccend.Location = New System.Drawing.Point(351, 91)
        Me.lblerrorccend.Name = "lblerrorccend"
        Me.lblerrorccend.Size = New System.Drawing.Size(21, 15)
        Me.lblerrorccend.TabIndex = 36
        Me.lblerrorccend.Text = "cc"
        Me.lblerrorccend.Visible = False
        '
        'lblerrortoend
        '
        Me.lblerrortoend.AutoSize = True
        Me.lblerrortoend.ForeColor = System.Drawing.Color.Yellow
        Me.lblerrortoend.Location = New System.Drawing.Point(351, 44)
        Me.lblerrortoend.Name = "lblerrortoend"
        Me.lblerrortoend.Size = New System.Drawing.Size(19, 15)
        Me.lblerrortoend.TabIndex = 35
        Me.lblerrortoend.Text = "to"
        Me.lblerrortoend.Visible = False
        '
        'lblerrorsubject
        '
        Me.lblerrorsubject.AutoSize = True
        Me.lblerrorsubject.ForeColor = System.Drawing.Color.Yellow
        Me.lblerrorsubject.Location = New System.Drawing.Point(110, 144)
        Me.lblerrorsubject.Name = "lblerrorsubject"
        Me.lblerrorsubject.Size = New System.Drawing.Size(38, 15)
        Me.lblerrorsubject.TabIndex = 34
        Me.lblerrorsubject.Text = "konu"
        Me.lblerrorsubject.Visible = False
        '
        'lblerrorcc
        '
        Me.lblerrorcc.AutoSize = True
        Me.lblerrorcc.ForeColor = System.Drawing.Color.Yellow
        Me.lblerrorcc.Location = New System.Drawing.Point(110, 91)
        Me.lblerrorcc.Name = "lblerrorcc"
        Me.lblerrorcc.Size = New System.Drawing.Size(21, 15)
        Me.lblerrorcc.TabIndex = 33
        Me.lblerrorcc.Text = "cc"
        Me.lblerrorcc.Visible = False
        '
        'lblerrorto
        '
        Me.lblerrorto.AutoSize = True
        Me.lblerrorto.ForeColor = System.Drawing.Color.Yellow
        Me.lblerrorto.Location = New System.Drawing.Point(113, 44)
        Me.lblerrorto.Name = "lblerrorto"
        Me.lblerrorto.Size = New System.Drawing.Size(19, 15)
        Me.lblerrorto.TabIndex = 22
        Me.lblerrorto.Text = "to"
        Me.lblerrorto.Visible = False
        '
        'lblAttach
        '
        Me.lblAttach.AutoSize = True
        Me.lblAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttach.Location = New System.Drawing.Point(112, 168)
        Me.lblAttach.Name = "lblAttach"
        Me.lblAttach.Size = New System.Drawing.Size(40, 15)
        Me.lblAttach.TabIndex = 32
        Me.lblAttach.Text = "attach"
        Me.lblAttach.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Image = Global.Balaban_G_mail.My.Resources.Resources.Untitled_9
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBrowse.Location = New System.Drawing.Point(407, 152)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(133, 48)
        Me.btnBrowse.TabIndex = 31
        Me.btnBrowse.Text = "Dosya Seç"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Ek Dosya:"
        '
        'tbrLeft
        '
        Me.tbrLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLeft.Image = CType(resources.GetObject("tbrLeft.Image"), System.Drawing.Image)
        Me.tbrLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrLeft.Name = "tbrLeft"
        Me.tbrLeft.Size = New System.Drawing.Size(23, 22)
        Me.tbrLeft.Text = "Sola hizala"
        '
        'tbrCenter
        '
        Me.tbrCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCenter.Image = CType(resources.GetObject("tbrCenter.Image"), System.Drawing.Image)
        Me.tbrCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCenter.Name = "tbrCenter"
        Me.tbrCenter.Size = New System.Drawing.Size(23, 22)
        Me.tbrCenter.Text = "Ortala"
        '
        'tbrRight
        '
        Me.tbrRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRight.Image = CType(resources.GetObject("tbrRight.Image"), System.Drawing.Image)
        Me.tbrRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRight.Name = "tbrRight"
        Me.tbrRight.Size = New System.Drawing.Size(23, 22)
        Me.tbrRight.Text = "Sağa Hizala"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbrItalic
        '
        Me.tbrItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrItalic.Image = CType(resources.GetObject("tbrItalic.Image"), System.Drawing.Image)
        Me.tbrItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrItalic.Name = "tbrItalic"
        Me.tbrItalic.Size = New System.Drawing.Size(23, 22)
        Me.tbrItalic.Text = "İtalik"
        '
        'tbrUnderline
        '
        Me.tbrUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUnderline.Image = CType(resources.GetObject("tbrUnderline.Image"), System.Drawing.Image)
        Me.tbrUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrUnderline.Name = "tbrUnderline"
        Me.tbrUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tbrUnderline.Text = "Altı Çizili"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbrOpen
        '
        Me.tbrOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrOpen.Image = CType(resources.GetObject("tbrOpen.Image"), System.Drawing.Image)
        Me.tbrOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrOpen.Name = "tbrOpen"
        Me.tbrOpen.Size = New System.Drawing.Size(23, 22)
        Me.tbrOpen.Text = "Dosya Aç"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblDate)
        Me.GroupBox3.Controls.Add(Me.lblTime)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(447, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 86)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Geçerli Saat ve Tarih"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(16, 54)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 19)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Tarih"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(17, 21)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 19)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Saat"
        '
        'TimerProgressbar
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 26)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Balaban tarafından geliştirildi:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eyüp Can Balaban"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(17, 591)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(18, 18)
        Me.lblStatus.TabIndex = 40
        Me.lblStatus.Text = ".."
        Me.lblStatus.Visible = False
        '
        'tbrBold
        '
        Me.tbrBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBold.Image = CType(resources.GetObject("tbrBold.Image"), System.Drawing.Image)
        Me.tbrBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrBold.Name = "tbrBold"
        Me.tbrBold.Size = New System.Drawing.Size(23, 22)
        Me.tbrBold.Text = "Kalın"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'cbEndcc
        '
        Me.cbEndcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEndcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndcc.FormattingEnabled = True
        Me.cbEndcc.Items.AddRange(New Object() {"@gmail.com", "@yahoo.com", "@hotmail.com"})
        Me.cbEndcc.Location = New System.Drawing.Point(351, 67)
        Me.cbEndcc.Name = "cbEndcc"
        Me.cbEndcc.Size = New System.Drawing.Size(121, 23)
        Me.cbEndcc.TabIndex = 29
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Image = Global.Balaban_G_mail.My.Resources.Resources.mail_forward
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSend.Location = New System.Drawing.Point(531, 532)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(116, 48)
        Me.btnSend.TabIndex = 34
        Me.btnSend.Text = "Gönder"
        Me.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Timerdate
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.Location = New System.Drawing.Point(324, 586)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(444, 23)
        Me.ProgressBar1.TabIndex = 35
        Me.ProgressBar1.Visible = False
        '
        'niEGS
        '
        Me.niEGS.Icon = CType(resources.GetObject("niEGS.Icon"), System.Drawing.Icon)
        Me.niEGS.Text = "Easy G-Mail Sender"
        Me.niEGS.Visible = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Image = Global.Balaban_G_mail.My.Resources.Resources.edit_clear__1_
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnClear.Location = New System.Drawing.Point(653, 532)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 48)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "Temizle"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'tbUname
        '
        Me.tbUname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbUname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUname.Location = New System.Drawing.Point(113, 20)
        Me.tbUname.Multiline = True
        Me.tbUname.Name = "tbUname"
        Me.tbUname.Size = New System.Drawing.Size(149, 23)
        Me.tbUname.TabIndex = 14
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(113, 52)
        Me.tbPass.Multiline = True
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(149, 22)
        Me.tbPass.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'cbEnd
        '
        Me.cbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnd.FormattingEnabled = True
        Me.cbEnd.Items.AddRange(New Object() {"@gmail.com", "@yahoo.com", "@yahoo.co.uk", "@ymail.com", "@hotmail.com"})
        Me.cbEnd.Location = New System.Drawing.Point(351, 20)
        Me.cbEnd.Name = "cbEnd"
        Me.cbEnd.Size = New System.Drawing.Size(121, 23)
        Me.cbEnd.TabIndex = 28
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrFont, Me.ToolStripSeparator4, Me.tbrLeft, Me.tbrCenter, Me.tbrRight, Me.ToolStripSeparator2, Me.tbrBold, Me.tbrItalic, Me.tbrUnderline, Me.ToolStripSeparator3, Me.tbrOpen})
        Me.ToolStrip1.Location = New System.Drawing.Point(113, 203)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(214, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Mesaj:"
        '
        'tbSubject
        '
        Me.tbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubject.Location = New System.Drawing.Point(113, 113)
        Me.tbSubject.Multiline = True
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(626, 28)
        Me.tbSubject.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Konu:"
        '
        'tbCc
        '
        Me.tbCc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbCc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCc.Location = New System.Drawing.Point(113, 67)
        Me.tbCc.Multiline = True
        Me.tbCc.Name = "tbCc"
        Me.tbCc.Size = New System.Drawing.Size(232, 21)
        Me.tbCc.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cc:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbluserend)
        Me.GroupBox1.Controls.Add(Me.lblerroruser)
        Me.GroupBox1.Controls.Add(Me.tbUname)
        Me.GroupBox1.Controls.Add(Me.tbPass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 86)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gönderici Detayları"
        '
        'lbluserend
        '
        Me.lbluserend.Location = New System.Drawing.Point(264, 25)
        Me.lbluserend.Name = "lbluserend"
        Me.lbluserend.Size = New System.Drawing.Size(105, 22)
        Me.lbluserend.TabIndex = 22
        Me.lbluserend.Text = "@gmail.com"
        '
        'lblerroruser
        '
        Me.lblerroruser.AutoSize = True
        Me.lblerroruser.ForeColor = System.Drawing.Color.Yellow
        Me.lblerroruser.Location = New System.Drawing.Point(268, 56)
        Me.lblerroruser.Name = "lblerroruser"
        Me.lblerroruser.Size = New System.Drawing.Size(41, 15)
        Me.lblerroruser.TabIndex = 21
        Me.lblerroruser.Text = "Şifre:"
        Me.lblerroruser.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Şifre:"
        '
        'tbTo
        '
        Me.tbTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTo.Location = New System.Drawing.Point(113, 20)
        Me.tbTo.Multiline = True
        Me.tbTo.Name = "tbTo"
        Me.tbTo.Size = New System.Drawing.Size(232, 21)
        Me.tbTo.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblerrorccend)
        Me.GroupBox2.Controls.Add(Me.lblerrortoend)
        Me.GroupBox2.Controls.Add(Me.lblerrorsubject)
        Me.GroupBox2.Controls.Add(Me.lblerrorcc)
        Me.GroupBox2.Controls.Add(Me.lblerrorto)
        Me.GroupBox2.Controls.Add(Me.lblAttach)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbEndcc)
        Me.GroupBox2.Controls.Add(Me.cbEnd)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Controls.Add(Me.tbBody)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbSubject)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbCc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbTo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 422)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alıcı Detayları"
        '
        'tbBody
        '
        Me.tbBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBody.Location = New System.Drawing.Point(113, 227)
        Me.tbBody.Name = "tbBody"
        Me.tbBody.Size = New System.Drawing.Size(626, 177)
        Me.tbBody.TabIndex = 26
        Me.tbBody.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Balaban_G_mail.My.Resources.Resources.EGSbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 621)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balaban G-Mail"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbrFont As ToolStripButton
    Friend WithEvents lblerrorccend As Label
    Friend WithEvents lblerrortoend As Label
    Friend WithEvents lblerrorsubject As Label
    Friend WithEvents lblerrorcc As Label
    Friend WithEvents lblerrorto As Label
    Friend WithEvents lblAttach As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbrLeft As ToolStripButton
    Friend WithEvents tbrCenter As ToolStripButton
    Friend WithEvents tbrRight As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tbrItalic As ToolStripButton
    Friend WithEvents tbrUnderline As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tbrOpen As ToolStripButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents TimerProgressbar As Timer
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents tbrBold As ToolStripButton
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents cbEndcc As ComboBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Timerdate As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents niEGS As NotifyIcon
    Friend WithEvents btnClear As Button
    Friend WithEvents tbUname As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbEnd As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSubject As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbluserend As Label
    Friend WithEvents lblerroruser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbBody As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
