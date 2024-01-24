﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FraudReportingResponseV02.  ISO2002 ID# _Rt_mJMr8EeuNe7RtB4qFHw.
//
namespace BeneficialStrategies.Iso20022.cafr;

/// <summary>
/// A FraudReportingResponse message is sent by an agent (processor, agent) to an issuer or acquirer in response to a FraudReportingInitiation message.|
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A FraudReportingResponse message is sent by an agent (processor, agent) to an issuer or acquirer in response to a FraudReportingInitiation message.|")]
public partial record FraudReportingResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FrdRptgRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_Rt_mJ8r8EeuNe7RtB4qFHw")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the initiation of the fraud reporting.
    /// </summary>
    [IsoId("_Rt_mJsr8EeuNe7RtB4qFHw")]
    [Description(@"Information related to the initiation of the fraud reporting.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Rt_mJcr8EeuNe7RtB4qFHw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FraudReportingResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FraudReportingResponseV02Document ToDocument()
    {
        return new FraudReportingResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FraudReportingResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FraudReportingResponseV02Document : IOuterDocument<FraudReportingResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafr.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FraudReportingResponseV02"/> is required.
    /// </summary>
    public required FraudReportingResponseV02 Message { get; init; }
}
