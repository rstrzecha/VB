<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.lstColumns = New System.Windows.Forms.ListBox()
        Me.txt_marka = New System.Windows.Forms.TextBox()
        Me.txt_nb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_silnik = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_kolor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cena = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_metalic = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txt_link = New System.Windows.Forms.TextBox()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_change
        '
        Me.btn_change.Location = New System.Drawing.Point(138, 211)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(75, 23)
        Me.btn_change.TabIndex = 2
        Me.btn_change.Text = "Zmień"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(129, 290)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(80, 20)
        Me.txt_model.TabIndex = 3
        '
        'lstColumns
        '
        Me.lstColumns.FormattingEnabled = True
        Me.lstColumns.Location = New System.Drawing.Point(12, 168)
        Me.lstColumns.Name = "lstColumns"
        Me.lstColumns.Size = New System.Drawing.Size(120, 95)
        Me.lstColumns.TabIndex = 4
        '
        'txt_marka
        '
        Me.txt_marka.Location = New System.Drawing.Point(43, 290)
        Me.txt_marka.Name = "txt_marka"
        Me.txt_marka.Size = New System.Drawing.Size(80, 20)
        Me.txt_marka.TabIndex = 5
        '
        'txt_nb
        '
        Me.txt_nb.Location = New System.Drawing.Point(6, 290)
        Me.txt_nb.Name = "txt_nb"
        Me.txt_nb.Size = New System.Drawing.Size(32, 20)
        Me.txt_nb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "rekord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "marka"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "silnik"
        '
        'txt_silnik
        '
        Me.txt_silnik.Location = New System.Drawing.Point(215, 290)
        Me.txt_silnik.Name = "txt_silnik"
        Me.txt_silnik.Size = New System.Drawing.Size(80, 20)
        Me.txt_silnik.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "kolor"
        '
        'txt_kolor
        '
        Me.txt_kolor.Location = New System.Drawing.Point(299, 290)
        Me.txt_kolor.Name = "txt_kolor"
        Me.txt_kolor.Size = New System.Drawing.Size(80, 20)
        Me.txt_kolor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "cena"
        '
        'txt_cena
        '
        Me.txt_cena.Location = New System.Drawing.Point(421, 290)
        Me.txt_cena.Name = "txt_cena"
        Me.txt_cena.Size = New System.Drawing.Size(53, 20)
        Me.txt_cena.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(381, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "metalic"
        '
        'txt_metalic
        '
        Me.txt_metalic.Location = New System.Drawing.Point(382, 290)
        Me.txt_metalic.Name = "txt_metalic"
        Me.txt_metalic.Size = New System.Drawing.Size(36, 20)
        Me.txt_metalic.TabIndex = 16
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(525, 276)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(23, 13)
        Me.label8.TabIndex = 19
        Me.label8.Text = "link"
        '
        'txt_link
        '
        Me.txt_link.Location = New System.Drawing.Point(479, 290)
        Me.txt_link.Name = "txt_link"
        Me.txt_link.Size = New System.Drawing.Size(117, 20)
        Me.txt_link.TabIndex = 18
        '
        'btn_last
        '
        Me.btn_last.Location = New System.Drawing.Point(287, 240)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(30, 23)
        Me.btn_last.TabIndex = 20
        Me.btn_last.Text = ">>"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Location = New System.Drawing.Point(179, 240)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(30, 23)
        Me.btn_first.TabIndex = 21
        Me.btn_first.Text = "<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_previous
        '
        Me.btn_previous.Location = New System.Drawing.Point(215, 240)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(30, 23)
        Me.btn_previous.TabIndex = 22
        Me.btn_previous.Text = "<"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(251, 240)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(30, 23)
        Me.btn_next.TabIndex = 23
        Me.btn_next.Text = ">"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(215, 211)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 24
        Me.btn_add.Text = "Dodaj"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(296, 211)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 25
        Me.btn_delete.Text = "Usuń"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 331)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_previous)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txt_link)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_metalic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cena)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_kolor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_silnik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nb)
        Me.Controls.Add(Me.txt_marka)
        Me.Controls.Add(Me.lstColumns)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "admin"
        Me.Text = "Administracja"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_change As Button
    Friend WithEvents txt_model As TextBox
    Friend WithEvents lstColumns As ListBox
    Friend WithEvents txt_marka As TextBox
    Friend WithEvents txt_nb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_silnik As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_kolor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cena As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_metalic As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents txt_link As TextBox
    Friend WithEvents btn_last As Button
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_previous As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
End Class
