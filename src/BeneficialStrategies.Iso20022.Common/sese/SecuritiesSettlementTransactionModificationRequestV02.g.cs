﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionModificationRequestV02.  ISO2002 ID# _51rRcQxyEeKMmbvHOtE4SA.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:||- a central securities depository participant which has an account with a central securities depository or a market infrastructure||- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.|||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:||- a central securities depository participant which has an account with a central securities depository or a market infrastructure||- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.|||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesSettlementTransactionModificationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionModificationRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestV02Document ToDocument()
    {
        return new SecuritiesSettlementTransactionModificationRequestV02Document { Message = this };
    }
}

/// <summary>
/// Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:||- a central securities depository participant which has an account with a central securities depository or a market infrastructure||- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.|||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// This is the outer document that contains <seealso cref="SecuritiesSettlementTransactionModificationRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionModificationRequestV02Document : IOuterDocument<SecuritiesSettlementTransactionModificationRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.038.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionModificationRequestV02"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionModificationRequestV02 Message { get; init; }
}
