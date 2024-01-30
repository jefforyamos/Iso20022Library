﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorNonFinancialResponseV01.  ISO2002 ID# _Zf-nIC_tEeugIJ3Gvoevmg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorNonFinancialResponse message is sent by the Acquirer (or its Agent) to the POI to provide addintional information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorNonFinancialResponse message is sent by the Acquirer (or its Agent) to the POI to provide addintional information.")]
public partial record AcceptorNonFinancialResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrNonFinRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Non Financial response message management information.
    /// </summary>
    [IsoId("_xpdIky_tEeugIJ3Gvoevmg")]
    [Description(@"Non Financial response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the non financial response.
    /// </summary>
    [IsoId("_xpdIlC_tEeugIJ3Gvoevmg")]
    [Description(@"Information related to the non financial response.")]
    [DataMember(Name="NonFinRspn")]
    [XmlElement(ElementName="NonFinRspn")]
    [Required]
    public required NonFinancialResponseComponent1 NonFinancialResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_xpdIlS_tEeugIJ3Gvoevmg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorNonFinancialResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorNonFinancialResponseV01Document ToDocument()
    {
        return new AcceptorNonFinancialResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorNonFinancialResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorNonFinancialResponseV01Document : IOuterDocument<AcceptorNonFinancialResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorNonFinancialResponseV01"/> is required.
    /// </summary>
    public required AcceptorNonFinancialResponseV01 Message { get; init; }
}
