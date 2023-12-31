﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType11Code.  ISO2002 ID# _7UXS0E2XEe2bQ-Ksk8mwQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7UXS0E2XEe2bQ-Ksk8mwQg")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeV2Code))]
public enum TransactionOperationType11Code
{
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as "Correction".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_AHVSkU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction,
    
    /// <summary>
    /// Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.
    /// Encoded/decoded by serializers as "MarginUpdate".
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_A3-sYU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.")]
    MarginUpdate,
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as "NewTransaction".
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_BjAmYU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction,
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_LmjDUWW_Ee2JluottcAG9w")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.")]
    Error,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionOperationType11CodeMetadataExtensions
{
    private static readonly TransactionOperationType11CodeDropdownSource _dropdownSource = new TransactionOperationType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionOperationType11CodeDropdownRow GetMetadata(this TransactionOperationType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


