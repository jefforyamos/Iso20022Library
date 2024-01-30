﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericDocumentIdentification1.  ISO2002 ID# _QtVlJNp-Ed-ak6NoX_4Aeg_2133317488.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Generic identification scheme for a document.
/// </summary>
public partial record GenericDocumentIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public IDocumentNumber1Choice? MessageNumber { get; init; } 
    /// <summary>
    /// Identification of the document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    
    #nullable disable
}
