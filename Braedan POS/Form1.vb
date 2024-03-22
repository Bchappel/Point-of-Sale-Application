Public Class Form1

    Dim subtotal As Decimal = 0
    Dim tax As Decimal = 0
    Dim total As Decimal = 0
    Dim HST As Decimal = 0.13

    Dim Payment As Double = 0
    Dim Change As Double = 0

    'GPUs
    Dim GTX970 As Decimal = 199.99
    Dim GTX980 As Decimal = 225.49
    Dim GTX980ti As Decimal = 349.49
    Dim GTX1060 As Decimal = 310.99
    Dim GTX1070 As Decimal = 379.99
    Dim GTX1070ti As Decimal = 449.99
    Dim GTX1080 As Decimal = 559.95
    Dim GTX1080ti As Decimal = 765.99
    Dim RTX2070 As Decimal = 575.49
    Dim RTX2080 As Decimal = 1105.27
    Dim RTX2080ti As Decimal = 1958.98
    Dim RTXTitan As Decimal = 3999.95
    Dim TitanV As Decimal = 2999.99
    Dim TitanXP As Decimal = 1350.99

    'CPUs
    Dim I39350k As Decimal = 190.96
    Dim I38350k As Decimal = 169.99
    Dim I59600K As Decimal = 395.99
    Dim I58600K As Decimal = 279.95
    Dim I79700K As Decimal = 549.99
    Dim i78086K As Decimal = 879.99
    Dim Ryzen5 As Decimal = 249.76
    Dim Ryzen7 As Decimal = 440.88
    Dim Ryzen9 As Decimal = 567.99


    Private Sub btnGTX970_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX970.Click
        subtotal = subtotal + GTX970        'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS GTX970 - $" & GTX970)

        btnCheckout.Visible = True


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbReceipt.Items.Add("BC Computers")
        lbReceipt.Items.Add("Guelph, Ontario")
        lbReceipt.Items.Add("(519) 993-1304")
        lbReceipt.Items.Add(Now)
        lbReceipt.Items.Add("===============================")
    End Sub

    Private Sub btnGTX980_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX980.Click
        subtotal = subtotal + GTX980        'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG GTX980 - $" & GTX980)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnGTX980ti_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX980ti.Click
        subtotal = subtotal + GTX980ti       'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("GTX980ti - $" & GTX980ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnGTX1060_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1060.Click
        subtotal = subtotal + GTX1060      'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("GTX1060 - $" & GTX1060)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnGTX970_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX970.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX970
        tbPricePreview.Text = "GPU: $" & GTX970
    End Sub

    Private Sub btnGTX980_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX980.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX980
        tbPricePreview.Text = "GPU: $" & GTX980
    End Sub

    Private Sub btnGTX980ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX980ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGAGTX980ti
        tbPricePreview.Text = "GPU: $" & GTX980ti
    End Sub

    Private Sub btnGTX1060_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1060.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGAGTX1060
        tbPricePreview.Text = "GPU: $" & GTX1060

    End Sub

    Private Sub btnGTX1070_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1070.Click
        subtotal = subtotal + GTX1070     'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("GTX1070 - $" & GTX1070)
    End Sub

    Private Sub btnGTX1070_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1070.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX1070
        tbPricePreview.Text = "GPU: $" & GTX1070
    End Sub

    Private Sub Button10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1070.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGAGTX1070
        tbPricePreview.Text = "GPU: $" & GTX1070
    End Sub

    Private Sub btnCheckout_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckout.Click
        btnCash.Visible = True
        btnCredit.Visible = True
        btnCheckout.Visible = False
        'GPU Sheild
        pbSheild.Visible = True
        'CPU Sheild
        pbCPUSheild.Visible = True
    End Sub

    Private Sub btnCredit_Click(sender As System.Object, e As System.EventArgs) Handles btnCredit.Click
        lbReceipt.Items.Add(" ")
        lbReceipt.Items.Add("Paid by Credit - Approved")
        lbReceipt.Items.Add("Thank You Come Again")

        btnCheckout.Visible = False
        btnCash.Visible = False
        btnCredit.Visible = False
        btnNext.Visible = True
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        subtotal = 0
        tbSubtotal.Text = "$" & subtotal
        tax = 0

        tbTax.Text = "$" & tax
        total = 0

        tbTotal.Text = "$" & total
        Payment = 0

        tbPayment.Text = Payment
        Change = 0

        lbReceipt.Items.Clear()
        lbReceipt.Items.Add("BC Computers")
        lbReceipt.Items.Add("Guelph, Ontario")
        lbReceipt.Items.Add("(519) 993-1304")
        lbReceipt.Items.Add(Now)
        lbReceipt.Items.Add("==========================================================")

        btnCheckout.Visible = False
        btnCash.Visible = False
        btnCredit.Visible = False
        btnNext.Visible = False
        btnPay.Visible = False
        tbPayment.Visible = False


        pbSheild.Visible = False
        pbCPUSheild.Visible = False

    End Sub

    Private Sub btnASUSGTX980ti_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX980ti.Click
        subtotal = subtotal + GTX980ti     'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG GTX980ti - $" & GTX980ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSGTX980ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX980ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX980ti
        tbPricePreview.Text = "GPU: $" & GTX980ti
    End Sub

    Private Sub btnASUSGTX1070ti_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1070ti.Click
        subtotal = subtotal + GTX1070ti     'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG STRIX GTX1070ti - $" & GTX1070ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSGTX1070ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1070ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX1070ti
        tbPricePreview.Text = "GPU: $" & GTX1070ti
    End Sub

    Private Sub btnASUSGTX1080_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1080.Click
        subtotal = subtotal + GTX1080    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG STRIX GTX1080 - $" & GTX1080)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSGTX1080_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1080.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX1080
        tbPricePreview.Text = "GPU: $" & GTX1080
    End Sub

    Private Sub btnEVGAGTX1080_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1080.Click
        subtotal = subtotal + GTX1080    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("EVGA GTX1080 - $" & GTX1080)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnEVGAGTX1080_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1080.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGAGTX1080FE
        tbPricePreview.Text = "GPU: $" & GTX1080
    End Sub

    Private Sub btnASUSGTX1080ti_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1080ti.Click
        subtotal = subtotal + GTX1080ti    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG STRIX GTX1080ti - $" & GTX1080ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSGTX1080ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSGTX1080ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSGTX1080ti
        tbPricePreview.Text = "GPU: $" & GTX1080ti
    End Sub

    Private Sub btnEVGAGTX1080ti_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1080ti.Click
        subtotal = subtotal + GTX1080ti    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add(" EVGA GTX 1080ti FE - $" & GTX1080ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnEVGAGTX1080ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1080ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGAGTX1080ti
        tbPricePreview.Text = "GPU: $" & GTX1080ti
    End Sub

    Private Sub btnEVGARTX2070_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGARTX2070.Click
        subtotal = subtotal + RTX2070    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("EVGA RTX 2070 - $" & RTX2070)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnEVGARTX2070_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGARTX2070.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGARTX2070
        tbPricePreview.Text = "GPU: $" & RTX2070
    End Sub

    Private Sub btnASUSRTX2070_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2070.Click
        subtotal = subtotal + RTX2070    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS RTX 2070 - $" & RTX2070)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSRTX2070_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2070.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSRTX2070
        tbPricePreview.Text = "GPU: $" & RTX2070
    End Sub

    Private Sub btnASUSRTX2080_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2080.Click
        subtotal = subtotal + RTX2080    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG Strix RTX 2080 - $" & RTX2080)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSRTX2080_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2080.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSRTX2080
        tbPricePreview.Text = "GPU: $" & RTX2080
    End Sub

    Private Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnPay.Click

        Try
            Payment = tbPayment.Text
            ' check if the payment
            If Payment >= total Then
                Change = Payment - total

                lbReceipt.Items.Add(" ")
                lbReceipt.Items.Add("Cash Paid: $" & Payment)
                lbReceipt.Items.Add("Change: $" & Change)
                lbReceipt.Items.Add(" ")
                lbReceipt.Items.Add("Have an excellent day")
                btnNext.Visible = True
            Else
                MessageBox.Show("Insufficient Funds: Restart Transaction")
                Application.Restart()
            End If

        Catch ex As Exception
            MessageBox.Show("Insufficient Funds: Restart Transaction")
            Application.Restart()
        End Try

        If btnPay.Visible = True Then
            btnPay.Visible = False
            tbPayment.Visible = False
        End If

    End Sub

    Private Sub btnCash_Click(sender As System.Object, e As System.EventArgs) Handles btnCash.Click
        btnCheckout.Visible = False
        btnPay.Visible = True
        tbPayment.Visible = True
        btnCash.Visible = False
        btnCredit.Visible = False
    End Sub

    Private Sub btnASUSRTX2080ti_Click(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2080ti.Click
        subtotal = subtotal + RTX2080ti    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("ASUS ROG Strix RTX 2080ti - $" & RTX2080ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnASUSRTX2080ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnASUSRTX2080ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ASUSRTX2080ti
        tbPricePreview.Text = "GPU: $" & RTX2080ti
    End Sub

    Private Sub btnEVGARTX2080ti_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGARTX2080ti.Click
        subtotal = subtotal + RTX2080ti    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("EVGA RTX 2080ti - $" & RTX2080ti)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnEVGARTX2080ti_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnEVGARTX2080ti.MouseEnter
        pbPreview.BackgroundImage = My.Resources.EVGARTX2080ti
        tbPricePreview.Text = "GPU: $" & RTX2080ti
    End Sub

    Private Sub btnRTXTITAN_Click(sender As System.Object, e As System.EventArgs) Handles btnRTXTITAN.Click
        subtotal = subtotal + RTXTitan    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Nvidia RTX Titan - $" & RTXTitan)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnRTXTITAN_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnRTXTITAN.MouseEnter
        pbPreview.BackgroundImage = My.Resources.RTX_TITAN
        tbPricePreview.Text = "GPU: $" & RTXTitan
    End Sub

    Private Sub btnTitanV_Click(sender As System.Object, e As System.EventArgs) Handles btnTitanV.Click
        subtotal = subtotal + TitanV    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Nvidia Titan V - $" & TitanV)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnTitanV_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnTitanV.MouseEnter
        pbPreview.BackgroundImage = My.Resources.TitanV
        tbPricePreview.Text = "GPU: $" & TitanV
    End Sub

    Private Sub btnTitanXP_Click(sender As System.Object, e As System.EventArgs) Handles btnTitanXP.Click
        subtotal = subtotal + TitanXP    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Nvidia Titan XP - $" & TitanXP)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnTitanXP_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnTitanXP.MouseEnter
        pbPreview.BackgroundImage = My.Resources.titanXP
        tbPricePreview.Text = "GPU: $" & TitanXP
    End Sub

    Private Sub btnEVGAGTX1070_Click(sender As System.Object, e As System.EventArgs) Handles btnEVGAGTX1070.Click
        subtotal = subtotal + GTX1070   'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("EVGA SuperClocked - $" & GTX1070)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn9350K_Click(sender As System.Object, e As System.EventArgs) Handles btn9350K.Click
        subtotal = subtotal + I39350k    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i3 9350K @ 4.0 GHZ - $" & I39350k)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn9350K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn9350K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i3_9350K
        tbPricePreview.Text = "CPU: $" & I39350k
    End Sub

    Private Sub btn9600K_Click(sender As System.Object, e As System.EventArgs) Handles btn9600K.Click
        subtotal = subtotal + I59600K    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i5 9600K @ 3.6 GHZ - $" & I59600K)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn9600K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn9600K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i5_9600K
        tbPricePreview.Text = "CPU: $" & I59600K
    End Sub

    Private Sub btn9700K_Click(sender As System.Object, e As System.EventArgs) Handles btn9700K.Click
        subtotal = subtotal + I79700K    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i7 9700K @ 3.6 GHZ - $" & I79700K)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn9700K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn9700K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i7_9700K
        tbPricePreview.Text = "CPU: $" & I79700K
    End Sub

    Private Sub btn8350K_Click(sender As System.Object, e As System.EventArgs) Handles btn8350K.Click
        subtotal = subtotal + I38350k    'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i3 8350K @ 4.0 GHZ - $" & I38350k)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn8350K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn8350K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i3_8350K
        tbPricePreview.Text = "CPU: $" & I38350k
    End Sub

    Private Sub btn8600K_Click(sender As System.Object, e As System.EventArgs) Handles btn8600K.Click
        subtotal = subtotal + I58600K  'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i5 8600K @ 3.6 GHZ - $" & I58600K)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn8600K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn8600K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i5_8600K
        tbPricePreview.Text = "CPU: $" & I58600K
    End Sub

    Private Sub btn8080K_Click(sender As System.Object, e As System.EventArgs) Handles btn8080K.Click
        subtotal = subtotal + i78086K  'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("Intel Core i7 8086K @ 4.0 GHZ - $" & i78086K)

        btnCheckout.Visible = True
    End Sub

    Private Sub btn8080K_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btn8080K.MouseEnter
        pbPreview.BackgroundImage = My.Resources.i7_8086K
        tbPricePreview.Text = "CPU: $" & i78086K
    End Sub

    Private Sub btnRyzen5_Click(sender As System.Object, e As System.EventArgs) Handles btnRyzen5.Click
        subtotal = subtotal + Ryzen5 'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("AMD Ryzen 5 3600X - $" & Ryzen5)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnRyzen5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnRyzen5.MouseEnter
        pbPreview.BackgroundImage = My.Resources.Ryzen5
        tbPricePreview.Text = "CPU: $" & Ryzen5
    End Sub

    Private Sub btnRyzen7_Click(sender As System.Object, e As System.EventArgs) Handles btnRyzen7.Click
        subtotal = subtotal + Ryzen7 'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total
        lbReceipt.Items.Add("AMD Ryzen 7 3700X - $" & Ryzen7)
        btnCheckout.Visible = True

    End Sub

    Private Sub btnRyzen7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnRyzen7.MouseEnter
        pbPreview.BackgroundImage = My.Resources.ryzen7
        tbPricePreview.Text = "CPU: $" & Ryzen7
    End Sub

    Private Sub btnRyzen9_Click(sender As System.Object, e As System.EventArgs) Handles btnRyzen9.Click
        subtotal = subtotal + Ryzen9 'add up the items
        tbSubtotal.Text = "$" & subtotal

        tax = subtotal * HST                'calculate tax
        tax = Math.Round(tax, 2)
        tbTax.Text = "$" & tax

        total = subtotal + tax              'calculate total
        tbTotal.Text = "$" & total

        lbReceipt.Items.Add("AMD Ryzen 9 3900X - $" & Ryzen9)

        btnCheckout.Visible = True
    End Sub

    Private Sub btnRyzen9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnRyzen9.MouseEnter
        pbPreview.BackgroundImage = My.Resources.Ryzen9
        tbPricePreview.Text = "CPU: $" & Ryzen9
    End Sub

End Class
