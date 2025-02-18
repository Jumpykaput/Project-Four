' ******************************************************
' Project: Burger Specials GUI
' Student: Carson Parker
' Assignment: 4 - GUI Development
' Class: [Your Class Name Here]
' Date: [Insert Date Here]
' Description: This program allows users to select a burger special
'              (Prime Beef or Veggie), view an image of the selected meal,
'              confirm their choice, and exit the application.
' ******************************************************
Public Class frmBurgerSpecials

    ' When Prime Beef button is clicked
    Private Sub btnPrimeBeef_Click(sender As Object, e As EventArgs) Handles btnPrimeBeef.Click
        pbxPrimeBeef.Visible = True  ' Show Prime Beef image
        pbxVeggie.Visible = False    ' Hide Veggie image
        btnSelectMeal.Enabled = True ' Enable meal selection button
    End Sub

    ' When Veggie button is clicked
    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        pbxVeggie.Visible = True   ' Show Veggie image
        pbxPrimeBeef.Visible = False ' Hide Prime Beef image
        btnSelectMeal.Enabled = True ' Enable meal selection button
    End Sub

    ' When Select Meal button is clicked
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        MessageBox.Show("You have selected your meal!", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Disable all selection buttons after choosing a meal
        btnPrimeBeef.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = True ' Enable Exit button
    End Sub

    ' When Exit button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close the application
    End Sub

    Private Sub frmBurgerSpecials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
