﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amendment8.  ISO2002 ID# _9_mScXltEeG7BsjMvd1mEw_288000024.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment identification.
/// </summary>
public partial record Amendment8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Sequence number assigned by the issuer to each amendment of the undertaking.
    /// </summary>
    public required IsoMax4AlphaNumericText SequenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the beneficiary to the undertaking.
    /// </summary>
    public IsoMax35Text? BeneficiaryReferenceNumber { get; init; } 
    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    public required PartyIdentification43 Issuer { get; init; } 
    
    #nullable disable
}
