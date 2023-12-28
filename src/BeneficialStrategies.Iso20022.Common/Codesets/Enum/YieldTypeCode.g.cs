﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for YieldTypeCode.  ISO2002 ID# _VqusONp-Ed-ak6NoX_4Aeg_337179810.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Yield computation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqusONp-Ed-ak6NoX_4Aeg_337179810")]
[Description(@"Yield computation method.")]
public enum YieldTypeCode
{
    /// <summary>
    /// The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.
    /// Encoded/decoded by serializers as "AFTX".
    /// </summary>
    [EnumMember(Value = "AFTX")]
    [IsoId("_VqusOdp-Ed-ak6NoX_4Aeg_337179811")]
    [Description(@"The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.")]
    AfterTax,
    
    /// <summary>
    /// The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value.
    /// Encoded/decoded by serializers as "ANNU".
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_Vq4dMNp-Ed-ak6NoX_4Aeg_337179812")]
    [Description(@"The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value.")]
    Annual,
    
    /// <summary>
    /// The yield of the bond offered on the issue date.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_Vq4dMdp-Ed-ak6NoX_4Aeg_337179813")]
    [Description(@"The yield of the bond offered on the issue date.")]
    AtIssue,
    
    /// <summary>
    /// The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the average life date.
    /// Encoded/decoded by serializers as "AVLF".
    /// </summary>
    [EnumMember(Value = "AVLF")]
    [IsoId("_Vq4dMtp-Ed-ak6NoX_4Aeg_337179822")]
    [Description(@"The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the average life date.")]
    ToAverageLife,
    
    /// <summary>
    /// The yield achieved by substituting a bond's average maturity for the issue's final maturity date.
    /// Encoded/decoded by serializers as "AVMA".
    /// </summary>
    [EnumMember(Value = "AVMA")]
    [IsoId("_Vq4dM9p-Ed-ak6NoX_4Aeg_337179823")]
    [Description(@"The yield achieved by substituting a bond's average maturity for the issue's final maturity date.")]
    ToAverageMaturity,
    
    /// <summary>
    /// The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.
    /// Encoded/decoded by serializers as "BOOK".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_Vq4dNNp-Ed-ak6NoX_4Aeg_337179824")]
    [Description(@"The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.")]
    Book,
    
    /// <summary>
    /// The yield of a bond to the next possible call date.
    /// Encoded/decoded by serializers as "CALL".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_Vq4dNdp-Ed-ak6NoX_4Aeg_337179825")]
    [Description(@"The yield of a bond to the next possible call date.")]
    ToNextCall,
    
    /// <summary>
    /// The change in the yield since the previous day's closing yield.
    /// Encoded/decoded by serializers as "CHCL".
    /// </summary>
    [EnumMember(Value = "CHCL")]
    [IsoId("_Vq4dNtp-Ed-ak6NoX_4Aeg_337179826")]
    [Description(@"The change in the yield since the previous day's closing yield.")]
    ChangeSinceClose,
    
    /// <summary>
    /// The yield of a bond based on the closing price.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_Vq4dN9p-Ed-ak6NoX_4Aeg_337179827")]
    [Description(@"The yield of a bond based on the closing price.")]
    Closing,
    
    /// <summary>
    /// The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.
    /// Encoded/decoded by serializers as "CMPD".
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_Vq4dONp-Ed-ak6NoX_4Aeg_337179828")]
    [Description(@"The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.")]
    Compound,
    
    /// <summary>
    /// Annual interest on a bond divided by the market value. The actual income rate of return as opposed to the coupon rate expressed as a percentage.
    /// Encoded/decoded by serializers as "CRRT".
    /// </summary>
    [EnumMember(Value = "CRRT")]
    [IsoId("_Vq4dOdp-Ed-ak6NoX_4Aeg_337179829")]
    [Description(@"Annual interest on a bond divided by the market value. The actual income rate of return as opposed to the coupon rate expressed as a percentage.")]
    Current,
    
    /// <summary>
    /// Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.
    /// Encoded/decoded by serializers as "TRGR".
    /// </summary>
    [EnumMember(Value = "TRGR")]
    [IsoId("_VrBnINp-Ed-ak6NoX_4Aeg_337179830")]
    [Description(@"Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.")]
    TrueGross,
    
    /// <summary>
    /// Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.
    /// Encoded/decoded by serializers as "GVEQ".
    /// </summary>
    [EnumMember(Value = "GVEQ")]
    [IsoId("_VrBnIdp-Ed-ak6NoX_4Aeg_337179831")]
    [Description(@"Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.")]
    GovernmentEquivalent,
    
