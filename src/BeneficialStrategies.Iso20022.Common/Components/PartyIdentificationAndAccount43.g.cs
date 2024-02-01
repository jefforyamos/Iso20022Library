﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount43.  ISO2002 ID# _eaw-ZeaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount43
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification43Choice_ Identification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    #nullable disable
}
