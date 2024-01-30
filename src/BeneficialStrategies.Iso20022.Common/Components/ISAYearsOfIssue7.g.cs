﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISAYearsOfIssue7.  ISO2002 ID# _1AA5BbNBEeewUI7-Tnew9A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which an ISA plan is issued.
/// </summary>
public partial record ISAYearsOfIssue7
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    public ICurrentYearType2Choice? CurrentYear { get; init; } 
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    public IPreviousYear2Choice? PreviousYears { get; init; } 
    
    #nullable disable
}
