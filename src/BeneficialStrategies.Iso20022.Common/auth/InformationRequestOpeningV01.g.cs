﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InformationRequestOpeningV01.  ISO2002 ID# _ixVXwztbEeGg8InIPRjKog.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.
/// Requests are underpinned by specific legal texts.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.||Requests are underpinned by specific legal texts.")]
public partial record InformationRequestOpeningV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqOpng";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the specific investigation as known by the requesting party.
    /// </summary>
    [IsoId("_MvVY3zteEeGg8InIPRjKog")]
    [Description(@"Unique identification for the specific investigation as known by the requesting party.")]
    [DataMember(Name="InvstgtnId")]
    [XmlElement(ElementName="InvstgtnId")]
    [Required]
    public required IsoMax35Text InvestigationIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the legal basis of the request.
    /// </summary>
    [IsoId("_Gh6K-0J9EeGuetKibuqsKw")]
    [Description(@"Provides details on the legal basis of the request.")]
    [DataMember(Name="LglMndtBsis")]
    [XmlElement(ElementName="LglMndtBsis")]
    [Required]
    public required LegalMandate1 LegalMandateBasis { get; init; }
    
    /// <summary>
    /// Specifies the confidentiality status of the investigation.
    /// </summary>
    [IsoId("_UdsRrz2NEeGG64_ngBNdUg")]
    [Description(@"Specifies the confidentiality status of the investigation.")]
    [DataMember(Name="CnfdtltySts")]
    [XmlElement(ElementName="CnfdtltySts")]
    [Required]
    public required IsoYesNoIndicator ConfidentialityStatus { get; init; }
    
    /// <summary>
    /// Specifies the date by when the financial institutiion needs to provide a response.
    /// </summary>
    [IsoId("_6Pv_70cVEeGlWcsEChp7QA")]
    [Description(@"Specifies the date by when the financial institutiion needs to provide a response.")]
    [DataMember(Name="DueDt")]
    [XmlElement(ElementName="DueDt")]
    public DueDate1? DueDate { get; init; }
    
    /// <summary>
    /// Specifies the dates between which period the authority requests that the financial institution provides a response to the information request.
    /// </summary>
    [IsoId("_VWAzXzwlEeGUCuI3g5RrVg")]
    [Description(@"Specifies the dates between which period the authority requests that the financial institution provides a response to the information request.")]
    [DataMember(Name="InvstgtnPrd")]
    [XmlElement(ElementName="InvstgtnPrd")]
    [Required]
    public required IDateOrDateTimePeriodChoice InvestigationPeriod { get; init; }
    
    /// <summary>
    /// Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.
    /// </summary>
    [IsoId("_qpVADzthEeGg8InIPRjKog")]
    [Description(@"Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.")]
    [DataMember(Name="SchCrit")]
    [XmlElement(ElementName="SchCrit")]
    [Required]
    public required ISearchCriteria1Choice SearchCriteria { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_O_AtrzwoEeGUCuI3g5RrVg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InformationRequestOpeningV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InformationRequestOpeningV01Document ToDocument()
    {
        return new InformationRequestOpeningV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InformationRequestOpeningV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InformationRequestOpeningV01Document : IOuterDocument<InformationRequestOpeningV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InformationRequestOpeningV01"/> is required.
    /// </summary>
    public required InformationRequestOpeningV01 Message { get; init; }
}
