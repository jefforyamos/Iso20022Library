﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAssetTypeCode.  ISO2002 ID# _1tmR8DL3EeKU9IrkkToqcw_1115111352.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) security sub-issue type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tmR8DL3EeKU9IrkkToqcw_1115111352")]
[Description(@"Specifies DTC (The Depository Trust Company) security sub-issue type.")]
[Derivations(typeof(DTCAssetType1Code),typeof(DTCAssetType2Code))]
public enum DTCAssetTypeCode
{
    /// <summary>
    /// Equity.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_1tmR8TL3EeKU9IrkkToqcw_-1469443667")]
    [Description(@"Equity.")]
    Equity,
    
    /// <summary>
    /// Common Stock.
    /// Encoded/decoded by serializers as &quot;S010&quot;.
    /// </summary>
    [EnumMember(Value = "S010")]
    [IsoId("_1tmR8jL3EeKU9IrkkToqcw_-1314693436")]
    [Description(@"Common Stock.")]
    CommonStock,
    
    /// <summary>
    /// Convertible Common Stock.
    /// Encoded/decoded by serializers as &quot;S011&quot;.
    /// </summary>
    [EnumMember(Value = "S011")]
    [IsoId("_1tmR8zL3EeKU9IrkkToqcw_-996951154")]
    [Description(@"Convertible Common Stock.")]
    ConvertibleCommonStock,
    
    /// <summary>
    /// Common Stock REIT.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_1tmR9DL3EeKU9IrkkToqcw_173404364")]
    [Description(@"Common Stock REIT.")]
    CommonStockREIT,
    
    /// <summary>
    /// Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S020&quot;.
    /// </summary>
    [EnumMember(Value = "S020")]
    [IsoId("_1tmR9TL3EeKU9IrkkToqcw_1564591502")]
    [Description(@"Preferred Stock.")]
    PreferredStock,
    
    /// <summary>
    /// Preferred Stock REIT.
    /// Encoded/decoded by serializers as &quot;S022&quot;.
    /// </summary>
    [EnumMember(Value = "S022")]
    [IsoId("_1tmR9jL3EeKU9IrkkToqcw_-416346201")]
    [Description(@"Preferred Stock REIT.")]
    PreferredStockREIT,
    
    /// <summary>
    /// Convertible Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S023&quot;.
    /// </summary>
    [EnumMember(Value = "S023")]
    [IsoId("_1tvb4DL3EeKU9IrkkToqcw_934291781")]
    [Description(@"Convertible Preferred Stock.")]
    ConvertiblePreferredStock,
    
    /// <summary>
    /// Tender Rate Preferred Stock.
    /// Encoded/decoded by serializers as &quot;S024&quot;.
    /// </summary>
    [EnumMember(Value = "S024")]
    [IsoId("_1tvb4TL3EeKU9IrkkToqcw_-1426887191")]
    [Description(@"Tender Rate Preferred Stock.")]
    TenderRatePreferredStock,
    
    /// <summary>
    /// Limited Partnership.
    /// Encoded/decoded by serializers as &quot;S030&quot;.
    /// </summary>
    [EnumMember(Value = "S030")]
    [IsoId("_1tvb4jL3EeKU9IrkkToqcw_266107007")]
    [Description(@"Limited Partnership.")]
    LimitedPartnership,
    
    /// <summary>
    /// CMO Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S040&quot;.
    /// </summary>
    [EnumMember(Value = "S040")]
    [IsoId("_1tvb4zL3EeKU9IrkkToqcw_1337295918")]
    [Description(@"CMO Denomination in ""Units"" or ""Undivided Interest"".")]
    CMODenominUnitsorUndividedInterest,
    
    /// <summary>
    /// ABS Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S041&quot;.
    /// </summary>
    [EnumMember(Value = "S041")]
    [IsoId("_1tvb5DL3EeKU9IrkkToqcw_434163355")]
    [Description(@"ABS Denomination in ""Units"" or ""Undivided Interest"".")]
    ABSDenominUnitsorUndividedInterest,
    
    /// <summary>
    /// Issue Denomination in &quot;Units&quot; or &quot;Undivided Interest&quot;.
    /// Encoded/decoded by serializers as &quot;S042&quot;.
    /// </summary>
    [EnumMember(Value = "S042")]
    [IsoId("_1tvb5TL3EeKU9IrkkToqcw_-1766172425")]
    [Description(@"Issue Denomination in ""Units"" or ""Undivided Interest"".")]
    IssueDenominUnitsorUndividedInterest,
    
