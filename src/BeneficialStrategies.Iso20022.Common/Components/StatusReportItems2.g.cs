﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReportItems2.  ISO2002 ID# _Ra7q9tp-Ed-ak6NoX_4Aeg_-898612372.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes a transaction and its status.
/// </summary>
public partial record StatusReportItems2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Entity for which the matching application has generated a report.
    /// </summary>
    // public IReadOnlyCollection<BICIdentification1> ReportedEntity { get; init; }
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    public required BaselineStatus3Code Status { get; init; } 
    /// <summary>
    /// Further description of the transaction status.
    /// </summary>
    public IsoMax140Text? SubStatus { get; init; } 
    
    #nullable disable
}
