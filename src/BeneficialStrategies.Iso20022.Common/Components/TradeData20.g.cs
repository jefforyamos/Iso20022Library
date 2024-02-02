﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeData20.  ISO2002 ID# _R_kY3O3tEemV1LTEADuPBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeData20
{
    #nullable enable
    
    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    [DataMember]
    public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about accepted and rejected transactions and the reasons of rejection.
    /// </summary>
    [DataMember]
    public ValueList<DetailedTransactionStatistics10> TransactionStatistics { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
