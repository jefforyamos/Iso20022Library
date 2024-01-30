﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractDocument1.  ISO2002 ID# _UkjHQtp-Ed-ak6NoX_4Aeg_15886237.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that contains the information of the contract agreed between both parties.
/// </summary>
public partial record ContractDocument1
{
    #nullable enable
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Signoff date of the document.
    /// </summary>
    public IsoISODate? SignOffDate { get; init; } 
    /// <summary>
    /// Identification of the version of the contract.
    /// </summary>
    public IsoMax6Text? Version { get; init; } 
    
    #nullable disable
}
