Public Class Calc
    Dim choose As String
    Private Sub Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.BMI' table. You can move, or remove it, as needed.
        Me.BMITableAdapter.Fill(Me.Soldier_RosterDataSet.BMI)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("PLEASE ADD A SOLDIER AND THE BMI CALCULATOR FOR THE SOLDIER", "ADD")
            Me.BMIBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        RanLastTextBox.Text = RankTextBox.Text & " " & LastNameTextBox.Text
        Try
            Me.Validate()
            Me.BMIBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show("SOLDIER AND BMI CALCULATION SAVED!", "SAVE")
            Splash3.MdiParent = MainForm
            Splash3.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("WOULD YOU LIKE TO DELETE THIS SOLDIER AND BMI CALCULATIONS?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("SOLDIER AND BMI CALCULATIONS DELETED", "DELETE")
                Me.BMIBindingSource.RemoveCurrent()
                Me.Validate()
                Me.BMIBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("BMI CALCULATOR UPDATED!", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        choose = GENDERComboBox.Text
        Dim waist, neck, height, hip, bim As Double
        Dim weight, total As Integer
        weight = Val(WEIGHTTextBox.Text)
        height = Val(HEIGHTTextBox.Text)
        neck = Val(NECKTextBox.Text)
        waist = Val(WAISTTextBox.Text)
        hip = Val(HIPSTextBox.Text)

        Try
            If chk1720.Checked Then
                If AGETextBox.Text = 17 Or 18 Or 19 Or 20 Then
                    bim = 86.001 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Or 59 Or 60 Then
                        total = weight - 132
                        lblWeight.Text = "132 LBS"
                        If weight < 132 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 132) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 132) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 136
                        lblWeight.Text = "136 LBS"
                        If weight < 136 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 136) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 136) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 141
                        lblWeight.Text = "141 LBS"
                        If weight < 141 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 141) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 141) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 145
                        lblWeight.Text = "145 LBS"
                        If weight < 145 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 145) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 145) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 150
                        lblWeight.Text = "150 LBS"
                        If weight < 150 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 150) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 150) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 155
                        lblWeight.Text = "155 LBS"
                        If weight < 155 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 155) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 155) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 160
                        lblWeight.Text = "160 LBS"
                        If weight < 160 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 160) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 160) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 165
                        lblWeight.Text = "165 LBS"
                        If weight < 165 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 165) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 165) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 170
                        lblWeight.Text = "170 LBS"
                        If weight < 170 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 170) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 170) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 175
                        lblWeight.Text = "175 LBS"
                        If weight < 175 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 175) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 175) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 180
                        lblWeight.Text = "180 LBS"
                        If weight < 180 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 180) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 180) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 185
                        lblWeight.Text = "185 LBS"
                        If weight < 185 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 185) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 185) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 190
                        lblWeight.Text = "190 LBS"
                        If weight < 190 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 190) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 190) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 195
                        lblWeight.Text = "195 LBS"
                        If weight < 195 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 195) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 195) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 201
                        lblWeight.Text = "201 LBS"
                        If weight < 201 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 201) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 201) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 206
                        lblWeight.Text = "206 LBS"
                        If weight < 206 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 206) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 206) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 212
                        lblWeight.Text = "212 LBS"
                        If weight < 212 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 212) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 212) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 218
                        lblWeight.Text = "218 LBS"
                        If weight < 218 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 218) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 218) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 223
                        lblWeight.Text = "223 LBS"
                        If weight < 223 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 223) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 223) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 229
                        lblWeight.Text = "229 LBS"
                        If weight < 229 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 229) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 229) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 234
                        lblWeight.Text = "234 LBS"
                        If weight < 234 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 234) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 234) & " OVER"
                        End If
                    End If
                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "20%"
                    lblFat.Visible = True
                    lblFat.Text = "20%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 20 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chk2127.Checked Then
                If AGETextBox.Text = 21 Or 22 Or 23 Or 24 Or 25 Or 26 Or 27 Then
                    bim = 86.001 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Or 59 Or 60 Then
                        total = weight - 136
                        lblWeight.Text = "136 LBS"
                        If weight < 136 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 136) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 136) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 140
                        lblWeight.Text = "140 LBS"
                        If weight < 140 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 140) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 140) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 144
                        lblWeight.Text = "144 LBS"
                        If weight < 144 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 144) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 144) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 149
                        lblWeight.Text = "149 LBS"
                        If weight < 149 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 149) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 149) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 154
                        lblWeight.Text = "154 LBS"
                        If weight < 154 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 154) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 154) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 159
                        lblWeight.Text = "159 LBS"
                        If weight < 159 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 159) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 159) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 163
                        lblWeight.Text = "163 LBS"
                        If weight < 163 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 163) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 163) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 169
                        lblWeight.Text = "169 LBS"
                        If weight < 169 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 169) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 169) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 174
                        lblWeight.Text = "174 LBS"
                        If weight < 174 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 174) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 174) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 179
                        lblWeight.Text = "179 LBS"
                        If weight < 179 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 179) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 179) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 185
                        lblWeight.Text = "185 LBS"
                        If weight < 185 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 185) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 185) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 189
                        lblWeight.Text = "189 LBS"
                        If weight < 189 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 189) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 189) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 195
                        lblWeight.Text = "195 LBS"
                        If weight < 195 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 195) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 195) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 200
                        lblWeight.Text = "200 LBS"
                        If weight < 200 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 200) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 200) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 206
                        lblWeight.Text = "206 LBS"
                        If weight < 206 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 206) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 206) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 212
                        lblWeight.Text = "212 LBS"
                        If weight < 212 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 212) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 212) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 217
                        lblWeight.Text = "217 LBS"
                        If weight < 217 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 217) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 217) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 223
                        lblWeight.Text = "223 LBS"
                        If weight < 223 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 223) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 223) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 229
                        lblWeight.Text = "229 LBS"
                        If weight < 229 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 229) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 229) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 235
                        lblWeight.Text = "235 LBS"
                        If weight < 235 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 235) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 235) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 240
                        lblWeight.Text = "240 LBS"
                        If weight < 240 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 240) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 240) & " OVER"
                        End If
                    End If
                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "22%"
                    lblFat.Visible = True
                    lblFat.Text = "22%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 22 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chk2839.Checked Then
                If AGETextBox.Text = 28 Or 29 Or 30 Or 31 Or 32 Or 33 Or 34 Or 35 Or 36 Or 37 Or 38 Or 39 Then
                    bim = 86.001 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Or 59 Or 60 Then
                        total = weight - 139
                        lblWeight.Text = "139 LBS"
                        If weight < 139 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 139) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 139) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 144
                        lblWeight.Text = "144 LBS"
                        If weight < 144 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 144) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 144) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 148
                        lblWeight.Text = "148 LBS"
                        If weight < 148 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 148) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 148) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 153
                        lblWeight.Text = "153 LBS"
                        If weight < 153 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 153) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 153) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 158
                        lblWeight.Text = "158 LBS"
                        If weight < 158 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 158) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 158) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 163
                        lblWeight.Text = "163 LBS"
                        If weight < 163 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 163) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 163) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 168
                        lblWeight.Text = "168 LBS"
                        If weight < 168 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 168) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 168) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 174
                        lblWeight.Text = "174 LBS"
                        If weight < 174 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 174) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 174) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 179
                        lblWeight.Text = "179 LBS"
                        If weight < 179 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 179) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 179) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 184
                        lblWeight.Text = "184 LBS"
                        If weight < 184 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 184) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 184) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 189
                        lblWeight.Text = "189 LBS"
                        If weight < 189 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 189) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 189) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 194
                        lblWeight.Text = "194 LBS"
                        If weight < 194 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 194) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 194) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 200
                        lblWeight.Text = "200 LBS"
                        If weight < 200 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 200) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 200) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 205
                        lblWeight.Text = "205 LBS"
                        If weight < 205 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 205) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 205) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 211
                        lblWeight.Text = "211 LBS"
                        If weight < 211 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 211) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 211) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 217
                        lblWeight.Text = "217 LBS"
                        If weight < 217 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 217) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 217) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 223
                        lblWeight.Text = "223 LBS"
                        If weight < 223 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 223) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 223) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 229
                        lblWeight.Text = "229 LBS"
                        If weight < 229 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 229) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 229) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 235
                        lblWeight.Text = "235 LBS"
                        If weight < 235 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 235) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 235) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 241
                        lblWeight.Text = "241 LBS"
                        If weight < 241 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 241) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 241) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 247
                        lblWeight.Text = "247 LBS"
                        If weight < 247 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 247) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 247) & " OVER"
                        End If
                    End If
                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "24%"
                    lblFat.Visible = True
                    lblFat.Text = "24%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim >= 24 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chk40.Checked Then
                If AGETextBox.Text >= 40 Then
                    bim = 86.001 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Or 59 Or 60 Then
                        total = weight - 141
                        lblWeight.Text = "141 LBS"
                        If weight < 141 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 141) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 141) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 146
                        lblWeight.Text = "146 LBS"
                        If weight < 146 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 146) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 146) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 150
                        lblWeight.Text = "150 LBS"
                        If weight < 150 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 150) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 150) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 155
                        lblWeight.Text = "155 LBS"
                        If weight < 155 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 155) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 155) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 160
                        lblWeight.Text = "160 LBS"
                        If weight < 160 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 160) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 160) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 165
                        lblWeight.Text = "165 LBS"
                        If weight < 165 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 165) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 165) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 170
                        lblWeight.Text = "170 LBS"
                        If weight < 170 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 170) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 170) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 176
                        lblWeight.Text = "176 LBS"
                        If weight < 176 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 176) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 176) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 181
                        lblWeight.Text = "181 LBS"
                        If weight < 181 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 181) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 181) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 186
                        lblWeight.Text = "186 LBS"
                        If weight < 186 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 186) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 186) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 192
                        lblWeight.Text = "192 LBS"
                        If weight < 192 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 192) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 192) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 197
                        lblWeight.Text = "197 LBS"
                        If weight < 197 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 197) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 197) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 203
                        lblWeight.Text = "203 LBS"
                        If weight < 203 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 203) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 203) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 208
                        lblWeight.Text = "208 LBS"
                        If weight < 208 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 208) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 208) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 214
                        lblWeight.Text = "214 LBS"
                        If weight < 214 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 214) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 214) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 220
                        lblWeight.Text = "220 LBS"
                        If weight < 220 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 220) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 220) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 226
                        lblWeight.Text = "226 LBS"
                        If weight < 226 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 226) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 226) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 232
                        lblWeight.Text = "232 LBS"
                        If weight < 232 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 232) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 232) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 238
                        lblWeight.Text = "238 LBS"
                        If weight < 238 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 238) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 238) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 244
                        lblWeight.Text = "244 LBS"
                        If weight < 244 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 244) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 244) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 250
                        lblWeight.Text = "250 LBS"
                        If weight < 250 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 250) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 250) & " OVER"
                        End If
                    End If

                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "26%"
                    lblFat.Visible = True
                    lblFat.Text = "26%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 26 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chkFam1720.Checked Then
                If AGETextBox.Text = 17 Or 18 Or 19 Or 20 Then
                    bim = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Then
                        total = weight - 119
                        lblWeight.Text = "119 LBS"
                        If weight < 119 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 119) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 119) & " OVER"
                        End If
                    End If
                    If height = 59 Then
                        total = weight - 124
                        lblWeight.Text = "124 LBS"
                        If weight < 124 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 124) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 124) & " OVER"
                        End If
                    End If
                    If height = 60 Then
                        total = weight - 128
                        lblWeight.Text = "128 LBS"
                        If weight < 128 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 128) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 128) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 132
                        lblWeight.Text = "132 LBS"
                        If weight < 132 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 132) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 132) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 136
                        lblWeight.Text = "136 LBS"
                        If weight < 136 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 136) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 136) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 141
                        lblWeight.Text = "141 LBS"
                        If weight < 165 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 141) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 141) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 145
                        lblWeight.Text = "145 LBS"
                        If weight < 145 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 145) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 145) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 150
                        lblWeight.Text = "150 LBS"
                        If weight < 150 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 150) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 150) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 155
                        lblWeight.Text = "155 LBS"
                        If weight < 155 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 155) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 155) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 159
                        lblWeight.Text = "159 LBS"
                        If weight < 159 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 159) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 159) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 164
                        lblWeight.Text = "164 LBS"
                        If weight < 164 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 164) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 164) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 169
                        lblWeight.Text = "169 LBS"
                        If weight < 169 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 169) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 169) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 174
                        lblWeight.Text = "174 LBS"
                        If weight < 174 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 174) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 174) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 179
                        lblWeight.Text = "179 LBS"
                        If weight < 179 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 179) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 179) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 184
                        lblWeight.Text = "184 LBS"
                        If weight < 184 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 184) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 184) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 189
                        lblWeight.Text = "189 LBS"
                        If weight < 189 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 189) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 189) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 194
                        lblWeight.Text = "194 LBS"
                        If weight < 194 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 194) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 194) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 200
                        lblWeight.Text = "200 LBS"
                        If weight < 200 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 200) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 200) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 205
                        lblWeight.Text = "205 LBS"
                        If weight < 205 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 205) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 205) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 210
                        lblWeight.Text = "210 LBS"
                        If weight < 210 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 210) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 210) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 216
                        lblWeight.Text = "216 LBS"
                        If weight < 216 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 216) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 216) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 221
                        lblWeight.Text = "221 LBS"
                        If weight < 221 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 221) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 221) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 227
                        lblWeight.Text = "227 LBS"
                        If weight < 227 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 227) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 227) & " OVER"
                        End If
                    End If

                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "30%"
                    lblFat.Visible = True
                    lblFat.Text = "30%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 30 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chkFam2127.Checked Then
                If AGETextBox.Text = 21 Or 22 Or 23 Or 24 Or 25 Or 26 Or 27 Then
                    bim = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Then
                        total = weight - 121
                        lblWeight.Text = "121 LBS"
                        If weight < 121 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 121) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 121) & " OVER"
                        End If
                    End If
                    If height = 59 Then
                        total = weight - 125
                        lblWeight.Text = "125 LBS"
                        If weight < 125 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 125) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 125) & " OVER"
                        End If
                    End If
                    If height = 60 Then
                        total = weight - 129
                        lblWeight.Text = "129 LBS"
                        If weight < 129 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 129) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 129) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 134
                        lblWeight.Text = "134 LBS"
                        If weight < 134 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 134) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 134) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 138
                        lblWeight.Text = "138 LBS"
                        If weight < 138 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 138) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 138) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 143
                        lblWeight.Text = "143 LBS"
                        If weight < 143 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 143) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 143) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 147
                        lblWeight.Text = "147 LBS"
                        If weight < 147 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 147) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 147) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 152
                        lblWeight.Text = "152 LBS"
                        If weight < 152 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 152) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 152) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 156
                        lblWeight.Text = "156 LBS"
                        If weight < 156 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 156) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 156) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 161
                        lblWeight.Text = "161 LBS"
                        If weight < 161 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 161) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 161) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 166
                        lblWeight.Text = "166 LBS"
                        If weight < 166 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 166) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 166) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 171
                        lblWeight.Text = "171 LBS"
                        If weight < 171 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 171) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 171) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 176
                        lblWeight.Text = "176 LBS"
                        If weight < 176 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 176) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 176) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 181
                        lblWeight.Text = "181 LBS"
                        If weight < 181 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 181) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 181) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 186
                        lblWeight.Text = "186 LBS"
                        If weight < 186 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 186) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 186) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 191
                        lblWeight.Text = "191 LBS"
                        If weight < 191 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 191) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 191) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 197
                        lblWeight.Text = "197 LBS"
                        If weight < 197 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 197) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 197) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 202
                        lblWeight.Text = "202 LBS"
                        If weight < 202 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 202) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 202) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 207
                        lblWeight.Text = "207 LBS"
                        If weight < 207 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 207) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 207) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 213
                        lblWeight.Text = "213 LBS"
                        If weight < 213 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 213) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 213) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 218
                        lblWeight.Text = "218 LBS"
                        If weight < 218 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 218) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 218) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 224
                        lblWeight.Text = "224 LBS"
                        If weight < 224 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 224) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 224) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 230
                        lblWeight.Text = "230 LBS"
                        If weight < 230 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 230) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 230) & " OVER"
                        End If
                    End If

                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "32%"
                    lblFat.Visible = True
                    lblFat.Text = "32%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 32 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chkFam2839.Checked Then
                If AGETextBox.Text = 28 Or 29 Or 30 Or 31 Or 32 Or 33 Or 34 Or 35 Or 36 Or 37 Or 38 Or 39 Then
                    bim = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Then
                        total = weight - 122
                        lblWeight.Text = "122 LBS"
                        If weight < 122 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 122) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 122) & " OVER"
                        End If
                    End If
                    If height = 59 Then
                        total = weight - 126
                        lblWeight.Text = "126 LBS"
                        If weight < 126 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 126) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 126) & " OVER"
                        End If
                    End If
                    If height = 60 Then
                        total = weight - 131
                        lblWeight.Text = "131 LBS"
                        If weight < 131 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 131) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 131) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 135
                        lblWeight.Text = "135 LBS"
                        If weight < 135 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 135) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 135) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 140
                        lblWeight.Text = "140 LBS"
                        If weight < 140 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 140) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 140) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 144
                        lblWeight.Text = "144 LBS"
                        If weight < 144 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 144) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 144) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 149
                        lblWeight.Text = "149 LBS"
                        If weight < 149 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 149) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 149) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 154
                        lblWeight.Text = "154 LBS"
                        If weight < 154 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 154) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 154) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 158
                        lblWeight.Text = "158 LBS"
                        If weight < 158 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 158) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 158) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 163
                        lblWeight.Text = "163 LBS"
                        If weight < 163 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 163) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 163) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 168
                        lblWeight.Text = "168 LBS"
                        If weight < 168 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 168) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 168) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 173
                        lblWeight.Text = "173 LBS"
                        If weight < 173 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 173) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 173) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 178
                        lblWeight.Text = "178 LBS"
                        If weight < 178 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 178) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 178) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 183
                        lblWeight.Text = "183 LBS"
                        If weight < 183 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 183) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 183) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 188
                        lblWeight.Text = "188 LBS"
                        If weight < 188 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 188) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 188) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 194
                        lblWeight.Text = "194 LBS"
                        If weight < 194 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 194) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 194) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 199
                        lblWeight.Text = "199 LBS"
                        If weight < 199 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 199) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 199) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 204
                        lblWeight.Text = "204 LBS"
                        If weight < 204 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 204) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 204) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 210
                        lblWeight.Text = "210 LBS"
                        If weight < 210 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 210) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 210) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 215
                        lblWeight.Text = "215 LBS"
                        If weight < 215 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 215) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 215) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 221
                        lblWeight.Text = "221 LBS"
                        If weight < 221 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 221) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 221) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 227
                        lblWeight.Text = "227 LBS"
                        If weight < 227 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 227) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 227) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 233
                        lblWeight.Text = "233 LBS"
                        If weight < 233 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 233) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 233) & " OVER"
                        End If
                    End If

                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "34%"
                    lblFat.Visible = True
                    lblFat.Text = "34%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 34 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If

            If chkFam40.Checked Then
                If AGETextBox.Text = 28 Or 29 Or 30 Or 31 Or 32 Or 33 Or 34 Or 35 Or 36 Or 37 Or 38 Or 39 Then
                    bim = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387
                    FATTextBox.Text = Format(bim, 00.00) & "%"

                    If height = 58 Then
                        total = weight - 124
                        lblWeight.Text = "124 LBS"
                        If weight < 124 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 124) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 124) & " OVER"
                        End If
                    End If
                    If height = 59 Then
                        total = weight - 128
                        lblWeight.Text = "128 LBS"
                        If weight < 128 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 128) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 128) & " OVER"
                        End If
                    End If
                    If height = 60 Then
                        total = weight - 133
                        lblWeight.Text = "133 LBS"
                        If weight < 133 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 133) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 133) & " OVER"
                        End If
                    End If
                    If height = 61 Then
                        total = weight - 137
                        lblWeight.Text = "137 LBS"
                        If weight < 137 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 137) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 137) & " OVER"
                        End If
                    End If
                    If height = 62 Then
                        total = weight - 142
                        lblWeight.Text = "142 LBS"
                        If weight < 142 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 142) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 142) & " OVER"
                        End If
                    End If
                    If height = 63 Then
                        total = weight - 146
                        lblWeight.Text = "146 LBS"
                        If weight < 146 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 146) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 146) & " OVER"
                        End If
                    End If
                    If height = 64 Then
                        total = weight - 151
                        lblWeight.Text = "151 LBS"
                        If weight < 151 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 151) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 151) & " OVER"
                        End If
                    End If
                    If height = 65 Then
                        total = weight - 156
                        lblWeight.Text = "156 LBS"
                        If weight < 156 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 156) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 156) & " OVER"
                        End If
                    End If
                    If height = 66 Then
                        total = weight - 161
                        lblWeight.Text = "161 LBS"
                        If weight < 161 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 161) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 161) & " OVER"
                        End If
                    End If
                    If height = 67 Then
                        total = weight - 166
                        lblWeight.Text = "166 LBS"
                        If weight < 166 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 166) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 166) & " OVER"
                        End If
                    End If
                    If height = 68 Then
                        total = weight - 171
                        lblWeight.Text = "171 LBS"
                        If weight < 171 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 171) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 171) & " OVER"
                        End If
                    End If
                    If height = 69 Then
                        total = weight - 176
                        lblWeight.Text = "176 LBS"
                        If weight < 176 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 176) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 176) & " OVER"
                        End If
                    End If
                    If height = 70 Then
                        total = weight - 181
                        lblWeight.Text = "181 LBS"
                        If weight < 181 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 181) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 181) & " OVER"
                        End If
                    End If
                    If height = 71 Then
                        total = weight - 186
                        lblWeight.Text = "186 LBS"
                        If weight < 186 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 186) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 186) & " OVER"
                        End If
                    End If
                    If height = 72 Then
                        total = weight - 191
                        lblWeight.Text = "191 LBS"
                        If weight < 191 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 191) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 191) & " OVER"
                        End If
                    End If
                    If height = 73 Then
                        total = weight - 197
                        lblWeight.Text = "197 LBS"
                        If weight < 197 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 197) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 197) & " OVER"
                        End If
                    End If
                    If height = 74 Then
                        total = weight - 202
                        lblWeight.Text = "202 LBS"
                        If weight < 202 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 202) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 202) & " OVER"
                        End If
                    End If
                    If height = 75 Then
                        total = weight - 208
                        lblWeight.Text = "208 LBS"
                        If weight < 208 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 208) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 208) & " OVER"
                        End If
                    End If
                    If height = 76 Then
                        total = weight - 213
                        lblWeight.Text = "213 LBS"
                        If weight < 213 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 213) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 213) & " OVER"
                        End If
                    End If
                    If height = 77 Then
                        total = weight - 219
                        lblWeight.Text = "219 LBS"
                        If weight < 219 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 219) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 219) & " OVER"
                        End If
                    End If
                    If height = 78 Then
                        total = weight - 225
                        lblWeight.Text = "225 LBS"
                        If weight < 225 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 225) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 225) & " OVER"
                        End If
                    End If
                    If height = 79 Then
                        total = weight - 230
                        lblWeight.Text = "230 LBS"
                        If weight < 230 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 230) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 230) & " OVER"
                        End If
                    End If
                    If height = 80 Then
                        total = weight - 236
                        lblWeight.Text = "236 LBS"
                        If weight < 236 Then
                            lblDifference.ForeColor = Color.Green
                            lblDifference.Text = Val(weight - 236) & " UNDER"
                        Else
                            lblDifference.ForeColor = Color.Red
                            lblDifference.Text = Val(weight - 236) & " OVER"
                        End If
                    End If

                    If total = 0 Then
                        total = 0
                        lblDifference.ForeColor = Color.Green
                        lblDifference.Text = total
                    End If

                    lblWeight.Visible = True
                    lblDifference.Visible = True
                    lblRange.Visible = True
                    lblRange.Text = "EXCELLENT"
                    lblRange.ForeColor = Color.Green
                    lblAllowFat.Visible = True
                    lblAllowFat.Text = "36%"
                    lblFat.Visible = True
                    lblFat.Text = "36%"
                    lblAllowFat.Visible = True
                    lblAllowFat.ForeColor = Color.Green
                    lblAllowFat.Text = Format(bim, 00.00) & "%"
                    lblCompliance.Visible = True
                    lblCompliance.ForeColor = Color.Green
                    lblCompliance.Text = "IN COMPLIENCE"
                    ComplienceTextBox.ForeColor = Color.Green
                    ComplienceTextBox.Text = "IN COMPLIENCE"

                    If bim > 36 Then
                        lblRange.ForeColor = Color.Red
                        lblCompliance.ForeColor = Color.Red
                        lblAllowFat.ForeColor = Color.Red
                        lblRange.Text = "POOR"
                        lblCompliance.Text = "NOT IN COMPLIANCE"
                        ComplienceTextBox.ForeColor = Color.Red
                        ComplienceTextBox.Text = "NOT IN COMPLIENCE"
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        AGETextBox.Clear()
        ComplienceTextBox.Clear()
        HEIGHTTextBox.Clear()
        NECKTextBox.Clear()
        WAISTTextBox.Clear()
        HIPSTextBox.Clear()
        WEIGHTTextBox.Clear()
        FATTextBox.Clear()
        lblWeight.Visible = False
        lblDifference.Visible = False
        lblRange.Visible = False
        lblAllowFat.Visible = False
        lblFat.Visible = False
        lblCompliance.Visible = False
        chk1720.Checked = False
        chk2127.Checked = False
        chk2839.Checked = False
        chk40.Checked = False
        chkFam1720.Checked = False
        chkFam2127.Checked = False
        chkFam2839.Checked = False
        chkFam40.Checked = False
        GENDERComboBox.Text = "MALE"
    End Sub

    Private Sub GENDERComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GENDERComboBox.SelectedIndexChanged
        choose = GENDERComboBox.Text
        If choose = "MALE" Then
            lblHips.Visible = False
            HIPSTextBox.Visible = False
            lblH.Visible = False
            lblAbs.Text = "ABDOMEN"
        End If
        If choose = "FEMALE" Then
            lblHips.Visible = True
            HIPSTextBox.Visible = True
            lblH.Visible = True
            lblAbs.Text = "WAIST"
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
        MainForm.txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BMIRe.Show()
    End Sub
End Class



