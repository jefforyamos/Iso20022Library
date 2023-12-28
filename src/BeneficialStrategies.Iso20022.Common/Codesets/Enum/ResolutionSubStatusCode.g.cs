﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResolutionSubStatusCode.  ISO2002 ID# _vmscgDUGEe2tRf29bleifQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the sub-status of a resolution.  
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vmscgDUGEe2tRf29bleifQ")]
[Description(@"Specifies the sub-status of a resolution.  ")]
[Derivations(typeof(ResolutionSubStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ResolutionSubStatusCode
{
    /// <summary>
    /// Resolution voted at the meeting is new. 
    /// Encoded/decoded by serializers as "NEWR".
    /// </summary>
    [EnumMember(Value = "NEWR")]
    [IsoId("_6ZWt0DUGEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting is new. ")]
    NewResolution,
    
    /// <summary>
    /// Resolution voted at the meeting was amended.
    /// Encoded/decoded by serializers as "AMDR".
    /// </summary>
    [EnumMember(Value = "AMDR")]
    [IsoId("_EIrS0DUHEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting was amended.")]
    AmendedResolution,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResolutionSubStatusCodeMetadataExtensions
{
    private static readonly ResolutionSubStatusCodeDropdownSource _dropdownSource = new ResolutionSubStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResolutionSubStatusCodeDropdownRow GetMetadata(this ResolutionSubStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


