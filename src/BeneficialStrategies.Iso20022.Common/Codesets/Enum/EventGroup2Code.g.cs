﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventGroup2Code.  ISO2002 ID# _qP240K2oEea8JNaCEJBGAA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qP240K2oEea8JNaCEJBGAA")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup2Code
{
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as "Distribution".
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_rxKTga2oEea8JNaCEJBGAA")]
    [Description(@"Distribution domain events.")]
    Distribution,
    
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_r2Nyoa2oEea8JNaCEJBGAA")]
    [Description(@"Redemption domain events.")]
    Redemption,
    
    /// <summary>
    /// Reorganization domain events.
    /// Encoded/decoded by serializers as "Reorganization".
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_r7bCwa2oEea8JNaCEJBGAA")]
    [Description(@"Reorganization domain events.")]
    Reorganization,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventGroup2CodeMetadataExtensions
{
    private static readonly EventGroup2CodeDropdownSource _dropdownSource = new EventGroup2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventGroup2CodeDropdownRow GetMetadata(this EventGroup2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


