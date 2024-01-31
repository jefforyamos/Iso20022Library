﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorNonFinancialRequestV02.  ISO2002 ID# _13CDAU3kEey_VecAUE-C9Q.
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
/// This record is an implementation of the caaa.022.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorNonFinancialRequest message is sent by the POI to receive additional information from the Acquirer (or its agent).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorNonFinancialRequest message is sent by the POI to receive additional information from the Acquirer (or its agent).")]
public partial record AcceptorNonFinancialRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.022.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrNonFinReq";
    
    #nullable enable
    /// <summary>
    /// Non Financial request message management information.
    /// </summary>
    [IsoId("_13CDA03kEey_VecAUE-C9Q")]
    [Description(@"Non Financial request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the non financial request.
    /// </summary>
    [IsoId("_13CDBU3kEey_VecAUE-C9Q")]
    [Description(@"Information related to the non financial request.")]
    [DataMember(Name="NonFinReq")]
    [XmlElement(ElementName="NonFinReq")]
    [Required]
    public required NonFinancialRequestComponent2 NonFinancialRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_13CDB03kEey_VecAUE-C9Q")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorNonFinancialRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorNonFinancialRequestV02Document ToDocument()
    {
        return new AcceptorNonFinancialRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorNonFinancialRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorNonFinancialRequestV02Document : IOuterDocument<AcceptorNonFinancialRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.022.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorNonFinancialRequestV02"/> is required.
    /// </summary>
    public required AcceptorNonFinancialRequestV02 Message { get; init; }
}
