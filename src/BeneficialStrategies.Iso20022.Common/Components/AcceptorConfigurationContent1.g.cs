﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationContent1.  ISO2002 ID# _Ksg2xX1DEeCF8NjrBemJWQ_1156169068.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
public partial record AcceptorConfigurationContent1
     : IIsoXmlSerilizable<AcceptorConfigurationContent1>
{
    #nullable enable
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    public AcquirerProtocolParameters1? AcquirerProtocolParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    public IsoMax10000Binary? MerchantParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    public ApplicationParameters1? ApplicationParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    public HostCommunicationParameter1? HostCommunicationParameters { get; init; } 
    
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
        if (AcquirerProtocolParameters is AcquirerProtocolParameters1 AcquirerProtocolParametersValue)
        {
            writer.WriteStartElement(null, "AcqrrPrtcolParams", xmlNamespace );
            AcquirerProtocolParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MerchantParameters is IsoMax10000Binary MerchantParametersValue)
        {
            writer.WriteStartElement(null, "MrchntParams", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(MerchantParametersValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (ApplicationParameters is ApplicationParameters1 ApplicationParametersValue)
        {
            writer.WriteStartElement(null, "ApplParams", xmlNamespace );
            ApplicationParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HostCommunicationParameters is HostCommunicationParameter1 HostCommunicationParametersValue)
        {
            writer.WriteStartElement(null, "HstComParams", xmlNamespace );
            HostCommunicationParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorConfigurationContent1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
