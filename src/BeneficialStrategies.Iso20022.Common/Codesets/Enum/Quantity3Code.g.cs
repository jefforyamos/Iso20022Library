﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Quantity3Code.  ISO2002 ID# _7AQ5seGZEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7AQ5seGZEd-1Ktb5rVaajw")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5bENmtdEeCY4-KZ9JEyUQ_-1074232711")]
    [Description(@"??")]
    AllSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnknownQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5kOIGtdEeCY4-KZ9JEyUQ_-1913030463")]
    [Description(@"??")]
    UnknownQuantity,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Quantity3CodeMetadataExtensions
{
    private static readonly Quantity3CodeDropdownSource _dropdownSource = new Quantity3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuantity3CodeDropdownRow GetMetadata(this Quantity3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

