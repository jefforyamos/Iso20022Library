﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CalculationType1Code.  ISO2002 ID# _bVa-Jtp-Ed-ak6NoX_4Aeg_-2002254762.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the yield computation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVa-Jtp-Ed-ak6NoX_4Aeg_-2002254762")]
[Description(@"Specifies the yield computation method.")]
[DerivedFrom(typeof(CalculationTypeCode))]
public enum CalculationType1Code
{
    /// <summary>
    /// The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.
    /// Encoded/decoded by serializers as "AfterTax".
    /// </summary>
    [EnumMember(Value = "AFTX")]
    [IsoId("_bVa-J9p-Ed-ak6NoX_4Aeg_-1490623835")]
    [Description(@"The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.")]
    AfterTax,
    
    /// <summary>
    /// The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_bVa-KNp-Ed-ak6NoX_4Aeg_-1490623583")]
    [Description(@"The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value.")]
    Annual,
    
    /// <summary>
    /// The yield of the bond offered on the issue date.
    /// Encoded/decoded by serializers as "AtIssue".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_bVkvINp-Ed-ak6NoX_4Aeg_-1490623540")]
    [Description(@"The yield of the bond offered on the issue date.")]
    AtIssue,
    
    /// <summary>
    /// The yield achieved by substituting a bond's average maturity for the issue's final maturity date.
    /// Encoded/decoded by serializers as "ToAverageMaturity".
    /// </summary>
    [EnumMember(Value = "AVMA")]
    [IsoId("_bVkvIdp-Ed-ak6NoX_4Aeg_-1490623523")]
    [Description(@"The yield achieved by substituting a bond's average maturity for the issue's final maturity date.")]
    ToAverageMaturity,
    
    /// <summary>
    /// The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.
    /// Encoded/decoded by serializers as "Book".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bVkvItp-Ed-ak6NoX_4Aeg_-1490623480")]
    [Description(@"The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.")]
    Book,
    
    /// <summary>
    /// Yield of a bond to the next possible call date.
    /// Encoded/decoded by serializers as "YieldToNextCall".
    /// </summary>
    [EnumMember(Value = "YTNC")]
    [IsoId("_bVkvI9p-Ed-ak6NoX_4Aeg_-1490623445")]
    [Description(@"Yield of a bond to the next possible call date.")]
    YieldToNextCall,
    
    /// <summary>
    /// The change in the yield since the previous day's closing yield.
    /// Encoded/decoded by serializers as "ChangeSinceClose".
    /// </summary>
    [EnumMember(Value = "CHCL")]
    [IsoId("_bVkvJNp-Ed-ak6NoX_4Aeg_-1490623162")]
    [Description(@"The change in the yield since the previous day's closing yield.")]
    ChangeSinceClose,
    
    /// <summary>
    /// The yield of a bond based on the closing price.
    /// Encoded/decoded by serializers as "Closing".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_bVkvJdp-Ed-ak6NoX_4Aeg_-1490623120")]
    [Description(@"The yield of a bond based on the closing price.")]
    Closing,
    
    /// <summary>
    /// The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.
    /// Encoded/decoded by serializers as "Compound".
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_bVkvJtp-Ed-ak6NoX_4Aeg_-1490623059")]
    [Description(@"The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.")]
    Compound,
    
    /// <summary>
    /// The ratio of the interest payment amount to the clean price.
    /// Encoded/decoded by serializers as "CurrentYield".
    /// </summary>
    [EnumMember(Value = "CUYI")]
    [IsoId("_bVkvJ9p-Ed-ak6NoX_4Aeg_-1490623041")]
    [Description(@"The ratio of the interest payment amount to the clean price.")]
    CurrentYield,
    
    /// <summary>
    /// Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.
    /// Encoded/decoded by serializers as "TrueGross".
    /// </summary>
    [EnumMember(Value = "TRGR")]
    [IsoId("_bVkvKNp-Ed-ak6NoX_4Aeg_-1490623016")]
    [Description(@"Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.")]
    TrueGross,
    
