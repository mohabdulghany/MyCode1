<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.MainScreen_FolderSelect_Dlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.folder_txt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.list_menu = New System.Windows.Forms.MenuStrip()
        Me.xmlViewer = New System.Windows.Forms.WebBrowser()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.articleTitle = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(12, 94)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(580, 619)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.folder_txt)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 61)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(444, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Working Folder"
        '
        'folder_txt
        '
        Me.folder_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folder_txt.Location = New System.Drawing.Point(128, 14)
        Me.folder_txt.Name = "folder_txt"
        Me.folder_txt.Size = New System.Drawing.Size(310, 26)
        Me.folder_txt.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1082, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(218, 77)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Process Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'list_menu
        '
        Me.list_menu.Location = New System.Drawing.Point(0, 0)
        Me.list_menu.Name = "list_menu"
        Me.list_menu.Size = New System.Drawing.Size(1312, 24)
        Me.list_menu.TabIndex = 6
        Me.list_menu.Text = "Delete"
        '
        'xmlViewer
        '
        Me.xmlViewer.Location = New System.Drawing.Point(598, 27)
        Me.xmlViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.xmlViewer.Name = "xmlViewer"
        Me.xmlViewer.Size = New System.Drawing.Size(714, 443)
        Me.xmlViewer.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"one", "two", "three"})
        Me.ListBox1.Location = New System.Drawing.Point(1171, 350)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(105, 43)
        Me.ListBox1.TabIndex = 5
        '
        'articleTitle
        '
        Me.articleTitle.Location = New System.Drawing.Point(598, 491)
        Me.articleTitle.Multiline = True
        Me.articleTitle.Name = "articleTitle"
        Me.articleTitle.Size = New System.Drawing.Size(457, 77)
        Me.articleTitle.TabIndex = 8
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 725)
        Me.Controls.Add(Me.articleTitle)
        Me.Controls.Add(Me.xmlViewer)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.list_menu)
        Me.MainMenuStrip = Me.list_menu
        Me.Name = "MainScreen"
        Me.Text = "NewsPress_XmlUtility"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainScreen_FolderSelect_Dlg As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents folder_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents list_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents xmlViewer As WebBrowser
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents articleTitle As TextBox
End Class
