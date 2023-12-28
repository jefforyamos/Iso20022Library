﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventType3Code.  ISO2002 ID# _bFoOptp-Ed-ak6NoX_4Aeg_1101765603.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bFoOptp-Ed-ak6NoX_4Aeg_1101765603")]
[Description(@"Specifies the corporate action event type.")]
[DerivedFrom(typeof(CorporateActionEventTypeV2Code))]
public enum CorporateActionEventType3Code
{
    /// <summary>
    /// Trading in security has commenced or security has been reactivated after a suspension in trading.
    /// Encoded/decoded by serializers as "ActiveTradingStatus".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bFoOp9p-Ed-ak6NoX_4Aeg_1101765612")]
    [Description(@"Trading in security has commenced or security has been reactivated after a suspension in trading.")]
    ActiveTradingStatus,
    
    /// <summary>
    /// The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as "Attachment".
    /// </summary>
    [EnumMember(Value = "ATTI")]
    [IsoId("_bFoOqNp-Ed-ak6NoX_4Aeg_1101765634")]
    [Description(@"The combination of different security types to create a unit. Units are usually comprised of warrants and bond or warrants and equity. Securities may be combined at the request of the security holder or based on market convention.")]
    Attachment,
    
    /// <summary>
    /// Also called Issuer Bid or Reverse Rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.
    /// Encoded/decoded by serializers as "BidRepurchaseOffer".
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_bFx_oNp-Ed-ak6NoX_4Aeg_1101765635")]
    [Description(@"Also called Issuer Bid or Reverse Rights. Offer to existing shareholders by the issuing company to repurchase equity or other securities convertible into equity. The objective of the offer is to reduce the number of outstanding equities.")]
    BidRepurchaseOffer,
    
    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as "BonusIssue".
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_bFx_odp-Ed-ak6NoX_4Aeg_1101765665")]
    [Description(@"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form.")]
    BonusIssue,
    
    /// <summary>
    /// Early redemption of a security at the election of the holder subject to the terms and condition of the issue.
    /// Encoded/decoded by serializers as "PutRedemption".
    /// </summary>
    [EnumMember(Value = "BPUT")]
    [IsoId("_bFx_otp-Ed-ak6NoX_4Aeg_1101765666")]
    [Description(@"Early redemption of a security at the election of the holder subject to the terms and condition of the issue.")]
    PutRedemption,
    
    /// <summary>
    /// Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.
    /// Encoded/decoded by serializers as "Bankruptcy".
    /// </summary>
    [EnumMember(Value = "BRUP")]
    [IsoId("_bFx_o9p-Ed-ak6NoX_4Aeg_1101765695")]
    [Description(@"Legal status of a company unable to pay creditors. Bankruptcy usually involves a formal court ruling. Securities may become valueless.")]
    Bankruptcy,
    
    /// <summary>
    /// Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.
    /// Encoded/decoded by serializers as "Change".
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_bFx_pNp-Ed-ak6NoX_4Aeg_1101765696")]
    [Description(@"Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.")]
    Change,
    
    /// <summary>
    /// Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price.
    /// Encoded/decoded by serializers as "Conversion".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bFx_pdp-Ed-ak6NoX_4Aeg_1101765726")]
    [Description(@"Conversion of securities (generally convertible bonds or preferred shares) into another form of securities (usually common shares) at a pre-stated price.")]
    Conversion,
    
    /// <summary>
    /// Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a prearranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.
    /// Encoded/decoded by serializers as "CompanyOption".
    /// </summary>
    [EnumMember(Value = "COOP")]
    [IsoId("_bFx_ptp-Ed-ak6NoX_4Aeg_1101765727")]
    [Description(@"Company option may be granted by the company, allowing the holder to take up shares at some future date(s) at a prearranged price in the company. A company may not grant options which enable the holder to take up unissued shares at a time which is five or more years from the date of the grant. Option holders are not members of a company. They are contingent creditors of a company and hence may, in some instances, be entitled to vote on and be bound by a scheme of arrangement between the creditors and the company. As many options have multiple exercise periods a company option will either lapse or carry on to the next expiry date.")]
    CompanyOption,
    
