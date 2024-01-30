﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Update.  ISO2002 ID# _GejBEDbuEeeYhaZ6bvG1Xg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyReport1Choice;

/// <summary>
/// Creation or update of a party.
/// </summary>
public partial record Update : IPartyReport1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public required PartyIdentification136 Identification { get; init; } 
    /// <summary>
    /// Unique identification of the party, as previously defined.
    /// </summary>
    public PartyIdentification136? PreviousIdentification { get; init; } 
    /// <summary>
    /// Any other additional information about the party.
    /// </summary>
    public required PartyDetail1 Other { get; init; } 
    /// <summary>
    /// Information about decision taken by a relevant institution concerning the party.
    /// </summary>
    public StatusDetail1? Status { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    public IPeriod4Choice? TechnicalValidityPeriod { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
