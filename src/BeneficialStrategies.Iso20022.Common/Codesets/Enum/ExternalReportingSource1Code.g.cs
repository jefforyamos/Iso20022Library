﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReportingSource1Code.  ISO2002 ID# _amolgtp-Ed-ak6NoX_4Aeg_-418115557.
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
[IsoId("_amolgtp-Ed-ak6NoX_4Aeg_-418115557")]
[Description(@"Specifies the reporting source, as published in an external reporting source code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalReportingSourceCode))]
public enum ExternalReportingSource1Code
{
    /// <summary>
    /// Statement or Report is based on accounting data.
    /// Encoded/decoded by serializers as "Accounting".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_t4fFyPRYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on accounting data.")]
    Accounting,
    
    /// <summary>
    /// An account reconciliation system that provides full reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as "AccountReconciliationSystemFull".
    /// </summary>
    [EnumMember(Value = "ARPF")]
    [IsoId("_t4o2wvRYEeuLhpyIdtJzwg")]
    [Description(@"An account reconciliation system that provides full reconciliation that usually addresses checks")]
    AccountReconciliationSystemFull,
    
    /// <summary>
    /// An account reconciliation system that provides partial reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as "AccountReconciliationSystemPartial".
    /// </summary>
    [EnumMember(Value = "ARPP")]
    [IsoId("_t4o2xfRYEeuLhpyIdtJzwg")]
    [Description(@"An account reconciliation system that provides partial reconciliation that usually addresses checks")]
    AccountReconciliationSystemPartial,
    
    /// <summary>
    /// A sub-application that reports presentment totals
    /// Encoded/decoded by serializers as "ControlledDisbursementSystem".
    /// </summary>
    [EnumMember(Value = "CTDB")]
    [IsoId("_t4o2yPRYEeuLhpyIdtJzwg")]
    [Description(@"A sub-application that reports presentment totals")]
    ControlledDisbursementSystem,
    
    /// <summary>
    /// Statement or Report is based on custody data.
    /// Encoded/decoded by serializers as "Custody".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t4o2y_RYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on custody data.")]
    Custody,
    
    /// <summary>
    /// Cash or deposit accounting system
    /// Encoded/decoded by serializers as "DepositSystem".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_t4o2zvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash or deposit accounting system")]
    DepositSystem,
    
    /// <summary>
    /// Deposit system that reports what has been collected from various financial institutions
    /// Encoded/decoded by serializers as "DepositConcentrationSystem".
    /// </summary>
    [EnumMember(Value = "DPCS")]
    [IsoId("_t4yAsvRYEeuLhpyIdtJzwg")]
    [Description(@"Deposit system that reports what has been collected from various financial institutions")]
    DepositConcentrationSystem,
    
    /// <summary>
    /// Processing system that captures and reports check data in a lockbox environment.
    /// Encoded/decoded by serializers as "Lockbox".
    /// </summary>
    [EnumMember(Value = "LKBX")]
    [IsoId("_t4yAtfRYEeuLhpyIdtJzwg")]
    [Description(@"Processing system that captures and reports check data in a lockbox environment.")]
    Lockbox,
    
    /// <summary>
    /// A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc.
    /// Encoded/decoded by serializers as "Receipts".
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_t4yAuPRYEeuLhpyIdtJzwg")]
    [Description(@"A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc.")]
    Receipts,
    
    /// <summary>
    /// Transaction submitted directly from PMI (Payment Market Infrastructure back-office system.
    /// Encoded/decoded by serializers as "MIBackOffice".
    /// </summary>
    [EnumMember(Value = "MIBO")]
    [IsoId("_LyWdMY5DEeyANo-d7JlQ1A")]
    [Description(@"Transaction submitted directly from PMI (Payment Market Infrastructure back-office system.")]
    MIBackOffice,
    
    /// <summary>
    /// Transactions submitted directly from participant / PSO (Payment System Operator) applications.
    /// Encoded/decoded by serializers as "ParticipantFrontEnd".
    /// </summary>
    [EnumMember(Value = "PFRE")]
    [IsoId("_L8xkgY5DEeyANo-d7JlQ1A")]
    [Description(@"Transactions submitted directly from participant / PSO (Payment System Operator) applications.")]
    ParticipantFrontEnd,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReportingSource1CodeMetadataExtensions
{
    private static readonly ExternalReportingSource1CodeDropdownSource _dropdownSource = new ExternalReportingSource1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReportingSource1CodeDropdownRow GetMetadata(this ExternalReportingSource1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


