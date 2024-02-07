﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationContent6.  ISO2002 ID# _CyJ6AbAGEeah1_v59tW6Rg.
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
public partial record AcceptorConfigurationContent6
     : IIsoXmlSerilizable<AcceptorConfigurationContent6>
{
    #nullable enable
    
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; } 
    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    public TMSProtocolParameters2? TMSProtocolParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    public AcquirerProtocolParameters10? AcquirerProtocolParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    public MerchantConfigurationParameters3? MerchantParameters { get; init; } 
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    public PaymentTerminalParameters4? TerminalParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    public ApplicationParameters6? ApplicationParameters { get; init; } 
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    public HostCommunicationParameter4? HostCommunicationParameters { get; init; } 
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    public SecurityParameters6? SecurityParameters { get; init; } 
    
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
        if (ReplaceConfiguration is IsoTrueFalseIndicator ReplaceConfigurationValue)
        {
            writer.WriteStartElement(null, "RplcCfgtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ReplaceConfigurationValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (TMSProtocolParameters is TMSProtocolParameters2 TMSProtocolParametersValue)
        {
            writer.WriteStartElement(null, "TMSPrtcolParams", xmlNamespace );
            TMSProtocolParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcquirerProtocolParameters is AcquirerProtocolParameters10 AcquirerProtocolParametersValue)
        {
            writer.WriteStartElement(null, "AcqrrPrtcolParams", xmlNamespace );
            AcquirerProtocolParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MerchantParameters is MerchantConfigurationParameters3 MerchantParametersValue)
        {
            writer.WriteStartElement(null, "MrchntParams", xmlNamespace );
            MerchantParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminalParameters is PaymentTerminalParameters4 TerminalParametersValue)
        {
            writer.WriteStartElement(null, "TermnlParams", xmlNamespace );
            TerminalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ApplicationParameters is ApplicationParameters6 ApplicationParametersValue)
        {
            writer.WriteStartElement(null, "ApplParams", xmlNamespace );
            ApplicationParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HostCommunicationParameters is HostCommunicationParameter4 HostCommunicationParametersValue)
        {
            writer.WriteStartElement(null, "HstComParams", xmlNamespace );
            HostCommunicationParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityParameters is SecurityParameters6 SecurityParametersValue)
        {
            writer.WriteStartElement(null, "SctyParams", xmlNamespace );
            SecurityParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorConfigurationContent6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
