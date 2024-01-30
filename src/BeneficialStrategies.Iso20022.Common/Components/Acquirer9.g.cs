﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Acquirer9.  ISO2002 ID# _h_-kQdkCEeiojJsa6FYyew.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer involved in the card payment.
/// </summary>
public partial record Acquirer9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer (for example the bank identification number BIN).
    /// </summary>
    public required GenericIdentification171 Identification { get; init; } 
    /// <summary>
    /// Version of the payment acquirer parameters of the POI.
    /// </summary>
    public IsoMax256Text? ParametersVersion { get; init; } 
    
    #nullable disable
}
