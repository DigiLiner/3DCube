Option Explicit On
Option Strict On
Module Module1

    Structure TDPoint

        Dim Control As Boolean
        Dim X As Double
        Dim Y As Double
        Dim Z As Double

    End Structure

    Structure TDEdge

        Dim Control As Boolean

        Dim p1 As TDPoint

        Dim p2 As TDPoint

    End Structure

    Structure TDCube
        Dim Control As Boolean
        Dim Point() As TDPoint
        Dim Edge() As TDEdge
        Dim Pivot As TDPoint
        Dim Angle As TDAngle
        Dim PointCount As Integer
        Dim EdgeCount As Integer

    End Structure

    Structure TDAngle
        Dim Ax As Double
        Dim Ay As Double
        Dim Az As Double
    End Structure

    Public SCX As Integer
    Public SCY As Double

    Public Cube As TDCube
    Public Dist As Integer
    Public Mpx As Integer
    Public Pen As Pen
    Public AddXAngle As Double
    Public AddYAngle As Double
    Public AddZAngle As Double
    Public addx As Double
    Public addy As Double
    Public addz As Double




    Public Function hsx(X As Double, Z As Double, dist As Double) As Double 'Horizontal center of screen

        hsx = dist * X / (dist + Z)

    End Function

    Public Function hsy(Y As Double, Z As Double, dist As Double) As Double 'Vertical center of screen

        hsy = dist * Y / (dist + Z)

    End Function
    Public Function Ry(by As Double, bz As Double, AngX As Double) As Double 'Rotation around the X-axis (Y)
        Ry = Math.Cos(Math.PI * AngX / 180) * by - Math.Sin(Math.PI * AngX / 180) * bz
    End Function


    Public Function Rz(by As Double, bz As Double, AngX As Double) As Double 'Rotation around the X-axis (Z)
        Rz = Math.Sin(Math.PI * AngX / 180) * by + Math.Cos(Math.PI * AngX / 180) * bz
    End Function

    Public Function Rx(bx As Double, Rz As Double, AngY As Double) As Double 'Rotation around the Y-axis (X)
        Rx = Math.Cos(Math.PI * AngY / 180) * (bx) + Math.Sin(Math.PI * AngY / 180) * Rz
    End Function


    Public Function RRz(bx As Double, Rz As Double, AngY As Double) As Double
        RRz = -Math.Sin(Math.PI * AngY / 180) * bx + Math.Cos(Math.PI * AngY / 180) * Rz
    End Function

    Public Function Rrx(Rx As Double, Ry As Double, AngZ As Double) As Double
        Rrx = Math.Cos(Math.PI * AngZ / 180) * Rx - Math.Sin(Math.PI * AngZ / 180) * Ry
    End Function


    Public Function Rry(Rx As Double, Ry As Double, AngZ As Double) As Double
        Rry = Math.Sin(Math.PI * AngZ / 180) * Rx + Math.Cos(Math.PI * AngZ / 180) * Ry
    End Function
End Module
