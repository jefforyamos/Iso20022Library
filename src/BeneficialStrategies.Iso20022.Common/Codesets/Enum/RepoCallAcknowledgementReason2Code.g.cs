﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepoCallAcknowledgementReason2Code.  ISO2002 ID# _ZSvUtNp-Ed-ak6NoX_4Aeg_632190422.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSvUtNp-Ed-ak6NoX_4Aeg_632190422")]
[Description(@"Specifies additional information about the repurchase agreement call processed instruction.")]
[DerivedFrom(typeof(RepoCallAcknowledgementReasonCode))]
public enum RepoCallAcknowledgementReason2Code
{
    /// <summary>
    /// Repurchase agreement call is in process.
    /// Encoded/decoded by serializers as "CALD".
    /// </summary>
    [EnumMember(Value = "CALD")]
    [IsoId("_ZSvUtdp-Ed-ak6NoX_4Aeg_-364881931")]
    [Description(@"Repurchase agreement call is in process.")]
    InProcess = RepoCallAcknowledgementReasonCode.InProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repurchase agreement call is processed.
    /// Encoded/decoded by serializers as "CALP".
    /// </summary>
    [EnumMember(Value = "CALP")]
    [IsoId("_ZSvUttp-Ed-ak6NoX_4Aeg_-478720997")]
    [Description(@"Repurchase agreement call is processed.")]
    Processed = RepoCallAcknowledgementReasonCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZSvUt9p-Ed-ak6NoX_4Aeg_1840624684")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = RepoCallAcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
}
