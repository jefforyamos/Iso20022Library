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
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as "Discount".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJR7Jtp-Ed-ak6NoX_4Aeg_-611906017")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount,
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as "Premium".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJR7J9p-Ed-ak6NoX_4Aeg_-611906016")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium,
    
    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as "Par".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_aJR7KNp-Ed-ak6NoX_4Aeg_-611906015")]
    [Description(@"Price is the face amount.")]
    Par,
    
    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as "Yield".
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_aJbFENp-Ed-ak6NoX_4Aeg_1135725162")]
    [Description(@"Price expressed as a yield.")]
    Yield,
    
    /// <summary>
    /// Difference between a market maker's bid and asked price.
    /// Encoded/decoded by serializers as "Spread".
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_aJbFEdp-Ed-ak6NoX_4Aeg_1135725179")]
    [Description(@"Difference between a market maker's bid and asked price.")]
    Spread,
    
    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_aJbFEtp-Ed-ak6NoX_4Aeg_1135725180")]
    [Description(@"Price expressed per unit.")]
    PerUnit,
    
    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as "Absolute".
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_aJbFE9p-Ed-ak6NoX_4Aeg_1135725445")]
    [Description(@"Price is expressed as absolute.")]
    Absolute,
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar price.
    /// Encoded/decoded by serializers as "TEDPrice".
    /// </summary>
    [EnumMember(Value = "TEDP")]
    [IsoId("_aJbFFNp-Ed-ak6NoX_4Aeg_1135725446")]
    [Description(@"Price is expressed as Treasury Euro Dollar price.")]
    TEDPrice,
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar yield.
    /// Encoded/decoded by serializers as "TEDYield".
    /// </summary>
    [EnumMember(Value = "TEDY")]
    [IsoId("_aJbFFdp-Ed-ak6NoX_4Aeg_1135725470")]
    [Description(@"Price is expressed as Treasury Euro Dollar yield.")]
    TEDYield,
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as "FixedCabinetTrade".
    /// </summary>
    [EnumMember(Value = "FICT")]
    [IsoId("_aJbFFtp-Ed-ak6NoX_4Aeg_1135725487")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
    FixedCabinetTrade,
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as "VariableCabinetTrade".
    /// </summary>
    [EnumMember(Value = "VACT")]
    [IsoId("_aJbFF9p-Ed-ak6NoX_4Aeg_1135725488")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
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


