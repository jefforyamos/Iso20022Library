﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICFI.  ISO2002 ID# _wnZu-EHREeW-Sp6UI3iOQA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification94Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BICFI : PartyIdentification94Choice_
     , IIsoXmlSerilizable<BICFI>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public required IsoBICFIIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "BICFI", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBICFIIdentifier(Value)); // data type BICFIIdentifier System.String
        writer.WriteEndElement();
    }
    public static new BICFI Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
