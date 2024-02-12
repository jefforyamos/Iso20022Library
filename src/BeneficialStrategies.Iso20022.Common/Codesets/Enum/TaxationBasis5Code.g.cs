﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxationBasis5Code.  ISO2002 ID# _pfehUDkTEeahTcrfPSjpxA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax or charge basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pfehUDkTEeahTcrfPSjpxA")]
[Description(@"Specifies the tax or charge basis.")]
[DerivedFrom(typeof(TaxationBasisCode))]
public enum TaxationBasis5Code
{
    /// <summary>
    /// Charge/tax basis is a lump sum.
    /// Encoded/decoded by serializers as "FLAT".
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_u1XA4TkTEeahTcrfPSjpxA")]
    [Description(@"Charge/tax basis is a lump sum.")]
    Flat = TaxationBasisCode.Flat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge/Commission/tax basis is based on the gross amount.
    /// Encoded/decoded by serializers as "GRAM".
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_u7wj0TkTEeahTcrfPSjpxA")]
    [Description(@"Charge/Commission/tax basis is based on the gross amount.")]
    GrossAmount = TaxationBasisCode.GrossAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge/commission/tax basis is based on the net amount.
    /// Encoded/decoded by serializers as "NEAM".
    /// </summary>
    [EnumMember(Value = "NEAM")]
    [IsoId("_vBjp0TkTEeahTcrfPSjpxA")]
    [Description(@"Charge/commission/tax basis is based on the net amount.")]
    NetAmount = TaxationBasisCode.NetAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge/tax basis is the price.
    /// Encoded/decoded by serializers as "NAVP".
    /// </summary>
    [EnumMember(Value = "NAVP")]
    [IsoId("_vNAr4TkTEeahTcrfPSjpxA")]
    [Description(@"Charge/tax basis is the price.")]
    NetAssetValuePrice = TaxationBasisCode.NetAssetValuePrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as "PERU".
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("_vbAEkTkTEeahTcrfPSjpxA")]
    [Description(@"Charges/tax basis is per unit of financial instrument.")]
    PerUnit = TaxationBasisCode.PerUnit, // same ordinal as derivation source for type conversions
    
}
