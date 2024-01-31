﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAssetTypeV2Code.  ISO2002 ID# _0hBrIL_VEeeb2ZBoAlSG1Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) security sub-issue type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0hBrIL_VEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTC (The Depository Trust Company) security sub-issue type.")]
[Derivations(typeof(DTCAssetType3Code))]
public enum DTCAssetTypeV2Code
{
    /// <summary>
    /// Asset is an equity.
    /// Encoded/decoded by serializers as "S005".
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_0hLbyr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity.")]
    Equity,
    
    /// <summary>
    /// Asset is a common stock.
    /// Encoded/decoded by serializers as "S010".
    /// </summary>
    [EnumMember(Value = "S010")]
    [IsoId("_0hLb87_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock.")]
    CommonStock,
    
    /// <summary>
    /// Asset is a convertible common stock.
    /// Encoded/decoded by serializers as "S011".
    /// </summary>
    [EnumMember(Value = "S011")]
    [IsoId("_0hLcBL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible common stock.")]
    ConvertibleCommonStock,
    
    /// <summary>
    /// Asset is a common stock real estate investment trust.
    /// Encoded/decoded by serializers as "S012".
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_0hLby7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a common stock real estate investment trust.")]
    CommonStockREIT,
    
    /// <summary>
    /// Asset is a preferred stock.
    /// Encoded/decoded by serializers as "S020".
    /// </summary>
    [EnumMember(Value = "S020")]
    [IsoId("_0hBrKr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock.")]
    PreferredStock,
    
    /// <summary>
    /// Asset is a preferred stock real estate investment trust.
    /// Encoded/decoded by serializers as "S022".
    /// </summary>
    [EnumMember(Value = "S022")]
    [IsoId("_0hBrJb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a preferred stock real estate investment trust.")]
    PreferredStockREIT,
    
    /// <summary>
    /// Asset is a convertible preferred stock.
    /// Encoded/decoded by serializers as "S023".
    /// </summary>
    [EnumMember(Value = "S023")]
    [IsoId("_0hLb5L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible preferred stock.")]
    ConvertiblePreferredStock,
    
    /// <summary>
    /// Asset is a tender rate preferred stock.
    /// Encoded/decoded by serializers as "S024".
    /// </summary>
    [EnumMember(Value = "S024")]
    [IsoId("_0hLb5b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate preferred stock.")]
    TenderRatePreferredStock,
    
    /// <summary>
    /// Asset is a limited partnership.
    /// Encoded/decoded by serializers as "S030".
    /// </summary>
    [EnumMember(Value = "S030")]
    [IsoId("_0hBrKL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a limited partnership.")]
    LimitedPartnership,
    
    /// <summary>
    /// Asset is a collateralized mortgage obligation denomination in "Units" or "Undivided Interest".
    /// Encoded/decoded by serializers as "S040".
    /// </summary>
    [EnumMember(Value = "S040")]
    [IsoId("_0hLbyL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a collateralized mortgage obligation denomination in ""Units"" or ""Undivided Interest"".")]
    CMODenominationUnitsOrUndividedInterest,
    
    /// <summary>
    /// Asset is an asset-backed security denomination in "Units" or "Undivided Interest".
    /// Encoded/decoded by serializers as "S041".
    /// </summary>
    [EnumMember(Value = "S041")]
    [IsoId("_0hLb4b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an asset-backed security denomination in ""Units"" or ""Undivided Interest"".")]
    ABSDenominationUnitsOrUndividedInterest,
    
    /// <summary>
    /// Asset is an issue denomination in "Units" or "Undivided Interest".
    /// Encoded/decoded by serializers as "S042".
    /// </summary>
    [EnumMember(Value = "S042")]
    [IsoId("_0hLb_b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an issue denomination in ""Units"" or ""Undivided Interest"".")]
    IssueDenominationUnitsOrUndividedInterest,
    
    /// <summary>
    /// Asset is an auction rate preferred stock (ARPS).
    /// Encoded/decoded by serializers as "S102".
    /// </summary>
    [EnumMember(Value = "S102")]
    [IsoId("_0hLb6r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an auction rate preferred stock (ARPS).")]
    AuctionRatePreferredStock,
    
