﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SenderBusinessRoleCode.  ISO2002 ID# _XOtxgFV0Eea1MPROA61PoQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether account owner or account servicer sends the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XOtxgFV0Eea1MPROA61PoQ")]
[Description(@"Specifies whether account owner or account servicer sends the message.")]
public enum SenderBusinessRoleCode
{
    /// <summary>
    /// Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.
    /// </summary>
    [EnumMember(Value = "AOWN")]
    [IsoId("_fPi0YFV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the owner of the safekeeping account. The sender is disclosing the breakdown of the underlying owners of sender’s holdings with the receiver.")]
    AOWN,
    
    /// <summary>
    /// Sender is the account servicer of an account owned by the receiver.
    /// </summary>
    [EnumMember(Value = "ASER")]
    [IsoId("_j6b2MFV0Eea1MPROA61PoQ")]
    [Description(@"Sender is the account servicer of an account owned by the receiver.")]
    ASER,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SenderBusinessRoleCodeMetadataExtensions
{
    private static readonly SenderBusinessRoleCodeDropdownSource _dropdownSource = new SenderBusinessRoleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISenderBusinessRoleCodeDropdownRow GetMetadata(this SenderBusinessRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


