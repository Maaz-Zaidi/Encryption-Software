<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWriteFileWithArray
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtFileContents = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAndStoreIntoArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreIntoArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CipherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodeNegOneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeNegOneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaeserCipherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodeCaeserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeCaeserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranspositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableYieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodeDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeYieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontSize1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontSize1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrikeoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtFileContents
        '
        Me.txtFileContents.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtFileContents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFileContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFileContents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileContents.ForeColor = System.Drawing.Color.White
        Me.txtFileContents.Location = New System.Drawing.Point(0, 24)
        Me.txtFileContents.Multiline = True
        Me.txtFileContents.Name = "txtFileContents"
        Me.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileContents.Size = New System.Drawing.Size(855, 496)
        Me.txtFileContents.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ArrayToolStripMenuItem, Me.CipherToolStripMenuItem, Me.CaeserCipherToolStripMenuItem, Me.TranspositionToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(855, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAndStoreIntoArrayToolStripMenuItem, Me.StoreIntoArrayToolStripMenuItem, Me.SortArrayToolStripMenuItem, Me.DisplayArrayToolStripMenuItem, Me.SearchArrayToolStripMenuItem, Me.HelpToolStripMenuItem3})
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ArrayToolStripMenuItem.Text = "Array"
        '
        'OpenAndStoreIntoArrayToolStripMenuItem
        '
        Me.OpenAndStoreIntoArrayToolStripMenuItem.Name = "OpenAndStoreIntoArrayToolStripMenuItem"
        Me.OpenAndStoreIntoArrayToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.OpenAndStoreIntoArrayToolStripMenuItem.Text = "Open and Store into Array"
        '
        'StoreIntoArrayToolStripMenuItem
        '
        Me.StoreIntoArrayToolStripMenuItem.Name = "StoreIntoArrayToolStripMenuItem"
        Me.StoreIntoArrayToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.StoreIntoArrayToolStripMenuItem.Text = "Store (Current) into Array"
        '
        'SortArrayToolStripMenuItem
        '
        Me.SortArrayToolStripMenuItem.Name = "SortArrayToolStripMenuItem"
        Me.SortArrayToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SortArrayToolStripMenuItem.Text = "Sort Array"
        '
        'DisplayArrayToolStripMenuItem
        '
        Me.DisplayArrayToolStripMenuItem.Name = "DisplayArrayToolStripMenuItem"
        Me.DisplayArrayToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DisplayArrayToolStripMenuItem.Text = "Display Array"
        '
        'SearchArrayToolStripMenuItem
        '
        Me.SearchArrayToolStripMenuItem.Name = "SearchArrayToolStripMenuItem"
        Me.SearchArrayToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearchArrayToolStripMenuItem.Text = "Search Array"
        '
        'HelpToolStripMenuItem3
        '
        Me.HelpToolStripMenuItem3.Name = "HelpToolStripMenuItem3"
        Me.HelpToolStripMenuItem3.Size = New System.Drawing.Size(211, 22)
        Me.HelpToolStripMenuItem3.Text = "Help"
        '
        'CipherToolStripMenuItem
        '
        Me.CipherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncodeNegOneToolStripMenuItem, Me.DecodeNegOneToolStripMenuItem, Me.HelpToolStripMenuItem2})
        Me.CipherToolStripMenuItem.Name = "CipherToolStripMenuItem"
        Me.CipherToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CipherToolStripMenuItem.Text = "(-1) Cipher"
        '
        'EncodeNegOneToolStripMenuItem
        '
        Me.EncodeNegOneToolStripMenuItem.Name = "EncodeNegOneToolStripMenuItem"
        Me.EncodeNegOneToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EncodeNegOneToolStripMenuItem.Text = "Encode NegOne"
        '
        'DecodeNegOneToolStripMenuItem
        '
        Me.DecodeNegOneToolStripMenuItem.Name = "DecodeNegOneToolStripMenuItem"
        Me.DecodeNegOneToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DecodeNegOneToolStripMenuItem.Text = "Decode NegOne"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.HelpToolStripMenuItem2.Text = "Help"
        '
        'CaeserCipherToolStripMenuItem
        '
        Me.CaeserCipherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncodeCaeserToolStripMenuItem, Me.DecodeCaeserToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.CaeserCipherToolStripMenuItem.Name = "CaeserCipherToolStripMenuItem"
        Me.CaeserCipherToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CaeserCipherToolStripMenuItem.Text = "Caeser Cipher"
        '
        'EncodeCaeserToolStripMenuItem
        '
        Me.EncodeCaeserToolStripMenuItem.Name = "EncodeCaeserToolStripMenuItem"
        Me.EncodeCaeserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EncodeCaeserToolStripMenuItem.Text = "Encode Caeser"
        '
        'DecodeCaeserToolStripMenuItem
        '
        Me.DecodeCaeserToolStripMenuItem.Name = "DecodeCaeserToolStripMenuItem"
        Me.DecodeCaeserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DecodeCaeserToolStripMenuItem.Text = "Decode Caeser"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'TranspositionToolStripMenuItem
        '
        Me.TranspositionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableYieldToolStripMenuItem, Me.EncodeDefaultToolStripMenuItem, Me.DecodeYieldToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TranspositionToolStripMenuItem.Name = "TranspositionToolStripMenuItem"
        Me.TranspositionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.TranspositionToolStripMenuItem.Text = "Transposition"
        '
        'TableYieldToolStripMenuItem
        '
        Me.TableYieldToolStripMenuItem.Name = "TableYieldToolStripMenuItem"
        Me.TableYieldToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TableYieldToolStripMenuItem.Text = "Table Yield (n)"
        '
        'EncodeDefaultToolStripMenuItem
        '
        Me.EncodeDefaultToolStripMenuItem.Name = "EncodeDefaultToolStripMenuItem"
        Me.EncodeDefaultToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EncodeDefaultToolStripMenuItem.Text = "Encode Default"
        '
        'DecodeYieldToolStripMenuItem
        '
        Me.DecodeYieldToolStripMenuItem.Name = "DecodeYieldToolStripMenuItem"
        Me.DecodeYieldToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DecodeYieldToolStripMenuItem.Text = "Decode Yield"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontSize1ToolStripMenuItem, Me.FontSize1ToolStripMenuItem1, Me.FontStyleToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'FontSize1ToolStripMenuItem
        '
        Me.FontSize1ToolStripMenuItem.Name = "FontSize1ToolStripMenuItem"
        Me.FontSize1ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.FontSize1ToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.FontSize1ToolStripMenuItem.Text = "Font Size 1+"
        '
        'FontSize1ToolStripMenuItem1
        '
        Me.FontSize1ToolStripMenuItem1.Name = "FontSize1ToolStripMenuItem1"
        Me.FontSize1ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.FontSize1ToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.FontSize1ToolStripMenuItem1.Text = "Font Size 1-"
        '
        'FontStyleToolStripMenuItem
        '
        Me.FontStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.BoldToolStripMenuItem, Me.ItalicsToolStripMenuItem, Me.StrikeoutToolStripMenuItem})
        Me.FontStyleToolStripMenuItem.Name = "FontStyleToolStripMenuItem"
        Me.FontStyleToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.FontStyleToolStripMenuItem.Text = "Font Style"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'ItalicsToolStripMenuItem
        '
        Me.ItalicsToolStripMenuItem.Name = "ItalicsToolStripMenuItem"
        Me.ItalicsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ItalicsToolStripMenuItem.Text = "Italics"
        '
        'StrikeoutToolStripMenuItem
        '
        Me.StrikeoutToolStripMenuItem.Name = "StrikeoutToolStripMenuItem"
        Me.StrikeoutToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StrikeoutToolStripMenuItem.Text = "Strikeout"
        '
        'frmWriteFileWithArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 520)
        Me.Controls.Add(Me.txtFileContents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "frmWriteFileWithArray"
        Me.Text = "Encryption Software"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtFileContents As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAndStoreIntoArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CipherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncodeNegOneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecodeNegOneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaeserCipherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncodeCaeserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecodeCaeserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranspositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableYieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncodeDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecodeYieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StoreIntoArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontSize1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontSize1ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrikeoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
