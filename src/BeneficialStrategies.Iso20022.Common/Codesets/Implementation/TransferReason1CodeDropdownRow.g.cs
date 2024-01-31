﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferReason1Code.  ISO2002 ID# _SGnRUPr5EeCu2Z1WwxJVWA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the assets transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferReason1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransferReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SGnRUPr5EeCu2Z1WwxJVWA")]
public partial class TransferReason1CodeDropdownRow : EnumMetadataItem<TransferReason1Code>, ITransferReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferReason1CodeDropdownRow(TransferReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
