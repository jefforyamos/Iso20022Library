﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventGroup4Code.  ISO2002 ID# _i8tCgAB8EeqouY-yI_q3qQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i8tCgAB8EeqouY-yI_q3qQ")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup4Code
{
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as "DISN".
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_mGuugQB8EeqouY-yI_q3qQ")]
    [Description(@"Distribution domain events.")]
    Distribution = EventGroupCode.Distribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// General domain events.
    /// Encoded/decoded by serializers as "GENL".
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_mLWIwQB8EeqouY-yI_q3qQ")]
    [Description(@"General domain events.")]
    General = EventGroupCode.General, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_mPg3EQB8EeqouY-yI_q3qQ")]
    [Description(@"Redemption domain events.")]
    Redemption = EventGroupCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganization domain events.
    /// Encoded/decoded by serializers as "REOR".
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_mT0vUQB8EeqouY-yI_q3qQ")]
    [Description(@"Reorganization domain events.")]
    Reorganization = EventGroupCode.Reorganization, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventGroup4CodeMetadataExtensions
{
    private static readonly EventGroup4CodeDropdownSource _dropdownSource = new EventGroup4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventGroup4CodeDropdownRow GetMetadata(this EventGroup4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


