﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMDevice2Code.  ISO2002 ID# _1m2agIqtEeSIDtZ76p6McQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of ATM devices.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1m2agIqtEeSIDtZ76p6McQ")]
[Description(@"List of ATM devices.")]
[DerivedFrom(typeof(ATMDeviceCode))]
public enum ATMDevice2Code
{
    /// <summary>
    /// Alarm sensors, such as tamper, seismic or heat sensors.
    /// Encoded/decoded by serializers as "AlarmSensors".
    /// </summary>
    [EnumMember(Value = "ALRM")]
    [IsoId("_6MaQYYqtEeSIDtZ76p6McQ")]
    [Description(@"Alarm sensors, such as tamper, seismic or heat sensors.")]
    AlarmSensors,
    
    /// <summary>
    /// Device scanning barcodes using any scanning technology.
    /// Encoded/decoded by serializers as "BarCodeReader".
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_6VDPA4qtEeSIDtZ76p6McQ")]
    [Description(@"Device scanning barcodes using any scanning technology.")]
    BarCodeReader,
    
    /// <summary>
    /// Camera, recorder, video mixer.
    /// Encoded/decoded by serializers as "Camera".
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_6WicwYqtEeSIDtZ76p6McQ")]
    [Description(@"Camera, recorder, video mixer.")]
    Camera,
    
    /// <summary>
    /// Device dispensing card to a consumer.
    /// Encoded/decoded by serializers as "CardDispenser".
    /// </summary>
    [EnumMember(Value = "CRDD")]
    [IsoId("_6jM_w4qtEeSIDtZ76p6McQ")]
    [Description(@"Device dispensing card to a consumer.")]
    CardDispenser,
    
    /// <summary>
    /// Device to read and optionally write card with various entry modes.
    /// Encoded/decoded by serializers as "CardUnit".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_6oH8AYqtEeSIDtZ76p6McQ")]
    [Description(@"Device to read and optionally write card with various entry modes.")]
    CardUnit,
    
    /// <summary>
    /// Device dispensing cash in an automated environment, or with an operator present.
    /// Encoded/decoded by serializers as "CashDispenser".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_6w6ro4qtEeSIDtZ76p6McQ")]
    [Description(@"Device dispensing cash in an automated environment, or with an operator present.")]
    CashDispenser,
    
    /// <summary>
    /// Device accepting in-out of items as coupons, documents, bills and coins.
    /// Encoded/decoded by serializers as "CashInModule".
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_62Ii04qtEeSIDtZ76p6McQ")]
    [Description(@"Device accepting in-out of items as coupons, documents, bills and coins.")]
    CashInModule,
    
    /// <summary>
    /// Compound device with cash in module, cash dispenser, and cash exchange.
    /// Encoded/decoded by serializers as "CashRecycler".
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_6-LEgYqtEeSIDtZ76p6McQ")]
    [Description(@"Compound device with cash in module, cash dispenser, and cash exchange.")]
    CashRecycler,
    
    /// <summary>
    /// Check reader and check image scanner.
    /// Encoded/decoded by serializers as "CheckReader".
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_7G90I4qtEeSIDtZ76p6McQ")]
    [Description(@"Check reader and check image scanner.")]
    CheckReader,
    
