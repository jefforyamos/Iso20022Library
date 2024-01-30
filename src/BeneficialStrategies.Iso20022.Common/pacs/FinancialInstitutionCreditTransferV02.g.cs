﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstitutionCreditTransferV02.  ISO2002 ID# _ef8nstEuEd-BzquC8wXy7w_-1794247615.
//
namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Scope
/// The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a creditor financial institution, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to move funds from a debtor account to a creditor, where both debtor and creditor are financial institutions.
/// Usage
/// The FinancialInstitutionCreditTransfer message is exchanged between agents and can contain one or more credit transfer instructions where debtor and creditor are both financial institutions.
/// The FinancialInstitutionCreditTransfer message does not allow for grouping: a CreditTransferTransactionInformation block must be present for each credit transfer transaction.
/// The FinancialInstitutionCreditTransfer message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a creditor financial institution, directly or through other agents and/or a payment clearing and settlement system.|It is used to move funds from a debtor account to a creditor, where both debtor and creditor are financial institutions.|Usage|The FinancialInstitutionCreditTransfer message is exchanged between agents and can contain one or more credit transfer instructions where debtor and creditor are both financial institutions.|The FinancialInstitutionCreditTransfer message does not allow for grouping: a CreditTransferTransactionInformation block must be present for each credit transfer transaction.|The FinancialInstitutionCreditTransfer message can be used in domestic and cross-border scenarios.")]
public partial record FinancialInstitutionCreditTransferV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstnCdtTrf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_ef8ns9EuEd-BzquC8wXy7w_-1794247584")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader35 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements providing information specific to the individual credit transfer(s).
    /// </summary>
    [IsoId("_ef8ntNEuEd-BzquC8wXy7w_-1794247244")]
    [Description(@"Set of elements providing information specific to the individual credit transfer(s).")]
    [DataMember(Name="CdtTrfTxInf")]
    [XmlElement(ElementName="CdtTrfTxInf")]
    [Required]
    public required CreditTransferTransactionInformation13 CreditTransferTransactionInformation { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstitutionCreditTransferV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstitutionCreditTransferV02Document ToDocument()
    {
        return new FinancialInstitutionCreditTransferV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstitutionCreditTransferV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstitutionCreditTransferV02Document : IOuterDocument<FinancialInstitutionCreditTransferV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstitutionCreditTransferV02"/> is required.
    /// </summary>
    public required FinancialInstitutionCreditTransferV02 Message { get; init; }
}
