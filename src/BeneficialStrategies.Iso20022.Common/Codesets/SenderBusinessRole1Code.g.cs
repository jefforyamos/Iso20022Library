﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SenderBusinessRole1Code.  ISO2002 ID# _p7dkgFV0Eea1MPROA61PoQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether an account owner or account servicer sends the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p7dkgFV0Eea1MPROA61PoQ")]
[Description(@"Specifies whether an account owner or account servicer sends the message.")]
[DerivedFrom(typeof(SenderBusinessRoleCode))]
public enum SenderBusinessRole1Code
{
    /// <summary>
    /// Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.
    /// Encoded/decoded by serializers as &quot;AOWN&quot;.
    /// </summary>
    [EnumMember(Value = "AOWN")]
    [IsoId("_sECakVV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.")]
    AccountOwner = SenderBusinessRoleCode.AccountOwner, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sender is the account servicer of an account owned by the receiver.
    /// Encoded/decoded by serializers as &quot;ASER&quot;.
    /// </summary>
    [EnumMember(Value = "ASER")]
    [IsoId("_sNkKAVV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the account servicer of an account owned by the receiver.")]
    AccountServicer = SenderBusinessRoleCode.AccountServicer, // same ordinal as derivation source for type conversions
    
}
