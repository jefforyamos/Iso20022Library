﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInConfirmation.  ISO2002 ID# _JMkTONE6Ed-BzquC8wXy7w_-1545863539.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.TransferInConfirmation>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// TheTransferInConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent.
/// This message is used to confirm the receipt of a financial instrument, free of payment, at a given date, from a specified party. This message can also be used to confirm the transfer a financial instrument from an own account or from a third party.
/// Usage
/// TheTransferInConfirmation message is used by an executing party to confirm to the instructing party receipt of a financial instrument, either from another account owned by the instructing party or from a third party.
/// </summary>
[Serializable]
[Description(@"Scope|TheTransferInConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent.|This message is used to confirm the receipt of a financial instrument, free of payment, at a given date, from a specified party. This message can also be used to confirm the transfer a financial instrument from an own account or from a third party.|Usage|TheTransferInConfirmation message is used by an executing party to confirm to the instructing party receipt of a financial instrument, either from another account owned by the instructing party or from a third party.")]
public partial record TransferInConfirmation : IOuterRecord<TransferInConfirmation,TransferInConfirmationDocument>
    ,IIsoXmlSerilizable<TransferInConfirmation>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.007.001.01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => TransferInConfirmationDocument.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_JMkTOdE6Ed-BzquC8wXy7w_-169153916")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required AdditionalReference2 RelatedReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_JMkTOtE6Ed-BzquC8wXy7w_1069651183")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_JMuEMNE6Ed-BzquC8wXy7w_1503454128")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_JMuEMdE6Ed-BzquC8wXy7w_-2005768789")]
    [Description(@"General information related to the transfer of a financial instrument.")]
    [DataMember(Name="TrfDtls")]
    [XmlElement(ElementName="TrfDtls")]
    [Required]
    public required Transfer4 TransferDetails { get; init; }
    
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_JMuEMtE6Ed-BzquC8wXy7w_-1652058290")]
    [Description(@"Information related to the financial instrument received.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    [Required]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_JMuEM9E6Ed-BzquC8wXy7w_1104644640")]
    [Description(@"Information related to the account into which the financial instrument was received.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required InvestmentAccount10 AccountDetails { get; init; }
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_JMuENNE6Ed-BzquC8wXy7w_-1058954698")]
    [Description(@"Information related to the delivering side of the transfer.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required DeliverInformation2 SettlementDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JMuENdE6Ed-BzquC8wXy7w_879395382")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInConfirmationDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInConfirmationDocument ToDocument()
    {
        return new TransferInConfirmationDocument { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("sese.007.001.01");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "RltdRef", xmlNamespace );
        RelatedReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PoolReference is AdditionalReference2 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference2 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfDtls", xmlNamespace );
        TransferDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmDtls", xmlNamespace );
        SettlementDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransferInConfirmation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInConfirmation"/>.
/// </summary>
[Serializable]
public partial record TransferInConfirmationDocument : IOuterDocument<TransferInConfirmation>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInConfirmation"/> is required.
    /// </summary>
    [DataMember(Name=TransferInConfirmation.XmlTag)]
    public required TransferInConfirmation Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(TransferInConfirmation.XmlTag);
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
