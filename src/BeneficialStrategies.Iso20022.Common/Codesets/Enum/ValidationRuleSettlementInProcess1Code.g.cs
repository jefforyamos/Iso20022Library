﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleSettlementInProcess1Code.  ISO2002 ID# _4kxdQiE5EeuIZ4Hf6difAw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the settlement in process status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4kxdQiE5EeuIZ4Hf6difAw")]
[Description(@"Specifies the settlement in process status code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleSettlementInProcess1Code
{
    /// <summary>
    /// Accepted settlement in process.
    /// Encoded/decoded by serializers as "ACSP".
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_C55eASE6EeuIZ4Hf6difAw")]
    [Description(@"Accepted settlement in process.")]
    AcceptedSettlementInProcess = ValidationRuleCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
}
