﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnitOfMeasure6Code.  ISO2002 ID# _Yk8WsY-JEeWjH5rPPp5_bg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of measure of the item purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yk8WsY-JEeWjH5rPPp5_bg")]
[Description(@"Unit of measure of the item purchased.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
public enum UnitOfMeasure6Code
{
    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as "PIEC".
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_Yv-iAY-JEeWjH5rPPp5_bg")]
    [Description(@"Standard length of cloth, wallpaper, as an item for sale or amount of a substance.")]
    Piece = UnitOfMeasureCode.Piece, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as "TONS".
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_Yv-iA4-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).")]
    Ton = UnitOfMeasureCode.Ton, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as "FOOT".
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_Yv-iBY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot = UnitOfMeasureCode.Foot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "GBGA".
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_Yv-iB4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon = UnitOfMeasureCode.GBGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "USGA".
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_Yv-iCY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon = UnitOfMeasureCode.USGallon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as "GRAM".
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_Yv-iC4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram = UnitOfMeasureCode.Gram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as "INCH".
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_Yv-iDY-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch = UnitOfMeasureCode.Inch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as "KILO".
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_Yv-iD4-JEeWjH5rPPp5_bg")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram = UnitOfMeasureCode.Kilogram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as "PUND".
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_Yv-iEY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound = UnitOfMeasureCode.Pound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as "METR".
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_Yv-iE4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre = UnitOfMeasureCode.Metre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as "CMET".
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_Yv-iFY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre = UnitOfMeasureCode.Centimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as "MMET".
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_Yv-iF4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre = UnitOfMeasureCode.Millimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as "LITR".
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_Yv-iGY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre = UnitOfMeasureCode.Litre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as "CELI".
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_Yv-iG4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre = UnitOfMeasureCode.Centilitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as "MILI".
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_Yv-iHY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre = UnitOfMeasureCode.MilliLitre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "GBOU".
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_Yv-iH4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce = UnitOfMeasureCode.GBOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "USOU".
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_Yv-iIY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce = UnitOfMeasureCode.USOunce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "GBQA".
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_Yv-iI4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart = UnitOfMeasureCode.GBQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "USQA".
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_Yv-iJY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart = UnitOfMeasureCode.USQuart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as "GBPI".
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_Yv-iJ4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint = UnitOfMeasureCode.GBPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as "USPI".
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_Yv-iKY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint = UnitOfMeasureCode.USPint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as "MILE".
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_Yv-iK4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as "KMET".
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_Yv-iLY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as "YARD".
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_Yv-iL4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard = UnitOfMeasureCode.Yard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as "SQKI".
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_Yv-iMY-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre = UnitOfMeasureCode.SquareKilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as "HECT".
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_Yv-iM4-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare = UnitOfMeasureCode.Hectare, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as "ARES".
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_Yv-iNY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are = UnitOfMeasureCode.Are, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as "SMET".
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_Yv-iN4-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre = UnitOfMeasureCode.SquareMetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as "SCMT".
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_Yv-iOY-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre = UnitOfMeasureCode.SquareCentimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as "SMIL".
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_Yv-iO4-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre = UnitOfMeasureCode.SquareMillimetre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as "SQMI".
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_Yv-iPY-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile = UnitOfMeasureCode.SquareMile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as "SQYA".
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_Yv-iP4-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard = UnitOfMeasureCode.SquareYard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as "SQFO".
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_Yv-iQY-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot = UnitOfMeasureCode.SquareFoot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as "SQIN".
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_Yv-iQ4-JEeWjH5rPPp5_bg")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch = UnitOfMeasureCode.SquareInch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as "ACRE".
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_Yv-iRY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre = UnitOfMeasureCode.Acre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as "KWHO".
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_al4TsY-JEeWjH5rPPp5_bg")]
    [Description(@"Unit of measure that is equal to the power consumption of one kilowatt during one hour.")]
    KilowattHours = UnitOfMeasureCode.KilowattHours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as "DGEU".
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_cD6_AY-JEeWjH5rPPp5_bg")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent = UnitOfMeasureCode.DieselGallonEquivalent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as "GGEU".
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_dHYnIY-JEeWjH5rPPp5_bg")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent = UnitOfMeasureCode.GasolineGallonEquivalent, // same ordinal as derivation source for type conversions
    
}
