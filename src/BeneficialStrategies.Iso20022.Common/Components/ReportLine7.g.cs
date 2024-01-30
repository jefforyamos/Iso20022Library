﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportLine7.  ISO2002 ID# _bnGykRrYEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a purchase order.
/// </summary>
public partial record ReportLine7
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    public Adjustment6? Adjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    public required IsoCurrencyAndAmount NetAmount { get; init; } 
    
    #nullable disable
}
