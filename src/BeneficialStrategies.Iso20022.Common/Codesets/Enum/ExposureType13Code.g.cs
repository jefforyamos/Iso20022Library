﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureType13Code.  ISO2002 ID# _pr4gLCgtEeyB747fKu7_rw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the exposure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pr4gLCgtEeyB747fKu7_rw")]
[Description(@"Specifies the underlying business area/type of trade causing the exposure.")]
[DerivedFrom(typeof(ExposureTypeV3Code))]
public enum ExposureType13Code
{
    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.
    /// Encoded/decoded by serializers as "CCIR".
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_Sr65cSgvEeyn17RQIQtLkQ")]
    [Description(@"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.")]
    CrossCurrencyIRS = ExposureTypeV3Code.CrossCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as "CRPR".
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_Sr65cygvEeyn17RQIQtLkQ")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeV3Code.CrossProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of equity.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_Sr65dSgvEeyn17RQIQtLkQ")]
    [Description(@"Trading of equity.")]
    Equity = ExposureTypeV3Code.Equity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as "EQPT".
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_Sr65dygvEeyn17RQIQtLkQ")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeV3Code.EquityOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as "EQUS".
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_Sr65eSgvEeyn17RQIQtLkQ")]
    [Description(@"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.")]
    EquitySwap = ExposureTypeV3Code.EquitySwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as "EXTD".
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_Sr65eygvEeyn17RQIQtLkQ")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeV3Code.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as "EXPT".
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_Sr65fSgvEeyn17RQIQtLkQ")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeV3Code.ExoticOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as "FIXI".
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_Sr65fygvEeyn17RQIQtLkQ")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeV3Code.FixedIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as "FORX".
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_Sr65gSgvEeyn17RQIQtLkQ")]
    [Description(@"FX trades in general.")]
    ForeignExchange = ExposureTypeV3Code.ForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as "FORW".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_Sr65gygvEeyn17RQIQtLkQ")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange = ExposureTypeV3Code.ForwardForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as "FUTR".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_Sr65hSgvEeyn17RQIQtLkQ")]
    [Description(@"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.")]
    Futures = ExposureTypeV3Code.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_Sr65hygvEeyn17RQIQtLkQ")]
    [Description(@"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.")]
    FXOption = ExposureTypeV3Code.FXOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as "LIQU".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_Sr65iSgvEeyn17RQIQtLkQ")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeV3Code.Liquidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Margin lending transaction. 
    /// Encoded/decoded by serializers as "MGLD".
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_Sr65iygvEeyn17RQIQtLkQ")]
    [Description(@"Margin lending transaction. ")]
    MarginLending = ExposureTypeV3Code.MarginLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as "OTCD".
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_Sr65jSgvEeyn17RQIQtLkQ")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeV3Code.OTCDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Sr65jygvEeyn17RQIQtLkQ")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeV3Code.RepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "RVPO".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_Sr65kSgvEeyn17RQIQtLkQ")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeV3Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as "SLOA".
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_Sr65kygvEeyn17RQIQtLkQ")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeV3Code.SecuredLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as "SBSC".
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_Sr65lSgvEeyn17RQIQtLkQ")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV3Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as "SCRP".
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_Sr65lygvEeyn17RQIQtLkQ")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeV3Code.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as "SLEB".
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_Sr65mSgvEeyn17RQIQtLkQ")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV3Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Short sell exposure.
    /// Encoded/decoded by serializers as "SHSL".
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_Sr65mygvEeyn17RQIQtLkQ")]
    [Description(@"Short sell exposure.")]
    ShortSell = ExposureTypeV3Code.ShortSell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as "SCIR".
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_Sr65nSgvEeyn17RQIQtLkQ")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeV3Code.SingleCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as "SCIE".
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_Sr65nygvEeyn17RQIQtLkQ")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeV3Code.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suggested credit line.
    /// Encoded/decoded by serializers as "ESCL".
    /// </summary>
    [EnumMember(Value = "ESCL")]
    [IsoId("_Sr65oSgvEeyn17RQIQtLkQ")]
    [Description(@"Suggested credit line.")]
    SuggestedCreditLine = ExposureTypeV3Code.SuggestedCreditLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as "SWPT".
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_Sr65oygvEeyn17RQIQtLkQ")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeV3Code.Swaption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as "TBAS".
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_Sr65pSgvEeyn17RQIQtLkQ")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeV3Code.ToBeAnnounced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total credit.
    /// Encoded/decoded by serializers as "ECRT".
    /// </summary>
    [EnumMember(Value = "ECRT")]
    [IsoId("_Sr65pygvEeyn17RQIQtLkQ")]
    [Description(@"Total credit.|")]
    TotalCredit = ExposureTypeV3Code.TotalCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total credit freezing.
    /// Encoded/decoded by serializers as "ECFR".
    /// </summary>
    [EnumMember(Value = "ECFR")]
    [IsoId("_Sr65qSgvEeyn17RQIQtLkQ")]
    [Description(@"Total credit freezing.")]
    TotalCreditFreezing = ExposureTypeV3Code.TotalCreditFreezing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total marginal lending.
    /// Encoded/decoded by serializers as "EMLO".
    /// </summary>
    [EnumMember(Value = "EMLO")]
    [IsoId("_Sr65qygvEeyn17RQIQtLkQ")]
    [Description(@"Total marginal lending.")]
    TotalMarginalLending = ExposureTypeV3Code.TotalMarginalLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total marginal lending interest.
    /// Encoded/decoded by serializers as "EMLI".
    /// </summary>
    [EnumMember(Value = "EMLI")]
    [IsoId("_Sr65rSgvEeyn17RQIQtLkQ")]
    [Description(@"Total marginal lending interest.")]
    TotalMarginalLendingInterest = ExposureTypeV3Code.TotalMarginalLendingInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total initial margin on outstanding liquidity providing open market operations.
    /// Encoded/decoded by serializers as "EOIM".
    /// </summary>
    [EnumMember(Value = "EOIM")]
    [IsoId("_Sr65rygvEeyn17RQIQtLkQ")]
    [Description(@"Total initial margin on outstanding liquidity providing open market operations.")]
    TotalInitialMarginOnOutstandingLiquidity = ExposureTypeV3Code.TotalInitialMarginOnOutstandingLiquidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total open market credit operations interest.
    /// Encoded/decoded by serializers as "EOMI".
    /// </summary>
    [EnumMember(Value = "EOMI")]
    [IsoId("_Sr65sSgvEeyn17RQIQtLkQ")]
    [Description(@"Total open market credit operations interest.")]
    TotalOpenMarketCreditOperationsInterest = ExposureTypeV3Code.TotalOpenMarketCreditOperationsInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of treasury bonds.
    /// Encoded/decoded by serializers as "TRBD".
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_Sr65sygvEeyn17RQIQtLkQ")]
    [Description(@"Trading of treasury bonds.")]
    TreasuryBonds = ExposureTypeV3Code.TreasuryBonds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as "BFWD".
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_Sr65tSgvEeyn17RQIQtLkQ")]
    [Description(@"Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.")]
    BondForward = ExposureTypeV3Code.BondForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_Sr65tygvEeyn17RQIQtLkQ")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeV3Code.CashSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as "CCPC".
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_Sr65uSgvEeyn17RQIQtLkQ")]
    [Description(@"Collateral covering the initial margin requirements for OTC trades cleared through a CCP.")]
    CCPCollateral = ExposureTypeV3Code.CCPCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_Sr65uygvEeyn17RQIQtLkQ")]
    [Description(@"Any good exchanged during commerce, which includes goods traded on a commodity exchange.")]
    Commodities = ExposureTypeV3Code.Commodities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as "CRDS".
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_Sr65vSgvEeyn17RQIQtLkQ")]
    [Description(@"Swap designed to transfer the credit exposure of fixed income products between parties.")]
    CreditDefaultSwap = ExposureTypeV3Code.CreditDefaultSwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as "CRTL".
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_Sr65vygvEeyn17RQIQtLkQ")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeV3Code.CreditLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as "CRSP".
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_Sr65wSgvEeyn17RQIQtLkQ")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeV3Code.CreditSupport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total open market credit operations.
    /// Encoded/decoded by serializers as "EOMO".
    /// </summary>
    [EnumMember(Value = "EOMO")]
    [IsoId("_Sr65wygvEeyn17RQIQtLkQ")]
    [Description(@"Total open market credit operations.|||")]
    TotalOpenMarketCreditOperations = ExposureTypeV3Code.TotalOpenMarketCreditOperations, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposures related to activity with central banks.
    /// Encoded/decoded by serializers as "CBCO".
    /// </summary>
    [EnumMember(Value = "CBCO")]
    [IsoId("_T9kukSgvEeyn17RQIQtLkQ")]
    [Description(@"Exposures related to activity with central banks.")]
    CentralBankCreditOperations = ExposureTypeV3Code.CentralBankCreditOperations, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as "TRCP".
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_Uxk-YSgvEeyn17RQIQtLkQ")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct = ExposureTypeV3Code.TreasuryCrossProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to uncleared derivative margin segregation. This could be for variation or initial margin.
    /// Encoded/decoded by serializers as "UDMS".
    /// </summary>
    [EnumMember(Value = "UDMS")]
    [IsoId("_VED1gSgvEeyn17RQIQtLkQ")]
    [Description(@"Relates to uncleared derivative margin segregation. This could be for variation or initial margin.")]
    UnclearedDerivativeMarginSegregation = ExposureTypeV3Code.UnclearedDerivativeMarginSegregation, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureType13CodeMetadataExtensions
{
    private static readonly ExposureType13CodeDropdownSource _dropdownSource = new ExposureType13CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureType13CodeDropdownRow GetMetadata(this ExposureType13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


