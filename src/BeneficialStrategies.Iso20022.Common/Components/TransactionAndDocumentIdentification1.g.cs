﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionAndDocumentIdentification1.  ISO2002 ID# _Qri1ZNp-Ed-ak6NoX_4Aeg_-896139049.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction and document identification details.
/// </summary>
public partial record TransactionAndDocumentIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identifier of the document (message) assigned by the sender of the document.
    /// </summary>
    public IsoMax35Text? DocumentIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the transaction was created by the instructing party in its business application.
    /// </summary>
    public IDateAndDateTimeChoice? CreationDateTime { get; init; } 
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 
    
    #nullable disable
}
