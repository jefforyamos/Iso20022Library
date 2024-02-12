﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClosedStatusReason1Code.  ISO2002 ID# _Sx9Z8E_wEeaB8-OWTiMVrQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the closed status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sx9Z8E_wEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for the closed status.")]
[DerivedFrom(typeof(ClosedStatusReasonCode))]
public enum ClosedStatusReason1Code
{
    /// <summary>
    /// Account is closed, following an instruction from the account servicer to close the account.
    /// Encoded/decoded by serializers as "ASIN".
    /// </summary>
    [EnumMember(Value = "ASIN")]
    [IsoId("_Vq4u4U_wEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the account servicer to close the account.")]
    AccountServicerInstruction = ClosedStatusReasonCode.AccountServicerInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is closed, following an instruction from the client, or an authorised party, to close the account.
    /// Encoded/decoded by serializers as "CLIN".
    /// </summary>
    [EnumMember(Value = "CLIN")]
    [IsoId("_V0joQU_wEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the client, or an authorised party, to close the account.")]
    ClientInstruction = ClosedStatusReasonCode.ClientInstruction, // same ordinal as derivation source for type conversions
    
}
