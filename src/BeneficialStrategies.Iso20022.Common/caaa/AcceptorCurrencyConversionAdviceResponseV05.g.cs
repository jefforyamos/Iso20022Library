﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionAdviceResponseV05.  ISO2002 ID# _MrhnQU7REeyGi9JAv6wq7Q.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.")]
public partial record AcceptorCurrencyConversionAdviceResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionAdviceResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionAdviceResponseV05Document ToDocument()
    {
        return new AcceptorCurrencyConversionAdviceResponseV05Document { Message = this };
    }
}

/// <summary>
/// The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.
/// This is the outer document that contains <seealso cref="AcceptorCurrencyConversionAdviceResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionAdviceResponseV05Document : IOuterDocument<AcceptorCurrencyConversionAdviceResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.019.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionAdviceResponseV05"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionAdviceResponseV05 Message { get; init; }
}
