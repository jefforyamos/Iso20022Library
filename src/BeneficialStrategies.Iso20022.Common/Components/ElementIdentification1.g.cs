﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ElementIdentification1.  ISO2002 ID# _RJf8s9p-Ed-ak6NoX_4Aeg_1263580782.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the element that creates the mismatch.
/// </summary>
public partial record ElementIdentification1
     : IIsoXmlSerilizable<ElementIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Refers to the identification number of the document in which the mismatch was found.
    /// </summary>
    public required IsoMax3NumericText DocumentIndex { get; init; } 
    /// <summary>
    /// Specifies from the root of the message the complete path of the element that violated a rule.
    /// </summary>
    public required IsoMax350Text ElementPath { get; init; } 
    /// <summary>
    /// Name of the element.
    /// </summary>
    public required IsoMax35Text ElementName { get; init; } 
    /// <summary>
    /// Content of the element.
    /// </summary>
    public IsoMax140Text? ElementValue { get; init; } 
    
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
        writer.WriteStartElement(null, "DocIndx", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax3NumericText(DocumentIndex)); // data type Max3NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ElmtPth", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(ElementPath)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ElmtNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ElementName)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ElementValue is IsoMax140Text ElementValueValue)
        {
            writer.WriteStartElement(null, "ElmtVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ElementValueValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static ElementIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
