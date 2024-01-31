﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InformationDistribution2Code.  ISO2002 ID# _zDak0CCUEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how information is to be distributed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zDak0CCUEeWJd9HF2tO7BA")]
[Description(@"Specifies how information is to be distributed.")]
[DerivedFrom(typeof(InformationDistributionCode))]
public enum InformationDistribution2Code
{
    /// <summary>
    /// Electronic distribution.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_18fqwSCUEeWJd9HF2tO7BA")]
    [Description(@"Electronic distribution.")]
    Electronic = InformationDistributionCode.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No distribution.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_2C5NsSCUEeWJd9HF2tO7BA")]
    [Description(@"No distribution.")]
    NoDistribution = InformationDistributionCode.NoDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Paper distribution.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_2Hpx4SCUEeWJd9HF2tO7BA")]
    [Description(@"Paper distribution.")]
    Paper = InformationDistributionCode.Paper, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InformationDistribution2CodeMetadataExtensions
{
    private static readonly InformationDistribution2CodeDropdownSource _dropdownSource = new InformationDistribution2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInformationDistribution2CodeDropdownRow GetMetadata(this InformationDistribution2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


