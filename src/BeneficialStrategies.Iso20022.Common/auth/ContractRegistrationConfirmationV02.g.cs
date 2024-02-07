﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ContractRegistrationConfirmationV02.  ISO2002 ID# _bf9RvW2PEei3KuUgpx7Xcw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.ContractRegistrationConfirmationV02>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.019.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ContractRegistrationConfirmation message is sent by the registration agent to the reporting party to register the contract subject to currency control.
/// </summary>
[Serializable]
[Description(@"The ContractRegistrationConfirmation message is sent by the registration agent to the reporting party to register the contract subject to currency control.")]
public partial record ContractRegistrationConfirmationV02 : IOuterRecord<ContractRegistrationConfirmationV02,ContractRegistrationConfirmationV02Document>
    ,IIsoXmlSerilizable<ContractRegistrationConfirmationV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.019.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtrctRegnConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ContractRegistrationConfirmationV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9Rv22PEei3KuUgpx7Xcw")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required CurrencyControlHeader6 GroupHeader { get; init; }
    
    /// <summary>
    /// Identifies the contract details which is registered for currency control.
    /// </summary>
    [IsoId("_bf9RwW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the contract details which is registered for currency control.")]
    [DataMember(Name="RegdCtrct")]
    [XmlElement(ElementName="RegdCtrct")]
    [Required]
    public required RegisteredContract7 RegisteredContract { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9Rw22PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ContractRegistrationConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ContractRegistrationConfirmationV02Document ToDocument()
    {
        return new ContractRegistrationConfirmationV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CtrctRegnConf");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
        GroupHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RegdCtrct", xmlNamespace );
        RegisteredContract.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ContractRegistrationConfirmationV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ContractRegistrationConfirmationV02"/>.
/// </summary>
[Serializable]
public partial record ContractRegistrationConfirmationV02Document : IOuterDocument<ContractRegistrationConfirmationV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.019.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ContractRegistrationConfirmationV02"/> is required.
    /// </summary>
    [DataMember(Name=ContractRegistrationConfirmationV02.XmlTag)]
    public required ContractRegistrationConfirmationV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ContractRegistrationConfirmationV02.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
