﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary34.  ISO2002 ID# __UGIoSSMEeWdoOFYMt-Lzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
public partial record Intermediary34
     : IIsoXmlSerilizable<Intermediary34>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required PartyIdentification70Choice_ Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account20? Account { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public Role4Choice_? Role { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
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
        if (Account is Account20 AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Role is Role4Choice_ RoleValue)
        {
            writer.WriteStartElement(null, "Role", xmlNamespace );
            RoleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactPerson is ContactIdentification2 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Intermediary34 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
