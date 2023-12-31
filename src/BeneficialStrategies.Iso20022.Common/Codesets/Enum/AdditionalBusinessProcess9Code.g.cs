﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcess9Code.  ISO2002 ID# _WX4ycReoEeyroI8qKgB7Mg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WX4ycReoEeyroI8qKgB7Mg")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess9Code
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "AutomaticMarketClaim".
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_WtfPAReoEeyroI8qKgB7Mg")]
    [Description(@"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).")]
    AutomaticMarketClaim,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as "SubjectToTransformation".
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_WtfPAxeoEeyroI8qKgB7Mg")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).")]
    SubjectToTransformation,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as "CancelUnderlyingTrades".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_WtfPBReoEeyroI8qKgB7Mg")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.")]
    CancelUnderlyingTrades,
    
    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NoAutomaticMarketClaimsAndTransformations".
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_WtfPBxeoEeyroI8qKgB7Mg")]
    [Description(@"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).")]
    NoAutomaticMarketClaimsAndTransformations,
    
    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as "NoSplitElection".
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_WtfPCReoEeyroI8qKgB7Mg")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection,
    
    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as "SchemeOrPlanOfArrangement".
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_WtfPCxeoEeyroI8qKgB7Mg")]
    [Description(@"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.")]
    SchemeOrPlanOfArrangement,
    
    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as "Consent".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_WtfPDReoEeyroI8qKgB7Mg")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).")]
    Consent,
    
    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as "PartialMandatoryPutRedemption".
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_WtfPDxeoEeyroI8qKgB7Mg")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.")]
    PartialMandatoryPutRedemption,
    
    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "FullPrefunding".
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_WtfPEReoEeyroI8qKgB7Mg")]
    [Description(@"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.")]
    FullPrefunding,
    
    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "PartialPreFunding".
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_WtfPExeoEeyroI8qKgB7Mg")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.")]
    PartialPreFunding,
    
    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as "RequiredAction".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_WtfPFReoEeyroI8qKgB7Mg")]
    [Description(@"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.")]
    RequiredAction,
    
    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as "IncentivePremiumPayment".
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_aNwQwReoEeyroI8qKgB7Mg")]
    [Description(@"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.")]
    IncentivePremiumPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalBusinessProcess9CodeMetadataExtensions
{
    private static readonly AdditionalBusinessProcess9CodeDropdownSource _dropdownSource = new AdditionalBusinessProcess9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalBusinessProcess9CodeDropdownRow GetMetadata(this AdditionalBusinessProcess9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


