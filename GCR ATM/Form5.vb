﻿Imports System.Data.SqlClient

Public Class Form5

    Dim cantidad As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Consultar()

        cantidad = InputBox("Cantidad a depositar: ")
        Aniadir(cantidad)
        RegistrarMovimiento("Deposito", cantidad)

        MsgBox("Deposito realizado con exito")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Consultar()
        MsgBox("Tenes actualmente: " & eldinero & " pesos")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim retiro As Double
        retiro = InputBox("Ingrese la cantidad a retirar")
        Consultar()
        If eldinero < retiro Then
            MsgBox("No hay suficiente dinero en tu cuenta para retirar esa cantidad")
        Else
            Extraer(retiro)
            MsgBox("Retiro realizado con exito")
            RegistrarMovimiento("Retiro", retiro)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim destino, actual As String
        destino = InputBox("Ingrese el numero de cuenta a depositar: ")
        cantidad = InputBox("ingresa la cantidad a depositar ")
        actual = clabe
        clabe = destino
        Aniadir(cantidad)
        clabe = actual
        Extraer(cantidad)
    End Sub
End Class