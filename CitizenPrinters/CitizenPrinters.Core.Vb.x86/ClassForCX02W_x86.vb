Imports System.Runtime.InteropServices

Public Class ClassForCX02W_x86
    Implements IDisposable

    Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Declare Function CvInitialize Lib "Cx2WStat.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function CvGetVersion Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSensorInfo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetMedia Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetStatus Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetPQTY Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterL Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterA Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetCounterB Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaCounter Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaColorOffset Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetMediaLotNo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataVersion_ Lib "Cx2WStat.dll" Alias "CvSetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetColorDataWrite_ Lib "Cx2WStat.dll" Alias "CvSetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvGetColorDataVersion Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvSetColorDataClear Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetColorDataChecksum Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetSerialNo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function CvGetResolutionH Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetResolutionV Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvGetFreeBuffer Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterA Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetClearCounterB Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwUpdateMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function CvSetFirmwDataWrite_ Lib "Cx2WStat.dll" Alias "CvSetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function CvSetCommand_ Lib "Cx2WStat.dll" Alias "CvSetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
    Declare Function CvGetCommand_ Lib "Cx2WStat.dll" Alias "CvGetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer, ByRef lpdwRetLen As Integer) As Integer
    Declare Function CvGetCommandEX_ Lib "Cx2WStat.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
    Declare Function CvGetCommandEX_ Lib "Cx2WStat.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff() As Byte, ByVal dwRetBuffSize As Integer) As Integer
    '
    Declare Function PortInitialize Lib "Cx2WStat.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String) As Integer
    Declare Function PortInitializeEX Lib "Cx2WStat.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal pszPortName As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal pszPrinterName As String) As Integer
    Declare Function RegisterPrinterName Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal pszPrinterName As String) As Integer
    Declare Function GetFirmwVersion Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetSensorInfo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMedia Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetStatus Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetPQTY Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterL Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterA Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterB Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterP Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterMatte Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetCounterM Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounter_R Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounterH Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaCounterH_R Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaColorOffset Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetMediaLotNo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetMediaIdSetInfo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetRfidMediaClass Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetRfidReserveData Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dwPAge As Integer) As Integer
    Declare Function SetColorDataVersion_ Lib "Cx2WStat.dll" Alias "SetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetColorDataWrite_ Lib "Cx2WStat.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function GetColorDataVersion Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetColorDataVersionRes Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer) As Integer
    Declare Function SetColorDataClear Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetColorDataChecksum Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetColorDataChecksumRes Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer) As Integer
    Declare Function GetSerialNo Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
    Declare Function GetResolutionH Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetResolutionV Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function GetFreeBuffer Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterA Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterB Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetClearCounterM Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetCounterP Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal Counter As Integer) As Integer
    Declare Function SetFirmwUpdateMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetFirmwDataWrite_ Lib "Cx2WStat.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpBuff As Integer, ByVal bLen As Integer) As Integer
    Declare Function SetCutterMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal d As Integer) As Integer
    Declare Function SetRettentionMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal d As Integer) As Integer
    Declare Function GetInitialMediaCount Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetUSBSerialEnable Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal b As Boolean) As Integer
    Declare Function GetUSBSerialEnable Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer

    Declare Function SetFullCutterSetup Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal lSize1 As Integer, ByVal lSize2 As Integer, ByVal lSize3 As Integer, ByVal lSize4 As Integer, ByVal lSize5 As Integer, ByVal lSize6 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Declare Function SetStandbyTime Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal lTime As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Declare Function GetStandbyTime Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetEndKeepMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal lMode As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Declare Function GetEndKeepMode Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetFullCutterSetupEX Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal lCutSize1 As Integer, ByVal lCutSize2 As Integer, ByVal lCutSize3 As Integer, ByVal lCutSize4 As Integer, ByVal lCutSize5 As Integer, ByVal lCutSize6 As Integer, ByVal DustSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Declare Function GetPanoramaPrintable Lib "Cx2WStat.dll" (ByVal lPortNum As Integer) As Integer
    Declare Function SetOvercoatFinish Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal ovcoat As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Declare Function GetColorDataVersionResEX Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer, ByVal lMedia As Integer) As Integer
    Declare Function GetColorDataChecksumResEX Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal s As String, ByVal dpi As Integer, ByVal lMedia As Integer) As Integer
    Declare Function SetPrintSpeed Lib "Cx2WStat.dll" (ByVal lPortNum As Integer, ByVal lPrintSpeed As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

End Class


