﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionAdviceResponseV01.  ISO2002 ID# _o7sQ1RCFEeeriKqGwDrUEg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.")]
public partial record AcceptorCurrencyConversionAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_o7sQ1xCFEeeriKqGwDrUEg")]
    [Description(@"Cancellation advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the currency conversion advice response.
    /// </summary>
    [IsoId("_o7sQ1hCFEeeriKqGwDrUEg")]
    [Description(@"Information related to the currency conversion advice response.")]
    [DataMember(Name="CcyConvsAdvcRspn")]
    [XmlElement(ElementName="CcyConvsAdvcRspn")]
    [Required]
    public required SomeCurrencyConversionAdviceResponseRecord CurrencyConversionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_o7sQ2BCFEeeriKqGwDrUEg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionAdviceResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionAdviceResponseV01Document ToDocument()
    {
        return new AcceptorCurrencyConversionAdviceResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionAdviceResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionAdviceResponseV01Document : IOuterDocument<AcceptorCurrencyConversionAdviceResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.019.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionAdviceResponseV01"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionAdviceResponseV01 Message { get; init; }
}
