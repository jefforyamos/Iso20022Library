﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CaseAssignment3.  ISO2002 ID# _sbKvolkyEeGeoaLUQk__nA_1583838951.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents the assignment of a case to a party.
/// </summary>
public partial record CaseAssignment3
     : IIsoXmlSerilizable<CaseAssignment3>
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    public required Party12Choice_ Assigner { get; init; } 
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    public required Party12Choice_ Assignee { get; init; } 
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Assgnr", xmlNamespace );
        Assigner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Assgne", xmlNamespace );
        Assignee.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static CaseAssignment3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
