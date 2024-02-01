﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ParticipantInformation1.  ISO2002 ID# _5On4EB9nEeapDZRA0Hb6ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Participant profile participant information.
/// </summary>
public partial record ParticipantInformation1
{
    #nullable enable
    
    /// <summary>
    /// Date the profile was deleted.
    /// </summary>
    public IsoISODateTime? ProfileDeletionDate { get; init; } 
    /// <summary>
    /// National BIC identifiers for authorised and central branches.
    /// </summary>
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; init; } 
    /// <summary>
    /// CBRF identification of the terminal.
    /// </summary>
    public IsoMax35Text? TerminalIdentification { get; init; } 
    /// <summary>
    /// Intraday restrictions details.
    /// </summary>
    public IsoMax35Text[] Restrictions { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// External payment system details.
    /// </summary>
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; init; } 
    /// <summary>
    /// Information related for participant migration process.
    /// </summary>
    public required SystemMigration1 Migration { get; init; } 
    
    #nullable disable
}
