﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountClosingAmendmentRequestV02.  ISO2002 ID# _SCcGoQ1TEeKGXqvMN6jpiw.
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
/// The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.")]
public partial record AccountClosingAmendmentRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAmdmntReq";
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_SCcGow1TEeKGXqvMN6jpiw")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_1R5hMA1XEeKGXqvMN6jpiw")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification8? From { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SCcGpw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountForAction1 AccountIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_SCcGqw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_SCcGrw1TEeKGXqvMN6jpiw")]
    [Description(@"Identification of the organisation requesting the change.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required OrganisationIdentification8 OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_SCcGsw1TEeKGXqvMN6jpiw")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract4? ContractDates { get; init; }
    
    /// <summary>
    /// Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.
    /// </summary>
    [IsoId("_SCcGtw1TEeKGXqvMN6jpiw")]
    [Description(@"Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.")]
    [DataMember(Name="BalTrfAcct")]
    [XmlElement(ElementName="BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.
    /// </summary>
    [IsoId("_SCcGuw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.")]
    [DataMember(Name="TrfAcctSvcrId")]
    [XmlElement(ElementName="TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification5? TransferAccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_SCcGvw1TEeKGXqvMN6jpiw")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2nRz8A4AEeKGXqvMN6jpiw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountClosingAmendmentRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountClosingAmendmentRequestV02Document ToDocument()
    {
        return new AccountClosingAmendmentRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountClosingAmendmentRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountClosingAmendmentRequestV02Document : IOuterDocument<AccountClosingAmendmentRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.020.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountClosingAmendmentRequestV02"/> is required.
    /// </summary>
    public required AccountClosingAmendmentRequestV02 Message { get; init; }
}
