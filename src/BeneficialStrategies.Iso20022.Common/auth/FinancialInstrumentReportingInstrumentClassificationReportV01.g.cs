﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingInstrumentClassificationReportV01.  ISO2002 ID# _4LK8VURNEee7JdgA9zPESA.
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
/// This record is an implementation of the auth.050.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingInstrumentClassificationReport message is sent by ESMA to all national competent authorities and provides all valid combinations for classification of financial instruments (CFI) as per ISO 10962.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingInstrumentClassificationReport message is sent by ESMA to all national competent authorities and provides all valid combinations for classification of financial instruments (CFI) as per ISO 10962.")]
public partial record FinancialInstrumentReportingInstrumentClassificationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.050.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgInstrmClssfctnRpt";
    
    #nullable enable
    /// <summary>
    /// Report detailing all classification for financial instruments (CFI) code.
    /// </summary>
    [IsoId("_4LK8V0RNEee7JdgA9zPESA")]
    [Description(@"Report detailing all classification for financial instruments (CFI) code.")]
    [DataMember(Name="InstrmClssfctn")]
    [XmlElement(ElementName="InstrmClssfctn")]
    [Required]
    public required SecuritiesInstrumentClassification2 InstrumentClassification { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8WURNEee7JdgA9zPESA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingInstrumentClassificationReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingInstrumentClassificationReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingInstrumentClassificationReportV01Document : IOuterDocument<FinancialInstrumentReportingInstrumentClassificationReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.050.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingInstrumentClassificationReportV01 Message { get; init; }
}
