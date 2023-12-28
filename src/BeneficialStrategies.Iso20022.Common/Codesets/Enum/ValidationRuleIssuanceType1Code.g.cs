﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleIssuanceType1Code.  ISO2002 ID# _rW7kBCBqEeugLNJneiyzbA.
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
[IsoId("_rW7kBCBqEeugLNJneiyzbA")]
[Description(@"Specifies the instruction for the cross-element validation rules.  Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleIssuanceType1Code
{
    /// <summary>
    /// Undertaking issued direct.
    /// Encoded/decoded by serializers as "UndertakingIssuedDirect".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ykFHMSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued direct.")]
    UndertakingIssuedDirect,
    
    /// <summary>
    /// Undertaking issued via confirming party.
    /// Encoded/decoded by serializers as "UndertakingIssuedViaConfirmingParty".
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_yxUR8SBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via confirming party.")]
    UndertakingIssuedViaConfirmingParty,
    
    /// <summary>
    /// Undertaking issued via advising party.
    /// Encoded/decoded by serializers as "UndertakingViaAdvisingParty".
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_y3r_sSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via advising party.")]
    UndertakingViaAdvisingParty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleIssuanceType1CodeMetadataExtensions
{
    private static readonly ValidationRuleIssuanceType1CodeDropdownSource _dropdownSource = new ValidationRuleIssuanceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleIssuanceType1CodeDropdownRow GetMetadata(this ValidationRuleIssuanceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


