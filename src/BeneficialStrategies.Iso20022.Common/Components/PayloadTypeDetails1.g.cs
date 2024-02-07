﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PayloadTypeDetails1.  ISO2002 ID# _jMCaQe5NEeCisYr99QEiWA_994991099.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the type of payload.
/// </summary>
public partial record PayloadTypeDetails1
     : IIsoXmlSerilizable<PayloadTypeDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Declaration of the payload content. Describes the type of business document being exchanged.
    /// When sending a copy or a duplicate of a previous document set, the document set identification must remain identical.
    /// </summary>
    public required IsoMax256Text Type { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax256Text(Type)); // data type Max256Text System.String
        writer.WriteEndElement();
    }
    public static PayloadTypeDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
