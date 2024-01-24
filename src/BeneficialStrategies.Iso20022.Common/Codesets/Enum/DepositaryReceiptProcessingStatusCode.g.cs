﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DepositaryReceiptProcessingStatusCode.  ISO2002 ID# _av4BF9p-Ed-ak6NoX_4Aeg_1948323043.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a depositary receipt processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_av4BF9p-Ed-ak6NoX_4Aeg_1948323043")]
[Description(@"Specifies the status of a depositary receipt processing.")]
[Derivations(typeof(DepositaryReceiptProcessingStatus1Code))]
public enum DepositaryReceiptProcessingStatusCode
{
    /// <summary>
    /// No record of the transaction for which a status is requested.
    /// Encoded/decoded by serializers as "NORE".
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_av4BGNp-Ed-ak6NoX_4Aeg_-2060352164")]
    [Description(@"No record of the transaction for which a status is requested.")]
    NoRecordFound,
    
    /// <summary>
    /// Depositary receipt is pending completion.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_awBLANp-Ed-ak6NoX_4Aeg_-2058506616")]
    [Description(@"Depositary receipt is pending completion.")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DepositaryReceiptProcessingStatusCodeMetadataExtensions
{
    private static readonly DepositaryReceiptProcessingStatusCodeDropdownSource _dropdownSource = new DepositaryReceiptProcessingStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDepositaryReceiptProcessingStatusCodeDropdownRow GetMetadata(this DepositaryReceiptProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


