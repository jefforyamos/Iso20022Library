﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvestmentFundReportRequestV02.  ISO2002 ID# _Zsax2NEvEd-BzquC8wXy7w_-630681424.
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
/// This record is an implementation of the reda.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party sends the InvestmentFundReportRequest message to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.
/// The InvestmentFundReportRequest message can be used to request one or many fund processing passport reports.
/// Usage
/// If the InvestmentFundReportRequest message is used to request a fund processing passport then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund processing passport report that is specified as "no criteria" means that the request is a request for all fund processing passports.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party sends the InvestmentFundReportRequest message to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.|The InvestmentFundReportRequest message can be used to request one or many fund processing passport reports.|Usage|If the InvestmentFundReportRequest message is used to request a fund processing passport then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund processing passport report that is specified as ""no criteria"" means that the request is a request for all fund processing passports.")]
public partial record InvestmentFundReportRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvstmtFndRptReq";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Zsax2dEvEd-BzquC8wXy7w_-760876160")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zsax2tEvEd-BzquC8wXy7w_62177576")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Zsax29EvEd-BzquC8wXy7w_1615234816")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Parameters for which the fund processing passport report is requested.
    /// </summary>
    [IsoId("_Zsax3NEvEd-BzquC8wXy7w_436796647")]
    [Description(@"Parameters for which the fund processing passport report is requested.")]
    [DataMember(Name="FPPRpt")]
    [XmlElement(ElementName="FPPRpt")]
    [Required]
    public required FundParameters3Choice_ FundProcessingPassportReport { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvestmentFundReportRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvestmentFundReportRequestV02Document ToDocument()
    {
        return new InvestmentFundReportRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvestmentFundReportRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvestmentFundReportRequestV02Document : IOuterDocument<InvestmentFundReportRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvestmentFundReportRequestV02"/> is required.
    /// </summary>
    public required InvestmentFundReportRequestV02 Message { get; init; }
}
