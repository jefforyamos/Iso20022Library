﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewRecord.  ISO2002 ID# _o1S5g6WvEeqZmriXpMtonA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport5Choice;

/// <summary>
/// Specifies new instruments that have been added since the previous report.
/// </summary>
public partial record NewRecord : ISecuritiesReferenceDeltaStatusReport5Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
    /// <summary>
    /// LEI of Issuer or trading venue operator.
    /// </summary>
    public required IsoLEIIdentifier Issuer { get; init; } 
    /// <summary>
    /// Traded venue related attributes.
    /// </summary>
    public TradingVenueAttributes1? TradingVenueRelatedAttributes { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
    /// <summary>
    /// Technical attributes.
    /// </summary>
    public RecordTechnicalData4? TechnicalAttributes { get; init; } 
    #nullable disable
}