    /// <summary>
    /// Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.
    /// Encoded/decoded by serializers as "DecreaseInValue".
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_bFx_p9p-Ed-ak6NoX_4Aeg_1101765728")]
    [Description(@"Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.")]
    DecreaseInValue,
    
    /// <summary>
    /// Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.
    /// Encoded/decoded by serializers as "Detachment".
    /// </summary>
    [EnumMember(Value = "DETI")]
    [IsoId("_bFx_qNp-Ed-ak6NoX_4Aeg_1101765756")]
    [Description(@"Separation of components that comprise a security usually units comprised of warrants and bond or warrants and equity. Units may be broken up at the request of the security holder or based on market convention.")]
    Detachment,
    
    /// <summary>
    /// Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.
    /// Encoded/decoded by serializers as "TradingStatusDelisted".
    /// </summary>
    [EnumMember(Value = "DLST")]
    [IsoId("_bFx_qdp-Ed-ak6NoX_4Aeg_1101765757")]
    [Description(@"Security is no longer able to comply with the listing requirements of a stock exchange and is removed from official board quotation.")]
    TradingStatusDelisted,
    
    /// <summary>
    /// Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and results are confirmed to bondholder.
    /// Encoded/decoded by serializers as "Drawing".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_bFx_qtp-Ed-ak6NoX_4Aeg_1101765787")]
    [Description(@"Redemption in part before the scheduled final maturity date of a security. Drawing is distinct from partial call since drawn bonds are chosen by lottery and results are confirmed to bondholder.")]
    Drawing,
    
    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as "DividendReinvestment".
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_bF7JkNp-Ed-ak6NoX_4Aeg_1101765788")]
    [Description(@"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.")]
    DividendReinvestment,
    
    /// <summary>
    /// Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.
    /// Encoded/decoded by serializers as "DutchAuction".
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_bF7Jkdp-Ed-ak6NoX_4Aeg_1101765789")]
    [Description(@"Action by a party wishing to acquire a security. Holders of the security are invited to make an offer to sell, within a specific price range. The acquiring party will buy from the holder with lowest offer.")]
    DutchAuction,
    
    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as "DividendOption".
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_bF7Jktp-Ed-ak6NoX_4Aeg_1101766035")]
    [Description(@"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.")]
    DividendOption,
    
    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as "ScripDividend".
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_bF7Jk9p-Ed-ak6NoX_4Aeg_1101766036")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividend,
    
    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as "StockDividend".
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_bF7JlNp-Ed-ak6NoX_4Aeg_1101766065")]
    [Description(@"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.")]
    StockDividend,
    
    /// <summary>
    /// Event is an exchange offer or capital reorganisation. It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.
    /// Encoded/decoded by serializers as "ExchangeOffer".
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_bF7Jldp-Ed-ak6NoX_4Aeg_1101766066")]
    [Description(@"Event is an exchange offer or capital reorganisation. It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.")]
    ExchangeOffer,
    
    /// <summary>
    /// Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).
    /// Encoded/decoded by serializers as "CallOnRights".
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_bF7Jltp-Ed-ak6NoX_4Aeg_1101766067")]
    [Description(@"Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).")]
    CallOnRights,
    
    /// <summary>
    /// Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).
    /// Encoded/decoded by serializers as "CallOnWarrants".
    /// </summary>
    [EnumMember(Value = "EXWA")]
    [IsoId("_bF7Jl9p-Ed-ak6NoX_4Aeg_1101766096")]
    [Description(@"Warrant conversion. Option offered to security holders to buy (call warrant) or to sell (put warrant) a specific amount of stock, cash, or commodity, at a predetermined price, during a predetermined period of time (which usually corresponds to the life of the issue).")]
    CallOnWarrants,
    
    /// <summary>
    /// Increase in the face value of a single security. The number of circulating securities remains unchanged.
    /// Encoded/decoded by serializers as "IncreaseInValue".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_bF7JmNp-Ed-ak6NoX_4Aeg_1101766097")]
    [Description(@"Increase in the face value of a single security. The number of circulating securities remains unchanged.")]
    IncreaseInValue,
    
