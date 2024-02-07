﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary48.  ISO2002 ID# _-wFGsXdhEeuvip1zrZRWzw.
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
public partial record Intermediary48
     : IIsoXmlSerilizable<Intermediary48>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary or a party related to the transfer.
    /// </summary>
    public required PartyIdentification132 Identification { get; init; } 
    /// <summary>
    /// Identification of the account.
    /// </summary>
    public Account34? Account { get; init; } 
    /// <summary>
    /// Function performed by the intermediary or related party.
    /// </summary>
    public Role8Choice_? Role { get; init; } 
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
        if (Account is Account34 AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Role is Role8Choice_ RoleValue)
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
    public static Intermediary48 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
