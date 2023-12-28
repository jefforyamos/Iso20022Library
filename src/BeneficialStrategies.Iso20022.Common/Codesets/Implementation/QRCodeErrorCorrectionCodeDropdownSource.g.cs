﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QRCodeErrorCorrectionCode.  ISO2002 ID# _55g6gNuaEeiB5uLfkg9ZJA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQRCodeErrorCorrectionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_55g6gNuaEeiB5uLfkg9ZJA")]
public partial class QRCodeErrorCorrectionCodeDropdownSource : EnumMetadataManager<QRCodeErrorCorrectionCode,IQRCodeErrorCorrectionCodeDropdownRow,QRCodeErrorCorrectionCodeDropdownRow>
{
    public QRCodeErrorCorrectionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new QRCodeErrorCorrectionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}