﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferType1Code.  ISO2002 ID# _YvbMR9p-Ed-ak6NoX_4Aeg_-1593227544.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YvbMR9p-Ed-ak6NoX_4Aeg_-1593227544")]
[Description(@"Specifies whether the financial instrument is transferred as an asset or as cash.")]
[DerivedFrom(typeof(TransferTypeCode))]
public enum TransferType1Code
{
    /// <summary>
    /// Transfer the security as an asset in specie, that is, 'in its actual form'.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YvbMSNp-Ed-ak6NoX_4Aeg_-1303244696")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie = TransferTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Yvk9QNp-Ed-ak6NoX_4Aeg_-1291238985")]
    [Description(@"Transfer as cash.")]
    Cash = TransferTypeCode.Cash, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferType1CodeMetadataExtensions
{
    private static readonly TransferType1CodeDropdownSource _dropdownSource = new TransferType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferType1CodeDropdownRow GetMetadata(this TransferType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


