﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventGroup1Code.  ISO2002 ID# _1tTXAjL3EeKU9IrkkToqcw_-1870797912.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tTXAjL3EeKU9IrkkToqcw_-1870797912")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup1Code
{
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_1tTXAzL3EeKU9IrkkToqcw_-766484011")]
    [Description(@"Redemption domain events.")]
    Redemption = EventGroupCode.Redemption, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventGroup1CodeMetadataExtensions
{
    private static readonly EventGroup1CodeDropdownSource _dropdownSource = new EventGroup1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventGroup1CodeDropdownRow GetMetadata(this EventGroup1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