    /// <summary>
    /// Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.
    /// Encoded/decoded by serializers as "GovernmentEquivalent".
    /// </summary>
    [EnumMember(Value = "GVEQ")]
    [IsoId("_bVkvKdp-Ed-ak6NoX_4Aeg_-1490622999")]
    [Description(@"Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.")]
    GovernmentEquivalent,
    
    /// <summary>
    /// Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.
    /// Encoded/decoded by serializers as "InflationAssumption".
    /// </summary>
    [EnumMember(Value = "FLAS")]
    [IsoId("_bVt5ENp-Ed-ak6NoX_4Aeg_-1490622981")]
    [Description(@"Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.")]
    InflationAssumption,
    
    /// <summary>
    /// Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.
    /// Encoded/decoded by serializers as "InverseFloater".
    /// </summary>
    [EnumMember(Value = "NVFL")]
    [IsoId("_bVt5Edp-Ed-ak6NoX_4Aeg_-1490622964")]
    [Description(@"Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.")]
    InverseFloater,
    
    /// <summary>
    /// Most Recent Closing Yield - The last available yield stored in history, computed using price.
    /// Encoded/decoded by serializers as "LastClose".
    /// </summary>
    [EnumMember(Value = "LSCL")]
    [IsoId("_bVt5Etp-Ed-ak6NoX_4Aeg_-1490622946")]
    [Description(@"Most Recent Closing Yield - The last available yield stored in history, computed using price.")]
    LastClose,
    
    /// <summary>
    /// Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end.
    /// Encoded/decoded by serializers as "LastMonth".
    /// </summary>
    [EnumMember(Value = "LSMT")]
    [IsoId("_bVt5E9p-Ed-ak6NoX_4Aeg_-1490622921")]
    [Description(@"Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end.")]
    LastMonth,
    
    /// <summary>
    /// Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end.
    /// Encoded/decoded by serializers as "LastQuarter".
    /// </summary>
    [EnumMember(Value = "LSQR")]
    [IsoId("_bVt5FNp-Ed-ak6NoX_4Aeg_-1490622904")]
    [Description(@"Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end.")]
    LastQuarter,
    
    /// <summary>
    /// Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end.
    /// Encoded/decoded by serializers as "LastYear".
    /// </summary>
    [EnumMember(Value = "LSYR")]
    [IsoId("_bVt5Fdp-Ed-ak6NoX_4Aeg_-1490622644")]
    [Description(@"Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end.")]
    LastYear,
    
    /// <summary>
    /// The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as "LongestAverageLife".
    /// </summary>
    [EnumMember(Value = "LGAL")]
    [IsoId("_bVt5Ftp-Ed-ak6NoX_4Aeg_-1490622627")]
    [Description(@"The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.")]
    LongestAverageLife,
    
    /// <summary>
    /// An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as "MarkToMarket".
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_bVt5F9p-Ed-ak6NoX_4Aeg_-1490622609")]
    [Description(@"An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.")]
    MarkToMarket,
    
    /// <summary>
    /// Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled.
    /// Encoded/decoded by serializers as "YieldToMaturity".
    /// </summary>
    [EnumMember(Value = "YTMA")]
    [IsoId("_bVt5GNp-Ed-ak6NoX_4Aeg_-1490622592")]
    [Description(@"Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled.")]
    YieldToMaturity,
    
    /// <summary>
    /// Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.
    /// Encoded/decoded by serializers as "ToNextRefund".
    /// </summary>
    [EnumMember(Value = "NXRF")]
    [IsoId("_bVt5Gdp-Ed-ak6NoX_4Aeg_-1490622574")]
    [Description(@"Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.")]
    ToNextRefund,
    
    /// <summary>
    /// The average yield of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as "OpenAverage".
    /// </summary>
    [EnumMember(Value = "PNAV")]
    [IsoId("_bVt5Gtp-Ed-ak6NoX_4Aeg_-1490622532")]
    [Description(@"The average yield of the respective securities in the portfolio.")]
    OpenAverage,
    
