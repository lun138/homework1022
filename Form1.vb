﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtUserName.Text = "" And txtPassword.Text = "" Then
            txtUserName.BackColor = Color.MistyRose
            txtPassword.BackColor = Color.MistyRose
        End If

        If txtUserName.Text = "login" Then
            txtUserName.BackColor = Color.White
        Else
            txtUserName.BackColor = Color.MistyRose
        End If

        If txtPassword.Text = "abc123" Then
            txtPassword.BackColor = Color.White
        Else
            txtPassword.BackColor = Color.MistyRose
        End If

        If txtUserName.Text = "login" And txtPassword.Text = "abc123" Then
            MessageBox.Show("帳號密碼輸入正確")
            Application.Exit()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
