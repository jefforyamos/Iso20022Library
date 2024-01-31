﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QRCodeErrorCorrection1Code.  ISO2002 ID# _LwMBINubEeiB5uLfkg9ZJA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQRCodeErrorCorrection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LwMBINubEeiB5uLfkg9ZJA")]
public partial class QRCodeErrorCorrection1CodeDropdownSource : EnumMetadataManager<QRCodeErrorCorrection1Code,IQRCodeErrorCorrection1CodeDropdownRow,QRCodeErrorCorrection1CodeDropdownRow>
{
    public QRCodeErrorCorrection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new QRCodeErrorCorrection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
