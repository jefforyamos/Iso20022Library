﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyTextInformation2.  ISO2002 ID# _PYi8ftp-Ed-ak6NoX_4Aeg_1769478257.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
public partial record PartyTextInformation2
{
    #nullable enable
    
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    public IsoMax350Text? DeclarationDetails { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax140Text? PartyContactDetails { get; init; } 
    
    #nullable disable
}
