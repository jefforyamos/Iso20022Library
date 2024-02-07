﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommunicationAddress8.  ISO2002 ID# _jVS2x5lCEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
public partial record CommunicationAddress8
     : IIsoXmlSerilizable<CommunicationAddress8>
{
    #nullable enable
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public required LongPostalAddress1Choice_ PostalAddress { get; init; } 
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    public IsoPhoneNumber? FaxNumber { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    
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
        writer.WriteStartElement(null, "PstlAdr", xmlNamespace );
        PostalAddress.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PhneNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPhoneNumber(PhoneNumber)); // data type PhoneNumber System.String
        writer.WriteEndElement();
        if (FaxNumber is IsoPhoneNumber FaxNumberValue)
        {
            writer.WriteStartElement(null, "FaxNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPhoneNumber(FaxNumberValue)); // data type PhoneNumber System.String
            writer.WriteEndElement();
        }
        if (EmailAddress is IsoMax256Text EmailAddressValue)
        {
            writer.WriteStartElement(null, "EmailAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(EmailAddressValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
    }
    public static CommunicationAddress8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
