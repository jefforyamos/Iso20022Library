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
    /// Encoded/decoded by serializers as "Adjustment".
    /// </summary>
    [EnumMember(Value = "ADJM")]
    [IsoId("_5HU-ofS_Eeife6veM7daYw")]
    [Description(@"Rental amount adjustment")]
    Adjustment,
    
    /// <summary>
    /// Authorised amount
    /// Encoded/decoded by serializers as "Authorised".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_5NX8QfS_Eeife6veM7daYw")]
    [Description(@"Authorised amount")]
    Authorised,
    
    /// <summary>
    /// Baby seat.
    /// Encoded/decoded by serializers as "BabySeat".
    /// </summary>
    [EnumMember(Value = "BAST")]
    [IsoId("_5ThAgfS_Eeife6veM7daYw")]
    [Description(@"Baby seat.")]
    BabySeat,
    
    /// <summary>
    /// Extra charges due to the need to clean the car.
    /// Encoded/decoded by serializers as "Cleaning".
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_5q_sYfS_Eeife6veM7daYw")]
    [Description(@"Extra charges due to the need to clean the car.")]
    Cleaning,
    
    /// <summary>
    /// Charge for damages
    /// Encoded/decoded by serializers as "Damage".
    /// </summary>
    [EnumMember(Value = "DMGS")]
    [IsoId("_-lIrIfS_Eeife6veM7daYw")]
    [Description(@"Charge for damages")]
    Damage,
    
    /// <summary>
    /// Charge for delivery of rental vehicle
    /// Encoded/decoded by serializers as "Delivery".
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_-rbgYfS_Eeife6veM7daYw")]
    [Description(@"Charge for delivery of rental vehicle")]
    Delivery,
    
    /// <summary>
    /// Drop off charges
    /// Encoded/decoded by serializers as "DropOff".
    /// </summary>
    [EnumMember(Value = "DPOF")]
    [IsoId("_-3p-gfS_Eeife6veM7daYw")]
    [Description(@"Drop off charges")]
    DropOff,
    
    /// <summary>
    /// Entertainment
    /// Encoded/decoded by serializers as "Entertainment".
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_A288wfTAEeife6veM7daYw")]
    [Description(@"Entertainment")]
    Entertainment,
    
    /// <summary>
    /// Extra charges
    /// Encoded/decoded by serializers as "ExtraCharges".
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_A92O8fTAEeife6veM7daYw")]
    [Description(@"Extra charges")]
    ExtraCharges,
    
    /// <summary>
    /// Charges for extra days
    /// Encoded/decoded by serializers as "ExtraDays".
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("_BCCycfTAEeife6veM7daYw")]
    [Description(@"Charges for extra days")]
    ExtraDays,
    
    /// <summary>
    /// Charges for additional distance
    /// Encoded/decoded by serializers as "ExtraDistance".
    /// </summary>
    [EnumMember(Value = "EXDI")]
    [IsoId("_BIfYsfTAEeife6veM7daYw")]
    [Description(@"Charges for additional distance")]
    ExtraDistance,
    
    /// <summary>
    /// Charges for extra hours
    /// Encoded/decoded by serializers as "ExtraHours".
    /// </summary>
    [EnumMember(Value = "EXHR")]
    [IsoId("_BOTs0fTAEeife6veM7daYw")]
    [Description(@"Charges for extra hours")]
    ExtraHours,
    
    /// <summary>
    /// Police and related fines or violation fees reinvoiced by vehicle rental company.
    /// Encoded/decoded by serializers as "Fines".
    /// </summary>
    [EnumMember(Value = "FINE")]
    [IsoId("_CvKbkfTAEeife6veM7daYw")]
    [Description(@"Police and related fines or violation fees reinvoiced by vehicle rental company.")]
    Fines,
    
    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as "Fuel".
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_C3YjcfTAEeife6veM7daYw")]
    [Description(@"Fuel")]
    Fuel,
    
    /// <summary>
    /// Garage
    /// Encoded/decoded by serializers as "Garage".
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_FC3jkfTAEeife6veM7daYw")]
    [Description(@"Garage")]
    Garage,
    
    /// <summary>
    /// Global Positioning System (GPS)
    /// Encoded/decoded by serializers as "GlobalPositioningSystem".
    /// </summary>
    [EnumMember(Value = "GPSY")]
    [IsoId("_FMhO0fTAEeife6veM7daYw")]
    [Description(@"Global Positioning System (GPS)")]
    GlobalPositioningSystem,
    
    /// <summary>
    /// Insurance
    /// Encoded/decoded by serializers as "Insurance".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_GU3W8fTAEeife6veM7daYw")]
    [Description(@"Insurance")]
    Insurance,
    
    /// <summary>
    /// Car returned late.
    /// Encoded/decoded by serializers as "LateReturn".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_GyOoYfTAEeife6veM7daYw")]
    [Description(@"Car returned late.")]
    LateReturn,
    
    /// <summary>
    /// Charges for liability insurance
    /// Encoded/decoded by serializers as "LiabilityInsurance".
    /// </summary>
    [EnumMember(Value = "LIIN")]
    [IsoId("_G5ixUfTAEeife6veM7daYw")]
    [Description(@"Charges for liability insurance")]
    LiabilityInsurance,
    
    /// <summary>
    /// Charges for Loss Damage Insurance
    /// Encoded/decoded by serializers as "LossDamageInsurance".
    /// </summary>
    [EnumMember(Value = "LDIN")]
    [IsoId("_G9mx8fTAEeife6veM7daYw")]
    [Description(@"Charges for Loss Damage Insurance")]
    LossDamageInsurance,
    
    /// <summary>
    /// Miscellaneous charges
    /// Encoded/decoded by serializers as "Miscellaneous".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_IGXw0fTAEeife6veM7daYw")]
    [Description(@"Miscellaneous charges")]
    Miscellaneous,
    
    /// <summary>
    /// Charges for navigation system
    /// Encoded/decoded by serializers as "Navigation".
    /// </summary>
    [EnumMember(Value = "NAVI")]
    [IsoId("_IP1O0fTAEeife6veM7daYw")]
    [Description(@"Charges for navigation system")]
    Navigation,
    
    /// <summary>
    /// Customer no-show charges.
    /// Encoded/decoded by serializers as "NoShow".
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_ITkfUfTAEeife6veM7daYw")]
    [Description(@"Customer no-show charges.")]
    NoShow,
    
    /// <summary>
    /// Drop-off charges.
    /// Encoded/decoded by serializers as "OneWay".
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_ImWRYfTAEeife6veM7daYw")]
    [Description(@"Drop-off charges.")]
    OneWay,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_I1-o0fTAEeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JMtt0fTAEeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate,
    
    /// <summary>
    /// Parking charges.
    /// Encoded/decoded by serializers as "Parking".
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_KW9TYfTAEeife6veM7daYw")]
    [Description(@"Parking charges.")]
    Parking,
    
    /// <summary>
    /// Personal Accident Insurance
    /// Encoded/decoded by serializers as "PersonalAccidentInsurance".
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_KqSfEfTAEeife6veM7daYw")]
    [Description(@"Personal Accident Insurance")]
    PersonalAccidentInsurance,
    
    /// <summary>
    /// Personal Effects Insurance
    /// Encoded/decoded by serializers as "PersonalEffectsInsurance".
    /// </summary>
    [EnumMember(Value = "PFIN")]
    [IsoId("_K6FOkfTAEeife6veM7daYw")]
    [Description(@"Personal Effects Insurance")]
    PersonalEffectsInsurance,
    
    /// <summary>
    /// On-board telephone service.
    /// Encoded/decoded by serializers as "Phone".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_LHLPYfTAEeife6veM7daYw")]
    [Description(@"On-board telephone service.")]
    Phone,
    
    /// <summary>
    /// Charges for regular distance
    /// Encoded/decoded by serializers as "RegularDistance".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_LO95cfTAEeife6veM7daYw")]
    [Description(@"Charges for regular distance")]
    RegularDistance,
    
    /// <summary>
    /// Extra charges due to smoking in the car.
    /// Encoded/decoded by serializers as "Smoking".
    /// </summary>
    [EnumMember(Value = "SMOK")]
    [IsoId("_MQ6eofTAEeife6veM7daYw")]
    [Description(@"Extra charges due to smoking in the car.")]
    Smoking,
    
    /// <summary>
    /// Charges for tolls
    /// Encoded/decoded by serializers as "Tolls".
    /// </summary>
    [EnumMember(Value = "TOLL")]
    [IsoId("_Mrgv8fTAEeife6veM7daYw")]
    [Description(@"Charges for tolls")]
    Tolls,
    
    /// <summary>
    /// Extra charges due to car towing.
    /// Encoded/decoded by serializers as "Towing".
    /// </summary>
    [EnumMember(Value = "TOWI")]
    [IsoId("_M3YowfTAEeife6veM7daYw")]
    [Description(@"Extra charges due to car towing.")]
    Towing,
    
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


