﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder19.  ISO2002 ID# __kNqIZ1EEeublrfU-wN95w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the cardholder.
/// </summary>
public partial record Cardholder19
     : IIsoXmlSerilizable<Cardholder19>
{
    #nullable enable
    
    /// <summary>
    /// Contains the registered cardholder name that issuer knows to be correct.
    /// </summary>
    public CardholderName3? CardholderName { get; init; } 
    /// <summary>
    /// Identification of the cardholder.
    /// ISO 8583:87 bit 56 (TLV tag 03/dataset 73)
    /// ISO 8583:93 bit 112 (TLV tag 03/dataset 73)
    /// ISO 8583:2003 bit 51 (TLV tag 03/dataset 73)
    /// </summary>
    public Credentials2? Identification { get; init; } 
    /// <summary>
    /// Complete address of the cardholder.
    /// </summary>
    public Address2? Address { get; init; } 
    /// <summary>
    /// Contact information.
    /// ISO 8583:87 bit 56 (TLV tag 02/dataset 72)
    /// ISO 8583:93 bit 112 (TLV tag 02/dataset 72)
    /// ISO 8583:2003 bit 51 (TLV tag 02/dataset 72)
    /// </summary>
    public Contact1? ContactInformation { get; init; } 
    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    public IsoISODate? DateOfBirth { get; init; } 
    /// <summary>
    /// Identifies a cardholder that is a highly valued individual (e.g., Very Important Person).
    /// </summary>
    public IsoTrueFalseIndicator? HighValueCustomerIndicator { get; init; } 
    /// <summary>
    /// Additional cardholder data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    public LocalData7? LocalData { get; init; } 
    
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
        if (CardholderName is CardholderName3 CardholderNameValue)
        {
            writer.WriteStartElement(null, "CrdhldrNm", xmlNamespace );
            CardholderNameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Identification is Credentials2 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Address is Address2 AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            AddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactInformation is Contact1 ContactInformationValue)
        {
            writer.WriteStartElement(null, "CtctInf", xmlNamespace );
            ContactInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateOfBirth is IsoISODate DateOfBirthValue)
        {
            writer.WriteStartElement(null, "DtOfBirth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateOfBirthValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (HighValueCustomerIndicator is IsoTrueFalseIndicator HighValueCustomerIndicatorValue)
        {
            writer.WriteStartElement(null, "HghValCstmrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(HighValueCustomerIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalData is LocalData7 LocalDataValue)
        {
            writer.WriteStartElement(null, "LclData", xmlNamespace );
            LocalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Cardholder19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
