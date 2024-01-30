﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RegulatoryTransactionReportV02.  ISO2002 ID# _gKH798IFEeGllrOKQRUTYA_1289680586.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// Scope
/// A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReport to a regulator or an intermediary (eg a reporting agent), to report the transaction details of a trade that has been executed on or off-exchange.
/// Usage
/// The message definition can be used to report more than one transaction. The message definition can also be used to specify, on a trade by trade basis, to which authorities the transaction report(s) need to be sent using the TransactionReportMarker.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReport to a regulator or an intermediary (eg a reporting agent), to report the transaction details of a trade that has been executed on or off-exchange.|Usage|The message definition can be used to report more than one transaction. The message definition can also be used to specify, on a trade by trade basis, to which authorities the transaction report(s) need to be sent using the TransactionReportMarker.")]
public partial record RegulatoryTransactionReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification of the RegulatoryTransactionReport.
    /// </summary>
    [IsoId("_gKH7-MIFEeGllrOKQRUTYA_1289680640")]
    [Description(@"Identification of the RegulatoryTransactionReport.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification8 Identification { get; init; }
    
    /// <summary>
    /// Provides details of the trade for which the transaction report is being sent.
    /// </summary>
    [IsoId("_gKRs8MIFEeGllrOKQRUTYA_1289680605")]
    [Description(@"Provides details of the trade for which the transaction report is being sent.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    [Required]
    public required TransactionDetails3 TransactionDetails { get; init; }
    
    /// <summary>
    /// Identification of the firm that is legally responsible for sending the transaction report.|.
    /// </summary>
    [IsoId("_gKRs8cIFEeGllrOKQRUTYA_1289680665")]
    [Description(@"Identification of the firm that is legally responsible for sending the transaction report.|.")]
    [DataMember(Name="RptgInstn")]
    [XmlElement(ElementName="RptgInstn")]
    [Required]
    public required IPartyIdentification23Choice ReportingInstitution { get; init; }
    
    /// <summary>
    /// Identifies the intermediary which is reporting on behalf on the ReportingInstitution. If there is a reporting chain, then the last party should override the previous one.
    /// </summary>
    [IsoId("_gKRs8sIFEeGllrOKQRUTYA_1289680990")]
    [Description(@"Identifies the intermediary which is reporting on behalf on the ReportingInstitution. If there is a reporting chain, then the last party should override the previous one.")]
    [DataMember(Name="RptgAgt")]
    [XmlElement(ElementName="RptgAgt")]
    public IPartyIdentification24Choice? ReportingAgent { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_gKRs88IFEeGllrOKQRUTYA_1289680973")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RegulatoryTransactionReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RegulatoryTransactionReportV02Document ToDocument()
    {
        return new RegulatoryTransactionReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RegulatoryTransactionReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RegulatoryTransactionReportV02Document : IOuterDocument<RegulatoryTransactionReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.008.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RegulatoryTransactionReportV02"/> is required.
    /// </summary>
    public required RegulatoryTransactionReportV02 Message { get; init; }
}
