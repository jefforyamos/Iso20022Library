﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Quantity3Code.  ISO2002 ID# _7AQ5seGZEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as "QALL".
    /// </summary>
    [EnumMember(Value = "QALL")]
    [IsoId("_q5bENmtdEeCY4-KZ9JEyUQ_-1074232711")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AllSecurities = QuantityCode.AllSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5kOIGtdEeCY4-KZ9JEyUQ_-1913030463")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions
    
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


