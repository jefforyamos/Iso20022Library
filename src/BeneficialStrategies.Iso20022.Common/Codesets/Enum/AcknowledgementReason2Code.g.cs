﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcknowledgementReason2Code.  ISO2002 ID# _bo8XGNp-Ed-ak6NoX_4Aeg_-1187951925.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bo8XGNp-Ed-ak6NoX_4Aeg_-1187951925")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason2Code
{
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpGIENp-Ed-ak6NoX_4Aeg_-1187951923")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = AcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.
    /// Encoded/decoded by serializers as "SMPG".
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_bpGIEdp-Ed-ak6NoX_4Aeg_-1187951894")]
    [Description(@"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.")]
    MarketPracticeRuleDiscrepency = AcknowledgementReasonCode.MarketPracticeRuleDiscrepency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_bpGIEtp-Ed-ak6NoX_4Aeg_-1187951864")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = AcknowledgementReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as "NSTP".
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_bpGIE9p-Ed-ak6NoX_4Aeg_-1187951863")]
    [Description(@"Instruction was not straight through processing and had to be processed manually.")]
    NotStraightThroughProcessing = AcknowledgementReasonCode.NotStraightThroughProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction registration is accepted but the registration is not in full, that is, not with voting rights.
    /// Encoded/decoded by serializers as "RQWV".
    /// </summary>
    [EnumMember(Value = "RQWV")]
    [IsoId("_bpGIFNp-Ed-ak6NoX_4Aeg_-1187951833")]
    [Description(@"Instruction registration is accepted but the registration is not in full, that is, not with voting rights.")]
    AcceptedWithoutVotingRights = AcknowledgementReasonCode.AcceptedWithoutVotingRights, // same ordinal as derivation source for type conversions
    
}
