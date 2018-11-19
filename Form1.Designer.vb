<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbViewer
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tabels_grp_box = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lstTabels = New System.Windows.Forms.ListBox()
        Me.btn_Open = New System.Windows.Forms.Button()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmb_marka = New System.Windows.Forms.ComboBox()
        Me.cmb_model = New System.Windows.Forms.ComboBox()
        Me.cmb_silnik = New System.Windows.Forms.ComboBox()
        Me.cmb_kolor = New System.Windows.Forms.ComboBox()
        Me.metalic = New System.Windows.Forms.CheckBox()
        Me.lbl_na = New System.Windows.Forms.Label()
        Me.lst_nb = New System.Windows.Forms.ListBox()
        Me.lst_marka = New System.Windows.Forms.ListBox()
        Me.lst_model = New System.Windows.Forms.ListBox()
        Me.lst_silnik = New System.Windows.Forms.ListBox()
        Me.lst_kolor = New System.Windows.Forms.ListBox()
        Me.lst_cena = New System.Windows.Forms.ListBox()
        Me.lbl_nb = New System.Windows.Forms.Label()
        Me.lbl_marka = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.lbl_silnik = New System.Windows.Forms.Label()
        Me.lbl_kolor = New System.Windows.Forms.Label()
        Me.lbl_cena = New System.Windows.Forms.Label()
        Me.lbl_marka1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbx_auto = New System.Windows.Forms.PictureBox()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_metalic = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tabels_grp_box.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbx_auto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabels_grp_box
        '
        Me.Tabels_grp_box.Controls.Add(Me.GroupBox1)
        Me.Tabels_grp_box.Controls.Add(Me.lstTabels)
        Me.Tabels_grp_box.Location = New System.Drawing.Point(12, 12)
        Me.Tabels_grp_box.Name = "Tabels_grp_box"
        Me.Tabels_grp_box.Size = New System.Drawing.Size(127, 70)
        Me.Tabels_grp_box.TabIndex = 2
        Me.Tabels_grp_box.TabStop = False
        Me.Tabels_grp_box.Text = "Wybór komisu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(156, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 235)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabele"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(135, 212)
        Me.ListBox1.TabIndex = 0
        '
        'lstTabels
        '
        Me.lstTabels.FormattingEnabled = True
        Me.lstTabels.Location = New System.Drawing.Point(6, 19)
        Me.lstTabels.Name = "lstTabels"
        Me.lstTabels.Size = New System.Drawing.Size(115, 43)
        Me.lstTabels.TabIndex = 0
        '
        'btn_Open
        '
        Me.btn_Open.Location = New System.Drawing.Point(21, 88)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(111, 23)
        Me.btn_Open.TabIndex = 3
        Me.btn_Open.Text = "Otwórz bazę"
        Me.btn_Open.UseVisualStyleBackColor = True
        '
        'btn_about
        '
        Me.btn_about.Location = New System.Drawing.Point(706, 12)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(37, 23)
        Me.btn_about.TabIndex = 4
        Me.btn_about.Text = "O..."
        Me.btn_about.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmb_marka
        '
        Me.cmb_marka.FormattingEnabled = True
        Me.cmb_marka.Location = New System.Drawing.Point(18, 134)
        Me.cmb_marka.Name = "cmb_marka"
        Me.cmb_marka.Size = New System.Drawing.Size(121, 21)
        Me.cmb_marka.TabIndex = 9
        '
        'cmb_model
        '
        Me.cmb_model.FormattingEnabled = True
        Me.cmb_model.Location = New System.Drawing.Point(18, 173)
        Me.cmb_model.Name = "cmb_model"
        Me.cmb_model.Size = New System.Drawing.Size(121, 21)
        Me.cmb_model.TabIndex = 10
        '
        'cmb_silnik
        '
        Me.cmb_silnik.FormattingEnabled = True
        Me.cmb_silnik.Location = New System.Drawing.Point(18, 213)
        Me.cmb_silnik.Name = "cmb_silnik"
        Me.cmb_silnik.Size = New System.Drawing.Size(121, 21)
        Me.cmb_silnik.TabIndex = 11
        '
        'cmb_kolor
        '
        Me.cmb_kolor.FormattingEnabled = True
        Me.cmb_kolor.Location = New System.Drawing.Point(18, 250)
        Me.cmb_kolor.Name = "cmb_kolor"
        Me.cmb_kolor.Size = New System.Drawing.Size(121, 21)
        Me.cmb_kolor.TabIndex = 12
        '
        'metalic
        '
        Me.metalic.AutoSize = True
        Me.metalic.Location = New System.Drawing.Point(147, 254)
        Me.metalic.Name = "metalic"
        Me.metalic.Size = New System.Drawing.Size(59, 17)
        Me.metalic.TabIndex = 13
        Me.metalic.Text = "metalic"
        Me.metalic.UseVisualStyleBackColor = True
        '
        'lbl_na
        '
        Me.lbl_na.AutoSize = True
        Me.lbl_na.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_na.Location = New System.Drawing.Point(18, 288)
        Me.lbl_na.Name = "lbl_na"
        Me.lbl_na.Size = New System.Drawing.Size(142, 13)
        Me.lbl_na.TabIndex = 14
        Me.lbl_na.Text = "Brak dostępnych modeli"
        Me.lbl_na.Visible = False
        '
        'lst_nb
        '
        Me.lst_nb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lst_nb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lst_nb.FormattingEnabled = True
        Me.lst_nb.Location = New System.Drawing.Point(219, 298)
        Me.lst_nb.Name = "lst_nb"
        Me.lst_nb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lst_nb.Size = New System.Drawing.Size(34, 69)
        Me.lst_nb.TabIndex = 16
        '
        'lst_marka
        '
        Me.lst_marka.FormattingEnabled = True
        Me.lst_marka.Location = New System.Drawing.Point(253, 298)
        Me.lst_marka.Name = "lst_marka"
        Me.lst_marka.Size = New System.Drawing.Size(85, 69)
        Me.lst_marka.TabIndex = 17
        '
        'lst_model
        '
        Me.lst_model.FormattingEnabled = True
        Me.lst_model.Location = New System.Drawing.Point(338, 298)
        Me.lst_model.Name = "lst_model"
        Me.lst_model.Size = New System.Drawing.Size(85, 69)
        Me.lst_model.TabIndex = 18
        '
        'lst_silnik
        '
        Me.lst_silnik.FormattingEnabled = True
        Me.lst_silnik.Location = New System.Drawing.Point(423, 298)
        Me.lst_silnik.Name = "lst_silnik"
        Me.lst_silnik.Size = New System.Drawing.Size(85, 69)
        Me.lst_silnik.TabIndex = 19
        '
        'lst_kolor
        '
        Me.lst_kolor.FormattingEnabled = True
        Me.lst_kolor.Location = New System.Drawing.Point(508, 298)
        Me.lst_kolor.Name = "lst_kolor"
        Me.lst_kolor.Size = New System.Drawing.Size(85, 69)
        Me.lst_kolor.TabIndex = 20
        '
        'lst_cena
        '
        Me.lst_cena.FormattingEnabled = True
        Me.lst_cena.Location = New System.Drawing.Point(628, 298)
        Me.lst_cena.Name = "lst_cena"
        Me.lst_cena.Size = New System.Drawing.Size(85, 69)
        Me.lst_cena.TabIndex = 21
        '
        'lbl_nb
        '
        Me.lbl_nb.AutoSize = True
        Me.lbl_nb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_nb.Location = New System.Drawing.Point(226, 282)
        Me.lbl_nb.Name = "lbl_nb"
        Me.lbl_nb.Size = New System.Drawing.Size(20, 13)
        Me.lbl_nb.TabIndex = 22
        Me.lbl_nb.Text = "Nr"
        '
        'lbl_marka
        '
        Me.lbl_marka.AutoSize = True
        Me.lbl_marka.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_marka.Location = New System.Drawing.Point(277, 282)
        Me.lbl_marka.Name = "lbl_marka"
        Me.lbl_marka.Size = New System.Drawing.Size(41, 13)
        Me.lbl_marka.TabIndex = 23
        Me.lbl_marka.Text = "marka"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_model.Location = New System.Drawing.Point(360, 282)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(40, 13)
        Me.lbl_model.TabIndex = 24
        Me.lbl_model.Text = "model"
        '
        'lbl_silnik
        '
        Me.lbl_silnik.AutoSize = True
        Me.lbl_silnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_silnik.Location = New System.Drawing.Point(444, 282)
        Me.lbl_silnik.Name = "lbl_silnik"
        Me.lbl_silnik.Size = New System.Drawing.Size(36, 13)
        Me.lbl_silnik.TabIndex = 25
        Me.lbl_silnik.Text = "silnik"
        '
        'lbl_kolor
        '
        Me.lbl_kolor.AutoSize = True
        Me.lbl_kolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_kolor.Location = New System.Drawing.Point(534, 282)
        Me.lbl_kolor.Name = "lbl_kolor"
        Me.lbl_kolor.Size = New System.Drawing.Size(35, 13)
        Me.lbl_kolor.TabIndex = 26
        Me.lbl_kolor.Text = "kolor"
        '
        'lbl_cena
        '
        Me.lbl_cena.AutoSize = True
        Me.lbl_cena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_cena.Location = New System.Drawing.Point(654, 282)
        Me.lbl_cena.Name = "lbl_cena"
        Me.lbl_cena.Size = New System.Drawing.Size(35, 13)
        Me.lbl_cena.TabIndex = 27
        Me.lbl_cena.Text = "cena"
        '
        'lbl_marka1
        '
        Me.lbl_marka1.AutoSize = True
        Me.lbl_marka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_marka1.Location = New System.Drawing.Point(15, 121)
        Me.lbl_marka1.Name = "lbl_marka1"
        Me.lbl_marka1.Size = New System.Drawing.Size(41, 13)
        Me.lbl_marka1.TabIndex = 28
        Me.lbl_marka1.Text = "marka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "silnik"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "kolor"
        '
        'pbx_auto
        '
        Me.pbx_auto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pbx_auto.Location = New System.Drawing.Point(256, 9)
        Me.pbx_auto.Name = "pbx_auto"
        Me.pbx_auto.Size = New System.Drawing.Size(320, 240)
        Me.pbx_auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_auto.TabIndex = 32
        Me.pbx_auto.TabStop = False
        '
        'btn_admin
        '
        Me.btn_admin.Location = New System.Drawing.Point(21, 320)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(111, 23)
        Me.btn_admin.TabIndex = 33
        Me.btn_admin.Text = "Administracja"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Wybierz numer ogłoszenia w celu jego wyświetlenia"
        '
        'lst_metalic
        '
        Me.lst_metalic.FormattingEnabled = True
        Me.lst_metalic.Location = New System.Drawing.Point(593, 298)
        Me.lst_metalic.Name = "lst_metalic"
        Me.lst_metalic.Size = New System.Drawing.Size(35, 69)
        Me.lst_metalic.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(587, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "metalic"
        '
        'dbViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 376)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lst_metalic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.pbx_auto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_marka1)
        Me.Controls.Add(Me.lbl_cena)
        Me.Controls.Add(Me.lbl_kolor)
        Me.Controls.Add(Me.lbl_silnik)
        Me.Controls.Add(Me.lbl_model)
        Me.Controls.Add(Me.lbl_marka)
        Me.Controls.Add(Me.lbl_nb)
        Me.Controls.Add(Me.lst_cena)
        Me.Controls.Add(Me.lst_kolor)
        Me.Controls.Add(Me.lst_silnik)
        Me.Controls.Add(Me.lst_model)
        Me.Controls.Add(Me.lst_marka)
        Me.Controls.Add(Me.lst_nb)
        Me.Controls.Add(Me.lbl_na)
        Me.Controls.Add(Me.metalic)
        Me.Controls.Add(Me.cmb_kolor)
        Me.Controls.Add(Me.cmb_silnik)
        Me.Controls.Add(Me.cmb_model)
        Me.Controls.Add(Me.cmb_marka)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.btn_Open)
        Me.Controls.Add(Me.Tabels_grp_box)
        Me.Name = "dbViewer"
        Me.Text = "Przeglądarka Komisów"
        Me.Tabels_grp_box.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbx_auto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tabels_grp_box As GroupBox
    Friend WithEvents lstTabels As ListBox
    Friend WithEvents btn_Open As Button
    Friend WithEvents btn_about As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cmb_marka As ComboBox
    Friend WithEvents cmb_model As ComboBox
    Friend WithEvents cmb_silnik As ComboBox
    Friend WithEvents cmb_kolor As ComboBox
    Friend WithEvents metalic As CheckBox
    Friend WithEvents lbl_na As Label
    Friend WithEvents lst_nb As ListBox
    Friend WithEvents lst_marka As ListBox
    Friend WithEvents lst_model As ListBox
    Friend WithEvents lst_silnik As ListBox
    Friend WithEvents lst_kolor As ListBox
    Friend WithEvents lst_cena As ListBox
    Friend WithEvents lbl_nb As Label
    Friend WithEvents lbl_marka As Label
    Friend WithEvents lbl_model As Label
    Friend WithEvents lbl_silnik As Label
    Friend WithEvents lbl_kolor As Label
    Friend WithEvents lbl_cena As Label
    Friend WithEvents lbl_marka1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbx_auto As PictureBox
    Friend WithEvents btn_admin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lst_metalic As ListBox
    Friend WithEvents Label5 As Label
End Class
