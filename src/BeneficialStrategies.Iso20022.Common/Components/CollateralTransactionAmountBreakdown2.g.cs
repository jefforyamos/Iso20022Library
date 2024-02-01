﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralTransactionAmountBreakdown2.  ISO2002 ID# _kK-5sRIoEeyZaPkaPAzTvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a market value.
/// </summary>
public partial record CollateralTransactionAmountBreakdown2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying transaction (exposure split).
    /// </summary>
    public required GenericIdentification178 LotNumber { get; init; } 
    /// <summary>
    /// Split amount of the aggregate transaction amount (exposure).
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    /// <summary>
    /// Period that applies to the aggregate transation amount (exposure).
    /// </summary>
    public Period4Choice_? Period { get; init; } 
    
    #nullable disable
}
