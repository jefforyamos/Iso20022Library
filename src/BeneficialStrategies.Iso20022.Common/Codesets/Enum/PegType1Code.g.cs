﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PegType1Code.  ISO2002 ID# _Z9p599p-Ed-ak6NoX_4Aeg_307440382.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z9p599p-Ed-ak6NoX_4Aeg_307440382")]
[Description(@"Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.")]
[DerivedFrom(typeof(PegTypeCode))]
public enum PegType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fixed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9p5-Np-Ed-ak6NoX_4Aeg_307440399")]
    [Description(@"??")]
    Fixed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Last".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9p5-dp-Ed-ak6NoX_4Aeg_307440417")]
    [Description(@"??")]
    Last,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Market".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9zq8Np-Ed-ak6NoX_4Aeg_307440434")]
    [Description(@"??")]
    Market,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MidPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9zq8dp-Ed-ak6NoX_4Aeg_307440452")]
    [Description(@"??")]
    MidPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Opening".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9zq8tp-Ed-ak6NoX_4Aeg_307440477")]
    [Description(@"??")]
    Opening,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Primary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9zq89p-Ed-ak6NoX_4Aeg_307440494")]
    [Description(@"??")]
    Primary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VolumeWeightAveragePrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z9zq9Np-Ed-ak6NoX_4Aeg_307440512")]
    [Description(@"??")]
    VolumeWeightAveragePrice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PegType1CodeMetadataExtensions
{
    private static readonly PegType1CodeDropdownSource _dropdownSource = new PegType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPegType1CodeDropdownRow GetMetadata(this PegType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

