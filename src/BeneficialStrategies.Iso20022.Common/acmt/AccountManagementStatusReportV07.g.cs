﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountManagementStatusReportV07.  ISO2002 ID# _tmYxMZDiEem7fvtoGpNpow.
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
/// The AccountManagementStatusReport message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner or its designated agent, for example, an investor to report on the receipt or the processing status of a previously received account management message.
/// Usage
/// The AccountManagementStatusReport message is used to provide the status of a previously received AccountOpeningInstruction, an AccountModificationInstruction or a GetAccountDetails message. It may also be used to report the status of the account. 
/// The AccountManagementStatusReport message is also used to reject an AccountOpeningInstruction, AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountManagementStatusReport message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner or its designated agent, for example, an investor to report on the receipt or the processing status of a previously received account management message.|Usage|The AccountManagementStatusReport message is used to provide the status of a previously received AccountOpeningInstruction, an AccountModificationInstruction or a GetAccountDetails message. It may also be used to report the status of the account. |The AccountManagementStatusReport message is also used to reject an AccountOpeningInstruction, AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified.")]
public partial record AccountManagementStatusReportV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMgmtStsRpt";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_tmYxM5DiEem7fvtoGpNpow")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_tmYxNZDiEem7fvtoGpNpow")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public required IReadOnlyCollection<AdditionalReference13> RelatedReference { get; init; } = []; // Min=1, Max=2
    
    /// <summary>
    /// Status details of the account management instruction for which the status is provided.
    /// </summary>
    [IsoId("_tmYxN5DiEem7fvtoGpNpow")]
    [Description(@"Status details of the account management instruction for which the status is provided.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required AccountManagementStatusAndReason5 StatusReport { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_tmYxOZDiEem7fvtoGpNpow")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_tmYxO5DiEem7fvtoGpNpow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountManagementStatusReportV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountManagementStatusReportV07Document ToDocument()
    {
        return new AccountManagementStatusReportV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountManagementStatusReportV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountManagementStatusReportV07Document : IOuterDocument<AccountManagementStatusReportV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountManagementStatusReportV07"/> is required.
    /// </summary>
    public required AccountManagementStatusReportV07 Message { get; init; }
}
