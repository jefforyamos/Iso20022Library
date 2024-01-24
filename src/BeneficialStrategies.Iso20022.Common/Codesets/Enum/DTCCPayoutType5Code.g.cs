﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCPayoutType5Code.  ISO2002 ID# _zzlRAZCMEeaSk9d1hvTrHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zzlRAZCMEeaSk9d1hvTrHg")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.")]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
public enum DTCCPayoutType5Code
{
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// Encoded/decoded by serializers as "CAPG".
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_0LieAZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as capital gains.")]
    CapitalGains = DTCCPayoutTypeCode.CapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payout consisting of cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_0LieA5CMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of cash.")]
    Cash = DTCCPayoutTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_0LieBZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    Dividend = DTCCPayoutTypeCode.Dividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_0LieB5CMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.")]
    Interest = DTCCPayoutTypeCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// Encoded/decoded by serializers as "LTCG".
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_0LieCZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as long-term capital gains.")]
    LongTermCapitalGains = DTCCPayoutTypeCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// Encoded/decoded by serializers as "PREM".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_0LieC5CMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.")]
    Premium = DTCCPayoutTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// Encoded/decoded by serializers as "PRPL".
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_0LieDZCMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment on a debt instrument that represents a return of principal to the holder.")]
    Principal = DTCCPayoutTypeCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution that doesn't represent earnings and is categorised by the company as return of capital.
    /// Encoded/decoded by serializers as "ROCA".
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_0LieD5CMEeaSk9d1hvTrHg")]
    [Description(@"Distribution that doesn't represent earnings and is categorised by the company as return of capital.")]
    ReturnOfCapital = DTCCPayoutTypeCode.ReturnOfCapital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// Encoded/decoded by serializers as "STCG".
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_0LieEZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as short-term capital gains.")]
    ShortTermCapitalGains = DTCCPayoutTypeCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payout consisting of a tax credit.
    /// Encoded/decoded by serializers as "TXCR".
    /// </summary>
    [EnumMember(Value = "TXCR")]
    [IsoId("_2l0IEZCMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of a tax credit.")]
    TaxCredit = DTCCPayoutTypeCode.TaxCredit, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCCPayoutType5CodeMetadataExtensions
{
    private static readonly DTCCPayoutType5CodeDropdownSource _dropdownSource = new DTCCPayoutType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCCPayoutType5CodeDropdownRow GetMetadata(this DTCCPayoutType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


