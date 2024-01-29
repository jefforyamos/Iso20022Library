﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountReportV01.  ISO2002 ID# _vtUU2NE9Ed-BzquC8wXy7w_446669337.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The AccountReport message is sent from a financial institution to an organisation for reporting purposes.
/// Usage
/// It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountReport message is sent from a financial institution to an organisation for reporting purposes.|Usage|It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.")]
public partial record AccountReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_vtUU2dE9Ed-BzquC8wXy7w_-501291820")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required SomeReferencesRecord References { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_vtUU2tE9Ed-BzquC8wXy7w_-1906603151")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required SomeAccountServicerIdentificationRecord AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_vtdewNE9Ed-BzquC8wXy7w_-1289032009")]
    [Description(@"Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.")]
    [DataMember(Name="Org")]
    [XmlElement(ElementName="Org")]
    [Required]
    public required SomeOrganisationRecord Organisation { get; init; }
    
    /// <summary>
    /// Account report.
    /// </summary>
    [IsoId("_vtdewdE9Ed-BzquC8wXy7w_1826995567")]
    [Description(@"Account report.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    public SomeReportRecord? Report { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_vtdewtE9Ed-BzquC8wXy7w_1985192498")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountReportV01Document ToDocument()
    {
        return new AccountReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountReportV01Document : IOuterDocument<AccountReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountReportV01"/> is required.
    /// </summary>
    public required AccountReportV01 Message { get; init; }
}