﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventFrequency10Code.  ISO2002 ID# _9DnqYCDUEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9DnqYCDUEeWCLu74WLgP4w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency10Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ASy8ISDVEeWCLu74WLgP4w")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Adhoc".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Aryq8SDVEeWCLu74WLgP4w")]
    [Description(@"??")]
    Adhoc,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventFrequency10CodeMetadataExtensions
{
    private static readonly EventFrequency10CodeDropdownSource _dropdownSource = new EventFrequency10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventFrequency10CodeDropdownRow GetMetadata(this EventFrequency10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

