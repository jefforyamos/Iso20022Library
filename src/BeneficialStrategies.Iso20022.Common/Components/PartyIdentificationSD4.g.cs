﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationSD4.  ISO2002 ID# _1VTtwjL3EeKU9IrkkToqcw_-1706678617.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact person at the party organising the meeting, at the issuer or at an intermediary.
/// </summary>
public partial record PartyIdentificationSD4
     : IIsoXmlSerilizable<PartyIdentificationSD4>
{
    #nullable enable
    
    /// <summary>
    /// Identifies a contact person by a name, a given name and an address.
    /// </summary>
    public ContactIdentification1? ContactPerson { get; init; } 
    /// <summary>
    /// Identifies the organisation which is represented by a person or for which a person works.
    /// </summary>
    public PartyIdentificationSD3? EmployingParty { get; init; } 
    
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
        if (ContactPerson is ContactIdentification1 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EmployingParty is PartyIdentificationSD3 EmployingPartyValue)
        {
            writer.WriteStartElement(null, "EmplngPty", xmlNamespace );
            EmployingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationSD4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
