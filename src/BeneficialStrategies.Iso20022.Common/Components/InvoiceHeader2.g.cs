﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvoiceHeader2.  ISO2002 ID# _1EABwcNREeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collection of data for that is exchanged between two or more parties in written, printed or electronic form.
/// </summary>
public partial record InvoiceHeader2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    public required ExternalDocumentType1Code TypeCode { get; init; } 
    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    public IsoMax35Text[] Name { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    public required IsoISODateTime IssueDateTime { get; init; } 
    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    public TradeParty3? Issuer { get; init; } 
    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    public LanguageCode? LanguageCode { get; init; } 
    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    public IsoYesNoIndicator? CopyIndicator { get; init; } 
    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    public AdditionalInformation6[] IncludedNote { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
