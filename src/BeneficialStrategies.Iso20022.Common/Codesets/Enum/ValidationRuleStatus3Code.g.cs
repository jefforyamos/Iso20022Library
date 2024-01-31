﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleStatus3Code.  ISO2002 ID# _RcJ6JyAUEeuxStysDTgLiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RcJ6JyAUEeuxStysDTgLiw")]
[Description(@"Specifies the status for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleStatus3Code
{
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as "RCVD".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_itZM4SAeEeuSiN6KdHu9iw")]
    [Description(@"Received.")]
    Received = ValidationRuleCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_K2H4QSE7EeuIZ4Hf6difAw")]
    [Description(@"Rejected.")]
    Rejected = ValidationRuleCode.Rejected, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleStatus3CodeMetadataExtensions
{
    private static readonly ValidationRuleStatus3CodeDropdownSource _dropdownSource = new ValidationRuleStatus3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleStatus3CodeDropdownRow GetMetadata(this ValidationRuleStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


