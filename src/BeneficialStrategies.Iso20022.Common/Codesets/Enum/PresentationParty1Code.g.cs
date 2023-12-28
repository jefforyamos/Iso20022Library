﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PresentationParty1Code.  ISO2002 ID# _RvL0sHyeEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the party to receive the presentation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RvL0sHyeEeGWJuGCfvwOsQ")]
[Description(@"Specifies the party to receive the presentation.")]
[DerivedFrom(typeof(PresentationPartyCode))]
public enum PresentationParty1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssuerOrOtherNominatatedParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cu64tnyeEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    IssuerOrOtherNominatatedParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExclusiveConfirmer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c1xupnyeEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    ExclusiveConfirmer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExclusiveIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c-toNnyeEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    ExclusiveIssuer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PresentationParty1CodeMetadataExtensions
{
    private static readonly PresentationParty1CodeDropdownSource _dropdownSource = new PresentationParty1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPresentationParty1CodeDropdownRow GetMetadata(this PresentationParty1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

