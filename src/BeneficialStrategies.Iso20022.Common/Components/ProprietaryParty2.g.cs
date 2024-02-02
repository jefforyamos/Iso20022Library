﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryParty2.  ISO2002 ID# _Rp-zl9p-Ed-ak6NoX_4Aeg_1074004060.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a proprietary party.
/// </summary>
[DataContract]
[XmlType]
public partial record ProprietaryParty2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary party.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Proprietary party.
    /// </summary>
    [DataMember]
    public required PartyIdentification32 Party { get; init; } 
    
    #nullable disable
}
