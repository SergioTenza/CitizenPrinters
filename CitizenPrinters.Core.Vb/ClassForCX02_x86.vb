Imports System.Runtime.InteropServices

Public Class ClassForCX02_x86
    Implements IDisposable

    Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Declare Function CvInitialize Lib "CsjCx2Sts.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function CvGetVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSensorInfo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetMedia Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetStatus Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetPQTY Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterL Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaCounter Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaColorOffset Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaLotNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataVersion_ Lib "CsjCx2Sts.dll" Alias "CvSetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetColorDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvGetColorDataVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataClear Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetColorDataChecksum Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSerialNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetResolutionH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetResolutionV Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetFreeBuffer Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwUpdateMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetCommand_ Lib "CsjCx2Sts.dll" Alias "CvSetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
    Declare Function CvGetCommand_ Lib "CsjCx2Sts.dll" Alias "CvGetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer, ByRef lpdwRetLen As Integer) As Integer
    Declare Function CvGetCommandEX_ Lib "CsjCx2Sts.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
    Declare Function CvGetCommandEX_ Lib "CsjCx2Sts.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff() As Byte, ByVal dwRetBuffSize As Integer) As Integer
    '
    Declare Function PortInitialize Lib "CsjCx2Sts.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function PortInitializeEX Lib "CsjCx2Sts.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal pszPrinterName As String) As Integer
    Declare Function RegisterPrinterName Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal pszPrinterName As String) As Integer
    Declare Function GetFirmwVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetSensorInfo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMedia Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetStatus Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetPQTY Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterL Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterP Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterMatte Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterM Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter_R Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounterH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounterH_R Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaColorOffset Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaLotNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMediaIdSetInfo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetRfidMediaClass Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetRfidReserveData Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dwPAge As Integer) As Integer
    Declare Function SetColorDataVersion_ Lib "CsjCx2Sts.dll" Alias "SetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetColorDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function GetColorDataVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetColorDataVersionRes Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer) As Integer
    Declare Function SetColorDataClear Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetColorDataChecksum Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetColorDataChecksumRes Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer) As Integer
    Declare Function GetSerialNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetResolutionH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetResolutionV Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetFreeBuffer Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterM Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetCounterP Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal Counter As Integer) As Integer
    Declare Function SetFirmwUpdateMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetFirmwDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetCutterMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal d As Integer) As Integer
    Declare Function SetRettentionMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal d As Integer) As Integer
    Declare Function GetInitialMediaCount Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetUSBSerialEnable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal b As Boolean) As Integer
    Declare Function GetUSBSerialEnable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer

    Declare Function SetFullCutterSetup Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal i1 As Integer, ByVal i2 As Integer, ByVal i3 As Integer, ByVal i4 As Integer) As Integer
    Declare Function SetFullCutterSetupEx Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal i1 As Integer, ByVal i2 As Integer, ByVal i3 As Integer, ByVal i4 As Integer, ByVal iDS As Integer) As Integer
    Declare Function SetStandbyTime Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lTime As Integer) As Integer
    Declare Function GetStandbyTime Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetEndKeepMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lMode As Integer) As Integer
    Declare Function GetEndKeepMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetPanoramaPrintable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetOvercoatFinish Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal ovcoat As Integer) As Integer


End Class


