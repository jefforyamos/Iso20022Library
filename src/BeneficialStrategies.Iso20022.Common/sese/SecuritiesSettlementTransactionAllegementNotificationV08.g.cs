﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAllegementNotificationV08.  ISO2002 ID# _rKSA4dBgEeihG9bKfarOOA.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionAllegementNotificationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAllgmtNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionAllegementNotificationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAllegementNotificationV08Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAllegementNotificationV08Document { Message = this };
    }
}

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// This is the outer document that contains <seealso cref="SecuritiesSettlementTransactionAllegementNotificationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionAllegementNotificationV08Document : IOuterDocument<SecuritiesSettlementTransactionAllegementNotificationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.028.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionAllegementNotificationV08"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionAllegementNotificationV08 Message { get; init; }
}
