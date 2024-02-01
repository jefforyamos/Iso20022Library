﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwapLegIdentification3.  ISO2002 ID# _2EZuFZ3DEeuwmdq0KtnICg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the legs of swap transaction.
/// </summary>
public partial record SwapLegIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Instrument received by the buyer.
    /// </summary>
    public FinancialInstrumentIdentification8Choice_? SwapIn { get; init; } 
    /// <summary>
    /// Instrument paid by the buyer.
    /// </summary>
    public FinancialInstrumentIdentification8Choice_? SwapOut { get; init; } 
    
    #nullable disable
}
