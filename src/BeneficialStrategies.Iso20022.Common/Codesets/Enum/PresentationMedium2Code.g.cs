﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PresentationMedium2Code.  ISO2002 ID# _YcK2AFzGEeeDqe2giKl0eQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Presentation medium type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcK2AFzGEeeDqe2giKl0eQ")]
[Description(@"Presentation medium type.")]
[DerivedFrom(typeof(PresentationMediumCode))]
public enum PresentationMedium2Code
{
    /// <summary>
    /// Biometric medium.
    /// Encoded/decoded by serializers as "BIOM".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_NnVqMX0kEemfrNOe0zHQyg")]
    [Description(@"Biometric medium.")]
    Biometric = PresentationMediumCode.Biometric, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Presentation is made electronically.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_NnVqM30kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made electronically.")]
    Electronic = PresentationMediumCode.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Presentation is made on paper.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_NnVqNX0kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made on paper.")]
    Paper = PresentationMediumCode.Paper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Presentation is made on paper and/or electronically.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_NnVqN30kEemfrNOe0zHQyg")]
    [Description(@"Presentation is made on paper and/or electronically.")]
    PaperElectronic = PresentationMediumCode.PaperElectronic, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PresentationMedium2CodeMetadataExtensions
{
    private static readonly PresentationMedium2CodeDropdownSource _dropdownSource = new PresentationMedium2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPresentationMedium2CodeDropdownRow GetMetadata(this PresentationMedium2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


