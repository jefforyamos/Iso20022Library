﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PaymentReturnV07.  ISO2002 ID# _YJ-PMWXjEeap-P22vGV91g.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pacs;


/// <summary>
/// Scope
/// The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.
/// Usage
/// The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).
/// The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message ('notification') and/or BankToCustomerAccountReport/BankToCustomerStatement message ('statement').
/// The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.
/// The PaymentReturn message can be used in domestic and cross-border scenarios.
/// The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.|Usage|The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).|The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message ('notification') and/or BankToCustomerAccountReport/BankToCustomerStatement message ('statement').|The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.|The PaymentReturn message can be used in domestic and cross-border scenarios.|The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.")]
public partial record PaymentReturnV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtRtr";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_YJ-PTWXjEeap-P22vGV91g")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader72 GroupHeader { get; init; }
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_YJ-PT2XjEeap-P22vGV91g")]
    [Description(@"Information concerning the original group of transactions, to which the message refers.")]
    [DataMember(Name="OrgnlGrpInf")]
    [XmlElement(ElementName="OrgnlGrpInf")]
    public OriginalGroupHeader2? OriginalGroupInformation { get; init; }
    
    /// <summary>
    /// Information concerning the original transactions, to which the return message refers.
    /// </summary>
    [IsoId("_YJ-PUWXjEeap-P22vGV91g")]
    [Description(@"Information concerning the original transactions, to which the return message refers.")]
    [DataMember(Name="TxInf")]
    [XmlElement(ElementName="TxInf")]
    public PaymentTransaction76? TransactionInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YJ-PU2XjEeap-P22vGV91g")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PaymentReturnV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PaymentReturnV07Document ToDocument()
    {
        return new PaymentReturnV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PaymentReturnV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PaymentReturnV07Document : IOuterDocument<PaymentReturnV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PaymentReturnV07"/> is required.
    /// </summary>
    public required PaymentReturnV07 Message { get; init; }
}
