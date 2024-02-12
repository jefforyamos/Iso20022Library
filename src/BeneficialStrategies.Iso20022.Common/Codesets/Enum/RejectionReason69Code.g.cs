﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason69Code.  ISO2002 ID# _K_rZwCtUEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K_rZwCtUEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason69Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_F9JsQStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_F9JsQytaEeyF-PUIGuhxvA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_F9JsRStaEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_F9JsRytaEeyF-PUIGuhxvA")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV3Code.CorporateActionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_F9JsSStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV3Code.SettlementDateRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_F9JsSytaEeyF-PUIGuhxvA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_F9JsTStaEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_F9JsTytaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_F9JsUStaEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as "INVB".
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_F9JsUytaEeyF-PUIGuhxvA")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance = RejectionReasonV3Code.InvalidBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "INVL".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_F9JsVStaEeyF-PUIGuhxvA")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV3Code.InvalidLink, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as "INVN".
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("_F9JsVytaEeyF-PUIGuhxvA")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber = RejectionReasonV3Code.InvalidLotNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_F9JsWStaEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RejectionReasonV3Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_F9JsWytaEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RejectionReasonV3Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as "VALR".
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_F9JsXStaEeyF-PUIGuhxvA")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule = RejectionReasonV3Code.InvalidRule, // same ordinal as derivation source for type conversions
    
}
