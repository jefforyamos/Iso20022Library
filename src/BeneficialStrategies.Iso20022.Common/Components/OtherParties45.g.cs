﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties45.  ISO2002 ID# _UDMVIQasEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about business parties involved in the transaction.
/// </summary>
public partial record OtherParties45
     : IIsoXmlSerilizable<OtherParties45>
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    public PartyIdentificationAndAccount220? Investor { get; init; } 
    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    public PartyIdentificationAndAccount152? StockExchange { get; init; } 
    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    public PartyIdentificationAndAccount152? TradeRegulator { get; init; } 
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    public PartyIdentificationAndAccount154? TripartyAgent { get; init; } 
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentificationAndAccount221? QualifiedForeignIntermediary { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Investor is PartyIdentificationAndAccount220 InvestorValue)
        {
            writer.WriteStartElement(null, "Invstr", xmlNamespace );
            InvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StockExchange is PartyIdentificationAndAccount152 StockExchangeValue)
        {
            writer.WriteStartElement(null, "StockXchg", xmlNamespace );
            StockExchangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeRegulator is PartyIdentificationAndAccount152 TradeRegulatorValue)
        {
            writer.WriteStartElement(null, "TradRgltr", xmlNamespace );
            TradeRegulatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TripartyAgent is PartyIdentificationAndAccount154 TripartyAgentValue)
        {
            writer.WriteStartElement(null, "TrptyAgt", xmlNamespace );
            TripartyAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QualifiedForeignIntermediary is PartyIdentificationAndAccount221 QualifiedForeignIntermediaryValue)
        {
            writer.WriteStartElement(null, "QlfdFrgnIntrmy", xmlNamespace );
            QualifiedForeignIntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OtherParties45 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
