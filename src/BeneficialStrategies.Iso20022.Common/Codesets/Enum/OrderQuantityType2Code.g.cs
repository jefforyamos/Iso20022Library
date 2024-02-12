﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderQuantityType2Code.  ISO2002 ID# _aRVD4Np-Ed-ak6NoX_4Aeg_-1133979180.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "UNIT".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_aRVD4dp-Ed-ak6NoX_4Aeg_-1092421681")]
    [Description(@"Order is placed by unit.")]
    Unit = OrderQuantityTypeCode.Unit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is placed by amount of money.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aRVD4tp-Ed-ak6NoX_4Aeg_-1092421663")]
    [Description(@"Order is placed by amount of money.")]
    Amount = OrderQuantityTypeCode.Amount, // same ordinal as derivation source for type conversions
    
}
