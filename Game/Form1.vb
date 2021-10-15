Public Class Form1
    Dim r As New Random
    Dim ahealth As Integer
    Dim CharDirection As Integer = 1
    Dim charhealth As Integer = 100
    Dim monsterhealth As Integer = 100
    Sub LeftRight(obj As PictureBox)
        Dim index As Integer
        Dim points(6) As Point
        points(0) = New Point(-5, 0)
        points(1) = New Point(-5, 0)
        points(2) = New Point(5, 0)
        points(3) = New Point(5, 0)
        points(4) = New Point(0, 0)
        points(5) = New Point(0, -0)
        'Don't change after here
        Integer.TryParse(obj.Tag, index)
        '  obj.Location = New Point(obj.Location.X + points(index).X, obj.Location.Y + points(index).Y)
        movexy(points(index).X, points(index).Y, obj)
        index = (index + 1) Mod points.Length
        obj.Tag = index
    End Sub
    'Sub Collision(obj1 As PictureBox, obj2 As PictureBox)
    'Label1.Text = obj1.Name & "," & obj2.Name
    'If obj2.Name.Contains("gun1") Then
    '     obj2.Visible = False
    'If
    'Debug.Print(obj2.Name)
    'Label1.Text = obj1.Name & "," & obj2.Name
    'If obj2.Name.Contains("coins") Then
    'obj2.Visible = False
    'End If
    'End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                ChangeDirection(Avatar, "E")
                movexy(10, 0, Avatar)
                CharDirection = 1
            Case Keys.Left
                ChangeDirection(Avatar, "W")
                movexy(-10, 0, Avatar)
                CharDirection = 2
            Case Keys.A
                ChangeDirection(Avatar, "W")
                movexy(-10, 0, Avatar)
                CharDirection = 2
            Case Keys.D
                ChangeDirection(Avatar, "E")
                movexy(10, 0, Avatar)
                CharDirection = 1
            Case Keys.Enter
                Add(Avatar, shell, "S", 50)
                Add(Avatar, b1, "direction", 20)
                If gun1.Name.Contains("gun1") Then
                    gun1.Visible = False
                    movexy(-10, 50, gun1)
                End If
            Case Keys.ShiftKey
                If CharDirection = 1 Then
                    ChangeDirection(Avatar, "E")
                    movexy(150, 0, Avatar)
                End If
                If CharDirection = 2 Then
                    ChangeDirection(Avatar, "W")
                    movexy(-150, 0, Avatar)
                End If
        End Select

        Me.Refresh()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControls(Me.Controls)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Animate()
        Add(b1, "East", 55)
        'Static count As Integer
        'count = count + 1
        'If count = 10 Then
        'add(Monster1, "follow")
        'End If
        'LeftRight(Avatar)
        'Add(Monster, "follow", 100)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = charhealth
    End Sub
    Private Sub healthbar_Click(sender As Object, e As EventArgs)
        healthbar.Value = charhealth
    End Sub
End Class