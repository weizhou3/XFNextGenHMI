<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button设置 = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ButtonCN = New System.Windows.Forms.Button()
        Me.ButtonEN = New System.Windows.Forms.Button()
        Me.TextBox设置 = New System.Windows.Forms.TextBox()
        Me.Button服务 = New System.Windows.Forms.Button()
        Me.TextBox服务 = New System.Windows.Forms.TextBox()
        Me.TextBox统计 = New System.Windows.Forms.TextBox()
        Me.Button统计 = New System.Windows.Forms.Button()
        Me.TextBox用户管理 = New System.Windows.Forms.TextBox()
        Me.Button用户管理 = New System.Windows.Forms.Button()
        Me.TextBox登录 = New System.Windows.Forms.TextBox()
        Me.Button登录 = New System.Windows.Forms.Button()
        Me.TextBox登出 = New System.Windows.Forms.TextBox()
        Me.Button登出 = New System.Windows.Forms.Button()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button设置
        '
        Me.Button设置.BackColor = System.Drawing.Color.Transparent
        Me.Button设置.BackgroundImage = CType(resources.GetObject("Button设置.BackgroundImage"), System.Drawing.Image)
        Me.Button设置.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button设置.Location = New System.Drawing.Point(2, 4)
        Me.Button设置.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button设置.Name = "Button设置"
        Me.Button设置.Size = New System.Drawing.Size(100, 100)
        Me.Button设置.TabIndex = 2
        Me.Button设置.UseVisualStyleBackColor = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'ButtonCN
        '
        Me.ButtonCN.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCN.BackgroundImage = CType(resources.GetObject("ButtonCN.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCN.Location = New System.Drawing.Point(842, 4)
        Me.ButtonCN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonCN.Name = "ButtonCN"
        Me.ButtonCN.Size = New System.Drawing.Size(80, 80)
        Me.ButtonCN.TabIndex = 3
        Me.ButtonCN.UseVisualStyleBackColor = False
        '
        'ButtonEN
        '
        Me.ButtonEN.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEN.BackgroundImage = CType(resources.GetObject("ButtonEN.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEN.Location = New System.Drawing.Point(919, 4)
        Me.ButtonEN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonEN.Name = "ButtonEN"
        Me.ButtonEN.Size = New System.Drawing.Size(80, 80)
        Me.ButtonEN.TabIndex = 4
        Me.ButtonEN.UseVisualStyleBackColor = False
        '
        'TextBox设置
        '
        Me.TextBox设置.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox设置.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox设置.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox设置.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox设置.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox设置.Location = New System.Drawing.Point(2, 104)
        Me.TextBox设置.Name = "TextBox设置"
        Me.TextBox设置.Size = New System.Drawing.Size(100, 19)
        Me.TextBox设置.TabIndex = 5
        Me.TextBox设置.Text = "设置"
        Me.TextBox设置.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button服务
        '
        Me.Button服务.BackColor = System.Drawing.Color.Transparent
        Me.Button服务.BackgroundImage = CType(resources.GetObject("Button服务.BackgroundImage"), System.Drawing.Image)
        Me.Button服务.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button服务.Location = New System.Drawing.Point(2, 128)
        Me.Button服务.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button服务.Name = "Button服务"
        Me.Button服务.Size = New System.Drawing.Size(100, 100)
        Me.Button服务.TabIndex = 6
        Me.Button服务.UseVisualStyleBackColor = False
        '
        'TextBox服务
        '
        Me.TextBox服务.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox服务.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox服务.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox服务.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox服务.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox服务.Location = New System.Drawing.Point(2, 228)
        Me.TextBox服务.Name = "TextBox服务"
        Me.TextBox服务.Size = New System.Drawing.Size(100, 19)
        Me.TextBox服务.TabIndex = 7
        Me.TextBox服务.Text = "服务"
        Me.TextBox服务.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox统计
        '
        Me.TextBox统计.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox统计.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox统计.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox统计.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox统计.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox统计.Location = New System.Drawing.Point(2, 352)
        Me.TextBox统计.Name = "TextBox统计"
        Me.TextBox统计.Size = New System.Drawing.Size(100, 19)
        Me.TextBox统计.TabIndex = 10
        Me.TextBox统计.Text = "统计"
        Me.TextBox统计.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button统计
        '
        Me.Button统计.BackColor = System.Drawing.Color.Transparent
        Me.Button统计.BackgroundImage = CType(resources.GetObject("Button统计.BackgroundImage"), System.Drawing.Image)
        Me.Button统计.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button统计.Location = New System.Drawing.Point(2, 250)
        Me.Button统计.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button统计.Name = "Button统计"
        Me.Button统计.Size = New System.Drawing.Size(100, 100)
        Me.Button统计.TabIndex = 9
        Me.Button统计.UseVisualStyleBackColor = False
        '
        'TextBox用户管理
        '
        Me.TextBox用户管理.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox用户管理.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox用户管理.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox用户管理.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox用户管理.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox用户管理.Location = New System.Drawing.Point(3, 475)
        Me.TextBox用户管理.Name = "TextBox用户管理"
        Me.TextBox用户管理.Size = New System.Drawing.Size(100, 19)
        Me.TextBox用户管理.TabIndex = 12
        Me.TextBox用户管理.Text = "用户管理"
        Me.TextBox用户管理.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button用户管理
        '
        Me.Button用户管理.BackColor = System.Drawing.Color.Transparent
        Me.Button用户管理.BackgroundImage = CType(resources.GetObject("Button用户管理.BackgroundImage"), System.Drawing.Image)
        Me.Button用户管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button用户管理.Location = New System.Drawing.Point(2, 375)
        Me.Button用户管理.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button用户管理.Name = "Button用户管理"
        Me.Button用户管理.Size = New System.Drawing.Size(100, 100)
        Me.Button用户管理.TabIndex = 11
        Me.Button用户管理.UseVisualStyleBackColor = False
        '
        'TextBox登录
        '
        Me.TextBox登录.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox登录.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox登录.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox登录.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox登录.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox登录.Location = New System.Drawing.Point(2, 688)
        Me.TextBox登录.Name = "TextBox登录"
        Me.TextBox登录.Size = New System.Drawing.Size(100, 19)
        Me.TextBox登录.TabIndex = 14
        Me.TextBox登录.Text = "登录"
        Me.TextBox登录.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button登录
        '
        Me.Button登录.BackColor = System.Drawing.Color.Transparent
        Me.Button登录.BackgroundImage = CType(resources.GetObject("Button登录.BackgroundImage"), System.Drawing.Image)
        Me.Button登录.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button登录.Location = New System.Drawing.Point(2, 584)
        Me.Button登录.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button登录.Name = "Button登录"
        Me.Button登录.Size = New System.Drawing.Size(100, 100)
        Me.Button登录.TabIndex = 13
        Me.Button登录.UseVisualStyleBackColor = False
        '
        'TextBox登出
        '
        Me.TextBox登出.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox登出.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox登出.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox登出.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox登出.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox登出.Location = New System.Drawing.Point(110, 688)
        Me.TextBox登出.Name = "TextBox登出"
        Me.TextBox登出.Size = New System.Drawing.Size(100, 19)
        Me.TextBox登出.TabIndex = 16
        Me.TextBox登出.Text = "登出"
        Me.TextBox登出.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button登出
        '
        Me.Button登出.BackColor = System.Drawing.Color.Transparent
        Me.Button登出.BackgroundImage = CType(resources.GetObject("Button登出.BackgroundImage"), System.Drawing.Image)
        Me.Button登出.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button登出.Location = New System.Drawing.Point(110, 584)
        Me.Button登出.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button登出.Name = "Button登出"
        Me.Button登出.Size = New System.Drawing.Size(100, 100)
        Me.Button登出.TabIndex = 15
        Me.Button登出.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1002, 712)
        Me.Controls.Add(Me.TextBox登出)
        Me.Controls.Add(Me.Button登出)
        Me.Controls.Add(Me.TextBox登录)
        Me.Controls.Add(Me.Button登录)
        Me.Controls.Add(Me.TextBox用户管理)
        Me.Controls.Add(Me.Button用户管理)
        Me.Controls.Add(Me.TextBox统计)
        Me.Controls.Add(Me.Button统计)
        Me.Controls.Add(Me.TextBox服务)
        Me.Controls.Add(Me.Button服务)
        Me.Controls.Add(Me.TextBox设置)
        Me.Controls.Add(Me.ButtonEN)
        Me.Controls.Add(Me.ButtonCN)
        Me.Controls.Add(Me.Button设置)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.Tag = "2"
        Me.Text = "Page 2"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button设置 As System.Windows.Forms.Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ButtonCN As Button
    Friend WithEvents ButtonEN As Button
    Friend WithEvents TextBox设置 As TextBox
    Friend WithEvents Button服务 As Button
    Friend WithEvents TextBox服务 As TextBox
    Friend WithEvents TextBox统计 As TextBox
    Friend WithEvents Button统计 As Button
    Friend WithEvents TextBox用户管理 As TextBox
    Friend WithEvents Button用户管理 As Button
    Friend WithEvents TextBox登录 As TextBox
    Friend WithEvents Button登录 As Button
    Friend WithEvents TextBox登出 As TextBox
    Friend WithEvents Button登出 As Button
End Class
