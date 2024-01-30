﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Error.  ISO2002 ID# _oZRTX3g-Eeu3kecHd7QKUQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport15Choice;

/// <summary>
/// Indicates a cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to reporting requirements but was reported to a trade repository by mistake.
/// </summary>
public partial record Error : ITradeReport15Choice
{
    #nullable enable
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    // public IReadOnlyCollection<CounterpartySpecificData29> CounterpartySpecificData { get; init; }
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public required CommonTradeDataReport49 CommonTradeData { get; init; } 
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// Usage: The absence of the code will imply the default value Transaction (TCTN).
    /// </summary>
    public ModificationLevel1Code? Level { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes4? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
