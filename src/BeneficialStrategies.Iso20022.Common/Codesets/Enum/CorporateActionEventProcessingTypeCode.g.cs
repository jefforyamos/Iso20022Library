﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventProcessingTypeCode.  ISO2002 ID# _bDij9dp-Ed-ak6NoX_4Aeg_-1352374921.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of event processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDij9dp-Ed-ak6NoX_4Aeg_-1352374921")]
[Description(@"Specifies the type of event processing.")]
[Derivations(typeof(CorporateActionEventProcessingType1Code))]
public enum CorporateActionEventProcessingTypeCode
{
    /// <summary>
    /// No debit or credit of resources.
    /// Encoded/decoded by serializers as "GENL".
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_bDij9tp-Ed-ak6NoX_4Aeg_-1333902672")]
    [Description(@"No debit or credit of resources.")]
    General,
    
    /// <summary>
    /// Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.
    /// Encoded/decoded by serializers as "DISN".
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_bDij99p-Ed-ak6NoX_4Aeg_-1333902641")]
    [Description(@"Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.")]
    Distribution,
    
    /// <summary>
    /// Underlying security will be debited and may be replaced by another resource (or resources).
    /// Encoded/decoded by serializers as "REOR".
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_bDij-Np-Ed-ak6NoX_4Aeg_-1333902640")]
    [Description(@"Underlying security will be debited and may be replaced by another resource (or resources).")]
    Reorganisation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventProcessingTypeCodeMetadataExtensions
{
    private static readonly CorporateActionEventProcessingTypeCodeDropdownSource _dropdownSource = new CorporateActionEventProcessingTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventProcessingTypeCodeDropdownRow GetMetadata(this CorporateActionEventProcessingTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


