﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AmountType1Code.  ISO2002 ID# _be0Ksdp-Ed-ak6NoX_4Aeg_334790339.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the value of the amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be0Ksdp-Ed-ak6NoX_4Aeg_334790339")]
[Description(@"Specifies the value of the amount.")]
[DerivedFrom(typeof(AmountTypeCode))]
public enum AmountType1Code
{
    /// <summary>
    /// The amount is open.
    /// Encoded/decoded by serializers as "Open".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_be0Kstp-Ed-ak6NoX_4Aeg_334790348")]
    [Description(@"The amount is open.")]
    Open,
    
    /// <summary>
    /// The amount is unkown.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_be0Ks9p-Ed-ak6NoX_4Aeg_334790370")]
    [Description(@"The amount is unkown.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AmountType1CodeMetadataExtensions
{
    private static readonly AmountType1CodeDropdownSource _dropdownSource = new AmountType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAmountType1CodeDropdownRow GetMetadata(this AmountType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


