﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeType8Code.  ISO2002 ID# _a9SK9Np-Ed-ak6NoX_4Aeg_-1551316006.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies charges linked to the conveyance of goods.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9SK9Np-Ed-ak6NoX_4Aeg_-1551316006")]
[Description(@"Identifies charges linked to the conveyance of goods.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType8Code
{
    /// <summary>
    /// Charge is for signature services.
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_a9SK9dp-Ed-ak6NoX_4Aeg_-1526379993")]
    [Description(@"Charge is for signature services.")]
    SignatureService = ChargeTypeCode.SignatureService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for storage of goods at destination.
    /// Encoded/decoded by serializers as "STDE".
    /// </summary>
    [EnumMember(Value = "STDE")]
    [IsoId("_a9SK9tp-Ed-ak6NoX_4Aeg_-1526379992")]
    [Description(@"Charge is for storage of goods at destination.")]
    StorageAtDestination = ChargeTypeCode.StorageAtDestination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for storage of goods at origin.
    /// Encoded/decoded by serializers as "STOR".
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_a9SK99p-Ed-ak6NoX_4Aeg_-1526379976")]
    [Description(@"Charge is for storage of goods at origin.")]
    StorageAtOrigin = ChargeTypeCode.StorageAtOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for packaging of goods.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a9SK-Np-Ed-ak6NoX_4Aeg_-1526379958")]
    [Description(@"Charge is for packaging of goods.")]
    Packaging = ChargeTypeCode.Packaging, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for pick-up of goods.
    /// Encoded/decoded by serializers as "PICK".
    /// </summary>
    [EnumMember(Value = "PICK")]
    [IsoId("_a9b78Np-Ed-ak6NoX_4Aeg_-1526379933")]
    [Description(@"Charge is for pick-up of goods.")]
    PickUp = ChargeTypeCode.PickUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for dangerous goods.
    /// Encoded/decoded by serializers as "DNGR".
    /// </summary>
    [EnumMember(Value = "DNGR")]
    [IsoId("_a9b78dp-Ed-ak6NoX_4Aeg_-1526379932")]
    [Description(@"Charge is for dangerous goods.")]
    DangerousGoodsFee = ChargeTypeCode.DangerousGoodsFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for security.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_a9b78tp-Ed-ak6NoX_4Aeg_-1526379916")]
    [Description(@"Charge is for security.")]
    SecurityCharge = ChargeTypeCode.SecurityCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is a premium for insurance.
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_a9b789p-Ed-ak6NoX_4Aeg_-1526379898")]
    [Description(@"Charge is a premium for insurance.")]
    InsurancePremium = ChargeTypeCode.InsurancePremium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for the collection of the freight.
    /// Encoded/decoded by serializers as "COLF".
    /// </summary>
    [EnumMember(Value = "COLF")]
    [IsoId("_a9b79Np-Ed-ak6NoX_4Aeg_-1526379873")]
    [Description(@"Charge is for the collection of the freight.")]
    CollectFreight = ChargeTypeCode.CollectFreight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for clearance and handling of goods at origin.
    /// Encoded/decoded by serializers as "CHOR".
    /// </summary>
    [EnumMember(Value = "CHOR")]
    [IsoId("_a9b79dp-Ed-ak6NoX_4Aeg_-1526379872")]
    [Description(@"Charge is for clearance and handling of goods at origin.")]
    ClearanceAndHandlingAtOrigin = ChargeTypeCode.ClearanceAndHandlingAtOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for clearance and handling of goods at destination.
    /// Encoded/decoded by serializers as "CHDE".
    /// </summary>
    [EnumMember(Value = "CHDE")]
    [IsoId("_a9b79tp-Ed-ak6NoX_4Aeg_-1526379856")]
    [Description(@"Charge is for clearance and handling of goods at destination.")]
    ClearanceAndHandlingAtDestination = ChargeTypeCode.ClearanceAndHandlingAtDestination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is an airway bill fee.
    /// Encoded/decoded by serializers as "AIRF".
    /// </summary>
    [EnumMember(Value = "AIRF")]
    [IsoId("_a9b799p-Ed-ak6NoX_4Aeg_-1526379838")]
    [Description(@"Charge is an airway bill fee.")]
    AirWayBillFee = ChargeTypeCode.AirWayBillFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is for transport.
    /// Encoded/decoded by serializers as "TRPT".
    /// </summary>
    [EnumMember(Value = "TRPT")]
    [IsoId("_a9b7-Np-Ed-ak6NoX_4Aeg_1348844149")]
    [Description(@"Charge is for transport.")]
    TransportCharges = ChargeTypeCode.TransportCharges, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeType8CodeMetadataExtensions
{
    private static readonly ChargeType8CodeDropdownSource _dropdownSource = new ChargeType8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeType8CodeDropdownRow GetMetadata(this ChargeType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


