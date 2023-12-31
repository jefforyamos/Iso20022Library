﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferStatusCode.  ISO2002 ID# _YvRbQ9p-Ed-ak6NoX_4Aeg_-141526851.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ITransferStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YvRbQ9p-Ed-ak6NoX_4Aeg_-141526851")]
public partial class TransferStatusCodeDropdownRow : EnumMetadataItem<TransferStatusCode>, ITransferStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the transfer or settlement instruction status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferStatusCodeDropdownRow(TransferStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
