﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LifeCycleSupportCode.  ISO2002 ID# _0g248FJ3EeeHVODnW-1ONQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0g248FJ3EeeHVODnW-1ONQ")]
[Description(@"Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.")]
public enum LifeCycleSupportCode
{
    /// <summary>
    /// Assigned at authorisation time.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_88m9QFJ3EeeHVODnW-1ONQ")]
    [Description(@"Assigned at authorisation time.")]
    AUTH,
    
    /// <summary>
    /// Assigned at financial time.
    /// </summary>
    [EnumMember(Value = "FINC")]
    [IsoId("_BxBHcFJ4EeeHVODnW-1ONQ")]
    [Description(@"Assigned at financial time.")]
    FINC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LifeCycleSupportCodeMetadataExtensions
{
    private static readonly LifeCycleSupportCodeDropdownSource _dropdownSource = new LifeCycleSupportCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILifeCycleSupportCodeDropdownRow GetMetadata(this LifeCycleSupportCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


