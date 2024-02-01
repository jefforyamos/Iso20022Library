﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialRequestContentComponent2.  ISO2002 ID# _V15BwU3kEey_VecAUE-C9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial request.
/// </summary>
public partial record NonFinancialRequestContentComponent2
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acceptor wants to be processed.
    /// </summary>
    public NonFinancialRequestType1Code[] NonFinancialRequestType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public CardPaymentTransaction119? Transaction { get; init; } 
    
    #nullable disable
}
