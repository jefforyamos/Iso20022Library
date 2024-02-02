﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference17.  ISO2002 ID# _QnOWE9p-Ed-ak6NoX_4Aeg_-1322304897.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record Reference17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral substitution request.
    /// </summary>
    [DataMember]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    /// <summary>
    /// Identification of the collateral substitution response.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CollateralSubstitutionResponseIdentification { get; init; } 
    
    #nullable disable
}
