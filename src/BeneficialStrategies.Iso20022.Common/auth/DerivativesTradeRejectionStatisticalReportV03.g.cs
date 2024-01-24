﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeRejectionStatisticalReportV03.  ISO2002 ID# _pVVvj2mFEe2DRvVJM2Qy-g.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The DerivativesTradeRejectionStatisticalReport message is sent by the trade repository (TR) to the report submitting entity, identifying the transactions rejected and the reasons for a rejection.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeRejectionStatisticalReport message is sent by the trade repository (TR) to the report submitting entity, identifying the transactions rejected and the reasons for a rejection.")]
public partial record DerivativesTradeRejectionStatisticalReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRjctnSttstclRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeRejectionStatisticalReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeRejectionStatisticalReportV03Document ToDocument()
    {
        return new DerivativesTradeRejectionStatisticalReportV03Document { Message = this };
    }
}

/// <summary>
/// The DerivativesTradeRejectionStatisticalReport message is sent by the trade repository (TR) to the report submitting entity, identifying the transactions rejected and the reasons for a rejection.
/// This is the outer document that contains <seealso cref="DerivativesTradeRejectionStatisticalReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeRejectionStatisticalReportV03Document : IOuterDocument<DerivativesTradeRejectionStatisticalReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.092.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeRejectionStatisticalReportV03"/> is required.
    /// </summary>
    public required DerivativesTradeRejectionStatisticalReportV03 Message { get; init; }
}
