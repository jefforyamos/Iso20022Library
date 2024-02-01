﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _BO3n864UEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData11Choice;

/// <summary>
/// Information concerning the reporting at transaction level.
/// </summary>
public partial record Report : TradeData11Choice_
{
    #nullable enable
    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    public DetailedReportStatistics5? ReportStatistics { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about accepted and rejected transactions and the reasons of rejection.
    /// </summary>
    public DetailedTransactionStatistics10? TransactionStatistics { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
