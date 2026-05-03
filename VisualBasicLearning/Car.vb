Public Class Car
    
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String
    
    Public Property SticerPrice As Integer
    
    Public Sub New()
        
        Me.Make = "Nissan"
        
    End Sub
    
    Public Sub New(ByVal make as String,
                   ByVal model As String,
                   ByVal year As Integer,
                   ByVal color As String)
        
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Color = color
        
    End Sub
    
'    Private newPropertyValue As String
'    Public Property NewProperty() As String
'        Get
'            Return newPropertyValue
'        End Get
'        Set(ByVal value As String)
'            newPropertyValue = value
'        End Set
'    End Property
    
    
    Public Function marketValue() As Decimal
        
        ' Super secret formula
        
        Dim carValue as Decimal
        
        If Me.Year > 1990 Then
            carValue = 10000.0
        Else 
            carValue = 2000.0
        End If
        
        Return carValue
        
    End Function

    
    
End Class

Public Class CarLot
    
    Public Shared Sub AddToInventory(ByVal newCar as Car)
        
    End Sub
    
End Class