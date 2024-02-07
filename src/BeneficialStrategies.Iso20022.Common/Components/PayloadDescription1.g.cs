﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PayloadDescription1.  ISO2002 ID# _jLvfUu5NEeCisYr99QEiWA_-1263684777.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information about the payload.
/// </summary>
public partial record PayloadDescription1
     : IIsoXmlSerilizable<PayloadDescription1>
{
    #nullable enable
    
    /// <summary>
    /// This component is used to identify the instance of the document exchanged.
    /// </summary>
    public required PayloadDetails1 PayloadDetails { get; init; } 
    /// <summary>
    /// Contains business information that is considered as necessary by the service provider.
    /// </summary>
    public ApplicationSpecifics1? ApplicationSpecificInformation { get; init; } 
    /// <summary>
    /// Identification of the type of payload.
    /// </summary>
    public required PayloadTypeDetails1 PayloadTypeDetails { get; init; } 
    /// <summary>
    /// Manifest that describes the related items or attachments.
    /// This block is repeated for each different type of item.
    /// </summary>
    public ManifestDetails1? ManifestDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "PyldDtls", xmlNamespace );
        PayloadDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ApplicationSpecificInformation is ApplicationSpecifics1 ApplicationSpecificInformationValue)
        {
            writer.WriteStartElement(null, "ApplSpcfcInf", xmlNamespace );
            ApplicationSpecificInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PyldTpDtls", xmlNamespace );
        PayloadTypeDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ManifestDetails is ManifestDetails1 ManifestDetailsValue)
        {
            writer.WriteStartElement(null, "MnfstDtls", xmlNamespace );
            ManifestDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PayloadDescription1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
