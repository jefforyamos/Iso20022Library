﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IntendedOrActualCode.  ISO2002 ID# _lko5sDcjEeidBoT_PugKiA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if a charge or cost is intended (ex ante) or actual (post ante).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lko5sDcjEeidBoT_PugKiA")]
[Description(@"Specifies if a charge or cost is intended (ex ante) or actual (post ante).")]
public enum IntendedOrActualCode
{
    /// <summary>
    /// Ex ante (intended).
    /// Encoded/decoded by serializers as "ANTE".
    /// </summary>
    [EnumMember(Value = "ANTE")]
    [IsoId("_nCEhADcjEeidBoT_PugKiA")]
    [Description(@"Ex ante (intended).")]
    ExAnte,
    
    /// <summary>
    /// Ex post (actual).
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_tNzqgDcjEeidBoT_PugKiA")]
    [Description(@"Ex post (actual).")]
    ExPost,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IntendedOrActualCodeMetadataExtensions
{
    private static readonly IntendedOrActualCodeDropdownSource _dropdownSource = new IntendedOrActualCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIntendedOrActualCodeDropdownRow GetMetadata(this IntendedOrActualCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


