﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRulePendingAndRejected1Code.  ISO2002 ID# _3o5AU06KEeuOHsgMPq_2jQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3o5AU06KEeuOHsgMPq_2jQ")]
[Description(@"Specifies the status for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRulePendingAndRejected1Code
{
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_3o5AVU6KEeuOHsgMPq_2jQ")]
    [Description(@"Rejected.")]
    Rejected = ValidationRuleCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_BRWvYU6LEeuOHsgMPq_2jQ")]
    [Description(@"Pending.")]
    Pending = ValidationRuleCode.Pending, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRulePendingAndRejected1CodeMetadataExtensions
{
    private static readonly ValidationRulePendingAndRejected1CodeDropdownSource _dropdownSource = new ValidationRulePendingAndRejected1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRulePendingAndRejected1CodeDropdownRow GetMetadata(this ValidationRulePendingAndRejected1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


