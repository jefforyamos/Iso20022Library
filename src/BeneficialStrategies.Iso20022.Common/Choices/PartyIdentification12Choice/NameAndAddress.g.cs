﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _QQ3rmNp-Ed-ak6NoX_4Aeg_1634438390.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification12Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record NameAndAddress : PartyIdentification12Choice_
     , IIsoXmlSerilizable<NameAndAddress>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    public PostalAddress1? Address { get; init; } 
    
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
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Name)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (Address is PostalAddress1 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new NameAndAddress Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
