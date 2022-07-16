using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ITT
{
    public partial class Revert : Form
    {
        public Revert()
        {
            InitializeComponent();
        }
        public static void Cmd(string line)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = "cmd.exe", Arguments = $"/c {line}", Verb = "runas", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"" /v ""SystemResponsiveness"" / t REG_DWORD /d ""14"" /f");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"" /v ""NetworkThrottlingIndex"" /t REG_DWORD /d ""10"" /f");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettings"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettingsOverride"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettingsOverrideMask"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""EnableCfg"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""MoveImages"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""DisableExceptionChainValidation"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""KernelSEHOPEnabled"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""DisableTsx"" /t REG_DWORD /d ""0"" /f");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\PriorityControl"" /v ""Win32PrioritySeparation"" /t REG_DWORD /d ""2"" /f");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects"" /v ""VisualFXSetting"" /t REG_DWORD /d ""1"" /f");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cmd(@"fsutil behavior set disableLastAccess 0");
            Cmd(@"fsutil behavior set disable8dot3 0");
            Cmd(@"fsutil behavior set encryptpagingfile 1");
            Cmd(@"fsutil behavior set disablecompression 0");
            Cmd(@"fsutil behavior set disableencryption 0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer"" /v ""AltTabSettings"" /t REG_DWORD /d ""0"" /f");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\Software\Microsoft\FTH\"" /v ""Enable"" /t REG_DWORD /d ""1"" /f");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TcpAckFrequency"" /t REG_DWORD /d ""0"" /f >nul 2>&1");
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TcpDelAckTicks"" /t REG_DWORD /d ""1"" /f >nul 2>&1");
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TCPNoDelay"" /t REG_DWORD /d ""0"" /f >nul 2>&1");
            Cmd(@"netsh int tcp set global autotuninglevel=normal");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reinstall your GPU Driver");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reinstall your GPU Driver");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\mouclass\Parameters"" /v ""MouseDataQueueSize"" /t REG_DWORD /d ""100"" /f");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\kbdclass\Parameters"" /v ""KeyboardDataQueueSize"" /t REG_DWORD /d ""100"" /f");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling"" /v ""PowerThrottlingOff"" /t REG_DWORD /d ""0"" /f");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cmd(@"powercfg.exe /hibernate on");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe delete ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4D36E968 - E325 - 11CE - BFC1 - 08002BE10318}\0000"" /v ""RMHdcpKeyglobZero"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4D36E968 - E325 - 11CE - BFC1 - 08002BE10318}\0001"" /v ""RMHdcpKeyglobZero"" /t REG_DWORD /d ""1"" /f");
        }
    }
    }
