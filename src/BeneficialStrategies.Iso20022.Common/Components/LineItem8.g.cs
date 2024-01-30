﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItem8.  ISO2002 ID# _RaVOCNp-Ed-ak6NoX_4Aeg_1564459654.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the current situation of a baseline as a result of the submission of a commercial data set.
/// </summary>
public partial record LineItem8
{
    #nullable enable
    
    /// <summary>
    /// Calculated information about the goods of the underlying transaction.
    /// </summary>
    public LineItemDetails8? LineItemDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Line items total amount as indicated in the baseline.
    /// </summary>
    public required IsoCurrencyAndAmount OrderedLineItemsTotalAmount { get; init; } 
    /// <summary>
    /// Line items total amount accepted by a data set submission(s).
    /// </summary>
    public required IsoCurrencyAndAmount AcceptedLineItemsTotalAmount { get; init; } 
    /// <summary>
    /// Difference between the ordered and the accepted line items total amount.
    /// </summary>
    public required IsoCurrencyAndAmount OutstandingLineItemsTotalAmount { get; init; } 
    /// <summary>
    /// Line item total amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    public required IsoCurrencyAndAmount PendingLineItemsTotalAmount { get; init; } 
    /// <summary>
    /// Total net amount as indicated in the baseline.
    /// </summary>
    public required IsoCurrencyAndAmount OrderedTotalNetAmount { get; init; } 
    /// <summary>
    /// Total net amount accepted by a data set submission.
    /// </summary>
    public required IsoCurrencyAndAmount AcceptedTotalNetAmount { get; init; } 
    /// <summary>
    /// Total net amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    public required IsoCurrencyAndAmount OutstandingTotalNetAmount { get; init; } 
    /// <summary>
    /// Difference between the ordered and the accepted total net amount.
    /// </summary>
    public required IsoCurrencyAndAmount PendingTotalNetAmount { get; init; } 
    
    #nullable disable
}
