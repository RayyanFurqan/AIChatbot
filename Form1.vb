Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Form1
   
    Private responses As New Dictionary(Of String, List(Of String)) From {
        {"hello", New List(Of String) From {"Hi there!", "Hello! How can I help?", "Hey! What's up?"}},
        {"how are you", New List(Of String) From {"I'm just a bot, but I'm doing great!", "Feeling chatty today!", "All good! What about you?"}},
        {"bye", New List(Of String) From {"Goodbye!", "See you later!", "Take care!"}},
        {"what is your name", New List(Of String) From {"I'm ChatBot!", "Call me AI Helper.", "I am your friendly chatbot."}},
        {"default", New List(Of String) From {"I didn't understand that.", "Can you rephrase?", "I'm still learning, try again!"}}
    }

    
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userMessage As String = txtUserInput.Text.ToLower().Trim()
        If userMessage = "" Then Exit Sub 

        
        lstChat.Items.Add("You: " & txtUserInput.Text)

        
        Dim botReply As String = GetResponse(userMessage)
        lstChat.Items.Add("Bot: " & botReply)

        
        txtUserInput.Clear()
    End Sub

    
    Private Function GetResponse(input As String) As String
        
        For Each key In responses.Keys
            If input.Contains(key) Then
                Dim possibleReplies As List(Of String) = responses(key)
                Dim random As New Random()
                Return possibleReplies(random.Next(possibleReplies.Count))
            End If
        Next
       
        Dim defaultReplies As List(Of String) = responses("default")
        Dim rand As New Random()
        Return defaultReplies(rand.Next(defaultReplies.Count))
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        lblSuggestions.Text = "Try asking:" & vbCrLf &
                          "- Hello" & vbCrLf &
                          "- How are you?" & vbCrLf &
                          "- What is your name?" & vbCrLf &
                          "- Tell me a joke" & vbCrLf &
                          "- What can you do?" & vbCrLf &
                          "- Who created you?"
    End Sub


End Class
