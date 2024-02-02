﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesReferenceDataReport6.  ISO2002 ID# _K5JXMSX7EeigZbhgJcrASA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the securities reference data for the required financial instruments.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesReferenceDataReport6
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    [DataMember]
    public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
    /// <summary>
    /// LEI of Issuer or trading venue operator.
    /// </summary>
    [DataMember]
    public required IsoLEIIdentifier Issuer { get; init; } 
    /// <summary>
    /// Traded venue related attributes.
    /// </summary>
    [DataMember]
    public ValueList<TradingVenueAttributes1> TradingVenueRelatedAttributes { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    [DataMember]
    public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    [DataMember]
    public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
    /// <summary>
    /// Technical attributes.
    /// </summary>
    [DataMember]
    public RecordTechnicalData4? TechnicalAttributes { get; init; } 
    
    #nullable disable
}
