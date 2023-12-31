﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalNarrativeTypeCode.  ISO2002 ID# _-MYPEW7iEeKo25nLKvGr8w_931495915.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPEW7iEeKo25nLKvGr8w_931495915")]
[Description(@"Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalNarrativeType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalNarrativeTypeCode
{
    /// <summary>
    /// Narrative text describing the additional terms and conditions.
    /// Encoded/decoded by serializers as "ADDI".
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_uPvII_RYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the additional terms and conditions.")]
    AdditionalTermsAndConditions,
    
    /// <summary>
    /// Narrative text describing the charge details.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_uPvIJvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the charge details.")]
    ChargeDetails,
    
    /// <summary>
    /// Narrative text describing the drawing details.
    /// Encoded/decoded by serializers as "DRAW".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_uP4SEPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the drawing details.")]
    DrawingDetails,
    
    /// <summary>
    /// Narrative text describing the assignment of proceeds terms and conditions.
    /// Encoded/decoded by serializers as "PRAS".
    /// </summary>
    [EnumMember(Value = "PRAS")]
    [IsoId("_uP4SE_RYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the assignment of proceeds terms and conditions.")]
    ProceedsAssignable,
    
    /// <summary>
    /// Narrative text describing the terms of effectiveness.
    /// Encoded/decoded by serializers as "TEFF".
    /// </summary>
    [EnumMember(Value = "TEFF")]
    [IsoId("_uP4SFvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of effectiveness.")]
    TermsOfEffectiveness,
    
    /// <summary>
    /// Narrative text describing the transfer terms and conditions.
    /// Encoded/decoded by serializers as "TRNF".
    /// </summary>
    [EnumMember(Value = "TRNF")]
    [IsoId("_uP4SGfRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the transfer terms and conditions.")]
    Transfer,
    
    /// <summary>
    /// Narrative text describing the terms of variation.
    /// Encoded/decoded by serializers as "TVAR".
    /// </summary>
    [EnumMember(Value = "TVAR")]
    [IsoId("_uP4SHPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of variation.")]
    TermsOfVariation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalNarrativeTypeCodeMetadataExtensions
{
    private static readonly ExternalNarrativeTypeCodeDropdownSource _dropdownSource = new ExternalNarrativeTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalNarrativeTypeCodeDropdownRow GetMetadata(this ExternalNarrativeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


