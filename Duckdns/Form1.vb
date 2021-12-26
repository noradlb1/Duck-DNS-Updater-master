


Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task.Run(New Action(Sub()
                                PostIP()
                            End Sub))
    End Sub

    Private Sub PostIP()
        Try
            Dim x As HttpWebRequest = HttpWebRequest.CreateHttp(New Uri("https://duckdns.org/update/" & _
            Me.TextBox1.Text & "/" & Me.TextBox2.Text & "/" & Me.TextBox3.Text))
            x.GetResponse()
            x.Abort()
            MsgBox("Sucess!", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + vbSystemModal, "Sucess")
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical + vbSystemModal, "Erro")
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Coded By MONSTERMC :)", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + vbSystemModal, ":)")

        Try
            Me.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Text = "Duckdns Updeter V" & My.Application.Info.Version.ToString
    End Sub
End Class
