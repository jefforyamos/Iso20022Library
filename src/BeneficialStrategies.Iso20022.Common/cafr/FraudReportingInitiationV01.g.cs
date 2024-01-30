﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FraudReportingInitiationV01.  ISO2002 ID# _tme-4Xa1Eeef9c2nwgY9Xw.
//
namespace BeneficialStrategies.Iso20022.cafr;

/// <summary>
/// A FraudReportingInitiation message is usually sent by a financial institution acting as an acquirer or as an issuer to an agent (processor, agent)  to inform about a confirmed fraudulent transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A FraudReportingInitiation message is usually sent by a financial institution acting as an acquirer or as an issuer to an agent (processor, agent)  to inform about a confirmed fraudulent transaction.")]
public partial record FraudReportingInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FrdRptgInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_tme-43a1Eeef9c2nwgY9Xw")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header48 Header { get; init; }
    
    /// <summary>
    /// Information related to the initiation of the fraud reporting.
    /// </summary>
    [IsoId("_tme-5Xa1Eeef9c2nwgY9Xw")]
    [Description(@"Information related to the initiation of the fraud reporting.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required FraudReportingInitiation1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_tme-53a1Eeef9c2nwgY9Xw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FraudReportingInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FraudReportingInitiationV01Document ToDocument()
    {
        return new FraudReportingInitiationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FraudReportingInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FraudReportingInitiationV01Document : IOuterDocument<FraudReportingInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafr.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FraudReportingInitiationV01"/> is required.
    /// </summary>
    public required FraudReportingInitiationV01 Message { get; init; }
}
