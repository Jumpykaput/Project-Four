<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgerSpecials
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrimeBeef = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbxVeggie = New System.Windows.Forms.PictureBox()
        Me.pbxPrimeBeef = New System.Windows.Forms.PictureBox()
        CType(Me.pbxVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPrimeBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Farm Burger Specials"
        '
        'btnPrimeBeef
        '
        Me.btnPrimeBeef.Location = New System.Drawing.Point(131, 302)
        Me.btnPrimeBeef.Name = "btnPrimeBeef"
        Me.btnPrimeBeef.Size = New System.Drawing.Size(122, 38)
        Me.btnPrimeBeef.TabIndex = 3
        Me.btnPrimeBeef.Text = "Prime Beef"
        Me.btnPrimeBeef.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(342, 302)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(122, 38)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(554, 302)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(122, 38)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(342, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pbxVeggie
        '
        Me.pbxVeggie.Image = Global.Project3_4.My.Resources.Resources.veggie
        Me.pbxVeggie.Location = New System.Drawing.Point(497, 58)
        Me.pbxVeggie.Name = "pbxVeggie"
        Me.pbxVeggie.Size = New System.Drawing.Size(229, 232)
        Me.pbxVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxVeggie.TabIndex = 1
        Me.pbxVeggie.TabStop = False
        '
        'pbxPrimeBeef
        '
        Me.pbxPrimeBeef.Image = Global.Project3_4.My.Resources.Resources.meat
        Me.pbxPrimeBeef.Location = New System.Drawing.Point(95, 58)
        Me.pbxPrimeBeef.Name = "pbxPrimeBeef"
        Me.pbxPrimeBeef.Size = New System.Drawing.Size(216, 232)
        Me.pbxPrimeBeef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPrimeBeef.TabIndex = 0
        Me.pbxPrimeBeef.TabStop = False
        '
        'frmBurgerSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnPrimeBeef)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxVeggie)
        Me.Controls.Add(Me.pbxPrimeBeef)
        Me.Name = "frmBurgerSpecials"
        Me.Text = "BurgerSpecials"
        CType(Me.pbxVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPrimeBeef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxPrimeBeef As PictureBox
    Friend WithEvents pbxVeggie As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrimeBeef As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnExit As Button
End Class
