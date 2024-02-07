﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommunicationAddress7.  ISO2002 ID# _tuV6EWIfEeeA54RzO_9yOw.
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
public partial record CommunicationAddress7
     : IIsoXmlSerilizable<CommunicationAddress7>
{
    #nullable enable
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax2048Text? Email { get; init; } 
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
    /// Address for a telex machine.
    /// </summary>
    public IsoMax35Text? TelexAddress { get; init; } 
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    public IsoMax2048Text? URLAddress { get; init; } 
    
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
        if (Email is IsoMax2048Text EmailValue)
        {
            writer.WriteStartElement(null, "Email", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(EmailValue)); // data type Max2048Text System.String
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
        if (TelexAddress is IsoMax35Text TelexAddressValue)
        {
            writer.WriteStartElement(null, "TlxAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TelexAddressValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (URLAddress is IsoMax2048Text URLAddressValue)
        {
            writer.WriteStartElement(null, "URLAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(URLAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
    }
    public static CommunicationAddress7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
