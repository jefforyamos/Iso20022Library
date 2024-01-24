﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlStatusAdviceV03.  ISO2002 ID# _Nz8avx3pEeuiRvbpCaJe6A.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.
/// Usage: 
/// The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.||Usage: |The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.")]
public partial record CurrencyControlStatusAdviceV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8awR3pEeuiRvbpCaJe6A")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Provides the group status for the global message.
    /// </summary>
    [IsoId("_Nz8awx3pEeuiRvbpCaJe6A")]
    [Description(@"Provides the group status for the global message.")]
    [DataMember(Name="GrpSts")]
    [XmlElement(ElementName="GrpSts")]
    [Required]
    public required SomeGroupStatusRecord GroupStatus { get; init; }
    
    /// <summary>
    /// Provides the status of the package in the message, which may contain the individual records.
    /// </summary>
    [IsoId("_Nz8axR3pEeuiRvbpCaJe6A")]
    [Description(@"Provides the status of the package in the message, which may contain the individual records.")]
    [DataMember(Name="PackgSts")]
    [XmlElement(ElementName="PackgSts")]
    public SomePackageStatusRecord? PackageStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8axx3pEeuiRvbpCaJe6A")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CurrencyControlStatusAdviceV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CurrencyControlStatusAdviceV03Document ToDocument()
    {
        return new CurrencyControlStatusAdviceV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CurrencyControlStatusAdviceV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CurrencyControlStatusAdviceV03Document : IOuterDocument<CurrencyControlStatusAdviceV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.027.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CurrencyControlStatusAdviceV03"/> is required.
    /// </summary>
    public required CurrencyControlStatusAdviceV03 Message { get; init; }
}
