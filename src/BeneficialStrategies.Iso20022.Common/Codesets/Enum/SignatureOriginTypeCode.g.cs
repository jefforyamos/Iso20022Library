﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SignatureOriginTypeCode.  ISO2002 ID# _l-8UwMnAEeWI4cSIO9foRA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the origin of the signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l-8UwMnAEeWI4cSIO9foRA")]
[Description(@"Specifies the origin of the signature.")]
[Derivations(typeof(SignatureOriginType1Code))]
public enum SignatureOriginTypeCode
{
    /// <summary>
    /// Signature is provided for the contract validation of the file.
    /// Encoded/decoded by serializers as "CTRC".
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_suYoQMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the contract validation of the file.")]
    Contract,
    
    /// <summary>
    /// Signature is provided for the technical validation of the file.
    /// Encoded/decoded by serializers as "TECH".
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_szS9cMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the technical validation of the file.")]
    Technical,
    
    /// <summary>
    /// Signature is provided for the value validation of the file.
    /// Encoded/decoded by serializers as "VLUE".
    /// </summary>
    [EnumMember(Value = "VLUE")]
    [IsoId("_rX9A0MnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the value validation of the file.")]
    Value,
    
    /// <summary>
    /// Signature is provided for the bank validation of the file.
    /// Encoded/decoded by serializers as "BANK".
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_s4NSoMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the bank validation of the file.")]
    Bank,
    
}
