﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferIn11.  ISO2002 ID# _teY88S7_EeO59oUFO5eLvw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
public partial record TransferIn11
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer21? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
