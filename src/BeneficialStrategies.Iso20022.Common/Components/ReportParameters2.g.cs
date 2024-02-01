﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportParameters2.  ISO2002 ID# _QlcNadp-Ed-ak6NoX_4Aeg_1490476160.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the parameters of the report.
/// </summary>
public partial record ReportParameters2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    public required IsoMax35Text ReportIdentification { get; init; } 
    /// <summary>
    /// Date (and time) at which the report was created.
    /// </summary>
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    public required EventFrequency6Code Frequency { get; init; } 
    /// <summary>
    /// Indicates the currency used for the calculation of the guarantee fund.
    /// </summary>
    public required CurrencyCode ReportCurrency { get; init; } 
    /// <summary>
    /// Indicates the date of calculation of the deficit (if any).
    /// </summary>
    public IsoISODateTime? CalculationDate { get; init; } 
    
    #nullable disable
}
