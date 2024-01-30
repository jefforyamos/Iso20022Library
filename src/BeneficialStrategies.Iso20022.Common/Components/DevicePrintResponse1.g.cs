﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DevicePrintResponse1.  ISO2002 ID# _Ty4bQN7HEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Print Response message.
/// </summary>
public partial record DevicePrintResponse1
{
    #nullable enable
    
    /// <summary>
    /// Qualification of the document printed to the Cashier or the Customer.
    /// </summary>
    public required DocumentType7Code DocumentQualifier { get; init; } 
    
    #nullable disable
}
