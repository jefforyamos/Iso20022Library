﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Eligible1Code.  ISO2002 ID# _unGN4CC9EeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is eligible or not eligible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_unGN4CC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is eligible or not eligible.")]
[DerivedFrom(typeof(EligibleCode))]
public enum Eligible1Code
{
    /// <summary>
    /// Item is eligible.
    /// Encoded/decoded by serializers as "ELIG".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_RBY30SC-EeWPMvNwVtiMsA")]
    [Description(@"Item is eligible.")]
    Eligible = EligibleCode.Eligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Item is not eligible.
    /// Encoded/decoded by serializers as "NELI".
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_RIY3sSC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not eligible.")]
    NotEligible = EligibleCode.NotEligible, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Eligible1CodeMetadataExtensions
{
    private static readonly Eligible1CodeDropdownSource _dropdownSource = new Eligible1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEligible1CodeDropdownRow GetMetadata(this Eligible1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


