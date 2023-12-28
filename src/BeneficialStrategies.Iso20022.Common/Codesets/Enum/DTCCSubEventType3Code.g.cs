﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCSubEventType3Code.  ISO2002 ID# _tnpJIWJQEeOfOt7Y7nAPUA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tnpJIWJQEeOfOt7Y7nAPUA")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.")]
[DerivedFrom(typeof(DTCCSubEventTypeCode))]
public enum DTCCSubEventType3Code
{
    /// <summary>
    /// Identifies a change in the place where the security is listed.
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "PLCL")]
    [IsoId("_uBYe1WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies a change in the place where the security is listed.")]
    PlaceOfListing,
    
    /// <summary>
    /// Identifies a change in Board Lot size.
    /// Encoded/decoded by serializers as "BoardLot".
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_uBYe12JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies a change in Board Lot size.")]
    BoardLot,
    
    /// <summary>
    /// Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.
    /// Encoded/decoded by serializers as "Remarketing".
    /// </summary>
    [EnumMember(Value = "RMRK")]
    [IsoId("_uBYe2WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event that involves a Stock Purchase Contract product that is offering an early settlement or remarketing feature prior to the contract's expiration.")]
    Remarketing,
    
    /// <summary>
    /// Identifies an event where "unwinding" of the basket of securities occurs.
    /// Encoded/decoded by serializers as "Unwind".
    /// </summary>
    [EnumMember(Value = "UNWD")]
    [IsoId("_uBYe22JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where ""unwinding"" of the basket of securities occurs.")]
    Unwind,
    
    /// <summary>
    /// Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "ShareExchange".
    /// </summary>
    [EnumMember(Value = "SHEX")]
    [IsoId("_uBYe3WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where two companies exchange their shares during a merger. After the share exchange, one company becomes a subsidiary of the other and is no longer listed. Usually applicable to an event in JP markets.")]
    ShareExchange,
    
    /// <summary>
    /// Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "Standard".
    /// </summary>
    [EnumMember(Value = "STDT")]
    [IsoId("_uBYe32JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where one company merges with the other and assumes the name of the surviving company. It is the standard market-accepted merger. Usually applicable to an event in JP markets.")]
    Standard,
    
    /// <summary>
    /// Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.
    /// Encoded/decoded by serializers as "Transfer".
    /// </summary>
    [EnumMember(Value = "XFER")]
    [IsoId("_uBYe4WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where one company transfers all of its shares to a newly created company. Usually applicable to an event in JP markets.")]
    Transfer,
    
    /// <summary>
    /// Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.
    /// Encoded/decoded by serializers as "SurvivorOptions".
    /// </summary>
    [EnumMember(Value = "SOPT")]
    [IsoId("_uBYe42JQEeOfOt7Y7nAPUA")]
    [Description(@"Indicates an event where the Issue has an early redemption feature. This feature allows the holder to elect to sell bonds back to the issuer on a predetermined basis (excluding monthly) according to specific priorities.")]
    SurvivorOptions,
    
    /// <summary>
    /// Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.
    /// Encoded/decoded by serializers as "MortgageBacked".
    /// </summary>
    [EnumMember(Value = "MBCK")]
    [IsoId("_uBYe5WJQEeOfOt7Y7nAPUA")]
    [Description(@"Indicates an event where the issue has an early redemption feature that allows the holder to elect to sell bonds back to the issuer on a monthly basis, according to specified conditions.")]
    MortgageBacked,
    
    /// <summary>
    /// Identifies an event where the distribution is from the proceeds of the sale of assets.
    /// Encoded/decoded by serializers as "SaleOfAssets".
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_uBYe52JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where the distribution is from the proceeds of the sale of assets.")]
    SaleOfAssets,
    
    /// <summary>
    /// Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.
    /// Encoded/decoded by serializers as "PhysicalRightsNotIssued".
    /// </summary>
    [EnumMember(Value = "PRNI")]
    [IsoId("_uBYe6WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where the company is not issuing a security with the right to subscribe for additional shares. In these instances, a User CUSIP is created by DTC (The Depository Trust Company) as opposed to a company-issued CUSIP in order to identify these issues.")]
    PhysicalRightsNotIssued,
    
    /// <summary>
    /// Identifies sale of rights event where issuers redeem poison pill rights.
    /// Encoded/decoded by serializers as "PoisonPill".
    /// </summary>
    [EnumMember(Value = "POPI")]
    [IsoId("_uBYe62JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies sale of rights event where issuers redeem poison pill rights.")]
    PoisonPill,
    
    /// <summary>
    /// Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).
    /// Encoded/decoded by serializers as "DividendReinvestmentByIssuer".
    /// </summary>
    [EnumMember(Value = "DRPI")]
    [IsoId("_uBYe7WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where the issuer offers a dividend reinvestment program that is not processed by DTC (the Depository Trust Company).")]
    DividendReinvestmentByIssuer,
    
    /// <summary>
    /// Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.
    /// Encoded/decoded by serializers as "MandatoryRedemptionOfShares".
    /// </summary>
    [EnumMember(Value = "MROS")]
    [IsoId("_uBYe72JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event where redemption shares are issued in addition to shares of the original security. This is related to the Mandatory Exchange event with the same sub-event type name.")]
    MandatoryRedemptionOfShares,
    
    /// <summary>
    /// Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).
    /// Encoded/decoded by serializers as "SharePurchasePlan".
    /// </summary>
    [EnumMember(Value = "SHPP")]
    [IsoId("_uBYe8WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event involving the offer of shares by a corporation listed on the Australia Stock Exchange, in which ASIC will give relief so that the company can offer existing shareholders the opportunity to acquire small numbers of additional shares without needing a disclosure document or Product Disclosure Statement (PDS).")]
    SharePurchasePlan,
    
    /// <summary>
    /// Identifies an event in certain markets where underlying rights are not issued.
    /// Encoded/decoded by serializers as "OpenOffer".
    /// </summary>
    [EnumMember(Value = "OPOF")]
    [IsoId("_uBYe82JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies an event in certain markets where underlying rights are not issued.")]
    OpenOffer,
    
    /// <summary>
    /// Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.
    /// Encoded/decoded by serializers as "TenderWithRights".
    /// </summary>
    [EnumMember(Value = "TWRI")]
    [IsoId("_uBYe9WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies a tender offer event on a Rights security. Holders must submit both the ordinary share(s) and right(s) to be eligible to receive the tender consideration. The ratio of ordinary shares to rights is defined in the offer.")]
    TenderWithRights,
    
    /// <summary>
    /// Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to "sell" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.
    /// Encoded/decoded by serializers as "CashinLieu".
    /// </summary>
    [EnumMember(Value = "CILI")]
    [IsoId("_uBYe92JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies DTC (the Depository Trust Company) specific sub-event where holders can elect to ""sell"" whole shares to satisfy fractional entitlements (usually as a result of a merger) at the beneficial owner level.")]
    CashinLieu,
    
    /// <summary>
    /// Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.
    /// Encoded/decoded by serializers as "BidTenderSealedTender".
    /// </summary>
    [EnumMember(Value = "BTST")]
    [IsoId("_uBYe-WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies a tender offer event in which the holder can choose the price at which they are willing to tender their securities. This price may or may not be accepted by the offeror.")]
    BidTenderSealedTender,
    
    /// <summary>
    /// Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.
    /// Encoded/decoded by serializers as "OfferToPurchase".
    /// </summary>
    [EnumMember(Value = "FTPR")]
    [IsoId("_uBYe-2JQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies a tender offer event made by another company to purchase a portion or all of the outstanding shares.")]
    OfferToPurchase,
    
    /// <summary>
    /// Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.
    /// Encoded/decoded by serializers as "ADR".
    /// </summary>
    [EnumMember(Value = "ADRS")]
    [IsoId("_uBYe_WJQEeOfOt7Y7nAPUA")]
    [Description(@"Identifies when the event security is an ADR. The underlying security is American Depositary Receipt.")]
    ADR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCCSubEventType3CodeMetadataExtensions
{
    private static readonly DTCCSubEventType3CodeDropdownSource _dropdownSource = new DTCCSubEventType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCCSubEventType3CodeDropdownRow GetMetadata(this DTCCSubEventType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


