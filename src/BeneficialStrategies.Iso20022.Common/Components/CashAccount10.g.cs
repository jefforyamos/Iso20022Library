﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount10.  ISO2002 ID# _WHVvu9p-Ed-ak6NoX_4Aeg_128393551.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
public partial record CashAccount10
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    public required IAccountIdentification3Choice Identification { get; init; } 
    
    #nullable disable
}
