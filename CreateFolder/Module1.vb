Module Module1

    Public a As Boolean
    Public Sub create_folder()
        a = False
        Dim nmeFolder As String
        Dim nmeSubFolder, distination As String
        Dim n1, n2 As Long
        distination = Form3.MaskedTextBox1.Text
        nmeFolder = Form3.MaskedTextBox2.Text
        nmeSubFolder = Form3.MaskedTextBox3.Text

        For n1 = 1 To Val(Form3.MaskedTextBox4.Text)
            MkDir(distination & "\" & nmeFolder & Str(n1))
            For n2 = 1 To Val(Form3.MaskedTextBox5.Text)
                MkDir(distination & "\" & nmeFolder & Str(n1) & "\" & nmeSubFolder & Str(n2))
                a = True
            Next n2

        Next n1
    End Sub

    Public Sub Print()
        Dim nmeFolder As String
        Dim nmeSubFolder, distination As String
        Dim i1, i2 As Long
        distination = Form3.MaskedTextBox1.Text
        nmeFolder = Form3.MaskedTextBox2.Text
        nmeSubFolder = Form3.MaskedTextBox3.Text
        For i1 = 1 To Val(Form3.MaskedTextBox4.Text)
            Form3.ListBox1.Items.Add(nmeFolder & Str(i1))
            For i2 = 1 To Val(Form3.MaskedTextBox5.Text)
                Form3.ListBox1.Items.Add("........" & nmeSubFolder & Str(i2))
            Next i2
        Next i1
    End Sub
    Public Sub open()
        Shell("start" & Form3.MaskedTextBox1.Text)
    End Sub
End Module
