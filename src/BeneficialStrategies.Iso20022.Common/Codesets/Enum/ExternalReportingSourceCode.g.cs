﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReportingSourceCode.  ISO2002 ID# _229eQLf8Eee9KIDjEHK7ZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reporting source, as published in an external reporting source code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_229eQLf8Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the reporting source, as published in an external reporting source code list. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalReportingSourceCode
{
    /// <summary>
    /// Statement or Report is based on accounting data.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_t4fFxvRYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on accounting data.")]
    Accounting,
    
    /// <summary>
    /// An account reconciliation system that provides full reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as "ARPF".
    /// </summary>
    [EnumMember(Value = "ARPF")]
    [IsoId("_t4o2wPRYEeuLhpyIdtJzwg")]
    [Description(@"An account reconciliation system that provides full reconciliation that usually addresses checks")]
    AccountReconciliationSystemFull,
    
    /// <summary>
    /// An account reconciliation system that provides partial reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as "ARPP".
    /// </summary>
    [EnumMember(Value = "ARPP")]
    [IsoId("_t4o2w_RYEeuLhpyIdtJzwg")]
    [Description(@"An account reconciliation system that provides partial reconciliation that usually addresses checks")]
    AccountReconciliationSystemPartial,
    
    /// <summary>
    /// A sub-application that reports presentment totals
    /// Encoded/decoded by serializers as "CTDB".
    /// </summary>
    [EnumMember(Value = "CTDB")]
    [IsoId("_t4o2xvRYEeuLhpyIdtJzwg")]
    [Description(@"A sub-application that reports presentment totals")]
    ControlledDisbursementSystem,
    
    /// <summary>
    /// Statement or Report is based on custody data.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t4o2yfRYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on custody data.")]
    Custody,
    
    /// <summary>
    /// Cash or deposit accounting system
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_t4o2zPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash or deposit accounting system")]
    DepositSystem,
    
    /// <summary>
    /// Deposit system that reports what has been collected from various financial institutions
    /// Encoded/decoded by serializers as "DPCS".
    /// </summary>
    [EnumMember(Value = "DPCS")]
    [IsoId("_t4yAsPRYEeuLhpyIdtJzwg")]
    [Description(@"Deposit system that reports what has been collected from various financial institutions")]
    DepositConcentrationSystem,
    
    /// <summary>
    /// Processing system that captures and reports check data in a lockbox environment.
    /// Encoded/decoded by serializers as "LKBX".
    /// </summary>
    [EnumMember(Value = "LKBX")]
    [IsoId("_t4yAs_RYEeuLhpyIdtJzwg")]
    [Description(@"Processing system that captures and reports check data in a lockbox environment.")]
    Lockbox,
    
    /// <summary>
    /// A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc.
    /// Encoded/decoded by serializers as "RCPT".
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_t4yAtvRYEeuLhpyIdtJzwg")]
    [Description(@"A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc.")]
    Receipts,
    
    /// <summary>
    /// Transactions submitted directly from participant / PSO (Payment System Operator) applications.
    /// Encoded/decoded by serializers as "PFRE".
    /// </summary>
    [EnumMember(Value = "PFRE")]
    [IsoId("_zcu9MI5CEeyANo-d7JlQ1A")]
    [Description(@"Transactions submitted directly from participant / PSO (Payment System Operator) applications.")]
    ParticipantFrontEnd,
    
    /// <summary>
    /// Transaction submitted directly from PMI (Payment Market Infrastructure back-office system.
    /// Encoded/decoded by serializers as "MIBO".
    /// </summary>
    [EnumMember(Value = "MIBO")]
    [IsoId("_7_JqMI5CEeyANo-d7JlQ1A")]
    [Description(@"Transaction submitted directly from PMI (Payment Market Infrastructure back-office system.")]
    MIBackOffice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReportingSourceCodeMetadataExtensions
{
    private static readonly ExternalReportingSourceCodeDropdownSource _dropdownSource = new ExternalReportingSourceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReportingSourceCodeDropdownRow GetMetadata(this ExternalReportingSourceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


