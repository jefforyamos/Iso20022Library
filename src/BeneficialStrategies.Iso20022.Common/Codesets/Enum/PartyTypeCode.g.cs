﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyTypeCode.  ISO2002 ID# _ZyoVs9p-Ed-ak6NoX_4Aeg_-359397827.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the entitled party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZyoVs9p-Ed-ak6NoX_4Aeg_-359397827")]
[Description(@"Specifies the entitled party.")]
public enum PartyTypeCode
{
    /// <summary>
    /// Party selling goods and services.
    /// Encoded/decoded by serializers as "SALE".
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_sSrgkL4pEeKkGaJ0UrThyA_-1476346300")]
    [Description(@"Party selling goods and services.")]
    SaleSystem,
    
    /// <summary>
    /// Party component of a POI system or POI terminal (Point of Interaction).
    /// Encoded/decoded by serializers as "PCPT".
    /// </summary>
    [EnumMember(Value = "PCPT")]
    [IsoId("_sSrgkb4pEeKkGaJ0UrThyA_-9585713")]
    [Description(@"Party component of a POI system or POI terminal (Point of Interaction).")]
    POIComponent,
    
    /// <summary>
    /// Issuer is the entitled party.
    /// Encoded/decoded by serializers as "ISUR".
    /// </summary>
    [EnumMember(Value = "ISUR")]
    [IsoId("_ZyoVtNp-Ed-ak6NoX_4Aeg_-300292214")]
    [Description(@"Issuer is the entitled party.")]
    Issuer,
    
    /// <summary>
    /// Holder is the entitled party.
    /// Encoded/decoded by serializers as "HLDR".
    /// </summary>
    [EnumMember(Value = "HLDR")]
    [IsoId("_ZyoVtdp-Ed-ak6NoX_4Aeg_-292904138")]
    [Description(@"Holder is the entitled party.")]
    Holder,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ZyoVttp-Ed-ak6NoX_4Aeg_-1029037842")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
    /// <summary>
    /// Party that identifies an executing / give-up broker.
    /// Encoded/decoded by serializers as "EXEC".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_ZyoVt9p-Ed-ak6NoX_4Aeg_-1027191353")]
    [Description(@"Party that identifies an executing / give-up broker.")]
    ExecutingFirm,
    
    /// <summary>
    /// Party that receives the trade credit.
    /// Encoded/decoded by serializers as "BROK".
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_ZyoVuNp-Ed-ak6NoX_4Aeg_-1025346609")]
    [Description(@"Party that receives the trade credit.")]
    BrokerOfCredit,
    
    /// <summary>
    /// Party that is going to carry the position on their books at another clearinghouse (exchanges).
    /// Encoded/decoded by serializers as "CORR".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ZyxfoNp-Ed-ak6NoX_4Aeg_-1024423043")]
    [Description(@"Party that is going to carry the position on their books at another clearinghouse (exchanges).")]
    CorrespondentClearingFirm,
    
    /// <summary>
    /// Party that is the counterparty in a trade.
    /// Encoded/decoded by serializers as "COFI".
    /// </summary>
    [EnumMember(Value = "COFI")]
    [IsoId("_Zyxfodp-Ed-ak6NoX_4Aeg_-1024422653")]
    [Description(@"Party that is the counterparty in a trade.")]
    ContraFirm,
    
    /// <summary>
    /// Party that is the clearing firm of the counterparty in a trade.
    /// Encoded/decoded by serializers as "COCL".
    /// </summary>
    [EnumMember(Value = "COCL")]
    [IsoId("_Zyxfotp-Ed-ak6NoX_4Aeg_-1024422268")]
    [Description(@"Party that is the clearing firm of the counterparty in a trade.")]
    ContraClearingFirm,
    
    /// <summary>
    /// Party (broker or other firm), which is the contra side of the trade for the underlying security.
    /// Encoded/decoded by serializers as "UNDE".
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_Zyxfo9p-Ed-ak6NoX_4Aeg_-1024422095")]
    [Description(@"Party (broker or other firm), which is the contra side of the trade for the underlying security.")]
    UnderlyingContraFirm,
    
    /// <summary>
    /// Party to which the trade is given up (carries the position that results from a trade).
    /// Encoded/decoded by serializers as "GIVE".
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_ZyxfpNp-Ed-ak6NoX_4Aeg_-1024421662")]
    [Description(@"Party to which the trade is given up (carries the position that results from a trade).")]
    GiveUpClearingFirm,
    
