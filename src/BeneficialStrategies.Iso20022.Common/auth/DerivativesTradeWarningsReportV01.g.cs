﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeWarningsReportV01.  ISO2002 ID# _pVW9r2mFEe2DRvVJM2Qy-g.
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
/// This record is an implementation of the auth.106.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeWarningsReport is sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeWarningsReport is sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.")]
public partial record DerivativesTradeWarningsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.106.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradWrnngsRpt";
    
    #nullable enable
    /// <summary>
    /// Detailed information on missing valuations of outstanding derivatives, missing margin information of outstanding derivatives, as well as on abnormal values reported in the fields.
    /// </summary>
    [IsoId("_pVW9sWmFEe2DRvVJM2Qy-g")]
    [Description(@"Detailed information on missing valuations of outstanding derivatives, missing margin information of outstanding derivatives, as well as on abnormal values reported in the fields.")]
    [DataMember(Name="WrnngsSttstcs")]
    [XmlElement(ElementName="WrnngsSttstcs")]
    [Required]
    public required IStatisticsPerCounterparty16Choice WarningsStatistics { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVW9s2mFEe2DRvVJM2Qy-g")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeWarningsReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeWarningsReportV01Document ToDocument()
    {
        return new DerivativesTradeWarningsReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeWarningsReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeWarningsReportV01Document : IOuterDocument<DerivativesTradeWarningsReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.106.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeWarningsReportV01"/> is required.
    /// </summary>
    public required DerivativesTradeWarningsReportV01 Message { get; init; }
}
