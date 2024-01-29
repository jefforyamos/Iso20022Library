﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingPairingRequestV02.  ISO2002 ID# _mxP0EcIVEeunlsN4rAgJZA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingPairingRequest is sent by the trade repository (TR) to the other trade repositories (TRs) in order to identify the trade repository (TR) holding information on a second leg of a given transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingPairingRequest is sent by the trade repository (TR) to the other trade repositories (TRs) in order to identify the trade repository (TR) holding information on a second leg of a given transaction.")]
public partial record SecuritiesFinancingReportingPairingRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgPairgReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of information identifying the transactions that are to be paired.
    /// </summary>
    [IsoId("_mxP0E8IVEeunlsN4rAgJZA")]
    [Description(@"Set of information identifying the transactions that are to be paired.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_mxP0FcIVEeunlsN4rAgJZA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingPairingRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingPairingRequestV02Document ToDocument()
    {
        return new SecuritiesFinancingReportingPairingRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingPairingRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingPairingRequestV02Document : IOuterDocument<SecuritiesFinancingReportingPairingRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.078.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingPairingRequestV02"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingPairingRequestV02 Message { get; init; }
}