    /// <summary>
    /// Auction Rate Preferred Stock (ARPS).
    /// Encoded/decoded by serializers as &quot;S102&quot;.
    /// </summary>
    [EnumMember(Value = "S102")]
    [IsoId("_1tvb5jL3EeKU9IrkkToqcw_-670141519")]
    [Description(@"Auction Rate Preferred Stock (ARPS).")]
    AuctionRatePreferredStockARPS,
    
    /// <summary>
    /// American Depositary Receipt (ADR).
    /// Encoded/decoded by serializers as &quot;S110&quot;.
    /// </summary>
    [EnumMember(Value = "S110")]
    [IsoId("_1t5M4DL3EeKU9IrkkToqcw_870556599")]
    [Description(@"American Depositary Receipt (ADR).")]
    AmericanDepositaryReceiptADR,
    
    /// <summary>
    /// Depositary Share.
    /// Encoded/decoded by serializers as &quot;S111&quot;.
    /// </summary>
    [EnumMember(Value = "S111")]
    [IsoId("_1t5M4TL3EeKU9IrkkToqcw_-1297318249")]
    [Description(@"Depositary Share.")]
    DepositaryShare,
    
    /// <summary>
    /// Municipal Option Call Right.
    /// Encoded/decoded by serializers as &quot;S112&quot;.
    /// </summary>
    [EnumMember(Value = "S112")]
    [IsoId("_1t5M4jL3EeKU9IrkkToqcw_-1514319231")]
    [Description(@"Municipal Option Call Right.")]
    MunicipalOptionCallRight,
    
