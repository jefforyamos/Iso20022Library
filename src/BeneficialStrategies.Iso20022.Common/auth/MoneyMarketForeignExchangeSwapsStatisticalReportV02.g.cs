﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MoneyMarketForeignExchangeSwapsStatisticalReportV02.  ISO2002 ID# _9ugiUcEOEea7jLfvGi1PDw.
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
/// This record is an implementation of the auth.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all daily Foreign Exchange Swaps (FX Swaps) transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all daily Foreign Exchange Swaps (FX Swaps) transactions.")]
public partial record MoneyMarketForeignExchangeSwapsStatisticalReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.014.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktFXSwpsSttstclRpt";
    
    #nullable enable
    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_9ugiU8EOEea7jLfvGi1PDw")]
    [Description(@"Provides the elements specific to the report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required MoneyMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the foreign exchange swaps segment.
    /// </summary>
    [IsoId("_9ugiVcEOEea7jLfvGi1PDw")]
    [Description(@"Provides the reason why no activity is reported or the required list of transactions for the foreign exchange swaps segment.")]
    [DataMember(Name="FXSwpsRpt")]
    [XmlElement(ElementName="FXSwpsRpt")]
    [Required]
    public required IForeignExchangeSwap3Choice ForeignExchangeSwapsReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9ugiV8EOEea7jLfvGi1PDw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MoneyMarketForeignExchangeSwapsStatisticalReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MoneyMarketForeignExchangeSwapsStatisticalReportV02Document ToDocument()
    {
        return new MoneyMarketForeignExchangeSwapsStatisticalReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MoneyMarketForeignExchangeSwapsStatisticalReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MoneyMarketForeignExchangeSwapsStatisticalReportV02Document : IOuterDocument<MoneyMarketForeignExchangeSwapsStatisticalReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.014.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MoneyMarketForeignExchangeSwapsStatisticalReportV02"/> is required.
    /// </summary>
    public required MoneyMarketForeignExchangeSwapsStatisticalReportV02 Message { get; init; }
}