    /// <summary>
    /// Party that originates an order.
    /// Encoded/decoded by serializers as "ORDE".
    /// </summary>
    [EnumMember(Value = "ORDE")]
    [IsoId("_Zyxfpdp-Ed-ak6NoX_4Aeg_-1024421147")]
    [Description(@"Party that originates an order.")]
    OrderOriginationFirm,
    
    /// <summary>
    /// Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.
    /// Encoded/decoded by serializers as "SPON".
    /// </summary>
    [EnumMember(Value = "SPON")]
    [IsoId("_Zyxfptp-Ed-ak6NoX_4Aeg_-1024420388")]
    [Description(@"Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.")]
    SponsoringFirm,
    
    /// <summary>
    /// Party (broker) that settles security transactions from another broker for a fee = take up broker.
    /// Encoded/decoded by serializers as "CLEA".
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_Zyxfp9p-Ed-ak6NoX_4Aeg_-1023496744")]
    [Description(@"Party (broker) that settles security transactions from another broker for a fee = take up broker.")]
    Clearingfirm,
    
    /// <summary>
    /// Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_ZyxfqNp-Ed-ak6NoX_4Aeg_-1023496295")]
    [Description(@"Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.")]
    IntroducingFirm,
    
    /// <summary>
    /// Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.
    /// Encoded/decoded by serializers as "ENTE".
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_Zyxfqdp-Ed-ak6NoX_4Aeg_-1021651731")]
    [Description(@"Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.")]
    EnteringFirm,
    
    /// <summary>
    /// A client is identified in third party-transactions or for investor in intermediary transactions.
    /// Encoded/decoded by serializers as "CLIE".
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_Zy7QoNp-Ed-ak6NoX_4Aeg_-1014262432")]
    [Description(@"A client is identified in third party-transactions or for investor in intermediary transactions.")]
    Client,
    
    /// <summary>
    /// Broker to which the investment manager directs the execution of a portion of the trade.
    /// Encoded/decoded by serializers as "STEP".
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_Zy7Qodp-Ed-ak6NoX_4Aeg_-1014261982")]
    [Description(@"Broker to which the investment manager directs the execution of a portion of the trade.")]
    StepInBroker,
    
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// Encoded/decoded by serializers as "AFFI".
    /// </summary>
    [EnumMember(Value = "AFFI")]
    [IsoId("_Zy7Qotp-Ed-ak6NoX_4Aeg_-1014261476")]
    [Description(@"Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.")]
    AffirmingParty,
    
    /// <summary>
    /// Party acting as the Electronic Trade Confirmation (ETC) service provider 1.
    /// Encoded/decoded by serializers as "ETC1".
    /// </summary>
    [EnumMember(Value = "ETC1")]
    [IsoId("_Zy7Qo9p-Ed-ak6NoX_4Aeg_-1013341055")]
    [Description(@"Party acting as the Electronic Trade Confirmation (ETC) service provider 1.")]
    ETCServiceProvider1,
    
    /// <summary>
    /// Party acting as the Electronic Trade Confirmation (ETC) service provider 2.
    /// Encoded/decoded by serializers as "ETC2".
    /// </summary>
    [EnumMember(Value = "ETC2")]
    [IsoId("_Zy7QpNp-Ed-ak6NoX_4Aeg_-1013340924")]
    [Description(@"Party acting as the Electronic Trade Confirmation (ETC) service provider 2.")]
    ETCServiceProvider2,
    
    /// <summary>
    /// In a directed order, broker with which the Receiver of the message is requested to execute the order.
    /// Encoded/decoded by serializers as "RQBR".
    /// </summary>
    [EnumMember(Value = "RQBR")]
    [IsoId("_Zy7Qpdp-Ed-ak6NoX_4Aeg_-1012416848")]
    [Description(@"In a directed order, broker with which the Receiver of the message is requested to execute the order.")]
    RequestedBroker,
    
    /// <summary>
    /// Tax authority.
    /// Encoded/decoded by serializers as "TAXH".
    /// </summary>
    [EnumMember(Value = "TAXH")]
    [IsoId("_TYnmcAEcEeCQm6a_G2yO_w_-621437721")]
    [Description(@"Tax authority.")]
    TaxAuthority,
    
    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as "DLIS".
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_TYxXcAEcEeCQm6a_G2yO_w_-1218908115")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer,
    
    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as "OPOI".
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_TYxXcQEcEeCQm6a_G2yO_w_-916133758")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI,
    
    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as "CISS".
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_TYxXcgEcEeCQm6a_G2yO_w_-1776979001")]
    [Description(@"Party that issues cards.")]
    CardIssuer,
    
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_TYxXcwEcEeCQm6a_G2yO_w_117452154")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor,
    
    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as "MERC".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TYxXdAEcEeCQm6a_G2yO_w_1818753336")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant,
    
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as "ACQR".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_TYxXdQEcEeCQm6a_G2yO_w_1892959120")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer,
    
    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as "ITAG".
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_TYxXdgEcEeCQm6a_G2yO_w_1528564891")]
    [Description(@"Party acting on behalf of other parties to process or forward data to other parties.")]
    IntermediaryAgent,
    
