﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchPaymentResponseV02.  ISO2002 ID# _7HT_YW42EeiU9cctagi5ow.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchPaymentResponse message is sent by the new account servicer to the old account servicer to confirm whether it will make the requested payment in a request payment message. The AccountSwitchPaymentResponse message is only used to respond to a AccountSwitchRequestPayment message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchPaymentResponse message is sent by the new account servicer to the old account servicer to confirm whether it will make the requested payment in a request payment message. The AccountSwitchPaymentResponse message is only used to respond to a AccountSwitchRequestPayment message.")]
public partial record AccountSwitchPaymentResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchPmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HT_Y242EeiU9cctagi5ow")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_7HT_ZW42EeiU9cctagi5ow")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HT_Z242EeiU9cctagi5ow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchPaymentResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchPaymentResponseV02Document ToDocument()
    {
        return new AccountSwitchPaymentResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchPaymentResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchPaymentResponseV02Document : IOuterDocument<AccountSwitchPaymentResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.035.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchPaymentResponseV02"/> is required.
    /// </summary>
    public required AccountSwitchPaymentResponseV02 Message { get; init; }
}
