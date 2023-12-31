﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BenchmarkCurveName3Code.  ISO2002 ID# _wcX9QKx1Eem81-uIvTF5rQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wcX9QKx1Eem81-uIvTF5rQ")]
[Description(@"Specifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameCode))]
public enum BenchmarkCurveName3Code
{
    /// <summary>
    /// Euro Short Term Rate
    /// Encoded/decoded by serializers as "ESTER".
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_zGuDoax1Eem81-uIvTF5rQ")]
    [Description(@"Euro Short Term Rate")]
    ESTER,
    
    /// <summary>
    /// Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).
    /// Encoded/decoded by serializers as "BBSW".
    /// </summary>
    [EnumMember(Value = "BBSW")]
    [IsoId("_0dTcEax1Eem81-uIvTF5rQ")]
    [Description(@"Australian Financial Markets Association (AFMA) Bank-Bill Reference Rate (BBSW).")]
    BBSW,
    
    /// <summary>
    /// Budapest Interbank Offered Rate.
    /// Encoded/decoded by serializers as "BUBOR".
    /// </summary>
    [EnumMember(Value = "BUBO")]
    [IsoId("_08JUMax1Eem81-uIvTF5rQ")]
    [Description(@"Budapest Interbank Offered Rate.")]
    BUBOR,
    
    /// <summary>
    /// Canadian Dollar Offered Rate.
    /// Encoded/decoded by serializers as "CDOR".
    /// </summary>
    [EnumMember(Value = "CDOR")]
    [IsoId("_1JkFIax1Eem81-uIvTF5rQ")]
    [Description(@"Canadian Dollar Offered Rate.")]
    CDOR,
    
    /// <summary>
    /// Copenhagen Interbank Offered Rate.
    /// Encoded/decoded by serializers as "CIBOR".
    /// </summary>
    [EnumMember(Value = "CIBO")]
    [IsoId("_1Sf-sax1Eem81-uIvTF5rQ")]
    [Description(@"Copenhagen Interbank Offered Rate.")]
    CIBOR,
    
    /// <summary>
    /// Euro OverNight Index Average rate.
    /// Encoded/decoded by serializers as "EONIA".
    /// </summary>
    [EnumMember(Value = "EONA")]
    [IsoId("_1vtfIax1Eem81-uIvTF5rQ")]
    [Description(@"Euro OverNight Index Average rate.")]
    EONIA,
    
    /// <summary>
    /// Euro OverNight Index Average swap rate.
    /// Encoded/decoded by serializers as "EONIASwaps".
    /// </summary>
    [EnumMember(Value = "EONS")]
    [IsoId("_14NT0ax1Eem81-uIvTF5rQ")]
    [Description(@"Euro OverNight Index Average swap rate.")]
    EONIASwaps,
    
    /// <summary>
    /// Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.
    /// Encoded/decoded by serializers as "Euribor".
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_2QDMEax1Eem81-uIvTF5rQ")]
    [Description(@"Euro Interbank Offer Rate is the rate at which Euro inter-bank term deposits within the Euro zone are offered by one prime bank to another prime bank.")]
    Euribor,
    
    /// <summary>
    /// Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.
    /// Encoded/decoded by serializers as "EURODOLLAR".
    /// </summary>
    [EnumMember(Value = "EUUS")]
    [IsoId("_2kUL4ax1Eem81-uIvTF5rQ")]
    [Description(@"Rate for the eurodollars, time deposits denominated in U.S. dollars at banks outside the United States, and thus are not under the jurisdiction of the Federal Reserve.")]
    EURODOLLAR,
    
    /// <summary>
    /// Swiss Franc LIBOR rate.
    /// Encoded/decoded by serializers as "EuroSwiss".
    /// </summary>
    [EnumMember(Value = "EUCH")]
    [IsoId("_2s0Akax1Eem81-uIvTF5rQ")]
    [Description(@"Swiss Franc LIBOR rate.")]
    EuroSwiss,
    
    /// <summary>
    /// Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.
    /// Encoded/decoded by serializers as "FutureSWAP".
    /// </summary>
    [EnumMember(Value = "FUSW")]
    [IsoId("_3J3wAax1Eem81-uIvTF5rQ")]
    [Description(@"Portion of a synthetic curve that is composed of Eurodollar or Treasury or similar Futures and Swap rates. The term usually begins at 3 months to 2 years for the futures strip component with the Swaps filling in the points to 10 years and beyond.")]
    FutureSWAP,
    
    /// <summary>
    /// GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index.
    /// Encoded/decoded by serializers as "GCFRepo".
    /// </summary>
    [EnumMember(Value = "GCFR")]
    [IsoId("_3mezgax1Eem81-uIvTF5rQ")]
    [Description(@"GCF Repo Index, the Depository Trust & Clearing Corporation (DTCC) general collateral finance repurchase agreements index.")]
    GCFRepo,
    
    /// <summary>
    /// Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).
    /// Encoded/decoded by serializers as "ISDAFIX".
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_3_ODoax1Eem81-uIvTF5rQ")]
    [Description(@"Worldwide common reference rate value for fixed interest rate swap rates, as defined by the International Swaps and Derivatives Association (ISDA).")]
    ISDAFIX,
    
    /// <summary>
    /// Johannesburg Interbank Agreed Rate.
    /// Encoded/decoded by serializers as "JIBAR".
    /// </summary>
    [EnumMember(Value = "JIBA")]
    [IsoId("_4HkHUax1Eem81-uIvTF5rQ")]
    [Description(@"Johannesburg Interbank Agreed Rate.")]
    JIBAR,
    
    /// <summary>
    /// Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.
    /// 
    /// London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.
    /// Encoded/decoded by serializers as "LIBID".
    /// </summary>
    [EnumMember(Value = "LIBI")]
    [IsoId("_4VufIax1Eem81-uIvTF5rQ")]
    [Description(@"Rate at which major international banks are willing to take deposits from one another, is normally 1/8 percent below LIBOR.  London InterBank Bid Rate, the rate bid by banks on Eurocurrency deposits; the international rate that banks lend to other banks.")]
    LIBID,
    
    /// <summary>
    /// London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.
    /// Encoded/decoded by serializers as "LIBOR".
    /// </summary>
    [EnumMember(Value = "LIBO")]
    [IsoId("_4eXdwax1Eem81-uIvTF5rQ")]
    [Description(@"London Interbank Offered Rate, the interest rate that major international banks in London charge each other for borrowing.")]
    LIBOR,
    
    /// <summary>
    /// Moscow Prime Offered Rate.
    /// Encoded/decoded by serializers as "MOSPRIM".
    /// </summary>
    [EnumMember(Value = "MOSP")]
    [IsoId("_4tHrcax1Eem81-uIvTF5rQ")]
    [Description(@"Moscow Prime Offered Rate.")]
    MOSPRIM,
    
    /// <summary>
    /// Benchmark curve used for municipals based on the best credit rating for municipal market debt.
    /// Encoded/decoded by serializers as "MuniAAA".
    /// </summary>
    [EnumMember(Value = "MAAA")]
    [IsoId("_43270ax1Eem81-uIvTF5rQ")]
    [Description(@"Benchmark curve used for municipals based on the best credit rating for municipal market debt.")]
    MuniAAA,
    
    /// <summary>
    /// Norwegian Interbank Offered Rate.
    /// Encoded/decoded by serializers as "NIBOR".
    /// </summary>
    [EnumMember(Value = "NIBO")]
    [IsoId("_5QvV4ax1Eem81-uIvTF5rQ")]
    [Description(@"Norwegian Interbank Offered Rate.")]
    NIBOR,
    
    /// <summary>
    /// Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.
    /// Encoded/decoded by serializers as "Pfandbriefe".
    /// </summary>
    [EnumMember(Value = "PFAN")]
    [IsoId("_5ZYUgax1Eem81-uIvTF5rQ")]
    [Description(@"Pfandbriefe security is a collateralised bullet bond backed by either mortgage loans or loans to the public sector. Pfandbriefe differ from traditional asset-backed securities in significant ways. The most important difference is that Pfandbriefe carry no pre-payment risk since they remain on the balance sheet of the issuing institution. Therefore, their spreads over sovereign bonds are attributable to liquidity and credit quality alone. New indices have been created and existing indices have been modified in response to the growing importance of the Pfandbriefe market. The Deutsche Borse has three synthetic indices called REX, JEX, and PEX. The Pfandbriefe curve is used as a reference for credit as well as mortgage market.")]
    Pfandbriefe,
    
    /// <summary>
    /// Czech Fixing of Interest Rates on Interbank Deposits.
    /// Encoded/decoded by serializers as "PRIBOR".
    /// </summary>
    [EnumMember(Value = "PRBO")]
    [IsoId("_53Cg4ax1Eem81-uIvTF5rQ")]
    [Description(@"Czech Fixing of Interest Rates on Interbank Deposits.")]
    PRIBOR,
    
    /// <summary>
    /// Stockholm Interbank Offered Rate.
    /// Encoded/decoded by serializers as "STIBOR".
    /// </summary>
    [EnumMember(Value = "STBO")]
    [IsoId("_5_iVkax1Eem81-uIvTF5rQ")]
    [Description(@"Stockholm Interbank Offered Rate.")]
    STIBOR,
    
    /// <summary>
    /// In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.
    /// Encoded/decoded by serializers as "SWAP".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_6U_oMax1Eem81-uIvTF5rQ")]
    [Description(@"In curve construction, Swap is the long portion of the curve constituting about 3 years to 30 years term.||The exchange of one security, currency or interest rate for another to change the maturity (bonds), or quality of issues (stocks or bonds), or because investment objectives have changed.")]
    SWAP,
    
    /// <summary>
    /// Tel Aviv Interbank Offered Rate.
    /// Encoded/decoded by serializers as "TELBOR".
    /// </summary>
    [EnumMember(Value = "TLBO")]
    [IsoId("_6dom0ax1Eem81-uIvTF5rQ")]
    [Description(@"Tel Aviv Interbank Offered Rate.")]
    TELBOR,
    
    /// <summary>
    /// Tokyo Interbank Offered Rate.
    /// Encoded/decoded by serializers as "TIBOR".
    /// </summary>
    [EnumMember(Value = "TIBO")]
    [IsoId("_6silgax1Eem81-uIvTF5rQ")]
    [Description(@"Tokyo Interbank Offered Rate.")]
    TIBOR,
    
    /// <summary>
    /// Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.
    /// Encoded/decoded by serializers as "Treasury".
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_68MLEax1Eem81-uIvTF5rQ")]
    [Description(@"Treasury benchmark that comes in three types: the yield curve, the par curve, and the spot curve. All curves also have a constituent time series.")]
    Treasury,
    
    /// <summary>
    /// Warsaw Interbank Offered Rate.
    /// Encoded/decoded by serializers as "WIBOR".
    /// </summary>
    [EnumMember(Value = "WIBO")]
    [IsoId("_7FR1oax1Eem81-uIvTF5rQ")]
    [Description(@"Warsaw Interbank Offered Rate.")]
    WIBOR,
    
    /// <summary>
    /// Secured Overnight Financing Rate.
    /// Encoded/decoded by serializers as "SOFR".
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_a08SkbUMEemybd4mhF9NIA")]
    [Description(@"Secured Overnight Financing Rate.")]
    SOFR,
    
    /// <summary>
    /// Sterling Over Night Index Average.
    /// Encoded/decoded by serializers as "SONIA".
    /// </summary>
    [EnumMember(Value = "SONA")]
    [IsoId("_bNdgQbUMEemybd4mhF9NIA")]
    [Description(@"Sterling Over Night Index Average.")]
    SONIA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BenchmarkCurveName3CodeMetadataExtensions
{
    private static readonly BenchmarkCurveName3CodeDropdownSource _dropdownSource = new BenchmarkCurveName3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBenchmarkCurveName3CodeDropdownRow GetMetadata(this BenchmarkCurveName3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


