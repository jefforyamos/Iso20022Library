﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService16.  ISO2002 ID# _vzO6Ya4WEeW_TaP-ygI0SQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provided by the ATM inside the session.
/// </summary>
public partial record ATMService16
     : IIsoXmlSerilizable<ATMService16>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the withdrawal service provided by the ATM inside the session.
    /// </summary>
    public IsoMax35Text? ServiceReference { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    public IsoMax35Text? ATMServiceCode { get; init; } 
    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    public IsoMax35Text? HostServiceCode { get; init; } 
    /// <summary>
    /// Describes the type of withdrawal selected by the customer.
    /// </summary>
    public required ATMServiceType3Code ServiceType { get; init; } 
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    
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
        if (ServiceReference is IsoMax35Text ServiceReferenceValue)
        {
            writer.WriteStartElement(null, "SvcRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ATMServiceCode is IsoMax35Text ATMServiceCodeValue)
        {
            writer.WriteStartElement(null, "ATMSvcCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ATMServiceCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (HostServiceCode is IsoMax35Text HostServiceCodeValue)
        {
            writer.WriteStartElement(null, "HstSvcCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(HostServiceCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SvcTp", xmlNamespace );
        writer.WriteValue(ServiceType.ToString()); // Enum value
        writer.WriteEndElement();
        if (ServiceVariantIdentification is IsoMax35Text ServiceVariantIdentificationValue)
        {
            writer.WriteStartElement(null, "SvcVarntId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceVariantIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static ATMService16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
