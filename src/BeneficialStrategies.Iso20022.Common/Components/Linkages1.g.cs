﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages1.  ISO2002 ID# _Qr1wV9p-Ed-ak6NoX_4Aeg_-2084291941.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages1
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required References1Choice_ Reference { get; init; } 
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; } 
    
    #nullable disable
}
