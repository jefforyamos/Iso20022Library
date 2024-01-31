﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeRejectionStatisticalReportV01.  ISO2002 ID# _wdKwPRWsEeqvRcdYcNYAVw.
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
/// The DerivativesTradeRejectionStatisticalReport message is sent by the the trade repositories to the supervisory authority system, to report statistical information on derivatives submissions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeRejectionStatisticalReport message is sent by the the trade repositories to the supervisory authority system, to report statistical information on derivatives submissions.")]
public partial record DerivativesTradeRejectionStatisticalReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRjctnSttstclRpt";
    
    #nullable enable
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_wdKwPxWsEeqvRcdYcNYAVw")]
    [Description(@"Detailed information on statistics per combination of counterparties.")]
    [DataMember(Name="SttstcsPerCtrPty")]
    [XmlElement(ElementName="SttstcsPerCtrPty")]
    [Required]
    public required IStatisticsPerCounterparty2Choice StatisticsPerCounterparty { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_wdKwQRWsEeqvRcdYcNYAVw")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeRejectionStatisticalReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeRejectionStatisticalReportV01Document ToDocument()
    {
        return new DerivativesTradeRejectionStatisticalReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeRejectionStatisticalReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeRejectionStatisticalReportV01Document : IOuterDocument<DerivativesTradeRejectionStatisticalReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.092.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeRejectionStatisticalReportV01"/> is required.
    /// </summary>
    public required DerivativesTradeRejectionStatisticalReportV01 Message { get; init; }
}
