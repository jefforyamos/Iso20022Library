﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SequenceType1Code.  ISO2002 ID# _ZKPgAtp-Ed-ak6NoX_4Aeg_650235099.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions. Specific attributes are required for the first, the recurring and the last instructions of a series, as well as the specification of a unique transaction (one-off direct debit transaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKPgAtp-Ed-ak6NoX_4Aeg_650235099")]
[Description(@"Specifies the type of the current transaction that belongs to a sequence of transactions. Specific attributes are required for the first, the recurring and the last instructions of a series, as well as the specification of a unique transaction (one-off direct debit transaction).")]
[DerivedFrom(typeof(SequenceTypeCode))]
public enum SequenceType1Code
{
    /// <summary>
    /// First collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as "First".
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_ZKPgA9p-Ed-ak6NoX_4Aeg_650235429")]
    [Description(@"First collection of a series of direct debit instructions.")]
    First,
    
    /// <summary>
    /// Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor.
    /// Encoded/decoded by serializers as "Recurring".
    /// </summary>
    [EnumMember(Value = "RCUR")]
    [IsoId("_ZKPgBNp-Ed-ak6NoX_4Aeg_650235490")]
    [Description(@"Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor.")]
    Recurring,
    
    /// <summary>
    /// Final collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as "Final".
    /// </summary>
    [EnumMember(Value = "FNAL")]
    [IsoId("_ZKPgBdp-Ed-ak6NoX_4Aeg_650235532")]
    [Description(@"Final collection of a series of direct debit instructions.")]
    Final,
    
    /// <summary>
    /// Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction.
    /// Encoded/decoded by serializers as "OneOff".
    /// </summary>
    [EnumMember(Value = "OOFF")]
    [IsoId("_ZKPgBtp-Ed-ak6NoX_4Aeg_650235798")]
    [Description(@"Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction.")]
    OneOff,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SequenceType1CodeMetadataExtensions
{
    private static readonly SequenceType1CodeDropdownSource _dropdownSource = new SequenceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISequenceType1CodeDropdownRow GetMetadata(this SequenceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


