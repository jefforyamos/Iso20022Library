﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Receipt2.  ISO2002 ID# _SoDHcZIdEeect698_YsnIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
public partial record Receipt2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction identification, when the request for which the receipt is generated is a payment transaction.
    /// </summary>
    public IPaymentIdentification5Choice? OriginalPaymentIdentification { get; init; } 
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    public RequestHandling1? RequestHandling { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
