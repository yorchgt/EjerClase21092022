Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Dim i As Integer



    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CalculadoraDataSet.TResultado' Puede moverla o quitarla según sea necesario.
        Me.TResultadoTableAdapter.Fill(Me.CalculadoraDataSet.TResultado)
        conexion.ConnectionString = "Data Source=DESKTOP-L6C8A8M\SQLEXPRESS;Initial Catalog=Calculadora;Integrated Security=True"
        conexion.Open()
        comando.Connection = conexion
        Try
            Dim da As New SqlDataAdapter(comando)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables("TResultado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TxtResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        EvaluayHazOperacion()
        Operacion = ""
        comando = conexion.CreateCommand()
        comando.CommandType = CommandType.Text
        comando.CommandText = "insert into TResultado (Resultado) values (" & TxtResultado.Text & ")"
        comando.ExecuteNonQuery()

    End Sub
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TxtResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            TxtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then

            TxtResultado.Text = ""
            SePresionaOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = ""
        End If
    End Sub


End Class