    /// <summary>
    /// Customer display and keyboard.
    /// Encoded/decoded by serializers as "CustomerConsole".
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("_7Ido8YqtEeSIDtZ76p6McQ")]
    [Description(@"Customer display and keyboard.")]
    CustomerConsole,
    
    /// <summary>
    /// Device for the deposit of media in envelopes or deposit of bags containing bulk media.
    /// Encoded/decoded by serializers as "Deposit".
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_7hMSAYqtEeSIDtZ76p6McQ")]
    [Description(@"Device for the deposit of media in envelopes or deposit of bags containing bulk media.")]
    Deposit,
    
    /// <summary>
    /// Printer for full-size forms documents and supporting the printing of text and graphic.
    /// Encoded/decoded by serializers as "DocumentPrinter".
    /// </summary>
    [EnumMember(Value = "DPRN")]
    [IsoId("_7pFpwYqtEeSIDtZ76p6McQ")]
    [Description(@"Printer for full-size forms documents and supporting the printing of text and graphic.")]
    DocumentPrinter,
    
    /// <summary>
    /// Door sensors, such as cabinet, safe or vandal shield doors.
    /// Encoded/decoded by serializers as "DoorSensors".
    /// </summary>
    [EnumMember(Value = "DOOR")]
    [IsoId("_7yCKYYqtEeSIDtZ76p6McQ")]
    [Description(@"Door sensors, such as cabinet, safe or vandal shield doors.")]
    DoorSensors,
    
    /// <summary>
    /// Self service device processing items.
    /// Encoded/decoded by serializers as "InputProcessingModule".
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_75e2MYqtEeSIDtZ76p6McQ")]
    [Description(@"Self service device processing items.")]
    InputProcessingModule,
    
    /// <summary>
    /// Event log.
    /// Encoded/decoded by serializers as "Journal".
    /// </summary>
    [EnumMember(Value = "JRNL")]
    [IsoId("_8BYN8YqtEeSIDtZ76p6McQ")]
    [Description(@"Event log.")]
    Journal,
    
    /// <summary>
    /// Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.
    /// Encoded/decoded by serializers as "JournalPrinter".
    /// </summary>
    [EnumMember(Value = "JPRN")]
    [IsoId("_8MtUMYqtEeSIDtZ76p6McQ")]
    [Description(@"Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.")]
    JournalPrinter,
    
    /// <summary>
    /// Other sensors and indicators unit.
    /// Encoded/decoded by serializers as "OtherSensor".
    /// </summary>
    [EnumMember(Value = "SNSR")]
    [IsoId("_8YoQUYqtEeSIDtZ76p6McQ")]
    [Description(@"Other sensors and indicators unit.")]
    OtherSensor,
    
    /// <summary>
    /// Passbook device supporting automatic positioning of the book.
    /// Encoded/decoded by serializers as "PassbookPrinter".
    /// </summary>
    [EnumMember(Value = "PSBK")]
    [IsoId("_8g-UAYqtEeSIDtZ76p6McQ")]
    [Description(@"Passbook device supporting automatic positioning of the book.")]
    PassbookPrinter,
    
    /// <summary>
    /// Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions.
    /// Encoded/decoded by serializers as "PINKeypad".
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_8oa_0YqtEeSIDtZ76p6McQ")]
    [Description(@"Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions.")]
    PINKeypad,
    
    /// <summary>
    /// Receipt printer used to print cut sheet documents.
    /// Encoded/decoded by serializers as "ReceiptPrinter".
    /// </summary>
    [EnumMember(Value = "RPRN")]
    [IsoId("_8wxDgYqtEeSIDtZ76p6McQ")]
    [Description(@"Receipt printer used to print cut sheet documents.")]
    ReceiptPrinter,
    
    /// <summary>
    /// Device incorporating both the capabilities to scan inserted documents and optionally to print on them.
    /// Encoded/decoded by serializers as "ScannerPrinter".
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_840MQYqtEeSIDtZ76p6McQ")]
    [Description(@"Device incorporating both the capabilities to scan inserted documents and optionally to print on them.")]
    ScannerPrinter,
    
    /// <summary>
    /// Receipt of the withdrawal transactions.
    /// Encoded/decoded by serializers as "WithdrawalReceipt".
    /// </summary>
    [EnumMember(Value = "RWDR")]
    [IsoId("_YA_OIY65EeSUpManOYhRpw")]
    [Description(@"Receipt of the withdrawal transactions.")]
    WithdrawalReceipt,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMDevice2CodeMetadataExtensions
{
    private static readonly ATMDevice2CodeDropdownSource _dropdownSource = new ATMDevice2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMDevice2CodeDropdownRow GetMetadata(this ATMDevice2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


