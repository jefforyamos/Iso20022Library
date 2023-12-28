﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialAssetBalanceType1Code.  ISO2002 ID# _m2iQ5fNBEeCuA5Tr22BnwA_1714463594.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies balances of assets and other balances.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m2iQ5fNBEeCuA5Tr22BnwA_1714463594")]
[Description(@"Specifies balances of assets and other balances.")]
[DerivedFrom(typeof(FinancialAssetBalanceTypeCode))]
public enum FinancialAssetBalanceType1Code
{
    /// <summary>
    /// Balance attributed to accrued income.
    /// Encoded/decoded by serializers as "AccruedIncome".
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_m2iQ5vNBEeCuA5Tr22BnwA_2145931339")]
    [Description(@"Balance attributed to accrued income.")]
    AccruedIncome,
    
    /// <summary>
    /// Balance attributed to other financial instruments.
    /// Encoded/decoded by serializers as "OtherFinancialInstruments".
    /// </summary>
    [EnumMember(Value = "OINT")]
    [IsoId("_m2iQ5_NBEeCuA5Tr22BnwA_2042814364")]
    [Description(@"Balance attributed to other financial instruments.")]
    OtherFinancialInstruments,
    
    /// <summary>
    /// Balance attributed to settled cash.
    /// Encoded/decoded by serializers as "SettledCash".
    /// </summary>
    [EnumMember(Value = "SCAS")]
    [IsoId("_m2iQ6PNBEeCuA5Tr22BnwA_-1973145424")]
    [Description(@"Balance attributed to settled cash.")]
    SettledCash,
    
    /// <summary>
    /// Balance attributed to foreign exchange profit or loss.
    /// Encoded/decoded by serializers as "FXTransaction".
    /// </summary>
    [EnumMember(Value = "FXTR")]
    [IsoId("_m2iQ6fNBEeCuA5Tr22BnwA_950545386")]
    [Description(@"Balance attributed to foreign exchange profit or loss.")]
    FXTransaction,
    
    /// <summary>
    /// Balance attributed to cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_m2sB4PNBEeCuA5Tr22BnwA_-1189505753")]
    [Description(@"Balance attributed to cash.")]
    Cash,
    
    /// <summary>
    /// Balance attributed to treasury inflated protected securities.
    /// Encoded/decoded by serializers as "TreasuryInflatedProtectedSecurity".
    /// </summary>
    [EnumMember(Value = "TIPS")]
    [IsoId("_m2sB4fNBEeCuA5Tr22BnwA_-1331831802")]
    [Description(@"Balance attributed to treasury inflated protected securities.")]
    TreasuryInflatedProtectedSecurity,
    
    /// <summary>
    /// Balance attributed to equities.
    /// Encoded/decoded by serializers as "Equity".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_m2sB4vNBEeCuA5Tr22BnwA_475154614")]
    [Description(@"Balance attributed to equities.")]
    Equity,
    
    /// <summary>
    /// Balance attributed to common stock.
    /// Encoded/decoded by serializers as "CommonStock".
    /// </summary>
    [EnumMember(Value = "CSTK")]
    [IsoId("_m2sB4_NBEeCuA5Tr22BnwA_987430411")]
    [Description(@"Balance attributed to common stock.")]
    CommonStock,
    
    /// <summary>
    /// Balance attributed to preferred stock.
    /// Encoded/decoded by serializers as "PreferredStock".
    /// </summary>
    [EnumMember(Value = "PREF")]
    [IsoId("_m2sB5PNBEeCuA5Tr22BnwA_1161829606")]
    [Description(@"Balance attributed to preferred stock.")]
    PreferredStock,
    
    /// <summary>
    /// Balance attributed to mutual funds.
    /// Encoded/decoded by serializers as "MutualFund".
    /// </summary>
    [EnumMember(Value = "MFUN")]
    [IsoId("_m2sB5fNBEeCuA5Tr22BnwA_1486947113")]
    [Description(@"Balance attributed to mutual funds.")]
    MutualFund,
    
