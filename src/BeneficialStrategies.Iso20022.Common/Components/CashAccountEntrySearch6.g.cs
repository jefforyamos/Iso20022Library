﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccountEntrySearch6.  ISO2002 ID# _PEwWiW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a cash entry.
/// </summary>
public partial record CashAccountEntrySearch6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentificationSearchCriteria2Choice? AccountIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the entry amount(s) on which the query is performed.
    /// </summary>
    public IActiveOrHistoricAmountRange2Choice? EntryAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency of the entry amount.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? EntryAmountCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    public EntryStatus1Code? EntryStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer's books.
    /// </summary>
    public IDateAndDateTimeSearch3Choice? EntryDate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification135? AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    
    #nullable disable
}
