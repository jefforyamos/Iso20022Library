﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RiskLimitType1Code.  ISO2002 ID# _Vm240dp-Ed-ak6NoX_4Aeg_-1698330250.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vm240dp-Ed-ak6NoX_4Aeg_-1698330250")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum RiskLimitType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Multilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vm240tp-Ed-ak6NoX_4Aeg_-1698330241")]
    [Description(@"??")]
    Multilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vm2409p-Ed-ak6NoX_4Aeg_-1698330240")]
    [Description(@"??")]
    Bilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetBilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vm241Np-Ed-ak6NoX_4Aeg_-1698330239")]
    [Description(@"??")]
    NetBilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndirectBilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vm241dp-Ed-ak6NoX_4Aeg_-1698330238")]
    [Description(@"??")]
    IndirectBilateral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RiskLimitType1CodeMetadataExtensions
{
    private static readonly RiskLimitType1CodeDropdownSource _dropdownSource = new RiskLimitType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRiskLimitType1CodeDropdownRow GetMetadata(this RiskLimitType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


