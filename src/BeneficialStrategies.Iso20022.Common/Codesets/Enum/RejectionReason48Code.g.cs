﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason48Code.  ISO2002 ID# _JsWxkbXSEeiTob_PrFFUxA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JsWxkbXSEeiTob_PrFFUxA")]
[Description(@"Specifies the reason why the instruction request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason48Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_J-XHkbXSEeiTob_PrFFUxA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_J-XHk7XSEeiTob_PrFFUxA")]
    [Description(@"Instruction is rejected since the provided certification is incorrect or incomplete.")]
    IncorrectCertification = RejectionReasonV3Code.IncorrectCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_J-XHlbXSEeiTob_PrFFUxA")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV3Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "OPTY".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_J-XHl7XSEeiTob_PrFFUxA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_J-XHmbXSEeiTob_PrFFUxA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_J-XHm7XSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_J-XHnbXSEeiTob_PrFFUxA")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_J-XHn7XSEeiTob_PrFFUxA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "NMTY".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_J-XHobXSEeiTob_PrFFUxA")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV3Code.Mismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_J-XHo7XSEeiTob_PrFFUxA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_J-XHpbXSEeiTob_PrFFUxA")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled = RejectionReasonV3Code.OptionCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "INTV".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_J-XHp7XSEeiTob_PrFFUxA")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive = RejectionReasonV3Code.OptionInactive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OPNM".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_J-XHqbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV3Code.OptionNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_J-XHq7XSEeiTob_PrFFUxA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_J-XHrbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "REFT".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_J-XHr7XSEeiTob_PrFFUxA")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV3Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_J-XHsbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_J-XHs7XSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as "DQCS".
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_J-XHtbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection = RejectionReasonV3Code.AmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as "DQCC".
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("_J-XHt7XSEeiTob_PrFFUxA")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection = RejectionReasonV3Code.CurrencyRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.
    /// Encoded/decoded by serializers as "DQAM".
    /// </summary>
    [EnumMember(Value = "DQAM")]
    [IsoId("_J-XHubXSEeiTob_PrFFUxA")]
    [Description(@"Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.")]
    InstructionTypeRejection = RejectionReasonV3Code.InstructionTypeRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected due to invalid use of the additional round up quantity.
    /// Encoded/decoded by serializers as "IRDQ".
    /// </summary>
    [EnumMember(Value = "IRDQ")]
    [IsoId("_jcWIYbXTEeiTob_PrFFUxA")]
    [Description(@"Instruction is rejected due to invalid use of the additional round up quantity.")]
    InvalidUseRoundUpQuantity = RejectionReasonV3Code.InvalidUseRoundUpQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "DQBV".
    /// </summary>
    [EnumMember(Value = "DQBV")]
    [IsoId("_jqB_EbXTEeiTob_PrFFUxA")]
    [Description(@"Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidValue = RejectionReasonV3Code.InvalidBidValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "DQBI".
    /// </summary>
    [EnumMember(Value = "DQBI")]
    [IsoId("_j2hi8bXTEeiTob_PrFFUxA")]
    [Description(@"Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidIncrement = RejectionReasonV3Code.InvalidBidIncrement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_lXxLUby6EeilsanBGAzy4A")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection = RejectionReasonV3Code.ShareholderNumberRejection, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason48CodeMetadataExtensions
{
    private static readonly RejectionReason48CodeDropdownSource _dropdownSource = new RejectionReason48CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason48CodeDropdownRow GetMetadata(this RejectionReason48Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


