﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPMemberObligationsReportV01.  ISO2002 ID# _YdmhceUUEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPInvestmentsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty invests the cash balances deposited with it as collateral by its clearing members. Details the source and size of the liquidity requirements CCPs are placing on clearing members as a result of their membership of the CCP.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPInvestmentsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty invests the cash balances deposited with it as collateral by its clearing members. Details the source and size of the liquidity requirements CCPs are placing on clearing members as a result of their membership of the CCP.")]
public partial record CCPMemberObligationsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPMmbOblgtnsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPMemberObligationsReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPMemberObligationsReportV01Document ToDocument()
    {
        return new CCPMemberObligationsReportV01Document { Message = this };
    }
}

/// <summary>
/// The CCPInvestmentsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty invests the cash balances deposited with it as collateral by its clearing members. Details the source and size of the liquidity requirements CCPs are placing on clearing members as a result of their membership of the CCP.
/// This is the outer document that contains <seealso cref="CCPMemberObligationsReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPMemberObligationsReportV01Document : IOuterDocument<CCPMemberObligationsReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.056.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPMemberObligationsReportV01"/> is required.
    /// </summary>
    public required CCPMemberObligationsReportV01 Message { get; init; }
}
