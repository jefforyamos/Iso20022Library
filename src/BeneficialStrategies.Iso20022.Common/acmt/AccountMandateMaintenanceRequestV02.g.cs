﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountMandateMaintenanceRequestV02.  ISO2002 ID# _Yex38Q1TEeKGXqvMN6jpiw.
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
/// The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update one or several accounts. Usage: this update is only about mandate information. 
/// If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request. 
/// If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.
/// It is not possible to update the account characteristics or organisation information with this message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update one or several accounts. Usage: this update is only about mandate information. |If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request. |If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.|It is not possible to update the account characteristics or organisation information with this message.")]
public partial record AccountMandateMaintenanceRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMndtMntncReq";
    
    #nullable enable
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_Yex38w1TEeKGXqvMN6jpiw")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_TABW8A1YEeKGXqvMN6jpiw")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification8? From { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_Yex39w1TEeKGXqvMN6jpiw")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract2? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_Yex3-w1TEeKGXqvMN6jpiw")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Yex3_w1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required AccountForAction1 AccountIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_Yex4Aw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_Yex4Bw1TEeKGXqvMN6jpiw")]
    [Description(@"Identification of the organisation requesting the change.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required Organisation14 OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_Yex4Cw1TEeKGXqvMN6jpiw")]
    [Description(@"Information specifying the account mandate.")]
    [DataMember(Name="Mndt")]
    [XmlElement(ElementName="Mndt")]
    [Required]
    public required OperationMandate3 Mandate { get; init; }
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_gEgTIA4XEeKGXqvMN6jpiw")]
    [Description(@"Definition of a group of parties.")]
    [DataMember(Name="Grp")]
    [XmlElement(ElementName="Grp")]
    public Group2? Group { get; init; }
    
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_Yex4Dw1TEeKGXqvMN6jpiw")]
    [Description(@"Contains additional information related to the message.")]
    [DataMember(Name="AddtlMsgInf")]
    [XmlElement(ElementName="AddtlMsgInf")]
    public AdditionalInformation5? AdditionalMessageInformation { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_Yex4Ew1TEeKGXqvMN6jpiw")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qNAEkA4AEeKGXqvMN6jpiw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountMandateMaintenanceRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountMandateMaintenanceRequestV02Document ToDocument()
    {
        return new AccountMandateMaintenanceRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountMandateMaintenanceRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountMandateMaintenanceRequestV02Document : IOuterDocument<AccountMandateMaintenanceRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.017.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountMandateMaintenanceRequestV02"/> is required.
    /// </summary>
    public required AccountMandateMaintenanceRequestV02 Message { get; init; }
}
