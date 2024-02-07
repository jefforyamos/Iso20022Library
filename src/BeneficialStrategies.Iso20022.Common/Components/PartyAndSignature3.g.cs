﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyAndSignature3.  ISO2002 ID# _Q_AvW3R1EeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
public partial record PartyAndSignature3
     : IIsoXmlSerilizable<PartyAndSignature3>
{
    #nullable enable
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    public required PartyIdentification135 Party { get; init; } 
    /// <summary>
    /// Signature of a party.
    /// </summary>
    public required SkipPayload Signature { get; init; } 
    
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
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sgntr", xmlNamespace );
        Signature.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PartyAndSignature3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
