﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType7Code.  ISO2002 ID# _YaHqp9p-Ed-ak6NoX_4Aeg_1660318711.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_YaHqqNp-Ed-ak6NoX_4Aeg_-797452913")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_YaQ0kNp-Ed-ak6NoX_4Aeg_1139772260")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_YaQ0kdp-Ed-ak6NoX_4Aeg_1653645394")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as &quot;YIEL&quot;.
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_YaQ0ktp-Ed-ak6NoX_4Aeg_2107732663")]
    [Description(@"Price expressed as a yield.")]
    Yield = PriceValueTypeCode.Yield, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Difference between a market maker&apos;s bid and asked price.
    /// Encoded/decoded by serializers as &quot;SPRE&quot;.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_YaQ0k9p-Ed-ak6NoX_4Aeg_2096633886")]
    [Description(@"Difference between a market maker's bid and asked price.")]
    Spread = PriceValueTypeCode.Spread, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as &quot;PEUN&quot;.
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_YaQ0lNp-Ed-ak6NoX_4Aeg_404453689")]
    [Description(@"Price expressed per unit.")]
    PerUnit = PriceValueTypeCode.PerUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as &quot;ABSO&quot;.
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_YaQ0ldp-Ed-ak6NoX_4Aeg_858540958")]
    [Description(@"Price is expressed as absolute.")]
    Absolute = PriceValueTypeCode.Absolute, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar price.
    /// Encoded/decoded by serializers as &quot;TEDP&quot;.
    /// </summary>
    [EnumMember(Value = "TEDP")]
    [IsoId("_YaQ0ltp-Ed-ak6NoX_4Aeg_-1499201165")]
    [Description(@"Price is expressed as Treasury Euro Dollar price.")]
    TEDPrice = PriceValueTypeCode.TEDPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is expressed as Treasury Euro Dollar yield.
    /// Encoded/decoded by serializers as &quot;TEDY&quot;.
    /// </summary>
    [EnumMember(Value = "TEDY")]
    [IsoId("_YaQ0l9p-Ed-ak6NoX_4Aeg_847442181")]
    [Description(@"Price is expressed as Treasury Euro Dollar yield.")]
    TEDYield = PriceValueTypeCode.TEDYield, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;FICT&quot;.
    /// </summary>
    [EnumMember(Value = "FICT")]
    [IsoId("_YaQ0mNp-Ed-ak6NoX_4Aeg_1898575253")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
    FixedCabinetTrade = PriceValueTypeCode.FixedCabinetTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;VACT&quot;.
    /// </summary>
    [EnumMember(Value = "VACT")]
    [IsoId("_YaQ0mdp-Ed-ak6NoX_4Aeg_-459166870")]
    [Description(@"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).")]
    VariableCabinetTrade = PriceValueTypeCode.VariableCabinetTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a percentage of par.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_YaalkNp-Ed-ak6NoX_4Aeg_-552112749")]
    [Description(@"Price expressed as a percentage of par.")]
    Percentage = PriceValueTypeCode.Percentage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Yaalkdp-Ed-ak6NoX_4Aeg_-1713637180")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount = PriceValueTypeCode.ActualAmount, // same ordinal as derivation source for type conversions
    
}
