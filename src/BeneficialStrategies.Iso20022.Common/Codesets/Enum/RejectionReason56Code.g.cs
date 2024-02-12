﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason56Code.  ISO2002 ID# _ReBJIe6BEeqc-LCjwLsUVg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ReBJIe6BEeqc-LCjwLsUVg")]
[Description(@"Specifies the reason why the instruction request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason56Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_R3dj4e6BEeqc-LCjwLsUVg")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_R3dj4-6BEeqc-LCjwLsUVg")]
    [Description(@"Instruction is rejected since the provided certification is incorrect or incomplete.")]
    IncorrectCertification = RejectionReasonV3Code.IncorrectCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_R3dj5e6BEeqc-LCjwLsUVg")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV3Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "OPTY".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_R3dj5-6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_R3dj6e6BEeqc-LCjwLsUVg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_R3dj6-6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_R3dj7e6BEeqc-LCjwLsUVg")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_R3dj7-6BEeqc-LCjwLsUVg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "NMTY".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_R3dj8e6BEeqc-LCjwLsUVg")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV3Code.Mismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_R3dj8-6BEeqc-LCjwLsUVg")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_R3dj9e6BEeqc-LCjwLsUVg")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled = RejectionReasonV3Code.OptionCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "INTV".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_R3dj9-6BEeqc-LCjwLsUVg")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive = RejectionReasonV3Code.OptionInactive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OPNM".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_R3dj-e6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV3Code.OptionNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_R3dj--6BEeqc-LCjwLsUVg")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_R3dj_e6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "REFT".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_R3dj_-6BEeqc-LCjwLsUVg")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV3Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_R3dkAe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_R3dkA-6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as "DQCS".
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_R3dkBe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection = RejectionReasonV3Code.AmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as "DQCC".
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("_R3dkB-6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection = RejectionReasonV3Code.CurrencyRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.
    /// Encoded/decoded by serializers as "DQAM".
    /// </summary>
    [EnumMember(Value = "DQAM")]
    [IsoId("_R3dkCe6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.")]
    InstructionTypeRejection = RejectionReasonV3Code.InstructionTypeRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected due to invalid use of the additional round up quantity.
    /// Encoded/decoded by serializers as "IRDQ".
    /// </summary>
    [EnumMember(Value = "IRDQ")]
    [IsoId("_R3dkC-6BEeqc-LCjwLsUVg")]
    [Description(@"Instruction is rejected due to invalid use of the additional round up quantity.")]
    InvalidUseRoundUpQuantity = RejectionReasonV3Code.InvalidUseRoundUpQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "DQBV".
    /// </summary>
    [EnumMember(Value = "DQBV")]
    [IsoId("_R3dkDe6BEeqc-LCjwLsUVg")]
    [Description(@"Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidValue = RejectionReasonV3Code.InvalidBidValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as "DQBI".
    /// </summary>
    [EnumMember(Value = "DQBI")]
    [IsoId("_R3dkD-6BEeqc-LCjwLsUVg")]
    [Description(@"Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).")]
    InvalidBidIncrement = RejectionReasonV3Code.InvalidBidIncrement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_R3dkEe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection = RejectionReasonV3Code.ShareholderNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as "ITAX".
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_R3dkE-6BEeqc-LCjwLsUVg")]
    [Description(@"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.")]
    IncorrectTaxRate = RejectionReasonV3Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as "NTAX".
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_R3dkFe6BEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = RejectionReasonV3Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as "MTAX".
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_R3dkF-6BEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = RejectionReasonV3Code.MissingTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid use of solicitation dealer fee indicator.
    /// Encoded/decoded by serializers as "ISOL".
    /// </summary>
    [EnumMember(Value = "ISOL")]
    [IsoId("_V2wD8e6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid use of solicitation dealer fee indicator.")]
    InvalidSolicitationDealerFeeUse = RejectionReasonV3Code.InvalidSolicitationDealerFeeUse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as "BSTR".
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("_gKYdoe6GEeqc-LCjwLsUVg")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = RejectionReasonV3Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact information is missing.
    /// Encoded/decoded by serializers as "CTCT".
    /// </summary>
    [EnumMember(Value = "CTCT")]
    [IsoId("_mgYWYe6GEeqc-LCjwLsUVg")]
    [Description(@"Contact information is missing.")]
    MissingContact = RejectionReasonV3Code.MissingContact, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as "DUPL".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_sCxA4e6GEeqc-LCjwLsUVg")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is required for cover protect instructions.
    /// Encoded/decoded by serializers as "PROI".
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_xfyDMe6GEeqc-LCjwLsUVg")]
    [Description(@"Protect identification is required for cover protect instructions.")]
    MissingProtectIdentification = RejectionReasonV3Code.MissingProtectIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No protect privilege for this event.
    /// Encoded/decoded by serializers as "PRON".
    /// </summary>
    [EnumMember(Value = "PRON")]
    [IsoId("_y-jHQe6GEeqc-LCjwLsUVg")]
    [Description(@"No protect privilege for this event.")]
    NoProtectPrivilege = RejectionReasonV3Code.NoProtectPrivilege, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date is required for cover protect instructions.
    /// Encoded/decoded by serializers as "PROT".
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_1C9PAe6GEeqc-LCjwLsUVg")]
    [Description(@"Protect date is required for cover protect instructions.")]
    MissingProtectDate = RejectionReasonV3Code.MissingProtectDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type is missing or invalid for protect or cover protect instructions.
    /// Encoded/decoded by serializers as "TRTI".
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_4LqFUe6GEeqc-LCjwLsUVg")]
    [Description(@"Transaction type is missing or invalid for protect or cover protect instructions.")]
    MissingTransactionType = RejectionReasonV3Code.MissingTransactionType, // same ordinal as derivation source for type conversions
    
}
