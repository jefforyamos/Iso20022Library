﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcessCode.  ISO2002 ID# _bmaAc9p-Ed-ak6NoX_4Aeg_356428670.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event such as an automatic market claim.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmaAc9p-Ed-ak6NoX_4Aeg_356428670")]
[Description(@"Specifies the additional business process linked to a corporate action event such as an automatic market claim.")]
public enum AdditionalBusinessProcessCode
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "ACLA".
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_bmaAdNp-Ed-ak6NoX_4Aeg_680586071")]
    [Description(@"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).")]
    AutomaticMarketClaim,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as "ATXF".
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_bmaAddp-Ed-ak6NoX_4Aeg_1125721829")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).")]
    SubjectToTransformation,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_bmaAdtp-Ed-ak6NoX_4Aeg_1154351853")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.")]
    CancelUnderlyingTrades,
    
    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NAMC".
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_bmaAd9p-Ed-ak6NoX_4Aeg_1195909241")]
    [Description(@"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).")]
    NoAutomaticMarketClaimsAndTransformations,
    
    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as "NPLE".
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_bmjxcNp-Ed-ak6NoX_4Aeg_1242085325")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection,
    
    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as "SCHM".
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_bmjxcdp-Ed-ak6NoX_4Aeg_1522835843")]
    [Description(@"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.")]
    SchemeOrPlanOfArrangement,
    
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as "CLAI".
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_bmjxctp-Ed-ak6NoX_4Aeg_1302432019")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation,
    
    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as "TAXR".
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_bmjxc9p-Ed-ak6NoX_4Aeg_1331059271")]
    [Description(@"Relates to a tax refund from the authorities on the associated corporate action event.")]
    TaxRefund,
    
    /// <summary>
    /// Indicates a preadvice of movement reversal.
    /// Encoded/decoded by serializers as "REVR".
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_bmjxdNp-Ed-ak6NoX_4Aeg_-1970967591")]
    [Description(@"Indicates a preadvice of movement reversal.")]
    NotificationOfReversal,
    
    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as "CONS".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bmjxddp-Ed-ak6NoX_4Aeg_164070844")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).")]
    Consent,
    
    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as "PPUT".
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_mr8y8GH9EeWNUe-5HV3A_g")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.")]
    PartialMandatoryPutRedemption,
    
    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "FPRE".
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_PnyMYGIAEeWNUe-5HV3A_g")]
    [Description(@"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.")]
    FullPrefunding,
    
    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "PPRE".
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_Xynf0GIAEeWNUe-5HV3A_g")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.")]
    PartialPreFunding,
    
    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as "REAC".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_Ao5yAGKfEeWR9ZSfjmHwUA")]
    [Description(@"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.")]
    RequiredAction,
    
    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as "INCP".
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_Du5eEBeoEeyroI8qKgB7Mg")]
    [Description(@"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.")]
    IncentivePremiumPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalBusinessProcessCodeMetadataExtensions
{
    private static readonly AdditionalBusinessProcessCodeDropdownSource _dropdownSource = new AdditionalBusinessProcessCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalBusinessProcessCodeDropdownRow GetMetadata(this AdditionalBusinessProcessCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


