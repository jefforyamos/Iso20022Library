﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferOut13.  ISO2002 ID# _Xr92oS74EeO59oUFO5eLvw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer out transaction.
/// </summary>
public partial record TransferOut13
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer27? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
