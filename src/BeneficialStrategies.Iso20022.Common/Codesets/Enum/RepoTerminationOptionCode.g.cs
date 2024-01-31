﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepoTerminationOptionCode.  ISO2002 ID# _tHaf4CyzEea35M2x2c9PXw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the termination option for a repurchase agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tHaf4CyzEea35M2x2c9PXw")]
[Description(@"Indicates the termination option for a repurchase agreement.")]
[Derivations(typeof(RepoTerminationOption1Code),typeof(RepoTerminationOption2Code))]
public enum RepoTerminationOptionCode
{
    /// <summary>
    /// Evergreen termination option.
    /// Encoded/decoded by serializers as "EGRN".
    /// </summary>
    [EnumMember(Value = "EGRN")]
    [IsoId("_4WluECyzEea35M2x2c9PXw")]
    [Description(@"Evergreen termination option.")]
    Evergreen,
    
    /// <summary>
    /// Extendable termination option.
    /// Encoded/decoded by serializers as "ETSB".
    /// </summary>
    [EnumMember(Value = "ETSB")]
    [IsoId("_4raukCyzEea35M2x2c9PXw")]
    [Description(@"Extendable termination option.")]
    Extendable,
    
    /// <summary>
    /// Evergreen and extendable termination option. 
    /// Encoded/decoded by serializers as "EGAE".
    /// </summary>
    [EnumMember(Value = "EGAE")]
    [IsoId("_5AF-ECyzEea35M2x2c9PXw")]
    [Description(@"Evergreen and extendable termination option. ")]
    EvergreenAndExtendable,
    
    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as "NOAP".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_vuqPINX_EeiqhpuDZKadPg")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepoTerminationOptionCodeMetadataExtensions
{
    private static readonly RepoTerminationOptionCodeDropdownSource _dropdownSource = new RepoTerminationOptionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepoTerminationOptionCodeDropdownRow GetMetadata(this RepoTerminationOptionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


