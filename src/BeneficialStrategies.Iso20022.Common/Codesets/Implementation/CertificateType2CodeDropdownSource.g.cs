﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CertificateType2Code.  ISO2002 ID# _GXDp0BODEeKjmvxNCObNeQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certificate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICertificateType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GXDp0BODEeKjmvxNCObNeQ")]
public partial class CertificateType2CodeDropdownSource : EnumMetadataManager<CertificateType2Code,ICertificateType2CodeDropdownRow,CertificateType2CodeDropdownRow>
{
    public CertificateType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CertificateType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
