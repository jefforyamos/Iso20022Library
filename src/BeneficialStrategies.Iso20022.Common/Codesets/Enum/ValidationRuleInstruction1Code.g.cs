﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleInstruction1Code.  ISO2002 ID# _cCdYNCAZEeuxStysDTgLiw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cCdYNCAZEeuxStysDTgLiw")]
[Description(@"Specifies the instruction for the cross-element validation rules.  Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleInstruction1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HoldCashForCreditor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sgJgYSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    HoldCashForCreditor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhoneBeneficiary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sgJgYyAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    PhoneBeneficiary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Telecom".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sgJgZSAeEeuSiN6KdHu9iw")]
    [Description(@"??")]
    Telecom,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleInstruction1CodeMetadataExtensions
{
    private static readonly ValidationRuleInstruction1CodeDropdownSource _dropdownSource = new ValidationRuleInstruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleInstruction1CodeDropdownRow GetMetadata(this ValidationRuleInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


