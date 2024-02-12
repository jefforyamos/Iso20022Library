﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason8Code.  ISO2002 ID# _ZmG8pNp-Ed-ak6NoX_4Aeg_1306497191.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of an election amendment request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZmG8pNp-Ed-ak6NoX_4Aeg_1306497191")]
[Description(@"Specifies the reason of a rejection of an election amendment request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason8Code
{
    /// <summary>
    /// Amendment is not allowed.
    /// Encoded/decoded by serializers as "NAMD".
    /// </summary>
    [EnumMember(Value = "NAMD")]
    [IsoId("_ZmG8pdp-Ed-ak6NoX_4Aeg_792769687")]
    [Description(@"Amendment is not allowed.")]
    AmendmentNotAllowed = RejectionReasonCode.AmendmentNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as "LATT".
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_ZmG8ptp-Ed-ak6NoX_4Aeg_792769717")]
    [Description(@"Instruction/Request arrives too late.")]
    Late = RejectionReasonCode.Late, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The election advice is already cancelled.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZmQtoNp-Ed-ak6NoX_4Aeg_792769718")]
    [Description(@"The election advice is already cancelled.")]
    ElectionAlreadyCancelled = RejectionReasonCode.ElectionAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZmQtodp-Ed-ak6NoX_4Aeg_792769965")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
}
