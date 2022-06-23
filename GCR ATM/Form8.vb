﻿Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim destino, actual As String
        Dim cantidad As Double

        destino = txtDestino.Text
        cantidad = txtMonto.Text
        actual = clabe
        clabe = destino

        If cbBanco.SelectedIndex = 0 Then
            Aniadir(cantidad)
            clabe = actual
            Extraer(cantidad)
        Else
            AniadirInter(cantidad)
            clabe = actual
            ExtraerInter(cantidad)
        End If

        des = "Transferencia a " & destino
        RegistrarMovimiento("Transferencia", cantidad)
        des = ""

        MsgBox("El deposito se realizó exitosamente")
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbBanco.Text = Me.cbBanco.Items(0).ToString
    End Sub
End Class