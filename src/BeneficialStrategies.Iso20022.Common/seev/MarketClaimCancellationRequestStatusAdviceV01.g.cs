﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarketClaimCancellationRequestStatusAdviceV01.  ISO2002 ID# _ygQkkNsFEeqmdMJWobugpw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// Scope and Usage
/// The MarketClaimCancellationRequestStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction cancellation request.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope and Usage|The MarketClaimCancellationRequestStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction cancellation request.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MarketClaimCancellationRequestStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCxlReqStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of the related market claim cancellation request document for which the status is provided.
    /// </summary>
    [IsoId("_r6OtoNx3EeqESbVR5AloZQ")]
    [Description(@"Identification of the related market claim cancellation request document for which the status is provided.")]
    [DataMember(Name="MktClmCxlReqId")]
    [XmlElement(ElementName="MktClmCxlReqId")]
    [Required]
    public required DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_x1AqBNx3EeqESbVR5AloZQ")]
    [Description(@"References of the transaction for which the securities settlement condition modification is requested.")]
    [DataMember(Name="TxRef")]
    [XmlElement(ElementName="TxRef")]
    [Required]
    public required References26 TransactionReference { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_x1AqBdx3EeqESbVR5AloZQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Status information about the processing of the market claim cancellation request.
    /// </summary>
    [IsoId("_7H81ANx3EeqESbVR5AloZQ")]
    [Description(@"Status information about the processing of the market claim cancellation request.")]
    [DataMember(Name="MktClmCxlReqSts")]
    [XmlElement(ElementName="MktClmCxlReqSts")]
    [Required]
    public required IMarketClaimCancellationRequestStatus1Choice MarketClaimCancellationRequestStatus { get; init; }
    
    /// <summary>
    /// Detailed information about the related corporate action option and related movements to which the market claim is linked.
    /// </summary>
    [IsoId("_x1AqBtx3EeqESbVR5AloZQ")]
    [Description(@"Detailed information about the related corporate action option and related movements to which the market claim is linked.")]
    [DataMember(Name="MktClmDtls")]
    [XmlElement(ElementName="MktClmDtls")]
    public CorporateActionOption185? MarketClaimDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_S5Y80SgaEeuYwc3diVMizA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarketClaimCancellationRequestStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarketClaimCancellationRequestStatusAdviceV01Document ToDocument()
    {
        return new MarketClaimCancellationRequestStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarketClaimCancellationRequestStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MarketClaimCancellationRequestStatusAdviceV01Document : IOuterDocument<MarketClaimCancellationRequestStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.053.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarketClaimCancellationRequestStatusAdviceV01"/> is required.
    /// </summary>
    public required MarketClaimCancellationRequestStatusAdviceV01 Message { get; init; }
}
