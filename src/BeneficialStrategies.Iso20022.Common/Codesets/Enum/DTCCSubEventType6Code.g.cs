﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCSubEventType6Code.  ISO2002 ID# _PxwL0b_oEeeb2ZBoAlSG1Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PxwL0b_oEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.")]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
public enum DTCCSubEventType6Code
{
    /// <summary>
    /// Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).
    /// Encoded/decoded by serializers as "OptOut".
    /// </summary>
    [EnumMember(Value = "OPTO")]
    [IsoId("_QB0oIb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event (for example Cash Dividend) where DTC (the Depository Trust Company) offers a DRIP option as a default option (holder must opt out of the DRIP Option).")]
    OptOut,
    
    /// <summary>
    /// Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as "DividendReinvestmentByDTC".
    /// </summary>
    [EnumMember(Value = "DRPD")]
    [IsoId("_QB0oI7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the Issue is eligible for a Dividend Reinvestment program at DTCC (The Depository Trust and Clearing Corporation).")]
    DividendReinvestmentByDTC,
    
    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_QB0oJb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing,
    
    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as "BoardLot".
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_QB0oJ7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot,
    
    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.
    /// Encoded/decoded by serializers as "Remarketing".
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_QB0oKb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.")]
    Remarketing,
    
    /// <summary>
    /// Identifies an event where "unwinding" of the basket of securities occurs.
    /// Encoded/decoded by serializers as "Unwind".
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_QB0oK7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind,
    
    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "ShareExchange".
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_QB0oLb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.")]
    ShareExchange,
    
    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "Standard".
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_QB0oL7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.")]
    Standard,
    
    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "Transfer".
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_QB0oMb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.")]
    Transfer,
    
    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as "SurvivorOptions".
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_QB0oM7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.")]
    SurvivorOptions,
    
    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as "MortgageBacked".
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_QB0oNb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.")]
    MortgageBacked,
    
    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as "SaleOfAssets".
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_QB0oN7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the distribution is from the proceeds of the sale of assets.")]
    SaleOfAssets,
    
    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as "PhysicalRightsNotIssued".
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_QB0oOb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.")]
    PhysicalRightsNotIssued,
    
    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as "PoisonPill".
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_QB0oO7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill,
    
    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as "DividendReinvestmentByIssuer".
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_QB0oPb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).")]
    DividendReinvestmentByIssuer,
    
    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as "MandatoryRedemptionOfShares".
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_QB0oP7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.")]
    MandatoryRedemptionOfShares,
    
    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as "SharePurchasePlan".
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_QB0oQb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).")]
    SharePurchasePlan,
    
    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as "OpenOffer".
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_QB0oQ7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer,
    
    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as "TenderWithRights".
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_QB0oRb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.")]
    TenderWithRights,
    
    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to "sell" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as "CashinLieu".
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_QB0oR7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.")]
    CashinLieu,
    
    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as "BidTenderSealedTender".
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_QB0oSb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.")]
    BidTenderSealedTender,
    
    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as "OfferToPurchase".
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_QB0oS7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.")]
    OfferToPurchase,
    
    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as "ADR".
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_QB0oTb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.")]
    ADR,
    
    /// <summary>
    /// Identifies a consent event with payout.
    /// Encoded/decoded by serializers as "WithPayout".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_QB0oT7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a consent event with payout.")]
    WithPayout,
    
    /// <summary>
    /// Identifies a consent event without payout.
    /// Encoded/decoded by serializers as "WithoutPayout".
    /// </summary>
    [EnumMember(Value = "WITO")]
    [IsoId("_QB0oUb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a consent event without payout.")]
    WithoutPayout,
    
    /// <summary>
    /// Identifies an event where a tax credit relating to the Build America Bonds will occur.
    /// Encoded/decoded by serializers as "TaxCredit".
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_QB0oU7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where a tax credit relating to the Build America Bonds will occur.")]
    TaxCredit,
    
    /// <summary>
    /// Identifies an exchange offer on securities that are subject to Securities Rule 144A.
    /// Encoded/decoded by serializers as "USLegal144A".
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_QB0oVb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an exchange offer on securities that are subject to Securities Rule 144A.")]
    USLegal144A,
    
    /// <summary>
    /// Identifies an event where the payout will be both cash and securities.
    /// Encoded/decoded by serializers as "CashAndSecurities".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_QB0oV7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the payout will be both cash and securities.")]
    CashAndSecurities,
    
    /// <summary>
    /// Identifies an exchange offer on securities that are subject to securities rule Reg S.
    /// Encoded/decoded by serializers as "RegulationS".
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_QB0oWb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an exchange offer on securities that are subject to securities rule Reg S.")]
    RegulationS,
    
    /// <summary>
    /// Identifies a MMI Important Notice.
    /// Encoded/decoded by serializers as "ImportantNotice".
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_QB0oW7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a MMI Important Notice.")]
    ImportantNotice,
    
    /// <summary>
    /// Identifies an event which will be based on record date holdings.
    /// Encoded/decoded by serializers as "BasedOnRecordDateHoldings".
    /// </summary>
    [EnumMember(Value = "RDTH")]
    [IsoId("_QB0oXb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event which will be based on record date holdings.")]
    BasedOnRecordDateHoldings,
    
    /// <summary>
    /// Identifies an event where the payout will be cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_QB0oX7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the payout will be cash.")]
    Cash,
    
    /// <summary>
    /// Identifies an event where the presentation of securities will be required.
    /// Encoded/decoded by serializers as "PresentationRequired".
    /// </summary>
    [EnumMember(Value = "PREQ")]
    [IsoId("_QB0oYb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the presentation of securities will be required.")]
    PresentationRequired,
    
    /// <summary>
    /// Identifies an event where the payout will be securities.
    /// Encoded/decoded by serializers as "Securities".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_QB0oY7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event where the payout will be securities.")]
    Securities,
    
    /// <summary>
    /// Identifies a tender offer with a convert feature.
    /// Encoded/decoded by serializers as "ConvertAndTender".
    /// </summary>
    [EnumMember(Value = "COTE")]
    [IsoId("_QB0oZb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies a tender offer with a convert feature.")]
    ConvertAndTender,
    
    /// <summary>
    /// Identifies when a tender offer is a mini tender.
    /// Encoded/decoded by serializers as "MiniTender".
    /// </summary>
    [EnumMember(Value = "MITE")]
    [IsoId("_QB0oZ7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies when a tender offer is a mini tender.")]
    MiniTender,
    
    /// <summary>
    /// Identifies when a tender offer is a self tender.
    /// Encoded/decoded by serializers as "SelfTender".
    /// </summary>
    [EnumMember(Value = "SETE")]
    [IsoId("_QB0oab_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies when a tender offer is a self tender.")]
    SelfTender,
    
    /// <summary>
    /// Identifies when the event security is a GDR. The underlying security is a global depositary receipt.
    /// Encoded/decoded by serializers as "GDR".
    /// </summary>
    [EnumMember(Value = "GDRS")]
    [IsoId("_QB0oa7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies when the event security is a GDR. The underlying security is a global depositary receipt.")]
    GDR,
    
    /// <summary>
    /// Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.
    /// Encoded/decoded by serializers as "DividendEquivalentPayment871M".
    /// </summary>
    [EnumMember(Value = "M871")]
    [IsoId("_QB0obb_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event which has been considered a dividend equivalent payment under Section 871(m) of the United States Internal Revenue Code.")]
    DividendEquivalentPayment871M,
    
    /// <summary>
    /// Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.
    /// Encoded/decoded by serializers as "DeemedDividend305C".
    /// </summary>
    [EnumMember(Value = "C305")]
    [IsoId("_QB0ob7_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event which has been considered a deemed distribution under Section 305(c) of the United States  Internal Revenue Code.")]
    DeemedDividend305C,
    
    /// <summary>
    /// Identifies an event which is a full call or a maturity with conversion.
    /// Encoded/decoded by serializers as "Conversion".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_STd6ob_oEeeb2ZBoAlSG1Q")]
    [Description(@"Identifies an event which is a full call or a maturity with conversion.")]
    Conversion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCCSubEventType6CodeMetadataExtensions
{
    private static readonly DTCCSubEventType6CodeDropdownSource _dropdownSource = new DTCCSubEventType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCCSubEventType6CodeDropdownRow GetMetadata(this DTCCSubEventType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


