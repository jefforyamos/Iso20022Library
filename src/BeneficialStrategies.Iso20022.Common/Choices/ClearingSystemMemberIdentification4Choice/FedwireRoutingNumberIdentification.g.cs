﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FedwireRoutingNumberIdentification.  ISO2002 ID# _VwSCbbNIEeejueAciesPMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice;

/// <summary>
/// Fedwire Routing Number - identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
/// </summary>
public partial record FedwireRoutingNumberIdentification : ClearingSystemMemberIdentification4Choice_
     , IIsoXmlSerilizable<FedwireRoutingNumberIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Fedwire Routing Number. Identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
    /// </summary>
    public required IsoFedwireRoutingNumberIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "USFW", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoFedwireRoutingNumberIdentifier(Value)); // data type FedwireRoutingNumberIdentifier System.String
        writer.WriteEndElement();
    }
    public static new FedwireRoutingNumberIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
