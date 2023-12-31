﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralType6Code.  ISO2002 ID# _p0PnYPJUEei775R97f5g5A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p0PnYPJUEei775R97f5g5A")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType6Code
{
    /// <summary>
    /// Collateral type is a bank guarantee.
    /// Encoded/decoded by serializers as "BankGuarantee".
    /// </summary>
    [EnumMember(Value = "GBBK")]
    [IsoId("_tMy3kfJUEei775R97f5g5A")]
    [Description(@"Collateral type is a bank guarantee.")]
    BankGuarantee,
    
    /// <summary>
    /// Collateral type is bonds.
    /// Encoded/decoded by serializers as "Bond".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_tRaR0PJUEei775R97f5g5A")]
    [Description(@"Collateral type is bonds.")]
    Bond,
    
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_tWUnAfJUEei775R97f5g5A")]
    [Description(@"Collateral type is cash.")]
    Cash,
    
    /// <summary>
    /// Collateral type is commodities.
    /// Encoded/decoded by serializers as "Commodity".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_tbOVIfJUEei775R97f5g5A")]
    [Description(@"Collateral type is commodities.")]
    Commodity,
    
    /// <summary>
    /// Collateral type is an insurance contract.
    /// Encoded/decoded by serializers as "Insurance".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_th0FUfJUEei775R97f5g5A")]
    [Description(@"Collateral type is an insurance contract.")]
    Insurance,
    
    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as "LetterOfCredit".
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_tnt5AfJUEei775R97f5g5A")]
    [Description(@"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking.")]
    LetterOfCredit,
    
    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tuSbEfJUEei775R97f5g5A")]
    [Description(@"Other assets that could be used as collateral.")]
    Other,
    
    /// <summary>
    /// Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.
    /// Encoded/decoded by serializers as "PhysicalEntities".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_t0UKkfJUEei775R97f5g5A")]
    [Description(@"Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.")]
    PhysicalEntities,
    
    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as "Securities".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_t551MfJUEei775R97f5g5A")]
    [Description(@"Collateral type is securities.")]
    Securities,
    
    /// <summary>
    /// Collateral type is stock certificates.
    /// Encoded/decoded by serializers as "StockCertificate".
    /// </summary>
    [EnumMember(Value = "STCF")]
    [IsoId("_t-GYsfJUEei775R97f5g5A")]
    [Description(@"Collateral type is stock certificates.")]
    StockCertificate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralType6CodeMetadataExtensions
{
    private static readonly CollateralType6CodeDropdownSource _dropdownSource = new CollateralType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralType6CodeDropdownRow GetMetadata(this CollateralType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


