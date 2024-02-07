﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Enquiry.  ISO2002 ID# _76G8dKMgEeCJ6YNENx4h-w_-1836773968.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RequestType2Choice;

/// <summary>
/// Request type is an enquiry on a position or a transaction.
/// </summary>
public partial record Enquiry : RequestType2Choice_
     , IIsoXmlSerilizable<Enquiry>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the request used to further detail the type of information that will be queried.
    /// </summary>
    public required RequestType2Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Enqry", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Enquiry Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
