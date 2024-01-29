﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentReversalV03.  ISO2002 ID# _sHC5wFkyEeGeoaLUQk__nA_-203184069.
//
namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.
/// The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.
/// The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.|The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.|The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.")]
public partial record FIToFIPaymentReversalV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtRvsl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_sHC5wVkyEeGeoaLUQk__nA_1620531152")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_sHMqwFkyEeGeoaLUQk__nA_737297865")]
    [Description(@"Information concerning the original group of transactions, to which the message refers.")]
    [DataMember(Name="OrgnlGrpInf")]
    [XmlElement(ElementName="OrgnlGrpInf")]
    [Required]
    public required SomeOriginalGroupInformationRecord OriginalGroupInformation { get; init; }
    
    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_sHMqwVkyEeGeoaLUQk__nA_623458799")]
    [Description(@"Information concerning the original transactions, to which the reversal message refers.")]
    [DataMember(Name="TxInf")]
    [XmlElement(ElementName="TxInf")]
    public SomeTransactionInformationRecord? TransactionInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sHWbwFkyEeGeoaLUQk__nA_319943093")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentReversalV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentReversalV03Document ToDocument()
    {
        return new FIToFIPaymentReversalV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentReversalV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FIToFIPaymentReversalV03Document : IOuterDocument<FIToFIPaymentReversalV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.007.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentReversalV03"/> is required.
    /// </summary>
    public required FIToFIPaymentReversalV03 Message { get; init; }
}