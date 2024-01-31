﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventConfirmationStatusCode.  ISO2002 ID# _ajNeFNp-Ed-ak6NoX_4Aeg_-582418410.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the occurrence of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajNeFNp-Ed-ak6NoX_4Aeg_-582418410")]
[Description(@"Indicates the status of the occurrence of an event.")]
[Derivations(typeof(EventConfirmationStatus1Code))]
public enum EventConfirmationStatusCode
{
    /// <summary>
    /// Occurrence of the event has been confirmed.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ajNeFdp-Ed-ak6NoX_4Aeg_-88336775")]
    [Description(@"Occurrence of the event has been confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Occurrence of the event has not been confirmed.
    /// Encoded/decoded by serializers as "UCON".
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_ajNeFtp-Ed-ak6NoX_4Aeg_-88336774")]
    [Description(@"Occurrence of the event has not been confirmed.")]
    Unconfirmed,
    
    /// <summary>
    /// Occurrence of the event is pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_k_9VoPyhEeq1mLMo4Zt_TQ")]
    [Description(@"Occurrence of the event is pending.")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventConfirmationStatusCodeMetadataExtensions
{
    private static readonly EventConfirmationStatusCodeDropdownSource _dropdownSource = new EventConfirmationStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventConfirmationStatusCodeDropdownRow GetMetadata(this EventConfirmationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


