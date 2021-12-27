Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices

Module CsjCx2Sts32
	' CITIZEN CX-02 Printer Status Code
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
	Public Const STATUS_USUALLY_STANDBY_MODE As Integer = GROUP_USUALLY Or &H8000I

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

	' Cutter Mode Setting Value
	Public Const CUTTER_MODE_STANDARD As UInteger = 0
	Public Const CUTTER_MODE_NONSCRAP As UInteger = 1
	Public Const CUTTER_MODE_2INCHCUT As UInteger = 120
	Public Const CUTTER_MODE_PANORAMA As UInteger = 1000

	' Panorama Print Status Code
	Public Const STATUS_PRINTABLE As Integer = &H0
	Public Const STATUS_HIGHTEMP_HEAD As Integer = &H1
	Public Const STATUS_LOWTEMP_MEDIA As Integer = &H20
	Public Const STATUS_HIGHHUMIDITY As Integer = &H100
	Public Const STATUS_OTHER_STATE As Integer = &H10000
	Public Const STATUS_COMM_ERROR As Integer = &HFFFFFFFF

	' Continuous Panoramic Prints Specification
	Public Const CONT_PANORAMA_LAST As UInteger = &H0
	Public Const CONT_PANORAMA_PRINT As UInteger = &H1

	' Overcoat Setting Value
	Public Const OVERCOAT_FINISH_GLOSSY As UInteger = 0         'glossy
	Public Const OVERCOAT_FINISH_MATTE1 As UInteger = 1         'matte 1
	Public Const OVERCOAT_FINISH_MATTE2 As UInteger = 2         'matte 2( reserve )
	Public Const OVERCOAT_FINISH_MATTE3 As UInteger = 3         'matte 3( reserve )
	Public Const OVERCOAT_FINISH_FINEMATTE As UInteger = 21     'fine matte
	Public Const OVERCOAT_FINISH_LUSTER As UInteger = 22        'luster
	Public Const OVERCOAT_FINISH_PMATTE11 As UInteger = 101     'partial matte ( matte )
	Public Const OVERCOAT_FINISH_PMATTE12 As UInteger = 121     'partial matte ( fine matte )
	Public Const OVERCOAT_FINISH_PMATTE13 As UInteger = 122     'partial matte ( luster )

	' Media Extension Code
	Public Const EXT_CODE_STANDARD As String = "0000000000"
	Public Const EXT_CODE_STICKER As String = "0000000001"
	Public Const EXT_CODE_UNKNOWN As String = "0000000099"

	' Cut control parameter
	Public Const CUT_MODE_STANDARD As UInteger = 0
	Public Const CUT_MODE_STICKER As UInteger = 1
	Public Const CUT_MODE_INSTRUCTION As UInteger = 2
	Public Const CUT_MODE_PAPER_FEED As UInteger = 10
	Public Const CUT_MODE_FEED_FORWARD As UInteger = 100
	Public Const CUT_MODE_FEED_BACKWARD As UInteger = 200
	Public Const CUT_MODE_START_CUTTING As UInteger = 1000

	' Cut Control Status
	Public Const CUT_STS_IDLE As UInteger = 0
	Public Const CUT_STS_PRINTING As UInteger = 1
	Public Const CUT_STS_WAIT_PAPER_FEED As UInteger = 10
	Public Const CUT_STS_WAIT_COMMAND As UInteger = 20
	Public Const CUT_STS_FEED_FORWARD As UInteger = 120
	Public Const CUT_STS_FEED_BACKWARD As UInteger = 220
	Public Const CUT_STS_WAIT_START_CUTTING As UInteger = 1000
	Public Const CUT_STS_ERROR As UInteger = 9000

	' Old Printer Status Code definition
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
	Public Const CVS_USUALLY_STANDBY_MODE As Integer = CVG_USUALLY Or &H8000I

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

	Declare Function CvInitialize Lib "CsjCx2Sts.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal p As String) As Integer
	Declare Function CvGetVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvGetSensorInfo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvGetResolutionH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetResolutionV Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetMedia Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvGetStatus Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetCounterL Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvSetClearCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvSetClearCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetFreeBuffer Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetPQTY Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetMediaCounter Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetMediaColorOffset Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvGetMediaLotNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvGetSerialNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvSetFirmwUpdateMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvSetFirmwDataWrite_ Lib "CsjCx2Sts.dll" Alias "CvSetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function CvSetColorDataClear Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function CvSetColorDataWrite_ Lib "CsjCx2Sts.dll" Alias "CvSetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function CvSetColorDataVersion_ Lib "CsjCx2Sts.dll" Alias "CvSetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function CvGetColorDataVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvGetColorDataChecksum Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function CvSetCommand_ Lib "CsjCx2Sts.dll" Alias "CvSetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
	Declare Function CvGetCommandEX_ Lib "CsjCx2Sts.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
	Declare Function CvGetCommandEX_ Lib "CsjCx2Sts.dll" Alias "CvGetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff() As Byte, ByVal dwRetBuffSize As Integer) As Integer
	'
	Declare Function PortInitialize Lib "CsjCx2Sts.dll" (<MarshalAs(UnmanagedType.LPWStr)> ByVal p As String) As Integer
	Declare Function GetFirmwVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetSensorInfo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetResolutionH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetResolutionV Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetMedia Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetStatus Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterL Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterP Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterMatte Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetCounterM Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetClearCounterA Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetClearCounterB Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetClearCounterM Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetCounterP Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lCounter As Integer) As Integer
	Declare Function GetFreeBuffer Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetPQTY Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetMediaCounter Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetMediaCounterH Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetInitialMediaCount Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetMediaColorOffset Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetMediaLotNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetRfidMediaClass Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetRfidReserveData Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String, ByVal dwPage As Integer) As Integer
	Declare Function GetSerialNo Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function SetUSBSerialEnable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal dwEnable As Integer) As Integer
	Declare Function GetUSBSerialEnable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetFirmwUpdateMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetFirmwDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetFirmwDataWrite" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function SetColorDataClear Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetColorDataWrite_ Lib "CsjCx2Sts.dll" Alias "SetColorDataWrite" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function SetColorDataVersion_ Lib "CsjCx2Sts.dll" Alias "SetColorDataVersion" (ByVal lPortNum As Integer, ByVal lpData As Integer, ByVal dwDataLen As Integer) As Integer
	Declare Function GetColorDataVersion Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetColorDataVersionRes Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String, ByVal dwType As Integer) As Integer
	Declare Function GetColorDataChecksum Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String) As Integer
	Declare Function GetColorDataChecksumRes Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal p As String, ByVal dwType As Integer) As Integer
	Declare Function SetCutterMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal dwMode As Integer) As Integer
	Declare Function SetFullCutterSetup Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lSize1 As Integer, ByVal lSize2 As Integer, ByVal lSize3 As Integer, ByVal lSize4 As Integer) As Integer
	Declare Function SetFullCutterSetupEX Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lCutSize1 As Integer, ByVal lCutSize2 As Integer, ByVal lCutSize3 As Integer, ByVal lCutSize4 As Integer, ByVal lDustSize As Integer) As Integer
	Declare Function SetCutControl Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal dwMode As UInteger, ByVal dwSpeed As UInteger, ByVal dwLength As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
	Declare Function SetPaperFeed Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal dwFrontFeed As UInteger, ByVal dwRearFeed As UInteger, ByVal dwFlag As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
	Declare Function GetCutControlStatus Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByRef lpState As UInteger, ByRef lpFeedCount As UInteger, ByRef lpRemainLength As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
	Declare Function GetMediaExtensionCode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal s As String) As Integer
	Declare Function SetStandbyTime Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lTime As Integer) As Integer
	Declare Function GetStandbyTime Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetEndKeepMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal lMode As Integer) As Integer
	Declare Function GetEndKeepMode Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function GetPanoramaPrintable Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer) As Integer
	Declare Function SetOvercoatFinish Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal ovcoat As Integer) As Integer
	Declare Function SetContPanorama Lib "CsjCx2Sts.dll" (ByVal lPortNum As Integer, ByVal dwContinuous As UInteger, ByVal dwOverlap As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
	Declare Function SetCommand_ Lib "CsjCx2Sts.dll" Alias "SetCommand" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer) As Integer
	Declare Function GetCommandEX_ Lib "CsjCx2Sts.dll" Alias "GetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff As String, ByVal dwRetBuffSize As Integer) As Integer
	Declare Function GetCommandEX_ Lib "CsjCx2Sts.dll" Alias "GetCommandEX" (ByVal lPortNum As Integer, ByVal lpCmd As Integer, ByVal dwCmdLen As Integer, ByVal lpRetBuff() As Byte, ByVal dwRetBuffSize As Integer) As Integer

	'-----------------------------------------------------------------------------------CX API Wrapper function
	Public Function CvSetCommand(
	  ByVal lPortNum As Integer,
	  ByVal Cmd As String,
	  ByVal dwCmdLen As Integer
	  ) As Integer

		Dim ByteArray As Byte()
		'Code Page 65001 = UTF-8
		ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
		'ガベージコレクタを固定する
		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		'固定オブジェクトのアドレスを取得する
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		CvSetCommand = CvSetCommand_(lPortNum, lpCmd, dwCmdLen)

		'開放
		gchCmd.Free()

	End Function

	Public Function CvSetData(
	  ByVal lPortNum As Integer,
	  ByVal ByteArray() As Byte,
	  ByVal dwLen As Integer
	  ) As Integer

		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		CvSetData = CvSetCommand_(lPortNum, lpCmd, dwLen)

		gchCmd.Free()

	End Function

	Public Function CvGetCommandEX(
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
		CvGetCommandEX = CvGetCommandEX_(lPortNum, lpCmd, dwCmdLen, rb, dwRetBuffSize)

		gchCmd.Free()

	End Function

	Public Function SetCommand(
	   ByVal lPortNum As Integer,
	   ByVal Cmd As String,
	   ByVal dwCmdLen As Integer
	   ) As Integer

		Dim ByteArray As Byte()
		'Code Page 65001 = UTF-8
		ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
		'ガベージコレクタを固定する
		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		'固定オブジェクトのアドレスを取得する
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		SetCommand = SetCommand_(lPortNum, lpCmd, dwCmdLen)

		'開放
		gchCmd.Free()

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

	Public Function CvSetFirmwDataWrite(
	  ByVal lPortNum As Integer,
	  ByVal ByteArray() As Byte,
	  ByVal dwLen As Integer
	  ) As Integer

		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		CvSetFirmwDataWrite = CvSetFirmwDataWrite_(lPortNum, lpCmd, dwLen)

		gchCmd.Free()

	End Function

	Public Function CvSetColorDataVersion(
	  ByVal lPortNum As Integer,
	  ByVal Cmd As String,
	  ByVal dwCmdLen As Integer
	  ) As Integer

		Dim ByteArray As Byte()
		ByteArray = System.Text.Encoding.GetEncoding(65001).GetBytes(Cmd)
		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		CvSetColorDataVersion = CvSetColorDataVersion_(lPortNum, lpCmd, dwCmdLen)

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

	Public Function CvSetColorDataWrite(
	  ByVal lPortNum As Integer,
	  ByVal ByteArray() As Byte,
	  ByVal dwLen As Integer
	  ) As Integer

		Dim gchCmd As GCHandle = GCHandle.Alloc(ByteArray, GCHandleType.Pinned)
		Dim lpCmd As Integer = gchCmd.AddrOfPinnedObject().ToInt32()
		CvSetColorDataWrite = CvSetColorDataWrite_(lPortNum, lpCmd, dwLen)

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

End Module

