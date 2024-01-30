﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsDailyInstructionType3.  ISO2002 ID# _MSd6hTOmEeqX8uoQQ3KffQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails split per instruction types.
/// </summary>
public partial record SettlementFailsDailyInstructionType3
{
    #nullable enable
    
    /// <summary>
    /// Fails due to delivery versus payment (DVP) settlement transactions, covers both delivery versus payment and receive versus payment transactions. 
    /// </summary>
    public required ISettlementDailyFailureReason1Choice DeliveryVersusPayment { get; init; } 
    /// <summary>
    /// Fails due to delivery with payment (DWP) settlement transactions, covers both delivery with payment (DWP) and receive with payment (RWP) transactions. 
    /// </summary>
    public required ISettlementDailyFailureReason1Choice DeliveryWithPayment { get; init; } 
    /// <summary>
    /// Fails due to payment free of delivery (PFOD) settlement transactions, covers both debit payment free of delivery (DPFOD) and credit payment free of delivery (CPFOD) transactions.
    /// </summary>
    public required ISettlementDailyFailureReason1Choice PaymentFreeOfDelivery { get; init; } 
    /// <summary>
    /// Fails due to free of payment (FoP) settlement transactions, covers both deliver free of payment (DFoP) and receive free of payment (RFoP) transactions.
    /// </summary>
    public required ISettlementDailyFailureReason1Choice FreeOfPayment { get; init; } 
    
    #nullable disable
}
