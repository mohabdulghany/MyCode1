Imports System.Xml
Imports System.IO


Public Class MainScreen


    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.AllowDrop = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
   
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
        '    folder_txt.Text = FolderBrowserDialog.SelectedPath
        '    folder_txt.Text = "F:\Working\XML-APP\src\website\2018-09-12\Anbaa"
        '    TreeView1.Nodes.Add(FolderBrowserDialog.SelectedPath)
        '    'Populate this root node
        '    PopulateTreeView(FolderBrowserDialog.SelectedPath, TreeView1.Nodes(0))

        'End If
        folder_txt.Text = "F:\Working\XML-APP\src\website\2018-09-12\Anbaa"
        TreeView1.Nodes.Add(FolderBrowserDialog.SelectedPath)
        'Populate this root node
        PopulateTreeView(FolderBrowserDialog.SelectedPath, TreeView1.Nodes(0))
    End Sub
    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        If (Directory.Exists(dir)) Then
            Dim folder As String = String.Empty
            Try
                'Add the files to treeview
                Dim files() As String = IO.Directory.GetFiles(dir)

                If files.Length <> 0 Then
                    Dim fileNode As TreeNode = Nothing
                    For Each file As String In files
                        Dim extension As String = IO.Path.GetExtension(file)
                        If extension = ".xml" Then
                            fileNode = parentNode.Nodes.Add(IO.Path.GetFileName(file))
                            fileNode.Tag = file
                        End If
                    Next
                End If
                'Add folders to treeview
                Dim folders() As String = IO.Directory.GetDirectories(dir)
                If folders.Length <> 0 Then
                    Dim folderNode As TreeNode = Nothing
                    Dim folderName As String = String.Empty
                    For Each folder In folders
                        folderName = IO.Path.GetFileName(folder)
                        folderNode = parentNode.Nodes.Add(folderName)
                        folderNode.Tag = folder
                        PopulateTreeView(folder, folderNode)
                    Next
                End If
            Catch ex As UnauthorizedAccessException
                parentNode.Nodes.Add("Access Denied")
            End Try
            TreeView1.ExpandAll()
        End If
    End Sub

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck

    End Sub

 

    Private Sub folder_txt_TextChanged(sender As Object, e As EventArgs) Handles folder_txt.TextChanged
        If (Directory.Exists(folder_txt.Text)) Then
            TreeView1.Nodes.Add(folder_txt.Text)
            'Populate this root node
            PopulateTreeView(folder_txt.Text, TreeView1.Nodes(0))
        End If
       
    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        ListBox1.Items.Insert(ListBox1.IndexFromPoint(ListBox1.PointToClient(New Point(e.X, e.Y))), e.Data.GetData(DataFormats.Text))
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

    End Sub

    Private Sub ListBox1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragOver
        e.Effect = DragDropEffects.Move

    End Sub


    Private Sub ListBox1_MouseDown(ByVal sender As Object,
  ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown

        ListBox1.DoDragDrop(ListBox1.Text, DragDropEffects.All)
        If e.Button = MouseButtons.Right Then
            Dim index As Integer = ListBox1.IndexFromPoint(New Point(e.X, e.Y))
            list_menu.Visible = True
            If index >= 0 Then
                ListBox1.SelectedItem = ListBox1.Items(index)
            End If
        End If
    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        '  Dim xmlDoc As XDocument = XDocument.Load("F:\\Working\\XML-APP\\src\\website\\2018-09-12\\Anbaa\\01\\453504.xml")
        If Not TreeView1.SelectedNode Is Nothing Then
            xmlViewer.Navigate(TreeView1.SelectedNode.FullPath)
            Dim ret As Article
            ret = readArticleFile(TreeView1.SelectedNode.FullPath)
            articleTitle.Text = ret.title

        End If
    End Sub
    Function readArticleFile(fname As String) As Article
        Dim articleData As Article = New Article()
        Dim m_xmlr As XmlTextReader
        m_xmlr = New XmlTextReader(fname)
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        While Not m_xmlr.EOF
            m_xmlr.Read()
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            m_xmlr.Read()
            articleData.title = m_xmlr.ReadElementString("title")
        End While
        m_xmlr.Close()
        Return articleData
    End Function
End Class
