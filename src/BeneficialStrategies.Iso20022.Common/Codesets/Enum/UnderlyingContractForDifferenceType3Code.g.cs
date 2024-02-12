﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingContractForDifferenceType3Code.  ISO2002 ID# _2qD00IJoEeaStugbHOVOsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type for an underlying contract for difference derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2qD00IJoEeaStugbHOVOsA")]
[Description(@"Specifies the type for an underlying contract for difference derivative.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingContractForDifferenceType3Code
{
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as "BOND".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_-D6XQYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a bond.")]
    Bond = UnderlyingTypeV3Code.Bond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a commodity.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_-NuakYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a commodity.")]
    Commodity = UnderlyingTypeV3Code.Commodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a currency.
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_-hqDMYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a currency.")]
    Currency = UnderlyingTypeV3Code.Currency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is an emission allowance.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_-7ii0YJoEeaStugbHOVOsA")]
    [Description(@"Underlying is an emission allowance.")]
    EmissionAllowance = UnderlyingTypeV3Code.EmissionAllowance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is an equity.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("__UhqkYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is an equity.")]
    Equity = UnderlyingTypeV3Code.Equity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as "FTEQ".
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_ANMX8YJpEeaStugbHOVOsA")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity = UnderlyingTypeV3Code.FutureOnEquity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as "OPEQ".
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_BAgEMYJpEeaStugbHOVOsA")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity = UnderlyingTypeV3Code.OptionOnEquity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BPhXoYJpEeaStugbHOVOsA")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV3Code.Other, // same ordinal as derivation source for type conversions
    
}
