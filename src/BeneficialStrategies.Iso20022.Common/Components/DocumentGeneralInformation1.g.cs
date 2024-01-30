﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentGeneralInformation1.  ISO2002 ID# _ThV909p-Ed-ak6NoX_4Aeg_568243835.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information that unambiguously identifies a document, such as identification number and issue date time.
/// </summary>
public partial record DocumentGeneralInformation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    public required DocumentType4Code DocumentType { get; init; } 
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    public required IsoMax35Text DocumentNumber { get; init; } 
    /// <summary>
    /// Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    public IsoMax140Text? SenderReceiverSequenceIdentification { get; init; } 
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    public required IsoISODate IssueDate { get; init; } 
    /// <summary>
    /// URL (Uniform Resource Locator) related to the document.
    /// </summary>
    public IsoMax256Text? URL { get; init; } 
    
    #nullable disable
}
