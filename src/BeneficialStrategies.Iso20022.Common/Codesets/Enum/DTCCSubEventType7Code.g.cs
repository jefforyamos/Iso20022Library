﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCSubEventType7Code.  ISO2002 ID# _8FNzoe2OEeiWtrflKsFqHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8FNzoe2OEeiWtrflKsFqHg")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.")]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
public enum DTCCSubEventType7Code
{
    /// <summary>
    /// Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).
    /// Encoded/decoded by serializers as "OPTO".
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_8oVHwe2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).")]
    OptOut = DTCCSubEventTypeCode.OptOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as "DRPD".
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_8oVHw-2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).")]
    DividendReinvestmentByDTC = DTCCSubEventTypeCode.DividendReinvestmentByDTC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as "PLCL".
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_8oVHxe2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing = DTCCSubEventTypeCode.PlaceOfListing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as "BLOT".
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_8oVHx-2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot = DTCCSubEventTypeCode.BoardLot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.
    /// Encoded/decoded by serializers as "RMRK".
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_8oVHye2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.")]
    Remarketing = DTCCSubEventTypeCode.Remarketing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where "unwinding" of the basket of securities occurs.
    /// Encoded/decoded by serializers as "UNWD".
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_8oVHy-2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind = DTCCSubEventTypeCode.Unwind, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "SHEX".
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_8oeRse2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.")]
    ShareExchange = DTCCSubEventTypeCode.ShareExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "STDT".
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_8oeRs-2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.")]
    Standard = DTCCSubEventTypeCode.Standard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "XFER".
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_8ooCsO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.")]
    Transfer = DTCCSubEventTypeCode.Transfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as "SOPT".
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_8ooCsu2OEeiWtrflKsFqHg")]
    [Description(@"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.")]
    SurvivorOptions = DTCCSubEventTypeCode.SurvivorOptions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as "MBCK".
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_8ooCtO2OEeiWtrflKsFqHg")]
    [Description(@"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.")]
    MortgageBacked = DTCCSubEventTypeCode.MortgageBacked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as "SALE".
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_8ooCtu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the distribution is from the proceeds of the sale of assets.")]
    SaleOfAssets = DTCCSubEventTypeCode.SaleOfAssets, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as "PRNI".
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_8ooCuO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.")]
    PhysicalRightsNotIssued = DTCCSubEventTypeCode.PhysicalRightsNotIssued, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as "POPI".
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_8ooCuu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill = DTCCSubEventTypeCode.PoisonPill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as "DRPI".
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_8ooCvO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).")]
    DividendReinvestmentByIssuer = DTCCSubEventTypeCode.DividendReinvestmentByIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as "MROS".
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_8ooCvu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.")]
    MandatoryRedemptionOfShares = DTCCSubEventTypeCode.MandatoryRedemptionOfShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as "SHPP".
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_8ooCwO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).")]
    SharePurchasePlan = DTCCSubEventTypeCode.SharePurchasePlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as "OPOF".
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_8ooCwu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer = DTCCSubEventTypeCode.OpenOffer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as "TWRI".
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_8ooCxO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.")]
    TenderWithRights = DTCCSubEventTypeCode.TenderWithRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to "sell" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as "CILI".
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_8ooCxu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.")]
    CashinLieu = DTCCSubEventTypeCode.CashinLieu, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as "BTST".
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_8ooCyO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.")]
    BidTenderSealedTender = DTCCSubEventTypeCode.BidTenderSealedTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as "FTPR".
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_8ooCyu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.")]
    OfferToPurchase = DTCCSubEventTypeCode.OfferToPurchase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as "ADRS".
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_8ooCzO2OEeiWtrflKsFqHg")]
    [Description(@"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.")]
    ADR = DTCCSubEventTypeCode.ADR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a consent event with payout.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_8ooCzu2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a consent event with payout.")]
    WithPayout = DTCCSubEventTypeCode.WithPayout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a consent event without payout.
    /// Encoded/decoded by serializers as "WITO".
    /// </summary>
    [EnumMember(Value = "WITO")]
    [IsoId("_8ooC0O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a consent event without payout.")]
    WithoutPayout = DTCCSubEventTypeCode.WithoutPayout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where a tax credit relating to the Build America Bonds will occur.
    /// Encoded/decoded by serializers as "CTAX".
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_8ooC0u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where a tax credit relating to the Build America Bonds will occur.")]
    TaxCredit = DTCCSubEventTypeCode.TaxCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an exchange offer on securities that are subject to Securities Rule 144A.
    /// Encoded/decoded by serializers as "A144".
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_8ooC1O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an exchange offer on securities that are subject to Securities Rule 144A.")]
    USLegal144A = DTCCSubEventTypeCode.USLegal144A, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the payout will be both cash and securities.
    /// Encoded/decoded by serializers as "CASE".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_8ooC1u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the payout will be both cash and securities.")]
    CashAndSecurities = DTCCSubEventTypeCode.CashAndSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an exchange offer on securities that are subject to securities rule Reg S.
    /// Encoded/decoded by serializers as "REGS".
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_8ooC2O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an exchange offer on securities that are subject to securities rule Reg S.")]
    RegulationS = DTCCSubEventTypeCode.RegulationS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a MMI Important Notice.
    /// Encoded/decoded by serializers as "NOTI".
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_8ooC2u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a MMI Important Notice.")]
    ImportantNotice = DTCCSubEventTypeCode.ImportantNotice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event which will be based on record date holdings.
    /// Encoded/decoded by serializers as "RDTH".
    /// </summary>
    [EnumMember(Value = "RDTH")]
    [IsoId("_8ooC3O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event which will be based on record date holdings.")]
    BasedOnRecordDateHoldings = DTCCSubEventTypeCode.BasedOnRecordDateHoldings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the payout will be cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_8ooC3u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the payout will be cash.")]
    Cash = DTCCSubEventTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the presentation of securities will be required.
    /// Encoded/decoded by serializers as "PREQ".
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_8ooC4O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the presentation of securities will be required.")]
    PresentationRequired = DTCCSubEventTypeCode.PresentationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event where the payout will be securities.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_8ooC4u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event where the payout will be securities.")]
    Securities = DTCCSubEventTypeCode.Securities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a tender offer with a convert feature.
    /// Encoded/decoded by serializers as "COTE".
    /// </summary>
    [EnumMember(Value = "COTE")]
    [IsoId("_8ooC5O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies a tender offer with a convert feature.")]
    ConvertAndTender = DTCCSubEventTypeCode.ConvertAndTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies when a tender offer is a mini tender.
    /// Encoded/decoded by serializers as "MITE".
    /// </summary>
    [EnumMember(Value = "MITE")]
    [IsoId("_8ooC5u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies when a tender offer is a mini tender.")]
    MiniTender = DTCCSubEventTypeCode.MiniTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies when a tender offer is a self tender.
    /// Encoded/decoded by serializers as "SETE".
    /// </summary>
    [EnumMember(Value = "SETE")]
    [IsoId("_8ooC6O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies when a tender offer is a self tender.")]
    SelfTender = DTCCSubEventTypeCode.SelfTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies when the event security is a GDR. The underlying security is a global depositary receipt.
    /// Encoded/decoded by serializers as "GDRS".
    /// </summary>
    [EnumMember(Value = "GDRS")]
    [IsoId("_8ooC6u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies when the event security is a GDR. The underlying security is a global depositary receipt.")]
    GDR = DTCCSubEventTypeCode.GDR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.
    /// Encoded/decoded by serializers as "M871".
    /// </summary>
    [EnumMember(Value = "M871")]
    [IsoId("_8ooC7O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.")]
    DividendEquivalentPayment871M = DTCCSubEventTypeCode.DividendEquivalentPayment871M, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.
    /// Encoded/decoded by serializers as "C305".
    /// </summary>
    [EnumMember(Value = "C305")]
    [IsoId("_8ooC7u2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.")]
    DeemedDividend305C = DTCCSubEventTypeCode.DeemedDividend305C, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an event which is a full call or a maturity with conversion.
    /// Encoded/decoded by serializers as "CONV".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_8ooC8O2OEeiWtrflKsFqHg")]
    [Description(@"Identifies an event which is a full call or a maturity with conversion.")]
    Conversion = DTCCSubEventTypeCode.Conversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name change with presentation required without new CUSIP.
    /// Encoded/decoded by serializers as "NCPR".
    /// </summary>
    [EnumMember(Value = "NCPR")]
    [IsoId("__akl4e2OEeiWtrflKsFqHg")]
    [Description(@"Name change with presentation required without new CUSIP.")]
    NameChangeAndPresentationRequired = DTCCSubEventTypeCode.NameChangeAndPresentationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name change with both CUSIP change and presentation required.
    /// Encoded/decoded by serializers as "CUPR".
    /// </summary>
    [EnumMember(Value = "CUPR")]
    [IsoId("__hRDwe2OEeiWtrflKsFqHg")]
    [Description(@"Name change with both CUSIP change and presentation required.")]
    NameAndCUSIPChangeAndPresentationRequired = DTCCSubEventTypeCode.NameAndCUSIPChangeAndPresentationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name change with CUSIP change.
    /// Encoded/decoded by serializers as "CUSP".
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("__nzwoe2OEeiWtrflKsFqHg")]
    [Description(@"Name change with CUSIP change.")]
    NameAndCUSIPChange = DTCCSubEventTypeCode.NameAndCUSIPChange, // same ordinal as derivation source for type conversions
    
}