    /// <summary>
    /// Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.
    /// Encoded/decoded by serializers as "FLAS".
    /// </summary>
    [EnumMember(Value = "FLAS")]
    [IsoId("_VrBnItp-Ed-ak6NoX_4Aeg_337179839")]
    [Description(@"Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.")]
    InflationAssumption,
    
    /// <summary>
    /// Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.
    /// Encoded/decoded by serializers as "NVFL".
    /// </summary>
    [EnumMember(Value = "NVFL")]
    [IsoId("_VrBnI9p-Ed-ak6NoX_4Aeg_337179840")]
    [Description(@"Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.")]
    InverseFloater,
    
    /// <summary>
    /// Most Recent Closing Yield - The last available yield stored in history, computed using price.
    /// Encoded/decoded by serializers as "LSCL".
    /// </summary>
    [EnumMember(Value = "LSCL")]
    [IsoId("_VrBnJNp-Ed-ak6NoX_4Aeg_337179841")]
    [Description(@"Most Recent Closing Yield - The last available yield stored in history, computed using price.")]
    LastClose,
    
    /// <summary>
    /// Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end.
    /// Encoded/decoded by serializers as "LSMT".
    /// </summary>
    [EnumMember(Value = "LSMT")]
    [IsoId("_VrBnJdp-Ed-ak6NoX_4Aeg_337179842")]
    [Description(@"Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end.")]
    LastMonth,
    
    /// <summary>
    /// Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end.
    /// Encoded/decoded by serializers as "LSQR".
    /// </summary>
    [EnumMember(Value = "LSQR")]
    [IsoId("_VrBnJtp-Ed-ak6NoX_4Aeg_337179843")]
    [Description(@"Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end.")]
    LastQuarter,
    
    /// <summary>
    /// Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end.
    /// Encoded/decoded by serializers as "LSYR".
    /// </summary>
    [EnumMember(Value = "LSYR")]
    [IsoId("_VrBnJ9p-Ed-ak6NoX_4Aeg_337179844")]
    [Description(@"Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end.")]
    LastYear,
    
    /// <summary>
    /// The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as "LGAL".
    /// </summary>
    [EnumMember(Value = "LGAL")]
    [IsoId("_VrBnKNp-Ed-ak6NoX_4Aeg_337179853")]
    [Description(@"The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.")]
    LongestAverageLife,
    
    /// <summary>
    /// Yield to Longest Average (Sinking Fund Bonds) - The yield assuming only mandatory sinks are taken. This results in a slower paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as "LGAV".
    /// </summary>
    [EnumMember(Value = "LGAV")]
    [IsoId("_VrBnKdp-Ed-ak6NoX_4Aeg_337179854")]
    [Description(@"Yield to Longest Average (Sinking Fund Bonds) - The yield assuming only mandatory sinks are taken. This results in a slower paydown of debt; the yield is then calculated to the final payment date.")]
    LongestAverage,
    
    /// <summary>
    /// An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as "MARK".
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_VrLYINp-Ed-ak6NoX_4Aeg_337179855")]
    [Description(@"An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.")]
    MarkToMarket,
    
    /// <summary>
    /// The yield of a bond to its maturity date.
    /// Encoded/decoded by serializers as "MTRY".
    /// </summary>
    [EnumMember(Value = "MTRY")]
    [IsoId("_VrLYIdp-Ed-ak6NoX_4Aeg_337179856")]
    [Description(@"The yield of a bond to its maturity date.")]
    Maturity,
    
    /// <summary>
    /// Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.
    /// Encoded/decoded by serializers as "NXRF".
    /// </summary>
    [EnumMember(Value = "NXRF")]
    [IsoId("_VrLYItp-Ed-ak6NoX_4Aeg_337179857")]
    [Description(@"Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.")]
    ToNextRefund,
    
    /// <summary>
    /// The average yield of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as "PNAV".
    /// </summary>
    [EnumMember(Value = "PNAV")]
    [IsoId("_VrLYI9p-Ed-ak6NoX_4Aeg_337179858")]
    [Description(@"The average yield of the respective securities in the portfolio.")]
    OpenAverage,
    
    /// <summary>
    /// The yield to the date at which the bond holder can next put the bond to the issuer.
    /// Encoded/decoded by serializers as "NXPT".
    /// </summary>
    [EnumMember(Value = "NXPT")]
    [IsoId("_VrLYJNp-Ed-ak6NoX_4Aeg_337179859")]
    [Description(@"The yield to the date at which the bond holder can next put the bond to the issuer.")]
    ToNextPut,
    
