﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionResponseV05.  ISO2002 ID# _LmgPwds5Eee9e6xduATmQg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.|")]
public partial record AcceptorCurrencyConversionResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Currency conversion response message management information.
    /// </summary>
    [IsoId("_LmgPxds5Eee9e6xduATmQg")]
    [Description(@"Currency conversion response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header35 Header { get; init; }
    
    /// <summary>
    /// Information related to the outcome of the currency conversion.
    /// </summary>
    [IsoId("_Lmg20ds5Eee9e6xduATmQg")]
    [Description(@"Information related to the outcome of the currency conversion.")]
    [DataMember(Name="CcyConvsRspn")]
    [XmlElement(ElementName="CcyConvsRspn")]
    [Required]
    public required AcceptorCurrencyConversionResponse5 CurrencyConversionResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC (message authentication code).
    /// </summary>
    [IsoId("_Lmg209s5Eee9e6xduATmQg")]
    [Description(@"Trailer of the message containing a MAC (message authentication code).")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType16? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionResponseV05Document ToDocument()
    {
        return new AcceptorCurrencyConversionResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionResponseV05Document : IOuterDocument<AcceptorCurrencyConversionResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.017.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionResponseV05"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionResponseV05 Message { get; init; }
}
