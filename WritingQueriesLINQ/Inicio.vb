Imports System.Linq

Module Inicio

    Sub Main()
        Dim dFecha As Date = Date.Now

        ' Crear una lista de studiantes
        Dim students = GetStudents()

        ' Mostrar los nombres de los estudiantes
        DisplayList(students)

        'Creamos la consulta LINQ sobre la lista.
        'Como se puede observar, studentQuery infiere su tipo de datos de currentStudent y este obtiene su tipo de datos de IEnumerable
        Dim studentQuery = From currentStudent In students
                           Where currentStudent.Rank <= 10
                           Select currentStudent
                           Order By currentStudent.Last Ascending, currentStudent.First Ascending

        'Recorermos la consulta
        Console.Clear()
        Debug.AutoFlush = True

        Debug.Print("Comenzamos " & Format(dFecha, "yyyyMMdd hh:mm:ss"))
        Debug.Indent()
        For Each studentRecord In studentQuery
            Console.WriteLine(studentRecord.Last & ", " & studentRecord.First)
            Debug.Print(studentRecord.Last & ", " & studentRecord.First)
        Next
        Debug.Unindent()
        Debug.Print("Finalizamos " & Format(dFecha, "yyyyMMdd hh:mm:ss"))

    End Sub

    ''' <summary>
    ''' Muestra en consola los nombres de los estudiantes en la lista.
    ''' </summary>
    ''' <param name="studentCol"></param>
    Private Sub DisplayList(ByVal studentCol As IEnumerable(Of Student))
        For Each st As Student In studentCol
            Console.WriteLine("First Name: " & st.First)
            Console.WriteLine(" Last Name: " & st.Last)
            Console.WriteLine()
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>Devuelve una lista de objetos Student</returns>
    Private Function GetStudents() As IEnumerable(Of Student)
        Return New List(Of Student) From
            {
             New Student("Michael", "Tucker", "Junior", 10),
             New Student("Svetlana", "Omelchenko", "Senior", 2),
             New Student("Michiko", "Osada", "Senior", 7),
             New Student("Sven", "Mortensen", "Freshman", 53),
             New Student("Hugo", "Garcia", "Junior", 16),
             New Student("Cesar", "Garcia", "Freshman", 4),
             New Student("Fadi", "Fakhouri", "Senior", 72),
             New Student("Hanying", "Feng", "Senior", 11),
             New Student("Debra", "Garcia", "Junior", 41),
             New Student("Lance", "Tucker", "Junior", 60),
             New Student("Terry", "Adams", "Senior", 6)
            }
    End Function
End Module
