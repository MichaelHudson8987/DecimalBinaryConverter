Imports Microsoft.Win32

Public Class Form1

    '#Calculate button click#
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormatValidate As String = ""
        Dim NumericTest As String
        Dim UserInput As String()
        Dim ConversionOutput As String = ""
        Dim BitNumber As Integer = 128
        Dim DecimalSection As Integer = 0
        Dim BinarySection As Integer = 0
        Dim validBinary As Integer = 1
        Dim Counter As Integer
        Dim Counter2 As Integer

        '#Decimal to binary#
        If txtBinary.ReadOnly = True Then

            NumericTest = Replace(txtDecimal.Text, ".", "0") 'Replaces any periods in input with numbers for IsNumeric verification
            UserInput = Split(txtDecimal.Text, ".") 'Splits input into an array of substrings (decimal sections), separated by delimiter (period)

            '#Validation#
            'Validating input only contains numbers
            If Not IsNumeric(NumericTest) Then
                MsgBox("IP decimal is invalid. Must contain only numbers and periods")
                txtDecimal.Text = ""

                'Validating that input has been split into an array of 4 substrings (decimal sections)
            ElseIf UserInput.Count = 4 Then

                For Counter2 = 0 To 3

                    'If any decimal sections are less than 3 digits long, add 1 or 2 "0"s to force format conformity
                    'Each decimal section is then combined to one validation string
                    If UserInput(Counter2).Length = 1 Then
                        FormatValidate = FormatValidate + "00" + UserInput(Counter2)

                    ElseIf UserInput(Counter2).Length = 2 Then
                        FormatValidate = FormatValidate + "0" + UserInput(Counter2)

                    ElseIf UserInput(Counter2).Length = 3 Then
                        FormatValidate += UserInput(Counter2)

                    End If

                    'Adding period to the validation string
                    If Counter2 < 3 Then
                        FormatValidate += "."

                    End If

                Next

                'Validating that validation string follows format
                If Not FormatValidate Like ("###.###.###.###") Then
                    MsgBox("IP decimal is invalid. Must follow format: #.#.#.#")
                    txtDecimal.Text = ""

                    'Validating decimal sections aren't higher than 255
                ElseIf ((UserInput(0) Or UserInput(1) Or UserInput(2) Or UserInput(3)) > 255) Then
                    MsgBox("IP decimal is invalid. Values must be 255 or lower")
                    txtDecimal.Text = ""

                Else
                    DecimalSection = UserInput(Counter)

                    '#Converting decimal input to binary#
                    For Counter = 0 To 3

                        'Adding "." to output in between each conversion. 
                        If (Counter > 0) And (Counter < 4) Then
                            ConversionOutput += "."

                            'Resetting decimal section to counter number after every loop
                            DecimalSection = UserInput(Counter)

                        End If

                        'Resetting bit number to 128 so conversion can be repeated
                        BitNumber = 128

                        'Add all 0's to output if decimal section is 0
                        If DecimalSection = 0 Then
                            ConversionOutput += "00000000"

                        End If

                        'Repeats until decimal section equals 0
                        While DecimalSection > 0

                            'If decimal section is HIGHER or EQUAL to bit number, "1" is added to output string and bit number is subtracted from decimal. Bit number is then divided by 2
                            If DecimalSection >= BitNumber Then
                                ConversionOutput += "1"
                                DecimalSection -= BitNumber
                                BitNumber /= 2

                                'Adds remaining "0"s to output string if decimal section already equals 0
                                If DecimalSection = 0 Then

                                    While BitNumber > 0
                                        ConversionOutput +=
"0"
                                        BitNumber /= 2

                                    End While

                                End If

                            Else
                                'If decimal section is LOWER than bit number, "0" is added to output string and bit number is subtracted from decimal. Bit number is then divided by 2
                                ConversionOutput += "0" '
                                BitNumber /= 2

                            End If
                        End While
                    Next
                End If
            Else
                'If array is not 4, display error message
                MsgBox("IP address is invalid. Must follow format: #.#.#.#")
                txtDecimal.Text = ""

            End If

            'Outputting binary output string to text box
            txtBinary.Text = ConversionOutput

            '#Binary to decimal#
        ElseIf txtDecimal.ReadOnly = True Then
            NumericTest = Replace(txtBinary.Text, ".", "0")
            UserInput = Split(txtBinary.Text, ".")
            FormatValidate = txtBinary.Text

            '#Validation#
            'Validating input only contains numbers
            If Not IsNumeric(NumericTest) Then
                MsgBox("Binary input is invalid. Must contain only numbers and periods")
                txtBinary.Text = ""
                txtDecimal.Text = ""
                validBinary = 0

                'Validating input is in an array of 4 substrings (binary sections)
            ElseIf UserInput.Count = 4 Then
                If Not FormatValidate Like ("########.########.########.########") Then
                    MsgBox("Binary input is invalid. Must follow format: ########.########.########.########")
                    txtBinary.Text = ""
                    txtDecimal.Text = ""
                    validBinary = 0

                    'Validating input contains only "0", "1", or "."
                Else
                    For IntCount = 0 To FormatValidate.Length - 1
                        If FormatValidate(IntCount) = "0" Or FormatValidate(IntCount) = "1" Or FormatValidate(IntCount) = "." Then
                            Continue For

                        Else
                            MsgBox("Binary input is invalid. Must contain only 1's, 0's, and periods.")
                            txtBinary.Text = ""
                            txtDecimal.Text = ""
                            validBinary = 0
                            Exit For

                        End If
                    Next
                End If

                'Outputting error if input is invalid
            Else
                MsgBox("Binary input is invalid. Must follow format: ########.########.########.########")
                txtBinary.Text = ""
                txtDecimal.Text = ""
                validBinary = 0

            End If

            'Resetting bit number
            BitNumber = 128

            'Adding bit number value to binary section if position in string is "1", nothing if "0". If position is ".", binary section is added
            'to conversion output. Bitnumber is divided by 2 after every loop.
            For IntCount = 0 To FormatValidate.Length - 1
                If FormatValidate(IntCount) = "1" Then
                    BinarySection += BitNumber
                    BitNumber /= 2

                ElseIf FormatValidate(IntCount) = "0" Then
                    BitNumber /= 2

                ElseIf FormatValidate(IntCount) = "." Then
                    ConversionOutput += CStr(BinarySection)
                    ConversionOutput += "."
                    BitNumber = 128
                    BinarySection = 0

                End If

            Next

            'Outputting last binary section to output string
            ConversionOutput += CStr(BinarySection)

            'Outputting conversion string to decimal textbox if binary input is valid
            If validBinary = 1 Then
                txtDecimal.Text = ConversionOutput

            End If
        End If
    End Sub

    '#Clear button click#
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDecimal.Text = ""
        txtBinary.Text = ""
    End Sub

    '#Enter equals Calculate button press (decimal)#
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDecimal.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    '#Enter equals Calculate button press (binary)#
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBinary.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub
    '#Binary to decimal button pressed#
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtDecimal.ReadOnly = True
        txtBinary.ReadOnly = False
        txtDecimal.Text = ""
    End Sub

    '#Decimal to binary button pressed#
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtDecimal.ReadOnly = False
        txtBinary.ReadOnly = True
        txtBinary.Text = ""
    End Sub
End Class
