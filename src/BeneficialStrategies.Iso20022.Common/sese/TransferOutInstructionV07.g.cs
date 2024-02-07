﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutInstructionV07.  ISO2002 ID# _XlHSMR8LEeWpZde3LQh6dg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.TransferOutInstructionV07>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.001.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.
/// This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party.
/// </summary>
[Serializable]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.|This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party.")]
public partial record TransferOutInstructionV07 : IOuterRecord<TransferOutInstructionV07,TransferOutInstructionV07Document>
    ,IIsoXmlSerilizable<TransferOutInstructionV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.001.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => TransferOutInstructionV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_XlHSNR8LEeWpZde3LQh6dg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_XlHSNx8LEeWpZde3LQh6dg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference6? PoolReference { get; init; }
    
    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_XlHSOR8LEeWpZde3LQh6dg")]
    [Description(@"Reference of the linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_XlHSOx8LEeWpZde3LQh6dg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_XlHSPR8LEeWpZde3LQh6dg")]
    [Description(@"Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }
    
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    [IsoId("_XlHSPx8LEeWpZde3LQh6dg")]
    [Description(@"Requested date at which the instructing party places the transfer instruction.")]
    [DataMember(Name="ReqdTrfDt")]
    [XmlElement(ElementName="ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_XlHSQR8LEeWpZde3LQh6dg")]
    [Description(@"General information related to the transfer of a financial instrument.")]
    [DataMember(Name="TrfDtls")]
    [XmlElement(ElementName="TrfDtls")]
    [Required]
    public required Transfer30 TransferDetails { get; init; }
    
    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("_XlHSQx8LEeWpZde3LQh6dg")]
    [Description(@"Information related to the account from which the financial instrument is to be withdrawn.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required InvestmentAccount54 AccountDetails { get; init; }
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_XlHSRR8LEeWpZde3LQh6dg")]
    [Description(@"Information related to the receiving side of the transfer.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    public ReceiveInformation16? SettlementDetails { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_XlHSRx8LEeWpZde3LQh6dg")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_XlHSSR8LEeWpZde3LQh6dg")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XlHSSx8LEeWpZde3LQh6dg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutInstructionV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutInstructionV07Document ToDocument()
    {
        return new TransferOutInstructionV07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("TrfOutInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PoolReference is AdditionalReference6 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference6 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedReference is AdditionalReference6 RelatedReferenceValue)
        {
            writer.WriteStartElement(null, "RltdRef", xmlNamespace );
            RelatedReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RequestedTransferDate is DateFormat1Choice_ RequestedTransferDateValue)
        {
            writer.WriteStartElement(null, "ReqdTrfDt", xmlNamespace );
            RequestedTransferDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfDtls", xmlNamespace );
        TransferDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementDetails is ReceiveInformation16 SettlementDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmDtls", xmlNamespace );
            SettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketPracticeVersion is MarketPracticeVersion1 MarketPracticeVersionValue)
        {
            writer.WriteStartElement(null, "MktPrctcVrsn", xmlNamespace );
            MarketPracticeVersionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CopyDetails is CopyInformation4 CopyDetailsValue)
        {
            writer.WriteStartElement(null, "CpyDtls", xmlNamespace );
            CopyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransferOutInstructionV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferOutInstructionV07"/>.
/// </summary>
[Serializable]
public partial record TransferOutInstructionV07Document : IOuterDocument<TransferOutInstructionV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.001.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutInstructionV07"/> is required.
    /// </summary>
    [DataMember(Name=TransferOutInstructionV07.XmlTag)]
    public required TransferOutInstructionV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(TransferOutInstructionV07.XmlTag);
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
