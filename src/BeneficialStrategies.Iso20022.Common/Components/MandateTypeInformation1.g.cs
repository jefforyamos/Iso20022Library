﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateTypeInformation1.  ISO2002 ID# _TFxcONp-Ed-ak6NoX_4Aeg_1015976937.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
public partial record MandateTypeInformation1
{
    #nullable enable
    
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    
    #nullable disable
}
