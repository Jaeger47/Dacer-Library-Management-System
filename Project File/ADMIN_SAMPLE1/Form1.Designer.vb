<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListBook = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnListIssue = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnListMember = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.workAreaPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1121, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(24, 24)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 40
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(937, 110)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(213, 600)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(937, 30)
        Me.Panel4.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Admin"
        '
        'btnListBook
        '
        Me.btnListBook.Activecolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListBook.BackColor = System.Drawing.Color.White
        Me.btnListBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListBook.BorderRadius = 0
        Me.btnListBook.ButtonText = "Books"
        Me.btnListBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListBook.DisabledColor = System.Drawing.Color.Gray
        Me.btnListBook.Iconcolor = System.Drawing.Color.Transparent
        Me.btnListBook.Iconimage = CType(resources.GetObject("btnListBook.Iconimage"), System.Drawing.Image)
        Me.btnListBook.Iconimage_right = Nothing
        Me.btnListBook.Iconimage_right_Selected = Nothing
        Me.btnListBook.Iconimage_Selected = Nothing
        Me.btnListBook.IconMarginLeft = 0
        Me.btnListBook.IconMarginRight = 0
        Me.btnListBook.IconRightVisible = True
        Me.btnListBook.IconRightZoom = 0.0R
        Me.btnListBook.IconVisible = True
        Me.btnListBook.IconZoom = 50.0R
        Me.btnListBook.IsTab = False
        Me.btnListBook.Location = New System.Drawing.Point(0, 212)
        Me.btnListBook.Name = "btnListBook"
        Me.btnListBook.Normalcolor = System.Drawing.Color.White
        Me.btnListBook.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListBook.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListBook.selected = False
        Me.btnListBook.Size = New System.Drawing.Size(212, 41)
        Me.btnListBook.TabIndex = 2
        Me.btnListBook.Text = "Books"
        Me.btnListBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnListBook.Textcolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListBook.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnListIssue
        '
        Me.btnListIssue.Activecolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListIssue.BackColor = System.Drawing.Color.White
        Me.btnListIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListIssue.BorderRadius = 0
        Me.btnListIssue.ButtonText = "Issued Books"
        Me.btnListIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListIssue.DisabledColor = System.Drawing.Color.Gray
        Me.btnListIssue.Iconcolor = System.Drawing.Color.Transparent
        Me.btnListIssue.Iconimage = CType(resources.GetObject("btnListIssue.Iconimage"), System.Drawing.Image)
        Me.btnListIssue.Iconimage_right = Nothing
        Me.btnListIssue.Iconimage_right_Selected = Nothing
        Me.btnListIssue.Iconimage_Selected = Nothing
        Me.btnListIssue.IconMarginLeft = 0
        Me.btnListIssue.IconMarginRight = 0
        Me.btnListIssue.IconRightVisible = True
        Me.btnListIssue.IconRightZoom = 0.0R
        Me.btnListIssue.IconVisible = True
        Me.btnListIssue.IconZoom = 50.0R
        Me.btnListIssue.IsTab = False
        Me.btnListIssue.Location = New System.Drawing.Point(0, 268)
        Me.btnListIssue.Name = "btnListIssue"
        Me.btnListIssue.Normalcolor = System.Drawing.Color.White
        Me.btnListIssue.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListIssue.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListIssue.selected = False
        Me.btnListIssue.Size = New System.Drawing.Size(212, 41)
        Me.btnListIssue.TabIndex = 7
        Me.btnListIssue.Text = "Issued Books"
        Me.btnListIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnListIssue.Textcolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListIssue.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnListMember
        '
        Me.btnListMember.Activecolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListMember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListMember.BackColor = System.Drawing.Color.White
        Me.btnListMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListMember.BorderRadius = 0
        Me.btnListMember.ButtonText = "Members"
        Me.btnListMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListMember.DisabledColor = System.Drawing.Color.Gray
        Me.btnListMember.Iconcolor = System.Drawing.Color.Transparent
        Me.btnListMember.Iconimage = CType(resources.GetObject("btnListMember.Iconimage"), System.Drawing.Image)
        Me.btnListMember.Iconimage_right = Nothing
        Me.btnListMember.Iconimage_right_Selected = Nothing
        Me.btnListMember.Iconimage_Selected = Nothing
        Me.btnListMember.IconMarginLeft = 0
        Me.btnListMember.IconMarginRight = 0
        Me.btnListMember.IconRightVisible = True
        Me.btnListMember.IconRightZoom = 0.0R
        Me.btnListMember.IconVisible = True
        Me.btnListMember.IconZoom = 50.0R
        Me.btnListMember.IsTab = False
        Me.btnListMember.Location = New System.Drawing.Point(0, 324)
        Me.btnListMember.Name = "btnListMember"
        Me.btnListMember.Normalcolor = System.Drawing.Color.White
        Me.btnListMember.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListMember.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListMember.selected = False
        Me.btnListMember.Size = New System.Drawing.Size(212, 41)
        Me.btnListMember.TabIndex = 8
        Me.btnListMember.Text = "Members"
        Me.btnListMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnListMember.Textcolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnListMember.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Manual"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 482)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(212, 41)
        Me.BunifuFlatButton1.TabIndex = 9
        Me.BunifuFlatButton1.Text = "Manual"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel2.Controls.Add(Me.btnListMember)
        Me.Panel2.Controls.Add(Me.btnListIssue)
        Me.Panel2.Controls.Add(Me.btnListBook)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 596)
        Me.Panel2.TabIndex = 1
        '
        'workAreaPanel
        '
        Me.workAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.workAreaPanel.Location = New System.Drawing.Point(213, 144)
        Me.workAreaPanel.Name = "workAreaPanel"
        Me.workAreaPanel.Size = New System.Drawing.Size(937, 456)
        Me.workAreaPanel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1150, 34)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 630)
        Me.Controls.Add(Me.workAreaPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1150, 630)
        Me.MinimumSize = New System.Drawing.Size(1150, 630)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnListBook As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnListIssue As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnListMember As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents workAreaPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
