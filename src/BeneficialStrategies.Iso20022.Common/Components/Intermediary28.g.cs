﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary28.  ISO2002 ID# _ONg8kZ-xEeO1d8sv7xazyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
public partial record Intermediary28
     : IIsoXmlSerilizable<Intermediary28>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required PartyIdentification100 Identification { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public required Role5Choice_ Role { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Role", xmlNamespace );
        Role.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Intermediary28 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
