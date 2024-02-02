﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification21.  ISO2002 ID# _VygD6ZqLEeWcAIE4lEkF_Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[DataContract]
[XmlType]
public partial record SecurityIdentification21
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [DataMember]
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [DataMember]
    public ValueList<OtherIdentification2> OtherIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax140Text? Description { get; init; } 
    
    #nullable disable
}
