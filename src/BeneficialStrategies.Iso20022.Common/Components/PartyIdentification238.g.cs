﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification238.  ISO2002 ID# _ow34pfQ0EeqAradXpAelDQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification238
     : IIsoXmlSerilizable<PartyIdentification238>
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required PersonName3 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    public required NaturalPersonIdentification1 Identification { get; init; } 
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    public CountryCode? Nationality { get; init; } 
    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    
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
        writer.WriteStartElement(null, "NmAndAdr", xmlNamespace );
        NameAndAddress.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EmailAddress is IsoMax256Text EmailAddressValue)
        {
            writer.WriteStartElement(null, "EmailAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(EmailAddressValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Nationality is CountryCode NationalityValue)
        {
            writer.WriteStartElement(null, "Ntlty", xmlNamespace );
            writer.WriteValue(NationalityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DateAndPlaceOfBirth is DateAndPlaceOfBirth2 DateAndPlaceOfBirthValue)
        {
            writer.WriteStartElement(null, "DtAndPlcOfBirth", xmlNamespace );
            DateAndPlaceOfBirthValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification238 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
