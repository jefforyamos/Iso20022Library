﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Undertaking8.  ISO2002 ID# _-FthiHltEeG7BsjMvd1mEw_-1983093565.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an undertaking.
/// </summary>
[DataContract]
[XmlType]
public partial record Undertaking8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    [DataMember]
    public required PartyIdentification43 Issuer { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ApplicantReferenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the beneficiary to the undertaking.
    /// </summary>
    [DataMember]
    public IsoMax35Text? BeneficiaryReferenceNumber { get; init; } 
    
    #nullable disable
}
