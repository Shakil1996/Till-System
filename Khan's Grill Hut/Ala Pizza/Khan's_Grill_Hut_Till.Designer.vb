<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khan_Grill_Hut_Till
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
        Me.lblVegMeal = New System.Windows.Forms.Label()
        Me.lblChickenMeal = New System.Windows.Forms.Label()
        Me.lblLambMeal = New System.Windows.Forms.Label()
        Me.lblCurryMeal = New System.Windows.Forms.Label()
        Me.CoffeeDrink = New System.Windows.Forms.Label()
        Me.VanilliaCake = New System.Windows.Forms.Label()
        Me.ChocolateCake = New System.Windows.Forms.Label()
        Me.VanilliaIceCream = New System.Windows.Forms.Label()
        Me.ChocolateIceCream = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Bill = New System.Windows.Forms.Label()
        Me.AmountGiven = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VegQty = New System.Windows.Forms.ComboBox()
        Me.TeaDrink = New System.Windows.Forms.Label()
        Me.CokeDrink = New System.Windows.Forms.Label()
        Me.ChickQty = New System.Windows.Forms.ComboBox()
        Me.LambQty = New System.Windows.Forms.ComboBox()
        Me.CurryQty = New System.Windows.Forms.ComboBox()
        Me.TeaQty = New System.Windows.Forms.ComboBox()
        Me.CoffeeQty = New System.Windows.Forms.ComboBox()
        Me.CokeQty = New System.Windows.Forms.ComboBox()
        Me.VanilliaCakeQty = New System.Windows.Forms.ComboBox()
        Me.ChocoCakeQty = New System.Windows.Forms.ComboBox()
        Me.VanilliaICreamQty = New System.Windows.Forms.ComboBox()
        Me.ChocoICreamQty = New System.Windows.Forms.ComboBox()
        Me.DisplayTotal = New System.Windows.Forms.TextBox()
        Me.Change = New System.Windows.Forms.Button()
        Me.ClearOrder = New System.Windows.Forms.Button()
        Me.UserGiven = New System.Windows.Forms.TextBox()
        Me.ChangeGiven = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndFAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVegMeal
        '
        Me.lblVegMeal.Location = New System.Drawing.Point(19, 98)
        Me.lblVegMeal.Name = "lblVegMeal"
        Me.lblVegMeal.Size = New System.Drawing.Size(110, 23)
        Me.lblVegMeal.TabIndex = 0
        Me.lblVegMeal.Text = "Vegtable Meal £4.50"
        '
        'lblChickenMeal
        '
        Me.lblChickenMeal.Location = New System.Drawing.Point(19, 146)
        Me.lblChickenMeal.Name = "lblChickenMeal"
        Me.lblChickenMeal.Size = New System.Drawing.Size(111, 23)
        Me.lblChickenMeal.TabIndex = 1
        Me.lblChickenMeal.Text = "Chicken Meal £7.50 "
        '
        'lblLambMeal
        '
        Me.lblLambMeal.Location = New System.Drawing.Point(30, 190)
        Me.lblLambMeal.Name = "lblLambMeal"
        Me.lblLambMeal.Size = New System.Drawing.Size(100, 23)
        Me.lblLambMeal.TabIndex = 2
        Me.lblLambMeal.Text = "Lamb Meal £8.50"
        '
        'lblCurryMeal
        '
        Me.lblCurryMeal.Location = New System.Drawing.Point(30, 226)
        Me.lblCurryMeal.Name = "lblCurryMeal"
        Me.lblCurryMeal.Size = New System.Drawing.Size(100, 23)
        Me.lblCurryMeal.TabIndex = 3
        Me.lblCurryMeal.Text = "Curry Meal £5"
        '
        'CoffeeDrink
        '
        Me.CoffeeDrink.Location = New System.Drawing.Point(170, 146)
        Me.CoffeeDrink.Name = "CoffeeDrink"
        Me.CoffeeDrink.Size = New System.Drawing.Size(100, 23)
        Me.CoffeeDrink.TabIndex = 5
        Me.CoffeeDrink.Text = "Coffee £2.99"
        '
        'VanilliaCake
        '
        Me.VanilliaCake.Location = New System.Drawing.Point(313, 96)
        Me.VanilliaCake.Name = "VanilliaCake"
        Me.VanilliaCake.Size = New System.Drawing.Size(121, 23)
        Me.VanilliaCake.TabIndex = 7
        Me.VanilliaCake.Text = "Vanillia  Cake £1.35"
        '
        'ChocolateCake
        '
        Me.ChocolateCake.Location = New System.Drawing.Point(302, 141)
        Me.ChocolateCake.Name = "ChocolateCake"
        Me.ChocolateCake.Size = New System.Drawing.Size(129, 23)
        Me.ChocolateCake.TabIndex = 8
        Me.ChocolateCake.Text = "Chocolate Cake £1.35"
        '
        'VanilliaIceCream
        '
        Me.VanilliaIceCream.Location = New System.Drawing.Point(292, 187)
        Me.VanilliaIceCream.Name = "VanilliaIceCream"
        Me.VanilliaIceCream.Size = New System.Drawing.Size(121, 21)
        Me.VanilliaIceCream.TabIndex = 9
        Me.VanilliaIceCream.Text = "Vanillia Ice Cream £1.80"
        '
        'ChocolateIceCream
        '
        Me.ChocolateIceCream.Location = New System.Drawing.Point(276, 226)
        Me.ChocolateIceCream.Name = "ChocolateIceCream"
        Me.ChocolateIceCream.Size = New System.Drawing.Size(146, 23)
        Me.ChocolateIceCream.TabIndex = 10
        Me.ChocolateIceCream.Text = "Chocolate Ice Cream £1.80"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(486, 229)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 42)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Exit Program"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Bill
        '
        Me.Bill.Location = New System.Drawing.Point(38, 289)
        Me.Bill.Name = "Bill"
        Me.Bill.Size = New System.Drawing.Size(104, 25)
        Me.Bill.TabIndex = 26
        Me.Bill.Text = "Bill"
        '
        'AmountGiven
        '
        Me.AmountGiven.Location = New System.Drawing.Point(193, 289)
        Me.AmountGiven.Name = "AmountGiven"
        Me.AmountGiven.Size = New System.Drawing.Size(104, 25)
        Me.AmountGiven.TabIndex = 27
        Me.AmountGiven.Text = "Amount Given"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(354, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Change"
        '
        'VegQty
        '
        Me.VegQty.FormattingEnabled = True
        Me.VegQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.VegQty.Location = New System.Drawing.Point(124, 95)
        Me.VegQty.Name = "VegQty"
        Me.VegQty.Size = New System.Drawing.Size(29, 21)
        Me.VegQty.TabIndex = 29
        '
        'TeaDrink
        '
        Me.TeaDrink.Location = New System.Drawing.Point(170, 98)
        Me.TeaDrink.Name = "TeaDrink"
        Me.TeaDrink.Size = New System.Drawing.Size(100, 23)
        Me.TeaDrink.TabIndex = 4
        Me.TeaDrink.Text = "Tea £1.99"
        '
        'CokeDrink
        '
        Me.CokeDrink.Location = New System.Drawing.Point(170, 190)
        Me.CokeDrink.Name = "CokeDrink"
        Me.CokeDrink.Size = New System.Drawing.Size(100, 23)
        Me.CokeDrink.TabIndex = 6
        Me.CokeDrink.Text = "Coke £0.80"
        '
        'ChickQty
        '
        Me.ChickQty.FormattingEnabled = True
        Me.ChickQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ChickQty.Location = New System.Drawing.Point(124, 143)
        Me.ChickQty.Name = "ChickQty"
        Me.ChickQty.Size = New System.Drawing.Size(29, 21)
        Me.ChickQty.TabIndex = 30
        '
        'LambQty
        '
        Me.LambQty.FormattingEnabled = True
        Me.LambQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.LambQty.Location = New System.Drawing.Point(124, 187)
        Me.LambQty.Name = "LambQty"
        Me.LambQty.Size = New System.Drawing.Size(29, 21)
        Me.LambQty.TabIndex = 31
        '
        'CurryQty
        '
        Me.CurryQty.FormattingEnabled = True
        Me.CurryQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CurryQty.Location = New System.Drawing.Point(124, 225)
        Me.CurryQty.Name = "CurryQty"
        Me.CurryQty.Size = New System.Drawing.Size(29, 21)
        Me.CurryQty.TabIndex = 32
        '
        'TeaQty
        '
        Me.TeaQty.FormattingEnabled = True
        Me.TeaQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.TeaQty.Location = New System.Drawing.Point(241, 93)
        Me.TeaQty.Name = "TeaQty"
        Me.TeaQty.Size = New System.Drawing.Size(29, 21)
        Me.TeaQty.TabIndex = 33
        '
        'CoffeeQty
        '
        Me.CoffeeQty.FormattingEnabled = True
        Me.CoffeeQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CoffeeQty.Location = New System.Drawing.Point(241, 143)
        Me.CoffeeQty.Name = "CoffeeQty"
        Me.CoffeeQty.Size = New System.Drawing.Size(29, 21)
        Me.CoffeeQty.TabIndex = 34
        '
        'CokeQty
        '
        Me.CokeQty.FormattingEnabled = True
        Me.CokeQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CokeQty.Location = New System.Drawing.Point(241, 187)
        Me.CokeQty.Name = "CokeQty"
        Me.CokeQty.Size = New System.Drawing.Size(29, 21)
        Me.CokeQty.TabIndex = 35
        '
        'VanilliaCakeQty
        '
        Me.VanilliaCakeQty.FormattingEnabled = True
        Me.VanilliaCakeQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.VanilliaCakeQty.Location = New System.Drawing.Point(428, 93)
        Me.VanilliaCakeQty.Name = "VanilliaCakeQty"
        Me.VanilliaCakeQty.Size = New System.Drawing.Size(29, 21)
        Me.VanilliaCakeQty.TabIndex = 36
        '
        'ChocoCakeQty
        '
        Me.ChocoCakeQty.FormattingEnabled = True
        Me.ChocoCakeQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ChocoCakeQty.Location = New System.Drawing.Point(428, 138)
        Me.ChocoCakeQty.Name = "ChocoCakeQty"
        Me.ChocoCakeQty.Size = New System.Drawing.Size(29, 21)
        Me.ChocoCakeQty.TabIndex = 37
        '
        'VanilliaICreamQty
        '
        Me.VanilliaICreamQty.FormattingEnabled = True
        Me.VanilliaICreamQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.VanilliaICreamQty.Location = New System.Drawing.Point(428, 184)
        Me.VanilliaICreamQty.Name = "VanilliaICreamQty"
        Me.VanilliaICreamQty.Size = New System.Drawing.Size(29, 21)
        Me.VanilliaICreamQty.TabIndex = 38
        '
        'ChocoICreamQty
        '
        Me.ChocoICreamQty.FormattingEnabled = True
        Me.ChocoICreamQty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ChocoICreamQty.Location = New System.Drawing.Point(428, 223)
        Me.ChocoICreamQty.Name = "ChocoICreamQty"
        Me.ChocoICreamQty.Size = New System.Drawing.Size(29, 21)
        Me.ChocoICreamQty.TabIndex = 39
        '
        'DisplayTotal
        '
        Me.DisplayTotal.Location = New System.Drawing.Point(41, 317)
        Me.DisplayTotal.Name = "DisplayTotal"
        Me.DisplayTotal.Size = New System.Drawing.Size(100, 20)
        Me.DisplayTotal.TabIndex = 40
        '
        'Change
        '
        Me.Change.Location = New System.Drawing.Point(486, 132)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(145, 42)
        Me.Change.TabIndex = 23
        Me.Change.Text = "Change"
        Me.Change.UseVisualStyleBackColor = True
        '
        'ClearOrder
        '
        Me.ClearOrder.Location = New System.Drawing.Point(486, 181)
        Me.ClearOrder.Name = "ClearOrder"
        Me.ClearOrder.Size = New System.Drawing.Size(145, 42)
        Me.ClearOrder.TabIndex = 41
        Me.ClearOrder.Text = "Clear Order"
        Me.ClearOrder.UseVisualStyleBackColor = True
        '
        'UserGiven
        '
        Me.UserGiven.Location = New System.Drawing.Point(196, 317)
        Me.UserGiven.Name = "UserGiven"
        Me.UserGiven.Size = New System.Drawing.Size(100, 20)
        Me.UserGiven.TabIndex = 42
        '
        'ChangeGiven
        '
        Me.ChangeGiven.Location = New System.Drawing.Point(357, 317)
        Me.ChangeGiven.Name = "ChangeGiven"
        Me.ChangeGiven.Size = New System.Drawing.Size(100, 20)
        Me.ChangeGiven.TabIndex = 43
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpMenuToolStripMenuItem
        '
        Me.HelpMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpAndFAQToolStripMenuItem})
        Me.HelpMenuToolStripMenuItem.Name = "HelpMenuToolStripMenuItem"
        Me.HelpMenuToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.HelpMenuToolStripMenuItem.Text = "Help Menu"
        '
        'HelpAndFAQToolStripMenuItem
        '
        Me.HelpAndFAQToolStripMenuItem.Name = "HelpAndFAQToolStripMenuItem"
        Me.HelpAndFAQToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.HelpAndFAQToolStripMenuItem.Text = "Help and FAQ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 54)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Khan's Grill Hut Till System"
        '
        'Khan_Grill_Hut_Till
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 369)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChangeGiven)
        Me.Controls.Add(Me.UserGiven)
        Me.Controls.Add(Me.ClearOrder)
        Me.Controls.Add(Me.DisplayTotal)
        Me.Controls.Add(Me.ChocoICreamQty)
        Me.Controls.Add(Me.VanilliaICreamQty)
        Me.Controls.Add(Me.ChocoCakeQty)
        Me.Controls.Add(Me.VanilliaCakeQty)
        Me.Controls.Add(Me.CokeQty)
        Me.Controls.Add(Me.CoffeeQty)
        Me.Controls.Add(Me.TeaQty)
        Me.Controls.Add(Me.CurryQty)
        Me.Controls.Add(Me.LambQty)
        Me.Controls.Add(Me.ChickQty)
        Me.Controls.Add(Me.VegQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountGiven)
        Me.Controls.Add(Me.Bill)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChocolateIceCream)
        Me.Controls.Add(Me.VanilliaIceCream)
        Me.Controls.Add(Me.ChocolateCake)
        Me.Controls.Add(Me.VanilliaCake)
        Me.Controls.Add(Me.CokeDrink)
        Me.Controls.Add(Me.CoffeeDrink)
        Me.Controls.Add(Me.TeaDrink)
        Me.Controls.Add(Me.lblCurryMeal)
        Me.Controls.Add(Me.lblLambMeal)
        Me.Controls.Add(Me.lblChickenMeal)
        Me.Controls.Add(Me.lblVegMeal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Khan_Grill_Hut_Till"
        Me.Text = "Khan_Grill_Hut_Till"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVegMeal As System.Windows.Forms.Label
    Friend WithEvents lblChickenMeal As System.Windows.Forms.Label
    Friend WithEvents lblLambMeal As System.Windows.Forms.Label
    Friend WithEvents lblCurryMeal As System.Windows.Forms.Label
    Friend WithEvents CoffeeDrink As System.Windows.Forms.Label
    Friend WithEvents VanilliaCake As System.Windows.Forms.Label
    Friend WithEvents ChocolateCake As System.Windows.Forms.Label
    Friend WithEvents VanilliaIceCream As System.Windows.Forms.Label
    Friend WithEvents ChocolateIceCream As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Bill As System.Windows.Forms.Label
    Friend WithEvents AmountGiven As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VegQty As System.Windows.Forms.ComboBox
    Friend WithEvents TeaDrink As System.Windows.Forms.Label
    Friend WithEvents CokeDrink As System.Windows.Forms.Label
    Friend WithEvents ChickQty As System.Windows.Forms.ComboBox
    Friend WithEvents LambQty As System.Windows.Forms.ComboBox
    Friend WithEvents CurryQty As System.Windows.Forms.ComboBox
    Friend WithEvents TeaQty As System.Windows.Forms.ComboBox
    Friend WithEvents CoffeeQty As System.Windows.Forms.ComboBox
    Friend WithEvents CokeQty As System.Windows.Forms.ComboBox
    Friend WithEvents VanilliaCakeQty As System.Windows.Forms.ComboBox
    Friend WithEvents ChocoCakeQty As System.Windows.Forms.ComboBox
    Friend WithEvents VanilliaICreamQty As System.Windows.Forms.ComboBox
    Friend WithEvents ChocoICreamQty As System.Windows.Forms.ComboBox
    Friend WithEvents DisplayTotal As System.Windows.Forms.TextBox
    Friend WithEvents Change As System.Windows.Forms.Button
    Friend WithEvents ClearOrder As System.Windows.Forms.Button
    Friend WithEvents UserGiven As System.Windows.Forms.TextBox
    Friend WithEvents ChangeGiven As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpAndFAQToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
