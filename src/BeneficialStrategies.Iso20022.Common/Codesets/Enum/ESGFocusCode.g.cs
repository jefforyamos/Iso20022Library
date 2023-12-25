﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ESGFocusCode.  ISO2002 ID# _tYWj0M2uEeuAE-cYsQdwHQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if focus will be Environmental, Social or Governance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tYWj0M2uEeuAE-cYsQdwHQ")]
[Description(@"Specifies if focus will be Environmental, Social or Governance.")]
public enum ESGFocusCode
{
    /// <summary>
    /// Main focus will be environmental.
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_3oVl4M2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be environmental.")]
    ENVR,
    
    /// <summary>
    /// Main focus will be social.
    /// </summary>
    [EnumMember(Value = "SOCL")]
    [IsoId("_7WLJkM2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be social.")]
    SOCL,
    
    /// <summary>
    /// Main focus will be governance.
    /// </summary>
    [EnumMember(Value = "GOVR")]
    [IsoId("_-n9DYM2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be governance.")]
    GOVR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ESGFocusCodeMetadataExtensions
{
    private static readonly ESGFocusCodeDropdownSource _dropdownSource = new ESGFocusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IESGFocusCodeDropdownRow GetMetadata(this ESGFocusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


