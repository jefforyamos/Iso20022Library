﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContactDetails.  ISO2002 ID# _J8b4wYwAEei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice;

/// <summary>
/// Specifies the options on how to contact the party.
/// </summary>
public partial record ContactDetails : SystemPartyModification2Choice_
     , IIsoXmlSerilizable<ContactDetails>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    public NamePrefix2Code? NamePrefix { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? MobileNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? FaxNumber { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax2048Text? EmailAddress { get; init; } 
    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    public IsoMax35Text? EmailPurpose { get; init; } 
    /// <summary>
    /// Title of the function.
    /// </summary>
    public IsoMax35Text? JobTitle { get; init; } 
    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    public IsoMax35Text? Responsibility { get; init; } 
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    public IsoMax70Text? Department { get; init; } 
    /// <summary>
    /// Contact details in another form.
    /// </summary>
    public OtherContact1? Other { get; init; } 
    /// <summary>
    /// Preferred method used to reach the technical contact.
    /// </summary>
    public PreferredContactMethod1Code? PreferredMethod { get; init; } 
    /// <summary>
    /// Starting validity date for the contact.
    /// </summary>
    public IsoISODate? ValidFrom { get; init; } 
    /// <summary>
    /// Ending validity date for the contact.
    /// </summary>
    public IsoISODate? ValidTo { get; init; } 
    
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
        if (NamePrefix is NamePrefix2Code NamePrefixValue)
        {
            writer.WriteStartElement(null, "NmPrfx", xmlNamespace );
            writer.WriteValue(NamePrefixValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Name is IsoMax140Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(NameValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (PhoneNumber is IsoPhoneNumber PhoneNumberValue)
        {
            writer.WriteStartElement(null, "PhneNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPhoneNumber(PhoneNumberValue)); // data type PhoneNumber System.String
            writer.WriteEndElement();
        }
        if (MobileNumber is IsoPhoneNumber MobileNumberValue)
        {
            writer.WriteStartElement(null, "MobNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPhoneNumber(MobileNumberValue)); // data type PhoneNumber System.String
            writer.WriteEndElement();
        }
        if (FaxNumber is IsoPhoneNumber FaxNumberValue)
        {
            writer.WriteStartElement(null, "FaxNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPhoneNumber(FaxNumberValue)); // data type PhoneNumber System.String
            writer.WriteEndElement();
        }
        if (EmailAddress is IsoMax2048Text EmailAddressValue)
        {
            writer.WriteStartElement(null, "EmailAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(EmailAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
        if (EmailPurpose is IsoMax35Text EmailPurposeValue)
        {
            writer.WriteStartElement(null, "EmailPurp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(EmailPurposeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (JobTitle is IsoMax35Text JobTitleValue)
        {
            writer.WriteStartElement(null, "JobTitl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(JobTitleValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Responsibility is IsoMax35Text ResponsibilityValue)
        {
            writer.WriteStartElement(null, "Rspnsblty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ResponsibilityValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Department is IsoMax70Text DepartmentValue)
        {
            writer.WriteStartElement(null, "Dept", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(DepartmentValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Other is OtherContact1 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreferredMethod is PreferredContactMethod1Code PreferredMethodValue)
        {
            writer.WriteStartElement(null, "PrefrdMtd", xmlNamespace );
            writer.WriteValue(PreferredMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ValidFrom is IsoISODate ValidFromValue)
        {
            writer.WriteStartElement(null, "VldFr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidFromValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ValidTo is IsoISODate ValidToValue)
        {
            writer.WriteStartElement(null, "VldTo", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidToValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static new ContactDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
