﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnitOfMeasure4Code.  ISO2002 ID# _Y3ne9dp-Ed-ak6NoX_4Aeg_735997635.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y3ne9dp-Ed-ak6NoX_4Aeg_735997635")]
[Description(@"Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.")]
[DerivedFrom(typeof(UnitOfMeasure2Code))]
public enum UnitOfMeasure4Code
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as "Kilogram".
    /// </summary>
    [EnumMember(Value = "KGM")]
    [IsoId("_Y3ne9tp-Ed-ak6NoX_4Aeg_735997667")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram,
    
    /// <summary>
    /// Unit of count defining the number of items regarded as separate units.
    /// Encoded/decoded by serializers as "Each".
    /// </summary>
    [EnumMember(Value = "EA")]
    [IsoId("_Y3ne99p-Ed-ak6NoX_4Aeg_735997668")]
    [Description(@"Unit of count defining the number of items regarded as separate units.")]
    Each,
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton).
    /// Encoded/decoded by serializers as "GBTon".
    /// </summary>
    [EnumMember(Value = "LTN")]
    [IsoId("_Y3ne-Np-Ed-ak6NoX_4Aeg_735997697")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton).")]
    GBTon,
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as "Metre".
    /// </summary>
    [EnumMember(Value = "MTR")]
    [IsoId("_Y3ne-dp-Ed-ak6NoX_4Aeg_735997975")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre,
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as "Inch".
    /// </summary>
    [EnumMember(Value = "INH")]
    [IsoId("_Y3xP8Np-Ed-ak6NoX_4Aeg_735998006")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch,
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as "Yard".
    /// </summary>
    [EnumMember(Value = "LY")]
    [IsoId("_Y3xP8dp-Ed-ak6NoX_4Aeg_735998007")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard,
    
    /// <summary>
    /// Unit of volume that is equal to 8 GB pints.
    /// Encoded/decoded by serializers as "GBGallon".
    /// </summary>
    [EnumMember(Value = "GLI")]
    [IsoId("_Y3xP8tp-Ed-ak6NoX_4Aeg_735998036")]
    [Description(@"Unit of volume that is equal to 8 GB pints.")]
    GBGallon,
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as "Gram".
    /// </summary>
    [EnumMember(Value = "GRM")]
    [IsoId("_Y3xP89p-Ed-ak6NoX_4Aeg_735998037")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram,
    
    /// <summary>
    /// One 100th part of a metre.
    /// Encoded/decoded by serializers as "Centimetre".
    /// </summary>
    [EnumMember(Value = "CMT")]
    [IsoId("_Y3xP9Np-Ed-ak6NoX_4Aeg_735998067")]
    [Description(@"One 100th part of a metre.")]
    Centimetre,
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as "SquareMetre".
    /// </summary>
    [EnumMember(Value = "MTK")]
    [IsoId("_Y3xP9dp-Ed-ak6NoX_4Aeg_735998098")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre,
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as "Foot".
    /// </summary>
    [EnumMember(Value = "FOT")]
    [IsoId("_Y3xP9tp-Ed-ak6NoX_4Aeg_735998099")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot,
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as "Mile".
    /// </summary>
    [EnumMember(Value = "1A")]
    [IsoId("_Y3xP99p-Ed-ak6NoX_4Aeg_735998128")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile,
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as "SquareInch".
    /// </summary>
    [EnumMember(Value = "INK")]
    [IsoId("_Y37A8Np-Ed-ak6NoX_4Aeg_735998129")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch,
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as "SquareFoot".
    /// </summary>
    [EnumMember(Value = "FTK")]
    [IsoId("_Y37A8dp-Ed-ak6NoX_4Aeg_735998159")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot,
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as "SquareMile".
    /// </summary>
    [EnumMember(Value = "MIK")]
    [IsoId("_Y37A8tp-Ed-ak6NoX_4Aeg_735998190")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile,
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "Ounce".
    /// </summary>
    [EnumMember(Value = "ONZ")]
    [IsoId("_Y37A89p-Ed-ak6NoX_4Aeg_735998191")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    Ounce,
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as "GBPint".
    /// </summary>
    [EnumMember(Value = "PTI")]
    [IsoId("_Y37A9Np-Ed-ak6NoX_4Aeg_735998213")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint,
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as "USPint".
    /// </summary>
    [EnumMember(Value = "PT")]
    [IsoId("_Y37A9dp-Ed-ak6NoX_4Aeg_735998221")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint,
    
    /// <summary>
    /// Unit of volume that is equal to 2 GB pints.
    /// Encoded/decoded by serializers as "GBQuart".
    /// </summary>
    [EnumMember(Value = "QTI")]
    [IsoId("_Y37A9tp-Ed-ak6NoX_4Aeg_735998244")]
    [Description(@"Unit of volume that is equal to 2 GB pints.")]
    GBQuart,
    
    /// <summary>
    /// Unit of volume that is equal to 2 US pints.
    /// Encoded/decoded by serializers as "USQuart".
    /// </summary>
    [EnumMember(Value = "QT")]
    [IsoId("_Y37A99p-Ed-ak6NoX_4Aeg_735998252")]
    [Description(@"Unit of volume that is equal to 2 US pints.")]
    USQuart,
    
    /// <summary>
    /// Unit of volume that is equal to 8 US pints.
    /// Encoded/decoded by serializers as "USGallon".
    /// </summary>
    [EnumMember(Value = "GLL")]
    [IsoId("_Y37A-Np-Ed-ak6NoX_4Aeg_735998253")]
    [Description(@"Unit of volume that is equal to 8 US pints.")]
    USGallon,
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as "Millimetre".
    /// </summary>
    [EnumMember(Value = "MMT")]
    [IsoId("_Y37A-dp-Ed-ak6NoX_4Aeg_735998491")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre,
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as "Kilometre".
    /// </summary>
    [EnumMember(Value = "KTM")]
    [IsoId("_Y4EK4Np-Ed-ak6NoX_4Aeg_735998492")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre,
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as "SquareYard".
    /// </summary>
    [EnumMember(Value = "YDK")]
    [IsoId("_Y4EK4dp-Ed-ak6NoX_4Aeg_735998500")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard,
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as "SquareMillimetre".
    /// </summary>
    [EnumMember(Value = "MMK")]
    [IsoId("_Y4EK4tp-Ed-ak6NoX_4Aeg_735998522")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre,
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as "SquareCentimetre".
    /// </summary>
    [EnumMember(Value = "CMK")]
    [IsoId("_Y4EK49p-Ed-ak6NoX_4Aeg_735998523")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre,
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as "SquareKilometre".
    /// </summary>
    [EnumMember(Value = "KMK")]
    [IsoId("_Y4EK5Np-Ed-ak6NoX_4Aeg_735998531")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre,
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as "CubicMillimetre".
    /// </summary>
    [EnumMember(Value = "MMQ")]
    [IsoId("_Y4EK5dp-Ed-ak6NoX_4Aeg_735998553")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre,
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as "Centilitre".
    /// </summary>
    [EnumMember(Value = "CLT")]
    [IsoId("_Y4EK5tp-Ed-ak6NoX_4Aeg_735998554")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre,
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as "Litre".
    /// </summary>
    [EnumMember(Value = "LTR")]
    [IsoId("_Y4EK59p-Ed-ak6NoX_4Aeg_735998562")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre,
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as "Pound".
    /// </summary>
    [EnumMember(Value = "LBR")]
    [IsoId("_Y4EK6Np-Ed-ak6NoX_4Aeg_735998583")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound,
    
    /// <summary>
    /// Measure of weight, in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as "USTon".
    /// </summary>
    [EnumMember(Value = "STN")]
    [IsoId("_Y4EK6dp-Ed-ak6NoX_4Aeg_735998584")]
    [Description(@"Measure of weight, in the US 2000lb (short ton).")]
    USTon,
    
    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as "USBarrel".
    /// </summary>
    [EnumMember(Value = "BLL")]
    [IsoId("_Y4EK6tp-Ed-ak6NoX_4Aeg_735998585")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel,
    
    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as "Box".
    /// </summary>
    [EnumMember(Value = "BX")]
    [IsoId("_Y4N74Np-Ed-ak6NoX_4Aeg_735998614")]
    [Description(@"Code for a box.")]
    Box,
    
    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as "Bottle".
    /// </summary>
    [EnumMember(Value = "BO")]
    [IsoId("_Y4N74dp-Ed-ak6NoX_4Aeg_735998615")]
    [Description(@"Code for a bottle.")]
    Bottle,
    
    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as "Carton".
    /// </summary>
    [EnumMember(Value = "CT")]
    [IsoId("_Y4N74tp-Ed-ak6NoX_4Aeg_735998616")]
    [Description(@"Code for a carton.")]
    Carton,
    
    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as "Container".
    /// </summary>
    [EnumMember(Value = "CH")]
    [IsoId("_Y4N749p-Ed-ak6NoX_4Aeg_736918616")]
    [Description(@"Code for a container.")]
    Container,
    
    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as "Crate".
    /// </summary>
    [EnumMember(Value = "CR")]
    [IsoId("_Y4N75Np-Ed-ak6NoX_4Aeg_736918625")]
    [Description(@"Code for a crate.")]
    Crate,
    
    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as "CubicInch".
    /// </summary>
    [EnumMember(Value = "INQ")]
    [IsoId("_Y4N75dp-Ed-ak6NoX_4Aeg_736918626")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch,
    
    /// <summary>
    /// Measure of a volume, one meter by one meter by one meter.
    /// Encoded/decoded by serializers as "CubicMeter".
    /// </summary>
    [EnumMember(Value = "MTQ")]
    [IsoId("_Y4N75tp-Ed-ak6NoX_4Aeg_736918646")]
    [Description(@"Measure of a volume, one meter by one meter by one meter.")]
    CubicMeter,
    
    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as "GBFluidOunce".
    /// </summary>
    [EnumMember(Value = "OZI")]
    [IsoId("_Y4N759p-Ed-ak6NoX_4Aeg_736918647")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFluidOunce,
    
    /// <summary>
    /// Unit of volume equal to 2, 957 353 centilitre.
    /// Encoded/decoded by serializers as "USFluidOunce".
    /// </summary>
    [EnumMember(Value = "OZA")]
    [IsoId("_Y4N76Np-Ed-ak6NoX_4Aeg_736918656")]
    [Description(@"Unit of volume equal to 2, 957 353 centilitre.")]
    USFluidOunce,
    
    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as "Bag".
    /// </summary>
    [EnumMember(Value = "BG")]
    [IsoId("_Y4N76dp-Ed-ak6NoX_4Aeg_736918657")]
    [Description(@"Code for a bag.")]
    Bag,
    
    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as "Bale".
    /// </summary>
    [EnumMember(Value = "BL")]
    [IsoId("_Y4XF0Np-Ed-ak6NoX_4Aeg_736918677")]
    [Description(@"Code for a bale.")]
    Bale,
    
    /// <summary>
    /// Measure of weight, equal to 1000 kilograms.
    /// Encoded/decoded by serializers as "MetricTon".
    /// </summary>
    [EnumMember(Value = "TNE")]
    [IsoId("_Y4XF0dp-Ed-ak6NoX_4Aeg_1231928752")]
    [Description(@"Measure of weight, equal to 1000 kilograms.")]
    MetricTon,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnitOfMeasure4CodeMetadataExtensions
{
    private static readonly UnitOfMeasure4CodeDropdownSource _dropdownSource = new UnitOfMeasure4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnitOfMeasure4CodeDropdownRow GetMetadata(this UnitOfMeasure4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


