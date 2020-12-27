Public Class Form1
    Public WT As Mat4x4
    Public VT As Mat4x4
    Public ST As Mat4x4

    Public DirectionOfProjection As Vector3
    Public ViewerCoord As Vector3
    Public LightSourceCoord As Vector3

    Public AmbientCoefficient As Double
    Public DiffuseCoefficient As Double
    Public SpecularCoefficient As Double
    Public AmbientIntensity As Double
    Public DiffuseIntensity As Double
    Public SpecularIntensity As Double
    Public SpecularExponent As Double

    Public Sphere As Sphere

    Public Bitmap As Bitmap
    Public Canvas As Graphics

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ZC = 100.0
        WT = New Mat4x4(1, 0, 0, 0,
                        0, 1, 0, 0,
                        0, 0, 1, 0,
                        0, 0, 0, 1)
        VT = New Mat4x4(1, 0, 0, 0,
                        0, 1, 0, 0,
                        0, 0, 1, 1 / -ZC,
                        0, 0, 0, 1)
        ST = New Mat4x4(200, 0, 0, 0,
                        0, -200, 0, 0,
                        0, 0, 1, 0,
                        200, 200, 0, 1)

        ViewerCoord = New Vector3(0, 0, 5)
        LightSourceCoord = New Vector3(-10, 10, 10)
        DirectionOfProjection = New Vector3(0, 0, -1)

        AmbientCoefficient = 0.5
        DiffuseCoefficient = 0.5
        SpecularCoefficient = 0.5

        AmbientIntensity = 0.5
        ' DiffuseIntensity = SpecularIntensity = LightIntensity
        DiffuseIntensity = 1.0
        SpecularIntensity = 1.0
        SpecularExponent = 1.0

        Sphere = New Sphere()
        Sphere.Transform(WT, VT, ST)

        Bitmap = New Bitmap(500, 500)
        Canvas = Graphics.FromImage(Bitmap)
        PictureBox1.Image = Bitmap
    End Sub

    Sub DrawFlat()
        For Each polygon In Sphere.Surfaces
            If Not Sphere.IsSurfaceFacingBack(polygon, DirectionOfProjection) Then
                Dim intensityVertex1 = GetIntensity(Sphere.VertCoordWCS(polygon(0)),
                                                    Sphere.VertNormal(polygon(0)),
                                                    AmbientCoefficient,
                                                    AmbientIntensity,
                                                    DiffuseCoefficient,
                                                    DiffuseIntensity,
                                                    SpecularCoefficient,
                                                    SpecularIntensity,
                                                    SpecularExponent)
                Dim intensityVertex2 = GetIntensity(Sphere.VertCoordWCS(polygon(1)),
                                                    Sphere.VertNormal(polygon(1)),
                                                    AmbientCoefficient,
                                                    AmbientIntensity,
                                                    DiffuseCoefficient,
                                                    DiffuseIntensity,
                                                    SpecularCoefficient,
                                                    SpecularIntensity,
                                                    SpecularExponent)
                Dim intensityVertex3 = GetIntensity(Sphere.VertCoordWCS(polygon(2)),
                                                    Sphere.VertNormal(polygon(2)),
                                                    AmbientCoefficient,
                                                    AmbientIntensity,
                                                    DiffuseCoefficient,
                                                    DiffuseIntensity,
                                                    SpecularCoefficient,
                                                    SpecularIntensity,
                                                    SpecularExponent)
                Dim intensity = (intensityVertex1 + intensityVertex2 + intensityVertex3) / 3.0
                If intensity > 1.0 Then
                    intensity = 1.0
                ElseIf intensity < 0.0 Then
                    intensity = 0.0
                End If

                Dim brush = New SolidBrush(Color.FromArgb(255.0 * intensity, 0, 0))
                Canvas.FillPolygon(brush, New Point(2) {
                               New Point(Sphere.VertCoordSCS(polygon(0)).X, Sphere.VertCoordSCS(polygon(0)).Y),
                               New Point(Sphere.VertCoordSCS(polygon(1)).X, Sphere.VertCoordSCS(polygon(1)).Y),
                               New Point(Sphere.VertCoordSCS(polygon(2)).X, Sphere.VertCoordSCS(polygon(2)).Y)
                               })
            End If
        Next
    End Sub

    Function GetIntensity(Coord As Vector3,
                          Normal As Vector3,
                          KAmbiant As Double,
                          IAmbiant As Double,
                          KDiff As Double,
                          IDiff As Double,
                          KSpec As Double,
                          ISpec As Double,
                          SpecularExponent As Double) As Double
        Dim ViewerVec = New Vector3(ViewerCoord.X - Coord.X,
                                    ViewerCoord.Y - Coord.Y,
                                    ViewerCoord.Z - Coord.Z)
        Dim LenCoordToViewer = Math.Sqrt(ViewerVec.X * ViewerVec.X +
                                         ViewerVec.Y * ViewerVec.Y +
                                         ViewerVec.Z * ViewerVec.Z)
        ViewerVec.X /= LenCoordToViewer
        ViewerVec.Y /= LenCoordToViewer
        ViewerVec.Z /= LenCoordToViewer

        Dim LightSourceVec = New Vector3(LightSourceCoord.X - Coord.X,
                                         LightSourceCoord.Y - Coord.Y,
                                         LightSourceCoord.Z - Coord.Z)
        Dim LenCoordToLightSource = Math.Sqrt(LightSourceVec.X * LightSourceVec.X +
                                              LightSourceVec.Y * LightSourceVec.Y +
                                              LightSourceVec.Z * LightSourceVec.Z)
        LightSourceVec.X /= LenCoordToLightSource
        LightSourceVec.Y /= LenCoordToLightSource
        LightSourceVec.Z /= LenCoordToLightSource

        Dim RVec = Normal.
            Mul(Normal.Dot(LightSourceVec)).
            Mul(2).
            Subt(LightSourceVec)

        Dim IA = KAmbiant * IAmbiant
        Dim ID = KDiff * IDiff * Normal.Dot(LightSourceVec)
        Dim [IS] = KSpec * ISpec * Math.Pow(ViewerVec.Dot(RVec), SpecularExponent)
        Dim ITot = IA + ID + [IS]
        If Normal.Dot(LightSourceVec) > 0 Then
            If ViewerVec.Dot(RVec) > 0 Then
                Return ITot
            Else
                Return IA + ID
            End If
        Else
            Return IA
        End If
    End Function

    Private Sub ButtonTranslate_Click(sender As Object, e As EventArgs) Handles ButtonTranslate.Click
        Dim x = CDbl(TextBoxTranslateX.Text)
        Dim y = CDbl(TextBoxTranslateY.Text)
        Dim z = CDbl(TextBoxTranslateZ.Text)
        WT = WT.Mul(
            New Mat4x4(1, 0, 0, 0,
                       0, 1, 0, 0,
                       0, 0, 1, 0,
                       x, y, z, 1))
        Sphere.Transform(WT, VT, ST)

        DrawCanvas()

        TextBoxTranslateX.Text = "0"
        TextBoxTranslateY.Text = "0"
        TextBoxTranslateZ.Text = "0"
    End Sub

    Sub DrawCanvas()
        LightSourceCoord.X = CDbl(TextBoxLightSourceX.Text)
        LightSourceCoord.Y = CDbl(TextBoxLightSourceY.Text)
        LightSourceCoord.Z = CDbl(TextBoxLightSourceZ.Text)

        AmbientCoefficient = CDbl(TextBoxAmbientCoefficient.Text)
        AmbientIntensity = CDbl(TextBoxAmbientIntensity.Text)

        DiffuseCoefficient = CDbl(TextBoxDiffuseCoefficient.Text)
        DiffuseIntensity = CDbl(TextBoxLightIntensity.Text)

        SpecularCoefficient = CDbl(TextBoxSpecularCoefficient.Text)
        SpecularIntensity = CDbl(TextBoxLightIntensity.Text)

        SpecularExponent = CDbl(TextBoxSpecularExponent.Text)

        Canvas.Clear(Color.Transparent)
        If RadioAlgorithmFlat.Checked Then
            DrawFlat()
        End If
        PictureBox1.Image = Bitmap
    End Sub

    Private Sub ButtonApplyChanges_Click(sender As Object, e As EventArgs) Handles ButtonApplyChanges.Click
        DrawCanvas()
    End Sub
