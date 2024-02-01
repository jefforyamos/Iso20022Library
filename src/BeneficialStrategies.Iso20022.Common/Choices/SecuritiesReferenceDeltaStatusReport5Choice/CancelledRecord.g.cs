﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancelledRecord.  ISO2002 ID# _o1S5h6WvEeqZmriXpMtonA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport5Choice;

/// <summary>
/// Specifies data that has been cancelled since the previous report.
/// </summary>
public partial record CancelledRecord : SecuritiesReferenceDeltaStatusReport5Choice_
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
    public required SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; init; } 
    /// <summary>
    /// LEI of Issuer or trading venue operator.
    /// </summary>
    public IsoLEIIdentifier? Issuer { get; init; } 
    /// <summary>
    /// Traded venue related attributes.
    /// </summary>
    public TradingVenueAttributes2? TradingVenueRelatedAttributes { get; init;  } // Warning: Don't know multiplicity.
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
