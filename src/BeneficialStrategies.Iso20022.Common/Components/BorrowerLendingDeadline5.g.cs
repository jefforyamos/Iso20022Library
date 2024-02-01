﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BorrowerLendingDeadline5.  ISO2002 ID# _a5bfp7XDEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
public partial record BorrowerLendingDeadline5
{
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event for which the underlying security is out on loan.
    /// </summary>
    public required DateFormat43Choice_ StockLendingDeadline { get; init; } 
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    public required PartyIdentification127Choice_ Borrower { get; init; } 
    
    #nullable disable
}
