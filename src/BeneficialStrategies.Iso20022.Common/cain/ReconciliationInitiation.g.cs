﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReconciliationInitiation.  ISO2002 ID# _k8erYHu5EeSLmfFG0DG7zQ.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The ReconciliationInitiation message is sent by an acquirer or an agent to an issuer or an agent, to initiate an exchange of totals to be reconciled for debits, credits, chargebacks and other transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReconciliationInitiation message is sent by an acquirer or an agent to an issuer or an agent, to initiate an exchange of totals to be reconciled for debits, credits, chargebacks and other transactions.")]
public partial record ReconciliationInitiation : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RcncltnInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_vvDdIHu5EeSLmfFG0DG7zQ")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header17 Header { get; init; }
    
    /// <summary>
    /// Information related to the reconciliation.
    /// </summary>
    [IsoId("_35V-AHu5EeSLmfFG0DG7zQ")]
    [Description(@"Information related to the reconciliation.")]
    [DataMember(Name="RcncltnInitn")]
    [XmlElement(ElementName="RcncltnInitn")]
    [Required]
    public required AcquirerReconciliationInitiation1 ReconciliationInitiation { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_7qmk8HvAEeSLmfFG0DG7zQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReconciliationInitiationDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReconciliationInitiationDocument ToDocument()
    {
        return new ReconciliationInitiationDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReconciliationInitiation"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReconciliationInitiationDocument : IOuterDocument<ReconciliationInitiation>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReconciliationInitiation"/> is required.
    /// </summary>
    public required ReconciliationInitiation Message { get; init; }
}
