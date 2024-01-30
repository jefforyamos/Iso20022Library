﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementResolutionEntry2.  ISO2002 ID# _ttIGwFkyEeGeoaLUQk__nA_2058261380.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the statement entry for the resolution of the investigation.
/// </summary>
public partial record StatementResolutionEntry2
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 
    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    public Charges3? Charges { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    
    #nullable disable
}
