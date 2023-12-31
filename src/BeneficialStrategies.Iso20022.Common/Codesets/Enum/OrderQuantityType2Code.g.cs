﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderQuantityType2Code.  ISO2002 ID# _aRVD4Np-Ed-ak6NoX_4Aeg_-1133979180.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRVD4Np-Ed-ak6NoX_4Aeg_-1133979180")]
[Description(@"Specifies how the order is placed, eg by quantity of units or by amount of money.")]
[DerivedFrom(typeof(OrderQuantityTypeCode))]
public enum OrderQuantityType2Code
{
    /// <summary>
    /// Order is placed by unit.
    /// Encoded/decoded by serializers as "Unit".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_aRVD4dp-Ed-ak6NoX_4Aeg_-1092421681")]
    [Description(@"Order is placed by unit.")]
    Unit,
    
    /// <summary>
    /// Order is placed by amount of money.
    /// Encoded/decoded by serializers as "Amount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aRVD4tp-Ed-ak6NoX_4Aeg_-1092421663")]
    [Description(@"Order is placed by amount of money.")]
    Amount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderQuantityType2CodeMetadataExtensions
{
    private static readonly OrderQuantityType2CodeDropdownSource _dropdownSource = new OrderQuantityType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderQuantityType2CodeDropdownRow GetMetadata(this OrderQuantityType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


