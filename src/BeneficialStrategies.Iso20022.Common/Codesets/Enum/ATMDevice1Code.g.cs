﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMDevice1Code.  ISO2002 ID# _TVx90IqIEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// ATM device to output message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVx90IqIEeSRT5rEzcAHEw")]
[Description(@"ATM device to output message.")]
[DerivedFrom(typeof(ATMDeviceCode))]
public enum ATMDevice1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerConsole".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dJrg0YqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    CustomerConsole,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DocumentPrinter".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dOmdEYqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    DocumentPrinter,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Journal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dTqjQYqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    Journal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "JournalPrinter".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dY4acYqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    JournalPrinter,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceiptPrinter".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_desukYqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    ReceiptPrinter,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithdrawalReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_djnDwYqIEeSRT5rEzcAHEw")]
    [Description(@"??")]
    WithdrawalReceipt,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMDevice1CodeMetadataExtensions
{
    private static readonly ATMDevice1CodeDropdownSource _dropdownSource = new ATMDevice1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMDevice1CodeDropdownRow GetMetadata(this ATMDevice1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

