﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesFinancingTransactionType1Code.  ISO2002 ID# _ZFoFwdp-Ed-ak6NoX_4Aeg_-1035743681.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "Repo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFoFwtp-Ed-ak6NoX_4Aeg_-738371349")]
    [Description(@"??")]
    Repo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReverseRepo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFoFw9p-Ed-ak6NoX_4Aeg_-738371331")]
    [Description(@"??")]
    ReverseRepo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesBorrowing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFoFxNp-Ed-ak6NoX_4Aeg_-738371296")]
    [Description(@"??")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesLending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZFoFxdp-Ed-ak6NoX_4Aeg_-738371271")]
    [Description(@"??")]
    SecuritiesLending,
    
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


