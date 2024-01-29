﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFICustomerDirectDebitV05.  ISO2002 ID# _fTgL6xPeEeSVo-TFVwFHvA.
//
namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Scope
/// The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to collect funds from a debtor account for a creditor.
/// Usage
/// The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.
/// The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.
/// The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.
/// The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.|It is used to collect funds from a debtor account for a creditor.|Usage|The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.|The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.|The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.|The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.")]
public partial record FIToFICustomerDirectDebitV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFICstmrDrctDbt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_fTgL_RPeEeSVo-TFVwFHvA")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements providing information specific to the individual direct debit(s).
    /// </summary>
    [IsoId("_fTgL_xPeEeSVo-TFVwFHvA")]
    [Description(@"Set of elements providing information specific to the individual direct debit(s).")]
    [DataMember(Name="DrctDbtTxInf")]
    [XmlElement(ElementName="DrctDbtTxInf")]
    [Required]
    public required SomeDirectDebitTransactionInformationRecord DirectDebitTransactionInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fTgMARPeEeSVo-TFVwFHvA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFICustomerDirectDebitV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFICustomerDirectDebitV05Document ToDocument()
    {
        return new FIToFICustomerDirectDebitV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFICustomerDirectDebitV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FIToFICustomerDirectDebitV05Document : IOuterDocument<FIToFICustomerDirectDebitV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFICustomerDirectDebitV05"/> is required.
    /// </summary>
    public required FIToFICustomerDirectDebitV05 Message { get; init; }
}