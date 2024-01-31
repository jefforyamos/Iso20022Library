﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesFinancingTransactionType1Code.  ISO2002 ID# _ZFoFwdp-Ed-ak6NoX_4Aeg_-1035743681.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities financing transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFoFwdp-Ed-ak6NoX_4Aeg_-1035743681")]
[Description(@"Specifies the type of securities financing transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
public enum SecuritiesFinancingTransactionType1Code
{
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as "REPU".
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZFoFwtp-Ed-ak6NoX_4Aeg_-738371349")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as "RVPO".
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZFoFw9p-Ed-ak6NoX_4Aeg_-738371331")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as "SECB".
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZFoFxNp-Ed-ak6NoX_4Aeg_-738371296")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZFoFxdp-Ed-ak6NoX_4Aeg_-738371271")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesFinancingTransactionType1CodeMetadataExtensions
{
    private static readonly SecuritiesFinancingTransactionType1CodeDropdownSource _dropdownSource = new SecuritiesFinancingTransactionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesFinancingTransactionType1CodeDropdownRow GetMetadata(this SecuritiesFinancingTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


