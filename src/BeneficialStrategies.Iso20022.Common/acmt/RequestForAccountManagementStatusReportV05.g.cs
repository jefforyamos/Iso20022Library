﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForAccountManagementStatusReportV05.  ISO2002 ID# _SG-cUUNEEeaknIuOb43xYQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// Scope
/// The RequestForAccountManagementStatusReport message is sent by an account owner, for example, an investor or its designated agent, to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to request the status of an AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction.
/// Usage
/// The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction message for which an AccountDetailsConfirmation message has not yet been received.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RequestForAccountManagementStatusReport message is sent by an account owner, for example, an investor or its designated agent, to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to request the status of an AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction.|Usage|The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction message for which an AccountDetailsConfirmation message has not yet been received.")]
public partial record RequestForAccountManagementStatusReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForAcctMgmtStsRpt";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_SG-cU0NEEeaknIuOb43xYQ")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies the account for which the status of the account management instruction is requested.
    /// </summary>
    [IsoId("_SG-cVUNEEeaknIuOb43xYQ")]
    [Description(@"Identifies the account for which the status of the account management instruction is requested.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    [Required]
    public required AccountManagementMessageReference4 RequestDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForAccountManagementStatusReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForAccountManagementStatusReportV05Document ToDocument()
    {
        return new RequestForAccountManagementStatusReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForAccountManagementStatusReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForAccountManagementStatusReportV05Document : IOuterDocument<RequestForAccountManagementStatusReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.005.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForAccountManagementStatusReportV05"/> is required.
    /// </summary>
    public required RequestForAccountManagementStatusReportV05 Message { get; init; }
}