    /// <summary>
    /// Responsible for the maintenance of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as "MTMG".
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_KY_d0H1DEeCF8NjrBemJWQ_1183753602")]
    [Description(@"Responsible for the maintenance of a card payment acceptance terminal.")]
    MasterTerminalManager,
    
    /// <summary>
    /// Responsible for one or several maintenance functions of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as "TMGT".
    /// </summary>
    [EnumMember(Value = "TMGT")]
    [IsoId("_KY_d0X1DEeCF8NjrBemJWQ_-245946481")]
    [Description(@"Responsible for one or several maintenance functions of a card payment acceptance terminal.")]
    TerminalManager,
    
    /// <summary>
    /// Entity providing acquiring card payment processing services on behalf on an acquirer.
    /// Encoded/decoded by serializers as "ACQP".
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_fvWXsHrTEeSfJf8ETXpBxg")]
    [Description(@"Entity providing acquiring card payment processing services on behalf on an acquirer.")]
    AcquirerProcessor,
    
    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as "CISP".
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_kx9V8HrTEeSfJf8ETXpBxg")]
    [Description(@"Entity providing issuing card payment processing services on behalf on an issuer.")]
    CardIssuerProcessor,
    
    /// <summary>
    /// Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as "CSCH".
    /// </summary>
    [EnumMember(Value = "CSCH")]
    [IsoId("_pRxJIHrTEeSfJf8ETXpBxg")]
    [Description(@"Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.")]
    CardScheme,
    
    /// <summary>
    /// Entity providing card payment processing services acting on behalf of a card scheme.
    /// Encoded/decoded by serializers as "SCHP".
    /// </summary>
    [EnumMember(Value = "SCHP")]
    [IsoId("_sMl7gHrTEeSfJf8ETXpBxg")]
    [Description(@"Entity providing card payment processing services acting on behalf of a card scheme.")]
    CardSchemeProcessor,
    
    /// <summary>
    /// Entity managing the ATM.
    /// Encoded/decoded by serializers as "ATMG".
    /// </summary>
    [EnumMember(Value = "ATMG")]
    [IsoId("_Jt4YsHrgEeSlsoBd7x4P6A")]
    [Description(@"Entity managing the ATM.")]
    ATMManager,
    
    /// <summary>
    /// Entity hosting the ATM.
    /// Encoded/decoded by serializers as "HSTG".
    /// </summary>
    [EnumMember(Value = "HSTG")]
    [IsoId("_M-rbEHrgEeSlsoBd7x4P6A")]
    [Description(@"Entity hosting the ATM.")]
    HostingEntity,
    
    /// <summary>
    /// ATM initiating the transaction.
    /// Encoded/decoded by serializers as "OATM".
    /// </summary>
    [EnumMember(Value = "OATM")]
    [IsoId("_Rs4PkHrgEeSlsoBd7x4P6A")]
    [Description(@"ATM initiating the transaction.")]
    OriginatingATM,
    
    /// <summary>
    /// Application on the terminal which has initiated the transaction.
    /// Encoded/decoded by serializers as "OTRM".
    /// </summary>
    [EnumMember(Value = "OTRM")]
    [IsoId("_oc6lUHtCEeSTS7uHCe8FPQ")]
    [Description(@"Application on the terminal which has initiated the transaction.")]
    OriginatingTerminal,
    
    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as "ICCA".
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_KFamcC6vEeWc7f-D6ByqMg")]
    [Description(@"Application in the smart card.")]
    CardApplication,
    
    /// <summary>
    /// Configuration to apply to the whole POI system.
    /// Encoded/decoded by serializers as "PSYS".
    /// </summary>
    [EnumMember(Value = "PSYS")]
    [IsoId("_IXjGsI33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to the whole POI system.")]
    POISystem,
    
