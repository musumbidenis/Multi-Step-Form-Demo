<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.login = New System.Windows.Forms.TabPage()
        Me.btnNext = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTextBox4 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTextBox3 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTextBox2 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.profile = New System.Windows.Forms.TabPage()
        Me.academic = New System.Windows.Forms.TabPage()
        Me.finish = New System.Windows.Forms.TabPage()
        Me.c1 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCheckBox1 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCheckBox2 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCheckBox3 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuPages1.SuspendLayout()
        Me.login.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.Controls.Add(Me.login)
        Me.BunifuPages1.Controls.Add(Me.profile)
        Me.BunifuPages1.Controls.Add(Me.academic)
        Me.BunifuPages1.Controls.Add(Me.finish)
        Me.BunifuPages1.Location = New System.Drawing.Point(47, 136)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(748, 346)
        Me.BunifuPages1.TabIndex = 0
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.White
        Me.login.Controls.Add(Me.btnNext)
        Me.login.Controls.Add(Me.BunifuCustomLabel8)
        Me.login.Controls.Add(Me.BunifuTextBox4)
        Me.login.Controls.Add(Me.BunifuCustomLabel7)
        Me.login.Controls.Add(Me.BunifuTextBox3)
        Me.login.Controls.Add(Me.BunifuCustomLabel6)
        Me.login.Controls.Add(Me.BunifuTextBox2)
        Me.login.Controls.Add(Me.BunifuCustomLabel5)
        Me.login.Controls.Add(Me.BunifuTextBox1)
        Me.login.Location = New System.Drawing.Point(4, 4)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(740, 320)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.ButtonText = "Next"
        Me.btnNext.ButtonTextMarginLeft = 0
        Me.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnNext.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnNext.DisabledForecolor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnNext.IconPadding = 10
        Me.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnNext.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnNext.IdleBorderRadius = 35
        Me.btnNext.IdleBorderThickness = 0
        Me.btnNext.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnNext.IdleIconLeftImage = Nothing
        Me.btnNext.IdleIconRightImage = Nothing
        Me.btnNext.Location = New System.Drawing.Point(309, 252)
        Me.btnNext.Name = "btnNext"
        StateProperties1.BorderColor = System.Drawing.Color.DarkViolet
        StateProperties1.BorderRadius = 35
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.DarkViolet
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnNext.onHoverState = StateProperties1
        Me.btnNext.Size = New System.Drawing.Size(122, 35)
        Me.btnNext.TabIndex = 24
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(411, 92)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(158, 23)
        Me.BunifuCustomLabel8.TabIndex = 23
        Me.BunifuCustomLabel8.Text = "Re-enter password"
        '
        'BunifuTextBox4
        '
        Me.BunifuTextBox4.AcceptsReturn = False
        Me.BunifuTextBox4.AcceptsTab = False
        Me.BunifuTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox4.BackgroundImage = CType(resources.GetObject("BunifuTextBox4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox4.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox4.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox4.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox4.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox4.BorderRadius = 35
        Me.BunifuTextBox4.BorderThickness = 1
        Me.BunifuTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox4.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox4.DefaultText = ""
        Me.BunifuTextBox4.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox4.HideSelection = True
        Me.BunifuTextBox4.IconLeft = Nothing
        Me.BunifuTextBox4.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox4.IconPadding = 10
        Me.BunifuTextBox4.IconRight = Nothing
        Me.BunifuTextBox4.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox4.Location = New System.Drawing.Point(407, 126)
        Me.BunifuTextBox4.MaxLength = 32767
        Me.BunifuTextBox4.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox4.Modified = False
        Me.BunifuTextBox4.Name = "BunifuTextBox4"
        Me.BunifuTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BunifuTextBox4.ReadOnly = False
        Me.BunifuTextBox4.SelectedText = ""
        Me.BunifuTextBox4.SelectionLength = 0
        Me.BunifuTextBox4.SelectionStart = 0
        Me.BunifuTextBox4.ShortcutsEnabled = True
        Me.BunifuTextBox4.Size = New System.Drawing.Size(216, 35)
        Me.BunifuTextBox4.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox4.TabIndex = 22
        Me.BunifuTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox4.TextMarginLeft = 5
        Me.BunifuTextBox4.TextPlaceholder = ""
        Me.BunifuTextBox4.UseSystemPasswordChar = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(122, 92)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(130, 23)
        Me.BunifuCustomLabel7.TabIndex = 21
        Me.BunifuCustomLabel7.Text = "Enter password"
        '
        'BunifuTextBox3
        '
        Me.BunifuTextBox3.AcceptsReturn = False
        Me.BunifuTextBox3.AcceptsTab = False
        Me.BunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox3.BackgroundImage = CType(resources.GetObject("BunifuTextBox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox3.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox3.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox3.BorderRadius = 35
        Me.BunifuTextBox3.BorderThickness = 1
        Me.BunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox3.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox3.DefaultText = ""
        Me.BunifuTextBox3.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox3.HideSelection = True
        Me.BunifuTextBox3.IconLeft = Nothing
        Me.BunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox3.IconPadding = 10
        Me.BunifuTextBox3.IconRight = Nothing
        Me.BunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox3.Location = New System.Drawing.Point(118, 126)
        Me.BunifuTextBox3.MaxLength = 32767
        Me.BunifuTextBox3.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox3.Modified = False
        Me.BunifuTextBox3.Name = "BunifuTextBox3"
        Me.BunifuTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BunifuTextBox3.ReadOnly = False
        Me.BunifuTextBox3.SelectedText = ""
        Me.BunifuTextBox3.SelectionLength = 0
        Me.BunifuTextBox3.SelectionStart = 0
        Me.BunifuTextBox3.ShortcutsEnabled = True
        Me.BunifuTextBox3.Size = New System.Drawing.Size(216, 35)
        Me.BunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox3.TabIndex = 20
        Me.BunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox3.TextMarginLeft = 5
        Me.BunifuTextBox3.TextPlaceholder = ""
        Me.BunifuTextBox3.UseSystemPasswordChar = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(411, 11)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(98, 23)
        Me.BunifuCustomLabel6.TabIndex = 19
        Me.BunifuCustomLabel6.Text = "Enter email"
        '
        'BunifuTextBox2
        '
        Me.BunifuTextBox2.AcceptsReturn = False
        Me.BunifuTextBox2.AcceptsTab = False
        Me.BunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox2.BackgroundImage = CType(resources.GetObject("BunifuTextBox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox2.BorderRadius = 35
        Me.BunifuTextBox2.BorderThickness = 1
        Me.BunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox2.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox2.DefaultText = ""
        Me.BunifuTextBox2.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox2.HideSelection = True
        Me.BunifuTextBox2.IconLeft = Nothing
        Me.BunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox2.IconPadding = 10
        Me.BunifuTextBox2.IconRight = Nothing
        Me.BunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox2.Location = New System.Drawing.Point(407, 45)
        Me.BunifuTextBox2.MaxLength = 32767
        Me.BunifuTextBox2.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox2.Modified = False
        Me.BunifuTextBox2.Name = "BunifuTextBox2"
        Me.BunifuTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox2.ReadOnly = False
        Me.BunifuTextBox2.SelectedText = ""
        Me.BunifuTextBox2.SelectionLength = 0
        Me.BunifuTextBox2.SelectionStart = 0
        Me.BunifuTextBox2.ShortcutsEnabled = True
        Me.BunifuTextBox2.Size = New System.Drawing.Size(216, 35)
        Me.BunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox2.TabIndex = 18
        Me.BunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox2.TextMarginLeft = 5
        Me.BunifuTextBox2.TextPlaceholder = ""
        Me.BunifuTextBox2.UseSystemPasswordChar = False
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(122, 11)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(131, 23)
        Me.BunifuCustomLabel5.TabIndex = 17
        Me.BunifuCustomLabel5.Text = "Enter username"
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox1.BorderRadius = 35
        Me.BunifuTextBox1.BorderThickness = 1
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Nothing
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox1.Location = New System.Drawing.Point(118, 45)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(216, 35)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 0
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginLeft = 5
        Me.BunifuTextBox1.TextPlaceholder = ""
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        '
        'profile
        '
        Me.profile.Location = New System.Drawing.Point(4, 4)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(740, 320)
        Me.profile.TabIndex = 1
        Me.profile.Text = "Profile"
        Me.profile.UseVisualStyleBackColor = True
        '
        'academic
        '
        Me.academic.Location = New System.Drawing.Point(4, 4)
        Me.academic.Name = "academic"
        Me.academic.Size = New System.Drawing.Size(740, 320)
        Me.academic.TabIndex = 2
        Me.academic.Text = "Academic"
        Me.academic.UseVisualStyleBackColor = True
        '
        'finish
        '
        Me.finish.Location = New System.Drawing.Point(4, 4)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(740, 320)
        Me.finish.TabIndex = 3
        Me.finish.Text = "finish"
        Me.finish.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.AllowBindingControlAnimation = True
        Me.c1.AllowBindingControlColorChanges = False
        Me.c1.AllowBindingControlLocation = True
        Me.c1.AllowCheckBoxAnimation = False
        Me.c1.AllowCheckmarkAnimation = True
        Me.c1.AllowOnHoverStates = True
        Me.c1.AutoCheck = False
        Me.c1.BackColor = System.Drawing.Color.Transparent
        Me.c1.BackgroundImage = CType(resources.GetObject("c1.BackgroundImage"), System.Drawing.Image)
        Me.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.c1.BindingControl = Nothing
        Me.c1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.c1.Checked = False
        Me.c1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.c1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.c1.CustomCheckmarkImage = Nothing
        Me.c1.Location = New System.Drawing.Point(155, 47)
        Me.c1.MinimumSize = New System.Drawing.Size(17, 17)
        Me.c1.Name = "c1"
        Me.c1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.c1.OnCheck.BorderRadius = 17
        Me.c1.OnCheck.BorderThickness = 1
        Me.c1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.c1.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.c1.OnCheck.CheckmarkThickness = 2
        Me.c1.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.c1.OnDisable.BorderRadius = 17
        Me.c1.OnDisable.BorderThickness = 1
        Me.c1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.c1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.c1.OnDisable.CheckmarkThickness = 2
        Me.c1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.c1.OnHoverChecked.BorderRadius = 17
        Me.c1.OnHoverChecked.BorderThickness = 1
        Me.c1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.c1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.c1.OnHoverChecked.CheckmarkThickness = 2
        Me.c1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.c1.OnHoverUnchecked.BorderRadius = 17
        Me.c1.OnHoverUnchecked.BorderThickness = 1
        Me.c1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.c1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.c1.OnUncheck.BorderRadius = 17
        Me.c1.OnUncheck.BorderThickness = 1
        Me.c1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.c1.Size = New System.Drawing.Size(21, 21)
        Me.c1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.c1.TabIndex = 5
        Me.c1.ThreeState = False
        Me.c1.ToolTipText = Nothing
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(176, 52)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCheckBox1
        '
        Me.BunifuCheckBox1.AllowBindingControlAnimation = True
        Me.BunifuCheckBox1.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox1.AllowBindingControlLocation = True
        Me.BunifuCheckBox1.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox1.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox1.AllowOnHoverStates = True
        Me.BunifuCheckBox1.AutoCheck = False
        Me.BunifuCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.BackgroundImage = CType(resources.GetObject("BunifuCheckBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox1.BindingControl = Nothing
        Me.BunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox1.Checked = False
        Me.BunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.BunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCheckBox1.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox1.Location = New System.Drawing.Point(324, 47)
        Me.BunifuCheckBox1.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox1.Name = "BunifuCheckBox1"
        Me.BunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox1.OnCheck.BorderRadius = 17
        Me.BunifuCheckBox1.OnCheck.BorderThickness = 1
        Me.BunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.BorderRadius = 17
        Me.BunifuCheckBox1.OnDisable.BorderThickness = 1
        Me.BunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.BorderRadius = 17
        Me.BunifuCheckBox1.OnHoverChecked.BorderThickness = 1
        Me.BunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderRadius = 17
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox1.OnUncheck.BorderRadius = 17
        Me.BunifuCheckBox1.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox1.TabIndex = 7
        Me.BunifuCheckBox1.ThreeState = False
        Me.BunifuCheckBox1.ToolTipText = Nothing
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(345, 52)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator2.TabIndex = 8
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCheckBox2
        '
        Me.BunifuCheckBox2.AllowBindingControlAnimation = True
        Me.BunifuCheckBox2.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox2.AllowBindingControlLocation = True
        Me.BunifuCheckBox2.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox2.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox2.AllowOnHoverStates = True
        Me.BunifuCheckBox2.AutoCheck = False
        Me.BunifuCheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.BackgroundImage = CType(resources.GetObject("BunifuCheckBox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox2.BindingControl = Nothing
        Me.BunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox2.Checked = False
        Me.BunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.BunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCheckBox2.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox2.Location = New System.Drawing.Point(494, 47)
        Me.BunifuCheckBox2.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox2.Name = "BunifuCheckBox2"
        Me.BunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox2.OnCheck.BorderRadius = 15
        Me.BunifuCheckBox2.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox2.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox2.OnDisable.BorderRadius = 15
        Me.BunifuCheckBox2.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox2.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverChecked.BorderRadius = 15
        Me.BunifuCheckBox2.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderRadius = 15
        Me.BunifuCheckBox2.OnHoverUnchecked.BorderThickness = 2
        Me.BunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox2.OnUncheck.BorderRadius = 15
        Me.BunifuCheckBox2.OnUncheck.BorderThickness = 2
        Me.BunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox2.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox2.TabIndex = 9
        Me.BunifuCheckBox2.ThreeState = False
        Me.BunifuCheckBox2.ToolTipText = Nothing
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(515, 52)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator3.TabIndex = 10
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuCheckBox3
        '
        Me.BunifuCheckBox3.AllowBindingControlAnimation = True
        Me.BunifuCheckBox3.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox3.AllowBindingControlLocation = True
        Me.BunifuCheckBox3.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox3.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox3.AllowOnHoverStates = True
        Me.BunifuCheckBox3.AutoCheck = False
        Me.BunifuCheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.BackgroundImage = CType(resources.GetObject("BunifuCheckBox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox3.BindingControl = Nothing
        Me.BunifuCheckBox3.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox3.Checked = False
        Me.BunifuCheckBox3.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.BunifuCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCheckBox3.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox3.Location = New System.Drawing.Point(666, 47)
        Me.BunifuCheckBox3.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox3.Name = "BunifuCheckBox3"
        Me.BunifuCheckBox3.OnCheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox3.OnCheck.BorderRadius = 15
        Me.BunifuCheckBox3.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox3.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox3.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox3.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox3.OnDisable.BorderRadius = 15
        Me.BunifuCheckBox3.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox3.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox3.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverChecked.BorderRadius = 15
        Me.BunifuCheckBox3.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox3.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox3.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderRadius = 15
        Me.BunifuCheckBox3.OnHoverUnchecked.BorderThickness = 2
        Me.BunifuCheckBox3.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BunifuCheckBox3.OnUncheck.BorderRadius = 15
        Me.BunifuCheckBox3.OnUncheck.BorderThickness = 2
        Me.BunifuCheckBox3.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox3.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox3.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox3.TabIndex = 11
        Me.BunifuCheckBox3.ThreeState = False
        Me.BunifuCheckBox3.ToolTipText = Nothing
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(96, 107)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(651, 35)
        Me.BunifuSeparator4.TabIndex = 12
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(140, 81)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(64, 23)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Step 1"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(647, 81)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(64, 23)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Step 4"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(472, 81)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(64, 23)
        Me.BunifuCustomLabel3.TabIndex = 15
        Me.BunifuCustomLabel3.Text = "Step 3"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(303, 81)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(64, 23)
        Me.BunifuCustomLabel4.TabIndex = 16
        Me.BunifuCustomLabel4.Text = "Step 2"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(788, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 26)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 17
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 529)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.BunifuCheckBox3)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.BunifuCheckBox2)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCheckBox1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.BunifuPages1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.Text = "Student"
        Me.BunifuPages1.ResumeLayout(False)
        Me.login.ResumeLayout(False)
        Me.login.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents c1 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCheckBox1 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCheckBox2 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCheckBox3 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents login As TabPage
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents profile As TabPage
    Friend WithEvents academic As TabPage
    Friend WithEvents finish As TabPage
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTextBox4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTextBox3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTextBox2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnNext As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
End Class
