﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Incoterms1.  ISO2002 ID# _Sr_qMtp-Ed-ak6NoX_4Aeg_-645465697.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the applicable Incoterm and associated location.
/// </summary>
public partial record Incoterms1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the applicable Incoterm by means of a code.
    /// </summary>
    public required Incoterms1Code Code { get; init; } 
    /// <summary>
    /// Specifies Incoterm not present in code list.
    /// </summary>
    public required IsoMax35Text Other { get; init; } 
    /// <summary>
    /// Location where the Incoterms are actioned.
    /// </summary>
    public IsoMax35Text? Location { get; init; } 
    
    #nullable disable
}
