﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleAnyBank1Code.  ISO2002 ID# _1SaLICBpEeugLNJneiyzbA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the confirmation for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1SaLICBpEeugLNJneiyzbA")]
[Description(@"Specifies the confirmation for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleAnyBank1Code
{
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as "ANYB".
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_GAUS4SBqEeugLNJneiyzbA")]
    [Description(@"Any bank.")]
    AnyBank = ValidationRuleCode.AnyBank, // same ordinal as derivation source for type conversions
    
}