End Class

Public Class Sphere
    Public VertCoordOCS As List(Of Vector3)
    Public VertNormal As List(Of Vector3)
    Public VertCoordWCS As List(Of Vector3)
    Public VertCoordVCS As List(Of Vector3)
    Public VertCoordSCS As List(Of Vector3)
    Public Surfaces As List(Of UInt32())

    Sub New()
        VertCoordOCS = New List(Of Vector3)
        Surfaces = New List(Of UInt32())
        VertNormal = New List(Of Vector3)
        VertCoordWCS = New List(Of Vector3)
        VertCoordVCS = New List(Of Vector3)
        VertCoordSCS = New List(Of Vector3)

        GetVerticesCoord(1, 15, 15)
        GetVerticesNormal()
        GetPolygonIndices(15, 15)
    End Sub

    Function GetVertexCoord(R As Double, Theta As Double, Phi As Double) As Vector3
        Dim PhiRad = Math.PI * Phi / 180.0
        Dim ThetaRad = Math.PI * Theta / 180.0
        Dim y = R * Math.Sin(PhiRad)
        Dim d = R * Math.Cos(PhiRad)
        Dim x = d * Math.Sin(ThetaRad)
        Dim z = d * Math.Cos(ThetaRad)
        Return New Vector3(x, y, z)
    End Function

    Sub GetVerticesNormal()
        For Each vertex In VertCoordOCS
            Dim normal = New Vector3(vertex.X, vertex.Y, vertex.Z)
            Dim length = Math.Sqrt(vertex.X * vertex.X + vertex.Y * vertex.Y + vertex.Z * vertex.Z)
            VertNormal.Add(normal.Div(length))
        Next
    End Sub

    Sub GetVerticesCoord(R As Double, Longitude As Integer, Latitude As Integer)
        VertCoordOCS.Clear()
        VertNormal.Clear()

        Dim longitudeAngle = 360 / Longitude
        Dim latitudeAngle = 90 / Latitude

        Dim n As Integer = 0
        For i = 0 To Latitude - 1
            For j = 0 To Longitude - 1
                Dim phi = i * latitudeAngle
                Dim theta = j * longitudeAngle
                VertCoordOCS.Add(GetVertexCoord(R, theta, phi))
            Next
        Next
        VertCoordOCS.Add(New Vector3(0, R, 0))

        For i = 1 To Latitude - 1
            For j = 0 To Longitude - 1
                Dim phi = i * latitudeAngle
                Dim theta = j * longitudeAngle
                Dim coord = GetVertexCoord(R, theta, phi)
                coord.Y *= -1
                VertCoordOCS.Add(coord)
            Next
        Next
        VertCoordOCS.Add(New Vector3(0, -R, 0))
    End Sub

    Sub GetPolygonIndices(Longitude As Integer, Latitude As Integer)
        Surfaces.Clear()

        Dim k As Integer
        For j = 0 To Longitude - 2
            k = j * Longitude
            For i = 0 To Longitude - 2
                Surfaces.Add(New UInt32(2) {i + k, i + k + 1, i + k + Longitude + 1})
                Surfaces.Add(New UInt32(2) {i + k, i + k + Longitude + 1, i + k + Longitude})
            Next
            Surfaces.Add(New UInt32(2) {k + Longitude - 1, k, k + Longitude})
            Surfaces.Add(New UInt32(2) {k + Longitude - 1, k + Longitude, k + 2 * Longitude - 1})
        Next

        For i = (Latitude - 1) * Longitude To Latitude * Longitude - 2
            Surfaces.Add(New UInt32(2) {i, i + 1, Latitude * Longitude})
        Next
        Surfaces.Add(New UInt32(2) {Latitude * Longitude - 1, (Latitude - 1) * Longitude, Latitude * Longitude})

        Dim l As Integer = Latitude * Longitude + 1
        For j = 0 To Latitude - 2
            k = j * Longitude
            For i = 0 To Longitude - 2
                If j = 0 Then
                    Surfaces.Add(New UInt32(2) {i + l + k, i + l + 1 + k, i + 1 + k})
                    Surfaces.Add(New UInt32(2) {i + l + k, i + 1 + k, i + k})
                Else
                    Surfaces.Add(New UInt32(2) {i + k + l, i + k + 1 + l, i + k + 1 + l - Longitude})
                    Surfaces.Add(New UInt32(2) {i + k + l, i + k + 1 + l - Longitude, i + k + l - Longitude})
                End If
            Next
            If j = 0 Then
                Surfaces.Add(New UInt32(2) {l + Longitude - 1, l, 0})
                Surfaces.Add(New UInt32(2) {l + Longitude - 1, 0, Longitude - 1})
            Else
                Surfaces.Add(New UInt32(2) {l + Longitude - 1 + k, k + l, k + l - Longitude})
                Surfaces.Add(New UInt32(2) {l + Longitude - 1 + k, k + l - Longitude, l - 1 + k})
            End If
        Next

        Dim idxDown = Longitude * (2 * Latitude - 1) + 1
        For i = 2 * Longitude * (Latitude - 1) To Longitude * (2 * Latitude - 1) - 1
            Surfaces.Add(New UInt32(2) {i, idxDown, i + 1})
        Next
        Surfaces.Add(New UInt32(2) {idxDown - 1, idxDown, idxDown - Longitude})
    End Sub

    Sub Transform(WT As Mat4x4, VT As Mat4x4, ST As Mat4x4)
        VertCoordSCS.Clear()
        VertCoordVCS.Clear()
        VertCoordWCS.Clear()
        For Each vertexOCSVec3 In VertCoordOCS
            Dim vertexOCSVec4 = New Vector4(vertexOCSVec3, 1.0)

            Dim vertexWCSVec4 = vertexOCSVec4.Mul(WT)
            vertexWCSVec4.X /= vertexWCSVec4.W
            vertexWCSVec4.Y /= vertexWCSVec4.W
            vertexWCSVec4.Z /= vertexWCSVec4.W
            Dim vertexWCSVec3 = New Vector3(vertexWCSVec4)
            VertCoordWCS.Add(vertexWCSVec3)

            Dim vertexVCSVec4 = vertexWCSVec4.Mul(VT)
            vertexVCSVec4.X /= vertexVCSVec4.W
            vertexVCSVec4.Y /= vertexVCSVec4.W
            vertexVCSVec4.Z /= vertexVCSVec4.W
            Dim vertexVCSVec3 = New Vector3(vertexVCSVec4)
            VertCoordVCS.Add(vertexVCSVec3)

            Dim vertexSCSVec4 = vertexVCSVec4.Mul(ST)
            vertexSCSVec4.X /= vertexSCSVec4.W
            vertexSCSVec4.Y /= vertexSCSVec4.W
            vertexSCSVec4.Z /= vertexSCSVec4.W
            Dim vertexSCSVec3 = New Vector3(vertexSCSVec4)
            VertCoordSCS.Add(vertexSCSVec3)
        Next
    End Sub

    Function IsSurfaceFacingBack(VertexIndices As UInteger(), DirectionOfProjection As Vector3) As Boolean
        Return ((VertCoordSCS(VertexIndices(2)).Subt(VertCoordSCS(VertexIndices(1)))).
            Cross(VertCoordSCS(VertexIndices(1)).Subt(VertCoordSCS(VertexIndices(0))))).
            Dot(DirectionOfProjection) >= 0
    End Function
