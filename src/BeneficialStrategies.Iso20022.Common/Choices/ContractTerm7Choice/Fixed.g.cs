﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Fixed.  ISO2002 ID# _xsKXY65qEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractTerm7Choice;

/// <summary>
/// Transaction is  fixed term with a contractually agreed maturity date.
/// </summary>
public partial record Fixed : IContractTerm7Choice
{
    #nullable enable
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
    /// </summary>
    public RepoTerminationOption2Code? TerminationOption { get; init; } 
    #nullable disable
}
