﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionRequestV07.  ISO2002 ID# _10HpkQuiEeqw5uEXxQ9H4g.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.|")]
public partial record AcceptorCurrencyConversionRequestV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Currency Conversion request message management information.
    /// </summary>
    [IsoId("_10HplQuiEeqw5uEXxQ9H4g")]
    [Description(@"Currency Conversion request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the currency conversion request.
    /// </summary>
    [IsoId("_10HplwuiEeqw5uEXxQ9H4g")]
    [Description(@"Information related to the currency conversion request.")]
    [DataMember(Name="CcyConvsReq")]
    [XmlElement(ElementName="CcyConvsReq")]
    [Required]
    public required SomeCurrencyConversionRequestRecord CurrencyConversionRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_10HpmQuiEeqw5uEXxQ9H4g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionRequestV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionRequestV07Document ToDocument()
    {
        return new AcceptorCurrencyConversionRequestV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionRequestV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionRequestV07Document : IOuterDocument<AcceptorCurrencyConversionRequestV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.016.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionRequestV07"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionRequestV07 Message { get; init; }
}