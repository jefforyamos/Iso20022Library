﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonName3.  ISO2002 ID# _FhKN1bqcEemCAOifqHrKJw.
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
public partial record PersonName3
     : IIsoXmlSerilizable<PersonName3>
{
    #nullable enable
    
    /// <summary>
    /// Prefix, as a title before a person's name.
    /// </summary>
    public NamePrefix2Code? NamePrefix { get; init; } 
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    public required IsoMax350Text FirstName { get; init; } 
    /// <summary>
    /// Name (s) by which a natural person is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Surname { get; init; } 
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
        if (NamePrefix is NamePrefix2Code NamePrefixValue)
        {
            writer.WriteStartElement(null, "NmPrfx", xmlNamespace );
            writer.WriteValue(NamePrefixValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FrstNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(FirstName)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Srnm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Surname)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (Address is PostalAddress26 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PersonName3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
