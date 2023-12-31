﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GDPRDataConsentCode.  ISO2002 ID# _aN8PUJTTEemC09f0MxYkRg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGDPRDataConsentCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aN8PUJTTEemC09f0MxYkRg")]
public partial class GDPRDataConsentCodeDropdownSource : EnumMetadataManager<GDPRDataConsentCode,IGDPRDataConsentCodeDropdownRow,GDPRDataConsentCodeDropdownRow>
{
    public GDPRDataConsentCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GDPRDataConsentCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
