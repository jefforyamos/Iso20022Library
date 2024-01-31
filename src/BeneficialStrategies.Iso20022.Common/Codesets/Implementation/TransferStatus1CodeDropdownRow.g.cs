﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferStatus1Code.  ISO2002 ID# _Ve9hFNp-Ed-ak6NoX_4Aeg_-2123998543.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransferStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ve9hFNp-Ed-ak6NoX_4Aeg_-2123998543")]
public partial class TransferStatus1CodeDropdownRow : EnumMetadataItem<TransferStatus1Code>, ITransferStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the transfer or settlement instruction status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferStatus1CodeDropdownRow(TransferStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
