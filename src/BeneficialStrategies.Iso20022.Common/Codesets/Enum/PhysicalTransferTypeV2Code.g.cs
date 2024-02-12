﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PhysicalTransferTypeV2Code.  ISO2002 ID# _jiYPJYBAEeall68-KLgmUw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerilized transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jiYPJYBAEeall68-KLgmUw")]
[Description(@"Specifies whether the financial instrument is to be physically delivered or is a dematerilized transfer.")]
[Derivations(typeof(PhysicalTransferType4Code))]
public enum PhysicalTransferTypeV2Code
{
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_jiYPKYBAEeall68-KLgmUw")]
    [Description(@"Physical transfer.")]
    Physical,
    
    /// <summary>
    /// Dematerialised transfer.
    /// Encoded/decoded by serializers as "DEMT".
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_jiYPKIBAEeall68-KLgmUw")]
    [Description(@"Dematerialised transfer.")]
    Dematerialised,
    
    /// <summary>
    /// Cash transfer.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jiYPJ4BAEeall68-KLgmUw")]
    [Description(@"Cash transfer.")]
    Cash,
    
    /// <summary>
    /// Determined by a third party or optional for counterparty.
    /// Encoded/decoded by serializers as "OPTL".
    /// </summary>
    [EnumMember(Value = "OPTL")]
    [IsoId("_jiYPJoBAEeall68-KLgmUw")]
    [Description(@"Determined by a third party or optional for counterparty.")]
    Optional,
    
}
