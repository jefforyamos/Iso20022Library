﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMAccountStatement1.  ISO2002 ID# _1dwnkIq7EeSHjtO_wHA7PQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
public partial record ATMAccountStatement1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    public required IAccountIdentification31Choice AccountIdentifier { get; init; } 
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.
    /// </summary>
    public IsoMax70Text? AccountName { get; init; } 
    /// <summary>
    /// Statement information.
    /// </summary>
    public ATMAccountStatement2? AccountStatement { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
