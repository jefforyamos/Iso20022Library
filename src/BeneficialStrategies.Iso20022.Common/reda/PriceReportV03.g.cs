﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportV03.  ISO2002 ID# _ZtdTrNEvEd-BzquC8wXy7w_1235947940.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// Scope
/// A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.
/// Usage
/// The PriceReport message is used to:
/// - report prices for one or several different financial instruments for one or several different trade dates,
/// - report statistical information about the valuation of a financial instrument,
/// - inform another party that the quotation of a financial instrument is suspended,
/// - report prices that are used for purposes other than the execution of investment funds orders.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.|Usage|The PriceReport message is used to:|- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for purposes other than the execution of investment funds orders.")]
public partial record PriceReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptV03";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_ZtdTrdEvEd-BzquC8wXy7w_-55887132")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZtdTrtEvEd-BzquC8wXy7w_1451126940")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_ZtdTr9EvEd-BzquC8wXy7w_1460364565")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_ZtnEoNEvEd-BzquC8wXy7w_1463134202")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_ZtnEodEvEd-BzquC8wXy7w_-1390634790")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_ZtnEotEvEd-BzquC8wXy7w_-1559220548")]
    [Description(@"Information related to the price valuation of a financial instrument.")]
    [DataMember(Name="PricValtnDtls")]
    [XmlElement(ElementName="PricValtnDtls")]
    [Required]
    public required PriceValuation3 PriceValuationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZtnEo9EvEd-BzquC8wXy7w_-1773147282")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportV03Document ToDocument()
    {
        return new PriceReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportV03Document : IOuterDocument<PriceReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.001.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportV03"/> is required.
    /// </summary>
    public required PriceReportV03 Message { get; init; }
}
