﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionResponseV10.  ISO2002 ID# _EoHywXMfEe2vXY6MoVq19w.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.017.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.
/// 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.|")]
public partial record AcceptorCurrencyConversionResponseV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.017.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsRspn";
    
    #nullable enable
    /// <summary>
    /// Currency conversion response message management information.
    /// </summary>
    [IsoId("_EoIZ03MfEe2vXY6MoVq19w")]
    [Description(@"Currency conversion response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header70 Header { get; init; }
    
    /// <summary>
    /// Information related to the outcome of the currency conversion.
    /// </summary>
    [IsoId("_EoIZ1XMfEe2vXY6MoVq19w")]
    [Description(@"Information related to the outcome of the currency conversion.")]
    [DataMember(Name="CcyConvsRspn")]
    [XmlElement(ElementName="CcyConvsRspn")]
    [Required]
    public required AcceptorCurrencyConversionResponse10 CurrencyConversionResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC (message authentication code).
    /// </summary>
    [IsoId("_EoIZ13MfEe2vXY6MoVq19w")]
    [Description(@"Trailer of the message containing a MAC (message authentication code).")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType36? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionResponseV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionResponseV10Document ToDocument()
    {
        return new AcceptorCurrencyConversionResponseV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionResponseV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionResponseV10Document : IOuterDocument<AcceptorCurrencyConversionResponseV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.017.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionResponseV10"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionResponseV10 Message { get; init; }
}
