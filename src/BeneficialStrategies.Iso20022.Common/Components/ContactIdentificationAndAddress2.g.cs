﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContactIdentificationAndAddress2.  ISO2002 ID# _-IRJIXhhEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record ContactIdentificationAndAddress2
     : IIsoXmlSerilizable<ContactIdentificationAndAddress2>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Role of the party in the payment.
    /// </summary>
    public required PaymentRole1Choice_ Role { get; init; } 
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    public required CommunicationAddress10 CommunicationAddress { get; init; } 
    
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
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Role", xmlNamespace );
        Role.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ComAdr", xmlNamespace );
        CommunicationAddress.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ContactIdentificationAndAddress2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
