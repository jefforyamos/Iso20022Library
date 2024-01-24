﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResidenceType1Code.  ISO2002 ID# _JX1ngGjNEeiRg5NzP0jkQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JX1ngGjNEeiRg5NzP0jkQg")]
[Description(@"Specifies the type of residence where the party has its permanent home or principal establishment.")]
[DerivedFrom(typeof(ResidenceTypeCode))]
public enum ResidenceType1Code
{
    /// <summary>
    /// Residence is domestic.
    /// Encoded/decoded by serializers as "DMST".
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_LFI20WjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is domestic.")]
    Domestic = ResidenceTypeCode.Domestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Residence is foreign.
    /// Encoded/decoded by serializers as "FRGN".
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_LOpYIWjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is foreign.")]
    Foreign = ResidenceTypeCode.Foreign, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Residence is mixed
    /// Encoded/decoded by serializers as "MXED".
    /// </summary>
    [EnumMember(Value = "MXED")]
    [IsoId("_LYfQoWjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is mixed")]
    Mixed = ResidenceTypeCode.Mixed, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResidenceType1CodeMetadataExtensions
{
    private static readonly ResidenceType1CodeDropdownSource _dropdownSource = new ResidenceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResidenceType1CodeDropdownRow GetMetadata(this ResidenceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


