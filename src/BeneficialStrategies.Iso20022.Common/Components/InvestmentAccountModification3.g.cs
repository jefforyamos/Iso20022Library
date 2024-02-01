﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountModification3.  ISO2002 ID# _viqSgWB1EeaHEJD5P6-ccw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the modification of an account.
/// </summary>
public partial record InvestmentAccountModification3
{
    #nullable enable
    
    /// <summary>
    /// Reason for the modification to the investment account information.
    /// </summary>
    public IsoMax350Text? ModificationReason { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    public AdditionalReference6? CounterpartyReference { get; init; } 
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    public Account23[] ExistingAccountIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
