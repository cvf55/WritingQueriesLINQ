Public Class Student
    Public Property First As String
    Public Property Last As String
    Public Property Year As String
    Public Property Rank As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal firstName As String,
                   ByVal lastName As String,
                   ByVal studentYear As String,
                   ByVal studentRank As Integer)
        First = firstName
        Last = lastName
        Year = studentYear
        Rank = studentRank
    End Sub
End Class
