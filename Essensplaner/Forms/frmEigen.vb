Public Class frmEigen

    Private _name As String
    Property NameSpeise As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    Private _ort As String
    Property Ort As String
        Get
            Return _ort
        End Get
        Set(ByVal Value As String)
            _ort = Value
        End Set
    End Property

    Private _beachten As String
    Property Beachten As String
        Get
            Return _beachten
        End Get
        Set(ByVal Value As String)
            _beachten = Value
        End Set
    End Property

    Private _anzahl As Integer
    Property Anzahl As Integer
        Get
            Return _anzahl
        End Get
        Set(ByVal Value As Integer)
            _anzahl = Value
        End Set
    End Property

    Private _preis As Decimal
    Property Preis As Decimal
        Get
            Return _preis
        End Get
        Set(ByVal Value As Decimal)
            _preis = Value
        End Set
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.NameSpeise = TextBox1.Text
        Me.Ort = TextBox2.Text
        Me.Preis = NumericUpDown1.Value
        Me.Anzahl = CInt(NumericUpDown2.Value)
        Me.Beachten = TextBox3.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class