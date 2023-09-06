Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        ' Constants
        Const unitPrice As Double = 10.0 ' Price per Quantity
        Const quantity As Integer = 10 ' Quantity
        Const discountPercentage As Double = 20.0 ' Discount
        Const VatAmount As Double = 80 * 15.0 / 100 ' Vat 
        Const totalbeforeVat As Double = 80 'after vat

        Dim totalAmountAfterVAT As Double = totalbeforeVat + VatAmount

        ' Calculate the total amount before applying the discount
        Dim subtotal As Double = unitPrice * quantity

        ' Calculate the discount amount & Vat
        Dim discountAmount As Double = (discountPercentage / 100) * subtotal


        'TOTAL BEFORE VAT
        txtNumber1.Text = "R" & subtotal.ToString("0.00")
        txtNumber2.Text = "R" & discountAmount.ToString("0.00")
        txtTotalbeforeVat.Text = "R" & totalbeforeVat.ToString("0.00")

        'VAT AMOUNT
        txtNumber1.Text = "R" & subtotal.ToString("0.00")
        txtNumber2.Text = "R" & discountAmount.ToString("0.00")
        txtVatAmount.Text = "R" & VatAmount.ToString("0.00")

        'Total After VAT
        txtNumber1.Text = "R" & subtotal.ToString("0.00")
        txtNumber2.Text = "R" & discountAmount.ToString("0.00")
        txtVatAmount.Text = "R" & VatAmount.ToString("0.00")
        txtTotalAfterVat.Text = "R" & totalAmountAfterVAT.ToString("0.00")


    End Sub
End Class
