﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PresentationMediumCode.  ISO2002 ID# _oH14wHyeEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the presentation medium.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oH14wHyeEeGWJuGCfvwOsQ")]
[Description(@"Specifies the presentation medium.")]
[Derivations(typeof(PresentationMedium1Code),typeof(PresentationMedium2Code))]
public enum PresentationMediumCode
{
    /// <summary>
    /// Presentation is made on paper.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_FoZMkHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper.")]
    Paper,
    
    /// <summary>
    /// Presentation is made electronically.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_M637sHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made electronically.")]
    Electronic,
    
    /// <summary>
    /// Presentation is made on paper and/or electronically.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_TXGYQHyfEeGWJuGCfvwOsQ")]
    [Description(@"Presentation is made on paper and/or electronically.")]
    PaperElectronic,
    
    /// <summary>
    /// Biometric medium.
    /// Encoded/decoded by serializers as "BIOM".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_NnSYYXyLEemHsOqJOzMVfg")]
    [Description(@"Biometric medium.")]
    Biometric,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PresentationMediumCodeMetadataExtensions
{
    private static readonly PresentationMediumCodeDropdownSource _dropdownSource = new PresentationMediumCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPresentationMediumCodeDropdownRow GetMetadata(this PresentationMediumCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


