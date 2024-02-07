﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ValidationResult5.  ISO2002 ID# _Ra7q8dp-Ed-ak6NoX_4Aeg_-1034400483.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of the differences.
/// </summary>
public partial record ValidationResult5
     : IIsoXmlSerilizable<ValidationResult5>
{
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to the mismatch.
    /// </summary>
    public required IsoNumber SequenceNumber { get; init; } 
    /// <summary>
    /// Coded identification of the matching rule that is violated.
    /// </summary>
    public required IsoMax35Text RuleIdentification { get; init; } 
    /// <summary>
    /// Detailed description of the rule.
    /// </summary>
    public required IsoMax350Text RuleDescription { get; init; } 
    /// <summary>
    /// Description of the element that creates the mismatch.
    /// </summary>
    public ElementIdentification1? MisMatchedElement { get; init; } 
    
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
        writer.WriteStartElement(null, "SeqNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(SequenceNumber)); // data type Number System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RuleId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(RuleIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RuleDesc", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(RuleDescription)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (MisMatchedElement is ElementIdentification1 MisMatchedElementValue)
        {
            writer.WriteStartElement(null, "MisMtchdElmt", xmlNamespace );
            MisMatchedElementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ValidationResult5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
