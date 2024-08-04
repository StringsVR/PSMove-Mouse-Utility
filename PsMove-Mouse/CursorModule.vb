Imports System.Runtime.InteropServices

Module CursorModule


    <DllImport("user32.dll")>
    Public Function SetCursorPos(ByVal x As Integer, ByVal y As Integer) As Boolean
    End Function

    ' Subroutine to set the mouse cursor position
    Sub SetMouseCursorPosition(ByVal x As Integer, ByVal y As Integer)
        SetCursorPos(x, y)
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Sub mouse_event(ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal dwData As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    ' Mouse event constants
    Public Const MOUSEEVENTF_MOVE As Integer = &H1
    Public Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
    Public Const MOUSEEVENTF_LEFTUP As Integer = &H4
    Public Const MOUSEEVENTF_RIGHTDOWN As Integer = &H8
    Public Const MOUSEEVENTF_RIGHTUP As Integer = &H10

End Module