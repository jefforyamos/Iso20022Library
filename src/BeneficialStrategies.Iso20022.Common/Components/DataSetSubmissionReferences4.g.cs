﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DataSetSubmissionReferences4.  ISO2002 ID# _RaCTGNp-Ed-ak6NoX_4Aeg_-1149247875.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides references to the transactions both for the matching application and for the user.
/// </summary>
public partial record DataSetSubmissionReferences4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Own reference to the transaction for the financial institution.
    /// </summary>
    // public IReadOnlyCollection<DocumentIdentification5> UserTransactionReference { get; init; }
    /// <summary>
    /// Specifies that this message should force the matching application to match all data sets it has received so far for the transaction identified by the transaction identification.
    /// </summary>
    public required IsoYesNoIndicator ForcedMatch { get; init; } 
    /// <summary>
    /// Unique identification assigned by the matching engine to the baseline when it is established.
    /// </summary>
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    public required BaselineStatus3Code TransactionStatus { get; init; } 
    
    #nullable disable
}
