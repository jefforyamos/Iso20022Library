﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PreviousYear2.  ISO2002 ID# _3gNXVEXfEeGY6MkiuzuPOA_-2106668594.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
/// </summary>
public partial record PreviousYear2
{
    #nullable enable
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    public required PreviousYear1Choice_ PreviousYears { get; init; } 
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    #nullable disable
}
