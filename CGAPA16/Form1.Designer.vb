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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioAlgorithmFlat = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBoxLightSourceX = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLightSourceZ = New System.Windows.Forms.TextBox()
        Me.TextBoxLightSourceY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonTranslate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTranslateZ = New System.Windows.Forms.TextBox()
        Me.TextBoxTranslateY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTranslateX = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxSpecularExponent = New System.Windows.Forms.TextBox()
        Me.TextBoxSpecularCoefficient = New System.Windows.Forms.TextBox()
        Me.TextBoxDiffuseCoefficient = New System.Windows.Forms.TextBox()
        Me.TextBoxAmbientCoefficient = New System.Windows.Forms.TextBox()
        Me.TextBoxLightIntensity = New System.Windows.Forms.TextBox()
        Me.TextBoxAmbientIntensity = New System.Windows.Forms.TextBox()
        Me.TextB = New System.Windows.Forms.Label()
        Me.ButtonApplyChanges = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RadioAlgorithmFlat
        '
        Me.RadioAlgorithmFlat.AutoSize = True
        Me.RadioAlgorithmFlat.Location = New System.Drawing.Point(6, 22)
        Me.RadioAlgorithmFlat.Name = "RadioAlgorithmFlat"
        Me.RadioAlgorithmFlat.Size = New System.Drawing.Size(44, 19)
        Me.RadioAlgorithmFlat.TabIndex = 1
        Me.RadioAlgorithmFlat.TabStop = True
        Me.RadioAlgorithmFlat.Text = "Flat"
        Me.RadioAlgorithmFlat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioAlgorithmFlat)
        Me.GroupBox1.Location = New System.Drawing.Point(521, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(83, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algorithm"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 19)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Phong"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 19)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Goraud"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBoxLightSourceX
        '
        Me.TextBoxLightSourceX.Location = New System.Drawing.Point(29, 22)
        Me.TextBoxLightSourceX.Name = "TextBoxLightSourceX"
        Me.TextBoxLightSourceX.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxLightSourceX.TabIndex = 3
        Me.TextBoxLightSourceX.Text = "-10"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBoxLightSourceZ)
        Me.GroupBox2.Controls.Add(Me.TextBoxLightSourceY)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBoxLightSourceX)
        Me.GroupBox2.Location = New System.Drawing.Point(521, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 116)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Light Source Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Y"
        '
        'TextBoxLightSourceZ
        '
        Me.TextBoxLightSourceZ.Location = New System.Drawing.Point(29, 80)
        Me.TextBoxLightSourceZ.Name = "TextBoxLightSourceZ"
        Me.TextBoxLightSourceZ.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxLightSourceZ.TabIndex = 6
        Me.TextBoxLightSourceZ.Text = "10"
        '
        'TextBoxLightSourceY
        '
        Me.TextBoxLightSourceY.Location = New System.Drawing.Point(29, 51)
        Me.TextBoxLightSourceY.Name = "TextBoxLightSourceY"
        Me.TextBoxLightSourceY.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxLightSourceY.TabIndex = 5
        Me.TextBoxLightSourceY.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonTranslate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxTranslateZ)
        Me.GroupBox3.Controls.Add(Me.TextBoxTranslateY)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBoxTranslateX)
        Me.GroupBox3.Location = New System.Drawing.Point(521, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 140)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Translate"
        '
        'ButtonTranslate
        '
        Me.ButtonTranslate.Location = New System.Drawing.Point(9, 109)
        Me.ButtonTranslate.Name = "ButtonTranslate"
        Me.ButtonTranslate.Size = New System.Drawing.Size(120, 23)
        Me.ButtonTranslate.TabIndex = 10
        Me.ButtonTranslate.Text = "Translate"
        Me.ButtonTranslate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Z"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Y"
        '
        'TextBoxTranslateZ
        '
        Me.TextBoxTranslateZ.Location = New System.Drawing.Point(29, 80)
        Me.TextBoxTranslateZ.Name = "TextBoxTranslateZ"
        Me.TextBoxTranslateZ.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxTranslateZ.TabIndex = 6
        Me.TextBoxTranslateZ.Text = "0"
        '
        'TextBoxTranslateY
        '
        Me.TextBoxTranslateY.Location = New System.Drawing.Point(29, 51)
        Me.TextBoxTranslateY.Name = "TextBoxTranslateY"
        Me.TextBoxTranslateY.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxTranslateY.TabIndex = 5
        Me.TextBoxTranslateY.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "X"
        '
        'TextBoxTranslateX
        '
        Me.TextBoxTranslateX.Location = New System.Drawing.Point(29, 22)
        Me.TextBoxTranslateX.Name = "TextBoxTranslateX"
        Me.TextBoxTranslateX.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxTranslateX.TabIndex = 3
        Me.TextBoxTranslateX.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBoxSpecularExponent)
        Me.GroupBox4.Controls.Add(Me.TextBoxSpecularCoefficient)
        Me.GroupBox4.Controls.Add(Me.TextBoxDiffuseCoefficient)
        Me.GroupBox4.Controls.Add(Me.TextBoxAmbientCoefficient)
        Me.GroupBox4.Controls.Add(Me.TextBoxLightIntensity)
        Me.GroupBox4.Controls.Add(Me.TextBoxAmbientIntensity)
        Me.GroupBox4.Location = New System.Drawing.Point(669, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 430)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lighting"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Specular Exponent"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Specular Coefficient"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Diffuse Coefficient"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ambient Coefficient"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Light Intensity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Ambient Intensity"
        '
        'TextBoxSpecularExponent
        '
        Me.TextBoxSpecularExponent.Location = New System.Drawing.Point(9, 257)
        Me.TextBoxSpecularExponent.Name = "TextBoxSpecularExponent"
        Me.TextBoxSpecularExponent.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxSpecularExponent.TabIndex = 14
        Me.TextBoxSpecularExponent.Text = "1"
        '
        'TextBoxSpecularCoefficient
        '
        Me.TextBoxSpecularCoefficient.Location = New System.Drawing.Point(9, 214)
        Me.TextBoxSpecularCoefficient.Name = "TextBoxSpecularCoefficient"
        Me.TextBoxSpecularCoefficient.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxSpecularCoefficient.TabIndex = 13
        Me.TextBoxSpecularCoefficient.Text = "0,5"
        '
        'TextBoxDiffuseCoefficient
        '
        Me.TextBoxDiffuseCoefficient.Location = New System.Drawing.Point(9, 170)
        Me.TextBoxDiffuseCoefficient.Name = "TextBoxDiffuseCoefficient"
        Me.TextBoxDiffuseCoefficient.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxDiffuseCoefficient.TabIndex = 12
        Me.TextBoxDiffuseCoefficient.Text = "0,5"
        '
        'TextBoxAmbientCoefficient
        '
        Me.TextBoxAmbientCoefficient.Location = New System.Drawing.Point(9, 125)
        Me.TextBoxAmbientCoefficient.Name = "TextBoxAmbientCoefficient"
        Me.TextBoxAmbientCoefficient.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAmbientCoefficient.TabIndex = 11
        Me.TextBoxAmbientCoefficient.Text = "0,5"
        '
        'TextBoxLightIntensity
        '
        Me.TextBoxLightIntensity.Location = New System.Drawing.Point(6, 81)
        Me.TextBoxLightIntensity.Name = "TextBoxLightIntensity"
        Me.TextBoxLightIntensity.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxLightIntensity.TabIndex = 10
        Me.TextBoxLightIntensity.Text = "1,0"
        '
        'TextBoxAmbientIntensity
        '
        Me.TextBoxAmbientIntensity.Location = New System.Drawing.Point(6, 37)
        Me.TextBoxAmbientIntensity.Name = "TextBoxAmbientIntensity"
        Me.TextBoxAmbientIntensity.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAmbientIntensity.TabIndex = 9
        Me.TextBoxAmbientIntensity.Text = "0,5"
        '
        'TextB
        '
        Me.TextB.AutoSize = True
        Me.TextB.Location = New System.Drawing.Point(707, 44)
        Me.TextB.Name = "TextB"
        Me.TextB.Size = New System.Drawing.Size(19, 15)
        Me.TextB.TabIndex = 5
        Me.TextB.Text = "ka"
        '
        'ButtonApplyChanges
        '
        Me.ButtonApplyChanges.Location = New System.Drawing.Point(518, 386)
        Me.ButtonApplyChanges.Name = "ButtonApplyChanges"
        Me.ButtonApplyChanges.Size = New System.Drawing.Size(64, 56)
        Me.ButtonApplyChanges.TabIndex = 11
        Me.ButtonApplyChanges.Text = "Apply Changes"
        Me.ButtonApplyChanges.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 521)
        Me.Controls.Add(Me.ButtonApplyChanges)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioAlgorithmFlat As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxLightSourceX As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLightSourceZ As TextBox
    Friend WithEvents TextBoxLightSourceY As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonTranslate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTranslateZ As TextBox
    Friend WithEvents TextBoxTranslateY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxTranslateX As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonApplyChanges As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextB As Label
    Friend WithEvents TextBoxDiffuseCoefficient As TextBox
    Friend WithEvents TextBoxAmbientCoefficient As TextBox
    Friend WithEvents TextBoxLightIntensity As TextBox
    Friend WithEvents TextBoxAmbientIntensity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBoxSpecularCoefficient As TextBox
    Friend WithEvents TextBoxDiffuseIntensity As TextBox
    Friend WithEvents TextBoxSpecularExponent As TextBox
End Class
