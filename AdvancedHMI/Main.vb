Public Class Main
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub Button设置_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button设置.Click
        Initial.Show()
        ' Me.Hide()
        Me.Visible = False
    End Sub

    Private Sub RecipeButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonCN_Click(sender As Object, e As EventArgs) Handles ButtonCN.Click
        SetCN()

    End Sub

    Private Sub SetEn()
        TextBox设置.Text = My.Resources.Lang_EN.设置
        TextBox服务.Text = My.Resources.Lang_EN.服务
        TextBox统计.Text = My.Resources.Lang_EN.统计
        TextBox用户管理.Text = My.Resources.Lang_EN.用户管理
        TextBox登录.Text = My.Resources.Lang_EN.登录
        TextBox登出.Text = My.Resources.Lang_EN.登出
    End Sub

    Private Sub SetCN()
        TextBox设置.Text = My.Resources.Lang_CN.设置
        TextBox服务.Text = My.Resources.Lang_CN.服务
        TextBox统计.Text = My.Resources.Lang_CN.统计
        TextBox用户管理.Text = My.Resources.Lang_CN.用户管理
        TextBox登录.Text = My.Resources.Lang_CN.登录
        TextBox登出.Text = My.Resources.Lang_CN.登出
    End Sub

    Private Sub ButtonEN_Click(sender As Object, e As EventArgs) Handles ButtonEN.Click
        SetEn()
    End Sub

    Private Sub Button设置_Click_1(sender As Object, e As EventArgs) Handles Button设置.Click

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TextBox设置_TextChanged(sender As Object, e As EventArgs) Handles TextBox设置.TextChanged

    End Sub

    Private Sub TextBox服务_TextChanged(sender As Object, e As EventArgs) Handles TextBox服务.TextChanged

    End Sub

    Private Sub Button统计_Click(sender As Object, e As EventArgs) Handles Button统计.Click

    End Sub
End Class