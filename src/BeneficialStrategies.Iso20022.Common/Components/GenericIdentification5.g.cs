﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification5.  ISO2002 ID# _P_b9Wdp-Ed-ak6NoX_4Aeg_652282211.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information expressed in a proprietary manner.
/// </summary>
[DataContract]
[XmlType]
public partial record GenericIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [DataMember]
    public required IsoMax8Text Issuer { get; init; } 
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [DataMember]
    public required IsoExact4AlphaNumericText Information { get; init; } 
    /// <summary>
    /// Additional information.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Narrative { get; init; } 
    
    #nullable disable
}
