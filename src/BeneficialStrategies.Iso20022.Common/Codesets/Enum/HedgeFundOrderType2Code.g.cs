﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HedgeFundOrderType2Code.  ISO2002 ID# _avIaNdp-Ed-ak6NoX_4Aeg_1497408468.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_avIaNdp-Ed-ak6NoX_4Aeg_1497408468")]
[Description(@"Specifies the type of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum HedgeFundOrderType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonUnitized".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avIaNtp-Ed-ak6NoX_4Aeg_1497408498")]
    [Description(@"??")]
    NonUnitized,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SidePocketComponent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avIaN9p-Ed-ak6NoX_4Aeg_1497408529")]
    [Description(@"??")]
    SidePocketComponent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BedAndBreakfast".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avIaONp-Ed-ak6NoX_4Aeg_1497408560")]
    [Description(@"??")]
    BedAndBreakfast,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SidePocketOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avIaOdp-Ed-ak6NoX_4Aeg_1497408561")]
    [Description(@"??")]
    SidePocketOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unitized".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avRkINp-Ed-ak6NoX_4Aeg_1497408590")]
    [Description(@"??")]
    Unitized,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TopUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avRkIdp-Ed-ak6NoX_4Aeg_1497408591")]
    [Description(@"??")]
    TopUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HoldBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_avRkItp-Ed-ak6NoX_4Aeg_-1544341372")]
    [Description(@"??")]
    HoldBack,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HedgeFundOrderType2CodeMetadataExtensions
{
    private static readonly HedgeFundOrderType2CodeDropdownSource _dropdownSource = new HedgeFundOrderType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHedgeFundOrderType2CodeDropdownRow GetMetadata(this HedgeFundOrderType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

