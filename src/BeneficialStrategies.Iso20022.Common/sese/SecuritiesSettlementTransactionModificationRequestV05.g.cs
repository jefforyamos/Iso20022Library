﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionModificationRequestV05.  ISO2002 ID# _cCQpsYvSEea5B-LIompvYg.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// This message is sent by an account owner to an account servicer. 
/// The account owner will generally be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an investment manager which has an account with a custodian acting as accounting and/or settlement agent.
/// It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.
/// Usage
/// The modification must only contain the data to be modified.
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionModificationRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionModificationRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestV05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionModificationRequestV05Document { Message = this };
    }
}

/// <summary>
/// Scope
/// This message is sent by an account owner to an account servicer. 
/// The account owner will generally be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an investment manager which has an account with a custodian acting as accounting and/or settlement agent.
/// It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.
/// Usage
/// The modification must only contain the data to be modified.
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// This is the outer document that contains <seealso cref="SecuritiesSettlementTransactionModificationRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionModificationRequestV05Document : IOuterDocument<SecuritiesSettlementTransactionModificationRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.038.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionModificationRequestV05"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionModificationRequestV05 Message { get; init; }
}
