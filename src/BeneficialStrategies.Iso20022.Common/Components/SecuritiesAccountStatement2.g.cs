﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccountStatement2.  ISO2002 ID# _QDcSkeGBEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesAccountStatement2
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [DataMember]
    public required IsoISODate SystemDate { get; init; } 
    /// <summary>
    /// Provides information on the actual change occurred to a securities account.
    /// </summary>
    [DataMember]
    public ValueList<SecuritiesAccountReferenceDataChange2> Change { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
