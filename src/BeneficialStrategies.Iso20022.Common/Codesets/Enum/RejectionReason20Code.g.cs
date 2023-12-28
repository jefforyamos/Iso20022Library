﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason20Code.  ISO2002 ID# _Zi-wJ9p-Ed-ak6NoX_4Aeg_1390539565.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of the standing instruction request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zi-wJ9p-Ed-ak6NoX_4Aeg_1390539565")]
[Description(@"Specifies the reason of a rejection of the standing instruction request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason20Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FailedValidation".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zi-wKNp-Ed-ak6NoX_4Aeg_-482612999")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation,
    
    /// <summary>
    /// Unable to identify cash account.
    /// Encoded/decoded by serializers as "NotIdentifiedCashAccount".
    /// </summary>
    [EnumMember(Value = "CASA")]
    [IsoId("_ZjIhINp-Ed-ak6NoX_4Aeg_-482612969")]
    [Description(@"Unable to identify cash account.")]
    NotIdentifiedCashAccount,
    
    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as "NotIdentifiedCorrespondentBank".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ZjIhIdp-Ed-ak6NoX_4Aeg_-482612938")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank,
    
    /// <summary>
    /// Invalid standing instruction type for the specified underlying security.
    /// Encoded/decoded by serializers as "InvalidStandingInstructionType".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_ZjIhItp-Ed-ak6NoX_4Aeg_-482612937")]
    [Description(@"Invalid standing instruction type for the specified underlying security.")]
    InvalidStandingInstructionType,
    
    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as "NoHolding".
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_ZjIhI9p-Ed-ak6NoX_4Aeg_-482612907")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason20CodeMetadataExtensions
{
    private static readonly RejectionReason20CodeDropdownSource _dropdownSource = new RejectionReason20CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason20CodeDropdownRow GetMetadata(this RejectionReason20Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


