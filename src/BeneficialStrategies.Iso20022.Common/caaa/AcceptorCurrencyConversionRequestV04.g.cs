﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionRequestV04.  ISO2002 ID# _MIALIaqMEeanIZ10Ka8PnA.
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
/// The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.|")]
public partial record AcceptorCurrencyConversionRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsReq";
    
    #nullable enable
    /// <summary>
    /// Currency Conversion request message management information.
    /// </summary>
    [IsoId("_MIALJaqMEeanIZ10Ka8PnA")]
    [Description(@"Currency Conversion request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header30 Header { get; init; }
    
    /// <summary>
    /// Information related to the currency conversion request.
    /// </summary>
    [IsoId("_MIALJ6qMEeanIZ10Ka8PnA")]
    [Description(@"Information related to the currency conversion request.")]
    [DataMember(Name="CcyConvsReq")]
    [XmlElement(ElementName="CcyConvsReq")]
    [Required]
    public required AcceptorCurrencyConversionRequest4 CurrencyConversionRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_MIALKaqMEeanIZ10Ka8PnA")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionRequestV04Document ToDocument()
    {
        return new AcceptorCurrencyConversionRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionRequestV04Document : IOuterDocument<AcceptorCurrencyConversionRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.016.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionRequestV04"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionRequestV04 Message { get; init; }
}