End Class

Public Class Vector4
    Public X As Double
    Public Y As Double
    Public Z As Double
    Public W As Double

    Sub New(X As Double, Y As Double, Z As Double, W As Double)
        Me.X = X
        Me.Y = Y
        Me.Z = Z
        Me.W = W
    End Sub

    Sub New(Other As Vector3, W As Double)
        X = Other.X
        Y = Other.Y
        Z = Other.Z
        Me.W = W
    End Sub

    Function Mul(Mat As Mat4x4) As Vector4
        Return New Vector4(X * Mat.Data(0)(0) + Y * Mat.Data(1)(0) + Z * Mat.Data(2)(0) + W * Mat.Data(3)(0),
                           X * Mat.Data(0)(1) + Y * Mat.Data(1)(1) + Z * Mat.Data(2)(1) + W * Mat.Data(3)(1),
                           X * Mat.Data(0)(2) + Y * Mat.Data(1)(2) + Z * Mat.Data(2)(2) + W * Mat.Data(3)(2),
                           X * Mat.Data(0)(3) + Y * Mat.Data(1)(3) + Z * Mat.Data(2)(3) + W * Mat.Data(3)(3))
    End Function
End Class

Public Class Vector3
    Public X As Double
    Public Y As Double
    Public Z As Double

    Sub New(X As Double, Y As Double, Z As Double)
        Me.X = X
        Me.Y = Y
        Me.Z = Z
    End Sub
    Sub New(Vec As Vector4)
        X = Vec.X
        Y = Vec.Y
        Z = Vec.Z
    End Sub

    Function Dot(Other As Vector3) As Double
        Return X * Other.X + Y * Other.Y + Z * Other.Z
    End Function

    Function Cross(Other As Vector3) As Vector3
        Return New Vector3(Y * Other.Z - Z * Other.Y, Z * Other.X - X * Other.Z, X * Other.Y - Y * Other.X)
    End Function

    Function Mul(Other As Double) As Vector3
        Return New Vector3(X * Other, Y * Other, Z * Other)
    End Function

    Function Subt(Other As Vector3) As Vector3
        Return New Vector3(X - Other.X, Y - Other.Y, Z - Other.Z)
    End Function

    Function Div(Other As Double) As Vector3
        Return New Vector3(X / Other, Y / Other, Z / Other)
    End Function
