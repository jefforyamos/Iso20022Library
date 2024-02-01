﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement59.  ISO2002 ID# _oN8KIV10Eea7JNQ75Q3JCw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
public partial record Statement59
{
    #nullable enable
    
    /// <summary>
    /// Specifies the business role of the message sender and, therefore, the business relationship between the sender and the receiver (or the interests represented by them, in those cases where another entity is acting on behalf of the sender or receiver). The message is exchanged between two entities, one being the account servicer and the other the account owner, and the message can be used with either one as the sender.
    /// </summary>
    public required SenderBusinessRole1Code SenderBusinessRole { get; init; } 
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public Number3Choice_? StatementNumber { get; init; } 
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    public IsoMax35Text? QueryReference { get; init; } 
    /// <summary>
    /// Reference common to all pages of the statement.
    /// </summary>
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Date and time when the statement was created.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Date period for which the statement was created.
    /// </summary>
    public required DatePeriod1Choice_ StatementPeriod { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public Frequency22Choice_? Frequency { get; init; } 
    /// <summary>
    /// Granularity of the frequency used for the reporting.
    /// </summary>
    public FrequencyGranularityType1Code? FrequencyGranularity { get; init; } 
    /// <summary>
    /// Specifies whether the statement is complete or contains changes only.
    /// </summary>
    public UpdateType4Choice_? UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or updated information reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    #nullable disable
}
