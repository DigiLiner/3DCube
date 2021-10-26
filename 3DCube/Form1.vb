Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Cube.Point(7)
        ReDim Cube.Edge(11)
        Cube.EdgeCount = 11
        Cube.PointCount = 7
        addx = addy = addz = 100
        AddXAngle = AddYAngle = AddZAngle = 50
        Cube.Pivot.X = 50
        Cube.Pivot.Y = 50
        Cube.Pivot.Z = 50

        Cube.Point(0).X = 0

        Cube.Point(0).Y = 0

        Cube.Point(0).Z = 0

        Cube.Point(1).X = 100

        Cube.Point(1).Y = 0

        Cube.Point(1).Z = 0

        Cube.Point(2).X = 0

        Cube.Point(2).Y = 100

        Cube.Point(2).Z = 0

        Cube.Point(3).X = 100

        Cube.Point(3).Y = 100

        Cube.Point(3).Z = 0

        Cube.Point(4).X = 0

        Cube.Point(4).Y = 0

        Cube.Point(4).Z = 100

        Cube.Point(5).X = 100

        Cube.Point(5).Y = 0

        Cube.Point(5).Z = 100

        Cube.Point(6).X = 0

        Cube.Point(6).Y = 100

        Cube.Point(6).Z = 100

        Cube.Point(7).X = 100

        Cube.Point(7).Y = 100

        Cube.Point(7).Z = 100

        Cube.Edge(0).p1 = Cube.Point(0)

        Cube.Edge(0).p2 = Cube.Point(1)

        Cube.Edge(1).p1 = Cube.Point(0)

        Cube.Edge(1).p2 = Cube.Point(2)

        Cube.Edge(2).p1 = Cube.Point(2)

        Cube.Edge(2).p2 = Cube.Point(3)

        Cube.Edge(3).p1 = Cube.Point(1)

        Cube.Edge(3).p2 = Cube.Point(3)

        Cube.Edge(4).p1 = Cube.Point(4)

        Cube.Edge(4).p2 = Cube.Point(5)

        Cube.Edge(5).p1 = Cube.Point(4)

        Cube.Edge(5).p2 = Cube.Point(6)

        Cube.Edge(6).p1 = Cube.Point(6)

        Cube.Edge(6).p2 = Cube.Point(7)

        Cube.Edge(7).p1 = Cube.Point(5)

        Cube.Edge(7).p2 = Cube.Point(7)

        Cube.Edge(8).p1 = Cube.Point(4)

        Cube.Edge(8).p2 = Cube.Point(0)

        Cube.Edge(9).p1 = Cube.Point(6)

        Cube.Edge(9).p2 = Cube.Point(2)

        Cube.Edge(10).p1 = Cube.Point(7)

        Cube.Edge(10).p2 = Cube.Point(3)

        Cube.Edge(11).p1 = Cube.Point(5)

        Cube.Edge(11).p2 = Cube.Point(1)

        Dist = 256 'Uzaklık

        Mpx = 1 'küpü kolay yoldan büyük çizdirebilmek için çarpan

        'PictureBox1 in değişiklikleri otomatik çizmesi için

        Drawer() 'Çizici
    End Sub

    Sub Drawer()


        Dim j As Integer
        Dim X1 As Double
        Dim Y1 As Double
        Dim Z1 As Double
        Dim X2 As Double
        Dim Y2 As Double
        Dim Z2 As Double

        Dim Trx1 As Double
        Dim Try1 As Double
        Dim Trz1 As Double
        Dim Trrx1 As Double
        Dim Trry1 As Double
        Dim Trrz1 As Double

        Dim Trx2 As Double
        Dim Try2 As Double
        Dim Trz2 As Double
        Dim Trrx2 As Double
        Dim Trry2 As Double
        Dim Trrz2 As Double

        Dim SX1 As Double
        Dim SX2 As Double
        Dim SY1 As Double
        Dim SY2 As Double


        Dim Pivot As TDPoint
        SCX = PictureBox1.Width / 2
        SCY = PictureBox1.Height / 2

        Pivot = Cube.Pivot

        Pen = New Pen(Color.FromArgb(255, 0, 0, 0))
        Pen.Color = Color.Black
        Pen.Width = 3
        Pen.StartCap = Drawing2D.LineCap.Flat
        Pen.EndCap = Drawing2D.LineCap.Flat

        Dim G As Graphics = Graphics.FromImage(PictureBox1.Image)
        G.Clear(Color.White)
        ' For j = 0 To Cube.PointCount 'Drawing Points
        'Try1 = Ry(Cube.Point(j).Y, Cube.Point(j).Z, AddXAngle)
        'Trz1 = Rz(Cube.Point(j).Y, Cube.Point(j).Z, AddXAngle)

        ' Trx1 = Rx(Cube.Point(j).X, Trz1, AddYAngle)
        'Trrz1 = RRz(Cube.Point(j).X, Trz1, AddYAngle)

        'Trrx1 = Rrx(Trx1, Try1, AddZAngle)
        'Trry1 = Rry(Trx1, Try1, AddZAngle)

        'X1 = Trrx1 + Pivot.X
        'Y1 = Trry1 + Pivot.Y
        'Z1 = Trrz1 + Pivot.Z
        '
        'SX1 = Mpx * hsx(X1, Z1, Dist)
        'SY1 = Mpx * hsy(Y1, Z1, Dist)
        'G.DrawLine(Pen, CInt(SCX + SX1), CInt(SCY - SY1), CInt(SCX + SX1), CInt(SCY - SY1))
        'Next j

        For j = 0 To Cube.EdgeCount 'Drawing Edges

            Try1 = Ry(Cube.Edge(j).p1.Y, Cube.Edge(j).p1.Z, AddXAngle)
            Trz1 = Rz(Cube.Edge(j).p1.Y, Cube.Edge(j).p1.Z, AddXAngle)

            Trx1 = Rx(Cube.Edge(j).p1.X, Trz1, AddYAngle)
            Trrz1 = RRz(Cube.Edge(j).p1.X, Trz1, AddYAngle)

            Trrx1 = Rrx(Trx1, Try1, AddZAngle)
            Trry1 = Rry(Trx1, Try1, AddZAngle)

            Try2 = Ry(Cube.Edge(j).p2.Y, Cube.Edge(j).p2.Z, AddXAngle)
            Trz2 = Rz(Cube.Edge(j).p2.Y, Cube.Edge(j).p2.Z, AddXAngle)

            Trx2 = Rx(Cube.Edge(j).p2.X, Trz2, AddYAngle)
            Trrz2 = RRz(Cube.Edge(j).p2.X, Trz2, AddYAngle)

            Trrx2 = Rrx(Trx2, Try2, AddZAngle)
            Trry2 = Rry(Trx2, Try2, AddZAngle)

            X1 = Trrx1 + Pivot.X
            Y1 = Trry1 + Pivot.Y
            Z1 = Trrz1 + Pivot.Z

            X2 = Trrx2 + Pivot.X
            Y2 = Trry2 + Pivot.Y
            Z2 = Trrz2 + Pivot.Z

            SX1 = Mpx * hsx(X1, Z1, Dist)
            SX2 = Mpx * hsx(X2, Z2, Dist)

            SY1 = Mpx * hsy(Y1, Z1, Dist)
            SY2 = Mpx * hsy(Y2, Z2, Dist)
            G.DrawLine(Pen, CInt(SCX + SX1), CInt(SCY - SY1), CInt(SCX + SX2), CInt(SCY - SY2))
            PictureBox1.Refresh()

        Next j



    End Sub
  



    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        AddXAngle = Cube.Angle.Ax - HScrollBar1.Value
        Drawer()
    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        AddYAngle = Cube.Angle.Ay - VScrollBar2.Value
        Drawer()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        AddZAngle = Cube.Angle.Az - VScrollBar1.Value
        Drawer()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Cube.Pivot.Z = Cube.Pivot.Z - addz
        Drawer()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cube.Pivot.Y = Cube.Pivot.Y - addy
        Drawer()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Cube.Pivot.Z = Cube.Pivot.Z + addz
        Drawer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cube.Pivot.X = Cube.Pivot.X - addx
        Drawer()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cube.Pivot.X = Cube.Pivot.X + addx
        Drawer()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cube.Pivot.Y = Cube.Pivot.Y + addy
        Drawer()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Mpx = CInt(TextBox1.Text)
    End Sub
End Class
