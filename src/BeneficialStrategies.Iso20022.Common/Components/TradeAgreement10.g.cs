﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeAgreement10.  ISO2002 ID# _wiD-kVN4EeOEi5J12GuNGQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade.
/// </summary>
public partial record TradeAgreement10
     : IIsoXmlSerilizable<TradeAgreement10>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed on the trade.
    /// </summary>
    public required IsoISODate TradeDate { get; init; } 
    /// <summary>
    /// Reference of the present instruction assigned by the party issuing the message. This reference must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    public required IsoMax35Text OriginatorReference { get; init; } 
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    public IsoMax35Text? CommonReference { get; init; } 
    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    public IsoMax4Text? OperationType { get; init; } 
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    public IsoMax4Text? OperationScope { get; init; } 
    /// <summary>
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    /// <summary>
    /// Specifies if the FX transaction is PVP settlement. Payment versus payment (PvP) settlement arrangement allows for two currencies in a foreign exchange (FX) contract to exchange simultaneously on a central settlement platform to eliminate the settlement risk. To apply PvP, the two parties in the FX contract need to have a pre-agreement with the central settlement platform, for example, USD/MYR FX deals require both parties to have an agreement to settle via HK Interbank Clearing Ltd settlement platform.
    /// </summary>
    public IsoYesNoIndicator? PaymentVersusPaymentIndicator { get; init; } 
    
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
        writer.WriteStartElement(null, "TradDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(TradeDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgtrRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginatorReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (CommonReference is IsoMax35Text CommonReferenceValue)
        {
            writer.WriteStartElement(null, "CmonRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OperationType is IsoMax4Text OperationTypeValue)
        {
            writer.WriteStartElement(null, "OprTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4Text(OperationTypeValue)); // data type Max4Text System.String
            writer.WriteEndElement();
        }
        if (OperationScope is IsoMax4Text OperationScopeValue)
        {
            writer.WriteStartElement(null, "OprScp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4Text(OperationScopeValue)); // data type Max4Text System.String
            writer.WriteEndElement();
        }
        if (SettlementSessionIdentifier is IsoExact4AlphaNumericText SettlementSessionIdentifierValue)
        {
            writer.WriteStartElement(null, "SttlmSsnIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(SettlementSessionIdentifierValue)); // data type Exact4AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (PaymentVersusPaymentIndicator is IsoYesNoIndicator PaymentVersusPaymentIndicatorValue)
        {
            writer.WriteStartElement(null, "PmtVrssPmtInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PaymentVersusPaymentIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static TradeAgreement10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
