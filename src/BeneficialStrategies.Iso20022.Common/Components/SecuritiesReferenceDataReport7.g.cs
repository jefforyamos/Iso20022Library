﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesReferenceDataReport7.  ISO2002 ID# _ENzaIUmXEeqmSrLQiFB8FA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the securities reference data for the required financial instruments.
/// </summary>
public partial record SecuritiesReferenceDataReport7
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
