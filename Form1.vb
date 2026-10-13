Public Class Form1
    Public Function IsPrime(ByVal number As Long) As Boolean
        If number < 2 Then Return False
        If number < 4 Then Return True
        If number Mod 2 = 0 Then Return False

        Dim divisor As Long = 3
        While divisor <= number \ divisor
            If number Mod divisor = 0 Then Return False
            divisor += 2
        End While

        Return True
    End Function
    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim n As Long = number.Text
        If IsPrime(n) Then
            MsgBox(n & " is prime")
        Else
            MsgBox(n & " isn't prime")
        End If

    End Sub
End Class
