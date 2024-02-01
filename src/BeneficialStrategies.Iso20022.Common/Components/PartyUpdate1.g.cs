﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyUpdate1.  ISO2002 ID# _oZdVsPH1Eeaz_YGUGLjP6A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of the party, which are / are being updated.
/// </summary>
public partial record PartyUpdate1
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
    public StatusDetail1[] Status { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    public Period4Choice_? TechnicalValidityPeriod { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
