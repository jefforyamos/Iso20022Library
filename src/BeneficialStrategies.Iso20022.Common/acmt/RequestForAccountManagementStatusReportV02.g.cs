﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForAccountManagementStatusReportV02.  ISO2002 ID# _043Mq9E9Ed-BzquC8wXy7w_2127190710.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// An account owner, for example, an investor or its designated agent, sends the RequestForAccountManagementStatusReport message to the account servicer, for example, a registrar, transfer agent or custodian bank to request the status of an AccountOpeningInstruction or an AccountModificationInstruction.
/// Usage
/// The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction message or AccountModificationInstruction message for which a AccountDetailsConfirmation message has not yet been received.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the RequestForAccountManagementStatusReport message to the account servicer, for example, a registrar, transfer agent or custodian bank to request the status of an AccountOpeningInstruction or an AccountModificationInstruction.|Usage|The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction message or AccountModificationInstruction message for which a AccountDetailsConfirmation message has not yet been received.")]
public partial record RequestForAccountManagementStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForAcctMgmtStsRptV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_043MrNE9Ed-BzquC8wXy7w_-809277134")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Information to identify the account management instruction for which the status is requested.
    /// </summary>
    [IsoId("_043MrdE9Ed-BzquC8wXy7w_2127190736")]
    [Description(@"Information to identify the account management instruction for which the status is requested.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    [Required]
    public required SomeRequestDetailsRecord RequestDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForAccountManagementStatusReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForAccountManagementStatusReportV02Document ToDocument()
    {
        return new RequestForAccountManagementStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForAccountManagementStatusReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForAccountManagementStatusReportV02Document : IOuterDocument<RequestForAccountManagementStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForAccountManagementStatusReportV02"/> is required.
    /// </summary>
    public required RequestForAccountManagementStatusReportV02 Message { get; init; }
}