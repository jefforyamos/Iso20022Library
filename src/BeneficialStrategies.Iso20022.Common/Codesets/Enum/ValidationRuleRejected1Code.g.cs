﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleRejected1Code.  ISO2002 ID# _S3XK8B-zEeuxStysDTgLiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rejected status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S3XK8B-zEeuxStysDTgLiw")]
[Description(@"Specifies the rejected status code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleRejected1Code
{
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uY6bcR-zEeuxStysDTgLiw")]
    [Description(@"Rejected.")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleRejected1CodeMetadataExtensions
{
    private static readonly ValidationRuleRejected1CodeDropdownSource _dropdownSource = new ValidationRuleRejected1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleRejected1CodeDropdownRow GetMetadata(this ValidationRuleRejected1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


