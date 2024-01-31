﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeMarginDataTransactionStateReportV01.  ISO2002 ID# _pVVvgWmFEe2DRvVJM2Qy-g.
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
/// The DerivativesTradeMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the derivatives transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the derivatives transactions.")]
public partial record DerivativesTradeMarginDataTransactionStateReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradMrgnDataTxStatRpt";
    
    #nullable enable
    /// <summary>
    /// Header information related to metadata of report message.
    /// </summary>
    [IsoId("_pVVvg2mFEe2DRvVJM2Qy-g")]
    [Description(@"Header information related to metadata of report message.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required TradeReportHeader4 ReportHeader { get; init; }
    
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [IsoId("_pVVvhWmFEe2DRvVJM2Qy-g")]
    [Description(@"Set of data concerning the reporting trade.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required ITradeData56Choice TradeData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVVvh2mFEe2DRvVJM2Qy-g")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeMarginDataTransactionStateReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeMarginDataTransactionStateReportV01Document ToDocument()
    {
        return new DerivativesTradeMarginDataTransactionStateReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeMarginDataTransactionStateReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeMarginDataTransactionStateReportV01Document : IOuterDocument<DerivativesTradeMarginDataTransactionStateReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.109.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeMarginDataTransactionStateReportV01"/> is required.
    /// </summary>
    public required DerivativesTradeMarginDataTransactionStateReportV01 Message { get; init; }
}
