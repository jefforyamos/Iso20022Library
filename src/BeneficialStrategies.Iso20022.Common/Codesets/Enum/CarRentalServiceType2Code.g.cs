﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CarRentalServiceType2Code.  ISO2002 ID# _2ILF4PS_Eeife6veM7daYw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Car rental service in addition to main car rental.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2ILF4PS_Eeife6veM7daYw")]
[Description(@"Car rental service in addition to main car rental.")]
[DerivedFrom(typeof(CarRentalServiceTypeCode))]
public enum CarRentalServiceType2Code
{
    /// <summary>
    /// Rental amount adjustment
    /// Encoded/decoded by serializers as "ADJM".
    /// </summary>
    [EnumMember(Value = "ADJM")]
    [IsoId("_5HU-ofS_Eeife6veM7daYw")]
    [Description(@"Rental amount adjustment")]
    Adjustment = CarRentalServiceTypeCode.Adjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorised amount
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_5NX8QfS_Eeife6veM7daYw")]
    [Description(@"Authorised amount")]
    Authorised = CarRentalServiceTypeCode.Authorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Baby seat.
    /// Encoded/decoded by serializers as "BAST".
    /// </summary>
    [EnumMember(Value = "BAST")]
    [IsoId("_5ThAgfS_Eeife6veM7daYw")]
    [Description(@"Baby seat.")]
    BabySeat = CarRentalServiceTypeCode.BabySeat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra charges due to the need to clean the car.
    /// Encoded/decoded by serializers as "CLEA".
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_5q_sYfS_Eeife6veM7daYw")]
    [Description(@"Extra charges due to the need to clean the car.")]
    Cleaning = CarRentalServiceTypeCode.Cleaning, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for damages
    /// Encoded/decoded by serializers as "DMGS".
    /// </summary>
    [EnumMember(Value = "DMGS")]
    [IsoId("_-lIrIfS_Eeife6veM7daYw")]
    [Description(@"Charge for damages")]
    Damage = CarRentalServiceTypeCode.Damage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for delivery of rental vehicle
    /// Encoded/decoded by serializers as "DLVR".
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_-rbgYfS_Eeife6veM7daYw")]
    [Description(@"Charge for delivery of rental vehicle")]
    Delivery = CarRentalServiceTypeCode.Delivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Drop off charges
    /// Encoded/decoded by serializers as "DPOF".
    /// </summary>
    [EnumMember(Value = "DPOF")]
    [IsoId("_-3p-gfS_Eeife6veM7daYw")]
    [Description(@"Drop off charges")]
    DropOff = CarRentalServiceTypeCode.DropOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entertainment
    /// Encoded/decoded by serializers as "ENTE".
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_A288wfTAEeife6veM7daYw")]
    [Description(@"Entertainment")]
    Entertainment = CarRentalServiceTypeCode.Entertainment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra charges
    /// Encoded/decoded by serializers as "EXTC".
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_A92O8fTAEeife6veM7daYw")]
    [Description(@"Extra charges")]
    ExtraCharges = CarRentalServiceTypeCode.ExtraCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for extra days
    /// Encoded/decoded by serializers as "EXDY".
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("_BCCycfTAEeife6veM7daYw")]
    [Description(@"Charges for extra days")]
    ExtraDays = CarRentalServiceTypeCode.ExtraDays, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for additional distance
    /// Encoded/decoded by serializers as "EXDI".
    /// </summary>
    [EnumMember(Value = "EXDI")]
    [IsoId("_BIfYsfTAEeife6veM7daYw")]
    [Description(@"Charges for additional distance")]
    ExtraDistance = CarRentalServiceTypeCode.ExtraDistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for extra hours
    /// Encoded/decoded by serializers as "EXHR".
    /// </summary>
    [EnumMember(Value = "EXHR")]
    [IsoId("_BOTs0fTAEeife6veM7daYw")]
    [Description(@"Charges for extra hours")]
    ExtraHours = CarRentalServiceTypeCode.ExtraHours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Police and related fines or violation fees reinvoiced by vehicle rental company.
    /// Encoded/decoded by serializers as "FINE".
    /// </summary>
    [EnumMember(Value = "FINE")]
    [IsoId("_CvKbkfTAEeife6veM7daYw")]
    [Description(@"Police and related fines or violation fees reinvoiced by vehicle rental company.")]
    Fines = CarRentalServiceTypeCode.Fines, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as "FUEL".
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_C3YjcfTAEeife6veM7daYw")]
    [Description(@"Fuel")]
    Fuel = CarRentalServiceTypeCode.Fuel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Garage
    /// Encoded/decoded by serializers as "GARA".
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_FC3jkfTAEeife6veM7daYw")]
    [Description(@"Garage")]
    Garage = CarRentalServiceTypeCode.Garage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global Positioning System (GPS)
    /// Encoded/decoded by serializers as "GPSY".
    /// </summary>
    [EnumMember(Value = "GPSY")]
    [IsoId("_FMhO0fTAEeife6veM7daYw")]
    [Description(@"Global Positioning System (GPS)")]
    GlobalPositioningSystem = CarRentalServiceTypeCode.GlobalPositioningSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_GU3W8fTAEeife6veM7daYw")]
    [Description(@"Insurance")]
    Insurance = CarRentalServiceTypeCode.Insurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Car returned late.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_GyOoYfTAEeife6veM7daYw")]
    [Description(@"Car returned late.")]
    LateReturn = CarRentalServiceTypeCode.LateReturn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for liability insurance
    /// Encoded/decoded by serializers as "LIIN".
    /// </summary>
    [EnumMember(Value = "LIIN")]
    [IsoId("_G5ixUfTAEeife6veM7daYw")]
    [Description(@"Charges for liability insurance")]
    LiabilityInsurance = CarRentalServiceTypeCode.LiabilityInsurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for Loss Damage Insurance
    /// Encoded/decoded by serializers as "LDIN".
    /// </summary>
    [EnumMember(Value = "LDIN")]
    [IsoId("_G9mx8fTAEeife6veM7daYw")]
    [Description(@"Charges for Loss Damage Insurance")]
    LossDamageInsurance = CarRentalServiceTypeCode.LossDamageInsurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous charges
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_IGXw0fTAEeife6veM7daYw")]
    [Description(@"Miscellaneous charges")]
    Miscellaneous = CarRentalServiceTypeCode.Miscellaneous, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for navigation system
    /// Encoded/decoded by serializers as "NAVI".
    /// </summary>
    [EnumMember(Value = "NAVI")]
    [IsoId("_IP1O0fTAEeife6veM7daYw")]
    [Description(@"Charges for navigation system")]
    Navigation = CarRentalServiceTypeCode.Navigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer no-show charges.
    /// Encoded/decoded by serializers as "NOSH".
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_ITkfUfTAEeife6veM7daYw")]
    [Description(@"Customer no-show charges.")]
    NoShow = CarRentalServiceTypeCode.NoShow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Drop-off charges.
    /// Encoded/decoded by serializers as "ONEW".
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_ImWRYfTAEeife6veM7daYw")]
    [Description(@"Drop-off charges.")]
    OneWay = CarRentalServiceTypeCode.OneWay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_I1-o0fTAEeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational = CarRentalServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JMtt0fTAEeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate = CarRentalServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Parking charges.
    /// Encoded/decoded by serializers as "PARK".
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_KW9TYfTAEeife6veM7daYw")]
    [Description(@"Parking charges.")]
    Parking = CarRentalServiceTypeCode.Parking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Personal Accident Insurance
    /// Encoded/decoded by serializers as "PRIN".
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_KqSfEfTAEeife6veM7daYw")]
    [Description(@"Personal Accident Insurance")]
    PersonalAccidentInsurance = CarRentalServiceTypeCode.PersonalAccidentInsurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Personal Effects Insurance
    /// Encoded/decoded by serializers as "PFIN".
    /// </summary>
    [EnumMember(Value = "PFIN")]
    [IsoId("_K6FOkfTAEeife6veM7daYw")]
    [Description(@"Personal Effects Insurance")]
    PersonalEffectsInsurance = CarRentalServiceTypeCode.PersonalEffectsInsurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On-board telephone service.
    /// Encoded/decoded by serializers as "PHON".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_LHLPYfTAEeife6veM7daYw")]
    [Description(@"On-board telephone service.")]
    Phone = CarRentalServiceTypeCode.Phone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for regular distance
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_LO95cfTAEeife6veM7daYw")]
    [Description(@"Charges for regular distance")]
    RegularDistance = CarRentalServiceTypeCode.RegularDistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra charges due to smoking in the car.
    /// Encoded/decoded by serializers as "SMOK".
    /// </summary>
    [EnumMember(Value = "SMOK")]
    [IsoId("_MQ6eofTAEeife6veM7daYw")]
    [Description(@"Extra charges due to smoking in the car.")]
    Smoking = CarRentalServiceTypeCode.Smoking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charges for tolls
    /// Encoded/decoded by serializers as "TOLL".
    /// </summary>
    [EnumMember(Value = "TOLL")]
    [IsoId("_Mrgv8fTAEeife6veM7daYw")]
    [Description(@"Charges for tolls")]
    Tolls = CarRentalServiceTypeCode.Tolls, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra charges due to car towing.
    /// Encoded/decoded by serializers as "TOWI".
    /// </summary>
    [EnumMember(Value = "TOWI")]
    [IsoId("_M3YowfTAEeife6veM7daYw")]
    [Description(@"Extra charges due to car towing.")]
    Towing = CarRentalServiceTypeCode.Towing, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CarRentalServiceType2CodeMetadataExtensions
{
    private static readonly CarRentalServiceType2CodeDropdownSource _dropdownSource = new CarRentalServiceType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICarRentalServiceType2CodeDropdownRow GetMetadata(this CarRentalServiceType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


