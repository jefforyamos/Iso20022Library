﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm11Code.  ISO2002 ID# _x-PlMWi4EeS87LmvcA55sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x-PlMWi4EeS87LmvcA55sg")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm11Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA256".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yLO4UWi4EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA256,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA384".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yLO4U2i4EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA384,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA512".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yLO4VWi4EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA512,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_I6AWUWi5EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA1,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm11CodeMetadataExtensions
{
    private static readonly Algorithm11CodeDropdownSource _dropdownSource = new Algorithm11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm11CodeDropdownRow GetMetadata(this Algorithm11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


