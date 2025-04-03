Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Form1
    ' Dictionary for chatbot responses
    Private responses As New Dictionary(Of String, List(Of String)) From {
        {"hello", New List(Of String) From {"Hi there!", "Hello! How can I help?", "Hey! What's up?"}},
        {"how are you", New List(Of String) From {"I'm just a bot, but I'm doing great!", "Feeling chatty today!", "All good! What about you?"}},
        {"bye", New List(Of String) From {"Goodbye!", "See you later!", "Take care!"}},
        {"what is your name", New List(Of String) From {"I'm ChatBot!", "Call me AI Helper.", "I am your friendly chatbot."}},
        {"default", New List(Of String) From {"I didn't understand that.", "Can you rephrase?", "I'm still learning, try again!"}}
    }

    ' Handle Send Button Click
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userMessage As String = txtUserInput.Text.ToLower().Trim()
        If userMessage = "" Then Exit Sub ' Prevent empty messages

        ' Display User Message
        lstChat.Items.Add("You: " & txtUserInput.Text)

        ' Get AI Response
        Dim botReply As String = GetResponse(userMessage)
        lstChat.Items.Add("Bot: " & botReply)

        ' Clear input field
        txtUserInput.Clear()
    End Sub

    ' Function to Get AI Response
    Private Function GetResponse(input As String) As String
        ' Check for matching keyword
        For Each key In responses.Keys
            If input.Contains(key) Then
                Dim possibleReplies As List(Of String) = responses(key)
                Dim random As New Random()
                Return possibleReplies(random.Next(possibleReplies.Count))
            End If
        Next
        ' Default response if no match
        Dim defaultReplies As List(Of String) = responses("default")
        Dim rand As New Random()
        Return defaultReplies(rand.Next(defaultReplies.Count))
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the text of lblSuggestions to display example questions
        lblSuggestions.Text = "Try asking:" & vbCrLf &
                          "- Hello" & vbCrLf &
                          "- How are you?" & vbCrLf &
                          "- What is your name?" & vbCrLf &
                          "- Tell me a joke" & vbCrLf &
                          "- What can you do?" & vbCrLf &
                          "- Who created you?"
    End Sub


End Class
