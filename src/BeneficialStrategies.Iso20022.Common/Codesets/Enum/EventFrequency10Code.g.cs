﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventFrequency10Code.  ISO2002 ID# _9DnqYCDUEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Event takes place every day.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_ASy8ISDVEeWCLu74WLgP4w")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as "ADHO".
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_Aryq8SDVEeWCLu74WLgP4w")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
    
}
