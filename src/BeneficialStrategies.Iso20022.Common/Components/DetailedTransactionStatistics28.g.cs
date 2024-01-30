﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics28.  ISO2002 ID# _x4xX8VyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about reported derivatives and reported derivatives with outliers.
/// </summary>
public partial record DetailedTransactionStatistics28
{
    #nullable enable
    
    /// <summary>
    /// Number of reported derivatives.
    /// </summary>
    public required IsoNumber NumberOfDerivativesReported { get; init; } 
    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
    /// <summary>
    /// Details of abnormal values.
    /// </summary>
    public AbnormalValuesData4? Warnings { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
