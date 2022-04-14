
Public Class Rectangle
        Dim points(2) As Point
        Public Property pen As Pen
        Dim m_image As Image
        Dim m_a As Point
        Dim m_b As Point

        Public Sub New(i As Image, a As Point, b As Point)
            pen = Pens.Red
            m_image = i
            m_a = a
            m_b = b
        End Sub
        Public Sub Draw()
            Using g As Graphics = Graphics.FromImage(m_image)
                Dim points(2) As Point
                g.DrawRectangle(pen, m_a.X, m_a.Y, 100, 100)




            End Using

        End Sub

    End Class


