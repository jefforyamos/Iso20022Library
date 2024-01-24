﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralSubstitutionResponseV05.  ISO2002 ID# _J4YklSgrEeyB747fKu7_rw.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected.")]
public partial record CollateralSubstitutionResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkmygrEeyB747fKu7_rw")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YknSgrEeyB747fKu7_rw")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required SomeObligationRecord Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YknygrEeyB747fKu7_rw")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public SomeAgreementRecord? Agreement { get; init; }
    
    /// <summary>
    /// Provides details about the collateral substitution response.
    /// </summary>
    [IsoId("_J4YkoSgrEeyB747fKu7_rw")]
    [Description(@"Provides details about the collateral substitution response.")]
    [DataMember(Name="SbstitnRspn")]
    [XmlElement(ElementName="SbstitnRspn")]
    [Required]
    public required SomeSubstitutionResponseRecord SubstitutionResponse { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkoygrEeyB747fKu7_rw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralSubstitutionResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralSubstitutionResponseV05Document ToDocument()
    {
        return new CollateralSubstitutionResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralSubstitutionResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralSubstitutionResponseV05Document : IOuterDocument<CollateralSubstitutionResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.011.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralSubstitutionResponseV05"/> is required.
    /// </summary>
    public required CollateralSubstitutionResponseV05 Message { get; init; }
}
