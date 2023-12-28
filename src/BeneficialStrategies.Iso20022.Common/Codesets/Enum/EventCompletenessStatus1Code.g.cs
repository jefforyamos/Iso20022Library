﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventCompletenessStatus1Code.  ISO2002 ID# _ajDtFNp-Ed-ak6NoX_4Aeg_1571232805.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the details provided about an event are complete or incomplete.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajDtFNp-Ed-ak6NoX_4Aeg_1571232805")]
[Description(@"Indicates whether the details provided about an event are complete or incomplete.")]
[DerivedFrom(typeof(EventCompletenessStatusCode))]
public enum EventCompletenessStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ajDtFdp-Ed-ak6NoX_4Aeg_1572153086")]
    [Description(@"??")]
    Complete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Incomplete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ajDtFtp-Ed-ak6NoX_4Aeg_1572153199")]
    [Description(@"??")]
    Incomplete,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventCompletenessStatus1CodeMetadataExtensions
{
    private static readonly EventCompletenessStatus1CodeDropdownSource _dropdownSource = new EventCompletenessStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventCompletenessStatus1CodeDropdownRow GetMetadata(this EventCompletenessStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


