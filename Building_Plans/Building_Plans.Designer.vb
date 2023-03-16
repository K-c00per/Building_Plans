<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Building_Plans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Building_Plans))
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grbConvert = New System.Windows.Forms.GroupBox()
        Me.radMetersToInches = New System.Windows.Forms.RadioButton()
        Me.radInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbConvert.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.BackgroundImage = CType(resources.GetObject("picBuilding.BackgroundImage"), System.Drawing.Image)
        Me.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBuilding.Location = New System.Drawing.Point(5, 41)
        Me.picBuilding.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(672, 405)
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(795, 98)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(853, 103)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Converter App"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConvert.Location = New System.Drawing.Point(141, 949)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(507, 95)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(813, 949)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(507, 95)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1485, 949)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(507, 95)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(827, 281)
        Me.lblText.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(589, 141)
        Me.lblText.TabIndex = 5
        Me.lblText.Text = "Enter a value and chose conversion"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(1520, 281)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(239, 75)
        Me.txtInput.TabIndex = 6
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grbConvert
        '
        Me.grbConvert.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grbConvert.Controls.Add(Me.radMetersToInches)
        Me.grbConvert.Controls.Add(Me.radInchesToMeters)
        Me.grbConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbConvert.ForeColor = System.Drawing.Color.White
        Me.grbConvert.Location = New System.Drawing.Point(963, 429)
        Me.grbConvert.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.grbConvert.Name = "grbConvert"
        Me.grbConvert.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.grbConvert.Size = New System.Drawing.Size(771, 289)
        Me.grbConvert.TabIndex = 7
        Me.grbConvert.TabStop = False
        Me.grbConvert.Text = "Convert Measurment"
        '
        'radMetersToInches
        '
        Me.radMetersToInches.AutoSize = True
        Me.radMetersToInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMetersToInches.ForeColor = System.Drawing.Color.White
        Me.radMetersToInches.Location = New System.Drawing.Point(67, 188)
        Me.radMetersToInches.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radMetersToInches.Name = "radMetersToInches"
        Me.radMetersToInches.Size = New System.Drawing.Size(367, 50)
        Me.radMetersToInches.TabIndex = 1
        Me.radMetersToInches.TabStop = True
        Me.radMetersToInches.Text = "Meters to Inches"
        Me.radMetersToInches.UseVisualStyleBackColor = True
        '
        'radInchesToMeters
        '
        Me.radInchesToMeters.AutoSize = True
        Me.radInchesToMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInchesToMeters.ForeColor = System.Drawing.Color.White
        Me.radInchesToMeters.Location = New System.Drawing.Point(67, 86)
        Me.radInchesToMeters.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radInchesToMeters.Name = "radInchesToMeters"
        Me.radInchesToMeters.Size = New System.Drawing.Size(367, 50)
        Me.radInchesToMeters.TabIndex = 0
        Me.radInchesToMeters.TabStop = True
        Me.radInchesToMeters.Text = "Inches to Meters"
        Me.radInchesToMeters.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(960, 818)
        Me.lblAnswer.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(499, 61)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "# convert to other #"
        Me.lblAnswer.Visible = False
        '
        'Building_Plans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(2133, 1073)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grbConvert)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBuilding)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Building_Plans"
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbConvert.ResumeLayout(False)
        Me.grbConvert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblText As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents grbConvert As GroupBox
    Friend WithEvents radMetersToInches As RadioButton
    Friend WithEvents radInchesToMeters As RadioButton
    Friend WithEvents lblAnswer As Label
End Class
