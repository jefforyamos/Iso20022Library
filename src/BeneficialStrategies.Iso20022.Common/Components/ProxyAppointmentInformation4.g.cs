﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProxyAppointmentInformation4.  ISO2002 ID# _kQJ7Ja09EemDtrWpq90Ckg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the registration of a proxy.
/// </summary>
public partial record ProxyAppointmentInformation4
     : IIsoXmlSerilizable<ProxyAppointmentInformation4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies how to register the proxy.
    /// </summary>
    public IsoMax350Text? RegistrationMethod { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary.
    /// </summary>
    public DateFormat58Choice_? Deadline { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the issuer.
    /// </summary>
    public DateFormat58Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Proxy person that is authorised by the issuer.
    /// </summary>
    public ValueList<Proxy8> AuthorisedProxy { get; init; } = [];
    
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
        if (RegistrationMethod is IsoMax350Text RegistrationMethodValue)
        {
            writer.WriteStartElement(null, "RegnMtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(RegistrationMethodValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Deadline is DateFormat58Choice_ DeadlineValue)
        {
            writer.WriteStartElement(null, "Ddln", xmlNamespace );
            DeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketDeadline is DateFormat58Choice_ MarketDeadlineValue)
        {
            writer.WriteStartElement(null, "MktDdln", xmlNamespace );
            MarketDeadlineValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AuthrsdPrxy", xmlNamespace );
        AuthorisedProxy.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ProxyAppointmentInformation4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
