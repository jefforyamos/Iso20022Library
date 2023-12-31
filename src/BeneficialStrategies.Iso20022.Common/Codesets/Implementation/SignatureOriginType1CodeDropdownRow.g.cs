﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SignatureOriginType1Code.  ISO2002 ID# _-s3AAMnAEeWI4cSIO9foRA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the origin of the signature.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SignatureOriginType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISignatureOriginType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-s3AAMnAEeWI4cSIO9foRA")]
public partial class SignatureOriginType1CodeDropdownRow : EnumMetadataItem<SignatureOriginType1Code>, ISignatureOriginType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the origin of the signature.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SignatureOriginType1CodeDropdownRow(SignatureOriginType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
