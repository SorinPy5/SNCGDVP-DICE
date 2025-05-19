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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.D1 = New System.Windows.Forms.PictureBox()
        Me.D2 = New System.Windows.Forms.PictureBox()
        Me.D3 = New System.Windows.Forms.PictureBox()
        Me.D4 = New System.Windows.Forms.PictureBox()
        Me.D5 = New System.Windows.Forms.PictureBox()
        Me.D6 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButtonLow = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHigh = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEngleza = New System.Windows.Forms.Button()
        Me.btnRomania = New System.Windows.Forms.Button()
        Me.btnPoloneza = New System.Windows.Forms.Button()
        CType(Me.D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'D1
        '
        Me.D1.BackColor = System.Drawing.Color.Transparent
        Me.D1.Image = CType(resources.GetObject("D1.Image"), System.Drawing.Image)
        Me.D1.Location = New System.Drawing.Point(377, 327)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(277, 216)
        Me.D1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D1.TabIndex = 4
        Me.D1.TabStop = False
        '
        'D2
        '
        Me.D2.Image = CType(resources.GetObject("D2.Image"), System.Drawing.Image)
        Me.D2.Location = New System.Drawing.Point(433, 342)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(175, 174)
        Me.D2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D2.TabIndex = 5
        Me.D2.TabStop = False
        '
        'D3
        '
        Me.D3.Image = CType(resources.GetObject("D3.Image"), System.Drawing.Image)
        Me.D3.Location = New System.Drawing.Point(434, 347)
        Me.D3.Name = "D3"
        Me.D3.Size = New System.Drawing.Size(178, 175)
        Me.D3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D3.TabIndex = 6
        Me.D3.TabStop = False
        '
        'D4
        '
        Me.D4.BackColor = System.Drawing.Color.Transparent
        Me.D4.Image = CType(resources.GetObject("D4.Image"), System.Drawing.Image)
        Me.D4.Location = New System.Drawing.Point(438, 342)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(174, 175)
        Me.D4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D4.TabIndex = 7
        Me.D4.TabStop = False
        '
        'D5
        '
        Me.D5.BackColor = System.Drawing.Color.Transparent
        Me.D5.Image = CType(resources.GetObject("D5.Image"), System.Drawing.Image)
        Me.D5.Location = New System.Drawing.Point(434, 342)
        Me.D5.Name = "D5"
        Me.D5.Size = New System.Drawing.Size(174, 180)
        Me.D5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D5.TabIndex = 8
        Me.D5.TabStop = False
        '
        'D6
        '
        Me.D6.BackColor = System.Drawing.Color.Transparent
        Me.D6.Image = CType(resources.GetObject("D6.Image"), System.Drawing.Image)
        Me.D6.Location = New System.Drawing.Point(435, 342)
        Me.D6.Name = "D6"
        Me.D6.Size = New System.Drawing.Size(177, 174)
        Me.D6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.D6.TabIndex = 9
        Me.D6.TabStop = False
        '
        'Timer1
        '
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(660, 471)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(128, 51)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Runs"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Location = New System.Drawing.Point(551, 51)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(0, 13)
        Me.Score.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 437)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'RadioButtonLow
        '
        Me.RadioButtonLow.AutoSize = True
        Me.RadioButtonLow.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonLow.Location = New System.Drawing.Point(651, 347)
        Me.RadioButtonLow.Name = "RadioButtonLow"
        Me.RadioButtonLow.Size = New System.Drawing.Size(197, 35)
        Me.RadioButtonLow.TabIndex = 13
        Me.RadioButtonLow.TabStop = True
        Me.RadioButtonLow.Text = "RadioButton1"
        Me.RadioButtonLow.UseVisualStyleBackColor = False
        '
        'RadioButtonHigh
        '
        Me.RadioButtonHigh.AutoSize = True
        Me.RadioButtonHigh.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonHigh.Location = New System.Drawing.Point(651, 303)
        Me.RadioButtonHigh.Name = "RadioButtonHigh"
        Me.RadioButtonHigh.Size = New System.Drawing.Size(197, 35)
        Me.RadioButtonHigh.TabIndex = 14
        Me.RadioButtonHigh.TabStop = True
        Me.RadioButtonHigh.Text = "RadioButton2"
        Me.RadioButtonHigh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(660, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 55)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "."
        '
        'btnEngleza
        '
        Me.btnEngleza.BackgroundImage = CType(resources.GetObject("btnEngleza.BackgroundImage"), System.Drawing.Image)
        Me.btnEngleza.Location = New System.Drawing.Point(829, 653)
        Me.btnEngleza.Name = "btnEngleza"
        Me.btnEngleza.Size = New System.Drawing.Size(75, 45)
        Me.btnEngleza.TabIndex = 17
        Me.btnEngleza.UseVisualStyleBackColor = True
        '
        'btnRomania
        '
        Me.btnRomania.BackgroundImage = CType(resources.GetObject("btnRomania.BackgroundImage"), System.Drawing.Image)
        Me.btnRomania.Location = New System.Drawing.Point(586, 641)
        Me.btnRomania.Name = "btnRomania"
        Me.btnRomania.Size = New System.Drawing.Size(104, 63)
        Me.btnRomania.TabIndex = 18
        Me.btnRomania.UseVisualStyleBackColor = True
        '
        'btnPoloneza
        '
        Me.btnPoloneza.BackgroundImage = CType(resources.GetObject("btnPoloneza.BackgroundImage"), System.Drawing.Image)
        Me.btnPoloneza.Location = New System.Drawing.Point(713, 646)
        Me.btnPoloneza.Name = "btnPoloneza"
        Me.btnPoloneza.Size = New System.Drawing.Size(94, 58)
        Me.btnPoloneza.TabIndex = 19
        Me.btnPoloneza.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btnPoloneza)
        Me.Controls.Add(Me.btnRomania)
        Me.Controls.Add(Me.btnEngleza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButtonHigh)
        Me.Controls.Add(Me.RadioButtonLow)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.D6)
        Me.Controls.Add(Me.D5)
        Me.Controls.Add(Me.D4)
        Me.Controls.Add(Me.D3)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.D1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents D1 As PictureBox
    Friend WithEvents D2 As PictureBox
    Friend WithEvents D3 As PictureBox
    Friend WithEvents D4 As PictureBox
    Friend WithEvents D5 As PictureBox
    Friend WithEvents D6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents Score As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButtonLow As RadioButton
    Friend WithEvents RadioButtonHigh As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnEngleza As Button
    Friend WithEvents btnRomania As Button
    Friend WithEvents btnPoloneza As Button
End Class