    /// <summary>
    /// The yield to the date at which the bond holder can next put the bond to the issuer.
    /// Encoded/decoded by serializers as "ToNextPut".
    /// </summary>
    [EnumMember(Value = "NXPT")]
    [IsoId("_bV3qENp-Ed-ak6NoX_4Aeg_-1490622514")]
    [Description(@"The yield to the date at which the bond holder can next put the bond to the issuer.")]
    ToNextPut,
    
    /// <summary>
    /// The yield of a bond based on the closing price 1 day ago.
    /// Encoded/decoded by serializers as "PreviousClose".
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_bV3qEdp-Ed-ak6NoX_4Aeg_-1490622472")]
    [Description(@"The yield of a bond based on the closing price 1 day ago.")]
    PreviousClose,
    
    /// <summary>
    /// The CD equivalent yield when the remaining time to maturity is less than two years.
    /// Encoded/decoded by serializers as "Proceeds".
    /// </summary>
    [EnumMember(Value = "PRYL")]
    [IsoId("_bV3qEtp-Ed-ak6NoX_4Aeg_-1490622206")]
    [Description(@"The CD equivalent yield when the remaining time to maturity is less than two years.")]
    Proceeds,
    
    /// <summary>
    /// The yield of a bond whose coupon payments are reinvested semi-annually.
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_bV3qE9p-Ed-ak6NoX_4Aeg_-1490622171")]
    [Description(@"The yield of a bond whose coupon payments are reinvested semi-annually.")]
    SemiAnnual,
    
    /// <summary>
    /// The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.
    /// Encoded/decoded by serializers as "ShortestAverageLife".
    /// </summary>
    [EnumMember(Value = "SHLF")]
    [IsoId("_bV3qFNp-Ed-ak6NoX_4Aeg_-1490622146")]
    [Description(@"The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.")]
    ShortestAverageLife,
    
    /// <summary>
    /// The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).
    /// Encoded/decoded by serializers as "Simple".
    /// </summary>
    [EnumMember(Value = "SPLL")]
    [IsoId("_bV3qFdp-Ed-ak6NoX_4Aeg_-1490622111")]
    [Description(@"The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).")]
    Simple,
    
    /// <summary>
    /// The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.
    /// Encoded/decoded by serializers as "TaxEquivalent".
    /// </summary>
    [EnumMember(Value = "TXQV")]
    [IsoId("_bV3qFtp-Ed-ak6NoX_4Aeg_-1490622086")]
    [Description(@"The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.")]
    TaxEquivalent,
    
    /// <summary>
    /// The yield on a Municipal bond to its mandatory tender date.
    /// Encoded/decoded by serializers as "ToTenderDate".
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_bV3qF9p-Ed-ak6NoX_4Aeg_-1490622051")]
    [Description(@"The yield on a Municipal bond to its mandatory tender date.")]
    ToTenderDate,
    
    /// <summary>
    /// The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.
    /// Encoded/decoded by serializers as "True".
    /// </summary>
    [EnumMember(Value = "TRYL")]
    [IsoId("_bV3qGNp-Ed-ak6NoX_4Aeg_-1490622016")]
    [Description(@"The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.")]
    True,
    
    /// <summary>
    /// The lowest yield to all possible redemption date scenarios.
    /// Encoded/decoded by serializers as "ToWorstConvention".
    /// </summary>
    [EnumMember(Value = "WRST")]
    [IsoId("_bV3qGdp-Ed-ak6NoX_4Aeg_-1490621991")]
    [Description(@"The lowest yield to all possible redemption date scenarios.")]
    ToWorstConvention,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CalculationType1CodeMetadataExtensions
{
    private static readonly CalculationType1CodeDropdownSource _dropdownSource = new CalculationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICalculationType1CodeDropdownRow GetMetadata(this CalculationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


