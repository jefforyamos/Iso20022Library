﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnitOfMeasure11Code.  ISO2002 ID# _tQTn4KoaEemdLtwzt4CWxg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the unit of measure by means of a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tQTn4KoaEemdLtwzt4CWxg")]
[Description(@"Identifies the unit of measure by means of a code.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
public enum UnitOfMeasure11Code
{
    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as "Allowances".
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_vVGKIaoaEemdLtwzt4CWxg")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances,
    
    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as "AmountOfCurrency".
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_v15KEaoaEemdLtwzt4CWxg")]
    [Description(@"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.")]
    AmountOfCurrency,
    
    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as "Barrels".
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_wZXDgaoaEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels,
    
    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as "BillionCubicFeet".
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_xBTNQaoaEemdLtwzt4CWxg")]
    [Description(@"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.")]
    BillionCubicFeet,
    
    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as "BoardFeet".
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_yEg9waoaEemdLtwzt4CWxg")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet,
    
    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as "Bushels".
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_ymC9gaoaEemdLtwzt4CWxg")]
    [Description(@"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.")]
    Bushels,
    
    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as "CertifiedEmissionsReduction".
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_zOI4QaoaEemdLtwzt4CWxg")]
    [Description(@"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.")]
    CertifiedEmissionsReduction,
    
    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as "ClimateReserveTonnes".
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_0UyXQaoaEemdLtwzt4CWxg")]
    [Description(@"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.")]
    ClimateReserveTonnes,
    
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as "Kilogram".
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_HzwRYaobEemdLtwzt4CWxg")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram,
    
    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as "Piece".
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_IlFnsaobEemdLtwzt4CWxg")]
    [Description(@"Standard length of cloth, wallpaper, as an item for sale or amount of a substance.")]
    Piece,
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as "Ton".
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_JXnQ0aobEemdLtwzt4CWxg")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).")]
    Ton,
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as "Metre".
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_KgyfYaobEemdLtwzt4CWxg")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre,
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as "Inch".
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_LV_pEaobEemdLtwzt4CWxg")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch,
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as "Yard".
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_NFURoaobEemdLtwzt4CWxg")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard,
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "GBGallon".
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_OoulIaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon,
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as "Gram".
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_QPaPEaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram,
    
    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as "Centimetre".
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_Q_QXoaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre,
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as "SquareMetre".
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_SadxYaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre,
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as "Foot".
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_UXNK4aobEemdLtwzt4CWxg")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot,
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as "Mile".
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_Vd_z0aobEemdLtwzt4CWxg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile,
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as "SquareInch".
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_WMppkaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch,
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as "SquareFoot".
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_YKIp8aobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot,
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as "SquareMile".
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_Yy-LkaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile,
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "GBOunce".
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_angrUaobEemdLtwzt4CWxg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce,
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "USOunce".
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_bfs3kaobEemdLtwzt4CWxg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce,
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as "GBPint".
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_ca3fUaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint,
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as "USPint".
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_fJ-w8aobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint,
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "GBQuart".
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_hqV04aobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart,
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "USGallon".
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_jBhqQaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon,
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as "Millimetre".
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_jpoMEaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre,
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as "Kilometre".
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_l1tpIaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre,
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as "SquareYard".
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_mhr-UaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard,
    
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as "Acre".
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_nLkBwaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre,
    
    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as "Are".
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_nvB7MaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are,
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as "SquareMillimetre".
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_pU0NQaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre,
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as "SquareCentimetre".
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_rNF9gaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre,
    
    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as "Hectare".
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_sfqYoaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare,
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as "SquareKilometre".
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_tSCQwaobEemdLtwzt4CWxg")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre,
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as "MilliLitre".
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_uCnZIaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre,
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as "Centilitre".
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_v8YXIaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre,
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as "Litre".
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_xCkjIaobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre,
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as "Pound".
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_x5HwoaobEemdLtwzt4CWxg")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound,
    
    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as "CubicMeters".
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_6YrW4aobEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.")]
    CubicMeters,
    
    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as "Days".
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_63A4saobEemdLtwzt4CWxg")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days,
    
    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as "DryMetricTons".
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_8ZmFwaobEemdLtwzt4CWxg")]
    [Description(@"Unit of weight that is equal to the same mass value as a metric ton excluding moisture.")]
    DryMetricTons,
    
    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as "EnvironmentalCredit".
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_9GMtEaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).")]
    EnvironmentalCredit,
    
    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as "EnvironmentalOffset".
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_9eJTAaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.")]
    EnvironmentalOffset,
    
    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as "Hundredweight".
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("__Ds7kaobEemdLtwzt4CWxg")]
    [Description(@"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.")]
    Hundredweight,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as "KilowattDayCapacity".
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("__mffkaobEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.")]
    KilowattDayCapacity,
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as "KilowattHours".
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_AI_vsaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to the power consumption of one kilowatt during one hour.")]
    KilowattHours,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as "KilowattHoursCapacity".
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_BLwNMaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.")]
    KilowattHoursCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as "KilowattMinuteCapacity".
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_BswogaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.")]
    KilowattMinuteCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as "KilowattMonthCapacity".
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_DRubMaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.")]
    KilowattMonthCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as "KilowattYearCapacity".
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_Dih3UaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.")]
    KilowattYearCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as "MegawattDayCapacity".
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_EgiXsaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.")]
    MegawattDayCapacity,
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as "MegawattHours".
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_FxH10aocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure that is equal to the power consumption of one megawatt during one hour.")]
    MegawattHours,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as "MegawattHoursCapacity".
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_F5mcYaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.")]
    MegawattHoursCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as "MegawattMinuteCapacity".
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_IIy30aocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.")]
    MegawattMinuteCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as "MegawattMonthCapacity".
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_IiETcaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.")]
    MegawattMonthCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as "MegawattYearCapacity".
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_I1GkMaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.")]
    MegawattYearCapacity,
    
    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as "MetricTons".
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_SoSVgaocEemdLtwzt4CWxg")]
    [Description(@"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).")]
    MetricTons,
    
    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as "MillionBarrels".
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_Tfm_EaocEemdLtwzt4CWxg")]
    [Description(@"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.")]
    MillionBarrels,
    
    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as "OneMillionBTU".
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_T44asaocEemdLtwzt4CWxg")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU,
    
    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as "TroyOunces".
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_WulcgaocEemdLtwzt4CWxg")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces,
    
    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as "USHundredweight".
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_XMBmcaocEemdLtwzt4CWxg")]
    [Description(@"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.")]
    USHundredweight,
    
    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as "IndexPoint".
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_ZLKMoaocEemdLtwzt4CWxg")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint,
    
    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as "PrincipalWithRelationToDebtInstrument".
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_aMlNYaocEemdLtwzt4CWxg")]
    [Description(@"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).")]
    PrincipalWithRelationToDebtInstrument,
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as "DieselGallonEquivalent".
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_cwJWUaocEemdLtwzt4CWxg")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent,
    
    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as "TonsOfCarbonDioxide".
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_drUlIaocEemdLtwzt4CWxg")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide,
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as "GasolineGallonEquivalent".
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_ldYcgbQ-EemI67HK7aviyg")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent,
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "USQuart".
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_9cIUobQ-EemI67HK7aviyg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnitOfMeasure11CodeMetadataExtensions
{
    private static readonly UnitOfMeasure11CodeDropdownSource _dropdownSource = new UnitOfMeasure11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnitOfMeasure11CodeDropdownRow GetMetadata(this UnitOfMeasure11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


