﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradePositionComponent5.  ISO2002 ID# _BmwjgQ1LEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a component report on a trade position.
/// </summary>
public partial record TradePositionComponent5
     : IIsoXmlSerilizable<TradePositionComponent5>
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "CtrPtySpcfcData", xmlNamespace );
        CounterpartySpecificData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CmonTradData", xmlNamespace );
        CommonTradeData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TechnicalAttributes is TechnicalAttributes1 TechnicalAttributesValue)
        {
            writer.WriteStartElement(null, "TechAttrbts", xmlNamespace );
            TechnicalAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TradePositionComponent5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
