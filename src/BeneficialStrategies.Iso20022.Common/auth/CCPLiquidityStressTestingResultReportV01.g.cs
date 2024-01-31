﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPLiquidityStressTestingResultReportV01.  ISO2002 ID# _FO6mYeUREem3X-64-NKdqg.
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
/// This record is an implementation of the auth.063.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPLiquidityStressTestingResultReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the results of the liquidity stress tests.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPLiquidityStressTestingResultReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the results of the liquidity stress tests.")]
public partial record CCPLiquidityStressTestingResultReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.063.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPLqdtyStrssTstgRsltRpt";
    
    #nullable enable
    /// <summary>
    /// Results from a scenario used to stress the liquidity needs of the CCP.
    /// </summary>
    [IsoId("_FO6maeUREem3X-64-NKdqg")]
    [Description(@"Results from a scenario used to stress the liquidity needs of the CCP.")]
    [DataMember(Name="LqdtyStrssTstRslt")]
    [XmlElement(ElementName="LqdtyStrssTstRslt")]
    [Required]
    public required LiquidityStressTestResult1 LiquidityStressTestResult { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_FO6ma-UREem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPLiquidityStressTestingResultReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPLiquidityStressTestingResultReportV01Document ToDocument()
    {
        return new CCPLiquidityStressTestingResultReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPLiquidityStressTestingResultReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPLiquidityStressTestingResultReportV01Document : IOuterDocument<CCPLiquidityStressTestingResultReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.063.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPLiquidityStressTestingResultReportV01"/> is required.
    /// </summary>
    public required CCPLiquidityStressTestingResultReportV01 Message { get; init; }
}
