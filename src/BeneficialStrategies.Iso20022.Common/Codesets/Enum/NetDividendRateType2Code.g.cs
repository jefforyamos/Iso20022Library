﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NetDividendRateType2Code.  ISO2002 ID# _0OkFsRFZEeKp2ZN13DI_pA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of net dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0OkFsRFZEeKp2ZN13DI_pA")]
[Description(@"Specifies the type of net dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum NetDividendRateType2Code
{
    /// <summary>
    /// Rate relating to the underlying security for which capital is distributed.
    /// Encoded/decoded by serializers as "CapitalPortion".
    /// </summary>
    [EnumMember(Value = "CAPO")]
    [IsoId("_0jbidRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which capital is distributed.")]
    CapitalPortion,
    
    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// Encoded/decoded by serializers as "FullyFranked".
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_0jbieRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate resulting from a fully franked dividend paid by a company; the rate includes tax credit for companies that have made sufficient tax payments during the fiscal period.")]
    FullyFranked,
    
    /// <summary>
    /// Rate relating to the underlying security for which income is distributed.
    /// Encoded/decoded by serializers as "IncomePortion".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_0jbifRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which income is distributed.")]
    IncomePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which interest is paid.
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_0jbigRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which interest is paid.")]
    Interest,
    
    /// <summary>
    /// Rate relating to the underlying security for which other income is paid.
    /// Encoded/decoded by serializers as "SundryOrOtherIncome".
    /// </summary>
    [EnumMember(Value = "SOIC")]
    [IsoId("_0jbihRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which other income is paid.")]
    SundryOrOtherIncome,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_0jbiiRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as "TaxDeferred".
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_0jbijRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred,
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as "TaxFree".
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_0jbikRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFree,
    
    /// <summary>
    /// Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.
    /// Encoded/decoded by serializers as "Unfranked".
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_0jbilRFZEeKp2ZN13DI_pA")]
    [Description(@"Rate resulting from an unfranked dividend paid by a company; the rate does not include tax credit and is subject to withholding tax.")]
    Unfranked,
    
    /// <summary>
    /// Distribution rate relating to the full period units, for example Group I units in UK.
    /// Encoded/decoded by serializers as "FullPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "FUPU")]
    [IsoId("_3_-h0RFZEeKp2ZN13DI_pA")]
    [Description(@"Distribution rate relating to the full period units, for example Group I units in UK.")]
    FullPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Distribution rate relating to the part way period units, for example Group II units in UK.
    /// Encoded/decoded by serializers as "PartWayPeriodUnitsIncomePortion".
    /// </summary>
    [EnumMember(Value = "PAPU")]
    [IsoId("_4YHVARFZEeKp2ZN13DI_pA")]
    [Description(@"Distribution rate relating to the part way period units, for example Group II units in UK.")]
    PartWayPeriodUnitsIncomePortion,
    
    /// <summary>
    /// Rate of income distribution originated by real estate investment.
    /// Encoded/decoded by serializers as "RealEstatePropertyIncomePortion".
    /// </summary>
    [EnumMember(Value = "REES")]
    [IsoId("_OGJ8YRLnEeKJ5uSjVyVvug")]
    [Description(@"Rate of income distribution originated by real estate investment.")]
    RealEstatePropertyIncomePortion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NetDividendRateType2CodeMetadataExtensions
{
    private static readonly NetDividendRateType2CodeDropdownSource _dropdownSource = new NetDividendRateType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INetDividendRateType2CodeDropdownRow GetMetadata(this NetDividendRateType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


