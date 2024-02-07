﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonName2.  ISO2002 ID# _W138xVB2Eem6LsRj385o5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a person via its first name and surname.
/// </summary>
public partial record PersonName2
     : IIsoXmlSerilizable<PersonName2>
{
    #nullable enable
    
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    public PostalAddress26? Address { get; init; } 
    
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
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Name)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (Address is PostalAddress26 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PersonName2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
