Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Ievadiet savu vecumu (gadi)"
        TextBox1.ForeColor = Color.Gray
        TextBox2.Text = "Ievadiet savu garumu (metri)"
        TextBox2.ForeColor = Color.Gray
        TextBox3.Text = "Ievadiet savu svaru (kilogrami)"
        TextBox3.ForeColor = Color.Gray
        Button1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vecums As Double = Double.Parse(TextBox1.Text)
        Dim garums As Double = Double.Parse(TextBox2.Text)
        Dim svars As Double = Double.Parse(TextBox3.Text)

        ' Perform the desired calculations
        Dim result1 As Double = svars / (garums * garums)

        ' Display the results
        TextBox4.Text = "Rezultāts: " & result1.ToString()
    End Sub

    Private Sub TextBox4_Paint(sender As Object, e As PaintEventArgs) Handles TextBox4.Paint
        Dim pen As Pen = New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(pen, 0, 0, TextBox4.Width - 1, TextBox4.Height - 1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.ReadOnly = True
        TextBox4.Enabled = False
    End Sub

    'Background text'
    'vecums'
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Ievadiet savu vecumu (gadi)" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Ievadiet savu vecumu (gadi)"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub
    'garums'
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Ievadiet savu garumu (metri)" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Ievadiet savu garumu (metri)"
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub
    'svars'
    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "Ievadiet savu svaru (kilogrami)" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = "Ievadiet savu svaru (kilogrami)"
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class