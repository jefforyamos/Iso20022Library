﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionLifeCycleIdentification2.  ISO2002 ID# _LoxEIMWaEeiCfKAZkk6ZAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique global identification structure used to match transactions throughout their lifecycle (for example, authorisation to financial, financial to chargebacks, etc.). 
/// It shall contain the same value in all messages throughout a transaction's lifecycle.
/// ISO 8583:2003 bit 21
/// </summary>
public partial record TransactionLifeCycleIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier.
    /// ISO 8583:2003 bit 21-2
    /// </summary>
    public required IsoExact15Text Identification { get; init; } 
    
    #nullable disable
}
