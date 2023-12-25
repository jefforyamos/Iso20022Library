﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCPayoutTypeCode.  ISO2002 ID# _1o-QojL3EeKU9IrkkToqcw_-806320900.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1o-QojL3EeKU9IrkkToqcw_-806320900")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.")]
public enum DTCCPayoutTypeCode
{
    /// <summary>
    /// Payout consisting of cash.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_1o-QozL3EeKU9IrkkToqcw_-834385062")]
    [Description(@"Payout consisting of cash.")]
    CASH,
    
    /// <summary>
    /// Payout consisting of securities.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_1o-QpDL3EeKU9IrkkToqcw_702376988")]
    [Description(@"Payout consisting of securities.")]
    SECU,
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_1o-QpTL3EeKU9IrkkToqcw_-1870772597")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    DIVI,
    
    /// <summary>
    /// Distribution that doesn't represent earnings and is categorised by the company as return of capital.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_1o-QpjL3EeKU9IrkkToqcw_-359228468")]
    [Description(@"Distribution that doesn't represent earnings and is categorised by the company as return of capital.")]
    ROCA,
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_1pIBoDL3EeKU9IrkkToqcw_1506061219")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as short-term capital gains.")]
    STCG,
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_1pIBoTL3EeKU9IrkkToqcw_2040405331")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as long-term capital gains.")]
    LTCG,
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_1pIBojL3EeKU9IrkkToqcw_-1084357800")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as capital gains.")]
    CAPG,
    
    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_1pIBozL3EeKU9IrkkToqcw_-1747991352")]
    [Description(@"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.")]
    PREM,
    
    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_1pIBpDL3EeKU9IrkkToqcw_-343213628")]
    [Description(@"Cash payment on a debt instrument that represents a return of principal to the holder.")]
    PRPL,
    
    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_1pIBpTL3EeKU9IrkkToqcw_1108680864")]
    [Description(@"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.")]
    INTR,
    
    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. "Franked" means that a tax credit is attached to that part of the dividend.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_1pIBpjL3EeKU9IrkkToqcw_-779183644")]
    [Description(@"In some markets, companies further categorize dividends as franked or unfranked. ""Franked"" means that a tax credit is attached to that part of the dividend.")]
    FLFR,
    
    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. "Unfranked" means that there is no tax credit attached to the dividend.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_1pRyoDL3EeKU9IrkkToqcw_-1942490306")]
    [Description(@"In some markets, companies further categorize dividends as franked or unfranked. ""Unfranked"" means that there is no tax credit attached to the dividend.")]
    UNFR,
    
    /// <summary>
    /// Applies when a specific payout code cannot be used.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_1pRyoTL3EeKU9IrkkToqcw_86152619")]
    [Description(@"Applies when a specific payout code cannot be used.")]
    OTHR,
    
    /// <summary>
    /// Payout consisting of a tax credit.
    /// </summary>
    [EnumMember(Value = "TXCR")]
    [IsoId("_iGgLQJCMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of a tax credit.")]
    TXCR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCCPayoutTypeCodeMetadataExtensions
{
    private static readonly DTCCPayoutTypeCodeDropdownSource _dropdownSource = new DTCCPayoutTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCCPayoutTypeCodeDropdownRow GetMetadata(this DTCCPayoutTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


