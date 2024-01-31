﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionActivityCode.  ISO2002 ID# _YrP25tp-Ed-ak6NoX_4Aeg_-41180042.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of activity to which this transaction relates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrP25tp-Ed-ak6NoX_4Aeg_-41180042")]
[Description(@"Specifies the type of activity to which this transaction relates.")]
[Derivations(typeof(TransactionActivity1Code))]
public enum TransactionActivityCode
{
    /// <summary>
    /// Transaction relates to lending/borrowing.
    /// Encoded/decoded by serializers as "BOLE".
    /// </summary>
    [EnumMember(Value = "BOLE")]
    [IsoId("_YrP259p-Ed-ak6NoX_4Aeg_-330582251")]
    [Description(@"Transaction relates to lending/borrowing.")]
    BorrowingLendingActivity,
    
    /// <summary>
    /// Transaction relates to a market claim following a corporate action.
    /// Encoded/decoded by serializers as "CLAI".
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_YrP26Np-Ed-ak6NoX_4Aeg_-328734377")]
    [Description(@"Transaction relates to a market claim following a corporate action.")]
    MarketClaim,
    
    /// <summary>
    /// Transaction relates to collateral.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_YrZn4Np-Ed-ak6NoX_4Aeg_-327810772")]
    [Description(@"Transaction relates to collateral.")]
    CollateralActivity,
    
    /// <summary>
    /// Transaction relates to corporate action.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_YrZn4dp-Ed-ak6NoX_4Aeg_-320422749")]
    [Description(@"Transaction relates to corporate action.")]
    CorporateActionActivity,
    
    /// <summary>
    /// Transaction relates to settlement and clearing.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YrZn4tp-Ed-ak6NoX_4Aeg_-319499022")]
    [Description(@"Transaction relates to settlement and clearing.")]
    SettlementandClearingActivity,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionActivityCodeMetadataExtensions
{
    private static readonly TransactionActivityCodeDropdownSource _dropdownSource = new TransactionActivityCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionActivityCodeDropdownRow GetMetadata(this TransactionActivityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


