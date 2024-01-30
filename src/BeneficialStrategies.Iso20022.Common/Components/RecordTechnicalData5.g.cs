﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecordTechnicalData5.  ISO2002 ID# _XjVHpZ26Eeuwmdq0KtnICg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
public partial record RecordTechnicalData5
{
    #nullable enable
    
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    public required IsoISODateTime ReceiptDateTime { get; init; } 
    /// <summary>
    /// Describes the reason for the exchange of the transaction report between the competent authorities.
    /// </summary>
    public ExternalAuthorityExchangeReason1Code? ExchangeReason { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
