﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason17Code.  ISO2002 ID# _-bahwOBjEeiVRbNQx5-Vhg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the transaction or the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-bahwOBjEeiVRbNQx5-Vhg")]
[Description(@"Specifies the reason why the transaction or the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason17Code
{
    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Es9YUeBkEeiVRbNQx5-Vhg")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions
    
}
