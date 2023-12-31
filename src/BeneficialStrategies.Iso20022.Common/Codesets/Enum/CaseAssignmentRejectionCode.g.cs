﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CaseAssignmentRejectionCode.  ISO2002 ID# _a2IaFtp-Ed-ak6NoX_4Aeg_-898092331.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2IaFtp-Ed-ak6NoX_4Aeg_-898092331")]
[Description(@"Specifies the reason for not accepting a Case.")]
[Derivations(typeof(CaseAssignmentRejection1Code),typeof(CaseAssignmentRejection2Code))]
// External derivations that should be provided by the proper interface are: 
public enum CaseAssignmentRejectionCode
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as "NFND".
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_a2IaF9p-Ed-ak6NoX_4Aeg_-141872446")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound,
    
    /// <summary>
    /// Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).
    /// Encoded/decoded by serializers as "NAUT".
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_a2IaGNp-Ed-ak6NoX_4Aeg_-141872403")]
    [Description(@"Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).")]
    NotAuthorisedToInvestigate,
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as "UKNW".
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2SLENp-Ed-ak6NoX_4Aeg_-141872368")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase,
    
    /// <summary>
    /// Used when the payment instruction has been rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_a2SLEdp-Ed-ak6NoX_4Aeg_-141872333")]
    [Description(@"Used when the payment instruction has been rejected.")]
    PaymentRejected,
    
    /// <summary>
    /// Used when the payment instruction has been cancelled.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a2SLEtp-Ed-ak6NoX_4Aeg_-141872308")]
    [Description(@"Used when the payment instruction has been cancelled.")]
    PaymentCancelled,
    
    /// <summary>
    /// Used when the payment instruction has previously been cancelled or rejected.
    /// Encoded/decoded by serializers as "PCOR".
    /// </summary>
    [EnumMember(Value = "PCOR")]
    [IsoId("_a2SLE9p-Ed-ak6NoX_4Aeg_-795580088")]
    [Description(@"Used when the payment instruction has previously been cancelled or rejected.")]
    PaymentPreviouslyCancelledOrRejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CaseAssignmentRejectionCodeMetadataExtensions
{
    private static readonly CaseAssignmentRejectionCodeDropdownSource _dropdownSource = new CaseAssignmentRejectionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICaseAssignmentRejectionCodeDropdownRow GetMetadata(this CaseAssignmentRejectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


