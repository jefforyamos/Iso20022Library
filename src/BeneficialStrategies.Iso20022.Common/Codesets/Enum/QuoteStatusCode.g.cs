﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QuoteStatusCode.  ISO2002 ID# _ZYjBxdp-Ed-ak6NoX_4Aeg_336258615.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of a quote acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYjBxdp-Ed-ak6NoX_4Aeg_336258615")]
[Description(@"Identifies the status of a quote acknowledgement.")]
[Derivations(typeof(QuoteStatus1Code),typeof(QuoteStatus2Code))]
// External derivations that should be provided by the proper interface are: 
public enum QuoteStatusCode
{
    /// <summary>
    /// Indicates that the quote is accepted for further negotiation.
    /// Encoded/decoded by serializers as "ACPT".
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_ZYjBxtp-Ed-ak6NoX_4Aeg_336258616")]
    [Description(@"Indicates that the quote is accepted for further negotiation.")]
    Accepted,
    
    /// <summary>
    /// Indicates that all quotes are cancelled for a financial instrument's symbol.
    /// Encoded/decoded by serializers as "SYMB".
    /// </summary>
    [EnumMember(Value = "SYMB")]
    [IsoId("_ZYjBx9p-Ed-ak6NoX_4Aeg_336258617")]
    [Description(@"Indicates that all quotes are cancelled for a financial instrument's symbol.")]
    CancelSymbol,
    
    /// <summary>
    /// Indicates that all quotes are cancelled for a specific security.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZYjByNp-Ed-ak6NoX_4Aeg_336258626")]
    [Description(@"Indicates that all quotes are cancelled for a specific security.")]
    CancelSecurity,
    
    /// <summary>
    /// Indicates that all quotes are cancelled for an underlying financial instrument.
    /// Encoded/decoded by serializers as "UNSY".
    /// </summary>
    [EnumMember(Value = "UNSY")]
    [IsoId("_ZYsywNp-Ed-ak6NoX_4Aeg_336258627")]
    [Description(@"Indicates that all quotes are cancelled for an underlying financial instrument.")]
    CancelUnderlying,
    
    /// <summary>
    /// Indicates that all quotes are cancelled.
    /// Encoded/decoded by serializers as "ALLE".
    /// </summary>
    [EnumMember(Value = "ALLE")]
    [IsoId("_ZYsywdp-Ed-ak6NoX_4Aeg_336258628")]
    [Description(@"Indicates that all quotes are cancelled.")]
    CancelAll,
    
    /// <summary>
    /// Indicates that the quote is not accepted.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZYsywtp-Ed-ak6NoX_4Aeg_336258629")]
    [Description(@"Indicates that the quote is not accepted.")]
    Rejected,
    
    /// <summary>
    /// Indicates that all quotes are removed from the market.
    /// Encoded/decoded by serializers as "REMO".
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZYsyw9p-Ed-ak6NoX_4Aeg_336258630")]
    [Description(@"Indicates that all quotes are removed from the market.")]
    RemovedFromMarket,
    
    /// <summary>
    /// Indicates that the quote is not valid anymore.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ZYsyxNp-Ed-ak6NoX_4Aeg_336258631")]
    [Description(@"Indicates that the quote is not valid anymore.")]
    Expired,
    
    /// <summary>
    /// Indicates that the quote is being requested.
    /// Encoded/decoded by serializers as "QUER".
    /// </summary>
    [EnumMember(Value = "QUER")]
    [IsoId("_ZYsyxdp-Ed-ak6NoX_4Aeg_336258632")]
    [Description(@"Indicates that the quote is being requested.")]
    Query,
    
    /// <summary>
    /// Indicates that no quote can be computed or communicated.
    /// Encoded/decoded by serializers as "NQUO".
    /// </summary>
    [EnumMember(Value = "NQUO")]
    [IsoId("_ZYsyxtp-Ed-ak6NoX_4Aeg_336258633")]
    [Description(@"Indicates that no quote can be computed or communicated.")]
    QuoteNotFound,
    
    /// <summary>
    /// Indicates that the quote is being processed.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZYsyx9p-Ed-ak6NoX_4Aeg_336258634")]
    [Description(@"Indicates that the quote is being processed.")]
    Pending,
    
    /// <summary>
    /// Indicates that the counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as "PASS".
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZYsyyNp-Ed-ak6NoX_4Aeg_-86642452")]
    [Description(@"Indicates that the counterparty is not interested in the transaction.")]
    Pass,
    
    /// <summary>
    /// Warning due to a situation of locked market.
    /// Encoded/decoded by serializers as "LMWA".
    /// </summary>
    [EnumMember(Value = "LMWA")]
    [IsoId("_ZYsyydp-Ed-ak6NoX_4Aeg_41725420")]
    [Description(@"Warning due to a situation of locked market.")]
    LockedMarketWarning,
    
    /// <summary>
    /// Warning due to a situation of cross market.
    /// Encoded/decoded by serializers as "CMWA".
    /// </summary>
    [EnumMember(Value = "CMWA")]
    [IsoId("_ZYsyytp-Ed-ak6NoX_4Aeg_298464818")]
    [Description(@"Warning due to a situation of cross market.")]
    CrossMarketWarning,
    
    /// <summary>
    /// Indicates that the quote is canceled due to a situation of locked market.
    /// Encoded/decoded by serializers as "CDLM".
    /// </summary>
    [EnumMember(Value = "CDLM")]
    [IsoId("_ZY2jwNp-Ed-ak6NoX_4Aeg_313241242")]
    [Description(@"Indicates that the quote is canceled due to a situation of locked market.")]
    CanceledDueToLockMarket,
    
    /// <summary>
    /// Indicates that the quote is canceled due to a situation of cross market.
    /// Encoded/decoded by serializers as "CDCM".
    /// </summary>
    [EnumMember(Value = "CDCM")]
    [IsoId("_ZY2jwdp-Ed-ak6NoX_4Aeg_340948751")]
    [Description(@"Indicates that the quote is canceled due to a situation of cross market.")]
    CanceledDueToCrossMarket,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QuoteStatusCodeMetadataExtensions
{
    private static readonly QuoteStatusCodeDropdownSource _dropdownSource = new QuoteStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuoteStatusCodeDropdownRow GetMetadata(this QuoteStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