    /// <summary>
    /// Asset is an American depositary receipt (ADR).
    /// Encoded/decoded by serializers as "S110".
    /// </summary>
    [EnumMember(Value = "S110")]
    [IsoId("_0hLb97_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an American depositary receipt (ADR).")]
    AmericanDepositaryReceipt,
    
    /// <summary>
    /// Asset is a depositary share.
    /// Encoded/decoded by serializers as "S111".
    /// </summary>
    [EnumMember(Value = "S111")]
    [IsoId("_0hLcAr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a depositary share.")]
    DepositaryShare,
    
    /// <summary>
    /// Asset is a municipal option call right.
    /// Encoded/decoded by serializers as "S112".
    /// </summary>
    [EnumMember(Value = "S112")]
    [IsoId("_0hBrJ7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal option call right.")]
    MunicipalOptionCallRight,
    
    /// <summary>
    /// Asset is an exchange traded funds.
    /// Encoded/decoded by serializers as "S117".
    /// </summary>
    [EnumMember(Value = "S117")]
    [IsoId("_0hLcBb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an exchange traded funds.")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// Asset is a money market instrument preferred stock (in CP-like mode).
    /// Encoded/decoded by serializers as "S120".
    /// </summary>
    [EnumMember(Value = "S120")]
    [IsoId("_0hBrKb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument preferred stock (in CP-like mode).")]
    MMIPreferredStockCPLike,
    
    /// <summary>
    /// Asset is a sealed envelope.
    /// Encoded/decoded by serializers as "S125".
    /// </summary>
    [EnumMember(Value = "S125")]
    [IsoId("_0hLcB7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a sealed envelope.")]
    SealedEnvelope,
    
    /// <summary>
    /// Asset is a custody user CUSIP.
    /// Encoded/decoded by serializers as "S126".
    /// </summary>
    [EnumMember(Value = "S126")]
    [IsoId("_0hLb7b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a custody user CUSIP.")]
    CustodyUserCUSIP,
    
    /// <summary>
    /// Asset is a real estate investment trust (REIT).
    /// Encoded/decoded by serializers as "S130".
    /// </summary>
    [EnumMember(Value = "S130")]
    [IsoId("_0hLb8L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate investment trust (REIT).")]
    RealEstateInvestmentTrust,
    
    /// <summary>
    /// Asset is a municipal bond.
    /// Encoded/decoded by serializers as "S310".
    /// </summary>
    [EnumMember(Value = "S310")]
    [IsoId("_0hBrM7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal bond.")]
    MunicipalBond,
    
    /// <summary>
    /// Asset is a municipal note.
    /// Encoded/decoded by serializers as "S311".
    /// </summary>
    [EnumMember(Value = "S311")]
    [IsoId("_0hBrMb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal note.")]
    MunicipalNote,
    
    /// <summary>
    /// Asset is a municipal auction rate note (ARN).
    /// Encoded/decoded by serializers as "S312".
    /// </summary>
    [EnumMember(Value = "S312")]
    [IsoId("_0hBrL7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal auction rate note (ARN).")]
    MunicipalAuctionRateNote,
    
    /// <summary>
    /// Asset is a municipal variable mode obligation (VMO).
    /// Encoded/decoded by serializers as "S313".
    /// </summary>
    [EnumMember(Value = "S313")]
    [IsoId("_0hBrNL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable mode obligation (VMO).")]
    MunicipalVariableModeObligation,
    
    /// <summary>
    /// Asset is a municipal variable rate demand obligation (VRDO).
    /// Encoded/decoded by serializers as "S314".
    /// </summary>
    [EnumMember(Value = "S314")]
    [IsoId("_0hLb1r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal variable rate demand obligation (VRDO).")]
    MunicipalVariableRateDemandObligation,
    
    /// <summary>
    /// Asset is a municipal insured custodial receipt.
    /// Encoded/decoded by serializers as "S315".
    /// </summary>
    [EnumMember(Value = "S315")]
    [IsoId("_0hBrLL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal insured custodial receipt.")]
    MunicipalInsuredCustodialReceipt,
    
    /// <summary>
    /// Asset is a money market instrument municipal variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as "S320".
    /// </summary>
    [EnumMember(Value = "S320")]
    [IsoId("_0hLbxb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument municipal variable rate demand obligation commercial paper.")]
    MMIMunicipalVariableRateDemandObligation,
    
    /// <summary>
    /// Asset is a money market instrument municipal commercial paper.
    /// Encoded/decoded by serializers as "S330".
    /// </summary>
    [EnumMember(Value = "S330")]
    [IsoId("_0hLb1b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument municipal commercial paper.")]
    MMIMunicipalCommercialPaper,
    
    /// <summary>
    /// Asset is a bearer, callable zero coupon bond.
    /// Encoded/decoded by serializers as "S340".
    /// </summary>
    [EnumMember(Value = "S340")]
    [IsoId("_0hLcCL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a bearer, callable zero coupon bond.")]
    BearerCallableZeroCouponBond,
    
    /// <summary>
    /// Asset is a government national mortgage association real estate mortgage investment conduit security.
    /// Encoded/decoded by serializers as "S450".
    /// </summary>
    [EnumMember(Value = "S450")]
    [IsoId("_0hLbwr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association real estate mortgage investment conduit security.")]
    GNMARealEstateMortgageInvestmentConduit,
    
    /// <summary>
    /// Asset is a government national mortgage association pass-through security.
    /// Encoded/decoded by serializers as "S451".
    /// </summary>
    [EnumMember(Value = "S451")]
    [IsoId("_0hLbzL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association pass-through security.")]
    GNMAPassThroughSecurity,
    
    /// <summary>
    /// Asset is a government national mortgage association serial note security.
    /// Encoded/decoded by serializers as "S452".
    /// </summary>
    [EnumMember(Value = "S452")]
    [IsoId("_0hLb3r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note security.")]
    GNMASerialNoteSecurity,
    
    /// <summary>
    /// Asset is a corporate bond (CB) Or a global corporate bond (GCB).
    /// Encoded/decoded by serializers as "S500".
    /// </summary>
    [EnumMember(Value = "S500")]
    [IsoId("_0hBrIb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate bond (CB) Or a global corporate bond (GCB).")]
    CorporateBondOrGlobal,
    
    /// <summary>
    /// Asset is a money market instrument bankers' acceptance note (BA).
    /// Encoded/decoded by serializers as "S502".
    /// </summary>
    [EnumMember(Value = "S502")]
    [IsoId("_0hLbxr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument bankers' acceptance note (BA).")]
    MMIBankersAcceptanceNote,
    
    /// <summary>
    /// Asset is a money market instrument institutional certificates of deposit.
    /// Encoded/decoded by serializers as "S504".
    /// </summary>
    [EnumMember(Value = "S504")]
    [IsoId("_0hLb8b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument institutional certificates of deposit.")]
    MMIInstitutionalCertificatesOfDeposit,
    
    /// <summary>
    /// Asset is a certificated money market instrument.
    /// Encoded/decoded by serializers as "S505".
    /// </summary>
    [EnumMember(Value = "S505")]
    [IsoId("_0hLcA7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market instrument.")]
    CertificatedMoneyMarketInstrument,
    
    /// <summary>
    /// Asset is a certificated money market - periodic payer.
    /// Encoded/decoded by serializers as "S506".
    /// </summary>
    [EnumMember(Value = "S506")]
    [IsoId("_0hLbx7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificated money market - periodic payer.")]
    CertificatedMoneyMarketPeriodicPayer,
    
    /// <summary>
    /// Asset is a certificates of deposit.
    /// Encoded/decoded by serializers as "S507".
    /// </summary>
    [EnumMember(Value = "S507")]
    [IsoId("_0hLb5r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a certificates of deposit.")]
    CertificatesOfDeposit,
    
    /// <summary>
    /// Asset is a consumer price index interest at maturity (IAM) commercial paper.
    /// Encoded/decoded by serializers as "S510".
    /// </summary>
    [EnumMember(Value = "S510")]
    [IsoId("_0hBrIr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index interest at maturity (IAM) commercial paper.")]
    ConsumerPriceIndexAtMaturityCP,
    
    /// <summary>
    /// Asset is a periodic payment commercial paper.
    /// Encoded/decoded by serializers as "S511".
    /// </summary>
    [EnumMember(Value = "S511")]
    [IsoId("_0hLb17_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a periodic payment commercial paper.")]
    PeriodicPaymentCommercialPaper,
    
    /// <summary>
    /// Asset is a consumer price index discount commercial paper.
    /// Encoded/decoded by serializers as "S520".
    /// </summary>
    [EnumMember(Value = "S520")]
    [IsoId("_0hLbwb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a consumer price index discount commercial paper.")]
    ConsumerPriceIndexDiscountCP,
    
    /// <summary>
    /// Asset is a money market instrument corporate commercial paper.
    /// Encoded/decoded by serializers as "S525".
    /// </summary>
    [EnumMember(Value = "S525")]
    [IsoId("_0hLbz7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument corporate commercial paper.")]
    MMICorporateCommercialPaper,
    
    /// <summary>
    /// Asset is a money market instrument corporate variable rate demand obligation commercial paper.
    /// Encoded/decoded by serializers as "S526".
    /// </summary>
    [EnumMember(Value = "S526")]
    [IsoId("_0hLb77_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument corporate variable rate demand obligation commercial paper.")]
    MMICorporateVariableRateDemandObligation,
    
    /// <summary>
    /// Asset is a medium term note (MTN).
    /// Encoded/decoded by serializers as "S530".
    /// </summary>
    [EnumMember(Value = "S530")]
    [IsoId("_0hLb-L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a medium term note (MTN).")]
    MediumTermNote,
    
    /// <summary>
    /// Asset is a money market instrument deposit note.
    /// Encoded/decoded by serializers as "S531".
    /// </summary>
    [EnumMember(Value = "S531")]
    [IsoId("_0hBrML_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument deposit note.")]
    MMIDepositNote,
    
    /// <summary>
    /// Asset is a money market instrument medium-term bank note.
    /// Encoded/decoded by serializers as "S532".
    /// </summary>
    [EnumMember(Value = "S532")]
    [IsoId("_0hLb3L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium-term bank note.")]
    MMIMediumTermBankNote,
    
    /// <summary>
    /// Asset is a money market instrument medium term note.
    /// Encoded/decoded by serializers as "S533".
    /// </summary>
    [EnumMember(Value = "S533")]
    [IsoId("_0hLb_7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument medium term note.")]
    MMIMediumTermNote,
    
    /// <summary>
    /// Asset is a collateralized mortgage obligation or global collateralized mortgage obligation.
    /// Encoded/decoded by serializers as "S540".
    /// </summary>
    [EnumMember(Value = "S540")]
    [IsoId("_0hLb_r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a collateralized mortgage obligation or global collateralized mortgage obligation.")]
    CollateralizedMortgageObligationOrGlobal,
    
    /// <summary>
    /// Asset is an asset-backed security (ABS) or global asset backed security (GABS).
    /// Encoded/decoded by serializers as "S541".
    /// </summary>
    [EnumMember(Value = "S541")]
    [IsoId("_0hLb9b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an asset-backed security (ABS) or global asset backed security (GABS).")]
    AssetBackedSecurityOrGlobal,
    
    /// <summary>
    /// Asset is a non-collateralized mortgage obligation ABS amortizing issue.
    /// Encoded/decoded by serializers as "S542".
    /// </summary>
    [EnumMember(Value = "S542")]
    [IsoId("_0hLbwL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non-collateralized mortgage obligation ABS amortizing issue.")]
    NonCMOABSAmortizingIssue,
    
    /// <summary>
    /// MMI Short-Term Bank Note.
    /// Encoded/decoded by serializers as "S550".
    /// </summary>
    [EnumMember(Value = "S550")]
    [IsoId("_0hLb0r_VEeeb2ZBoAlSG1Q")]
    [Description(@"MMI Short-Term Bank Note.")]
    MMIShortTermBankNote,
    
    /// <summary>
    /// Asset is a zero coupon denomination in initial principal amount.
    /// Encoded/decoded by serializers as "S551".
    /// </summary>
    [EnumMember(Value = "S551")]
    [IsoId("_0hLbzb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon denomination in initial principal amount.")]
    ZCPNDenominationInitialPrincipalAmount,
    
    /// <summary>
    /// Asset is a money market instrument discount note.
    /// Encoded/decoded by serializers as "S560".
    /// </summary>
    [EnumMember(Value = "S560")]
    [IsoId("_0hLb9r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a money market instrument discount note.")]
    MMIDiscountNote,
    
    /// <summary>
    /// Asset is a corporate auction rate note.
    /// Encoded/decoded by serializers as "S571".
    /// </summary>
    [EnumMember(Value = "S571")]
    [IsoId("_0hLb2r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate auction rate note.")]
    CorporateAuctionRateNote,
    
    /// <summary>
    /// Asset is a convertible corporate debt.
    /// Encoded/decoded by serializers as "S572".
    /// </summary>
    [EnumMember(Value = "S572")]
    [IsoId("_0hLcAL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a convertible corporate debt.")]
    ConvertibleCorporateDebt,
    
    /// <summary>
    /// Asset is a corporate variable mode obligation (CVMO).
    /// Encoded/decoded by serializers as "S573".
    /// </summary>
    [EnumMember(Value = "S573")]
    [IsoId("_0hLbyb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate variable mode obligation (CVMO).")]
    CorporateVariableModeObligation,
    
    /// <summary>
    /// Asset is a corporate short-term note.
    /// Encoded/decoded by serializers as "S574".
    /// </summary>
    [EnumMember(Value = "S574")]
    [IsoId("_0hLb07_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate short-term note.")]
    CorporateShortTermNote,
    
    /// <summary>
    /// Asset is a corporate debenture.
    /// Encoded/decoded by serializers as "S575".
    /// </summary>
    [EnumMember(Value = "S575")]
    [IsoId("_0hLb2L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debenture.")]
    CorporateDebenture,
    
    /// <summary>
    /// Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD).
    /// Encoded/decoded by serializers as "S576".
    /// </summary>
    [EnumMember(Value = "S576")]
    [IsoId("_0hBrMr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate variable rate demand obligation or a municipal variable rate demand obligation (MMD).")]
    CorporateOrMunicipalVariableRateDemandObligation,
    
    /// <summary>
    /// Asset is a corporate insured custodial receipt.
    /// Encoded/decoded by serializers as "S577".
    /// </summary>
    [EnumMember(Value = "S577")]
    [IsoId("_0hLb6b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate insured custodial receipt.")]
    CorporateInsuredCustodialReceipt,
    
    /// <summary>
    /// Asset is a tender rate note.
    /// Encoded/decoded by serializers as "S578".
    /// </summary>
    [EnumMember(Value = "S578")]
    [IsoId("_0hLb-b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a tender rate note.")]
    TenderRateNote,
    
    /// <summary>
    /// Asset is a zero coupon bond.
    /// Encoded/decoded by serializers as "S579".
    /// </summary>
    [EnumMember(Value = "S579")]
    [IsoId("_0hLbzr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a zero coupon bond.")]
    ZeroCouponBond,
    
    /// <summary>
    /// Asset is a government national mortgage association government security.
    /// Encoded/decoded by serializers as "S601".
    /// </summary>
    [EnumMember(Value = "S601")]
    [IsoId("_0hLb6L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association government security.")]
    GovernmentSecurity,
    
    /// <summary>
    /// Asset is a government trust certificate.
    /// Encoded/decoded by serializers as "S602".
    /// </summary>
    [EnumMember(Value = "S602")]
    [IsoId("_0hLb4L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government trust certificate.")]
    GovernmentTrustCertificate,
    
    /// <summary>
    /// Asset is a junk and treasury growth receipt (JGR).
    /// Encoded/decoded by serializers as "S603".
    /// </summary>
    [EnumMember(Value = "S603")]
    [IsoId("_0hLb-r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a junk and treasury growth receipt (JGR).")]
    JunkAndTreasuryGrowthReceipt,
    
    /// <summary>
    /// Asset is a U.S. treasury security.
    /// Encoded/decoded by serializers as "S610".
    /// </summary>
    [EnumMember(Value = "S610")]
    [IsoId("_0hLb67_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. treasury security.")]
    USTreasurySecurity,
    
    /// <summary>
    /// Asset is a US treasury bill.
    /// Encoded/decoded by serializers as "S611".
    /// </summary>
    [EnumMember(Value = "S611")]
    [IsoId("_0hLb27_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bill.")]
    USTreasuryBill,
    
    /// <summary>
    /// Asset is a US treasury note.
    /// Encoded/decoded by serializers as "S612".
    /// </summary>
    [EnumMember(Value = "S612")]
    [IsoId("_0hLcAb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury note.")]
    USTreasuryNote,
    
    /// <summary>
    /// Asset is a US treasury bond.
    /// Encoded/decoded by serializers as "S613".
    /// </summary>
    [EnumMember(Value = "S613")]
    [IsoId("_0hLb37_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a US treasury bond.")]
    USTreasuryBond,
    
    /// <summary>
    /// Asset is a U.S. government agency security.
    /// Encoded/decoded by serializers as "S620".
    /// </summary>
    [EnumMember(Value = "S620")]
    [IsoId("_0hLbw7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a U.S. government agency security.")]
    USGovernmentAgencySecurity,
    
    /// <summary>
    /// Asset is a government national mortgage association (GNMA).
    /// Encoded/decoded by serializers as "S650".
    /// </summary>
    [EnumMember(Value = "S650")]
    [IsoId("_0hLcBr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association (GNMA).")]
    GovernmentNationallMortgageAssociation,
    
    /// <summary>
    /// Asset is a real estate mortgage investment conduit (REMIC).
    /// Encoded/decoded by serializers as "S651".
    /// </summary>
    [EnumMember(Value = "S651")]
    [IsoId("_0hLb3b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a real estate mortgage investment conduit (REMIC).")]
    RealEstateMortgageInvestmentConduit,
    
    /// <summary>
    /// Asset is a government national mortgage association serial note.
    /// Encoded/decoded by serializers as "S652".
    /// </summary>
    [EnumMember(Value = "S652")]
    [IsoId("_0hLb8r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a government national mortgage association serial note.")]
    GNMASerialNote,
    
    /// <summary>
    /// Asset is a package.
    /// Encoded/decoded by serializers as "S700".
    /// </summary>
    [EnumMember(Value = "S700")]
    [IsoId("_0hLb2b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a package.")]
    Package,
    
    /// <summary>
    /// Corporate Debt Derivative.
    /// Encoded/decoded by serializers as "S704".
    /// </summary>
    [EnumMember(Value = "S704")]
    [IsoId("_0hBrK7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Corporate Debt Derivative.")]
    CorporateDebtDerivative,
    
    /// <summary>
    /// Asset is an equity derivative.
    /// Encoded/decoded by serializers as "S705".
    /// </summary>
    [EnumMember(Value = "S705")]
    [IsoId("_0hLcCb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity derivative.")]
    EquityDerivative,
    
    /// <summary>
    /// Asset is a municipal derivative.
    /// Encoded/decoded by serializers as "S706".
    /// </summary>
    [EnumMember(Value = "S706")]
    [IsoId("_0hLcCr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal derivative.")]
    MunicipalDerivative,
    
    /// <summary>
    /// Asset is a municipal amortized issue.
    /// Encoded/decoded by serializers as "S708".
    /// </summary>
    [EnumMember(Value = "S708")]
    [IsoId("_0hBrJr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal amortized issue.")]
    MunicipalAmortizedIssue,
    
    /// <summary>
    /// Asset is an option derivative.
    /// Encoded/decoded by serializers as "S710".
    /// </summary>
    [EnumMember(Value = "S710")]
    [IsoId("_0hBrLb_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an option derivative.")]
    OptionDerivative,
    
    /// <summary>
    /// Asset is a warrant.
    /// Encoded/decoded by serializers as "S720".
    /// </summary>
    [EnumMember(Value = "S720")]
    [IsoId("_0hLb47_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a warrant.")]
    Warrant,
    
    /// <summary>
    /// Asset is a right.
    /// Encoded/decoded by serializers as "S730".
    /// </summary>
    [EnumMember(Value = "S730")]
    [IsoId("_0hLb1L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a right.")]
    Right,
    
    /// <summary>
    /// Asset is a mutual fund.
    /// Encoded/decoded by serializers as "S760".
    /// </summary>
    [EnumMember(Value = "S760")]
    [IsoId("_0hLb57_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a mutual fund.")]
    MutualFund,
    
    /// <summary>
    /// Asset is a closed end fund.
    /// Encoded/decoded by serializers as "S761".
    /// </summary>
    [EnumMember(Value = "S761")]
    [IsoId("_0hBrI7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a closed end fund.")]
    ClosedEndFund,
    
    /// <summary>
    /// Asset is an institutional money market instrument mutual fund share.
    /// Encoded/decoded by serializers as "S762".
    /// </summary>
    [EnumMember(Value = "S762")]
    [IsoId("_0hLbxL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an institutional money market instrument mutual fund share.")]
    InstitutionalMMIMutualFundShare,
    
    /// <summary>
    /// Asset is an equity unit.
    /// Encoded/decoded by serializers as "S780".
    /// </summary>
    [EnumMember(Value = "S780")]
    [IsoId("_0hLb-7_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity unit.")]
    EquityUnit,
    
    /// <summary>
    /// Asset is a debt unit.
    /// Encoded/decoded by serializers as "S781".
    /// </summary>
    [EnumMember(Value = "S781")]
    [IsoId("_0hLb7r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a debt unit.")]
    DebtUnit,
    
    /// <summary>
    /// Asset is a unit investment trust (UIT) nuveen only.
    /// Encoded/decoded by serializers as "S790".
    /// </summary>
    [EnumMember(Value = "S790")]
    [IsoId("_0hBrJL_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT) nuveen only.")]
    UnitInvestmentTrustNuveenOnly,
    
    /// <summary>
    /// Asset is a global unit trust.
    /// Encoded/decoded by serializers as "S791".
    /// </summary>
    [EnumMember(Value = "S791")]
    [IsoId("_0hBrLr_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a global unit trust.")]
    GlobalUnitTrust,
    
    /// <summary>
    /// Asset is a unit investment trust (UIT).
    /// Encoded/decoded by serializers as "S795".
    /// </summary>
    [EnumMember(Value = "S795")]
    [IsoId("_0hLb0b_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a unit investment trust (UIT).")]
    UnitInvestmentTrust,
    
    /// <summary>
    /// Asset is an equity, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as "S121".
    /// </summary>
    [EnumMember(Value = "S121")]
    [IsoId("_0hLb9L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is an equity, subject to 144a, designated investors.")]
    Equity144aDesignatedInvestors,
    
    /// <summary>
    /// Asset is a municipal debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as "S346".
    /// </summary>
    [EnumMember(Value = "S346")]
    [IsoId("_0hLb4r_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a municipal debt, classified as other, subject to tax exempt.")]
    MunicipalOtherTaxExempt,
    
    /// <summary>
    /// Asset is a corporate debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as "S546".
    /// </summary>
    [EnumMember(Value = "S546")]
    [IsoId("_0hLb7L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, classified as other, subject to tax exempt.")]
    CorporateOtherTaxExempt,
    
    /// <summary>
    /// Asset is a corporate debt, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as "S545".
    /// </summary>
    [EnumMember(Value = "S545")]
    [IsoId("_0hLb0L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a corporate debt, subject to 144a, designated investors.")]
    Corporate144aDesignatedInvestors,
    
    /// <summary>
    /// Asset is a non standard asset user CUSIP.
    /// Encoded/decoded by serializers as "S127".
    /// </summary>
    [EnumMember(Value = "S127")]
    [IsoId("_0hLb_L_VEeeb2ZBoAlSG1Q")]
    [Description(@"Asset is a non standard asset user CUSIP.")]
    NonStandardAssetUserCUSIP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCAssetTypeV2CodeMetadataExtensions
{
    private static readonly DTCAssetTypeV2CodeDropdownSource _dropdownSource = new DTCAssetTypeV2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCAssetTypeV2CodeDropdownRow GetMetadata(this DTCAssetTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


