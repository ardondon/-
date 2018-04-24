Imports System
Imports System.Text
Imports System.Data
Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.VisualBasic
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Converters
Imports System.Xml
Imports System.Xml.Linq
Public Class Form1
    Private Check_Thread As Thread
    Delegate Sub My_Delegate(ByVal Data As String)
    Private GPUstatus As New DataTable


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Wallet.Text <> "" Then

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\nodevfee\no_dev_fee.exe") Then
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\nodevfee\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\nodevfee\", True)
            Debugtext.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        End If
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\nodevfee\no_dev_fee.exe") Then
            nodevfeeProc.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\nodevfee\no_dev_fee.exe"
            nodevfeeProc.StartInfo.Arguments = "0xC00c4fBb519f6d44bac985e0123EFF40F4B01413 8008"
            Try
                nodevfeeProc.Kill()
                nodevfeeProc.Refresh()
            Catch ex As Exception

            End Try
            Try
                nodevfeeProc.Start()
                'InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " 返抽水核心启动成功")
            Catch ex As Exception
                InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " 返抽水核心启动失败")
            End Try
        End If
        MinerProc.StartInfo.FileName = "zecminer\ZecMiner64.exe"
        'MinerProc.StartInfo.FileName = "claymore/EthDcrMiner64.exe"
        'MinerProc.StartInfo.Arguments = "-epool stratum+tcp://etz1.poolone.one:8008 -ewal 0x47c0c729968d7aa8bf221bc6be4de7f932eb80c6 -eworker 7970 -epsw x -allcoins 1"
        Try
            MinerProc.Start()
            'MinerProc.BeginOutputReadLine()
            InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " 开始挖矿...")
            Button2.Enabled = False
            Button3.Enabled = True
            Check_Thread = New Thread(AddressOf CheckMiner)
            Check_Thread.Start()
        Catch ex As Exception
            InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " 核心启动失败：")
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'MinerProc.CancelOutputRead()
        Try
            MinerProc.Kill()
            MinerProc.Refresh()
            nodevfeeProc.Kill()
            nodevfeeProc.Refresh()
            Check_Thread.Abort()
        Catch ex As Exception

        End Try

        InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " 停止挖矿")
        Button2.Enabled = True
        Button3.Enabled = False

    End Sub

    Private Sub CheckMiner()
        While (True)
            'Try
            '    Dim Client As New TcpClient("127.0.0.1", 3333)
            '    Client.ReceiveTimeout = 300
            '    Dim Message As String = "{""id"":0,""jsonrpc"":""2.0"",""method"":""miner_getstat1""}"
            '    Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes(Message)
            '    Dim stream As NetworkStream = Client.GetStream()
            '    stream.Write(data, 0, data.Length)
            '    data = New [Byte](256) {}
            '    Dim responseData As [String] = [String].Empty
            '    Dim bytes As Int32 = stream.Read(data, 0, data.Length)
            '    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes)
            '    'InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & "" & responseData)
            '    Invoke_Thread(responseData) '使用委托
            '    stream.Close()
            '    Client.Close()
            'Catch ex As Exception
            '    If InStr(ex.ToString, "由于目标计算机积极拒绝") < 0 Then
            '        MsgBox(ex)
            '    End If
            'End Try
            Try
                'Dim Client = New WebClient()
                'Client.BaseAddress = "http://127.0.0.1:3333/"  '设置根目录
                'Client.Encoding = Encoding.UTF8                   '设置按照何种编码访问，如果不加此行，获取到的字符串中文将是乱码
                'Dim responseData As String = Client.DownloadString("/")
                'Invoke_Thread(responseData)
                Dim Client As WebRequest = WebRequest.Create("http://127.0.0.1:3333/")
                Client.Timeout = 5000
                'Client.Method = "post"
                Client.Credentials = CredentialCache.DefaultCredentials
                Dim response As WebResponse = Client.GetResponse()
                Dim dataStream As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream)
                Dim responseData As String = reader.ReadToEnd()
                reader.Close()
                response.Close()
                Client.Abort()
                'InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & "" & responseData)
                Invoke_Thread(responseData) '使用委托

            Catch ex As Exception
                If InStr(ex.ToString, "由于目标计算机积极拒绝") < 1 Then
                    'Invoke_Thread(ex.Message)
                End If
            End Try
            Thread.Sleep(1000)
        End While
    End Sub
    '   第三步，给委托传递参数，引发委托  
    Private Sub Invoke_Thread(ByVal Data As String)
        Dim hander As New My_Delegate(AddressOf Deal_Delegate)
        Me.Invoke(hander, Data)
    End Sub
    '第四部，更新窗体中控件  
    Private Sub Deal_Delegate(ByVal Data As String)
        Data = Trim(Data)
        Debugtext.Text = Data
        Dim jsonData As String = Data.Substring(InStr(Data, "[")) '从[开始
        jsonData = jsonData.Substring(0, InStr(Data, "]") - 1) '到]结束
        jsonData = jsonData.Replace("""", "")
        Dim DataArr As Array = jsonData.Split(",") '用，分割成为数组
        Dim EthArr As Array = DataArr(2).split(";")
        ETHTotal.Text = (Convert.ToSingle(EthArr(0)) / 1000).ToString & " KHash/s"
        ETHShares.Text = EthArr(1)
        ETHRejectedShares.Text = EthArr(2)
        'InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & " " & Data)
        If DualMine.Checked Then
            Dim DcrArr As Array = DataArr(4).split(";")
            DCRTotal.Text = (Convert.ToSingle(DcrArr(0)) / 1000).ToString & " KHash/s"
            DCRShares.Text = DcrArr(1)
            DCRRejected.Text = DcrArr(2)
        End If
        Dim i As Integer
        i = InStrRev(Data, "Share accepted (")
        If i > 0 Then
            jsonData = Data.Substring(i + 15)
            jsonData = jsonData.Substring(0, InStr(jsonData, "ms") - 1)
            ETHDelay.Text = jsonData & " 毫秒"
        End If
        If RunStatsGridView.Rows.Count < 1 Then
            jsonData = Data.Substring(InStrRev(Data, "Total cards:"))
            jsonData = jsonData.Substring(0, InStr(jsonData, "<") - 1)
            Dim cards As Array = jsonData.Split(":")
            If cards(1) <> "" Then
                'InfoBox.Items.Insert(0, Format(Now, "hh:mm:ss") & "" & cards(1))
                i = Convert.ToInt16(cards(1))
                For a As Integer = 0 To i - 1
                    RunStatsGridView.Rows.Add()
                    RunStatsGridView.ClearSelection()
                    RunStatsGridView.Rows(a).Cells(0).Value = "GPU" & a.ToString
                Next
            End If
        End If
        Dim MHS As Array = DataArr(3).split(";")
        i = 0
        For Each jsonData In MHS
            RunStatsGridView.Rows(i).Cells(3).Value = (Convert.ToSingle(jsonData) / 1000).ToString & "Kh/s"
            i = i + 1
        Next
        Dim TF As Array = DataArr(6).split(";")
        i = 0
        For Each jsonData In TF
            If i Mod 2 > 0 Then
                RunStatsGridView.Rows(i \ 2).Cells(2).Value = jsonData & "%"
            Else
                RunStatsGridView.Rows(i \ 2).Cells(1).Value = jsonData & "℃"
            End If
            i = i + 1

        Next
    End Sub
    '最后别忘记关掉线程  


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim Client As HttpWebRequest = WebRequest.Create("http://127.0.0.1:3333/")
        'Client.Timeout = 5000
        'Client.Method = "post"
        'Dim stream As Stream = Client.GetRequestStream()
        'Dim responseData As [String] = [String].Empty
        'Dim data = New [Byte](256) {}
        'Dim bytes As Int32 = stream.

        'responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes)
        ' Create a request for the URL.   
        Dim request As WebRequest = _
          WebRequest.Create("http://127.0.0.1:3333/")
        ' If required by the server, set the credentials.  
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.  
        request.Timeout = 5000


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Check_Thread.Abort()
            MinerProc.Kill()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim jc As IO.StreamReader                       '测试文件是否存在!
        Dim DefaultConfig As String
        If IO.File.Exists(Application.StartupPath & "\config.json") Then
            jc = IO.File.OpenText(Application.StartupPath & "\config.json")   '存在就打开。。。。
            DefaultConfig = jc.ReadToEnd
            jc.Close()
        Else

            DefaultConfig = _
            <string>
{
"version": "v0.0.3",
"website":"miner.sd5h.com",
"procname":"生动矿工",
"author":"ardon"
}
            </string>
            Dim jw As IO.StreamWriter = IO.File.CreateText(Application.StartupPath & "\config.json")
            jw.Write(DefaultConfig)
            jw.Close()
        End If

        Debugtext.Text = DefaultConfig
    End Sub
End Class
