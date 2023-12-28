﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriorityCode.  ISO2002 ID# _aKUc9Np-Ed-ak6NoX_4Aeg_1549809096.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKUc9Np-Ed-ak6NoX_4Aeg_1549809096")]
[Description(@"Specifies the priority level of an event.")]
[Derivations(typeof(Priority1Code),typeof(Priority2Code),typeof(Priority3Code),typeof(Priority4Code),typeof(Priority5Code))]
// External derivations that should be provided by the proper interface are: 
public enum PriorityCode
{
    /// <summary>
    /// Priority level is urgent (highest priority possible).
    /// Encoded/decoded by serializers as "URGT".
    /// </summary>
    [EnumMember(Value = "URGT")]
    [IsoId("_aKUc9dp-Ed-ak6NoX_4Aeg_-940450716")]
    [Description(@"Priority level is urgent (highest priority possible).")]
    Urgent,
    
    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as "HIGH".
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKUc9tp-Ed-ak6NoX_4Aeg_2036504741")]
    [Description(@"Priority level is high.")]
    High,
    
    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as "NORM".
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKUc99p-Ed-ak6NoX_4Aeg_-552715931")]
    [Description(@"Priority level is normal.")]
    Normal,
    
    /// <summary>
    /// Priority level is low.
    /// Encoded/decoded by serializers as "LOWW".
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_aKUc-Np-Ed-ak6NoX_4Aeg_2049436362")]
    [Description(@"Priority level is low.")]
    Low,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriorityCodeMetadataExtensions
{
    private static readonly PriorityCodeDropdownSource _dropdownSource = new PriorityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriorityCodeDropdownRow GetMetadata(this PriorityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


