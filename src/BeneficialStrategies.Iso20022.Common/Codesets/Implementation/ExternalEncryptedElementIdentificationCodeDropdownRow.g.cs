﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalEncryptedElementIdentificationCode.  ISO2002 ID# _aG9UEVdTEeqBUKlIwxdUog.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the element that has been encrypted, as published in an external data to encrypt type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalEncryptedElementIdentificationCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalEncryptedElementIdentificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aG9UEVdTEeqBUKlIwxdUog")]
public partial class ExternalEncryptedElementIdentificationCodeDropdownRow : EnumMetadataItem<ExternalEncryptedElementIdentificationCode>, IExternalEncryptedElementIdentificationCodeDropdownRow
{
    /// <summary>
    /// Specifies the element that has been encrypted, as published in an external data to encrypt type code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalEncryptedElementIdentificationCodeDropdownRow(ExternalEncryptedElementIdentificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
