﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesIndexReport1.  ISO2002 ID# _00E_kL3kEeWvRsMSLyTf-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the securities index request operations for national competent authorities.
/// </summary>
public partial record SecuritiesIndexReport1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and feedback messages.
    /// Usage:
    /// This identification will be used in the status advice sent back.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Country code of the entity that wishes to express an interest in receiving transaction reports for the requested indexes.
    /// </summary>
    public CountryCode? RequestingEntity { get; init; } 
    /// <summary>
    /// Details the index that is being requested.
    /// </summary>
    public required FinancialInstrument46Choice_ Index { get; init; } 
    /// <summary>
    /// Date when the national competent authority last expressed its interest in this index.
    /// </summary>
    public Period4Choice_? ValidityPeriod { get; init; } 
    
    #nullable disable
}
