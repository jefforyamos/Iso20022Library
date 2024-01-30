﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashEntry2.  ISO2002 ID# _HOYB15liEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
public partial record CashEntry2
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Date at which an entry is posted to an account on the account servicer's books.
    /// </summary>
    public IDateAndDateTime2Choice? Date { get; init; } 
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    public EntryStatus1Code? Status { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an entry, as assigned by the account servicer.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    public IsoNumber? AccountServicerReference { get; init; } 
    /// <summary>
    /// Further details of the entry.
    /// </summary>
    public IsoMax140Text? AdditionalEntryInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
