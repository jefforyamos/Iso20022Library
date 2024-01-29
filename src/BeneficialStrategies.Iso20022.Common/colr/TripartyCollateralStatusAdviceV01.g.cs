﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TripartyCollateralStatusAdviceV01.  ISO2002 ID# _2uaM6ys7EeySlt9bF77XfA.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope:
/// This message is sent by a triparty agent after the receipt of a collateral instruction from its client.
/// In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.
/// Usage:
/// This message provides valuation results as well as the status of the  proposed collateral movements (cash and securities).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope:|This message is sent by a triparty agent after the receipt of a collateral instruction from its client.||In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.||Usage:|This message provides valuation results as well as the status of the  proposed collateral movements (cash and securities).")]
public partial record TripartyCollateralStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_2uaM8ys7EeySlt9bF77XfA")]
    [Description(@"Provides unambiguous transaction identification information.|")]
    [DataMember(Name="TxInstrId")]
    [XmlElement(ElementName="TxInstrId")]
    [Required]
    public required SomeTransactionInstructionIdentificationRecord TransactionInstructionIdentification { get; init; }
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaM9Ss7EeySlt9bF77XfA")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required SomePaginationRecord Pagination { get; init; }
    
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_2uaM9ys7EeySlt9bF77XfA")]
    [Description(@"Provides the status of allocation of collateral to cover the instruction.|")]
    [DataMember(Name="AllcnSts")]
    [XmlElement(ElementName="AllcnSts")]
    public SomeAllocationStatusRecord? AllocationStatus { get; init; }
    
    /// <summary>
    /// Provides the status of settlement of the transaction or the instruction.
    /// </summary>
    [IsoId("_2uaM-Ss7EeySlt9bF77XfA")]
    [Description(@"Provides the status of settlement of the transaction or the instruction.")]
    [DataMember(Name="SttlmSts")]
    [XmlElement(ElementName="SttlmSts")]
    public SomeSettlementStatusRecord? SettlementStatus { get; init; }
    
    /// <summary>
    /// Provides the collateral status of an instruction.
    /// </summary>
    [IsoId("_2uaM-ys7EeySlt9bF77XfA")]
    [Description(@"Provides the collateral status of an instruction.|")]
    [DataMember(Name="CollSts")]
    [XmlElement(ElementName="CollSts")]
    public SomeCollateralStatusRecord? CollateralStatus { get; init; }
    
    /// <summary>
    /// provides general information about the instruction and collateral transaction the message refers to.
    /// </summary>
    [IsoId("_2uaM_Ss7EeySlt9bF77XfA")]
    [Description(@"provides general information about the instruction and collateral transaction the message refers to.|")]
    [DataMember(Name="GnlParams")]
    [XmlElement(ElementName="GnlParams")]
    [Required]
    public required SomeGeneralParametersRecord GeneralParameters { get; init; }
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaM_ys7EeySlt9bF77XfA")]
    [Description(@"Identifies the chain of collateral parties.|")]
    [DataMember(Name="CollPties")]
    [XmlElement(ElementName="CollPties")]
    [Required]
    public required SomeCollateralPartiesRecord CollateralParties { get; init; }
    
    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNASs7EeySlt9bF77XfA")]
    [Description(@"Specifies the information related to the deal.")]
    [DataMember(Name="DealTxDtls")]
    [XmlElement(ElementName="DealTxDtls")]
    [Required]
    public required SomeDealTransactionDetailsRecord DealTransactionDetails { get; init; }
    
    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNAys7EeySlt9bF77XfA")]
    [Description(@"Identifies the dates related to the triparty collateral instruction or transactions.|")]
    [DataMember(Name="DealTxDt")]
    [XmlElement(ElementName="DealTxDt")]
    [Required]
    public required SomeDealTransactionDateRecord DealTransactionDate { get; init; }
    
    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_2uaNBSs7EeySlt9bF77XfA")]
    [Description(@"Securities movements.")]
    [DataMember(Name="SctiesMvmnt")]
    [XmlElement(ElementName="SctiesMvmnt")]
    public SomeSecuritiesMovementRecord? SecuritiesMovement { get; init; }
    
    /// <summary>
    ///  Cash movement.
    /// </summary>
    [IsoId("_2uaNBys7EeySlt9bF77XfA")]
    [Description(@" Cash movement.")]
    [DataMember(Name="CshMvmnt")]
    [XmlElement(ElementName="CshMvmnt")]
    public SomeCashMovementRecord? CashMovement { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNCSs7EeySlt9bF77XfA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TripartyCollateralStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TripartyCollateralStatusAdviceV01Document ToDocument()
    {
        return new TripartyCollateralStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TripartyCollateralStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TripartyCollateralStatusAdviceV01Document : IOuterDocument<TripartyCollateralStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TripartyCollateralStatusAdviceV01"/> is required.
    /// </summary>
    public required TripartyCollateralStatusAdviceV01 Message { get; init; }
}