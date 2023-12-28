﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Priority4Code.  ISO2002 ID# _jc3ekMmJEeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jc3ekMmJEeWAGphE2LvqeA")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Normal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nOxC4cmJEeWAGphE2LvqeA")]
    [Description(@"??")]
    Normal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Urgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nbaXwsmJEeWAGphE2LvqeA")]
    [Description(@"??")]
    Urgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Priority4CodeMetadataExtensions
{
    private static readonly Priority4CodeDropdownSource _dropdownSource = new Priority4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriority4CodeDropdownRow GetMetadata(this Priority4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


