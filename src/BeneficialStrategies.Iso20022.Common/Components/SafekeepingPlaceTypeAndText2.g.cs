﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingPlaceTypeAndText2.  ISO2002 ID# _SfVHMNp-Ed-ak6NoX_4Aeg_813979411.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the place of safekeeping expressed as a code and a narrative description.
/// </summary>
[DataContract]
[XmlType]
public partial record SafekeepingPlaceTypeAndText2
{
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [DataMember]
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Identification { get; init; } 
    
    #nullable disable
}
