﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardEntry5.  ISO2002 ID# _bdHtUdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction entry.
/// </summary>
public partial record CardEntry5
     : IIsoXmlSerilizable<CardEntry5>
{
    #nullable enable
    
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    public PaymentCard4? Card { get; init; } 
    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    public PointOfInteraction1? POI { get; init; } 
    /// <summary>
    /// Card entry details, based on card transaction aggregated data performed by the account servicer.
    /// </summary>
    public CardAggregated2? AggregatedEntry { get; init; } 
    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    public CashAccount40? PrePaidAccount { get; init; } 
    
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
        if (Card is PaymentCard4 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POI is PointOfInteraction1 POIValue)
        {
            writer.WriteStartElement(null, "POI", xmlNamespace );
            POIValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AggregatedEntry is CardAggregated2 AggregatedEntryValue)
        {
            writer.WriteStartElement(null, "AggtdNtry", xmlNamespace );
            AggregatedEntryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrePaidAccount is CashAccount40 PrePaidAccountValue)
        {
            writer.WriteStartElement(null, "PrePdAcct", xmlNamespace );
            PrePaidAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardEntry5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
