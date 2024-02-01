﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedQuantityFormat14.  ISO2002 ID# _S6IhwzRTEe2id-MjcNoBdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of a security for various quantity formats.
/// </summary>
public partial record SignedQuantityFormat14
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of securities.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of securities.
    /// </summary>
    public required FinancialInstrumentQuantity45Choice_ Quantity { get; init; } 
    
    #nullable disable
}
