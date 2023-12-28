﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventClassificationCode.  ISO2002 ID# _ajDtENp-Ed-ak6NoX_4Aeg_-407135956.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides information about how the holder must participate in the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajDtENp-Ed-ak6NoX_4Aeg_-407135956")]
[Description(@"Provides information about how the holder must participate in the event.")]
public enum EventClassificationCode
{
    /// <summary>
    /// Specifies that the event will occur without the beneficial owner or agent taking any action.
    /// Encoded/decoded by serializers as "MAND".
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_ajDtEdp-Ed-ak6NoX_4Aeg_-354497585")]
    [Description(@"Specifies that the event will occur without the beneficial owner or agent taking any action.")]
    Mandatory,
    
    /// <summary>
    /// Specifies that the event will occur but the beneficial owner or agent has a choice as to the action taken against the holdings.
    /// Encoded/decoded by serializers as "MAOP".
    /// </summary>
    [EnumMember(Value = "MAOP")]
    [IsoId("_ajDtEtp-Ed-ak6NoX_4Aeg_-353573140")]
    [Description(@"Specifies that the event will occur but the beneficial owner or agent has a choice as to the action taken against the holdings.")]
    MandatoryWithOptions,
    
    /// <summary>
    /// Specifies that this is an event in whichthe beneficial owner or agent of a security need to take action if the event is to affect their holdings.
    /// Encoded/decoded by serializers as "VOLU".
    /// </summary>
    [EnumMember(Value = "VOLU")]
    [IsoId("_ajDtE9p-Ed-ak6NoX_4Aeg_-352650112")]
    [Description(@"Specifies that this is an event in whichthe beneficial owner or agent of a security need to take action if the event is to affect their holdings.")]
    Voluntary,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventClassificationCodeMetadataExtensions
{
    private static readonly EventClassificationCodeDropdownSource _dropdownSource = new EventClassificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventClassificationCodeDropdownRow GetMetadata(this EventClassificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

