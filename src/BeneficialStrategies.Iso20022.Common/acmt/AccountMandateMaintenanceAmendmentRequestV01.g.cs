﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountMandateMaintenanceAmendmentRequestV01.  ISO2002 ID# _rHdkCNE9Ed-BzquC8wXy7w_-266920575.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The AccountMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. This update is only about mandate information.
/// Usage
/// This message should only be sent in response to a request from the financial institution. This update is only about mandate information. The organisation will specify under the Mandate tag the complete information as it should be in the financial institutions records after processing the update request. It is not possible to update the account characteristics or organisation information with this message.
/// It is possible to request to update the mandate information of several accounts, if these accounts must have exactly the same mandates.
/// This message could be sent together with other related documents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. This update is only about mandate information.|Usage|This message should only be sent in response to a request from the financial institution. This update is only about mandate information. The organisation will specify under the Mandate tag the complete information as it should be in the financial institutions records after processing the update request. It is not possible to update the account characteristics or organisation information with this message.|It is possible to request to update the mandate information of several accounts, if these accounts must have exactly the same mandates.|This message could be sent together with other related documents.")]
public partial record AccountMandateMaintenanceAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMndtMntncAmdmntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_rHdkCdE9Ed-BzquC8wXy7w_-1650659865")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required SomeReferencesRecord References { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_rHnVANE9Ed-BzquC8wXy7w_1663722693")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public SomeContractDatesRecord? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_rHnVAdE9Ed-BzquC8wXy7w_1467666004")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public SomeUnderlyingMasterAgreementRecord? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_rHnVAtE9Ed-BzquC8wXy7w_604759008")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required SomeAccountIdentificationRecord AccountIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_rHnVA9E9Ed-BzquC8wXy7w_-391901204")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required SomeAccountServicerIdentificationRecord AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_rHnVBNE9Ed-BzquC8wXy7w_142996449")]
    [Description(@"Identification of the organisation requesting the change.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required SomeOrganisationIdentificationRecord OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_rHnVBdE9Ed-BzquC8wXy7w_-1737493661")]
    [Description(@"Information specifying the account mandate.")]
    [DataMember(Name="Mndt")]
    [XmlElement(ElementName="Mndt")]
    public SomeMandateRecord? Mandate { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_rHnVBtE9Ed-BzquC8wXy7w_629134464")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountMandateMaintenanceAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountMandateMaintenanceAmendmentRequestV01Document ToDocument()
    {
        return new AccountMandateMaintenanceAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountMandateMaintenanceAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountMandateMaintenanceAmendmentRequestV01Document : IOuterDocument<AccountMandateMaintenanceAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.018.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountMandateMaintenanceAmendmentRequestV01"/> is required.
    /// </summary>
    public required AccountMandateMaintenanceAmendmentRequestV01 Message { get; init; }
}