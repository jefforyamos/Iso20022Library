﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference20.  ISO2002 ID# _Qkr_cNp-Ed-ak6NoX_4Aeg_2036685643.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the updated interest request such the original InterestRequest identification, and optionaly the InterestResponse identification.
/// </summary>
public partial record Reference20
{
    #nullable enable
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    public required IsoMax35Text InterestPaymentRequestIdentification { get; init; } 
    /// <summary>
    /// Provides the reference to the interest payment response.
    /// </summary>
    public IsoMax35Text? InterestPaymentResponseIdentification { get; init; } 
    
    #nullable disable
}
