﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferType4Code.  ISO2002 ID# _xvY1YKxWEemRcYBAkJyjkg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xvY1YKxWEemRcYBAkJyjkg")]
[Description(@"Specifies whether a financial instrument is transferred as an asset or as cash.")]
[DerivedFrom(typeof(TransferTypeCode))]
public enum TransferType4Code
{
    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_y8KKgaxWEemRcYBAkJyjkg")]
    [Description(@"Transfer as cash.")]
    Cash = TransferTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ISIN is converted to another ISIN and then transferred.
    /// Encoded/decoded by serializers as "CONV".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_zABW0axWEemRcYBAkJyjkg")]
    [Description(@"ISIN is converted to another ISIN and then transferred.")]
    Conversion = TransferTypeCode.Conversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Asset excluded from transfer.
    /// Encoded/decoded by serializers as "EXCL".
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_zE7sAaxWEemRcYBAkJyjkg")]
    [Description(@"Asset excluded from transfer.")]
    Excluded = TransferTypeCode.Excluded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer the security as an asset in specie, that is, 'in its actual form'.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_zJGaUaxWEemRcYBAkJyjkg")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie = TransferTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferType4CodeMetadataExtensions
{
    private static readonly TransferType4CodeDropdownSource _dropdownSource = new TransferType4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferType4CodeDropdownRow GetMetadata(this TransferType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


