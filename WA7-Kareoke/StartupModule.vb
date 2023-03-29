Imports System.Windows.Forms

Module StartupModule
    Private WithEvents SplashScreenTimer As New Timer

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim splash As New SplashScreen1()

        ' Set up the timer
        SplashScreenTimer.Interval = 3000 ' 3 seconds
        AddHandler SplashScreenTimer.Tick, AddressOf SplashScreenTimer_Tick
        SplashScreenTimer.Start()

        ' Show the splash screen
        splash.ShowDialog()

        ' Run the main application form
        Application.Run(New frmKaraoke())
    End Sub

    Private Sub SplashScreenTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        ' Stop the timer
        SplashScreenTimer.Stop()

        ' Close the splash screen
        Dim splash As SplashScreen1 = TryCast(Application.OpenForms("SplashScreen1"), SplashScreen1)
        If splash IsNot Nothing Then
            splash.Close()
        End If
    End Sub
End Module
