﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GDPRDataConsent1Code.  ISO2002 ID# _SQd7EJTWEemC09f0MxYkRg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGDPRDataConsent1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SQd7EJTWEemC09f0MxYkRg")]
public partial class GDPRDataConsent1CodeDropdownSource : EnumMetadataManager<GDPRDataConsent1Code,IGDPRDataConsent1CodeDropdownRow,GDPRDataConsent1CodeDropdownRow>
{
    public GDPRDataConsent1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GDPRDataConsent1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
