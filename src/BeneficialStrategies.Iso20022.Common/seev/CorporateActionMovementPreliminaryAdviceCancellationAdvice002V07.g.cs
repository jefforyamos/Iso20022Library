﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07.  ISO2002 ID# _u3Nnc5wuEeazcsnODTksnQ.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_u3NndZwuEeazcsnODTksnQ")]
    [Description(@"Identification of a previously sent movement preliminary advice document.")]
    [DataMember(Name="MvmntPrlimryAdvcId")]
    [XmlElement(ElementName="MvmntPrlimryAdvcId")]
    [Required]
    public required SomeMovementPreliminaryAdviceIdentificationRecord MovementPreliminaryAdviceIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_u3Nnd5wuEeazcsnODTksnQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_u3NneZwuEeazcsnODTksnQ")]
    [Description(@"General information about the safekeeping account and the account owner.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_u3Nne5wuEeazcsnODTksnQ")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public SomeCorporateActionDetailsRecord? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_u3NnfZwuEeazcsnODTksnQ")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public SomeIssuerAgentRecord? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_u3Nnf5wuEeazcsnODTksnQ")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public SomePayingAgentRecord? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_u3NngZwuEeazcsnODTksnQ")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public SomeSubPayingAgentRecord? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_u3Nng5wuEeazcsnODTksnQ")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public SomeRegistrarRecord? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_u3NnhZwuEeazcsnODTksnQ")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public SomeResellingAgentRecord? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_u3Nnh5wuEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public SomePhysicalSecuritiesAgentRecord? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_u3NniZwuEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public SomeDropAgentRecord? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_u3Nni5wuEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public SomeSolicitationAgentRecord? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_u3NnjZwuEeazcsnODTksnQ")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public SomeInformationAgentRecord? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_u3Nnj5wuEeazcsnODTksnQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07Document ToDocument()
    {
        return new CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07Document : IOuterDocument<CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.002.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07"/> is required.
    /// </summary>
    public required CorporateActionMovementPreliminaryAdviceCancellationAdvice002V07 Message { get; init; }
}
