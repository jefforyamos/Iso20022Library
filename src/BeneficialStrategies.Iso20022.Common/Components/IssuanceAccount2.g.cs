﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IssuanceAccount2.  ISO2002 ID# _mzWcD-FgEeWIA4E9cYSxxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the account to or from which a securities entry is made and the usage type.
/// </summary>
[DataContract]
[XmlType]
public partial record IssuanceAccount2
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [DataMember]
    public required SecuritiesAccount19 IssuanceAccount { get; init; } 
    /// <summary>
    /// Defines if the related issuance account is the primary account or not.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator PrimaryAccountIndicator { get; init; } 
    
    #nullable disable
}
