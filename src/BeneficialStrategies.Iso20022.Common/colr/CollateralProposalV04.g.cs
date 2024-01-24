﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralProposalV04.  ISO2002 ID# _ih0twYFrEeWtPe6Crjmeug.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The CollateralProposal message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager, to propose the collateral to be delivered. This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. This message is used for both initial collateral proposal and subsequent counter proposals.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. The collateral proposal can include securities, cash and other types of collateral.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralProposal message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager, to propose the collateral to be delivered. This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. This message is used for both initial collateral proposal and subsequent counter proposals.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. The collateral proposal can include securities, cash and other types of collateral.")]
public partial record CollateralProposalV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollPrpsl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_ih0tw4FrEeWtPe6Crjmeug")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_ih0txYFrEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required SomeObligationRecord Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_ih0tx4FrEeWtPe6Crjmeug")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public SomeAgreementRecord? Agreement { get; init; }
    
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_ih0tyYFrEeWtPe6Crjmeug")]
    [Description(@"Indicates whether this is an initial or counter proposal.")]
    [DataMember(Name="TpAndDtls")]
    [XmlElement(ElementName="TpAndDtls")]
    [Required]
    public required SomeTypeAndDetailsRecord TypeAndDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ih0ty4FrEeWtPe6Crjmeug")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralProposalV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralProposalV04Document ToDocument()
    {
        return new CollateralProposalV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralProposalV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralProposalV04Document : IOuterDocument<CollateralProposalV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.007.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralProposalV04"/> is required.
    /// </summary>
    public required CollateralProposalV04 Message { get; init; }
}
