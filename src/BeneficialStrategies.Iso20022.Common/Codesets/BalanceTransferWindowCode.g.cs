﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceTransferWindowCode.  ISO2002 ID# _vLUjgBE3EeafpqhYGpTDnw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing window in which the balance transfer will be processed on the switch date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vLUjgBE3EeafpqhYGpTDnw")]
[Description(@"Specifies the processing window in which the balance transfer will be processed on the switch date.")]
[Derivations(typeof(BalanceTransferWindow1Code))]
public enum BalanceTransferWindowCode
{
    /// <summary>
    /// Indicates out of business hours processing.
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_zy5yoBE3EeafpqhYGpTDnw")]
    [Description(@"Indicates out of business hours processing.")]
    OutOfHours,
    
    /// <summary>
    /// Indicates in business hours processing.
    /// Encoded/decoded by serializers as &quot;DAYH&quot;.
    /// </summary>
    [EnumMember(Value = "DAYH")]
    [IsoId("_1rMJ8BE3EeafpqhYGpTDnw")]
    [Description(@"Indicates in business hours processing.")]
    InHours,
    
}
