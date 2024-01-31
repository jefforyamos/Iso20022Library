﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionGroupStatus2Code.  ISO2002 ID# _YrjY5dp-Ed-ak6NoX_4Aeg_14174870.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrjY5dp-Ed-ak6NoX_4Aeg_14174870")]
[Description(@"Specifies the status of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionGroupStatus2Code
{
    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_YrjY5tp-Ed-ak6NoX_4Aeg_14174990")]
    [Description(@"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.")]
    PartiallyAccepted = PaymentStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YrjY59p-Ed-ak6NoX_4Aeg_14175042")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionGroupStatus2CodeMetadataExtensions
{
    private static readonly TransactionGroupStatus2CodeDropdownSource _dropdownSource = new TransactionGroupStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionGroupStatus2CodeDropdownRow GetMetadata(this TransactionGroupStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


