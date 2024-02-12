﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GrossDividendRateType3Code.  ISO2002 ID# _XfCfsBLZEeKJ5uSjVyVvug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XfCfsBLZEeKJ5uSjVyVvug")]
[Description(@"Specifies the type of dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum GrossDividendRateType3Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as "CAPO".
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_cQ99oRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion = DividendRateTypeCode.CapitalPortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as "FLFR".
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_cyDRcRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.")]
    FullyFranked = DividendRateTypeCode.FullyFranked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as "INCO".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_c5zfQRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion = DividendRateTypeCode.IncomePortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_dUxkARLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest = DividendRateTypeCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Long term capital gain.
    /// Encoded/decoded by serializers as "LTCG".
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_dj0soRLZEeKJ5uSjVyVvug")]
    [Description(@"Long term capital gain.")]
    LongTermCapitalGain = DividendRateTypeCode.LongTermCapitalGain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as "REES".
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_d-WsgRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion = DividendRateTypeCode.RealEstatePropertyIncomePortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Short term capital gain.
    /// Encoded/decoded by serializers as "STCG".
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_ee_UYRLZEeKJ5uSjVyVvug")]
    [Description(@"Short term capital gain.")]
    ShortTermCapitalGain = DividendRateTypeCode.ShortTermCapitalGain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as "SOIC".
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_fkbScRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome = DividendRateTypeCode.SundryOrOtherIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as "TXBL".
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_f7Xy0RLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion = DividendRateTypeCode.TaxablePortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as "TXDF".
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_gC1FsRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = DividendRateTypeCode.TaxDeferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as "TXFR".
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_grEKYRLZEeKJ5uSjVyVvug")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree = DividendRateTypeCode.TaxFree, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as "UNFR".
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_gzQdERLZEeKJ5uSjVyVvug")]
    [Description(@"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.")]
    Unfranked = DividendRateTypeCode.Unfranked, // same ordinal as derivation source for type conversions
    
}
