﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstitutionDirectDebitV04.  ISO2002 ID# _LwDQLcP_Eemsic1bQcEtLA.
//
namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Scope:
/// The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.
/// Usage:
/// The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope:|The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.||Usage:|The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.|")]
public partial record FinancialInstitutionDirectDebitV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIDrctDbt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstitutionDirectDebitV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstitutionDirectDebitV04Document ToDocument()
    {
        return new FinancialInstitutionDirectDebitV04Document { Message = this };
    }
}

/// <summary>
/// Scope:
/// The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.
/// Usage:
/// The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.
/// This is the outer document that contains <seealso cref="FinancialInstitutionDirectDebitV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstitutionDirectDebitV04Document : IOuterDocument<FinancialInstitutionDirectDebitV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstitutionDirectDebitV04"/> is required.
    /// </summary>
    public required FinancialInstitutionDirectDebitV04 Message { get; init; }
}