    /// <summary>
    /// Exchange Traded Funds.
    /// Encoded/decoded by serializers as &quot;S117&quot;.
    /// </summary>
    [EnumMember(Value = "S117")]
    [IsoId("_1t5M4zL3EeKU9IrkkToqcw_-594898135")]
    [Description(@"Exchange Traded Funds.")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// MMI Preferred Stock (in CP-like mode).
    /// Encoded/decoded by serializers as &quot;S120&quot;.
    /// </summary>
    [EnumMember(Value = "S120")]
    [IsoId("_1t5M5DL3EeKU9IrkkToqcw_1707999643")]
    [Description(@"MMI Preferred Stock (in CP-like mode).")]
    MMIPreferredStockinCPlikemode,
    
    /// <summary>
    /// Sealed Envelope.
    /// Encoded/decoded by serializers as &quot;S125&quot;.
    /// </summary>
    [EnumMember(Value = "S125")]
    [IsoId("_1t5M5TL3EeKU9IrkkToqcw_743529360")]
    [Description(@"Sealed Envelope.")]
    SealedEnvelope,
    
    /// <summary>
    /// Custody User CUSIP.
    /// Encoded/decoded by serializers as &quot;S126&quot;.
    /// </summary>
    [EnumMember(Value = "S126")]
    [IsoId("_1t5M5jL3EeKU9IrkkToqcw_777246712")]
    [Description(@"Custody User CUSIP.")]
    CustodyUserCUSIP,
    
    /// <summary>
    /// Real-Estate Investment Trust (REIT).
    /// Encoded/decoded by serializers as &quot;S130&quot;.
    /// </summary>
    [EnumMember(Value = "S130")]
    [IsoId("_1uC94DL3EeKU9IrkkToqcw_-1346481653")]
    [Description(@"Real-Estate Investment Trust (REIT).")]
    RealEstateInvestmentTrustREIT,
    
    /// <summary>
    /// Municipal Bond.
    /// Encoded/decoded by serializers as &quot;S310&quot;.
    /// </summary>
    [EnumMember(Value = "S310")]
    [IsoId("_1uC94TL3EeKU9IrkkToqcw_945375390")]
    [Description(@"Municipal Bond.")]
    MunicipalBond,
    
    /// <summary>
    /// Municipal Note.
    /// Encoded/decoded by serializers as &quot;S311&quot;.
    /// </summary>
    [EnumMember(Value = "S311")]
    [IsoId("_1uC94jL3EeKU9IrkkToqcw_-534815444")]
    [Description(@"Municipal Note.")]
    MunicipalNote,
    
    /// <summary>
    /// Municipal Auction Rate Note (ARN).
    /// Encoded/decoded by serializers as &quot;S312&quot;.
    /// </summary>
    [EnumMember(Value = "S312")]
    [IsoId("_1uC94zL3EeKU9IrkkToqcw_1584808530")]
    [Description(@"Municipal Auction Rate Note (ARN).")]
    MunicipalAuctionRateNoteARN,
    
    /// <summary>
    /// Municipal Variable Mode Obligation (VMO).
    /// Encoded/decoded by serializers as &quot;S313&quot;.
    /// </summary>
    [EnumMember(Value = "S313")]
    [IsoId("_1uC95DL3EeKU9IrkkToqcw_318809937")]
    [Description(@"Municipal Variable Mode Obligation (VMO).")]
    MunicipalVariableModeObligationVMO,
    
    /// <summary>
    /// Municipal Variable Rate Demand Obligation (VRDO).
    /// Encoded/decoded by serializers as &quot;S314&quot;.
    /// </summary>
    [EnumMember(Value = "S314")]
    [IsoId("_1uC95TL3EeKU9IrkkToqcw_146779616")]
    [Description(@"Municipal Variable Rate Demand Obligation (VRDO).")]
    MunicipalVariableRateDemandObligationVRDO,
    
    /// <summary>
    /// Municipal Insured Custodial Receipt.
    /// Encoded/decoded by serializers as &quot;S315&quot;.
    /// </summary>
    [EnumMember(Value = "S315")]
    [IsoId("_1uC95jL3EeKU9IrkkToqcw_585809267")]
    [Description(@"Municipal Insured Custodial Receipt.")]
    MunicipalInsuredCustodialReceipt,
    
    /// <summary>
    /// MMI Municipal VRDO/CP.
    /// Encoded/decoded by serializers as &quot;S320&quot;.
    /// </summary>
    [EnumMember(Value = "S320")]
    [IsoId("_1uC95zL3EeKU9IrkkToqcw_1625027414")]
    [Description(@"MMI Municipal VRDO/CP.")]
    MMIMunicipalVRDOCP,
    
    /// <summary>
    /// MMI Municipal Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S330&quot;.
    /// </summary>
    [EnumMember(Value = "S330")]
    [IsoId("_1uMH0DL3EeKU9IrkkToqcw_1271161310")]
    [Description(@"MMI Municipal Commercial Paper.")]
    MMIMunicipalCommercialPaper,
    
    /// <summary>
    /// Bearer, Callable Zero Coupon Bond.
    /// Encoded/decoded by serializers as &quot;S340&quot;.
    /// </summary>
    [EnumMember(Value = "S340")]
    [IsoId("_1ufp0DL3EeKU9IrkkToqcw_636224116")]
    [Description(@"Bearer, Callable Zero Coupon Bond.")]
    BearerCallableZeroCouponBond,
    
    /// <summary>
    /// GNMA REMIC securities.
    /// Encoded/decoded by serializers as &quot;S450&quot;.
    /// </summary>
    [EnumMember(Value = "S450")]
    [IsoId("_1ufp0TL3EeKU9IrkkToqcw_2012914466")]
    [Description(@"GNMA REMIC securities.")]
    GNMAREMICSecurities,
    
    /// <summary>
    /// GNMA Pass-through securities.
    /// Encoded/decoded by serializers as &quot;S451&quot;.
    /// </summary>
    [EnumMember(Value = "S451")]
    [IsoId("_1ufp0jL3EeKU9IrkkToqcw_1245729532")]
    [Description(@"GNMA Pass-through securities.")]
    GNMAPassThroughSecurities,
    
    /// <summary>
    /// GNMA Serial note securities.
    /// Encoded/decoded by serializers as &quot;S452&quot;.
    /// </summary>
    [EnumMember(Value = "S452")]
    [IsoId("_1uozwDL3EeKU9IrkkToqcw_-1681155785")]
    [Description(@"GNMA Serial note securities.")]
    GNMASerialNoteSecurities,
    
    /// <summary>
    /// Corporate Bond (CB) or Global Corp Bond (GCB).
    /// Encoded/decoded by serializers as &quot;S500&quot;.
    /// </summary>
    [EnumMember(Value = "S500")]
    [IsoId("_1uozwTL3EeKU9IrkkToqcw_1543057458")]
    [Description(@"Corporate Bond (CB) or Global Corp Bond (GCB).")]
    CorporateBondCBorGlobalCorpBondGCB,
    
    /// <summary>
    /// MMI Bankers&apos; Acceptance Note (BA).
    /// Encoded/decoded by serializers as &quot;S502&quot;.
    /// </summary>
    [EnumMember(Value = "S502")]
    [IsoId("_1uozwjL3EeKU9IrkkToqcw_2043978002")]
    [Description(@"MMI Bankers' Acceptance Note (BA).")]
    MMIBankersAcceptanceNoteBA,
    
    /// <summary>
    /// MMI Institutional Certificates of Deposit.
    /// Encoded/decoded by serializers as &quot;S504&quot;.
    /// </summary>
    [EnumMember(Value = "S504")]
    [IsoId("_1uozwzL3EeKU9IrkkToqcw_1416963337")]
    [Description(@"MMI Institutional Certificates of Deposit.")]
    MMIInstitutionalCertificatesofDeposit,
    
    /// <summary>
    /// Certificated Money Market Instrument.
    /// Encoded/decoded by serializers as &quot;S505&quot;.
    /// </summary>
    [EnumMember(Value = "S505")]
    [IsoId("_1uykwDL3EeKU9IrkkToqcw_1422795115")]
    [Description(@"Certificated Money Market Instrument.")]
    CertificatedMoneyMarketInstrument,
    
    /// <summary>
    /// Certificated Money Market - Periodic Payer.
    /// Encoded/decoded by serializers as &quot;S506&quot;.
    /// </summary>
    [EnumMember(Value = "S506")]
    [IsoId("_1uykwTL3EeKU9IrkkToqcw_-1186697952")]
    [Description(@"Certificated Money Market - Periodic Payer.")]
    CertificatedMoneyMarketPeriodicPayer,
    
    /// <summary>
    /// Certificates of Deposit.
    /// Encoded/decoded by serializers as &quot;S507&quot;.
    /// </summary>
    [EnumMember(Value = "S507")]
    [IsoId("_1uykwjL3EeKU9IrkkToqcw_1145908780")]
    [Description(@"Certificates of Deposit.")]
    CertificatesOfDeposit,
    
    /// <summary>
    /// CPI Interest at Maturity (IAM) Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S510&quot;.
    /// </summary>
    [EnumMember(Value = "S510")]
    [IsoId("_1uykwzL3EeKU9IrkkToqcw_-1700471005")]
    [Description(@"CPI Interest at Maturity (IAM) Commercial Paper.")]
    CPIInterestAtMaturityIAMCommercialPaper,
    
    /// <summary>
    /// Periodic Payment Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S511&quot;.
    /// </summary>
    [EnumMember(Value = "S511")]
    [IsoId("_1uykxDL3EeKU9IrkkToqcw_785211249")]
    [Description(@"Periodic Payment Commercial Paper.")]
    PeriodicPaymentCommercialPaper,
    
    /// <summary>
    /// CPI Discount Commercial Paper (CP).
    /// Encoded/decoded by serializers as &quot;S520&quot;.
    /// </summary>
    [EnumMember(Value = "S520")]
    [IsoId("_1uykxTL3EeKU9IrkkToqcw_-1957967186")]
    [Description(@"CPI Discount Commercial Paper (CP).")]
    CPIDiscountCommercialPaperCP,
    
    /// <summary>
    /// MMI Corporate Commercial Paper.
    /// Encoded/decoded by serializers as &quot;S525&quot;.
    /// </summary>
    [EnumMember(Value = "S525")]
    [IsoId("_1uykxjL3EeKU9IrkkToqcw_-183672385")]
    [Description(@"MMI Corporate Commercial Paper.")]
    MMICorporateCommercialPaper,
    
    /// <summary>
    /// MMI Corporate VRDO/CP.
    /// Encoded/decoded by serializers as &quot;S526&quot;.
    /// </summary>
    [EnumMember(Value = "S526")]
    [IsoId("_1u7usDL3EeKU9IrkkToqcw_-1160671039")]
    [Description(@"MMI Corporate VRDO/CP.")]
    MMICorporateVRDOCP,
    
    /// <summary>
    /// MTN Medium Term Note.
    /// Encoded/decoded by serializers as &quot;S530&quot;.
    /// </summary>
    [EnumMember(Value = "S530")]
    [IsoId("_1u7usTL3EeKU9IrkkToqcw_-1502461490")]
    [Description(@"MTN Medium Term Note.")]
    MTNMediumTermNote,
    
    /// <summary>
    /// MMI Deposit Note.
    /// Encoded/decoded by serializers as &quot;S531&quot;.
    /// </summary>
    [EnumMember(Value = "S531")]
    [IsoId("_1u7usjL3EeKU9IrkkToqcw_1382709319")]
    [Description(@"MMI Deposit Note.")]
    MMIDepositNote,
    
    /// <summary>
    /// MMI Medium-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S532&quot;.
    /// </summary>
    [EnumMember(Value = "S532")]
    [IsoId("_1u7uszL3EeKU9IrkkToqcw_376367372")]
    [Description(@"MMI Medium-Term Bank Note.")]
    MMIMediumTermBankNote,
    
    /// <summary>
    /// MMI Medium Term Note.
    /// Encoded/decoded by serializers as &quot;S533&quot;.
    /// </summary>
    [EnumMember(Value = "S533")]
    [IsoId("_1u7utDL3EeKU9IrkkToqcw_959757916")]
    [Description(@"MMI Medium Term Note.")]
    MMIMediumTermNote,
    
    /// <summary>
    /// Collateralized Mortgage Obligation or Global CMO.
    /// Encoded/decoded by serializers as &quot;S540&quot;.
    /// </summary>
    [EnumMember(Value = "S540")]
    [IsoId("_1u7utTL3EeKU9IrkkToqcw_-171294477")]
    [Description(@"Collateralized Mortgage Obligation or Global CMO.")]
    CollateralizedMtgeObligationorGlobalCMO,
    
    /// <summary>
    /// Asset-Backed security (ABS) or global ABS (GABS).
    /// Encoded/decoded by serializers as &quot;S541&quot;.
    /// </summary>
    [EnumMember(Value = "S541")]
    [IsoId("_1u7utjL3EeKU9IrkkToqcw_-583656522")]
    [Description(@"Asset-Backed security (ABS) or global ABS (GABS).")]
    AssetBackedSecurityABSorGlobalABSGABS,
    
    /// <summary>
    /// Non-CMO/ABS Amortizing Issue.
    /// Encoded/decoded by serializers as &quot;S542&quot;.
    /// </summary>
    [EnumMember(Value = "S542")]
    [IsoId("_1vFfsDL3EeKU9IrkkToqcw_1270120523")]
    [Description(@"Non-CMO/ABS Amortizing Issue.")]
    NonCMOABSAmortizingIssue,
    
    /// <summary>
    /// MMI Short-Term Bank Note.
    /// Encoded/decoded by serializers as &quot;S550&quot;.
    /// </summary>
    [EnumMember(Value = "S550")]
    [IsoId("_1vFfsTL3EeKU9IrkkToqcw_844040264")]
    [Description(@"MMI Short-Term Bank Note.")]
    MMIShortTermBankNote,
    
    /// <summary>
    /// Z CPN Denomination in Initial Principal Amt.
    /// Encoded/decoded by serializers as &quot;S551&quot;.
    /// </summary>
    [EnumMember(Value = "S551")]
    [IsoId("_1vFfsjL3EeKU9IrkkToqcw_-936173")]
    [Description(@"Z CPN Denomination in Initial Principal Amt.")]
    ZCPNDenominInitialPrincipalAmt,
    
    /// <summary>
    /// MMI Discount Note.
    /// Encoded/decoded by serializers as &quot;S560&quot;.
    /// </summary>
    [EnumMember(Value = "S560")]
    [IsoId("_1vFfszL3EeKU9IrkkToqcw_1292765868")]
    [Description(@"MMI Discount Note.")]
    MMIDiscountNote,
    
    /// <summary>
    /// Corporate Auction Rate Note.
    /// Encoded/decoded by serializers as &quot;S571&quot;.
    /// </summary>
    [EnumMember(Value = "S571")]
    [IsoId("_1vFftDL3EeKU9IrkkToqcw_2005124833")]
    [Description(@"Corporate Auction Rate Note.")]
    CorporateAuctionRateNote,
    
    /// <summary>
    /// Convertible Corporate Debt.
    /// Encoded/decoded by serializers as &quot;S572&quot;.
    /// </summary>
    [EnumMember(Value = "S572")]
    [IsoId("_1vFftTL3EeKU9IrkkToqcw_-1340246748")]
    [Description(@"Convertible Corporate Debt.")]
    ConvertibleCorporateDebt,
    
    /// <summary>
    /// Corporate Variable Mode Obligation (CVMO).
    /// Encoded/decoded by serializers as &quot;S573&quot;.
    /// </summary>
    [EnumMember(Value = "S573")]
    [IsoId("_1vFftjL3EeKU9IrkkToqcw_-1315718626")]
    [Description(@"Corporate Variable Mode Obligation (CVMO).")]
    CorporateVariableModeObligationCVMO,
    
    /// <summary>
    /// Corporate Short-Term Note.
    /// Encoded/decoded by serializers as &quot;S574&quot;.
    /// </summary>
    [EnumMember(Value = "S574")]
    [IsoId("_1vPQsDL3EeKU9IrkkToqcw_1415111367")]
    [Description(@"Corporate Short-Term Note.")]
    CorporateShortTermNote,
    
    /// <summary>
    /// Corporate Debenture.
    /// Encoded/decoded by serializers as &quot;S575&quot;.
    /// </summary>
    [EnumMember(Value = "S575")]
    [IsoId("_1vPQsTL3EeKU9IrkkToqcw_-822757287")]
    [Description(@"Corporate Debenture.")]
    CorporateDebenture,
    
    /// <summary>
    /// Corporate VRDO / Municipal VRDO (MMD).
    /// Encoded/decoded by serializers as &quot;S576&quot;.
    /// </summary>
    [EnumMember(Value = "S576")]
    [IsoId("_1vPQsjL3EeKU9IrkkToqcw_834329093")]
    [Description(@"Corporate VRDO / Municipal VRDO (MMD).")]
    CorporateVRDOMunicipalVRDOMMD,
    
    /// <summary>
    /// Corporate Insured Custodial Receipt.
    /// Encoded/decoded by serializers as &quot;S577&quot;.
    /// </summary>
    [EnumMember(Value = "S577")]
    [IsoId("_1vPQszL3EeKU9IrkkToqcw_-627115428")]
    [Description(@"Corporate Insured Custodial Receipt.")]
    CorporateInsuredCustodialReceipt,
    
    /// <summary>
    /// Tender Rate Note.
    /// Encoded/decoded by serializers as &quot;S578&quot;.
    /// </summary>
    [EnumMember(Value = "S578")]
    [IsoId("_1vPQtDL3EeKU9IrkkToqcw_-889657156")]
    [Description(@"Tender Rate Note.")]
    TenderRateNote,
    
    /// <summary>
    /// Zero Coupon Bond.
    /// Encoded/decoded by serializers as &quot;S579&quot;.
    /// </summary>
    [EnumMember(Value = "S579")]
    [IsoId("_1vPQtTL3EeKU9IrkkToqcw_-1932293028")]
    [Description(@"Zero Coupon Bond.")]
    ZeroCouponBond,
    
    /// <summary>
    /// Government security.
    /// Encoded/decoded by serializers as &quot;S601&quot;.
    /// </summary>
    [EnumMember(Value = "S601")]
    [IsoId("_1vPQtjL3EeKU9IrkkToqcw_1537969818")]
    [Description(@"Government security.")]
    GovernmentSecurity,
    
    /// <summary>
    /// Government Trust Certificate.
    /// Encoded/decoded by serializers as &quot;S602&quot;.
    /// </summary>
    [EnumMember(Value = "S602")]
    [IsoId("_1vPQtzL3EeKU9IrkkToqcw_1226234330")]
    [Description(@"Government Trust Certificate.")]
    GovernmentTrustCertificate,
    
    /// <summary>
    /// Junk and Treasury Growth Receipt (JGR).
    /// Encoded/decoded by serializers as &quot;S603&quot;.
    /// </summary>
    [EnumMember(Value = "S603")]
    [IsoId("_1vYaoDL3EeKU9IrkkToqcw_-47492641")]
    [Description(@"Junk and Treasury Growth Receipt (JGR).")]
    JunkAndTreasuryGrowthReceiptJGR,
    
    /// <summary>
    /// U.S. Treasury security.
    /// Encoded/decoded by serializers as &quot;S610&quot;.
    /// </summary>
    [EnumMember(Value = "S610")]
    [IsoId("_1vYaoTL3EeKU9IrkkToqcw_762291671")]
    [Description(@"U.S. Treasury security.")]
    USTreasurySecurity,
    
    /// <summary>
    /// US Treasury Bill.
    /// Encoded/decoded by serializers as &quot;S611&quot;.
    /// </summary>
    [EnumMember(Value = "S611")]
    [IsoId("_1vYaojL3EeKU9IrkkToqcw_1354888854")]
    [Description(@"US Treasury Bill.")]
    USTreasuryBill,
    
    /// <summary>
    /// US Treasury Note.
    /// Encoded/decoded by serializers as &quot;S612&quot;.
    /// </summary>
    [EnumMember(Value = "S612")]
    [IsoId("_1vYaozL3EeKU9IrkkToqcw_1193800547")]
    [Description(@"US Treasury Note.")]
    USTreasuryNote,
    
    /// <summary>
    /// US Treasury Bond.
    /// Encoded/decoded by serializers as &quot;S613&quot;.
    /// </summary>
    [EnumMember(Value = "S613")]
    [IsoId("_1vYapDL3EeKU9IrkkToqcw_976811622")]
    [Description(@"US Treasury Bond.")]
    USTreasuryBond,
    
    /// <summary>
    /// U.S. government agency security.
    /// Encoded/decoded by serializers as &quot;S620&quot;.
    /// </summary>
    [EnumMember(Value = "S620")]
    [IsoId("_1vYapTL3EeKU9IrkkToqcw_-686330670")]
    [Description(@"U.S. government agency security.")]
    USGovernmentAgencySecurity,
    
    /// <summary>
    /// Government Nat&apos;l Mortgage Association (GNMA).
    /// Encoded/decoded by serializers as &quot;S650&quot;.
    /// </summary>
    [EnumMember(Value = "S650")]
    [IsoId("_1viLoDL3EeKU9IrkkToqcw_-867529286")]
    [Description(@"Government Nat'l Mortgage Association (GNMA).")]
    GovernmentNatlMortgageAssociationGNMA,
    
    /// <summary>
    /// REMIC (Real Estate Mortgage Investment Conduit).
    /// Encoded/decoded by serializers as &quot;S651&quot;.
    /// </summary>
    [EnumMember(Value = "S651")]
    [IsoId("_1viLoTL3EeKU9IrkkToqcw_-1765787746")]
    [Description(@"REMIC (Real Estate Mortgage Investment Conduit).")]
    REMICRealEstateMtgeInvestmentConduit,
    
    /// <summary>
    /// GNMA Serial Note.
    /// Encoded/decoded by serializers as &quot;S652&quot;.
    /// </summary>
    [EnumMember(Value = "S652")]
    [IsoId("_1viLojL3EeKU9IrkkToqcw_-849963853")]
    [Description(@"GNMA Serial Note.")]
    GNMASerialNote,
    
    /// <summary>
    /// Package.
    /// Encoded/decoded by serializers as &quot;S700&quot;.
    /// </summary>
    [EnumMember(Value = "S700")]
    [IsoId("_1viLozL3EeKU9IrkkToqcw_-228654683")]
    [Description(@"Package.")]
    Package,
    
    /// <summary>
    /// Corporate Debt Derivative.
    /// Encoded/decoded by serializers as &quot;S704&quot;.
    /// </summary>
    [EnumMember(Value = "S704")]
    [IsoId("_1viLpDL3EeKU9IrkkToqcw_-1078944495")]
    [Description(@"Corporate Debt Derivative.")]
    CorporateDebtDerivative,
    
    /// <summary>
    /// Equity Derivative.
    /// Encoded/decoded by serializers as &quot;S705&quot;.
    /// </summary>
    [EnumMember(Value = "S705")]
    [IsoId("_1viLpTL3EeKU9IrkkToqcw_498931113")]
    [Description(@"Equity Derivative.")]
    EquityDerivative,
    
    /// <summary>
    /// Municipal Derivative.
    /// Encoded/decoded by serializers as &quot;S706&quot;.
    /// </summary>
    [EnumMember(Value = "S706")]
    [IsoId("_1viLpjL3EeKU9IrkkToqcw_-1812446398")]
    [Description(@"Municipal Derivative.")]
    MunicipalDerivative,
    
    /// <summary>
    /// Municipal Amortized Issue.
    /// Encoded/decoded by serializers as &quot;S708&quot;.
    /// </summary>
    [EnumMember(Value = "S708")]
    [IsoId("_1viLpzL3EeKU9IrkkToqcw_2009760948")]
    [Description(@"Municipal Amortized Issue.")]
    MunicipalAmortizedIssue,
    
    /// <summary>
    /// Option Derivative.
    /// Encoded/decoded by serializers as &quot;S710&quot;.
    /// </summary>
    [EnumMember(Value = "S710")]
    [IsoId("_1vr8oDL3EeKU9IrkkToqcw_-1238216508")]
    [Description(@"Option Derivative.")]
    OptionDerivative,
    
    /// <summary>
    /// Warrant.
    /// Encoded/decoded by serializers as &quot;S720&quot;.
    /// </summary>
    [EnumMember(Value = "S720")]
    [IsoId("_1vr8oTL3EeKU9IrkkToqcw_-970532350")]
    [Description(@"Warrant.")]
    Warrant,
    
    /// <summary>
    /// Right.
    /// Encoded/decoded by serializers as &quot;S730&quot;.
    /// </summary>
    [EnumMember(Value = "S730")]
    [IsoId("_1vr8ojL3EeKU9IrkkToqcw_-1855635595")]
    [Description(@"Right.")]
    Right,
    
    /// <summary>
    /// Mutual Fund.
    /// Encoded/decoded by serializers as &quot;S760&quot;.
    /// </summary>
    [EnumMember(Value = "S760")]
    [IsoId("_1vr8ozL3EeKU9IrkkToqcw_-851715296")]
    [Description(@"Mutual Fund.")]
    MutualFund,
    
    /// <summary>
    /// Closed End Fund.
    /// Encoded/decoded by serializers as &quot;S761&quot;.
    /// </summary>
    [EnumMember(Value = "S761")]
    [IsoId("_1vr8pDL3EeKU9IrkkToqcw_-1960086610")]
    [Description(@"Closed End Fund.")]
    ClosedEndFund,
    
    /// <summary>
    /// (IMMI) Institutional MMI Mutual Fund Shares.
    /// Encoded/decoded by serializers as &quot;S762&quot;.
    /// </summary>
    [EnumMember(Value = "S762")]
    [IsoId("_1v1GkDL3EeKU9IrkkToqcw_1628377162")]
    [Description(@"(IMMI) Institutional MMI Mutual Fund Shares.")]
    IMMIInstitutionalMMIMutualFundShares,
    
    /// <summary>
    /// Equity Unit.
    /// Encoded/decoded by serializers as &quot;S780&quot;.
    /// </summary>
    [EnumMember(Value = "S780")]
    [IsoId("_1v1GkTL3EeKU9IrkkToqcw_1638047686")]
    [Description(@"Equity Unit.")]
    EquityUnit,
    
    /// <summary>
    /// Debt Unit.
    /// Encoded/decoded by serializers as &quot;S781&quot;.
    /// </summary>
    [EnumMember(Value = "S781")]
    [IsoId("_1v1GkjL3EeKU9IrkkToqcw_1215007434")]
    [Description(@"Debt Unit.")]
    DebtUnit,
    
    /// <summary>
    /// Unit Investment Trust (UIT) - Nuveen Only.
    /// Encoded/decoded by serializers as &quot;S790&quot;.
    /// </summary>
    [EnumMember(Value = "S790")]
    [IsoId("_1v1GkzL3EeKU9IrkkToqcw_316548064")]
    [Description(@"Unit Investment Trust (UIT) - Nuveen Only.")]
    UnitInvestmentTrustUITNuveenOnly,
    
    /// <summary>
    /// Global Unit Trust.
    /// Encoded/decoded by serializers as &quot;S791&quot;.
    /// </summary>
    [EnumMember(Value = "S791")]
    [IsoId("_1v1GlDL3EeKU9IrkkToqcw_-507331362")]
    [Description(@"Global Unit Trust.")]
    GlobalUnitTrust,
    
    /// <summary>
    /// Unit Investment Trust (UIT).
    /// Encoded/decoded by serializers as &quot;S795&quot;.
    /// </summary>
    [EnumMember(Value = "S795")]
    [IsoId("_1v1GlTL3EeKU9IrkkToqcw_-101061388")]
    [Description(@"Unit Investment Trust (UIT).")]
    UnitInvestmentTrustUIT,
    
    /// <summary>
    /// Equity, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S121&quot;.
    /// </summary>
    [EnumMember(Value = "S121")]
    [IsoId("_1v1GljL3EeKU9IrkkToqcw_25468788")]
    [Description(@"Equity, subject to 144a, designated investors.")]
    Equity144aDesignatedInvestors,
    
    /// <summary>
    /// Municipal debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S346&quot;.
    /// </summary>
    [EnumMember(Value = "S346")]
    [IsoId("_1v-3kDL3EeKU9IrkkToqcw_-125882065")]
    [Description(@"Municipal debt, classified as other, subject to tax exempt.")]
    MunicipalOtherTaxExempt,
    
    /// <summary>
    /// Corporate debt, classified as other, subject to tax exempt.
    /// Encoded/decoded by serializers as &quot;S546&quot;.
    /// </summary>
    [EnumMember(Value = "S546")]
    [IsoId("_1v-3kTL3EeKU9IrkkToqcw_-1398080328")]
    [Description(@"Corporate debt, classified as other, subject to tax exempt.")]
    CorporateOtherTaxExempt,
    
    /// <summary>
    /// Corporate debt, subject to 144a, designated investors.
    /// Encoded/decoded by serializers as &quot;S545&quot;.
    /// </summary>
    [EnumMember(Value = "S545")]
    [IsoId("_1v-3kjL3EeKU9IrkkToqcw_191144524")]
    [Description(@"Corporate debt, subject to 144a, designated investors.")]
    Corporate144aDesignatedInvestors,
    
    /// <summary>
    /// Non standard asset user CUSIP.
    /// Encoded/decoded by serializers as &quot;S127&quot;.
    /// </summary>
    [EnumMember(Value = "S127")]
    [IsoId("_OV0CwJ2LEeW-bsa36JFb9A")]
    [Description(@"Non standard asset user CUSIP.")]
    NonStandardAssetUserCUSIP,
    
}
