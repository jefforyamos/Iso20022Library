﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderQuantityType1Code.  ISO2002 ID# _ViiZgdp-Ed-ak6NoX_4Aeg_-392071140.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViiZgdp-Ed-ak6NoX_4Aeg_-392071140")]
[Description(@"Specifies how the order is placed, eg by quantity of units or by amount of money.")]
[DerivedFrom(typeof(OrderQuantityTypeCode))]
public enum OrderQuantityType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViiZgtp-Ed-ak6NoX_4Aeg_-278477005")]
    [Description(@"??")]
    Unit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Amount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViiZg9p-Ed-ak6NoX_4Aeg_-278476987")]
    [Description(@"??")]
    Amount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViiZhNp-Ed-ak6NoX_4Aeg_-278476962")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderQuantityType1CodeMetadataExtensions
{
    private static readonly OrderQuantityType1CodeDropdownSource _dropdownSource = new OrderQuantityType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderQuantityType1CodeDropdownRow GetMetadata(this OrderQuantityType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


