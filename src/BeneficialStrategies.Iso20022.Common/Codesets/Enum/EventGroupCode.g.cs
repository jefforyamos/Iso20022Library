﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventGroupCode.  ISO2002 ID# _1oFf0zL3EeKU9IrkkToqcw_648096752.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oFf0zL3EeKU9IrkkToqcw_648096752")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
public enum EventGroupCode
{
    /// <summary>
    /// Redemption domain events.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_1oFf1DL3EeKU9IrkkToqcw_-934083267")]
    [Description(@"Redemption domain events.")]
    REDM,
    
    /// <summary>
    /// Reorganization domain events.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_yQlqgK2nEea8JNaCEJBGAA")]
    [Description(@"Reorganization domain events.")]
    REOR,
    
    /// <summary>
    /// Distribution domain events.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_j3dzYK2oEea8JNaCEJBGAA")]
    [Description(@"Distribution domain events.")]
    DISN,
    
    /// <summary>
    /// General domain events.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_ZJKr4AB8EeqouY-yI_q3qQ")]
    [Description(@"General domain events.")]
    GENL,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventGroupCodeMetadataExtensions
{
    private static readonly EventGroupCodeDropdownSource _dropdownSource = new EventGroupCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventGroupCodeDropdownRow GetMetadata(this EventGroupCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


