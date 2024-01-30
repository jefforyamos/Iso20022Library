﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for New.  ISO2002 ID# __fyLYWEUEe2P-L9DBerEgA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport32Choice;

/// <summary>
/// Indicates whether transaction is reported for the first time.
/// </summary>
public partial record New : ITradeReport32Choice
{
    #nullable enable
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    // public IReadOnlyCollection<CounterpartySpecificData36> CounterpartySpecificData { get; init; }
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public required CommonTradeDataReport69 CommonTradeData { get; init; } 
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// Usage: The absence of the code will imply the default value Transaction (TCTN).
    /// </summary>
    public ModificationLevel1Code? Level { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes5? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Information regarding the public dissemination of trade data.
    /// </summary>
    public DisseminationData1? PublicDisseminationData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
