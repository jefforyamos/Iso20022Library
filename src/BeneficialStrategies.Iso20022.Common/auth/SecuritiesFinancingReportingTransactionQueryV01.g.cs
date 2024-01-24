﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionQueryV01.  ISO2002 ID# _2zvMFQuAEeqVvtu9Ny8FDA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.")]
public partial record SecuritiesFinancingReportingTransactionQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionQueryV01Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionQueryV01Document { Message = this };
    }
}

/// <summary>
/// The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.
/// This is the outer document that contains <seealso cref="SecuritiesFinancingReportingTransactionQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionQueryV01Document : IOuterDocument<SecuritiesFinancingReportingTransactionQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.094.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionQueryV01"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionQueryV01 Message { get; init; }
}
