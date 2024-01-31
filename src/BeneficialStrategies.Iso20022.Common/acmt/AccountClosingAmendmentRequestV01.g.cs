﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountClosingAmendmentRequestV01.  ISO2002 ID# _nlQomNE9Ed-BzquC8wXy7w_1266077822.
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
/// The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.
/// Usage
/// This message may only be sent in response to a request from the financial institution to send additional information.
/// It could be sent together with other related documents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.|Usage|This message may only be sent in response to a request from the financial institution to send additional information.|It could be sent together with other related documents.")]
public partial record AccountClosingAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAmdmntReq";
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_nlQomdE9Ed-BzquC8wXy7w_-908345623")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nlQomtE9Ed-BzquC8wXy7w_-1865223147")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountForAction1 AccountIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_nlaZkNE9Ed-BzquC8wXy7w_-814283343")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_nlaZkdE9Ed-BzquC8wXy7w_1006271356")]
    [Description(@"Identification of the organisation requesting the change.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_nlaZktE9Ed-BzquC8wXy7w_-53663536")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract4? ContractDates { get; init; }
    
    /// <summary>
    /// Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.
    /// </summary>
    [IsoId("_nlaZk9E9Ed-BzquC8wXy7w_-114881708")]
    [Description(@"Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.")]
    [DataMember(Name="BalTrfAcct")]
    [XmlElement(ElementName="BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.
    /// </summary>
    [IsoId("_nlaZlNE9Ed-BzquC8wXy7w_258218512")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.")]
    [DataMember(Name="TrfAcctSvcrId")]
    [XmlElement(ElementName="TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_nlaZldE9Ed-BzquC8wXy7w_-944215031")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountClosingAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountClosingAmendmentRequestV01Document ToDocument()
    {
        return new AccountClosingAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountClosingAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountClosingAmendmentRequestV01Document : IOuterDocument<AccountClosingAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.020.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountClosingAmendmentRequestV01"/> is required.
    /// </summary>
    public required AccountClosingAmendmentRequestV01 Message { get; init; }
}