    /// <summary>
    /// Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.
    /// Encoded/decoded by serializers as "LiquidationDividend".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_bF7Jmdp-Ed-ak6NoX_4Aeg_1101766127")]
    [Description(@"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividend,
    
    /// <summary>
    /// Redemption of an entire issue outstanding of bonds/preferred equity by the issuer before final maturity. Also known as early redemption.
    /// Encoded/decoded by serializers as "FullCall".
    /// </summary>
    [EnumMember(Value = "MCAL")]
    [IsoId("_bGE6kNp-Ed-ak6NoX_4Aeg_1101766128")]
    [Description(@"Redemption of an entire issue outstanding of bonds/preferred equity by the issuer before final maturity. Also known as early redemption.")]
    FullCall,
    
    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as "Merger".
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_bGE6kdp-Ed-ak6NoX_4Aeg_1101766129")]
    [Description(@"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.")]
    Merger,
    
    /// <summary>
    /// Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.
    /// Encoded/decoded by serializers as "OddLotSalePurchase".
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_bGE6ktp-Ed-ak6NoX_4Aeg_1101766157")]
    [Description(@"Sale to or purchase of odd-lots from the issuing company, initiated either by the holder of the security or through an offer made by the issuer.")]
    OddLotSalePurchase,
    
    /// <summary>
    /// Other event, use only when no other event type applies, for example, a new event type.
    /// Encoded/decoded by serializers as "OtherEvent".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bGE6k9p-Ed-ak6NoX_4Aeg_1101766158")]
    [Description(@"Other event, use only when no other event type applies, for example, a new event type.")]
    OtherEvent,
    
    /// <summary>
    /// Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, that is, become identical in all respects. The event may be scheduled in advance or be the result of an outside event.
    /// Encoded/decoded by serializers as "PariPassu".
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_bGE6lNp-Ed-ak6NoX_4Aeg_1102686159")]
    [Description(@"Also called Assimilation or Enfranchisement. Occurs when securities with different characteristics, for example, equities with different entitlements to dividend or voting rights, are assimilated, that is, become identical in all respects. The event may be scheduled in advance or be the result of an outside event.")]
    PariPassu,
    
    /// <summary>
    /// Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.
    /// Encoded/decoded by serializers as "PartialRedemptionWithNominalValueReduction".
    /// </summary>
    [EnumMember(Value = "PCAL")]
    [IsoId("_bGE6ldp-Ed-ak6NoX_4Aeg_1102686160")]
    [Description(@"Securities are redeemed in part before their scheduled final maturity date with reduction of the nominal value of the shares. The outstanding amount of securities will be reduced proportionally.")]
    PartialRedemptionWithNominalValueReduction,
    
    /// <summary>
    /// Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.
    /// Encoded/decoded by serializers as "Prefunding".
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_bGE6ltp-Ed-ak6NoX_4Aeg_1102686161")]
    [Description(@"Also called partial defeasance. Issuer has money set aside to redeem a portion of an issue and the indenture states that the securities could be called earlier than the stated maturity.")]
    Prefunding,
    
    /// <summary>
    /// Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as "PayInKind".
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_bGE6l9p-Ed-ak6NoX_4Aeg_1102686189")]
    [Description(@"Interest payment, in any kind except cash, distributed to holders of an interest bearing asset.")]
    PayInKind,
    
    /// <summary>
    /// Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.
    /// Encoded/decoded by serializers as "PlaceOfIncorporation".
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_bGE6mNp-Ed-ak6NoX_4Aeg_1102686190")]
    [Description(@"Changes in the state of incorporation for US companies and changes in the place of incorporation for foreign companies. Where shares need to be registered following the incorporation change, the holder(s) may have to elect the registrar.")]
    PlaceOfIncorporation,
    
    /// <summary>
    /// Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.
    /// Encoded/decoded by serializers as "InstalmentCall".
    /// </summary>
    [EnumMember(Value = "PPMT")]
    [IsoId("_bGE6mdp-Ed-ak6NoX_4Aeg_1102686220")]
    [Description(@"Instalment towards the purchase of equity capital, subject to an agreement between an issuer and a purchaser.")]
    InstalmentCall,
    
    /// <summary>
    /// A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment.
    /// Encoded/decoded by serializers as "PrincipalAndInterestPaydown".
    /// </summary>
    [EnumMember(Value = "PRII")]
    [IsoId("_bGOEgNp-Ed-ak6NoX_4Aeg_1102686221")]
    [Description(@"A payment of a portion of the principal of an interest bearing asset, in addition to the interest payment.")]
    PrincipalAndInterestPaydown,
    
    /// <summary>
    /// Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time.
    /// Encoded/decoded by serializers as "PriorityIssue".
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_bGOEgdp-Ed-ak6NoX_4Aeg_1102686222")]
    [Description(@"Form of open or public offer where priority is given to existing shareholders due to limited amount of securities available in the offer. Shareholders can buy a type of security during a short period of time.")]
    PriorityIssue,
    
    /// <summary>
    /// Redemption of an entire issue outstanding of securities by the issuer at final maturity.
    /// Encoded/decoded by serializers as "FinalMaturity".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_bGOEgtp-Ed-ak6NoX_4Aeg_1102686251")]
    [Description(@"Redemption of an entire issue outstanding of securities by the issuer at final maturity.")]
    FinalMaturity,
    
    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.
    /// Encoded/decoded by serializers as "Redenomination".
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_bGOEg9p-Ed-ak6NoX_4Aeg_1102686252")]
    [Description(@"Event by which the unit (currency and/or nominal) of a security is restated, for example, nominal/par value of security in a national currency is restated in another currency.")]
    Redenomination,
    
    /// <summary>
    /// Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.
    /// Encoded/decoded by serializers as "RemarketingAgreement".
    /// </summary>
    [EnumMember(Value = "REMK")]
    [IsoId("_bGOEhNp-Ed-ak6NoX_4Aeg_1102686281")]
    [Description(@"Purchase and sale of remarketed preferred equities/bonds through the negotiation of interest rate between the issuers and the holders.")]
    RemarketingAgreement,
    
    /// <summary>
    /// Event is the distribution of rights to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as "RightsDistribution".
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_bGOEhdp-Ed-ak6NoX_4Aeg_1102686282")]
    [Description(@"Event is the distribution of rights to shareholders, in proportion to their equity holding.")]
    RightsDistribution,
    
    /// <summary>
    /// Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event. Also known as subscription rights or rights offer.
    /// Encoded/decoded by serializers as "RightsIssue".
    /// </summary>
    [EnumMember(Value = "RHTS")]
    [IsoId("_bGOEhtp-Ed-ak6NoX_4Aeg_1102686283")]
    [Description(@"Distribution of a security or privilege that gives the holder an entitlement or right to take part in a future event. Also known as subscription rights or rights offer.")]
    RightsIssue,
    
    /// <summary>
    /// Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.
    /// Encoded/decoded by serializers as "SmallestNegotiableUnit".
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_bGOEh9p-Ed-ak6NoX_4Aeg_1102686312")]
    [Description(@"Modification of the smallest negotiable unit of shares in order to obtain a new negotiable unit.")]
    SmallestNegotiableUnit,
    
    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as "SpinOff".
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_bGOEiNp-Ed-ak6NoX_4Aeg_1102686313")]
    [Description(@"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.")]
    SpinOff,
    
    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as "StockSplit".
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_bGOEidp-Ed-ak6NoX_4Aeg_1102686343")]
    [Description(@"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    StockSplit,
    
    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as "ReverseStockSplit".
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_bGOEitp-Ed-ak6NoX_4Aeg_1102686344")]
    [Description(@"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    ReverseStockSplit,
    
    /// <summary>
    /// Trading in the security has been suspended.
    /// Encoded/decoded by serializers as "TradingStatusSuspended".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bGX1gNp-Ed-ak6NoX_4Aeg_1102686345")]
    [Description(@"Trading in the security has been suspended.")]
    TradingStatusSuspended,
    
    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.
    /// Encoded/decoded by serializers as "Tender".
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bGX1gdp-Ed-ak6NoX_4Aeg_1102686366")]
    [Description(@"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.")]
    Tender,
    
    /// <summary>
    /// Booking out of valueless securities.
    /// Encoded/decoded by serializers as "Worthless".
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_bGX1gtp-Ed-ak6NoX_4Aeg_1102686374")]
    [Description(@"Booking out of valueless securities.")]
    Worthless,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventType3CodeMetadataExtensions
{
    private static readonly CorporateActionEventType3CodeDropdownSource _dropdownSource = new CorporateActionEventType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventType3CodeDropdownRow GetMetadata(this CorporateActionEventType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