End Class

Public Class Mat4x4
    Public Data As Double()()

    Sub New(n1 As Double, n2 As Double, n3 As Double, n4 As Double,
            n5 As Double, n6 As Double, n7 As Double, n8 As Double,
            n9 As Double, n10 As Double, n11 As Double, n12 As Double,
            n13 As Double, n14 As Double, n15 As Double, n16 As Double)
        Data = New Double(3)() {
            New Double(3) {n1, n2, n3, n4},
            New Double(3) {n5, n6, n7, n8},
            New Double(3) {n9, n10, n11, n12},
            New Double(3) {n13, n14, n15, n16}
        }
    End Sub

    Sub New(OtherData As Double()())
        Data = OtherData
    End Sub

    Function Mul(Other As Mat4x4) As Mat4x4
        Dim result = New Double(3)() {
            New Double(3) {0, 0, 0, 0},
            New Double(3) {0, 0, 0, 0},
            New Double(3) {0, 0, 0, 0},
            New Double(3) {0, 0, 0, 0}
        }
        For i = 0 To 3
            For j = 0 To 3
                For k = 0 To 3
                    result(i)(j) += Data(i)(k) * Other.Data(k)(j)
                Next
            Next
        Next
        Return New Mat4x4(result)
    End Function

    Function Inverse(Other As Mat4x4) As Mat4x4
        Dim Det As Double =
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3)) -
            (Data(0)(1) * Data(1)(2) * Data(2)(3) * Data(3)(0)) +
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3)) -
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3)) -
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3)) +
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3)) -
            (Data(0)(0) * Data(1)(1) * Data(2)(2) * Data(3)(3))
        Return New Mat4x4(Other.Data(0)(0) * Det, Other.Data(0)(1) * Det, Other.Data(0)(2) * Det, Other.Data(0)(3) * Det,
                          Other.Data(1)(0) * Det, Other.Data(1)(1) * Det, Other.Data(1)(2) * Det, Other.Data(1)(3) * Det,
                          Other.Data(2)(0) * Det, Other.Data(2)(1) * Det, Other.Data(2)(2) * Det, Other.Data(2)(3) * Det,
                          Other.Data(3)(0) * Det, Other.Data(3)(1) * Det, Other.Data(3)(2) * Det, Other.Data(3)(3) * Det)
    End Function
End Class

