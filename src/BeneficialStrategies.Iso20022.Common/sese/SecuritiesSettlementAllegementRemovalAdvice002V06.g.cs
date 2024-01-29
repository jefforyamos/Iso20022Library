﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementAllegementRemovalAdvice002V06.  ISO2002 ID# _dhIjMzi8Eeydid5dcNPKvg.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesSettlementAllegementRemovalAdvice to an account owner to acknowledge that a previously sent allegement is no longer outstanding, because the alleged party sent its instruction.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementAllegementRemovalAdvice to an account owner to acknowledge that a previously sent allegement is no longer outstanding, because the alleged party sent its instruction.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementAllegementRemovalAdvice002V06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmAllgmtRmvlAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_dhIjQTi8Eeydid5dcNPKvg")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="AcctSvcrTxId")]
    [XmlElement(ElementName="AcctSvcrTxId")]
    [Required]
    public required SomeAccountServicerTransactionIdentificationRecord AccountServicerTransactionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_dhIjQzi8Eeydid5dcNPKvg")]
    [Description(@"Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.")]
    [DataMember(Name="MktInfrstrctrTxId")]
    [XmlElement(ElementName="MktInfrstrctrTxId")]
    public SomeMarketInfrastructureTransactionIdentificationRecord? MarketInfrastructureTransactionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_dhIjRTi8Eeydid5dcNPKvg")]
    [Description(@"Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.")]
    [DataMember(Name="CtrPtyMktInfrstrctrTxId")]
    [XmlElement(ElementName="CtrPtyMktInfrstrctrTxId")]
    public SomeCounterpartyMarketInfrastructureTransactionIdentificationRecord? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_dhIjRzi8Eeydid5dcNPKvg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public SomeAccountOwnerRecord? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_dhIjSTi8Eeydid5dcNPKvg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SomeSafekeepingAccountRecord? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_dhIjSzi8Eeydid5dcNPKvg")]
    [Description(@"Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.")]
    [DataMember(Name="BlckChainAdrOrWllt")]
    [XmlElement(ElementName="BlckChainAdrOrWllt")]
    public SomeBlockChainAddressOrWalletRecord? BlockChainAddressOrWallet { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_dhIjTTi8Eeydid5dcNPKvg")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public SomeTransactionDetailsRecord? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dhIjTzi8Eeydid5dcNPKvg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementAllegementRemovalAdvice002V06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementAllegementRemovalAdvice002V06Document ToDocument()
    {
        return new SecuritiesSettlementAllegementRemovalAdvice002V06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementAllegementRemovalAdvice002V06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementAllegementRemovalAdvice002V06Document : IOuterDocument<SecuritiesSettlementAllegementRemovalAdvice002V06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.029.002.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementAllegementRemovalAdvice002V06"/> is required.
    /// </summary>
    public required SecuritiesSettlementAllegementRemovalAdvice002V06 Message { get; init; }
}