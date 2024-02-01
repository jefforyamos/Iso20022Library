﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClassificationType2.  ISO2002 ID# _58Yc4eLVEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of format for the classification.
/// </summary>
public partial record ClassificationType2
{
    #nullable enable
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    public ExternalFinancialInstrumentProductType1Code? FinancialInstrumentProductTypeCode { get; init; } 
    /// <summary>
    /// Proprietary classification of financial instrument.
    /// </summary>
    public GenericIdentification36[] AlternateClassification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
