﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MoneyMarketStatisticalReportStatusAdviceV01.  ISO2002 ID# _1P-hEaieEeWHO_l3hf2rlA.
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
/// This record is an implementation of the auth.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.")]
public partial record MoneyMarketStatisticalReportStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.028.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktSttstclRptStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Provides the status on the global report.
    /// </summary>
    [IsoId("_1P-hE6ieEeWHO_l3hf2rlA")]
    [Description(@"Provides the status on the global report.")]
    [DataMember(Name="StsRptHdr")]
    [XmlElement(ElementName="StsRptHdr")]
    [Required]
    public required MoneyMarketStatusReportHeader1 StatusReportHeader { get; init; }
    
    /// <summary>
    /// Provides the status on an individual transaction and the related reason if required.
    /// </summary>
    [IsoId("_1P-hFaieEeWHO_l3hf2rlA")]
    [Description(@"Provides the status on an individual transaction and the related reason if required.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    public MoneyMarketTransactionStatus2? TransactionStatus { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1P-hF6ieEeWHO_l3hf2rlA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MoneyMarketStatisticalReportStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MoneyMarketStatisticalReportStatusAdviceV01Document ToDocument()
    {
        return new MoneyMarketStatisticalReportStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MoneyMarketStatisticalReportStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MoneyMarketStatisticalReportStatusAdviceV01Document : IOuterDocument<MoneyMarketStatisticalReportStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.028.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MoneyMarketStatisticalReportStatusAdviceV01"/> is required.
    /// </summary>
    public required MoneyMarketStatisticalReportStatusAdviceV01 Message { get; init; }
}
