Imports System.Math

Public Class QuaternionToEuler

    ' Function to convert quaternion to Euler angles (pitch, yaw, roll)
    Public Shared Function QuaternionToEulerAngles(qx As Double, qy As Double, qz As Double, qw As Double) As (pitch As Double, yaw As Double, roll As Double)
        ' Calculate pitch (x-axis rotation)
        Dim sinPitch As Double = 2.0 * (qw * qx + qy * qz)
        Dim cosPitch As Double = 1.0 - 2.0 * (qx * qx + qy * qy)
        Dim pitch As Double = Atan2(sinPitch, cosPitch)

        ' Calculate yaw (y-axis rotation)
        Dim sinYaw As Double = 2.0 * (qw * qy - qz * qx)
        Dim yaw As Double
        If Abs(sinYaw) >= 1 Then
            yaw = Sign(sinYaw) * PI / 2 ' Use 90 degrees if out of range
        Else
            yaw = Asin(sinYaw)
        End If

        ' Calculate roll (z-axis rotation)
        Dim sinRoll As Double = 2.0 * (qw * qz + qx * qy)
        Dim cosRoll As Double = 1.0 - 2.0 * (qy * qy + qz * qz)
        Dim roll As Double = Atan2(sinRoll, cosRoll)

        ' Convert radians to degrees
        pitch = pitch * (180.0 / PI)
        yaw = yaw * (180.0 / PI)
        roll = roll * (180.0 / PI)

        Return (pitch, yaw, roll)
    End Function

End Class