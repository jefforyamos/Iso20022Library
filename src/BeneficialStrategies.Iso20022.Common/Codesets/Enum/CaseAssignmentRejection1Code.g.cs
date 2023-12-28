﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CaseAssignmentRejection1Code.  ISO2002 ID# _Vm241tp-Ed-ak6NoX_4Aeg_-475726160.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vm241tp-Ed-ak6NoX_4Aeg_-475726160")]
[Description(@"Specifies the reason for not accepting a Case.")]
[DerivedFrom(typeof(CaseAssignmentRejectionCode))]
public enum CaseAssignmentRejection1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnderlyingPaymentNotFound".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vm2419p-Ed-ak6NoX_4Aeg_-407386472")]
    [Description(@"??")]
    UnderlyingPaymentNotFound,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotAuthorisedToInvestigate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VnACwNp-Ed-ak6NoX_4Aeg_-48136805")]
    [Description(@"??")]
    NotAuthorisedToInvestigate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnknownCase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VnACwdp-Ed-ak6NoX_4Aeg_-1993051148")]
    [Description(@"??")]
    UnknownCase,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentRejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VnACwtp-Ed-ak6NoX_4Aeg_-1951794735")]
    [Description(@"??")]
    PaymentRejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VnACw9p-Ed-ak6NoX_4Aeg_-1881606195")]
    [Description(@"??")]
    PaymentCancelled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CaseAssignmentRejection1CodeMetadataExtensions
{
    private static readonly CaseAssignmentRejection1CodeDropdownSource _dropdownSource = new CaseAssignmentRejection1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICaseAssignmentRejection1CodeDropdownRow GetMetadata(this CaseAssignmentRejection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

