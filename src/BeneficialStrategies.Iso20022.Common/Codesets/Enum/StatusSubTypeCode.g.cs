﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatusSubTypeCode.  ISO2002 ID# _T_BfoB3cEeKXIbeXfdPzuw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the sub status of the trade notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T_BfoB3cEeKXIbeXfdPzuw")]
[Description(@"Indicates the sub status of the trade notification.")]
[Derivations(typeof(StatusSubType1Code),typeof(StatusSubType2Code))]
public enum StatusSubTypeCode
{
    /// <summary>
    /// No flag has been set for the sub status of the trade notification.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_fI1ssB3cEeKXIbeXfdPzuw")]
    [Description(@"No flag has been set for the sub status of the trade notification.")]
    NoFlagsSet,
    
    /// <summary>
    /// Same day flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as "SMDY".
    /// </summary>
    [EnumMember(Value = "SMDY")]
    [IsoId("_lXEJgB3cEeKXIbeXfdPzuw")]
    [Description(@"Same day flag has been set to true for the sub status of the trade notification.")]
    OnlySameDayFlagTrue,
    
    /// <summary>
    /// Pending flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_sw0lUB3cEeKXIbeXfdPzuw")]
    [Description(@"Pending flag has been set to true for the sub status of the trade notification.")]
    OnlyPendingFlagTrue,
    
    /// <summary>
    /// Both the same day and pending flags have been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as "SDPG".
    /// </summary>
    [EnumMember(Value = "SDPG")]
    [IsoId("_yIHaIB3cEeKXIbeXfdPzuw")]
    [Description(@"Both the same day and pending flags have been set to true for the sub status of the trade notification.")]
    SameDayAndPendingFlagsTrue,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatusSubTypeCodeMetadataExtensions
{
    private static readonly StatusSubTypeCodeDropdownSource _dropdownSource = new StatusSubTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatusSubTypeCodeDropdownRow GetMetadata(this StatusSubTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


