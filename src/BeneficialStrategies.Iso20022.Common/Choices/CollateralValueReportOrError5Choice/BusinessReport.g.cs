﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _-DiXcTpvEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError5Choice;

/// <summary>
/// Provides information specific to the collateral value reports included in the message.
/// </summary>
public partial record BusinessReport : CollateralValueReportOrError5Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account on which information is requested.
    /// </summary>
    public required CashAccount38 CashAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public SystemPartyIdentification11? CashAccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    public PartyIdentification136? SecuritiesAccountServicer { get; init; } 
    /// <summary>
    /// Provides information specific to the report on collateral value positions.
    /// </summary>
    public CollateralValueReportOrError6Choice_? CollateralValueReport { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
