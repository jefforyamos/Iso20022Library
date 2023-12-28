﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationType6Code.  ISO2002 ID# _uaoFUP_iEemm3skPVSMJQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uaoFUP_iEemm3skPVSMJQg")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralReuseUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tfgO8__kEemm3skPVSMJQg")]
    [Description(@"??")]
    CollateralReuseUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t1HSkf_kEemm3skPVSMJQg")]
    [Description(@"??")]
    CollateralUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Correction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uLd9E__kEemm3skPVSMJQg")]
    [Description(@"??")]
    Correction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EarlyTermination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uLd9Ff_kEemm3skPVSMJQg")]
    [Description(@"??")]
    EarlyTermination,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValuationUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ul2L8f_kEemm3skPVSMJQg")]
    [Description(@"??")]
    ValuationUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PositionComponent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vBRjsf_kEemm3skPVSMJQg")]
    [Description(@"??")]
    PositionComponent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NewTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vBato__kEemm3skPVSMJQg")]
    [Description(@"??")]
    NewTransaction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Modification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vBkeof_kEemm3skPVSMJQg")]
    [Description(@"??")]
    Modification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarginUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vEjhMf_kEemm3skPVSMJQg")]
    [Description(@"??")]
    MarginUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vIRjkf_kEemm3skPVSMJQg")]
    [Description(@"??")]
    Error,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionOperationType6CodeMetadataExtensions
{
    private static readonly TransactionOperationType6CodeDropdownSource _dropdownSource = new TransactionOperationType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionOperationType6CodeDropdownRow GetMetadata(this TransactionOperationType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

