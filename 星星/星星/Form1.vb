Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If i = j Then
                    TextBox1.Text &= "＊"
                Else
                    TextBox1.Text &= "．"
                End If
            Next
            TextBox1.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If i = 1 Or i = 9 Or j = 1 Or j = 9 Then
                    TextBox2.Text &= "＊"
                Else
                    TextBox2.Text &= "．"
                End If
            Next
            TextBox2.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If i = 5 Or j = 5 Then
                    TextBox3.Text &= "＊"
                Else
                    TextBox3.Text &= "．"
                End If
            Next
            TextBox3.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Then
                    TextBox4.Text &= "＊"
                Else
                    TextBox4.Text &= "．"
                End If
            Next
            TextBox4.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If i = 6 Or i = 7 Or i = 8 Or i = 9 Or j = 6 Or j = 7 Or j = 8 Or j = 9 Then
                    TextBox5.Text &= "．"
                Else
                    TextBox5.Text &= "＊"
                End If
            Next
            TextBox5.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        For i As Integer = 9 To 1 Step -1
            For j As Integer = 1 To 9
                If i = j Then
                    TextBox6.Text &= "＊"
                Else
                    TextBox6.Text &= "．"
                End If
            Next
            TextBox6.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If j = 9 Or j = i Or i = 1 Then
                    TextBox10.Text &= "＊"
                Else
                    TextBox10.Text &= "．"
                End If
            Next
            TextBox10.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                If j = i Or j = 2 * i Then
                    TextBox11.Text &= "＊"
                Else
                    TextBox11.Text &= "．"
                End If
            Next
            TextBox11.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        For i As Integer = 9 To 1 Step -1
            For j As Integer = 1 To i
                TextBox12.Text &= "＊"
            Next
            TextBox12.Text &= vbCrLf
        Next
    End Sub
End Class
