﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType7Code.  ISO2002 ID# _YaHqp9p-Ed-ak6NoX_4Aeg_1660318711.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YaHqp9p-Ed-ak6NoX_4Aeg_1660318711")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType7Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as "Discount".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_YaHqqNp-Ed-ak6NoX_4Aeg_-797452913")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount,
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as "Premium".
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_YaQ0kNp-Ed-ak6NoX_4Aeg_1139772260")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium,
    
    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as "Par".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_YaQ0kdp-Ed-ak6NoX_4Aeg_1653645394")]
    [Description(@"Price is the face amount.")]
    Par,
    
    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as "Yield".
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_YaQ0ktp-Ed-ak6NoX_4Aeg_2107732663")]
    [Description(@"Price expressed as a yield.")]
    Yield,
    
    /// <summary>
    /// Difference between a market maker's bid and asked price.
    /// Encoded/decoded by serializers as "Spread".
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_YaQ0k9p-Ed-ak6NoX_4Aeg_2096633886")]
    [Description(@"Difference between a market maker's bid and asked price.")]
    Spread,
    
    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_YaQ0lNp-Ed-ak6NoX_4Aeg_404453689")]
    [Description(@"Price expressed per unit.")]
    PerUnit,
    
    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as "Absolute".
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_YaQ0ldp-Ed-ak6NoX_4Aeg_858540958")]
    [Description(@"Price is expressed as absolute.")]
    Absolute,
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar price.
    /// Encoded/decoded by serializers as "TEDPrice".
    /// </summary>
    [EnumMember(Value = "TEDP")]
    [IsoId("_YaQ0ltp-Ed-ak6NoX_4Aeg_-1499201165")]
    [Description(@"Price is expressed as Treasury Euro Dollar price.")]
    TEDPrice,
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar yield.
    /// Encoded/decoded by serializers as "TEDYield".
    /// </summary>
    [EnumMember(Value = "TEDY")]
    [IsoId("_YaQ0l9p-Ed-ak6NoX_4Aeg_847442181")]
    [Description(@"Price is expressed as Treasury Euro Dollar yield.")]
    TEDYield,
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as "FixedCabinetTrade".
    /// </summary>
    [EnumMember(Value = "FICT")]
    [IsoId("_YaQ0mNp-Ed-ak6NoX_4Aeg_1898575253")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
    FixedCabinetTrade,
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as "VariableCabinetTrade".
    /// </summary>
    [EnumMember(Value = "VACT")]
    [IsoId("_YaQ0mdp-Ed-ak6NoX_4Aeg_-459166870")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
    VariableCabinetTrade,
    
    /// <summary>
    /// Price expressed as a percentage of par.
    /// Encoded/decoded by serializers as "Percentage".
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_YaalkNp-Ed-ak6NoX_4Aeg_-552112749")]
    [Description(@"Price expressed as a percentage of par.")]
    Percentage,
    
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as "ActualAmount".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Yaalkdp-Ed-ak6NoX_4Aeg_-1713637180")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType7CodeMetadataExtensions
{
    private static readonly PriceValueType7CodeDropdownSource _dropdownSource = new PriceValueType7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType7CodeDropdownRow GetMetadata(this PriceValueType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


