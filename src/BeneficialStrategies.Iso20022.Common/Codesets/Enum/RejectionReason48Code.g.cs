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
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_J-XHkbXSEeiTob_PrFFUxA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as "IncorrectCertification".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_J-XHk7XSEeiTob_PrFFUxA")]
    [Description(@"Instruction is rejected since the provided certification is incorrect or incomplete.")]
    IncorrectCertification,
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "InvalidForTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_J-XHlbXSEeiTob_PrFFUxA")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_J-XHl7XSEeiTob_PrFFUxA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_J-XHmbXSEeiTob_PrFFUxA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_J-XHm7XSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_J-XHnbXSEeiTob_PrFFUxA")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_J-XHn7XSEeiTob_PrFFUxA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "Mismatch".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_J-XHobXSEeiTob_PrFFUxA")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "MissingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_J-XHo7XSEeiTob_PrFFUxA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "OptionCancelled".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_J-XHpbXSEeiTob_PrFFUxA")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled,
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "OptionInactive".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_J-XHp7XSEeiTob_PrFFUxA")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive,
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OptionNumberRejection".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_J-XHqbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_J-XHq7XSEeiTob_PrFFUxA")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_J-XHrbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "RefusedByTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_J-XHr7XSEeiTob_PrFFUxA")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_J-XHsbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_J-XHs7XSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as "AmountRejection".
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_J-XHtbXSEeiTob_PrFFUxA")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection,
    
    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as "CurrencyRejection".
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("_J-XHt7XSEeiTob_PrFFUxA")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection,
    
    /// <summary>
    /// Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.
    /// Encoded/decoded by serializers as "InstructionTypeRejection".
    /// </summary>
    [EnumMember(Value = "DQAM")]
    [IsoId("_J-XHubXSEeiTob_PrFFUxA")]
    [Description(@"Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.")]
    InstructionTypeRejection,
    
    /// <summary>
    /// Instruction is rejected due to invalid use of the additional round up quantity.
    /// Encoded/decoded by serializers as "InvalidUseRoundUpQuantity".
    /// </summary>
    [EnumMember(Value = "IRDQ")]
    [IsoId("_jcWIYbXTEeiTob_PrFFUxA")]
    [Description(@"Instruction is rejected due to invalid use of the additional round up quantity.")]
    InvalidUseRoundUpQuantity,
    
    /// <summary>
    /// Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "InvalidBidValue".
    /// </summary>
    [EnumMember(Value = "DQBV")]
    [IsoId("_jqB_EbXTEeiTob_PrFFUxA")]
    [Description(@"Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidValue,
    
    /// <summary>
    /// Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "InvalidBidIncrement".
    /// </summary>
    [EnumMember(Value = "DQBI")]
    [IsoId("_j2hi8bXTEeiTob_PrFFUxA")]
    [Description(@"Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidIncrement,
    
    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as "ShareholderNumberRejection".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_lXxLUby6EeilsanBGAzy4A")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection,
    
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


