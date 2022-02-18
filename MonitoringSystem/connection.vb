Imports MySql.Data.MySqlClient
Module connection
    Public Function Mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=leavedb")
    End Function
    Public con As MySqlConnection = Mysqldb()
End Module
'كود الاتصال بقاعدة البيانات 