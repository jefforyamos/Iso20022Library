﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification30.  ISO2002 ID# _puErAEVnEeS9ytE0W9bgkQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a data source scheme.
/// </summary>
public partial record AccountIdentification30
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of account.
    /// </summary>
    public required AccountInformationType1Code AccountType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification26 Identification { get; init; } 
    
    #nullable disable
}
