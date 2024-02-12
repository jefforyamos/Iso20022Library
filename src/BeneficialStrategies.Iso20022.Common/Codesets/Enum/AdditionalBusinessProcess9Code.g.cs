﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcess9Code.  ISO2002 ID# _WX4ycReoEeyroI8qKgB7Mg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "ACLA".
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_WtfPAReoEeyroI8qKgB7Mg")]
    [Description(@"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).")]
    AutomaticMarketClaim = AdditionalBusinessProcessCode.AutomaticMarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as "ATXF".
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_WtfPAxeoEeyroI8qKgB7Mg")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).")]
    SubjectToTransformation = AdditionalBusinessProcessCode.SubjectToTransformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_WtfPBReoEeyroI8qKgB7Mg")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.")]
    CancelUnderlyingTrades = AdditionalBusinessProcessCode.CancelUnderlyingTrades, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NAMC".
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_WtfPBxeoEeyroI8qKgB7Mg")]
    [Description(@"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).")]
    NoAutomaticMarketClaimsAndTransformations = AdditionalBusinessProcessCode.NoAutomaticMarketClaimsAndTransformations, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as "NPLE".
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_WtfPCReoEeyroI8qKgB7Mg")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as "SCHM".
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_WtfPCxeoEeyroI8qKgB7Mg")]
    [Description(@"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.")]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as "CONS".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_WtfPDReoEeyroI8qKgB7Mg")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).")]
    Consent = AdditionalBusinessProcessCode.Consent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as "PPUT".
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_WtfPDxeoEeyroI8qKgB7Mg")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.")]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "FPRE".
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_WtfPEReoEeyroI8qKgB7Mg")]
    [Description(@"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.")]
    FullPrefunding = AdditionalBusinessProcessCode.FullPrefunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "PPRE".
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_WtfPExeoEeyroI8qKgB7Mg")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.")]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as "REAC".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_WtfPFReoEeyroI8qKgB7Mg")]
    [Description(@"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.")]
    RequiredAction = AdditionalBusinessProcessCode.RequiredAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as "INCP".
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_aNwQwReoEeyroI8qKgB7Mg")]
    [Description(@"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.")]
    IncentivePremiumPayment = AdditionalBusinessProcessCode.IncentivePremiumPayment, // same ordinal as derivation source for type conversions
    
}
