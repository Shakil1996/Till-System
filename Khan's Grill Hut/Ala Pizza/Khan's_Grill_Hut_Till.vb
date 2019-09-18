Public Class Khan_Grill_Hut_Till
    'Here is all my global variables
    'There are my constant variables to set up the price for all my meals
    Const VegMeal = 4.5
    Const ChickenMeal = 7.5
    Const LambMeal = 8.5
    Const CurryMeal = 5
    Const TeaMeal = 1.99
    Const CoffeeMeal = 2.99
    Const CokeMeal = 0.8
    Const VanilliaCakeMeal = 1.35
    Const ChocolateCakeMeal = 1.35
    Const VanilliaIceCreamMeal = 1.8
    Const ChocolateIceCreamMeal = 1.8
    'These variables are the quantity so that the user can decide how much they want of that one meal
    Dim QtyVegMeal, QtyChickenMeal, QtyLambMeal, QtyCurryMeal As Integer
    Dim QtyTeaDrink, QtyCoffeeDrink, QtyCokeDrink As Integer
    Dim QtyVanilliaCake, QtyChocolateCake, QtyVanilliaIceCream, QtyChocolateIceCream As Integer
    'These variables will give the total pricing of the entire meal
    Dim TotalVegMeal, TotalChickenMeal, TotalLambMeal, TotalCurryMeal As Single
    Dim TotalTeaMeal, TotalCoffeeMeal, TotalCokeMeal As Single
    Dim TotalVanilliaCakeMeal, TotalChocolateCakeMeal, TotalVanilliaIceCreamMeal, TotalChocolateIceCreamMeal As Single
    Dim Total As Single
    'These variables will allow the user how much they are paying and how much change they will recieve
    Dim UserChange As Single
    Dim UserGives As Single

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'This section is for all the meals
        QtyVegMeal = VegQty.SelectedItem
        QtyChickenMeal = ChickQty.SelectedItem
        QtyLambMeal = LambQty.SelectedItem
        QtyCurryMeal = CurryQty.SelectedItem
        'This section is for all the drinks
        QtyTeaDrink = TeaQty.SelectedItem
        QtyCoffeeDrink = CoffeeQty.SelectedItem
        QtyCokeDrink = CokeQty.SelectedItem
        'This section is for all the deserts
        QtyVanilliaCake = VanilliaCakeQty.SelectedItem
        QtyChocolateCake = ChocoCakeQty.SelectedItem
        QtyVanilliaIceCream = VanilliaICreamQty.SelectedItem
        QtyChocolateIceCream = ChocoICreamQty.SelectedItem
        'These is the calculation of the total when user selects what meals, drinks and deserts they want
        TotalVegMeal = QtyVegMeal * VegMeal
        TotalChickenMeal = QtyChickenMeal * ChickenMeal
        TotalLambMeal = QtyLambMeal * LambMeal
        TotalCurryMeal = QtyCurryMeal * CurryMeal
        TotalTeaMeal = QtyTeaDrink * TeaMeal
        TotalCoffeeMeal = QtyCoffeeDrink * CoffeeMeal
        TotalCokeMeal = QtyCokeDrink * CokeMeal
        TotalVanilliaCakeMeal = QtyVanilliaCake * VanilliaCakeMeal
        TotalChocolateCakeMeal = QtyChocolateCake * ChocolateCakeMeal
        TotalVanilliaIceCreamMeal = QtyVanilliaIceCream * VanilliaIceCreamMeal
        TotalChocolateIceCreamMeal = QtyChocolateIceCream * ChocolateIceCreamMeal
        'This calculation will show the total cost when user clicks on the total button
        Total = (TotalVegMeal + TotalChickenMeal + TotalLambMeal + TotalCurryMeal + TotalTeaMeal + TotalCoffeeMeal + TotalCokeMeal + TotalVanilliaCakeMeal + TotalChocolateCakeMeal + TotalVanilliaIceCreamMeal + TotalChocolateIceCreamMeal) * 1.2
        'This will simply display the total in the correct currency
        DisplayTotal.Text = FormatCurrency(Total)
    End Sub

    Private Sub ClearOrder_Click(sender As System.Object, e As System.EventArgs) Handles ClearOrder.Click
        'This is the coding behind the clear button
        'What this section will do is reset the quantity for all the meals at zero
        VegQty.SelectedIndex = -1
        ChickQty.SelectedIndex = -1
        LambQty.SelectedIndex = -1
        CurryQty.SelectedIndex = -1
        TeaQty.SelectedIndex = -1
        CoffeeQty.SelectedIndex = -1
        CokeQty.SelectedIndex = -1
        VanilliaCakeQty.SelectedIndex = -1
        ChocoCakeQty.SelectedIndex = -1
        VanilliaICreamQty.SelectedIndex = -1
        ChocoICreamQty.SelectedIndex = -1
        'This section shows that it will clear all the textbox for the total, amount given and change
        DisplayTotal.Clear()
        UserGiven.Clear()
        ChangeGiven.Clear()
    End Sub

    Private Sub Change_Click(sender As System.Object, e As System.EventArgs) Handles Change.Click
        'This is coding behind the change button
        'This is the exception handling tool which will help pick out invalid values and make the user type in the valid value

        UserGives = UserGiven.Text
        UserChange = UserGives - Total
        ChangeGiven.Text = FormatCurrency(UserChange)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'This is the coding behind the exit program button'
        'What these coding does is that it will close all of the forums that i have created
        Me.Close()
        Help_and_FAQ_Page.Close()
        Login_System.Close()
    End Sub

    Private Sub HelpAndFAQToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpAndFAQToolStripMenuItem.Click
        'What this does is that when the user clicks on Help and FAQ on the menu bar, it will open the help and FAQ page
        Help_and_FAQ_Page.Show()
    End Sub
End Class