﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TR34CommandCode.  ISO2002 ID# _hWYrAF2iEeekzJIz1JxYSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specific TR34 command that the ATM could perform.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hWYrAF2iEeekzJIz1JxYSQ")]
[Description(@"Specific TR34 command that the ATM could perform.")]
public enum TR34CommandCode
{
    /// <summary>
    /// TR34 bind operation.
    /// Encoded/decoded by serializers as "BIND".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_0VRW4F2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 bind operation.")]
    Bind,
    
    /// <summary>
    /// TR34 unbind operation.
    /// Encoded/decoded by serializers as "UBND".
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_3d7J4F2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 unbind operation.")]
    Unbind,
    
    /// <summary>
    /// TR34 rebind operation.
    /// Encoded/decoded by serializers as "RBND".
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_6ZOdYF2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 rebind operation.")]
    Rebind,
    
    /// <summary>
    /// TR34 Higher Level unbind operation.
    /// Encoded/decoded by serializers as "HILU".
    /// </summary>
    [EnumMember(Value = "HILU")]
    [IsoId("_9VGYoF2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level unbind operation.")]
    HigherLevelUnbind,
    
    /// <summary>
    /// TR34 Higher Level rebind operation.
    /// Encoded/decoded by serializers as "HILR".
    /// </summary>
    [EnumMember(Value = "HILR")]
    [IsoId("_B_ymIF2jEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level rebind operation.")]
    HigherLevelRebind,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TR34CommandCodeMetadataExtensions
{
    private static readonly TR34CommandCodeDropdownSource _dropdownSource = new TR34CommandCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITR34CommandCodeDropdownRow GetMetadata(this TR34CommandCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

