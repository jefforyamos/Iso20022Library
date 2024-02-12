﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUnitOfMeasureCode.  ISO2002 ID# _KGEoLzNmEe2UWZuK9pqFtg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KGEoLzNmEe2UWZuK9pqFtg")]
[Description(@"Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalUnitOfMeasure1Code))]
public enum ExternalUnitOfMeasureCode
{
    /// <summary>
    /// Basic unit of mass in the SI system, 1000 grams.
    /// Encoded/decoded by serializers as "KILO".
    /// </summary>
    [EnumMember(Value = "KILO")]
    [IsoId("_KGFO8DNmEe2UWZuK9pqFtg")]
    [Description(@"Basic unit of mass in the SI system, 1000 grams.")]
    Kilogram,
    
    /// <summary>
    /// Standard length of cloth, wallpaper, as an item for sale or amount of a substance.
    /// Encoded/decoded by serializers as "PIEC".
    /// </summary>
    [EnumMember(Value = "PIEC")]
    [IsoId("_KGFO-jNmEe2UWZuK9pqFtg")]
    [Description(@"Standard length of cloth, wallpaper, as an item for sale or amount of a substance.")]
    Piece,
    
    /// <summary>
    /// Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).
    /// Encoded/decoded by serializers as "TONS".
    /// </summary>
    [EnumMember(Value = "TONS")]
    [IsoId("_KGFPIzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of weight, in Britain 2240lb (long ton)and in the US 2000lb (short ton).")]
    Ton,
    
    /// <summary>
    /// Unit of length in the metric system, equal to 39.37 inches.
    /// Encoded/decoded by serializers as "METR".
    /// </summary>
    [EnumMember(Value = "METR")]
    [IsoId("_KGFO4TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length in the metric system, equal to 39.37 inches.")]
    Metre,
    
    /// <summary>
    /// Measure of length equal to 2.54 cm.
    /// Encoded/decoded by serializers as "INCH".
    /// </summary>
    [EnumMember(Value = "INCH")]
    [IsoId("_KGFO5TNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of length equal to 2.54 cm.")]
    Inch,
    
    /// <summary>
    /// Unit of length equal to 3 feet or 0.9144 metre.
    /// Encoded/decoded by serializers as "YARD".
    /// </summary>
    [EnumMember(Value = "YARD")]
    [IsoId("_KGFPEjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 3 feet or 0.9144 metre.")]
    Yard,
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "GBGA".
    /// </summary>
    [EnumMember(Value = "GBGA")]
    [IsoId("_KGFPEDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    GBGallon,
    
    /// <summary>
    /// Unit of measure that is equal to a 1, 000th of a kilo.
    /// Encoded/decoded by serializers as "GRAM".
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_KGFPITNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to a 1, 000th of a kilo.")]
    Gram,
    
    /// <summary>
    /// Unit of measure that is equal to one hundredth of a metre.
    /// Encoded/decoded by serializers as "CMET".
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_KGFPGTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to one hundredth of a metre.")]
    Centimetre,
    
    /// <summary>
    /// Measure of a surface, one metre by one metre.
    /// Encoded/decoded by serializers as "SMET".
    /// </summary>
    [EnumMember(Value = "SMET")]
    [IsoId("_KGEoNzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one metre by one metre.")]
    SquareMetre,
    
    /// <summary>
    /// Unit of length equal to 1/3 yard.
    /// Encoded/decoded by serializers as "FOOT".
    /// </summary>
    [EnumMember(Value = "FOOT")]
    [IsoId("_KGFPDTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 1/3 yard.")]
    Foot,
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as "MILE".
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_KGFPFjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile,
    
    /// <summary>
    /// Measure of a surface, one inch by one inch.
    /// Encoded/decoded by serializers as "SQIN".
    /// </summary>
    [EnumMember(Value = "SQIN")]
    [IsoId("_KGFO_zNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one inch by one inch.")]
    SquareInch,
    
    /// <summary>
    /// Measure of a surface, one foot by one foot.
    /// Encoded/decoded by serializers as "SQFO".
    /// </summary>
    [EnumMember(Value = "SQFO")]
    [IsoId("_KGFO5jNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one foot by one foot.")]
    SquareFoot,
    
    /// <summary>
    /// Measure of a surface, one mile by one mile.
    /// Encoded/decoded by serializers as "SQMI".
    /// </summary>
    [EnumMember(Value = "SQMI")]
    [IsoId("_KGFPLzNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one mile by one mile.")]
    SquareMile,
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "GBOU".
    /// </summary>
    [EnumMember(Value = "GBOU")]
    [IsoId("_KGFPFDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    GBOunce,
    
    /// <summary>
    /// Unit of weight equal to a sixteenth of a pound.
    /// Encoded/decoded by serializers as "USOU".
    /// </summary>
    [EnumMember(Value = "USOU")]
    [IsoId("_KGFPJDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to a sixteenth of a pound.")]
    USOunce,
    
    /// <summary>
    /// Unit of volume that is equal to 568 cubic centimetres.
    /// Encoded/decoded by serializers as "GBPI".
    /// </summary>
    [EnumMember(Value = "GBPI")]
    [IsoId("_KGFPJzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 568 cubic centimetres.")]
    GBPint,
    
    /// <summary>
    /// Unit of volume that is equal to 473 cubic centimetres.
    /// Encoded/decoded by serializers as "USPI".
    /// </summary>
    [EnumMember(Value = "USPI")]
    [IsoId("_KGFPIjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 473 cubic centimetres.")]
    USPint,
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "GBQA".
    /// </summary>
    [EnumMember(Value = "GBQA")]
    [IsoId("_KGEoMTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    GBQuart,
    
    /// <summary>
    /// Unit of volume that is equal to 2 pints.
    /// Encoded/decoded by serializers as "USQA".
    /// </summary>
    [EnumMember(Value = "USQA")]
    [IsoId("_KGFPCjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 2 pints.")]
    USQuart,
    
    /// <summary>
    /// Unit of volume that is equal to 8 pints.
    /// Encoded/decoded by serializers as "USGA".
    /// </summary>
    [EnumMember(Value = "USGA")]
    [IsoId("_KGFPJjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 8 pints.")]
    USGallon,
    
    /// <summary>
    /// Unit of measure that is a thousandth of one metre.
    /// Encoded/decoded by serializers as "MMET".
    /// </summary>
    [EnumMember(Value = "MMET")]
    [IsoId("_KGFO9DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is a thousandth of one metre.")]
    Millimetre,
    
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as "KMET".
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_KGFPFTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre,
    
    /// <summary>
    /// Measure of a surface, one yard by one yard.
    /// Encoded/decoded by serializers as "SQYA".
    /// </summary>
    [EnumMember(Value = "SQYA")]
    [IsoId("_KGEoMDNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one yard by one yard.")]
    SquareYard,
    
    /// <summary>
    /// Unit of measure equal to 4, 840 square yards.
    /// Encoded/decoded by serializers as "ACRE".
    /// </summary>
    [EnumMember(Value = "ACRE")]
    [IsoId("_KGFPBDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure equal to 4, 840 square yards.")]
    Acre,
    
    /// <summary>
    /// Unit of measure equal to a 100 square meters.
    /// Encoded/decoded by serializers as "ARES".
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_KGFPCDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure equal to a 100 square meters.")]
    Are,
    
    /// <summary>
    /// Measure of a surface, one millimetre by one millimetre.
    /// Encoded/decoded by serializers as "SMIL".
    /// </summary>
    [EnumMember(Value = "SMIL")]
    [IsoId("_KGFO9jNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one millimetre by one millimetre.")]
    SquareMillimetre,
    
    /// <summary>
    /// Measure of a surface, one centimetre by one centimetre.
    /// Encoded/decoded by serializers as "SCMT".
    /// </summary>
    [EnumMember(Value = "SCMT")]
    [IsoId("_KGEoODNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one centimetre by one centimetre.")]
    SquareCentimetre,
    
    /// <summary>
    /// Unit of measure that is equal to 10, 000 square meters.
    /// Encoded/decoded by serializers as "HECT".
    /// </summary>
    [EnumMember(Value = "HECT")]
    [IsoId("_KGFPJTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to 10, 000 square meters.")]
    Hectare,
    
    /// <summary>
    /// Measure of a surface, one kilometre by one kilometre.
    /// Encoded/decoded by serializers as "SQKI".
    /// </summary>
    [EnumMember(Value = "SQKI")]
    [IsoId("_KGEoNTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a surface, one kilometre by one kilometre.")]
    SquareKilometre,
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as "MILI".
    /// </summary>
    [EnumMember(Value = "MILI")]
    [IsoId("_KGFO9TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    MilliLitre,
    
    /// <summary>
    /// Unit of volume that is equal to one hundredth of a litre.
    /// Encoded/decoded by serializers as "CELI".
    /// </summary>
    [EnumMember(Value = "CELI")]
    [IsoId("_KGFPMTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one hundredth of a litre.")]
    Centilitre,
    
    /// <summary>
    /// Unit of volume that is equal to a thousand cubic centimetres.
    /// Encoded/decoded by serializers as "LITR".
    /// </summary>
    [EnumMember(Value = "LITR")]
    [IsoId("_KGFO7TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to a thousand cubic centimetres.")]
    Litre,
    
    /// <summary>
    /// Unit of weight equal to 0.454 kilograms.
    /// Encoded/decoded by serializers as "PUND".
    /// </summary>
    [EnumMember(Value = "PUND")]
    [IsoId("_KGFPFzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to 0.454 kilograms.")]
    Pound,
    
    /// <summary>
    /// Amount of money deducted from a price or an amount due.
    /// Encoded/decoded by serializers as "ALOW".
    /// </summary>
    [EnumMember(Value = "ALOW")]
    [IsoId("_KGEoMjNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of money deducted from a price or an amount due.")]
    Allowances,
    
    /// <summary>
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.
    /// Encoded/decoded by serializers as "ACCY".
    /// </summary>
    [EnumMember(Value = "ACCY")]
    [IsoId("_KGFPGDNmEe2UWZuK9pqFtg")]
    [Description(@"Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217.")]
    AmountOfCurrency,
    
    /// <summary>
    /// Unit of volume that is equal to 42 US gallons.
    /// Encoded/decoded by serializers as "BARL".
    /// </summary>
    [EnumMember(Value = "BARL")]
    [IsoId("_KGFPADNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 42 US gallons.")]
    Barrels,
    
    /// <summary>
    /// Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.
    /// Encoded/decoded by serializers as "BCUF".
    /// </summary>
    [EnumMember(Value = "BCUF")]
    [IsoId("_KGFPBjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure for large volumes of natural gas equivalent to 28316846 cubic meters.")]
    BillionCubicFeet,
    
    /// <summary>
    /// Measure of length equal to 144 cubic inches.
    /// Encoded/decoded by serializers as "BDFT".
    /// </summary>
    [EnumMember(Value = "BDFT")]
    [IsoId("_KGFO6jNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of length equal to 144 cubic inches.")]
    BoardFeet,
    
    /// <summary>
    /// Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.
    /// Encoded/decoded by serializers as "BUSL".
    /// </summary>
    [EnumMember(Value = "BUSL")]
    [IsoId("_KGFO_DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight that is equal to 8 gallons. Mostly used for agricultural products with a specification of weight defined for each commodity differently.")]
    Bushels,
    
    /// <summary>
    /// Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.
    /// Encoded/decoded by serializers as "CEER".
    /// </summary>
    [EnumMember(Value = "CEER")]
    [IsoId("_KGFO_TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of emissions type (or carbon credits) issued by the Clean Development Mechanism (CDM) Executive Board for emission reductions achieved by CDM projects and verified by a DOE (Designated Operational Entity) under the rules of the Kyoto Protocol.")]
    CertifiedEmissionsReduction,
    
    /// <summary>
    /// Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.
    /// Encoded/decoded by serializers as "CLRT".
    /// </summary>
    [EnumMember(Value = "CLRT")]
    [IsoId("_KGFPGzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of offset credits used by the Climate Action Reserve. One Climate Reserve Tonne is equal to one metric ton of Greenhouse Gas (GHG) reduced/sequestered.")]
    ClimateReserveTonnes,
    
    /// <summary>
    /// Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.
    /// Encoded/decoded by serializers as "CBME".
    /// </summary>
    [EnumMember(Value = "CBME")]
    [IsoId("_KGEoNjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one meter in length, breadth and height or also equal to 1000 liters.")]
    CubicMeters,
    
    /// <summary>
    /// Unit of time that is equal to 24 hours.
    /// Encoded/decoded by serializers as "DAYS".
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_KGFPLTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of time that is equal to 24 hours.")]
    Days,
    
    /// <summary>
    /// Unit of weight that is equal to the same mass value as a metric ton excluding moisture.
    /// Encoded/decoded by serializers as "DMET".
    /// </summary>
    [EnumMember(Value = "DMET")]
    [IsoId("_KGFO6zNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight that is equal to the same mass value as a metric ton excluding moisture.")]
    DryMetricTons,
    
    /// <summary>
    /// Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).
    /// Encoded/decoded by serializers as "ENVC".
    /// </summary>
    [EnumMember(Value = "ENVC")]
    [IsoId("_KGFPBTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure for ownership of credit (or allowance) of carbon dioxide emission (in metric ton).")]
    EnvironmentalCredit,
    
    /// <summary>
    /// Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.
    /// Encoded/decoded by serializers as "ENVO".
    /// </summary>
    [EnumMember(Value = "ENVO")]
    [IsoId("_KGFO9zNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure for reduction of carbon dioxide emission (in metric ton) that may result in Environmental Credit.")]
    EnvironmentalOffset,
    
    /// <summary>
    /// Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.
    /// Encoded/decoded by serializers as "HUWG".
    /// </summary>
    [EnumMember(Value = "HUWG")]
    [IsoId("_KGF18DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight or mass of various values in the Imperial Unit System also known as quintal, cental or centum.")]
    Hundredweight,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.
    /// Encoded/decoded by serializers as "KWDC".
    /// </summary>
    [EnumMember(Value = "KWDC")]
    [IsoId("_KGFO5DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one day.")]
    KilowattDayCapacity,
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one kilowatt during one hour.
    /// Encoded/decoded by serializers as "KWHO".
    /// </summary>
    [EnumMember(Value = "KWHO")]
    [IsoId("_KGFPMDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to the power consumption of one kilowatt during one hour.")]
    KilowattHours,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.
    /// Encoded/decoded by serializers as "KWHC".
    /// </summary>
    [EnumMember(Value = "KWHC")]
    [IsoId("_KGFPEzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one hour.")]
    KilowattHoursCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.
    /// Encoded/decoded by serializers as "KMOC".
    /// </summary>
    [EnumMember(Value = "KMOC")]
    [IsoId("_KGF18TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one minute.")]
    KilowattMinuteCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.
    /// Encoded/decoded by serializers as "KWMC".
    /// </summary>
    [EnumMember(Value = "KWMC")]
    [IsoId("_KGFPBzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one month.")]
    KilowattMonthCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.
    /// Encoded/decoded by serializers as "KWYC".
    /// </summary>
    [EnumMember(Value = "KWYC")]
    [IsoId("_KGFO8TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000 watt in one year.")]
    KilowattYearCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.
    /// Encoded/decoded by serializers as "MWDC".
    /// </summary>
    [EnumMember(Value = "MWDC")]
    [IsoId("_KGFO6TNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one day.")]
    MegawattDayCapacity,
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one megawatt during one hour.
    /// Encoded/decoded by serializers as "MWHO".
    /// </summary>
    [EnumMember(Value = "MWHO")]
    [IsoId("_KGFO4DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to the power consumption of one megawatt during one hour.")]
    MegawattHours,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.
    /// Encoded/decoded by serializers as "MWHC".
    /// </summary>
    [EnumMember(Value = "MWHC")]
    [IsoId("_KGFPKDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one hour.")]
    MegawattHoursCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.
    /// Encoded/decoded by serializers as "MWMC".
    /// </summary>
    [EnumMember(Value = "MWMC")]
    [IsoId("_KGFPKjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one minute.")]
    MegawattMinuteCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.
    /// Encoded/decoded by serializers as "MMOC".
    /// </summary>
    [EnumMember(Value = "MMOC")]
    [IsoId("_KGFO8jNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one month.")]
    MegawattMonthCapacity,
    
    /// <summary>
    /// Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.
    /// Encoded/decoded by serializers as "MWYC".
    /// </summary>
    [EnumMember(Value = "MWYC")]
    [IsoId("_KGFO4zNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of the capacity of production of electric power equal to 1000000 watt in one year.")]
    MegawattYearCapacity,
    
    /// <summary>
    /// Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).
    /// Encoded/decoded by serializers as "TONE".
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_KGFPLjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of mass equal to 1000 kilograms; equivalent to approximately 2,204.6 pounds, 1.102 short tons (US) or 0.984 long tons (imperial).")]
    MetricTons,
    
    /// <summary>
    /// Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.
    /// Encoded/decoded by serializers as "MIBA".
    /// </summary>
    [EnumMember(Value = "MIBA")]
    [IsoId("_KGFPHDNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to 1 million barrels equivalent to 42.000.000 US gallons.")]
    MillionBarrels,
    
    /// <summary>
    /// Unit of measure of heat equal to one million British thermal unit (BTU).
    /// Encoded/decoded by serializers as "MBTU".
    /// </summary>
    [EnumMember(Value = "MBTU")]
    [IsoId("_KGFO7jNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of heat equal to one million British thermal unit (BTU).")]
    OneMillionBTU,
    
    /// <summary>
    /// Unit of weight equal to 31.1034768 grams. Used in precious metals.
    /// Encoded/decoded by serializers as "OZTR".
    /// </summary>
    [EnumMember(Value = "OZTR")]
    [IsoId("_KGFPKTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight equal to 31.1034768 grams. Used in precious metals.")]
    TroyOunces,
    
    /// <summary>
    /// Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.
    /// Encoded/decoded by serializers as "UCWT".
    /// </summary>
    [EnumMember(Value = "UCWT")]
    [IsoId("_KGFO8zNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of weight or mass of various values in the US Customary System also known as quintal, cental or centum. Equal to 100 lbs.")]
    USHundredweight,
    
    /// <summary>
    /// Decimal number used to calculate an amount or a price.
    /// Encoded/decoded by serializers as "IPNT".
    /// </summary>
    [EnumMember(Value = "IPNT")]
    [IsoId("_KGFO7DNmEe2UWZuK9pqFtg")]
    [Description(@"Decimal number used to calculate an amount or a price.")]
    IndexPoint,
    
    /// <summary>
    /// Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).
    /// Encoded/decoded by serializers as "PWRD".
    /// </summary>
    [EnumMember(Value = "PWRD")]
    [IsoId("_KGEoNDNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of money borrowed, or part of that amount which remains unpaid (excluding interest).")]
    PrincipalWithRelationToDebtInstrument,
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of diesel.
    /// Encoded/decoded by serializers as "DGEU".
    /// </summary>
    [EnumMember(Value = "DGEU")]
    [IsoId("_KGFO_jNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of fuel alternative equal to one gallon of diesel.")]
    DieselGallonEquivalent,
    
    /// <summary>
    /// Amount of fuel alternative equal to one gallon of gasoline.
    /// Encoded/decoded by serializers as "GGEU".
    /// </summary>
    [EnumMember(Value = "GGEU")]
    [IsoId("_KGFO5zNmEe2UWZuK9pqFtg")]
    [Description(@"Amount of fuel alternative equal to one gallon of gasoline.")]
    GasolineGallonEquivalent,
    
    /// <summary>
    /// Tons of carbon dioxide.
    /// Encoded/decoded by serializers as "TOCD".
    /// </summary>
    [EnumMember(Value = "TOCD")]
    [IsoId("_KGFPETNmEe2UWZuK9pqFtg")]
    [Description(@"Tons of carbon dioxide.")]
    TonsOfCarbonDioxide,
    
    /// <summary>
    /// Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.
    /// Encoded/decoded by serializers as "SHAS".
    /// </summary>
    [EnumMember(Value = "SHAS")]
    [IsoId("_KGFPCzNmEe2UWZuK9pqFtg")]
    [Description(@"Financial instrument that gives the owner right to dividends paid by a company and the most junior claim on the companies assets in the event of a bankruptcy.")]
    Shares,
    
    /// <summary>
    /// Unit of heat, often used a unit of measure for natural gas in the UK.
    /// Encoded/decoded by serializers as "THMS".
    /// </summary>
    [EnumMember(Value = "THMS")]
    [IsoId("_KGFPDzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of heat, often used a unit of measure for natural gas in the UK.")]
    Therms,
    
    /// <summary>
    /// Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.
    /// Encoded/decoded by serializers as "FUTU".
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_KGFPDDNmEe2UWZuK9pqFtg")]
    [Description(@"Exchange traded contract that defines an agreement to buy specific quantities of a commodity or financial instrument at an agreed time in the future.")]
    Future,
    
    /// <summary>
    /// Unit of measure that is equal to the power consumption of one Gigawatt during one hour.
    /// Encoded/decoded by serializers as "GWHO".
    /// </summary>
    [EnumMember(Value = "GWHO")]
    [IsoId("_KGFPHTNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure that is equal to the power consumption of one Gigawatt during one hour.")]
    GigawattHours,
    
    /// <summary>
    /// Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit.
    /// Encoded/decoded by serializers as "BRTU".
    /// </summary>
    [EnumMember(Value = "BRTU")]
    [IsoId("_KGFPHzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of measure of heat required to raise the temperature of one pound of water by one degree Fahrenheit.")]
    BritishThermalUnit,
    
    /// <summary>
    /// Indication of the unit of measurement.
    /// Encoded/decoded by serializers as "LOTS".
    /// </summary>
    [EnumMember(Value = "LOTS")]
    [IsoId("_KGFPGjNmEe2UWZuK9pqFtg")]
    [Description(@"Indication of the unit of measurement.")]
    Lot,
    
    /// <summary>
    /// Code for a bag.
    /// Encoded/decoded by serializers as "BAGG".
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_KGEoMzNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bag.")]
    Bag,
    
    /// <summary>
    /// Code for a bale.
    /// Encoded/decoded by serializers as "BALE".
    /// </summary>
    [EnumMember(Value = "BALE")]
    [IsoId("_KGFPKzNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bale.")]
    Bale,
    
    /// <summary>
    /// Code for a bottle.
    /// Encoded/decoded by serializers as "BOTL".
    /// </summary>
    [EnumMember(Value = "BOTL")]
    [IsoId("_KGFPLDNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a bottle.")]
    Bottle,
    
    /// <summary>
    /// Code for a box.
    /// Encoded/decoded by serializers as "BOXX".
    /// </summary>
    [EnumMember(Value = "BOXX")]
    [IsoId("_KGFPMjNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a box.")]
    Box,
    
    /// <summary>
    /// Code for a carton.
    /// Encoded/decoded by serializers as "CRTN".
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_KGFPIDNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a carton.")]
    Carton,
    
    /// <summary>
    /// Code for a container.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_KGFPATNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a container.")]
    Container,
    
    /// <summary>
    /// Code for a crate.
    /// Encoded/decoded by serializers as "CRAT".
    /// </summary>
    [EnumMember(Value = "CRAT")]
    [IsoId("_KGFPHjNmEe2UWZuK9pqFtg")]
    [Description(@"Code for a crate.")]
    Crate,
    
    /// <summary>
    /// Measure of a volume, one inch by one inch by one inch.
    /// Encoded/decoded by serializers as "CBIN".
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_KGFPAjNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of a volume, one inch by one inch by one inch.")]
    CubicInch,
    
    /// <summary>
    /// Unit of volume that is equal to one thousandth of a litre.
    /// Encoded/decoded by serializers as "CBML".
    /// </summary>
    [EnumMember(Value = "CBML")]
    [IsoId("_KGFO4jNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume that is equal to one thousandth of a litre.")]
    CubicMillimetre,
    
    /// <summary>
    /// Unit of volume equal to 2, 841 306 centilitre.
    /// Encoded/decoded by serializers as "GBFO".
    /// </summary>
    [EnumMember(Value = "GBFO")]
    [IsoId("_KGFPDjNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 2, 841 306 centilitre.")]
    GBFuildOunce,
    
    /// <summary>
    /// Measure of weight, in Britain 2240 lb (long ton).
    /// Encoded/decoded by serializers as "GBTN".
    /// </summary>
    [EnumMember(Value = "GBTN")]
    [IsoId("_KGFPCTNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of weight, in Britain 2240 lb (long ton).")]
    GBTon,
    
    /// <summary>
    /// Unit of volume equal to 158, 9873 litre.
    /// Encoded/decoded by serializers as "USBA".
    /// </summary>
    [EnumMember(Value = "USBA")]
    [IsoId("_KGFPAzNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 158, 9873 litre.")]
    USBarrel,
    
    /// <summary>
    /// Unit of volume equal to 2, 957353 centilitre.
    /// Encoded/decoded by serializers as "USFO".
    /// </summary>
    [EnumMember(Value = "USFO")]
    [IsoId("_KGFO6DNmEe2UWZuK9pqFtg")]
    [Description(@"Unit of volume equal to 2, 957353 centilitre.")]
    USFluidOunce,
    
    /// <summary>
    /// Measure of weight, in the US 2000 lb (short ton).
    /// Encoded/decoded by serializers as "USTN".
    /// </summary>
    [EnumMember(Value = "USTN")]
    [IsoId("_KGFO-zNmEe2UWZuK9pqFtg")]
    [Description(@"Measure of weight, in the US 2000 lb (short ton).")]
    USTon,
    
    /// <summary>
    /// Cooling degree day
    /// Encoded/decoded by serializers as "CDDA".
    /// </summary>
    [EnumMember(Value = "CDDA")]
    [IsoId("_KGFO7zNmEe2UWZuK9pqFtg")]
    [Description(@"Cooling degree day")]
    CoolingDegreeDay,
    
    /// <summary>
    /// Heating degree day
    /// Encoded/decoded by serializers as "HDDA".
    /// </summary>
    [EnumMember(Value = "HDDA")]
    [IsoId("_KGFO-TNmEe2UWZuK9pqFtg")]
    [Description(@"Heating degree day")]
    HeatingDegreeDay,
    
    /// <summary>
    /// Critical precipitation day
    /// Encoded/decoded by serializers as "CPDA".
    /// </summary>
    [EnumMember(Value = "CPDA")]
    [IsoId("_KGFO-DNmEe2UWZuK9pqFtg")]
    [Description(@"Critical precipitation day")]
    CriticalPrecipitationDay,
    
}
