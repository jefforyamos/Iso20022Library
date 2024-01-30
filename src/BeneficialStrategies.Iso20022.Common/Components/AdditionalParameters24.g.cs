﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalParameters24.  ISO2002 ID# _SoVUUTxFEeW5v6FXICU4Ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional parameters to the message or transaction.
/// </summary>
public partial record AdditionalParameters24
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; } 
    
    #nullable disable
}
