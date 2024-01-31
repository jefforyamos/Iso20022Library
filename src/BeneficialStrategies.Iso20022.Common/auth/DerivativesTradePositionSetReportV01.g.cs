﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradePositionSetReportV01.  ISO2002 ID# _CClucQ1MEeqV4s5SpzR1dQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// The DerivativesTradePositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties that comprise positions sets, collateral position sets, currency positions sets and currency collateral position sets.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradePositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties that comprise positions sets, collateral position sets, currency positions sets and currency collateral position sets.")]
public partial record DerivativesTradePositionSetReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradPosSetRpt";
    
    #nullable enable
    /// <summary>
    /// Representation of exposures between a pair of counterparties that comprise positions sets, collateral position sets, currency positions sets and currency collateral position sets.
    /// </summary>
    [IsoId("_CClucw1MEeqV4s5SpzR1dQ")]
    [Description(@"Representation of exposures between a pair of counterparties that comprise positions sets, collateral position sets, currency positions sets and currency collateral position sets.")]
    [DataMember(Name="AggtdPos")]
    [XmlElement(ElementName="AggtdPos")]
    [Required]
    public required IPositionSetAggregated1Choice AggregatedPosition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CCludQ1MEeqV4s5SpzR1dQ")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradePositionSetReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradePositionSetReportV01Document ToDocument()
    {
        return new DerivativesTradePositionSetReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradePositionSetReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradePositionSetReportV01Document : IOuterDocument<DerivativesTradePositionSetReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.090.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradePositionSetReportV01"/> is required.
    /// </summary>
    public required DerivativesTradePositionSetReportV01 Message { get; init; }
}
