﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionCounterpartyResponseV01.  ISO2002 ID# _0Z18hQlIEeGATtfOBToyew_-281695721.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope|An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:|- the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)|- the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.|The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants|The account owner may be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:|- the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)|- the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.|The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants|The account owner may be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesSettlementTransactionCounterpartyResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxCtrPtyRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionCounterpartyResponseV01Document ToDocument()
    {
        return new SecuritiesSettlementTransactionCounterpartyResponseV01Document { Message = this };
    }
}

/// <summary>
/// Scope|An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:|- the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)|- the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.|The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants|The account owner may be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// This is the outer document that contains <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionCounterpartyResponseV01Document : IOuterDocument<SecuritiesSettlementTransactionCounterpartyResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.040.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionCounterpartyResponseV01"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionCounterpartyResponseV01 Message { get; init; }
}
