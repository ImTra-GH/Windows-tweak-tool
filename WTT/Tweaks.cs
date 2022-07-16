using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ITT                                           //Hello!!!
{

    public partial class Tweaks : Form
    {
        public Tweaks()
        {
            InitializeComponent();
        }
        Point lastPoint;


        private void X_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public static void Cmd(string line)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = "cmd.exe", Arguments = $"/c {line}", Verb = "runas", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"" /v ""NetworkThrottlingIndex"" /t REG_DWORD /d ""10"" /f");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"" /v ""SystemResponsiveness"" / t REG_DWORD /d ""10"" /f");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\PriorityControl"" /v ""Win32PrioritySeparation"" /t REG_DWORD /d ""38"" /f");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects"" /v ""VisualFXSetting"" /t REG_DWORD /d ""2"" /f");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettings"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettingsOverride"" /t REG_DWORD /d ""3"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""FeatureSettingsOverrideMask"" /t REG_DWORD /d ""3"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""EnableCfg"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"" /v ""MoveImages"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""DisableExceptionChainValidation"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""KernelSEHOPEnabled"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\kernel"" /v ""DisableTsx"" /t REG_DWORD /d ""1"" /f");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cmd(@"fsutil behavior set disableLastAccess 1");
            Cmd(@"fsutil behavior set disable8dot3 1");
            Cmd(@"fsutil behavior set encryptpagingfile 0");
            Cmd(@"fsutil behavior set disablecompression 1");
            Cmd(@"fsutil behavior set disableencryption 1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cmd(@"takeown /f C:\Windows\System32\mcupdate_GenuineIntel.dll & del C:\Windows\System32\mcupdate_GenuineIntel.dll /s /f /q");
            Cmd(@"takeown /f C:\Windows\System32\mcupdate_AuthenticAMD.dll & del C:\Windows\System32\mcupdate_AuthenticAMD.dll /s /f /q");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer"" /v ""AltTabSettings"" /t REG_DWORD /d ""1"" /f");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cmd(@"reg add ""HKLM\Software\Microsoft\FTH\"" /v ""Enable"" /t REG_DWORD /d ""0"" /f");
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TcpAckFrequency"" /t REG_DWORD /d ""1"" /f >nul 2>&1");
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TcpDelAckTicks"" /t REG_DWORD /d ""0"" /f >nul 2>&1");
            Cmd(@"for /f %%i in ('wmic path win32_networkadapter get GUID ^| findstr ""{""') do reg add ""HKLM\System\CurrentControlSet\services\Tcpip\Parameters\Interfaces\%% i"" /v ""TCPNoDelay"" /t REG_DWORD /d ""1"" /f >nul 2>&1");
            Cmd(@"netsh int tcp set global autotuninglevel=disabled");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\mouclass\Parameters"" /v ""MouseDataQueueSize"" /t REG_DWORD /d ""50"" /f");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\kbdclass\Parameters"" /v ""KeyboardDataQueueSize"" /t REG_DWORD /d ""50"" /f");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""DisableDMACopy"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""DisableBlockWrite"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""StutterMode"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"reg add ""HKLM\SYSTEM\CurrentControlSet\services\iphlpsvc"" /v ""Start"" /t REG_DWORD /d ""4"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""EnableUlps"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""PP_SclkDeepSleepDisable"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""PP_ThermalAutoThrottlingEnable"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000"" /v ""DisableDrmdmaPowerGating"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\UMD"" /v ""ShaderCache"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\UMD"" /v ""Tessellation_OPTION"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\UMD"" /v ""Tessellation"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\UMD"" /v ""VSyncControl"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\UMD"" /v ""TFQ"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4d36e968 - e325 - 11ce - bfc1 - 08002be10318}\0000\DAL2_DATA__2_0\DisplayPath_4\EDID_D109_78E9\Option"" /v ""ProtectionControl"" /t REG_BINARY /d ""0100000001000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_DeLagEnabled"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableDMACopy"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableBlockWrite"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""StutterMode"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""EnableUlps"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""PP_SclkDeepSleepDisable"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""PP_ThermalAutoThrottlingEnable"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableDrmdmaPowerGating"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_EnableComputePreemption"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_DeLagEnabled"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ShaderCache"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation_OPTION"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""VSyncControl"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TFQ"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\DAL2_DATA__2_0\DisplayPath_4\EDID_D109_78E9\Option"" /v ""ProtectionControl"" /t REG_BINARY /d ""0100000001000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\services\amdkmdap"" /v ""KMD_APlusISharedMiniSegmentOptions"" /t REG_DWORD /d ""7"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\services\amdkmdap"" /v ""KMD_APlusISharedMiniSegmentSize"" /t REG_DWORD /d ""67108864"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\services\amdkmdap"" /v ""KMD_PXForceVideoPlaybackToIntegrated"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\CLASS\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000"" /v ""KMD_EnableCrossGpuDisplaySupport"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_EnableComputePreemption"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableDMACopy"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableBlockWrite"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""StutterMode"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""EnableUlps"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""PP_SclkDeepSleepDisable"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""PP_ThermalAutoThrottlingEnable"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""DisableDrmdmaPowerGating"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_EnableComputePreemption"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000"" /v ""KMD_DeLagEnabled"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\DAL2_DATA__2_0\DisplayPath_4\EDID_D109_78E9\Option"" /v ""ProtectionControl"" /t REG_BINARY /d ""0100000001000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdlog"" /v ""Start"" /t REG_DWORD /d ""4"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\AMD External Events Utility"" /v ""Start"" /t REG_DWORD /d ""4"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""MainVideo_SET"" /t REG_SZ /d ""0 1 2 3 4"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""MainVideo_TBL"" /t REG_SZ /d ""1:Brightness=0.0,Contrast=1.0,Saturation=1.0,Gamma=0.0,Hue=0.0;2:Brightness=-3.0,Contrast=1.16,Saturation=1.25,Gamma=0.0,Hue=0.0;3:Brightness=-3.0,Contrast=1.07,Saturation=1.10,Gamma=0.0,Hue=0.0;4:Brightness=7.0,Contrast=1.25,Saturation=0.96,Gamma=0.0,Hue=0.0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ATMS_NA"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EnableCrossfireForNonProfileApps_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EnableCrossfireForNonProfileApps"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""GI_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AreaAniso_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASTT_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AAF_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AAF_Mapping_SET"" /t REG_SZ /d ""0(Standard:2,Edge-detect:12) 2(Standard:2) 4(Standard:4,Edge-detect:12) 8(Standard:8,Edge-detect:24) 16(Standard:16)"" / f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ATMS_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AAAMethod_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""CFM_SET"" /t REG_SZ /d ""0,1,2,3,5"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""CFM_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AAF_Value_SET"" /t REG_SZ /d ""Standard:0,Edge-detect:3"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""GLPBMode_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""NoOSPowerOptions"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASD_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EQAA_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EQAAMapping_SET"" /t REG_SZ /d ""0(0:0,1:0) 2(0:2,1:2) 4(0:4,1:4) 8(0:8,1:8,2:16)"" / f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""MLF_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SurfaceFormatReplacements_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TFQ_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAliasSamples_SET"" /t REG_BINARY /d ""3020322034203800"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAlias_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAliasSamples_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAliasMapping_SET"" /t REG_BINARY /d ""3028303a302c313a3029203228303a322c313a3229203428303a342c313a3429203828303a382c313a382900"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Main3D_DEF"" /t REG_SZ /d ""3"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AnisoType_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AnisoDegree_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TextureOpt_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TextureLod_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TruformMode_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""VSyncControl_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SwapEffect_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TemporalAAMultiplier_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ExportCompressedTex_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""PixelCenter_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ForceZBufferDepth_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EnableTripleBuffering_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""CatalystAI_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation_OPTION_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation_DEF"" /t REG_SZ /d ""64"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Main3D"" /t REG_BINARY /d ""33000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AnisoType"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AnisoDegree"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAlias"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiAliasSamples"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASTT"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASD"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ASE"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TextureLod"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TextureOpt"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""VSyncControl"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TruformMode_NA"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SwapEffect"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""DitherAlpha_NA"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ZFormats_NA"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""PixelCenter"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ExportCompressedTex"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EnableTripleBuffering"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ForceZBufferDepth"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TemporalAAMultiplier_NA"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""CatalystAI"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""GI"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AAF"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation_OPTION"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Main3D_SET"" /t REG_BINARY /d ""302031203220332034203500"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AnisoDegree_SET"" /t REG_BINARY /d ""3020322034203820313600"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SwapEffect_D3D_SET"" /t REG_BINARY /d ""3020312032203320342038203900"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SwapEffect_OGL_SET"" /t REG_BINARY /d ""3020312032203320342035203620372038203920313120313220313320313420313520313620313700"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ForceZBufferDepth_SET"" /t REG_BINARY /d ""3020313620323400"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""HighQualityAF"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Tessellation_SET"" /t REG_BINARY /d ""31203220342036203820313620333220363400"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AppGpuId"" /t REG_BINARY /d ""300078003200360030003000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""PowerState"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TurboSync"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""AntiStuttering"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""ShaderCache"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""DisplayCrossfireLogo"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""MLF"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""EQAA"" /t REG_BINARY /d ""3000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""SurfaceFormatReplacements"" /t REG_BINARY /d ""3100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""TFQ"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXC"" /v ""AllowDelag"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXC"" /v ""4045523771"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""OvlTheaterMode_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""TrueWhite_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""LRTCCoef_DEF"" /t REG_SZ /d ""100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""OvlTheaterModeType_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""LRTCEnable"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""LRTCEnable_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""WhiteBalanceCorrection_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""BlueStretch_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""StaticGamma_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DemoMode_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DI_METHOD"" /t REG_BINARY /d ""2d0031000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""EnablePCOMShaders"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""EnableOCLShaders"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""VForceOCLVP9"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""VForceUVDH265"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""ColorVibrance_DEF"" /t REG_SZ /d ""40"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""ColorVibrance_ENABLE_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Denoise_DEF"" /t REG_SZ /d ""64"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Denoise_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DynamicContrast_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""OverridePA_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Detail_DEF"" /t REG_SZ /d ""10"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Detail_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DXVA_WMV"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DXVA_WMV_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""3to2Pulldown"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""3to2Pulldown_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DI_METHOD_DEF"" /t REG_SZ /d "" - 1"" / f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""StaticGamma"" /t REG_BINARY /d ""3100300030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""StaticGamma_DEF"" /t REG_SZ /d ""100"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CameraShake_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CameraShakeStrength_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CameraShakeDelay_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CameraShakeZoom_DEF"" /t REG_SZ /d ""95"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CameraShakeDisplayLogoVersion"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""MosquitoNoiseRemoval_DEF"" /t REG_SZ /d ""50"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""MosquitoNoiseRemoval_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Deblocking_DEF"" /t REG_SZ /d ""50"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Deblocking_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""CmMode_XvYCC"" /t REG_DWORD /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""BlueStretch_ENABLE_DEF"" /t REG_SZ /d ""1"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DynamicRange_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DynamicRange_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Fleshtone_DEF"" /t REG_SZ /d ""50"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Fleshtone_ENABLE_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""InternetVideo_DEF"" /t REG_SZ /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""OvlTheaterMode"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""TrueWhite"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Denoise"" /t REG_BINARY /d ""360034000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Denoise_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Detail"" /t REG_BINARY /d ""310030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Detail_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""ColorVibrance"" /t REG_BINARY /d ""340030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""ColorVibrance_ENABLE"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Fleshtone"" /t REG_BINARY /d ""350030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Fleshtone_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""WhiteBalanceCorrection"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DynamicContrast_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""LRTCCoef"" /t REG_BINARY /d ""3100300030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""BlueStretch"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""BlueStretch_ENABLE"" /t REG_BINARY /d ""31000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""StaticGamma_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DynamicRange"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""OverridePA"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""DemoMode"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Deblocking"" /t REG_BINARY /d ""350030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""Deblocking_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""MosquitoNoiseRemoval"" /t REG_BINARY /d ""350030000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""MosquitoNoiseRemoval_ENABLE"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD\DXVA"" /v ""InternetVideo"" /t REG_BINARY /d ""30000000"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Main3D_DEF"" /t REG_SZ /d ""2"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""Main3D"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000\UMD"" /v ""FlipQueueSize"" /t REG_BINARY /d ""3200"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\DVR"" /v ""ShowRSOverlay"" /t REG_SZ /d ""false"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN"" /v ""AnimationEffect"" /t REG_SZ /d ""false"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN"" /v ""CN_Hide_Toast_Notification"" /t REG_SZ /d ""true"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN"" /v ""AllowWebContent"" /t REG_SZ /d ""false"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN"" /v ""SystemTray"" /t REG_SZ /d ""false"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN"" /v ""UA_Pref"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKCU\Software\AMD\CN\DisplayScaling"" /v ""CurrentImageScale,0,0"" /t REG_DWORD /d ""1"" /f");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SOFTWARE\NVIDIA Corporation\Global\CoProcManager"" /v ""AutoDownload"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm"" /v ""EnableBugcheckDisplay"" /t REG_DWORD /d ""0"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm"" /f");
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm"" /v ""DisableMshybridNvsrSwitch"" /t REG_DWORD /d ""1"" /f");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling"" /v ""PowerThrottlingOff"" /t REG_DWORD /d ""1"" /f");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4D36E968 - E325 - 11CE - BFC1 - 08002BE10318}\0000"" /v ""RMHdcpKeyglobZero"" /t REG_DWORD /d ""1"" /f");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Cmd(@"Reg.exe add ""HKLM\SYSTEM\CurrentControlSet\Control\Class\{ 4D36E968 - E325 - 11CE - BFC1 - 08002BE10318}\0001"" /v ""RMHdcpKeyglobZero"" /t REG_DWORD /d ""1"" /f");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cmd(@"powercfg.exe /hibernate off");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
