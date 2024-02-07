﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PortugueseNCCIdentification.  ISO2002 ID# _TDY2hdp-Ed-ak6NoX_4Aeg_-896562591.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice;

/// <summary>
/// Portuguese National Clearing Code - identifies Portuguese financial institutions on the Portuguese national clearing system.
/// </summary>
public partial record PortugueseNCCIdentification : ClearingSystemMemberIdentificationChoice_
     , IIsoXmlSerilizable<PortugueseNCCIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Portuguese National Clearing Code. Identifies Portuguese financial institutions on the Portuguese national clearing system.
    /// </summary>
    public required IsoPortugueseNCCIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "PTNCC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPortugueseNCCIdentifier(Value)); // data type PortugueseNCCIdentifier System.String
        writer.WriteEndElement();
    }
    public static new PortugueseNCCIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
