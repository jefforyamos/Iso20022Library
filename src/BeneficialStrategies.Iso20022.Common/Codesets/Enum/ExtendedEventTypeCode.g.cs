﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExtendedEventTypeCode.  ISO2002 ID# _1mchFTL3EeKU9IrkkToqcw_1589826234.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mchFTL3EeKU9IrkkToqcw_1589826234")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
public enum ExtendedEventTypeCode
{
    /// <summary>
    /// Meeting of a company's share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_1mlrADL3EeKU9IrkkToqcw_588269517")]
    [Description(@"Meeting of a company's share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite.")]
    MEET,
    
    /// <summary>
    /// General information provided by the issuer that should not result in material changes to the security.
    /// </summary>
    [EnumMember(Value = "RPLA")]
    [IsoId("_1mlrATL3EeKU9IrkkToqcw_607228373")]
    [Description(@"General information provided by the issuer that should not result in material changes to the security.")]
    RPLA,
    
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_1mlrAjL3EeKU9IrkkToqcw_1138262364")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    TMTN,
    
    /// <summary>
    /// Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.
    /// </summary>
    [EnumMember(Value = "BRIS")]
    [IsoId("_1mlrAzL3EeKU9IrkkToqcw_2131083886")]
    [Description(@"Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.")]
    BRIS,
    
    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from "partial defeasance", "partial prerefunding" event types mapped to the same ISO event type code.
    /// </summary>
    [EnumMember(Value = "FLPR")]
    [IsoId("_1mlrBDL3EeKU9IrkkToqcw_1470985921")]
    [Description(@"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from ""partial defeasance"", ""partial prerefunding"" event types mapped to the same ISO event type code.")]
    FLPR,
    
    /// <summary>
    /// Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from "full prerefunding", "partial prerefunding" event types mapped to the same ISO event type code.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_1mlrBTL3EeKU9IrkkToqcw_256596043")]
    [Description(@"Issuer sets aside cash in escrow to pay off a portion of the issue before the maturity date. New securities are issued for the portion defeased. Distinguishes from ""full prerefunding"", ""partial prerefunding"" event types mapped to the same ISO event type code.")]
    PDEF,
    
    /// <summary>
    /// Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from "full prerefunding", "partial defeasance" event types mapped to the same ISO event type code.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_1mlrBjL3EeKU9IrkkToqcw_-135348525")]
    [Description(@"Similar to a Full Prerefunding, a partial prerefunding is the exercise of a privilege by the issuer to repay, in part, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. New securities are issued for the portion prerefunded. Distinguishes from ""full prerefunding"", ""partial defeasance"" event types mapped to the same ISO event type code.")]
    PPRE,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExtendedEventTypeCodeMetadataExtensions
{
    private static readonly ExtendedEventTypeCodeDropdownSource _dropdownSource = new ExtendedEventTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExtendedEventTypeCodeDropdownRow GetMetadata(this ExtendedEventTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


