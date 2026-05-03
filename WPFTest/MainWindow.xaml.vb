Class MainWindow 
    
    private Shared result as String = ""
    
    Private Sub buttonClick(sender as Object, e as RoutedEventArgs)
        
        MyTextBlock.Text = result
        
    End Sub
    
    Private Sub Window_Initialized(sender as Object, e as EventArgs)
        AddHandler myButton.Click, AddressOf MainWindow.HandleEvent
        
    End Sub
    
    Private shared Sub HandleEvent()
        
        result = String.Format("Happened at: {0:HH:mm:ss:fff}", Date.Now)
        
    End Sub

End Class
