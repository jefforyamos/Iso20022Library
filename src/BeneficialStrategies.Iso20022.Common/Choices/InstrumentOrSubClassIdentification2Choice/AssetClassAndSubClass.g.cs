﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AssetClassAndSubClass.  ISO2002 ID# _BSnWY6aUEeqZmriXpMtonA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentOrSubClassIdentification2Choice;

/// <summary>
/// Identifies the asset class and sub-class of non-equity instruments to which the result relates
/// </summary>
public partial record AssetClassAndSubClass : IInstrumentOrSubClassIdentification2Choice
{
    #nullable enable
    /// <summary>
    /// Asset class of non-equity instruments to which the result relates
    /// </summary>
    public required NonEquityAssetClass1Code AssetClass { get; init; } 
    /// <summary>
    /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
    /// </summary>
    public NonEquitySubClass1? DerivativeSubClass { get; init; } 
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    #nullable disable
}
