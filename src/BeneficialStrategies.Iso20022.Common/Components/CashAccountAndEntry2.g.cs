﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccountAndEntry2.  ISO2002 ID# _HGFBcZliEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
public partial record CashAccountAndEntry2
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public required CashAccount36 Account { get; init; } 
    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    public CashEntry2? Entry { get; init; } 
    
    #nullable disable
}
