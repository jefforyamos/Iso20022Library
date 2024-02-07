﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Delete.  ISO2002 ID# _QOJ0M5JKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType35Choice;

/// <summary>
/// Set of data requested for deletion from a security.
/// </summary>
public partial record Delete : UpdateType35Choice_
     , IIsoXmlSerilizable<Delete>
{
    #nullable enable
    
    /// <summary>
    /// Provides additional details about the financial instrument.
    /// </summary>
    public FinancialInstrument97? FinancialInstrumentType { get; init; } 
    /// <summary>
    /// Provides details about the financial instrument attributes of a particular leg.
    /// </summary>
    public CommonFinancialInstrumentAttributes12? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
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
        if (FinancialInstrumentType is FinancialInstrument97 FinancialInstrumentTypeValue)
        {
            writer.WriteStartElement(null, "FinInstrmTp", xmlNamespace );
            FinancialInstrumentTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAttributes is CommonFinancialInstrumentAttributes12 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Delete Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
