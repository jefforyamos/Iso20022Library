﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType2Code.  ISO2002 ID# _ZyVax9p-Ed-ak6NoX_4Aeg_-1463923724.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of party involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZyVax9p-Ed-ak6NoX_4Aeg_-1463923724")]
[Description(@"Specifies the type of party involved in the transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType2Code
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ZyVayNp-Ed-ak6NoX_4Aeg_1425772570")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
    /// <summary>
    /// Party that identifies an executing / give-up broker.
    /// Encoded/decoded by serializers as "ExecutingFirm".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_ZyeksNp-Ed-ak6NoX_4Aeg_1488571424")]
    [Description(@"Party that identifies an executing / give-up broker.")]
    ExecutingFirm,
    
    /// <summary>
    /// Party that receives the trade credit.
    /// Encoded/decoded by serializers as "BrokerOfCredit".
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_Zyeksdp-Ed-ak6NoX_4Aeg_1488571597")]
    [Description(@"Party that receives the trade credit.")]
    BrokerOfCredit,
    
    /// <summary>
    /// Party that is going to carry the position on their books at another clearinghouse (exchanges).
    /// Encoded/decoded by serializers as "CorrespondentClearingFirm".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_Zyekstp-Ed-ak6NoX_4Aeg_1488571614")]
    [Description(@"Party that is going to carry the position on their books at another clearinghouse (exchanges).")]
    CorrespondentClearingFirm,
    
    /// <summary>
    /// Party that is the counterparty in a trade.
    /// Encoded/decoded by serializers as "ContraFirm".
    /// </summary>
    [EnumMember(Value = "COFI")]
    [IsoId("_Zyeks9p-Ed-ak6NoX_4Aeg_1488572277")]
    [Description(@"Party that is the counterparty in a trade.")]
    ContraFirm,
    
    /// <summary>
    /// Party that is the clearing firm of the counterparty in a trade.
    /// Encoded/decoded by serializers as "ContraClearingFirm".
    /// </summary>
    [EnumMember(Value = "COCL")]
    [IsoId("_ZyektNp-Ed-ak6NoX_4Aeg_1488572337")]
    [Description(@"Party that is the clearing firm of the counterparty in a trade.")]
    ContraClearingFirm,
    
    /// <summary>
    /// Party (broker or other firm), which is the contra side of the trade for the underlying security.
    /// Encoded/decoded by serializers as "UnderlyingContraFirm".
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_Zyektdp-Ed-ak6NoX_4Aeg_1488572527")]
    [Description(@"Party (broker or other firm), which is the contra side of the trade for the underlying security.")]
    UnderlyingContraFirm,
    
    /// <summary>
    /// Party to which the trade is given up (carries the position that results from a trade).
    /// Encoded/decoded by serializers as "GiveUpClearingFirm".
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_Zyekttp-Ed-ak6NoX_4Aeg_1488572864")]
    [Description(@"Party to which the trade is given up (carries the position that results from a trade).")]
    GiveUpClearingFirm,
    
    /// <summary>
    /// Party that originates an order.
    /// Encoded/decoded by serializers as "OrderOriginationFirm".
    /// </summary>
    [EnumMember(Value = "ORDE")]
    [IsoId("_Zyekt9p-Ed-ak6NoX_4Aeg_1488573423")]
    [Description(@"Party that originates an order.")]
    OrderOriginationFirm,
    
    /// <summary>
    /// Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.
    /// Encoded/decoded by serializers as "SponsoringFirm".
    /// </summary>
    [EnumMember(Value = "SPON")]
    [IsoId("_ZyekuNp-Ed-ak6NoX_4Aeg_1488574258")]
    [Description(@"Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.")]
    SponsoringFirm,
    
    /// <summary>
    /// Party (broker) that settles security transactions from another broker for a fee = take up broker.
    /// Encoded/decoded by serializers as "Clearingfirm".
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_Zyekudp-Ed-ak6NoX_4Aeg_1488574430")]
    [Description(@"Party (broker) that settles security transactions from another broker for a fee = take up broker.")]
    Clearingfirm,
    
    /// <summary>
    /// Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.
    /// Encoded/decoded by serializers as "IntroducingFirm".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_Zyekutp-Ed-ak6NoX_4Aeg_1489494904")]
    [Description(@"Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.")]
    IntroducingFirm,
    
    /// <summary>
    /// Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.
    /// Encoded/decoded by serializers as "EnteringFirm".
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_ZyoVsNp-Ed-ak6NoX_4Aeg_1489495041")]
    [Description(@"Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.")]
    EnteringFirm,
    
    /// <summary>
    /// A client is identified in third party-transactions or for investor in intermediary transactions.
    /// Encoded/decoded by serializers as "Client".
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_ZyoVsdp-Ed-ak6NoX_4Aeg_1489495378")]
    [Description(@"A client is identified in third party-transactions or for investor in intermediary transactions.")]
    Client,
    
    /// <summary>
    /// Broker to which the investment manager directs the execution of a portion of the trade.
    /// Encoded/decoded by serializers as "StepInBroker".
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_ZyoVstp-Ed-ak6NoX_4Aeg_1489495860")]
    [Description(@"Broker to which the investment manager directs the execution of a portion of the trade.")]
    StepInBroker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType2CodeMetadataExtensions
{
    private static readonly PartyType2CodeDropdownSource _dropdownSource = new PartyType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType2CodeDropdownRow GetMetadata(this PartyType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


