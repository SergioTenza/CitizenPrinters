Imports System.Runtime.InteropServices

Public Class ClassForCY_x86
    Implements IDisposable

    Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Public Const GROUP_USUALLY As Integer = &H10000
    Public Const GROUP_SETTING As Integer = &H20000
    Public Const GROUP_HARDWARE As Integer = &H40000
    Public Const GROUP_SYSTEM As Integer = &H80000
    Public Const GROUP_FLSHPROG As Integer = &H100000

    Public Const STATUS_ERROR As Integer = &H80000000

    Public Const STATUS_USUALLY_IDLE As Integer = GROUP_USUALLY Or &H1S
    Public Const STATUS_USUALLY_PRINTING As Integer = GROUP_USUALLY Or &H2S
    Public Const STATUS_USUALLY_STANDSTILL As Integer = GROUP_USUALLY Or &H4S
    Public Const STATUS_USUALLY_PAPER_END As Integer = GROUP_USUALLY Or &H8S
    Public Const STATUS_USUALLY_RIBBON_END As Integer = GROUP_USUALLY Or &H10S
    Public Const STATUS_USUALLY_COOLING As Integer = GROUP_USUALLY Or &H20S
    Public Const STATUS_USUALLY_MOTCOOLING As Integer = GROUP_USUALLY Or &H40S

    Public Const STATUS_SETTING_COVER_OPEN As Integer = GROUP_SETTING Or &H1S
    Public Const STATUS_SETTING_PAPER_JAM As Integer = GROUP_SETTING Or &H2S
    Public Const STATUS_SETTING_RIBBON_ERR As Integer = GROUP_SETTING Or &H4S
    Public Const STATUS_SETTING_PAPER_ERR As Integer = GROUP_SETTING Or &H8S
    Public Const STATUS_SETTING_DATA_ERR As Integer = GROUP_SETTING Or &H10S
    Public Const STATUS_SETTING_SCRAPBOX_ERR As Integer = GROUP_SETTING Or &H20S

    Public Const STATUS_HARDWARE_ERR01 As Integer = GROUP_HARDWARE Or &H1S
    Public Const STATUS_HARDWARE_ERR02 As Integer = GROUP_HARDWARE Or &H2S
    Public Const STATUS_HARDWARE_ERR03 As Integer = GROUP_HARDWARE Or &H4S
    Public Const STATUS_HARDWARE_ERR04 As Integer = GROUP_HARDWARE Or &H8S
    Public Const STATUS_HARDWARE_ERR05 As Integer = GROUP_HARDWARE Or &H10S
    Public Const STATUS_HARDWARE_ERR06 As Integer = GROUP_HARDWARE Or &H20S
    Public Const STATUS_HARDWARE_ERR07 As Integer = GROUP_HARDWARE Or &H40S
    Public Const STATUS_HARDWARE_ERR08 As Integer = GROUP_HARDWARE Or &H80S
    Public Const STATUS_HARDWARE_ERR09 As Integer = GROUP_HARDWARE Or &H100S
    Public Const STATUS_HARDWARE_ERR10 As Integer = GROUP_HARDWARE Or &H200S

    Public Const STATUS_SYSTEM_ERR01 As Integer = GROUP_SYSTEM Or &H1S

    Public Const STATUS_FLSHPROG_IDLE As Integer = GROUP_FLSHPROG Or &H1S
    Public Const STATUS_FLSHPROG_WRITING As Integer = GROUP_FLSHPROG Or &H2S
    Public Const STATUS_FLSHPROG_FINISHED As Integer = GROUP_FLSHPROG Or &H4S
    Public Const STATUS_FLSHPROG_DATA_ERR1 As Integer = GROUP_FLSHPROG Or &H8S
    Public Const STATUS_FLSHPROG_DEVICE_ERR1 As Integer = GROUP_FLSHPROG Or &H10S
    Public Const STATUS_FLSHPROG_OTHERS_ERR1 As Integer = GROUP_FLSHPROG Or &H20S

    'For CV Printers Item
    Public Const CVG_USUALLY As Integer = &H10000
    Public Const CVG_SETTING As Integer = &H20000
    Public Const CVG_HARDWARE As Integer = &H40000
    Public Const CVG_SYSTEM As Integer = &H80000
    Public Const CVG_FLSHPROG As Integer = &H100000

    Public Const CVSTATUS_ERROR As Integer = &H80000000

    Public Const CVS_USUALLY_IDLE As Integer = CVG_USUALLY Or &H1S
    Public Const CVS_USUALLY_PRINTING As Integer = CVG_USUALLY Or &H2S
    Public Const CVS_USUALLY_STANDSTILL As Integer = CVG_USUALLY Or &H4S
    Public Const CVS_USUALLY_PAPER_END As Integer = CVG_USUALLY Or &H8S
    Public Const CVS_USUALLY_RIBBON_END As Integer = CVG_USUALLY Or &H10S
    Public Const CVS_USUALLY_COOLING As Integer = CVG_USUALLY Or &H20S
    Public Const CVS_USUALLY_MOTCOOLING As Integer = CVG_USUALLY Or &H40S

    Public Const CVS_SETTING_COVER_OPEN As Integer = CVG_SETTING Or &H1S
    Public Const CVS_SETTING_PAPER_JAM As Integer = CVG_SETTING Or &H2S
    Public Const CVS_SETTING_RIBBON_ERR As Integer = CVG_SETTING Or &H4S
    Public Const CVS_SETTING_PAPER_ERR As Integer = CVG_SETTING Or &H8S
    Public Const CVS_SETTING_DATA_ERR As Integer = CVG_SETTING Or &H10S
    Public Const CVS_SETTING_SCRAP_ERR As Integer = CVG_SETTING Or &H20S

    Public Const CVS_HARDWARE_ERR01 As Integer = CVG_HARDWARE Or &H1S
    Public Const CVS_HARDWARE_ERR02 As Integer = CVG_HARDWARE Or &H2S
    Public Const CVS_HARDWARE_ERR03 As Integer = CVG_HARDWARE Or &H4S
    Public Const CVS_HARDWARE_ERR04 As Integer = CVG_HARDWARE Or &H8S
    Public Const CVS_HARDWARE_ERR05 As Integer = CVG_HARDWARE Or &H10S
    Public Const CVS_HARDWARE_ERR06 As Integer = CVG_HARDWARE Or &H20S
    Public Const CVS_HARDWARE_ERR07 As Integer = CVG_HARDWARE Or &H40S
    Public Const CVS_HARDWARE_ERR08 As Integer = CVG_HARDWARE Or &H80S
    Public Const CVS_HARDWARE_ERR09 As Integer = CVG_HARDWARE Or &H100S
    Public Const CVS_HARDWARE_ERR10 As Integer = CVG_HARDWARE Or &H200S

    Public Const CVS_SYSTEM_ERR01 As Integer = CVG_SYSTEM Or &H1S

    Public Const CVS_FLSHPROG_IDLE As Integer = CVG_FLSHPROG Or &H1S
    Public Const CVS_FLSHPROG_WRITING As Integer = CVG_FLSHPROG Or &H2S
    Public Const CVS_FLSHPROG_FINISHED As Integer = CVG_FLSHPROG Or &H4S
    Public Const CVS_FLSHPROG_DATA_ERR1 As Integer = CVG_FLSHPROG Or &H8S
    Public Const CVS_FLSHPROG_DEVICE_ERR1 As Integer = CVG_FLSHPROG Or &H10S
    Public Const CVS_FLSHPROG_OTHERS_ERR1 As Integer = CVG_FLSHPROG Or &H20S


    Public Const CUTTER_MODE_STANDARD As Short = &H0S
    Public Const CUTTER_MODE_NONSCRAP As Short = &H1S
    Public Const CUTTER_MODE_2INCHCUT As Short = &H78S


    Declare Function CvInitialize Lib "CyStat.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function CvGetVersion Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSensorInfo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetMedia Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetStatus Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetPQTY Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterL Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterA Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterB Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaCounter Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaColorOffset Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaLotNo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataVersion_ Lib "CyStat.dll" Alias "CvSetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetColorDataWrite_ Lib "CyStat.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvGetColorDataVersion Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataClear Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetColorDataChecksum Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSerialNo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetResolutionH Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetResolutionV Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetFreeBuffer Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterA Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterB Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwUpdateMode Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwDataWrite_ Lib "CyStat.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetCommand_ Lib "CyStat.dll" Alias "CvSetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
    Declare Function CvGetCommand_ Lib "CyStat.dll" Alias "CvGetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer, ByRef lpdwRetLen As Integer) As Integer
    Declare Function CvGetCommandEX_ Lib "CyStat.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
    Declare Function PortInitialize Lib "CyStat.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function GetFirmwVersion Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetSensorInfo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMedia Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetStatus Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetPQTY Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterL Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterA Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterB Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterP Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterMatte Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterM Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter_R Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaColorOffset Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaLotNo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMediaIdSetInfo Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetColorDataVersion_ Lib "CyStat.dll" Alias "SetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetColorDataWrite_ Lib "CyStat.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function GetColorDataVersion Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function SetColorDataClear Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetColorDataChecksum Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetSerialNo Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetResolutionH Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetResolutionV Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetFreeBuffer Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterA Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterB Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterM Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetCounterP Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal Counter As Integer) As Integer
    Declare Function SetFirmwUpdateMode Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetFirmwDataWrite_ Lib "CyStat.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetCutterMode Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal d As Integer) As Integer
    Declare Function SetCommand_ Lib "CyStat.dll" Alias "SetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
    Declare Function GetCommand_ Lib "CyStat.dll" Alias "GetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer, ByRef lpdwRetLen As Integer) As Integer
    Declare Function GetCommandEX_ Lib "CyStat.dll" Alias "GetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
    Declare Function GetRfidMediaClass Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetRfidReserveData Lib "CyStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dwPage As Integer) As Integer
    Declare Function GetInitialMediaCount Lib "CyStat.dll" (ByVal lPortNum As Integer) As Integer


    '----------------------------------------------------------------------------------- API Wrapper function
    Public Function SetCommand(
            ByVal lPortNum As Integer,
            ByVal Cmd As String,
            ByVal dwCmdLen As Integer
            ) As Integer

        Dim ByteArray As Byte()
        ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        SetCommand = SetCommand_(lPortNum, lpCmd, dwCmdLen)

        gchCmd.Free()

    End Function


    Public Function GetCommand(
                    ByVal lPortNum As Integer,
                    ByVal Cmd As String,
                    ByVal dwCmdLen As Integer,
                    ByRef rb As String,
                    ByVal dwRetBuffSize As Integer,
                    ByRef dwRetLen As Integer
                    ) As Integer

        Dim ByteArray As Byte()
        ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim gchRetLen As GCHandle = GCHandle.Alloc(dwRetLen, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        Dim lpdwRetLen As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        GetCommand = GetCommand_(lPortNum, lpCmd, dwCmdLen, rb, dwRetBuffSize, lpdwRetLen)

        gchCmd.Free()
        gchRetLen.Free()

    End Function


    Public Function GetCommandEX(
                ByVal lPortNum As Integer,
                ByVal Cmd As String,
                ByVal dwCmdLen As Integer,
                ByRef rb As String,
                ByVal dwRetBuffSize As Integer
                ) As Integer

        Dim ByteArray As Byte()
        ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        GetCommandEX = GetCommandEX_(lPortNum, lpCmd, dwCmdLen, rb, dwRetBuffSize)

        gchCmd.Free()

    End Function


    Public Function SetFirmwDataWrite(
            ByVal lPortNum As Integer,
            ByVal ByteArray() As Byte,
            ByVal dwLen As Integer
            ) As Integer

        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        SetFirmwDataWrite = SetFirmwDataWrite_(lPortNum, lpCmd, dwLen)

        gchCmd.Free()

    End Function


    Public Function SetColorDataVersion(
            ByVal lPortNum As Integer,
            ByVal Cmd As String,
            ByVal dwCmdLen As Integer
            ) As Integer

        Dim ByteArray As Byte()
        ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        SetColorDataVersion = SetColorDataVersion_(lPortNum, lpCmd, dwCmdLen)

        gchCmd.Free()

    End Function


    Public Function SetColorDataWrite(
            ByVal lPortNum As Integer,
            ByVal ByteArray() As Byte,
            ByVal dwLen As Integer
            ) As Integer

        Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
        Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
        SetColorDataWrite = SetColorDataWrite_(lPortNum, lpCmd, dwLen)

        gchCmd.Free()

    End Function
End Class