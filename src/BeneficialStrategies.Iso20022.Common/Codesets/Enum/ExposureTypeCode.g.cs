﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureTypeCode.  ISO2002 ID# _alvNodp-Ed-ak6NoX_4Aeg_1976296742.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Short sale exposure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_alvNodp-Ed-ak6NoX_4Aeg_1976296742")]
[Description(@"Short sale exposure.")]
public enum ExposureTypeCode
{
    /// <summary>
    /// Cross currency interest rate swap.
    /// Encoded/decoded by serializers as "CCIR".
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_alvNotp-Ed-ak6NoX_4Aeg_1862457676")]
    [Description(@"Cross currency interest rate swap.")]
    CrossCurrencyIRS,
    
    /// <summary>
    /// Trading of exchanged traded commodities.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_alvNo9p-Ed-ak6NoX_4Aeg_687266651")]
    [Description(@"Trading of exchanged traded commodities.")]
    Commodities,
    
    /// <summary>
    /// Trading of credit default swap.
    /// Encoded/decoded by serializers as "CRDS".
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_alvNpNp-Ed-ak6NoX_4Aeg_-17847964")]
    [Description(@"Trading of credit default swap.")]
    CreditDefaultSwap,
    
    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as "CRPR".
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_alvNpdp-Ed-ak6NoX_4Aeg_1627419471")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct,
    
    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as "CRSP".
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_alvNptp-Ed-ak6NoX_4Aeg_-1128759383")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport,
    
    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as "CRTL".
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_alvNp9p-Ed-ak6NoX_4Aeg_1991016888")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine,
    
    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as "EQPT".
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_alvNqNp-Ed-ak6NoX_4Aeg_1285902273")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption,
    
    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as "EQUS".
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_al4-oNp-Ed-ak6NoX_4Aeg_-1363797588")]
    [Description(@"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.")]
    EquitySwap,
    
    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as "EXPT".
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_al4-odp-Ed-ak6NoX_4Aeg_174990854")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption,
    
    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as "EXTD".
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_al4-otp-Ed-ak6NoX_4Aeg_-1000200171")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives,
    
    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as "FIXI".
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_al4-o9p-Ed-ak6NoX_4Aeg_-1705314786")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome,
    
    /// <summary>
    /// Forward foreign exchange trades.
    /// Encoded/decoded by serializers as "FORW".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_al4-pNp-Ed-ak6NoX_4Aeg_-60047351")]
    [Description(@"Forward foreign exchange trades.")]
    ForwardForeignExchange,
    
    /// <summary>
    /// Foreign exchange trades in general.
    /// Encoded/decoded by serializers as "FORX".
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_al4-pdp-Ed-ak6NoX_4Aeg_1478741091")]
    [Description(@"Foreign exchange trades in general.")]
    ForeignExchange,
    
    /// <summary>
    /// Related to futures trading activity.
    /// Encoded/decoded by serializers as "FUTR".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_al4-ptp-Ed-ak6NoX_4Aeg_303550066")]
    [Description(@"Related to futures trading activity.")]
    Futures,
    
    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as "LIQU".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_al4-p9p-Ed-ak6NoX_4Aeg_-401564549")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity,
    
    /// <summary>
    /// Related to options trading activity.
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_al4-qNp-Ed-ak6NoX_4Aeg_1243702886")]
    [Description(@"Related to options trading activity.")]
    FXOption,
    
    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as "OTCD".
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_al4-qdp-Ed-ak6NoX_4Aeg_-1512475968")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives,
    
    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_amCIkNp-Ed-ak6NoX_4Aeg_1607300303")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement,
    
    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_amCIkdp-Ed-ak6NoX_4Aeg_902185688")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement,
    
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as "SBSC".
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_amCIktp-Ed-ak6NoX_4Aeg_-1747514173")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack,
    
    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as "SCIE".
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_amCIk9p-Ed-ak6NoX_4Aeg_-208725731")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic,
    
    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as "SCIR".
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_amCIlNp-Ed-ak6NoX_4Aeg_-1383916756")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS,
    
    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as "SCRP".
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_amCIldp-Ed-ak6NoX_4Aeg_-2089031371")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts,
    
    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as "SLEB".
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_amCIltp-Ed-ak6NoX_4Aeg_-443763936")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing,
    
    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as "SLOA".
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_amCIl9p-Ed-ak6NoX_4Aeg_-592442316")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan,
    
    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as "SWPT".
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_amCImNp-Ed-ak6NoX_4Aeg_-1767633341")]
    [Description(@"Option on interest rate swap.")]
    Swaption,
    
    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as "TRCP".
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_amCImdp-Ed-ak6NoX_4Aeg_1822219340")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCorssProduct,
    
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as "BFWD".
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_amCImtp-Ed-ak6NoX_4Aeg_591085066")]
    [Description(@"Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.")]
    BondForward,
    
    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "RVPO".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_amL5kNp-Ed-ak6NoX_4Aeg_1899573656")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as "TBAS".
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_amL5kdp-Ed-ak6NoX_4Aeg_-859846379")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced,
    
