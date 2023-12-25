﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QRCodePresentmentModeCode.  ISO2002 ID# _JsWoAMV3Eeua2vd9tJAtHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the mode used to present a QR Code for a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QRCodePresentmentModeCodeDropdownSource"/>.
/// Implements <seealso cref="IQRCodePresentmentModeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JsWoAMV3Eeua2vd9tJAtHg")]
public partial class QRCodePresentmentModeCodeDropdownRow : EnumMetadataItem<QRCodePresentmentModeCode>, IQRCodePresentmentModeCodeDropdownRow
{
    /// <summary>
    /// Identifies the mode used to present a QR Code for a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QRCodePresentmentModeCodeDropdownRow(QRCodePresentmentModeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
