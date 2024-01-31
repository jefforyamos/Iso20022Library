﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType1Code.  ISO2002 ID# _atCvgdp-Ed-ak6NoX_4Aeg_1585971671.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atCvgdp-Ed-ak6NoX_4Aeg_1585971671")]
[Description(@"Specifies the type of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType1Code
{
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_atCvgtp-Ed-ak6NoX_4Aeg_1645076282")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription = FundOrderTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_atCvg9p-Ed-ak6NoX_4Aeg_1645076559")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption = FundOrderTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a switch.
    /// Encoded/decoded by serializers as "SWIT".
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_atCvhNp-Ed-ak6NoX_4Aeg_1645076612")]
    [Description(@"Investment fund order is a switch.")]
    Switch = FundOrderTypeCode.Switch, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType1CodeMetadataExtensions
{
    private static readonly FundOrderType1CodeDropdownSource _dropdownSource = new FundOrderType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType1CodeDropdownRow GetMetadata(this FundOrderType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


