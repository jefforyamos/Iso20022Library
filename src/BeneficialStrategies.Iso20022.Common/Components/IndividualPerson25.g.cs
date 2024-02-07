﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson25.  ISO2002 ID# _8aBMx1tgEeSwKe7KuKvXhg.
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
public partial record IndividualPerson25
     : IIsoXmlSerilizable<IndividualPerson25>
{
    #nullable enable
    
    /// <summary>
    /// Name received at birth, for example, maiden name.
    /// </summary>
    public required IsoMax35Text BirthName { get; init; } 
    /// <summary>
    /// First name of the person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the person, for example, passport.
    /// </summary>
    public PersonIdentification6? Identification { get; init; } 
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    public LongPostalAddress2Choice_? Address { get; init; } 
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    public PartyIdentification40Choice_? EmployingParty { get; init; } 
    
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
        writer.WriteStartElement(null, "BirthNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(BirthName)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (GivenName is IsoMax35Text GivenNameValue)
        {
            writer.WriteStartElement(null, "GvnNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(GivenNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Identification is PersonIdentification6 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Address is LongPostalAddress2Choice_ AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EmployingParty is PartyIdentification40Choice_ EmployingPartyValue)
        {
            writer.WriteStartElement(null, "EmplngPty", xmlNamespace );
            EmployingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IndividualPerson25 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
