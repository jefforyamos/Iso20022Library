﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Priority3Code.  ISO2002 ID# _aKUc8Np-Ed-ak6NoX_4Aeg_1584820248.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKUc8Np-Ed-ak6NoX_4Aeg_1584820248")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority3Code
{
    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as "URGT".
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_aKUc8dp-Ed-ak6NoX_4Aeg_1584820280")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent = PriorityCode.Urgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as "HIGH".
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKUc8tp-Ed-ak6NoX_4Aeg_1584820309")]
    [Description(@"Priority level is high.")]
    High = PriorityCode.High, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as "NORM".
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKUc89p-Ed-ak6NoX_4Aeg_1584820310")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Priority3CodeMetadataExtensions
{
    private static readonly Priority3CodeDropdownSource _dropdownSource = new Priority3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriority3CodeDropdownRow GetMetadata(this Priority3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


