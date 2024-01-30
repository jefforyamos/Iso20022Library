﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTypeAndIdentification21.  ISO2002 ID# _cfvuM5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall process covering the trade and settlement transactions of financial instruments.
/// </summary>
public partial record SettlementTypeAndIdentification21
{
    #nullable enable
    
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Reference of the transaction.
    /// </summary>
    public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    public IDateAndDateTimeChoice? SettlementDate { get; init; } 
    
    #nullable disable
}
