﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleSpecifiedAddress1Code.  ISO2002 ID# _2SRssiBpEeugLNJneiyzbA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the confirmation for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2SRssiBpEeugLNJneiyzbA")]
[Description(@"Specifies the confirmation for the cross-element validation rules.  Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleSpecifiedAddress1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpecifiedAddress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_D9RdESBqEeugLNJneiyzbA")]
    [Description(@"??")]
    SpecifiedAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleSpecifiedAddress1CodeMetadataExtensions
{
    private static readonly ValidationRuleSpecifiedAddress1CodeDropdownSource _dropdownSource = new ValidationRuleSpecifiedAddress1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleSpecifiedAddress1CodeDropdownRow GetMetadata(this ValidationRuleSpecifiedAddress1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

