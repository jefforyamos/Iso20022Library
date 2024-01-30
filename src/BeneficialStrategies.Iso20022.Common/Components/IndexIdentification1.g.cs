﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndexIdentification1.  ISO2002 ID# _bs7zADN1Ee2gE4h-lpiUxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements for the identification of an index. ISIN is the preferred format.
/// </summary>
public partial record IndexIdentification1
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    /// <summary>
    /// Proprietary identification of the index on which the financial instrument is based.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Index name where the underlying is an index.
    /// </summary>
    public ExternalBenchmarkCurveName1Code? Index { get; init; } 
    
    #nullable disable
}
