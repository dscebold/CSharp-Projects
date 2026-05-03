Imports System.IO
Imports System.Net

Public Class WebScraper
    
    Public Function ScrapeWebpage(ByVal url as String, ByVal path as String ) As String
        
        Dim client as New WebClient()
        Dim reply as String = client.DownloadString(url)
        
        File.WriteAllText(path, reply)
        
        Return reply
        
    End Function
    
End Class