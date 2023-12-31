﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AutoRoutingCode.  ISO2002 ID# _bj4Q59p-Ed-ak6NoX_4Aeg_686608073.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether an automatic routing system is involved.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bj4Q59p-Ed-ak6NoX_4Aeg_686608073")]
[Description(@"Indicates whether an automatic routing system is involved.")]
[Derivations(typeof(AutoRouting1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AutoRoutingCode
{
    /// <summary>
    /// Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as "DDOT".
    /// </summary>
    [EnumMember(Value = "DDOT")]
    [IsoId("_bkBa0Np-Ed-ak6NoX_4Aeg_1056016458")]
    [Description(@"Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.")]
    DOTSystem,
    
    /// <summary>
    /// Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as "SDOT".
    /// </summary>
    [EnumMember(Value = "SDOT")]
    [IsoId("_bkBa0dp-Ed-ak6NoX_4Aeg_1056016502")]
    [Description(@"Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.")]
    SuperDOTSystem,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AutoRoutingCodeMetadataExtensions
{
    private static readonly AutoRoutingCodeDropdownSource _dropdownSource = new AutoRoutingCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAutoRoutingCodeDropdownRow GetMetadata(this AutoRoutingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


