﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionAdviceV04.  ISO2002 ID# _U3EZsQuiEeqw5uEXxQ9H4g.
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
/// The AcceptorCurrencyConversionAdvice message is sent by the card acceptor to inform the currency conversion service provider of the outcome of the card currency conversion.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCurrencyConversionAdvice message is sent by the card acceptor to inform the currency conversion service provider of the outcome of the card currency conversion.|")]
public partial record AcceptorCurrencyConversionAdviceV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsAdvc";
    
    #nullable enable
    /// <summary>
    /// Currency Conversion request message management information.
    /// </summary>
    [IsoId("_U3FAwwuiEeqw5uEXxQ9H4g")]
    [Description(@"Currency Conversion request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header58 Header { get; init; }
    
    /// <summary>
    /// Information related to the outcome of the currency conversion.
    /// </summary>
    [IsoId("_U3FAxQuiEeqw5uEXxQ9H4g")]
    [Description(@"Information related to the outcome of the currency conversion.")]
    [DataMember(Name="AccptrCcyConvsAdvc")]
    [XmlElement(ElementName="AccptrCcyConvsAdvc")]
    [Required]
    public required AcceptorCurrencyConversionAdvice4 AcceptorCurrencyConversionAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_U3FAxwuiEeqw5uEXxQ9H4g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType24? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCurrencyConversionAdviceV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionAdviceV04Document ToDocument()
    {
        return new AcceptorCurrencyConversionAdviceV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCurrencyConversionAdviceV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCurrencyConversionAdviceV04Document : IOuterDocument<AcceptorCurrencyConversionAdviceV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.018.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCurrencyConversionAdviceV04"/> is required.
    /// </summary>
    public required AcceptorCurrencyConversionAdviceV04 Message { get; init; }
}