    /// <summary>
    /// The yield of a bond based on the closing price 1 day ago.
    /// Encoded/decoded by serializers as "PRCL".
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_VrLYJdp-Ed-ak6NoX_4Aeg_337179860")]
    [Description(@"The yield of a bond based on the closing price 1 day ago.")]
    PreviousClose,
    
    /// <summary>
    /// The CD equivalent yield when the remaining time to maturity is less than two years.
    /// Encoded/decoded by serializers as "PRYL".
    /// </summary>
    [EnumMember(Value = "PRYL")]
    [IsoId("_VrLYJtp-Ed-ak6NoX_4Aeg_337179861")]
    [Description(@"The CD equivalent yield when the remaining time to maturity is less than two years.")]
    Proceeds,
    
    /// <summary>
    /// The yield of a bond whose coupon payments are reinvested semi-annually.
    /// Encoded/decoded by serializers as "SEMI".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_VrLYJ9p-Ed-ak6NoX_4Aeg_337179862")]
    [Description(@"The yield of a bond whose coupon payments are reinvested semi-annually.")]
    SemiAnnual,
    
    /// <summary>
    /// The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.
    /// Encoded/decoded by serializers as "SHLF".
    /// </summary>
    [EnumMember(Value = "SHLF")]
    [IsoId("_VrLYKNp-Ed-ak6NoX_4Aeg_337179870")]
    [Description(@"The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.")]
    ShortestAverageLife,
    
    /// <summary>
    /// Yield to Shortest Average (Sinking Fund Bonds) - The yield assuming that all sinks (mandatory and voluntary) are taken. This results in a faster paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as "SHAV".
    /// </summary>
    [EnumMember(Value = "SHAV")]
    [IsoId("_VrLYKdp-Ed-ak6NoX_4Aeg_337179871")]
    [Description(@"Yield to Shortest Average (Sinking Fund Bonds) - The yield assuming that all sinks (mandatory and voluntary) are taken. This results in a faster paydown of debt; the yield is then calculated to the final payment date.")]
    ShortestAverage,
    
    /// <summary>
    /// The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).
    /// Encoded/decoded by serializers as "SPLL".
    /// </summary>
    [EnumMember(Value = "SPLL")]
    [IsoId("_VrUiENp-Ed-ak6NoX_4Aeg_337179872")]
    [Description(@"The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).")]
    Simple,
    
    /// <summary>
    /// The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.
    /// Encoded/decoded by serializers as "TXQV".
    /// </summary>
    [EnumMember(Value = "TXQV")]
    [IsoId("_VrUiEdp-Ed-ak6NoX_4Aeg_337179873")]
    [Description(@"The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.")]
    TaxEquivalent,
    
    /// <summary>
    /// The yield on a Municipal bond to its mandatory tender date.
    /// Encoded/decoded by serializers as "TTDT".
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_VrUiEtp-Ed-ak6NoX_4Aeg_337179874")]
    [Description(@"The yield on a Municipal bond to its mandatory tender date.")]
    ToTenderDate,
    
    /// <summary>
    /// The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.
    /// Encoded/decoded by serializers as "TRYL".
    /// </summary>
    [EnumMember(Value = "TRYL")]
    [IsoId("_VrUiE9p-Ed-ak6NoX_4Aeg_337179875")]
    [Description(@"The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.")]
    True,
    
    /// <summary>
    /// Yield Value Of 1/32 - The amount that the yield will change for a 1/32nd change in price.
    /// Encoded/decoded by serializers as "VALU".
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_VrUiFNp-Ed-ak6NoX_4Aeg_337179884")]
    [Description(@"Yield Value Of 1/32 - The amount that the yield will change for a 1/32nd change in price.")]
    Proportion,
    
    /// <summary>
    /// The lowest yield to all possible redemption date scenarios.
    /// Encoded/decoded by serializers as "WRST".
    /// </summary>
    [EnumMember(Value = "WRST")]
    [IsoId("_VrUiFdp-Ed-ak6NoX_4Aeg_337179885")]
    [Description(@"The lowest yield to all possible redemption date scenarios.")]
    ToWorstConvention,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class YieldTypeCodeMetadataExtensions
{
    private static readonly YieldTypeCodeDropdownSource _dropdownSource = new YieldTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IYieldTypeCodeDropdownRow GetMetadata(this YieldTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


