﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferReference4.  ISO2002 ID# _SwnEd9p-Ed-ak6NoX_4Aeg_-1173422245.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer of a security on a securities account servicer after the receipt of a securities settlement instruction, or the transfer of cash on an account servicer after the receipt of a payment instruction. The transfer consists of a debit/credit operation in the books of the account servicer.
/// </summary>
public partial record TransferReference4
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    
    #nullable disable
}
