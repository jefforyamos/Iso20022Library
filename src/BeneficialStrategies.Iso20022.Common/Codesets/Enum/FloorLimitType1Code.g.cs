﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FloorLimitType1Code.  ISO2002 ID# _aqzT0tp-Ed-ak6NoX_4Aeg_-1031522617.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqzT0tp-Ed-ak6NoX_4Aeg_-1031522617")]
[Description(@"Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries.")]
[DerivedFrom(typeof(FloorLimitTypeCode))]
public enum FloorLimitType1Code
{
    /// <summary>
    /// Floor limit applies to credit entries.
    /// Encoded/decoded by serializers as "Credit".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_aqzT09p-Ed-ak6NoX_4Aeg_-430226238")]
    [Description(@"Floor limit applies to credit entries.")]
    Credit,
    
    /// <summary>
    /// Floor limit applies to debit entries.
    /// Encoded/decoded by serializers as "Debit".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_aqzT1Np-Ed-ak6NoX_4Aeg_-371121394")]
    [Description(@"Floor limit applies to debit entries.")]
    Debit,
    
    /// <summary>
    /// Floor limit applies to both credit and debit entries.
    /// Encoded/decoded by serializers as "Both".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_aqzT1dp-Ed-ak6NoX_4Aeg_-344337748")]
    [Description(@"Floor limit applies to both credit and debit entries.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FloorLimitType1CodeMetadataExtensions
{
    private static readonly FloorLimitType1CodeDropdownSource _dropdownSource = new FloorLimitType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFloorLimitType1CodeDropdownRow GetMetadata(this FloorLimitType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


