﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionOperationTypeCode.  ISO2002 ID# _0tTA3JfpEeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0tTA3JfpEeSfnc-VXAEapg")]
[Description(@"Specifies the type of process related to a specific transaction.")]
[Derivations(typeof(TransactionOperationType1Code),typeof(TransactionOperationType3Code),typeof(TransactionOperationType4Code),typeof(TransactionOperationType5Code),typeof(TransactionOperationType6Code),typeof(TransactionOperationType7Code))]
// External derivations that should be provided by the proper interface are: 
public enum TransactionOperationTypeCode
{
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as "NEWT".
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_0tTn4ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction,
    
    /// <summary>
    /// Transaction requests the deletion/cancellation of a previously sent transaction.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_0tTn6ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction requests the deletion/cancellation of a previously sent transaction.")]
    Cancellation,
    
    /// <summary>
    /// Transaction amends a previously sent transaction.
    /// Encoded/decoded by serializers as "AMND".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_0tTn55fpEeSfnc-VXAEapg")]
    [Description(@"Transaction amends a previously sent transaction.")]
    Amendment,
    
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as "CORR".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_0tTn5ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction,
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as "ETRM".
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_Ykx9QA3lEeWc7_0KPiuk6w")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination,
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as "EROR".
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_ladPMA3lEeWc7_0KPiuk6w")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.")]
    Error,
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_ExfDABVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification,
    
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_VE-foBVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a compression.")]
    Compression,
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as "VALU".
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_X7FKEBVmEeWXLoZC9OIRgg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate,
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as "POSC".
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_c_QOkBVmEeWXLoZC9OIRgg")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_za5KEOldEeWv8d_RPCVG5g")]
    [Description(@"Other.")]
    Other,
    
    /// <summary>
    /// Update of a contract collateral.
    /// Encoded/decoded by serializers as "COLU".
    /// </summary>
    [EnumMember(Value = "COLU")]
    [IsoId("_RpAiYK1UEemkQYpo6COeTA")]
    [Description(@"Update of a contract collateral.")]
    CollateralUpdate,
    
    /// <summary>
    /// Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs.
    /// Encoded/decoded by serializers as "MARU".
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_aWxM4P_LEemm3skPVSMJQg")]
    [Description(@"Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs.")]
    MarginUpdate,
    
    /// <summary>
    /// Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.
    /// Encoded/decoded by serializers as "REUU".
    /// </summary>
    [EnumMember(Value = "REUU")]
    [IsoId("_a-tWoP_LEemm3skPVSMJQg")]
    [Description(@"Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.")]
    CollateralReuseUpdate,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as "REVI".
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_vwtpwS42Eeuxhbw_aW6haw")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    Revive,
    
    /// <summary>
    /// Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ufv-wS_DEeuZ2qWQaQMBMw")]
    [Description(@"Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.")]
    Termination,
    
    /// <summary>
    /// Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).
    /// Encoded/decoded by serializers as "PRTO".
    /// </summary>
    [EnumMember(Value = "PRTO")]
    [IsoId("_fvz4sD3gEe2uHKhHp3bXyA")]
    [Description(@"Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).")]
    PortOut,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionOperationTypeCodeMetadataExtensions
{
    private static readonly TransactionOperationTypeCodeDropdownSource _dropdownSource = new TransactionOperationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionOperationTypeCodeDropdownRow GetMetadata(this TransactionOperationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


