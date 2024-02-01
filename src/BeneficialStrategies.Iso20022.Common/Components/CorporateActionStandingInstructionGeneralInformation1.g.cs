﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionStandingInstructionGeneralInformation1.  ISO2002 ID# _UJkbdNp-Ed-ak6NoX_4Aeg_1871445103.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the standing instruction.
/// </summary>
public partial record CorporateActionStandingInstructionGeneralInformation1
{
    #nullable enable
    
    /// <summary>
    /// Type of standing instruction.
    /// </summary>
    public required StandingInstructionType1Code StandingInstructionType { get; init; } 
    /// <summary>
    /// Type of coporpate action event.
    /// </summary>
    public CorporateActionEventType2FormatChoice_[] EventType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the instructing party, ie, the CSD client.
    /// </summary>
    public required PartyIdentification2Choice_ InstructingPartyIdentification { get; init; } 
    /// <summary>
    /// Reference of the standing instruction assigned by the client.
    /// </summary>
    public required IsoMax35Text ClientStandingInstructionIdentification { get; init; } 
    /// <summary>
    /// Provides information about the account to which the standing instruction can apply.
    /// </summary>
    public IncludedAccount1[] AccountDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    public FinancialInstrumentDescription3? UnderlyingSecurity { get; init; } 
    
    #nullable disable
}
