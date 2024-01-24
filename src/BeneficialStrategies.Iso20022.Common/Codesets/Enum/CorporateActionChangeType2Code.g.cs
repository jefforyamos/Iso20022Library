﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionChangeType2Code.  ISO2002 ID# _bC8uFNp-Ed-ak6NoX_4Aeg_-1895645716.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of changes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bC8uFNp-Ed-ak6NoX_4Aeg_-1895645716")]
[Description(@"Specifies the type of changes.")]
[DerivedFrom(typeof(CorporateActionChangeTypeCode))]
public enum CorporateActionChangeType2Code
{
    /// <summary>
    /// Change from bearer into registered form.
    /// Encoded/decoded by serializers as "BERE".
    /// </summary>
    [EnumMember(Value = "BERE")]
    [IsoId("_bC8uFdp-Ed-ak6NoX_4Aeg_-1895645691")]
    [Description(@"Change from bearer into registered form.")]
    BearToRegistered = CorporateActionChangeTypeCode.BearToRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of all instruments into certificates.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bC8uFtp-Ed-ak6NoX_4Aeg_-1895645690")]
    [Description(@"Change of all instruments into certificates.")]
    Certificates = CorporateActionChangeTypeCode.Certificates, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from dematerialised into physical form.
    /// Encoded/decoded by serializers as "DEPH".
    /// </summary>
    [EnumMember(Value = "DEPH")]
    [IsoId("_bC8uF9p-Ed-ak6NoX_4Aeg_-1895645689")]
    [Description(@"Change from dematerialised into physical form.")]
    DematerialisedToPhysical = CorporateActionChangeTypeCode.DematerialisedToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global permanent to physical form.
    /// Encoded/decoded by serializers as "GPPH".
    /// </summary>
    [EnumMember(Value = "GPPH")]
    [IsoId("_bC8uGNp-Ed-ak6NoX_4Aeg_-1895645674")]
    [Description(@"Change from global permanent to physical form.")]
    GlobalPermanentToPhysical = CorporateActionChangeTypeCode.GlobalPermanentToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global temporary to global permanent form.
    /// Encoded/decoded by serializers as "GTGP".
    /// </summary>
    [EnumMember(Value = "GTGP")]
    [IsoId("_bC8uGdp-Ed-ak6NoX_4Aeg_-1895645673")]
    [Description(@"Change from global temporary to global permanent form.")]
    GlobalTemporaryToGlobalPermanent = CorporateActionChangeTypeCode.GlobalTemporaryToGlobalPermanent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global temporary to physical form.
    /// Encoded/decoded by serializers as "GTPH".
    /// </summary>
    [EnumMember(Value = "GTPH")]
    [IsoId("_bDF4ANp-Ed-ak6NoX_4Aeg_-1895645656")]
    [Description(@"Change from global temporary to physical form.")]
    GlobalTemporaryToPhysical = CorporateActionChangeTypeCode.GlobalTemporaryToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as "NAME".
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bDF4Adp-Ed-ak6NoX_4Aeg_-1895645655")]
    [Description(@"The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.")]
    Name = CorporateActionChangeTypeCode.Name, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from physical into dematerialised form.
    /// Encoded/decoded by serializers as "PHDE".
    /// </summary>
    [EnumMember(Value = "PHDE")]
    [IsoId("_bDF4Atp-Ed-ak6NoX_4Aeg_-1895645639")]
    [Description(@"Change from physical into dematerialised form.")]
    PhysicalToDematerialised = CorporateActionChangeTypeCode.PhysicalToDematerialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from registered into bearer form.
    /// Encoded/decoded by serializers as "REBE".
    /// </summary>
    [EnumMember(Value = "REBE")]
    [IsoId("_bDF4A9p-Ed-ak6NoX_4Aeg_-1895645621")]
    [Description(@"Change from registered into bearer form.")]
    RegisteredToBearer = CorporateActionChangeTypeCode.RegisteredToBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change in the terms of the security.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_bDF4BNp-Ed-ak6NoX_4Aeg_-1895645613")]
    [Description(@"Change in the terms of the security.")]
    Terms = CorporateActionChangeTypeCode.Terms, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionChangeType2CodeMetadataExtensions
{
    private static readonly CorporateActionChangeType2CodeDropdownSource _dropdownSource = new CorporateActionChangeType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionChangeType2CodeDropdownRow GetMetadata(this CorporateActionChangeType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


