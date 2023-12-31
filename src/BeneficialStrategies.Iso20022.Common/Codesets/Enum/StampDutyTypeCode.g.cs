﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StampDutyTypeCode.  ISO2002 ID# _ZPdXN9p-Ed-ak6NoX_4Aeg_930727871.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPdXN9p-Ed-ak6NoX_4Aeg_930727871")]
[Description(@"Specifies if the stamp duty is applicable.")]
[Derivations(typeof(StampDutyType2Code),typeof(StampDutyType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum StampDutyTypeCode
{
    /// <summary>
    /// SDRT paid outside of CSD on corporate action.
    /// Encoded/decoded by serializers as "SDRU".
    /// </summary>
    [EnumMember(Value = "SDRU")]
    [IsoId("_ZPdXONp-Ed-ak6NoX_4Aeg_999066501")]
    [Description(@"SDRT paid outside of CSD on corporate action.")]
    OutsideCSD,
    
    /// <summary>
    /// SDRT paid on another transaction.
    /// Encoded/decoded by serializers as "SDRT".
    /// </summary>
    [EnumMember(Value = "SDRT")]
    [IsoId("_ZPnIMNp-Ed-ak6NoX_4Aeg_999066531")]
    [Description(@"SDRT paid on another transaction.")]
    Paid,
    
    /// <summary>
    /// Stamp duty not applicable.
    /// Encoded/decoded by serializers as "SDRN".
    /// </summary>
    [EnumMember(Value = "SDRN")]
    [IsoId("_ZPnIMdp-Ed-ak6NoX_4Aeg_999066562")]
    [Description(@"Stamp duty not applicable.")]
    NotApplicable,
    
    /// <summary>
    /// Exempt, for any other reason.
    /// Encoded/decoded by serializers as "SDRQ".
    /// </summary>
    [EnumMember(Value = "SDRQ")]
    [IsoId("_ZPnIMtp-Ed-ak6NoX_4Aeg_999066810")]
    [Description(@"Exempt, for any other reason.")]
    Exemption,
    
    /// <summary>
    /// Stamps duty is applicable.
    /// Encoded/decoded by serializers as "ASTD".
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_oTfCx_piEeCG_oUHBFcYXA")]
    [Description(@"Stamps duty is applicable.")]
    Applicable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StampDutyTypeCodeMetadataExtensions
{
    private static readonly StampDutyTypeCodeDropdownSource _dropdownSource = new StampDutyTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStampDutyTypeCodeDropdownRow GetMetadata(this StampDutyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