    /// <summary>
    /// Configuration to apply to a subset of the whole POI system.
    /// Encoded/decoded by serializers as "PGRP".
    /// </summary>
    [EnumMember(Value = "PGRP")]
    [IsoId("_MFDTMI33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to a subset of the whole POI system.")]
    POIGroup,
    
    /// <summary>
    /// Configuration to apply to a single POI terminal.
    /// Encoded/decoded by serializers as "PSNG".
    /// </summary>
    [EnumMember(Value = "PSNG")]
    [IsoId("_PhmSkI33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to a single POI terminal.")]
    SinglePOI,
    
    /// <summary>
    /// The bank of the source account.
    /// Encoded/decoded by serializers as "BKAF".
    /// </summary>
    [EnumMember(Value = "BKAF")]
    [IsoId("_6dYsAK1-EeWMg5rOByfExw")]
    [Description(@"The bank of the source account.")]
    AccountFromBank,
    
    /// <summary>
    /// The bank of the destination account.
    /// Encoded/decoded by serializers as "BKAT".
    /// </summary>
    [EnumMember(Value = "BKAT")]
    [IsoId("_9pfboK1-EeWMg5rOByfExw")]
    [Description(@"The bank of the destination account.")]
    AccountToBank,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_dY4eW3yKEemHsOqJOzMVfg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent,
    
    /// <summary>
    /// Holder of a payment card.
    /// Encoded/decoded by serializers as "CRDH".
    /// </summary>
    [EnumMember(Value = "CRDH")]
    [IsoId("_dY4eXHyKEemHsOqJOzMVfg")]
    [Description(@"Holder of a payment card.")]
    Cardholder,
    
    /// <summary>
    /// Agent in charge of clearing payment or related transactions.
    /// Encoded/decoded by serializers as "CLRA".
    /// </summary>
    [EnumMember(Value = "CLRA")]
    [IsoId("_dY4eXXyKEemHsOqJOzMVfg")]
    [Description(@"Agent in charge of clearing payment or related transactions.")]
    ClearingAgent,
    
    /// <summary>
    /// Government organisation investigation unit. 
    /// Encoded/decoded by serializers as "GVIU".
    /// </summary>
    [EnumMember(Value = "GVIU")]
    [IsoId("_dY4eXnyKEemHsOqJOzMVfg")]
    [Description(@"Government organisation investigation unit. ")]
    GovernmentInvestigationUnit,
    
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_dY4eX3yKEemHsOqJOzMVfg")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dY4eYHyKEemHsOqJOzMVfg")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Payment Initiation Service Provider (PISP)
    /// Encoded/decoded by serializers as "PISP".
    /// </summary>
    [EnumMember(Value = "PISP")]
    [IsoId("_dY4eYXyKEemHsOqJOzMVfg")]
    [Description(@"Payment Initiation Service Provider (PISP)")]
    PaymentInitiationServiceProvider,
    
    /// <summary>
    /// Entity provding payments services.
    /// Encoded/decoded by serializers as "PASP".
    /// </summary>
    [EnumMember(Value = "PASP")]
    [IsoId("_dY4eYnyKEemHsOqJOzMVfg")]
    [Description(@"Entity provding payments services.")]
    PaymentServiceProvider,
    
    /// <summary>
    /// Party in charge of controlling or supervising a card acceptance Point of Interaction
    /// Encoded/decoded by serializers as "POOI".
    /// </summary>
    [EnumMember(Value = "POOI")]
    [IsoId("_dY4eY3yKEemHsOqJOzMVfg")]
    [Description(@"Party in charge of controlling or supervising a card acceptance Point of Interaction")]
    PointOfInteraction,
    
    /// <summary>
    /// Agent in charge of the settlement of a payment or related transaction.
    /// Encoded/decoded by serializers as "SETA".
    /// </summary>
    [EnumMember(Value = "SETA")]
    [IsoId("_dY4eZHyKEemHsOqJOzMVfg")]
    [Description(@"Agent in charge of the settlement of a payment or related transaction.")]
    SettlementAgent,
    
    /// <summary>
    /// Provider of an electronic wallet
    /// Encoded/decoded by serializers as "WLPR".
    /// </summary>
    [EnumMember(Value = "WLPR")]
    [IsoId("_dY4eZXyKEemHsOqJOzMVfg")]
    [Description(@"Provider of an electronic wallet")]
    WalletProvider,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyTypeCodeMetadataExtensions
{
    private static readonly PartyTypeCodeDropdownSource _dropdownSource = new PartyTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyTypeCodeDropdownRow GetMetadata(this PartyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

