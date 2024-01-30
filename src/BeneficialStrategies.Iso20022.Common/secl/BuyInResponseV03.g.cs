﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BuyInResponseV03.  ISO2002 ID# _2_0twS0lEeSRe9rElPHBfg.
//
namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// Scope
/// The BuyInResponse message is sent by the clearing member to the central counterparty as a response to the previous buy-in notification message.
/// The message definition is intended for use with the ISO 20022 Business Application Header.
/// Usage
/// The BuyInResponse may be sent in response to the BuyInNotification message. However, the use of this message in the buy in process is optional and depends on the rules set by each central counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BuyInResponse message is sent by the clearing member to the central counterparty as a response to the previous buy-in notification message.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The BuyInResponse may be sent in response to the BuyInNotification message. However, the use of this message in the buy in process is optional and depends on the rules set by each central counterparty.")]
public partial record BuyInResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_2_0twy0lEeSRe9rElPHBfg")]
    [Description(@"Unambiguous identification of the transaction as known by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides response details such as a request for delay and the number of days associated to that request.
    /// </summary>
    [IsoId("_2_0txS0lEeSRe9rElPHBfg")]
    [Description(@"Provides response details such as a request for delay and the number of days associated to that request.")]
    [DataMember(Name="BuyInRspnDtls")]
    [XmlElement(ElementName="BuyInRspnDtls")]
    [Required]
    public required BuyIn3 BuyInResponseDetails { get; init; }
    
    /// <summary>
    /// Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.
    /// </summary>
    [IsoId("_2_0txy0lEeSRe9rElPHBfg")]
    [Description(@"Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.")]
    [DataMember(Name="OrgnlSttlmOblgtnDtls")]
    [XmlElement(ElementName="OrgnlSttlmOblgtnDtls")]
    public SettlementObligation7? OriginalSettlementObligationDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2_0tyS0lEeSRe9rElPHBfg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BuyInResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BuyInResponseV03Document ToDocument()
    {
        return new BuyInResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BuyInResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BuyInResponseV03Document : IOuterDocument<BuyInResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.008.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BuyInResponseV03"/> is required.
    /// </summary>
    public required BuyInResponseV03 Message { get; init; }
}