    /// <summary>
    /// Balance attributed to exchange traded funds.
    /// Encoded/decoded by serializers as "ExchangeTradedFund".
    /// </summary>
    [EnumMember(Value = "XFUN")]
    [IsoId("_m21y4PNBEeCuA5Tr22BnwA_603713826")]
    [Description(@"Balance attributed to exchange traded funds.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Balance attributed to rights.
    /// Encoded/decoded by serializers as "Rights".
    /// </summary>
    [EnumMember(Value = "RGHT")]
    [IsoId("_m21y4fNBEeCuA5Tr22BnwA_-1844107599")]
    [Description(@"Balance attributed to rights.")]
    Rights,
    
    /// <summary>
    /// Balance attributed to warrants.
    /// Encoded/decoded by serializers as "Warrant".
    /// </summary>
    [EnumMember(Value = "WARR")]
    [IsoId("_m21y4vNBEeCuA5Tr22BnwA_313435633")]
    [Description(@"Balance attributed to warrants.")]
    Warrant,
    
    /// <summary>
    /// Balance attributed to bonds.
    /// Encoded/decoded by serializers as "Bond".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_m21y4_NBEeCuA5Tr22BnwA_-2037864427")]
    [Description(@"Balance attributed to bonds.")]
    Bond,
    
    /// <summary>
    /// Balance attributed to convertible bonds.
    /// Encoded/decoded by serializers as "ConvertibleBond".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_m21y5PNBEeCuA5Tr22BnwA_1530826045")]
    [Description(@"Balance attributed to convertible bonds.")]
    ConvertibleBond,
    
    /// <summary>
    /// Balance attributed to corporate bonds.
    /// Encoded/decoded by serializers as "CorporateBond".
    /// </summary>
    [EnumMember(Value = "CBND")]
    [IsoId("_m21y5fNBEeCuA5Tr22BnwA_662312904")]
    [Description(@"Balance attributed to corporate bonds.")]
    CorporateBond,
    
    /// <summary>
    /// Balance attributed to government bonds.
    /// Encoded/decoded by serializers as "GovernmentBond".
    /// </summary>
    [EnumMember(Value = "GBND")]
    [IsoId("_m21y5vNBEeCuA5Tr22BnwA_-123481008")]
    [Description(@"Balance attributed to government bonds.")]
    GovernmentBond,
    
    /// <summary>
    /// Balance attributed to options.
    /// Encoded/decoded by serializers as "Option".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_m2-80PNBEeCuA5Tr22BnwA_-1460391014")]
    [Description(@"Balance attributed to options.")]
    Option,
    
    /// <summary>
    /// Balance attributed to futures.
    /// Encoded/decoded by serializers as "Future".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_m2-80fNBEeCuA5Tr22BnwA_-1116076312")]
    [Description(@"Balance attributed to futures.")]
    Future,
    
    /// <summary>
    /// Balance attributed to swaps.
    /// Encoded/decoded by serializers as "Swap".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_m2-80vNBEeCuA5Tr22BnwA_-146898457")]
    [Description(@"Balance attributed to swaps.")]
    Swap,
    
    /// <summary>
    /// Balance attributed to currency exchange contracts.
    /// Encoded/decoded by serializers as "CurrencyExchange".
    /// </summary>
    [EnumMember(Value = "CUEX")]
    [IsoId("_m2-80_NBEeCuA5Tr22BnwA_6757749")]
    [Description(@"Balance attributed to currency exchange contracts.")]
    CurrencyExchange,
    
    /// <summary>
    /// Balance attributed to foreign investments.
    /// Encoded/decoded by serializers as "ForeignInvestment".
    /// </summary>
    [EnumMember(Value = "FOIV")]
    [IsoId("_m2-81PNBEeCuA5Tr22BnwA_489874760")]
    [Description(@"Balance attributed to foreign investments.")]
    ForeignInvestment,
    
    /// <summary>
    /// Balance attributed to gold.
    /// Encoded/decoded by serializers as "Gold".
    /// </summary>
    [EnumMember(Value = "GOLD")]
    [IsoId("_m2-81fNBEeCuA5Tr22BnwA_-413073108")]
    [Description(@"Balance attributed to gold.")]
    Gold,
    
    /// <summary>
    /// Balance attributed to property.
    /// Encoded/decoded by serializers as "Property".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_m3It0PNBEeCuA5Tr22BnwA_-93356983")]
    [Description(@"Balance attributed to property.")]
    Property,
    
    /// <summary>
    /// Balance attributed to bankers acceptances.
    /// Encoded/decoded by serializers as "BankersAcceptance".
    /// </summary>
    [EnumMember(Value = "BAAP")]
    [IsoId("_m3It0fNBEeCuA5Tr22BnwA_-1924025361")]
    [Description(@"Balance attributed to bankers acceptances.")]
    BankersAcceptance,
    
    /// <summary>
    /// Balance attributed to syndicated bank loans.
    /// Encoded/decoded by serializers as "SyndicatedBankLoan".
    /// </summary>
    [EnumMember(Value = "SYBL")]
    [IsoId("_m3It0vNBEeCuA5Tr22BnwA_-463318661")]
    [Description(@"Balance attributed to syndicated bank loans.")]
    SyndicatedBankLoan,
    
    /// <summary>
    /// Balance attributed to collateralised bond obligations.
    /// Encoded/decoded by serializers as "CollateralisedBondObligation".
    /// </summary>
    [EnumMember(Value = "CBOO")]
    [IsoId("_m3It0_NBEeCuA5Tr22BnwA_566913461")]
    [Description(@"Balance attributed to collateralised bond obligations.")]
    CollateralisedBondObligation,
    
    /// <summary>
    /// Balance attributed to certificates of deposits.
    /// Encoded/decoded by serializers as "CertificateOfDeposit".
    /// </summary>
    [EnumMember(Value = "CEOD")]
    [IsoId("_m3It1PNBEeCuA5Tr22BnwA_331875256")]
    [Description(@"Balance attributed to certificates of deposits.")]
    CertificateOfDeposit,
    
    /// <summary>
    /// Balance attributed to collateralised debt obligations.
    /// Encoded/decoded by serializers as "CollateralisedDebtObligation".
    /// </summary>
    [EnumMember(Value = "CDEO")]
    [IsoId("_m3It1fNBEeCuA5Tr22BnwA_1328947609")]
    [Description(@"Balance attributed to collateralised debt obligations.")]
    CollateralisedDebtObligation,
    
    /// <summary>
    /// Balance attributed to collateralised loan obligations.
    /// Encoded/decoded by serializers as "CollateralisedLoanObligation".
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_m3It1vNBEeCuA5Tr22BnwA_-1810947830")]
    [Description(@"Balance attributed to collateralised loan obligations.")]
    CollateralisedLoanObligation,
    
    /// <summary>
    /// Balance attributed to collateralised mortgage obligations.
    /// Encoded/decoded by serializers as "CollateralisedMortgageObligation".
    /// </summary>
    [EnumMember(Value = "CMOO")]
    [IsoId("_m3Se0PNBEeCuA5Tr22BnwA_-1791739243")]
    [Description(@"Balance attributed to collateralised mortgage obligations.")]
    CollateralisedMortgageObligation,
    
    /// <summary>
    /// Balance attributed to commercial paper.
    /// Encoded/decoded by serializers as "CommericalPaper".
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_m3Se0fNBEeCuA5Tr22BnwA_-828595623")]
    [Description(@"Balance attributed to commercial paper.")]
    CommericalPaper,
    
    /// <summary>
    /// Balance attributed to corporate private placements.
    /// Encoded/decoded by serializers as "CorporatePrivatePlacement".
    /// </summary>
    [EnumMember(Value = "CPPE")]
    [IsoId("_m3Se0vNBEeCuA5Tr22BnwA_-448598515")]
    [Description(@"Balance attributed to corporate private placements.")]
    CorporatePrivatePlacement,
    
    /// <summary>
    /// Balance attributed to discount notes.
    /// Encoded/decoded by serializers as "DiscountNote".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_m3Se0_NBEeCuA5Tr22BnwA_1545546191")]
    [Description(@"Balance attributed to discount notes.")]
    DiscountNote,
    
    /// <summary>
    /// Balance attributed to federal agency discount notes.
    /// Encoded/decoded by serializers as "FederalAgencyDiscountNote".
    /// </summary>
    [EnumMember(Value = "FEAD")]
    [IsoId("_m3Se1PNBEeCuA5Tr22BnwA_1852224075")]
    [Description(@"Balance attributed to federal agency discount notes.")]
    FederalAgencyDiscountNote,
    
    /// <summary>
    /// Balance attributed to federal housing authorities.
    /// Encoded/decoded by serializers as "FederalHousingAuthority".
    /// </summary>
    [EnumMember(Value = "FEHA")]
    [IsoId("_m3bowPNBEeCuA5Tr22BnwA_-700036411")]
    [Description(@"Balance attributed to federal housing authorities.")]
    FederalHousingAuthority,
    
    /// <summary>
    /// Balance attributed to federal home loans.
    /// Encoded/decoded by serializers as "FederalHomeLoan".
    /// </summary>
    [EnumMember(Value = "FEHL")]
    [IsoId("_m3bowfNBEeCuA5Tr22BnwA_855151722")]
    [Description(@"Balance attributed to federal home loans.")]
    FederalHomeLoan,
    
    /// <summary>
    /// Balance attributed to federal national mortgage associations.
    /// Encoded/decoded by serializers as "FederalNationalMortgageAssociation".
    /// </summary>
    [EnumMember(Value = "FNMA")]
    [IsoId("_m3bowvNBEeCuA5Tr22BnwA_-1135273507")]
    [Description(@"Balance attributed to federal national mortgage associations.")]
    FederalNationalMortgageAssociation,
    
    /// <summary>
    /// Balance attributed to floating rate notes.
    /// Encoded/decoded by serializers as "FloatingRateNote".
    /// </summary>
    [EnumMember(Value = "FLNO")]
    [IsoId("_m3bow_NBEeCuA5Tr22BnwA_1088991431")]
    [Description(@"Balance attributed to floating rate notes.")]
    FloatingRateNote,
    
    /// <summary>
    /// Balance attributed to the government national mortgage association.
    /// Encoded/decoded by serializers as "GovernmentNationalMortgageAssociation".
    /// </summary>
    [EnumMember(Value = "GNMA")]
    [IsoId("_m3boxPNBEeCuA5Tr22BnwA_-9641942")]
    [Description(@"Balance attributed to the government national mortgage association.")]
    GovernmentNationalMortgageAssociation,
    
    /// <summary>
    /// Balance attributed to treasuries and agencies debentures.
    /// Encoded/decoded by serializers as "TreasuriesAndAgenciesDebentures".
    /// </summary>
    [EnumMember(Value = "TAAB")]
    [IsoId("_m3boxfNBEeCuA5Tr22BnwA_260235577")]
    [Description(@"Balance attributed to treasuries and agencies debentures.")]
    TreasuriesAndAgenciesDebentures,
    
    /// <summary>
    /// Balance attributed to IOETTE mortgages.
    /// Encoded/decoded by serializers as "IOETTEMortgage".
    /// </summary>
    [EnumMember(Value = "IETM")]
    [IsoId("_m3boxvNBEeCuA5Tr22BnwA_355635020")]
    [Description(@"Balance attributed to IOETTE mortgages.")]
    IOETTEMortgage,
    
    /// <summary>
    /// Balance attributed to mortgage private placements.
    /// Encoded/decoded by serializers as "MortgagePrivatePlacement".
    /// </summary>
    [EnumMember(Value = "MPRP")]
    [IsoId("_m3lZwPNBEeCuA5Tr22BnwA_-1441951391")]
    [Description(@"Balance attributed to mortgage private placements.")]
    MortgagePrivatePlacement,
    
    /// <summary>
    /// Balance attributed to municipal bonds.
    /// Encoded/decoded by serializers as "MunicipalBond".
    /// </summary>
    [EnumMember(Value = "MBON")]
    [IsoId("_m3lZwfNBEeCuA5Tr22BnwA_1003830102")]
    [Description(@"Balance attributed to municipal bonds.")]
    MunicipalBond,
    
    /// <summary>
    /// Balance attributed to student loan marketing associations.
    /// Encoded/decoded by serializers as "StudentLoanMarketingAssociation".
    /// </summary>
    [EnumMember(Value = "SLMA")]
    [IsoId("_m3lZwvNBEeCuA5Tr22BnwA_1563985814")]
    [Description(@"Balance attributed to student loan marketing associations.")]
    StudentLoanMarketingAssociation,
    
    /// <summary>
    /// Balance attributed to short term investment funds.
    /// Encoded/decoded by serializers as "ShortTermInvestmentFund".
    /// </summary>
    [EnumMember(Value = "STIF")]
    [IsoId("_m3lZw_NBEeCuA5Tr22BnwA_873591345")]
    [Description(@"Balance attributed to short term investment funds.")]
    ShortTermInvestmentFund,
    
    /// <summary>
    /// Balance attributed to treasury strips.
    /// Encoded/decoded by serializers as "TreasuryStrips".
    /// </summary>
    [EnumMember(Value = "TSTP")]
    [IsoId("_m3lZxPNBEeCuA5Tr22BnwA_-28081565")]
    [Description(@"Balance attributed to treasury strips.")]
    TreasuryStrips,
    
    /// <summary>
    /// Balance attributed to time deposits.
    /// Encoded/decoded by serializers as "TimeDeposit".
    /// </summary>
    [EnumMember(Value = "TIDE")]
    [IsoId("_m3lZxfNBEeCuA5Tr22BnwA_-141920631")]
    [Description(@"Balance attributed to time deposits.")]
    TimeDeposit,
    
    /// <summary>
    /// Balance attributed to unitized bonds and warrants.
    /// Encoded/decoded by serializers as "UnitizedBondsAndWarrants".
    /// </summary>
    [EnumMember(Value = "UNBW")]
    [IsoId("_m3ujsPNBEeCuA5Tr22BnwA_-813875477")]
    [Description(@"Balance attributed to unitized bonds and warrants.")]
    UnitizedBondsAndWarrants,
    
    /// <summary>
    /// Balance attributed to unitized bonds.
    /// Encoded/decoded by serializers as "UnitizedBonds".
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_m3ujsfNBEeCuA5Tr22BnwA_1022269725")]
    [Description(@"Balance attributed to unitized bonds.")]
    UnitizedBonds,
    
    /// <summary>
    /// Balance attributed to variable rate discount notes.
    /// Encoded/decoded by serializers as "VariableRateDiscountNote".
    /// </summary>
    [EnumMember(Value = "VRDN")]
    [IsoId("_m3ujsvNBEeCuA5Tr22BnwA_-1355591566")]
    [Description(@"Balance attributed to variable rate discount notes.")]
    VariableRateDiscountNote,
    
    /// <summary>
    /// Balance attributed to cats, lions and tigers.
    /// Encoded/decoded by serializers as "CatsTigersLions".
    /// </summary>
    [EnumMember(Value = "ZOOO")]
    [IsoId("_m3ujs_NBEeCuA5Tr22BnwA_1600786179")]
    [Description(@"Balance attributed to cats, lions and tigers.")]
    CatsTigersLions,
    
    /// <summary>
    /// Balance attributed to forwards - bonds.
    /// Encoded/decoded by serializers as "ForwardBonds".
    /// </summary>
    [EnumMember(Value = "FWBO")]
    [IsoId("_m3ujtPNBEeCuA5Tr22BnwA_-1697108764")]
    [Description(@"Balance attributed to forwards - bonds.")]
    ForwardBonds,
    
    /// <summary>
    /// Balance attributed to forward rate agreements.
    /// Encoded/decoded by serializers as "ForwardRateAgreement".
    /// </summary>
    [EnumMember(Value = "FRAG")]
    [IsoId("_m3ujtfNBEeCuA5Tr22BnwA_-299920135")]
    [Description(@"Balance attributed to forward rate agreements.")]
    ForwardRateAgreement,
    
    /// <summary>
    /// Balance attributed to repurchase agreements.
    /// Encoded/decoded by serializers as "RepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_m3ujtvNBEeCuA5Tr22BnwA_-1767068898")]
    [Description(@"Balance attributed to repurchase agreements.")]
    RepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to reverse repurchase agreements.
    /// Encoded/decoded by serializers as "ReverseRepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "XREP")]
    [IsoId("_m34UsPNBEeCuA5Tr22BnwA_374074643")]
    [Description(@"Balance attributed to reverse repurchase agreements.")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to triparty repurchase agreements.
    /// Encoded/decoded by serializers as "TripartyRepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "TREP")]
    [IsoId("_m34UsfNBEeCuA5Tr22BnwA_968990788")]
    [Description(@"Balance attributed to triparty repurchase agreements.")]
    TripartyRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to triparty reverse repurchase agreements.
    /// Encoded/decoded by serializers as "TripartyReverseRepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "RXRP")]
    [IsoId("_m34UsvNBEeCuA5Tr22BnwA_680752527")]
    [Description(@"Balance attributed to triparty reverse repurchase agreements.")]
    TripartyReverseRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to foreign exchange forwards.
    /// Encoded/decoded by serializers as "FXForward".
    /// </summary>
    [EnumMember(Value = "FXFD")]
    [IsoId("_m34Us_NBEeCuA5Tr22BnwA_620113517")]
    [Description(@"Balance attributed to foreign exchange forwards.")]
    FXForward,
    
    /// <summary>
    /// Balance attributed to foreign exchange spots.
    /// Encoded/decoded by serializers as "FXSpot".
    /// </summary>
    [EnumMember(Value = "FXSP")]
    [IsoId("_m34UtPNBEeCuA5Tr22BnwA_697152218")]
    [Description(@"Balance attributed to foreign exchange spots.")]
    FXSpot,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialAssetBalanceType1CodeMetadataExtensions
{
    private static readonly FinancialAssetBalanceType1CodeDropdownSource _dropdownSource = new FinancialAssetBalanceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialAssetBalanceType1CodeDropdownRow GetMetadata(this FinancialAssetBalanceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


