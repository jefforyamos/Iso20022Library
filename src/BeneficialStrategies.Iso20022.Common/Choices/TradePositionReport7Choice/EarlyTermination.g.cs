﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EarlyTermination.  ISO2002 ID# _bWl_hxLBEeqctpBfTmLJnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice;

/// <summary>
/// Indicates that reported position is an early termination of an existing contract.
/// </summary>
public partial record EarlyTermination : TradePositionReport7Choice_
     , IIsoXmlSerilizable<EarlyTermination>
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    public ValueList<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    public required CommonTradeDataReport35 CommonTradeData { get; init; } 
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
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
    public static new EarlyTermination Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
