﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType1Code.  ISO2002 ID# _aJIKJ9p-Ed-ak6NoX_4Aeg_1793790743.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJIKJ9p-Ed-ak6NoX_4Aeg_1793790743")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType1Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJIKKNp-Ed-ak6NoX_4Aeg_-2127153341")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJR7INp-Ed-ak6NoX_4Aeg_-2125306944")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as "PARV".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_aJR7Idp-Ed-ak6NoX_4Aeg_1927701255")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType1CodeMetadataExtensions
{
    private static readonly PriceValueType1CodeDropdownSource _dropdownSource = new PriceValueType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType1CodeDropdownRow GetMetadata(this PriceValueType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