    /// <summary>
    /// Short sale exposure.
    /// Encoded/decoded by serializers as "SHSL".
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_Ci-qQNtlEd-RF5yaMAVhAw")]
    [Description(@"Short sale exposure.")]
    ShortSell,
    
    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as "CCPC".
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_53RykCT2EeOSHvJr_wacAw")]
    [Description(@"Collateral covering the initial margin requirements for OTC trades cleared through a CCP.")]
    CCPCollateral,
    
    /// <summary>
    /// Trading of equity.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_0ATnMWNgEeSLD8nyfZcLzQ")]
    [Description(@"Trading of equity.")]
    Equity,
    
    /// <summary>
    /// Trading of treasury bonds.
    /// Encoded/decoded by serializers as "TRBD".
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_4LEXcWNgEeSLD8nyfZcLzQ")]
    [Description(@"Trading of treasury bonds.")]
    TreasuryBonds,
    
    /// <summary>
    /// Margin lending transaction. 
    /// Encoded/decoded by serializers as "MGLD".
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_KSx3gHaaEeavseMKyTsJEA")]
    [Description(@"Margin lending transaction. ")]
    MarginLending,
    
    /// <summary>
    /// Total open market credit operations.
    /// 
    /// 
    /// 
    /// Encoded/decoded by serializers as "EOMO".
    /// </summary>
    [EnumMember(Value = "EOMO")]
    [IsoId("_jq-3sALsEeutW5-TpeYJhA")]
    [Description(@"Total open market credit operations.   ")]
    TotalOpenMarketCreditOperations,
    
    /// <summary>
    /// Total open market credit operations interest.
    /// Encoded/decoded by serializers as "EOMI".
    /// </summary>
    [EnumMember(Value = "EOMI")]
    [IsoId("_9YafMALsEeutW5-TpeYJhA")]
    [Description(@"Total open market credit operations interest.")]
    TotalOpenMarketCreditOperationsInterest,
    
    /// <summary>
    /// Total initial margin on outstanding liquidity providing open market operations.
    /// Encoded/decoded by serializers as "EOIM".
    /// </summary>
    [EnumMember(Value = "EOIM")]
    [IsoId("_HP9MEALtEeutW5-TpeYJhA")]
    [Description(@"Total initial margin on outstanding liquidity providing open market operations.")]
    TotalInitialMarginOnOutstandingLiquidity,
    
    /// <summary>
    /// Total credit freezing.
    /// Encoded/decoded by serializers as "ECFR".
    /// </summary>
    [EnumMember(Value = "ECFR")]
    [IsoId("_SJs80ALtEeutW5-TpeYJhA")]
    [Description(@"Total credit freezing.")]
    TotalCreditFreezing,
    
    /// <summary>
    /// Total marginal lending.
    /// Encoded/decoded by serializers as "EMLO".
    /// </summary>
    [EnumMember(Value = "EMLO")]
    [IsoId("_aDrJwALtEeutW5-TpeYJhA")]
    [Description(@"Total marginal lending.")]
    TotalMarginalLending,
    
    /// <summary>
    /// Total marginal lending interest.
    /// Encoded/decoded by serializers as "EMLI".
    /// </summary>
    [EnumMember(Value = "EMLI")]
    [IsoId("_ha2LoALtEeutW5-TpeYJhA")]
    [Description(@"Total marginal lending interest.")]
    TotalMarginalLendingInterest,
    
    /// <summary>
    /// Total credit.
    /// 
    /// Encoded/decoded by serializers as "ECRT".
    /// </summary>
    [EnumMember(Value = "ECRT")]
    [IsoId("_pQzbQALtEeutW5-TpeYJhA")]
    [Description(@"Total credit. ")]
    TotalCredit,
    
    /// <summary>
    /// Suggested credit line.
    /// Encoded/decoded by serializers as "ESCL".
    /// </summary>
    [EnumMember(Value = "ESCL")]
    [IsoId("_wNe5gALtEeutW5-TpeYJhA")]
    [Description(@"Suggested credit line.")]
    SuggestedCreditLine,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureTypeCodeMetadataExtensions
{
    private static readonly ExposureTypeCodeDropdownSource _dropdownSource = new ExposureTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureTypeCodeDropdownRow GetMetadata(this ExposureTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

