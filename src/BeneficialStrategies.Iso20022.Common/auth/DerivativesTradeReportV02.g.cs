﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeReportV02.  ISO2002 ID# _6ULEkHg8Eeu3kecHd7QKUQ.
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
/// This record is an implementation of the auth.030.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeReport is sent by the reporting entities to provide transaction data to the trade repositories (TRs) or by the trade repositories (TRs) to the competent authorities.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeReport is sent by the reporting entities to provide transaction data to the trade repositories (TRs) or by the trade repositories (TRs) to the competent authorities.")]
public partial record DerivativesTradeReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.030.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRpt";
    
    #nullable enable
    /// <summary>
    /// Header information related to metadata of report message.
    /// </summary>
    [IsoId("_6ULEkng8Eeu3kecHd7QKUQ")]
    [Description(@"Header information related to metadata of report message.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required TradeQueryHeader4 ReportHeader { get; init; }
    
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [IsoId("_6ULElHg8Eeu3kecHd7QKUQ")]
    [Description(@"Data concerning the reporting trade.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeData19Choice_ TradeData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_6ULElng8Eeu3kecHd7QKUQ")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeReportV02Document ToDocument()
    {
        return new DerivativesTradeReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeReportV02Document : IOuterDocument<DerivativesTradeReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.030.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeReportV02"/> is required.
    /// </summary>
    public required DerivativesTradeReportV02 Message { get; init; }
}
