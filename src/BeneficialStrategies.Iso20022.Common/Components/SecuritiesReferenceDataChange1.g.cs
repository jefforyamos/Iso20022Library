﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesReferenceDataChange1.  ISO2002 ID# _k2JLo-5NEeCisYr99QEiWA_1566681041.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
public partial record SecuritiesReferenceDataChange1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument for which the changes are listed in the advice.
    /// </summary>
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    public required IsoMax35Text FieldName { get; init; } 
    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    public required IsoMax350Text OldFieldValue { get; init; } 
    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    public required IsoMax350Text NewFieldValue { get; init; } 
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    #nullable disable
}
