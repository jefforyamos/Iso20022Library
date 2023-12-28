﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType3Code.  ISO2002 ID# _aJR7Jdp-Ed-ak6NoX_4Aeg_-611906034.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJR7Jdp-Ed-ak6NoX_4Aeg_-611906034")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Discount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJR7Jtp-Ed-ak6NoX_4Aeg_-611906017")]
    [Description(@"??")]
    Discount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Premium".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJR7J9p-Ed-ak6NoX_4Aeg_-611906016")]
    [Description(@"??")]
    Premium,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Par".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJR7KNp-Ed-ak6NoX_4Aeg_-611906015")]
    [Description(@"??")]
    Par,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Yield".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFENp-Ed-ak6NoX_4Aeg_1135725162")]
    [Description(@"??")]
    Yield,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Spread".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFEdp-Ed-ak6NoX_4Aeg_1135725179")]
    [Description(@"??")]
    Spread,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFEtp-Ed-ak6NoX_4Aeg_1135725180")]
    [Description(@"??")]
    PerUnit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Absolute".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFE9p-Ed-ak6NoX_4Aeg_1135725445")]
    [Description(@"??")]
    Absolute,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TEDPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFFNp-Ed-ak6NoX_4Aeg_1135725446")]
    [Description(@"??")]
    TEDPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TEDYield".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFFdp-Ed-ak6NoX_4Aeg_1135725470")]
    [Description(@"??")]
    TEDYield,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FixedCabinetTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFFtp-Ed-ak6NoX_4Aeg_1135725487")]
    [Description(@"??")]
    FixedCabinetTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VariableCabinetTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aJbFF9p-Ed-ak6NoX_4Aeg_1135725488")]
    [Description(@"??")]
    VariableCabinetTrade,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType3CodeMetadataExtensions
{
    private static readonly PriceValueType3CodeDropdownSource _dropdownSource = new PriceValueType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType3CodeDropdownRow GetMetadata(this PriceValueType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


